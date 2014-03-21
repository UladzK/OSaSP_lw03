namespace lw03
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dirList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(2, 9);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(148, 20);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "Enter path to directory/file";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(147, 8);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(55, 20);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monitor:";
            // 
            // dirList
            // 
            this.dirList.FormattingEnabled = true;
            this.dirList.Location = new System.Drawing.Point(230, 28);
            this.dirList.Name = "dirList";
            this.dirList.Size = new System.Drawing.Size(180, 186);
            this.dirList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Files List";
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(433, 28);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(152, 186);
            this.fileList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 256);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dirList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.pathBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox dirList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox fileList;
    }
}

