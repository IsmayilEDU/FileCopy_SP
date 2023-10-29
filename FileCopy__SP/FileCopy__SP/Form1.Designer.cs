namespace FileCopy__SP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_FileStream = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.button_From = new System.Windows.Forms.Button();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.button_To = new System.Windows.Forms.Button();
            this.button_Resume = new System.Windows.Forms.Button();
            this.button_Suspend = new System.Windows.Forms.Button();
            this.button_Abort = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // progressBar_FileStream
            // 
            this.progressBar_FileStream.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar_FileStream.Location = new System.Drawing.Point(13, 124);
            this.progressBar_FileStream.Name = "progressBar_FileStream";
            this.progressBar_FileStream.Size = new System.Drawing.Size(209, 23);
            this.progressBar_FileStream.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // textBox_To
            // 
            this.textBox_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_To.Location = new System.Drawing.Point(74, 53);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.Size = new System.Drawing.Size(447, 29);
            this.textBox_To.TabIndex = 4;
            // 
            // button_From
            // 
            this.button_From.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_From.Location = new System.Drawing.Point(534, 10);
            this.button_From.Name = "button_From";
            this.button_From.Size = new System.Drawing.Size(38, 29);
            this.button_From.TabIndex = 5;
            this.button_From.Text = "...";
            this.button_From.UseVisualStyleBackColor = false;
            this.button_From.Click += new System.EventHandler(this.button_From_Click);
            // 
            // textBox_From
            // 
            this.textBox_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_From.Location = new System.Drawing.Point(74, 10);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(447, 29);
            this.textBox_From.TabIndex = 7;
            // 
            // button_To
            // 
            this.button_To.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_To.Location = new System.Drawing.Point(534, 53);
            this.button_To.Name = "button_To";
            this.button_To.Size = new System.Drawing.Size(38, 29);
            this.button_To.TabIndex = 8;
            this.button_To.Text = "...";
            this.button_To.UseVisualStyleBackColor = false;
            this.button_To.Click += new System.EventHandler(this.button_To_Click);
            // 
            // button_Resume
            // 
            this.button_Resume.Location = new System.Drawing.Point(335, 126);
            this.button_Resume.Name = "button_Resume";
            this.button_Resume.Size = new System.Drawing.Size(75, 23);
            this.button_Resume.TabIndex = 9;
            this.button_Resume.Text = "Resume";
            this.button_Resume.UseVisualStyleBackColor = true;
            // 
            // button_Suspend
            // 
            this.button_Suspend.Location = new System.Drawing.Point(254, 126);
            this.button_Suspend.Name = "button_Suspend";
            this.button_Suspend.Size = new System.Drawing.Size(75, 23);
            this.button_Suspend.TabIndex = 10;
            this.button_Suspend.Text = "Suspend";
            this.button_Suspend.UseVisualStyleBackColor = true;
            // 
            // button_Abort
            // 
            this.button_Abort.Location = new System.Drawing.Point(416, 126);
            this.button_Abort.Name = "button_Abort";
            this.button_Abort.Size = new System.Drawing.Size(75, 23);
            this.button_Abort.TabIndex = 11;
            this.button_Abort.Text = "Abort";
            this.button_Abort.UseVisualStyleBackColor = true;
            // 
            // button_Copy
            // 
            this.button_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Copy.Location = new System.Drawing.Point(497, 113);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(75, 36);
            this.button_Copy.TabIndex = 12;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Abort);
            this.Controls.Add(this.button_Suspend);
            this.Controls.Add(this.button_Resume);
            this.Controls.Add(this.button_To);
            this.Controls.Add(this.textBox_From);
            this.Controls.Add(this.button_From);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar_FileStream);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_FileStream;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_To;
        private System.Windows.Forms.Button button_From;
        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.Button button_To;
        private System.Windows.Forms.Button button_Resume;
        private System.Windows.Forms.Button button_Suspend;
        private System.Windows.Forms.Button button_Abort;
        private System.Windows.Forms.Button button_Copy;
    }
}

