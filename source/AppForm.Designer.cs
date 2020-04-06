namespace PhotoGrouper
{
    partial class AppForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.Label_Source = new System.Windows.Forms.Label();
            this.TextBox_Source = new System.Windows.Forms.TextBox();
            this.Button_Source = new System.Windows.Forms.Button();
            this.Label_Destination = new System.Windows.Forms.Label();
            this.TextBox_Destination = new System.Windows.Forms.TextBox();
            this.Button_Destination = new System.Windows.Forms.Button();
            this.TextBox_Log = new System.Windows.Forms.TextBox();
            this.GroupBox_Operation = new System.Windows.Forms.GroupBox();
            this.RadioButton_Move = new System.Windows.Forms.RadioButton();
            this.RadioButton_Copy = new System.Windows.Forms.RadioButton();
            this.Button_Analyze = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Label_TitleStatus = new System.Windows.Forms.Label();
            this.Label_Status = new System.Windows.Forms.Label();
            this.Label_Log = new System.Windows.Forms.Label();
            this.Label_Progress = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Label_Author = new System.Windows.Forms.LinkLabel();
            this.GroupBox_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Source
            // 
            this.Label_Source.AutoSize = true;
            this.Label_Source.Location = new System.Drawing.Point(10, 13);
            this.Label_Source.Name = "Label_Source";
            this.Label_Source.Size = new System.Drawing.Size(53, 17);
            this.Label_Source.TabIndex = 0;
            this.Label_Source.Text = "Source";
            // 
            // TextBox_Source
            // 
            this.TextBox_Source.Location = new System.Drawing.Point(13, 33);
            this.TextBox_Source.Name = "TextBox_Source";
            this.TextBox_Source.ReadOnly = true;
            this.TextBox_Source.Size = new System.Drawing.Size(330, 22);
            this.TextBox_Source.TabIndex = 1;
            // 
            // Button_Source
            // 
            this.Button_Source.Location = new System.Drawing.Point(349, 33);
            this.Button_Source.Name = "Button_Source";
            this.Button_Source.Size = new System.Drawing.Size(120, 26);
            this.Button_Source.TabIndex = 2;
            this.Button_Source.Text = "Select";
            this.Button_Source.UseVisualStyleBackColor = true;
            this.Button_Source.Click += new System.EventHandler(this.Button_Source_Click);
            // 
            // Label_Destination
            // 
            this.Label_Destination.AutoSize = true;
            this.Label_Destination.Location = new System.Drawing.Point(10, 69);
            this.Label_Destination.Name = "Label_Destination";
            this.Label_Destination.Size = new System.Drawing.Size(79, 17);
            this.Label_Destination.TabIndex = 3;
            this.Label_Destination.Text = "Destination";
            // 
            // TextBox_Destination
            // 
            this.TextBox_Destination.Location = new System.Drawing.Point(13, 89);
            this.TextBox_Destination.Name = "TextBox_Destination";
            this.TextBox_Destination.ReadOnly = true;
            this.TextBox_Destination.Size = new System.Drawing.Size(330, 22);
            this.TextBox_Destination.TabIndex = 4;
            // 
            // Button_Destination
            // 
            this.Button_Destination.Location = new System.Drawing.Point(349, 89);
            this.Button_Destination.Name = "Button_Destination";
            this.Button_Destination.Size = new System.Drawing.Size(120, 26);
            this.Button_Destination.TabIndex = 5;
            this.Button_Destination.Text = "Select";
            this.Button_Destination.UseVisualStyleBackColor = true;
            this.Button_Destination.Click += new System.EventHandler(this.Button_Destination_Click);
            // 
            // TextBox_Log
            // 
            this.TextBox_Log.Location = new System.Drawing.Point(13, 330);
            this.TextBox_Log.Multiline = true;
            this.TextBox_Log.Name = "TextBox_Log";
            this.TextBox_Log.ReadOnly = true;
            this.TextBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Log.Size = new System.Drawing.Size(454, 293);
            this.TextBox_Log.TabIndex = 6;
            // 
            // GroupBox_Operation
            // 
            this.GroupBox_Operation.Controls.Add(this.RadioButton_Move);
            this.GroupBox_Operation.Controls.Add(this.RadioButton_Copy);
            this.GroupBox_Operation.Location = new System.Drawing.Point(13, 131);
            this.GroupBox_Operation.Name = "GroupBox_Operation";
            this.GroupBox_Operation.Size = new System.Drawing.Size(456, 67);
            this.GroupBox_Operation.TabIndex = 7;
            this.GroupBox_Operation.TabStop = false;
            this.GroupBox_Operation.Text = "Grouping Mode";
            // 
            // RadioButton_Move
            // 
            this.RadioButton_Move.AutoSize = true;
            this.RadioButton_Move.Location = new System.Drawing.Point(169, 30);
            this.RadioButton_Move.Name = "RadioButton_Move";
            this.RadioButton_Move.Size = new System.Drawing.Size(63, 21);
            this.RadioButton_Move.TabIndex = 1;
            this.RadioButton_Move.TabStop = true;
            this.RadioButton_Move.Text = "Move";
            this.RadioButton_Move.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Copy
            // 
            this.RadioButton_Copy.AutoSize = true;
            this.RadioButton_Copy.Location = new System.Drawing.Point(6, 30);
            this.RadioButton_Copy.Name = "RadioButton_Copy";
            this.RadioButton_Copy.Size = new System.Drawing.Size(61, 21);
            this.RadioButton_Copy.TabIndex = 0;
            this.RadioButton_Copy.TabStop = true;
            this.RadioButton_Copy.Text = "Copy";
            this.RadioButton_Copy.UseVisualStyleBackColor = true;
            // 
            // Button_Analyze
            // 
            this.Button_Analyze.Enabled = false;
            this.Button_Analyze.Location = new System.Drawing.Point(13, 222);
            this.Button_Analyze.Name = "Button_Analyze";
            this.Button_Analyze.Size = new System.Drawing.Size(225, 40);
            this.Button_Analyze.TabIndex = 8;
            this.Button_Analyze.Text = "Analyze";
            this.Button_Analyze.UseVisualStyleBackColor = true;
            this.Button_Analyze.Click += new System.EventHandler(this.Button_Analyze_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Enabled = false;
            this.Button_Start.Location = new System.Drawing.Point(245, 222);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(225, 40);
            this.Button_Start.TabIndex = 9;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Label_TitleStatus
            // 
            this.Label_TitleStatus.AutoSize = true;
            this.Label_TitleStatus.Location = new System.Drawing.Point(10, 280);
            this.Label_TitleStatus.Name = "Label_TitleStatus";
            this.Label_TitleStatus.Size = new System.Drawing.Size(52, 17);
            this.Label_TitleStatus.TabIndex = 10;
            this.Label_TitleStatus.Text = "Status:";
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Location = new System.Drawing.Point(70, 280);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(13, 17);
            this.Label_Status.TabIndex = 11;
            this.Label_Status.Text = "-";
            // 
            // Label_Log
            // 
            this.Label_Log.AutoSize = true;
            this.Label_Log.Location = new System.Drawing.Point(13, 310);
            this.Label_Log.Name = "Label_Log";
            this.Label_Log.Size = new System.Drawing.Size(32, 17);
            this.Label_Log.TabIndex = 12;
            this.Label_Log.Text = "Log";
            // 
            // Label_Progress
            // 
            this.Label_Progress.AutoSize = true;
            this.Label_Progress.Location = new System.Drawing.Point(13, 640);
            this.Label_Progress.Name = "Label_Progress";
            this.Label_Progress.Size = new System.Drawing.Size(65, 17);
            this.Label_Progress.TabIndex = 13;
            this.Label_Progress.Text = "Progress";
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProgressBar.Location = new System.Drawing.Point(13, 661);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(454, 23);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 14;
            // 
            // Label_Author
            // 
            this.Label_Author.AutoSize = true;
            this.Label_Author.Location = new System.Drawing.Point(170, 697);
            this.Label_Author.Name = "Label_Author";
            this.Label_Author.Size = new System.Drawing.Size(139, 17);
            this.Label_Author.TabIndex = 16;
            this.Label_Author.TabStop = true;
            this.Label_Author.Text = "v1.0 by VedFI - 2020";
            this.Label_Author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_Author_LinkClicked);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(482, 723);
            this.Controls.Add(this.Label_Author);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Label_Progress);
            this.Controls.Add(this.Label_Log);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Label_TitleStatus);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Button_Analyze);
            this.Controls.Add(this.GroupBox_Operation);
            this.Controls.Add(this.TextBox_Log);
            this.Controls.Add(this.Button_Destination);
            this.Controls.Add(this.TextBox_Destination);
            this.Controls.Add(this.Label_Destination);
            this.Controls.Add(this.Button_Source);
            this.Controls.Add(this.TextBox_Source);
            this.Controls.Add(this.Label_Source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Grouper";
            this.GroupBox_Operation.ResumeLayout(false);
            this.GroupBox_Operation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Source;
        private System.Windows.Forms.TextBox TextBox_Source;
        private System.Windows.Forms.Button Button_Source;
        private System.Windows.Forms.Label Label_Destination;
        private System.Windows.Forms.TextBox TextBox_Destination;
        private System.Windows.Forms.Button Button_Destination;
        private System.Windows.Forms.TextBox TextBox_Log;
        private System.Windows.Forms.GroupBox GroupBox_Operation;
        private System.Windows.Forms.RadioButton RadioButton_Move;
        private System.Windows.Forms.RadioButton RadioButton_Copy;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label Label_TitleStatus;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Label Label_Log;
        private System.Windows.Forms.Label Label_Progress;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button Button_Analyze;
        private System.Windows.Forms.LinkLabel Label_Author;
    }
}

