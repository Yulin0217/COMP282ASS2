using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLines
{
    partial class Task9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove_btn = new System.Windows.Forms.Button();
            this.color_btn = new System.Windows.Forms.Button();
            this.find_btn = new System.Windows.Forms.Button();
            this.picture_box2 = new System.Windows.Forms.PictureBox();
            this.color_dialog_2 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.remove_btn);
            this.panel1.Controls.Add(this.color_btn);
            this.panel1.Controls.Add(this.find_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(872, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 774);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.Column4, this.Column5 });
            this.dataGridView1.Location = new System.Drawing.Point(6, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(298, 463);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_cell_click);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Y";
            this.Column2.Name = "Column2";
            this.Column2.Width = 55;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Second X";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Second Y";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(179, 32);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(103, 39);
            this.remove_btn.TabIndex = 15;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click_1);
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(28, 32);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(105, 39);
            this.color_btn.TabIndex = 14;
            this.color_btn.Text = "Color";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(93, 608);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(134, 55);
            this.find_btn.TabIndex = 13;
            this.find_btn.Text = "Find InterSections";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // picture_box2
            // 
            this.picture_box2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_box2.Location = new System.Drawing.Point(0, 0);
            this.picture_box2.Name = "picture_box2";
            this.picture_box2.Size = new System.Drawing.Size(872, 774);
            this.picture_box2.TabIndex = 4;
            this.picture_box2.TabStop = false;
            this.picture_box2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseUp);
            // 
            // Task9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 774);
            this.Controls.Add(this.picture_box2);
            this.Controls.Add(this.panel1);
            this.Name = "Task9";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.PictureBox picture_box2;
        private System.Windows.Forms.ColorDialog color_dialog_2;
        #endregion
    }
}