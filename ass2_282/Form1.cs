using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        private List<Line> _lines = new List<Line>();
        private List<Point> _points = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {   //Add location to points container
                _points.Add(e.Location);
                if (_points.Count == 2)
                {   //Use start and end position to make a line
                    Line line = new Line(_points.ToArray()[0], _points.ToArray()[1], color_btn.ForeColor);
                    _lines.Add(line);
                    Draw_add();
                    _points.Clear();
                }
            }
        }


        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Point point1 = new Point();
                Point point2 = new Point();
                //Check if empty
                if (FirstX.Text.Trim() == "" || FirstY.Text.Trim() == "" || SecondX.Text.Trim() == "" ||
                    SecondY.Text.Trim() == "")
                {
                    MessageBox.Show("Can't be empty or not digits!!!");
                    return;
                }

                //Check if digits
                string inputFirstx = FirstX.Text.Trim();
                string inputFirsty = FirstY.Text.Trim();
                string inputSecondx = SecondX.Text.Trim();
                string inputSecondy = SecondY.Text.Trim();
                if (Regex.IsMatch(inputFirstx, "^[0-9]+$") || Regex.IsMatch(inputFirsty, "^[0-9]+$") || Regex.IsMatch(
                        inputSecondx, "^[0-9]+$") || Regex.IsMatch(inputSecondy, "^[0-9]+$"))
                {
                    point1.X = int.Parse(inputFirstx);
                    point1.Y = int.Parse(inputFirsty);
                    point2.X = int.Parse(inputSecondx);
                    point2.Y = int.Parse(inputSecondy);
                }
                else
                {
                    MessageBox.Show("Can't be empty or not digits!!!");
                    return;
                }

                Line line = new Line(point1, point2, color_btn.ForeColor);
                _lines.Add(line);
                Draw_add();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void Draw_add()
        {
            Graphics g = picture_box1.CreateGraphics();
            g.Clear(Color.White);
            //Clear listbox to avoid repetition.
            listBox1.Items.Clear();
            foreach (Line line in _lines)
            {
                Pen pen = new Pen(line.LineColor);
                g.DrawLine(pen, line.Point1, line.Point2);
                listBox1.Items.Add(line.ToString());
            }
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            if (color_dialog_1.ShowDialog() == DialogResult.OK)
            {
                color_btn.ForeColor = color_dialog_1.Color;
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            // Get the currently selected item index
            int selectedIndex = listBox1.SelectedIndex;

            // Check if an item is selected
            if (selectedIndex >= 0)
            {  //re activate remove button
                remove_btn.Enabled = true;
                // Remove the selected line from the container class
                _lines.RemoveAt(selectedIndex);
                // Remove the selected line from the list box
                listBox1.Items.RemoveAt(selectedIndex);
                // Redraw
                Draw_add();
                // Check if lines in the container
                if (_lines.Count > 0)
                {
                    // Set the selected index to be an adjacent line
                    if (selectedIndex >= _lines.Count)
                    {
                        selectedIndex--;
                    }

                    listBox1.SelectedIndex = selectedIndex;
                }
                else
                {
                    // No lines left, disable remove button and clear picture box(and list)
                    remove_btn.Enabled = false;
                    Graphics g = picture_box1.CreateGraphics();
                    g.Clear(Color.White);
                    listBox1.Items.Clear();
                }
            }
            else
            {
                // No item selected, display error message
                MessageBox.Show("Please select a line to remove.");
            }
        }
    }
}