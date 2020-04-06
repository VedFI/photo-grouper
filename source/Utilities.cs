using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhotoGrouper
{
    public class Utilities
    {
        AppForm form;

        public Utilities(AppForm form)
        {
            this.form = form;
        }

        public void findDirectories(string root_path)
        {
            try
            {
                var directories = Directory.EnumerateDirectories(root_path, "*", SearchOption.AllDirectories);
                form.setProgressBar(0, directories.Count() + 1, 1);
                foreach (var path in directories)
                {
                    form.addLog("   " + path);
                    AppForm.directories.Push(path);
                    form.performStep();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void findNumberOfPhotos()
        {
            int result = 0;
            try
            {
                //subfolder aramak yerine tek tek bütün directorylerde aramak mantıklı olabilir.
                result = Directory.EnumerateFiles(AppForm.source_directory, "*", SearchOption.AllDirectories)
                    .Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg")).Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            AppForm.photos_count = result;
        }

        public void operation(int mode, string path, DateTime date)
        {
            string image_name = Path.GetFileNameWithoutExtension(path);
            string image_extension = Path.GetExtension(path);
            string datepath = "\\NON-GROUPABLE";
            if (date != DateTime.MinValue)
            {
                datepath = "\\" + date.Year.ToString() + "\\" + date.Month.ToString() + "-" + date.ToString("MMMM");
            }
            string destination_directory = AppForm.destination_directory + datepath;
            string destination_path = destination_directory + "\\" + image_name + image_extension;
            switch (mode)
            {
                case 0:
                    //do copy
                    try
                    {
                        if (!File.Exists(destination_path))
                        {
                            Directory.CreateDirectory(destination_directory);
                            File.Copy(path, destination_path);
                        }
                        else
                        {
                            while (File.Exists(destination_path)){
                                image_name += "-C";
                                destination_path = destination_directory + "\\" + image_name + image_extension;
                            }
                            File.Copy(path, destination_path);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case 1:
                    //do move
                    try
                    {
                        if (!File.Exists(destination_path))
                        {
                            Directory.CreateDirectory(destination_directory);
                            File.Move(path, destination_path);

                        }
                        else
                        {
                            while (File.Exists(destination_path))
                            {
                                image_name += "-C";
                                destination_path = destination_directory + "\\" + image_name + image_extension;
                            }
                            File.Move(path, destination_path);

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                default:
                    //error
                    Console.WriteLine("Impossible Error!");
                    break;
            }
            
        }


        public DateTime exifReader(Bitmap bitmap)
        {
            var r = new Regex(":");
            try
            {
                var ExifDateTimeOrig = bitmap.GetPropertyItem(0x9003);
                string value = r.Replace(Encoding.UTF8.GetString(ExifDateTimeOrig.Value), "-", 2);
                DateTime date = Convert.ToDateTime(value);
                //form.addLog("   ###");
                //form.addLog("   Exif read.");
                bitmap.Dispose();
                return date;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //form.addLog("   ###");
                //form.addLog("   Exif non read.");
                bitmap.Dispose();
                return DateTime.MinValue;
            }
        }

        public IEnumerable<string> findPhotos(string path)
        {
            var photo_list = Directory.EnumerateFiles(path)
                .Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg"));
            return photo_list;
        }

        public void corruptFile(int mode, string path)
        {
            string image_name = Path.GetFileNameWithoutExtension(path);
            string image_extension = Path.GetExtension(path);
            string destination_directory = AppForm.destination_directory +"\\CORRUPT";
            string destination_path = destination_directory + "\\" + image_name + image_extension;
            
            switch (mode)
            {
                case 0:
                    //do copy
                    try
                    {
                        if (!File.Exists(destination_path))
                        {
                            Directory.CreateDirectory(destination_directory);
                            File.Copy(path, destination_path);
                        }
                        else
                        {
                            while (File.Exists(destination_path))
                            {
                                image_name += "-C";
                                destination_path = destination_directory + "\\" + image_name + image_extension;
                            }
                            File.Copy(path, destination_path);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case 1:
                    //do move
                    try
                    {
                        if (!File.Exists(destination_path))
                        {
                            Directory.CreateDirectory(destination_directory);
                            File.Move(path, destination_path);

                        }
                        else
                        {
                            while (File.Exists(destination_path))
                            {
                                image_name += "-C";
                                destination_path = destination_directory + "\\" + image_name + image_extension;
                            }
                            File.Move(path, destination_path);

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                default:
                    //error
                    Console.WriteLine("Impossible Error!");
                    break;
            }
        }

        public void grouper(AppForm form)
        {
            form.setProgressBar(0, AppForm.photos_count, 1);
            int total_directories = AppForm.directories.Count;
            int i = 0,j=0;
            while (AppForm.directories.Count != 0)
            {
                i++;
                form.addLog("Directory " + i + "/" + total_directories);
                string path = AppForm.directories.Pop();
                IEnumerable<string> photo_list = findPhotos(path);
                int photos_in_current_dir = photo_list.Count();
                foreach(string photo in photo_list)
                {
                    j++;
                    try
                    {
                        Bitmap bitmap = new Bitmap(photo);  //parametre exception
                        operation(AppForm.operation, photo, exifReader(bitmap));
                    }
                    catch(Exception e)
                    {
                        corruptFile(AppForm.operation, photo);
                        
                    }
                    finally
                    {
                        form.addLog("   Completed " + j + "/" + photos_in_current_dir);
                        form.performStep();
                    }
                }
                j = 0;
            }
        }
        
    }
}
