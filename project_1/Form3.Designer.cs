﻿namespace project_1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.file_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_action = new System.Windows.Forms.CheckBox();
            this.checkBox_drama = new System.Windows.Forms.CheckBox();
            this.checkBox_thiller = new System.Windows.Forms.CheckBox();
            this.checkBox_horror = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.File_path = new System.Windows.Forms.TextBox();
            this.upload_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.upload_btn);
            this.panel1.Controls.Add(this.File_path);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox_horror);
            this.panel1.Controls.Add(this.checkBox_thiller);
            this.panel1.Controls.Add(this.checkBox_drama);
            this.panel1.Controls.Add(this.checkBox_action);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.file_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(173, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 596);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(75, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chose Catagory";
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(171, 122);
            this.file_name.Multiline = true;
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(230, 20);
            this.file_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "File name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload Video";
            // 
            // checkBox_action
            // 
            this.checkBox_action.AutoSize = true;
            this.checkBox_action.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_action.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_action.Location = new System.Drawing.Point(79, 363);
            this.checkBox_action.Name = "checkBox_action";
            this.checkBox_action.Size = new System.Drawing.Size(67, 21);
            this.checkBox_action.TabIndex = 4;
            this.checkBox_action.Text = "Action";
            this.checkBox_action.UseVisualStyleBackColor = true;
            // 
            // checkBox_drama
            // 
            this.checkBox_drama.AutoSize = true;
            this.checkBox_drama.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_drama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_drama.Location = new System.Drawing.Point(79, 386);
            this.checkBox_drama.Name = "checkBox_drama";
            this.checkBox_drama.Size = new System.Drawing.Size(68, 21);
            this.checkBox_drama.TabIndex = 5;
            this.checkBox_drama.Text = "Drama";
            this.checkBox_drama.UseVisualStyleBackColor = true;
            // 
            // checkBox_thiller
            // 
            this.checkBox_thiller.AutoSize = true;
            this.checkBox_thiller.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_thiller.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_thiller.Location = new System.Drawing.Point(79, 409);
            this.checkBox_thiller.Name = "checkBox_thiller";
            this.checkBox_thiller.Size = new System.Drawing.Size(72, 21);
            this.checkBox_thiller.TabIndex = 6;
            this.checkBox_thiller.Text = "Thriller";
            this.checkBox_thiller.UseVisualStyleBackColor = true;
            // 
            // checkBox_horror
            // 
            this.checkBox_horror.AutoSize = true;
            this.checkBox_horror.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_horror.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_horror.Location = new System.Drawing.Point(79, 432);
            this.checkBox_horror.Name = "checkBox_horror";
            this.checkBox_horror.Size = new System.Drawing.Size(68, 21);
            this.checkBox_horror.TabIndex = 7;
            this.checkBox_horror.Text = "Horror";
            this.checkBox_horror.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(67, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "File Path";
            // 
            // File_path
            // 
            this.File_path.Location = new System.Drawing.Point(171, 195);
            this.File_path.Multiline = true;
            this.File_path.Name = "File_path";
            this.File_path.Size = new System.Drawing.Size(230, 20);
            this.File_path.TabIndex = 9;
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(438, 195);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(75, 23);
            this.upload_btn.TabIndex = 10;
            this.upload_btn.Text = "Upload";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 689);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_action;
        private System.Windows.Forms.CheckBox checkBox_horror;
        private System.Windows.Forms.CheckBox checkBox_thiller;
        private System.Windows.Forms.CheckBox checkBox_drama;
        private System.Windows.Forms.TextBox File_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}