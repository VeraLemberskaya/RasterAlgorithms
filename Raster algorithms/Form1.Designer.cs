namespace Raster_algorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.XTextbox = new System.Windows.Forms.TextBox();
            this.ResizeXYButton = new System.Windows.Forms.Button();
            this.YTextbox = new System.Windows.Forms.TextBox();
            this.ResizeYButton = new System.Windows.Forms.Button();
            this.ResizeXButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.extentionLabel2 = new System.Windows.Forms.Label();
            this.resolutionLabel2 = new System.Windows.Forms.Label();
            this.sizeLabel2 = new System.Windows.Forms.Label();
            this.KNNButton = new System.Windows.Forms.Button();
            this.KTimesButton = new System.Windows.Forms.Button();
            this.BLButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.algLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(12, 547);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(93, 35);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Load image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 521);
            this.panel1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(120, 547);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 35);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // XTextbox
            // 
            this.XTextbox.Location = new System.Drawing.Point(590, 273);
            this.XTextbox.Name = "XTextbox";
            this.XTextbox.Size = new System.Drawing.Size(41, 20);
            this.XTextbox.TabIndex = 4;
            // 
            // ResizeXYButton
            // 
            this.ResizeXYButton.Location = new System.Drawing.Point(926, 267);
            this.ResizeXYButton.Name = "ResizeXYButton";
            this.ResizeXYButton.Size = new System.Drawing.Size(97, 38);
            this.ResizeXYButton.TabIndex = 5;
            this.ResizeXYButton.Text = "Resize XY";
            this.ResizeXYButton.UseVisualStyleBackColor = true;
            this.ResizeXYButton.Click += new System.EventHandler(this.ResizeXYButton_Click);
            // 
            // YTextbox
            // 
            this.YTextbox.Location = new System.Drawing.Point(590, 310);
            this.YTextbox.Name = "YTextbox";
            this.YTextbox.Size = new System.Drawing.Size(41, 20);
            this.YTextbox.TabIndex = 6;
            // 
            // ResizeYButton
            // 
            this.ResizeYButton.Location = new System.Drawing.Point(796, 267);
            this.ResizeYButton.Name = "ResizeYButton";
            this.ResizeYButton.Size = new System.Drawing.Size(97, 38);
            this.ResizeYButton.TabIndex = 8;
            this.ResizeYButton.Text = "Resize Y";
            this.ResizeYButton.UseVisualStyleBackColor = true;
            this.ResizeYButton.Click += new System.EventHandler(this.ResizeYButton_Click);
            // 
            // ResizeXButton
            // 
            this.ResizeXButton.Location = new System.Drawing.Point(666, 267);
            this.ResizeXButton.Name = "ResizeXButton";
            this.ResizeXButton.Size = new System.Drawing.Size(97, 38);
            this.ResizeXButton.TabIndex = 9;
            this.ResizeXButton.Text = "Resize X";
            this.ResizeXButton.UseVisualStyleBackColor = true;
            this.ResizeXButton.Click += new System.EventHandler(this.ResizeXButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(565, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(565, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(587, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extension:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(587, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resolution:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(587, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Size:";
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extensionLabel.Location = new System.Drawing.Point(695, 42);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(0, 16);
            this.extensionLabel.TabIndex = 15;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resolutionLabel.Location = new System.Drawing.Point(695, 74);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(0, 16);
            this.resolutionLabel.TabIndex = 16;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.Location = new System.Drawing.Point(651, 104);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(0, 16);
            this.sizeLabel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(587, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "BEFORE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(836, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "AFTER:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(836, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Size:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(836, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Resolution:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(836, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Extension:";
            // 
            // extentionLabel2
            // 
            this.extentionLabel2.AutoSize = true;
            this.extentionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extentionLabel2.Location = new System.Drawing.Point(937, 42);
            this.extentionLabel2.Name = "extentionLabel2";
            this.extentionLabel2.Size = new System.Drawing.Size(0, 16);
            this.extentionLabel2.TabIndex = 23;
            // 
            // resolutionLabel2
            // 
            this.resolutionLabel2.AutoSize = true;
            this.resolutionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resolutionLabel2.Location = new System.Drawing.Point(937, 74);
            this.resolutionLabel2.Name = "resolutionLabel2";
            this.resolutionLabel2.Size = new System.Drawing.Size(0, 16);
            this.resolutionLabel2.TabIndex = 24;
            // 
            // sizeLabel2
            // 
            this.sizeLabel2.AutoSize = true;
            this.sizeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel2.Location = new System.Drawing.Point(893, 104);
            this.sizeLabel2.Name = "sizeLabel2";
            this.sizeLabel2.Size = new System.Drawing.Size(0, 16);
            this.sizeLabel2.TabIndex = 25;
            // 
            // KNNButton
            // 
            this.KNNButton.Location = new System.Drawing.Point(568, 370);
            this.KNNButton.Name = "KNNButton";
            this.KNNButton.Size = new System.Drawing.Size(137, 38);
            this.KNNButton.TabIndex = 26;
            this.KNNButton.Text = "K-Nearest Neighbors";
            this.KNNButton.UseVisualStyleBackColor = true;
            this.KNNButton.Click += new System.EventHandler(this.KNNButton_Click);
            // 
            // KTimesButton
            // 
            this.KTimesButton.Location = new System.Drawing.Point(568, 428);
            this.KTimesButton.Name = "KTimesButton";
            this.KTimesButton.Size = new System.Drawing.Size(137, 38);
            this.KTimesButton.TabIndex = 27;
            this.KTimesButton.Text = "K-Times";
            this.KTimesButton.UseVisualStyleBackColor = true;
            this.KTimesButton.Click += new System.EventHandler(this.KTimesButton_Click);
            // 
            // BLButton
            // 
            this.BLButton.Location = new System.Drawing.Point(568, 489);
            this.BLButton.Name = "BLButton";
            this.BLButton.Size = new System.Drawing.Size(137, 38);
            this.BLButton.TabIndex = 28;
            this.BLButton.Text = "Bilinear interpolation";
            this.BLButton.UseVisualStyleBackColor = true;
            this.BLButton.Click += new System.EventHandler(this.BLButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(587, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Time taken:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(587, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Algorithm:";
            // 
            // algLabel
            // 
            this.algLabel.AutoSize = true;
            this.algLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.algLabel.Location = new System.Drawing.Point(695, 208);
            this.algLabel.Name = "algLabel";
            this.algLabel.Size = new System.Drawing.Size(0, 16);
            this.algLabel.TabIndex = 31;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(695, 235);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 16);
            this.timeLabel.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 594);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.algLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BLButton);
            this.Controls.Add(this.KTimesButton);
            this.Controls.Add(this.KNNButton);
            this.Controls.Add(this.sizeLabel2);
            this.Controls.Add(this.resolutionLabel2);
            this.Controls.Add(this.extentionLabel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResizeXButton);
            this.Controls.Add(this.ResizeYButton);
            this.Controls.Add(this.YTextbox);
            this.Controls.Add(this.ResizeXYButton);
            this.Controls.Add(this.XTextbox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoadImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox XTextbox;
        private System.Windows.Forms.Button ResizeXYButton;
        private System.Windows.Forms.TextBox YTextbox;
        private System.Windows.Forms.Button ResizeYButton;
        private System.Windows.Forms.Button ResizeXButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label extentionLabel2;
        private System.Windows.Forms.Label resolutionLabel2;
        private System.Windows.Forms.Label sizeLabel2;
        private System.Windows.Forms.Button KNNButton;
        private System.Windows.Forms.Button KTimesButton;
        private System.Windows.Forms.Button BLButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label algLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

