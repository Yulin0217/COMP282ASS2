namespace DrawLines
{
    partial class Task1_8
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
            this.picture_box1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.find_its_btn = new System.Windows.Forms.Button();
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
            this.color_dialog_1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_box1
            // 
            this.picture_box1.Location = new System.Drawing.Point(1, -2);
            this.picture_box1.Name = "picture_box1";
            this.picture_box1.Size = new System.Drawing.Size(710, 768);
            this.picture_box1.TabIndex = 2;
            this.picture_box1.TabStop = false;
            this.picture_box1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(717, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(501, 640);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.find_its_btn);
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
            this.Menu.Location = new System.Drawing.Point(717, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(501, 111);
            this.Menu.TabIndex = 4;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // find_its_btn
            // 
            this.find_its_btn.Location = new System.Drawing.Point(309, 70);
            this.find_its_btn.Name = "find_its_btn";
            this.find_its_btn.Size = new System.Drawing.Size(126, 23);
            this.find_its_btn.TabIndex = 12;
            this.find_its_btn.Text = "Find InterSections";
            this.find_its_btn.UseVisualStyleBackColor = true;
            this.find_its_btn.Click += new System.EventHandler(this.find_its_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(212, 70);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(91, 23);
            this.remove_btn.TabIndex = 11;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(115, 70);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(91, 23);
            this.update_btn.TabIndex = 10;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(6, 70);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(91, 23);
            this.color_btn.TabIndex = 9;
            this.color_btn.Text = "Color";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(327, 20);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(118, 38);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Second Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Second X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "First X";
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
            // Task1_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 759);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.picture_box1);
            this.Name = "Task1_8";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button find_its_btn;
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
        private System.Windows.Forms.ColorDialog color_dialog_1;
        private System.Windows.Forms.PictureBox picture_box1;
    }
}

