namespace AOA_Interface
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.preview_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.classname_TextBox = new System.Windows.Forms.RichTextBox();
            this.starttime_combobox = new System.Windows.Forms.ComboBox();
            this.endtime_combobox = new System.Windows.Forms.ComboBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.classroom_TextBox = new System.Windows.Forms.RichTextBox();
            this.optimalsolution_btn = new System.Windows.Forms.Button();
            this.csvfile_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // preview_btn
            // 
            this.preview_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.preview_btn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.preview_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.preview_btn.Location = new System.Drawing.Point(809, 101);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(170, 62);
            this.preview_btn.TabIndex = 2;
            this.preview_btn.Text = "Preview";
            this.preview_btn.UseVisualStyleBackColor = false;
            this.preview_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(134, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Want to Update Data!!";
            // 
            // classname_TextBox
            // 
            this.classname_TextBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.classname_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classname_TextBox.Location = new System.Drawing.Point(359, 329);
            this.classname_TextBox.Name = "classname_TextBox";
            this.classname_TextBox.Size = new System.Drawing.Size(620, 35);
            this.classname_TextBox.TabIndex = 6;
            this.classname_TextBox.Text = "";
            // 
            // starttime_combobox
            // 
            this.starttime_combobox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.starttime_combobox.DropDownHeight = 100;
            this.starttime_combobox.DropDownWidth = 200;
            this.starttime_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.starttime_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime_combobox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.starttime_combobox.FormattingEnabled = true;
            this.starttime_combobox.IntegralHeight = false;
            this.starttime_combobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.starttime_combobox.Location = new System.Drawing.Point(360, 395);
            this.starttime_combobox.Name = "starttime_combobox";
            this.starttime_combobox.Size = new System.Drawing.Size(144, 33);
            this.starttime_combobox.TabIndex = 36;
            // 
            // endtime_combobox
            // 
            this.endtime_combobox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.endtime_combobox.DropDownHeight = 100;
            this.endtime_combobox.DropDownWidth = 200;
            this.endtime_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endtime_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime_combobox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.endtime_combobox.FormattingEnabled = true;
            this.endtime_combobox.IntegralHeight = false;
            this.endtime_combobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.endtime_combobox.Location = new System.Drawing.Point(830, 396);
            this.endtime_combobox.Name = "endtime_combobox";
            this.endtime_combobox.Size = new System.Drawing.Size(147, 33);
            this.endtime_combobox.TabIndex = 37;
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.insert_btn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.insert_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.insert_btn.Location = new System.Drawing.Point(451, 534);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(223, 65);
            this.insert_btn.TabIndex = 38;
            this.insert_btn.Text = "Load / Insert";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // classroom_TextBox
            // 
            this.classroom_TextBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.classroom_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classroom_TextBox.Location = new System.Drawing.Point(481, 459);
            this.classroom_TextBox.Name = "classroom_TextBox";
            this.classroom_TextBox.Size = new System.Drawing.Size(496, 33);
            this.classroom_TextBox.TabIndex = 40;
            this.classroom_TextBox.Text = "";
            // 
            // optimalsolution_btn
            // 
            this.optimalsolution_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.optimalsolution_btn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.optimalsolution_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.optimalsolution_btn.Location = new System.Drawing.Point(206, 610);
            this.optimalsolution_btn.Name = "optimalsolution_btn";
            this.optimalsolution_btn.Size = new System.Drawing.Size(170, 81);
            this.optimalsolution_btn.TabIndex = 41;
            this.optimalsolution_btn.Text = "Optimal Solution";
            this.optimalsolution_btn.UseVisualStyleBackColor = false;
            // 
            // csvfile_btn
            // 
            this.csvfile_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.csvfile_btn.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.csvfile_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.csvfile_btn.Location = new System.Drawing.Point(737, 612);
            this.csvfile_btn.Name = "csvfile_btn";
            this.csvfile_btn.Size = new System.Drawing.Size(170, 81);
            this.csvfile_btn.TabIndex = 42;
            this.csvfile_btn.Text = "Create CSV File";
            this.csvfile_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(276, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 44);
            this.label2.TabIndex = 43;
            this.label2.Text = "         Your file has been proceesed.        ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(428, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 44);
            this.label3.TabIndex = 44;
            this.label3.Text = "    Insert a Class    ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(138, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 33);
            this.label4.TabIndex = 45;
            this.label4.Text = "Class Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(138, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 33);
            this.label5.TabIndex = 46;
            this.label5.Text = "Start Time   :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(138, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 33);
            this.label6.TabIndex = 47;
            this.label6.Text = "Number of Classrooms:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(621, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 33);
            this.label7.TabIndex = 48;
            this.label7.Text = "  End Time :  ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 139);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1195, 745);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.csvfile_btn);
            this.Controls.Add(this.optimalsolution_btn);
            this.Controls.Add(this.classroom_TextBox);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.endtime_combobox);
            this.Controls.Add(this.starttime_combobox);
            this.Controls.Add(this.classname_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preview_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "For";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button preview_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox classname_TextBox;
        private System.Windows.Forms.ComboBox starttime_combobox;
        private System.Windows.Forms.ComboBox endtime_combobox;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.RichTextBox classroom_TextBox;
        private System.Windows.Forms.Button optimalsolution_btn;
        private System.Windows.Forms.Button csvfile_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}