﻿namespace DrawLines
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.color_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondY = new System.Windows.Forms.TextBox();
            this.FirstY = new System.Windows.Forms.TextBox();
            this.SecondX = new System.Windows.Forms.TextBox();
            this.FirstX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 768);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(717, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(501, 640);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.find_btn);
            this.Menu.Controls.Add(this.remove_btn);
            this.Menu.Controls.Add(this.update_btn);
            this.Menu.Controls.Add(this.color_btn);
            this.Menu.Controls.Add(this.Add_btn);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.SecondY);
            this.Menu.Controls.Add(this.FirstY);
            this.Menu.Controls.Add(this.SecondX);
            this.Menu.Controls.Add(this.FirstX);
            this.Menu.Location = new System.Drawing.Point(717, 29);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(501, 94);
            this.Menu.TabIndex = 4;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            this.Menu.Enter += new System.EventHandler(this.Menu_Enter);
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(309, 73);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(126, 23);
            this.find_btn.TabIndex = 12;
            this.find_btn.Text = "Find InterSections";
            this.find_btn.UseVisualStyleBackColor = true;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(212, 73);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(91, 23);
            this.remove_btn.TabIndex = 11;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(115, 70);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(91, 23);
            this.update_btn.TabIndex = 10;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(6, 70);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(91, 23);
            this.color_btn.TabIndex = 9;
            this.color_btn.Text = "Color";
            this.color_btn.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(327, 20);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(118, 38);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "SecondY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "SecondX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "FirstY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "FirstX";
            // 
            // SecondY
            // 
            this.SecondY.Location = new System.Drawing.Point(212, 46);
            this.SecondY.Name = "SecondY";
            this.SecondY.Size = new System.Drawing.Size(109, 21);
            this.SecondY.TabIndex = 3;
            // 
            // FirstY
            // 
            this.FirstY.Location = new System.Drawing.Point(53, 43);
            this.FirstY.Name = "FirstY";
            this.FirstY.Size = new System.Drawing.Size(100, 21);
            this.FirstY.TabIndex = 2;
            // 
            // SecondX
            // 
            this.SecondX.Location = new System.Drawing.Point(212, 14);
            this.SecondX.Name = "SecondX";
            this.SecondX.Size = new System.Drawing.Size(109, 21);
            this.SecondX.TabIndex = 1;
            // 
            // FirstX
            // 
            this.FirstX.Location = new System.Drawing.Point(53, 14);
            this.FirstX.Name = "FirstX";
            this.FirstX.Size = new System.Drawing.Size(100, 21);
            this.FirstX.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 759);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondY;
        private System.Windows.Forms.TextBox FirstY;
        private System.Windows.Forms.TextBox SecondX;
        private System.Windows.Forms.TextBox FirstX;

        private System.Windows.Forms.ListBox listBox1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

