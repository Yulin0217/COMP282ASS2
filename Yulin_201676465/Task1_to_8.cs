using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DrawLines
{
    public partial class Task1_to_8 : Form
    {
        private List<Line> _lines = new List<Line>();
        private List<Point> _points = new List<Point>();

        public Task1_to_8()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            remove_btn.Enabled = true;
            if (e.Button == MouseButtons.Left)
            {
                //Add location to points container
                _points.Add(e.Location);
                if (_points.Count == 2)
                {
                    //Use start and end position to make a line
                    Line line = new Line(_points[0], _points[1], color_btn.ForeColor);
                    _lines.Add(line);
                    draw_add();
                    _points.Clear();
                }
            }
        }


        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                remove_btn.Enabled = true;
                Point point1 = new Point();
                Point point2 = new Point();
                //Check if empty
                if (FirstX.Text.Trim() == "" || FirstY.Text.Trim() == "" || SecondX.Text.Trim() == "" ||
                    SecondY.Text.Trim() == "")
                {
                    MessageBox.Show("Can't be empty or not digits!!!");
                    return;
                }

                //Check if digits using regex
                string inputFirstx = FirstX.Text.Trim();
                string inputFirsty = FirstY.Text.Trim();
                string inputSecondx = SecondX.Text.Trim();
                string inputSecondy = SecondY.Text.Trim();
                if (Regex.IsMatch(inputFirstx, "^(-)?[0-9]+$") && Regex.IsMatch(inputFirsty, "^(-)?[0-9]+$") &&
                    Regex.IsMatch(
                        inputSecondx, "^(-)?[0-9]+$") && Regex.IsMatch(inputSecondy, "^(-)?[0-9]+$"))
                {
                    if (int.Parse(inputFirstx) <= 0 && int.Parse(inputFirsty) <= 0 && int.Parse(inputSecondx) <= 0 &&
                        int.Parse(inputSecondy) <= 0)
                    {
                        MessageBox.Show("Your entered cordinates are all negative or zero and could not display.");
                    }

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
                draw_add();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void draw_add()
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
            int selected_index = listBox1.SelectedIndex;

            // Check if an item is selected
            if (selected_index >= 0)
            {
                //re-activate remove button
                remove_btn.Enabled = true;
                // Remove  from the container class
                _lines.RemoveAt(selected_index);
                // Remove  from the list box
                listBox1.Items.RemoveAt(selected_index);
                // Redraw
                draw_add();
                // Check if lines in the container
                if (_lines.Count > 0)
                {
                    // Set the selected index to be an adjacent line
                    if (selected_index >= _lines.Count)
                    {
                        selected_index--;
                    }

                    listBox1.SelectedIndex = selected_index;
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

            //Clear input text when all lines are deleted
            if (_lines.Count == 0)
            {
                FirstX.Clear();
                FirstY.Clear();
                SecondX.Clear();
                SecondY.Clear();
                MessageBox.Show("All lines are deleted!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //Get the selected index
                int index = listBox1.SelectedIndex;
                //Change the text
                FirstX.Text = _lines[index].Point1.X.ToString();
                FirstY.Text = _lines[index].Point1.Y.ToString();
                SecondX.Text = _lines[index].Point2.X.ToString();
                SecondY.Text = _lines[index].Point2.Y.ToString();
                //Change the button color
                color_btn.ForeColor = _lines[index].LineColor;
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //Creat new points and get their information
                Point new_point1 = new Point();
                Point new_point2 = new Point();
                //Check if empty
                if (FirstX.Text.Trim() == "" || FirstY.Text.Trim() == "" || SecondX.Text.Trim() == "" ||
                    SecondY.Text.Trim() == "")
                {
                    MessageBox.Show("Can't be empty or not digits!!!");
                    return;
                }

                //Check if digits using regex
                string inputFirstx = FirstX.Text.Trim();
                string inputFirsty = FirstY.Text.Trim();
                string inputSecondx = SecondX.Text.Trim();
                string inputSecondy = SecondY.Text.Trim();
                if (Regex.IsMatch(inputFirstx, "^(-)?[0-9]+$") && Regex.IsMatch(inputFirsty, "^(-)?[0-9]+$") &&
                    Regex.IsMatch(
                        inputSecondx, "^(-)?[0-9]+$") && Regex.IsMatch(inputSecondy, "^(-)?[0-9]+$"))
                {
                    if (int.Parse(inputFirstx) <= 0 && int.Parse(inputFirsty) <= 0 && int.Parse(inputSecondx) <= 0 &&
                        int.Parse(inputSecondy) <= 0)
                    {
                        MessageBox.Show("Your entered cordinates are all negative or zero and could not display.");
                    }

                    new_point1.X = int.Parse(inputFirstx);
                    new_point1.Y = int.Parse(inputFirsty);
                    new_point2.X = int.Parse(inputSecondx);
                    new_point2.Y = int.Parse(inputSecondy);
                }
                else
                {
                    MessageBox.Show("Can't be empty or not digits!!!");
                    return;
                }

                //Get selected point index
                int index_selected = listBox1.SelectedIndex;
                //Update the line
                _lines[index_selected].Point1 = new_point1;
                _lines[index_selected].Point2 = new_point2;
                _lines[index_selected].LineColor = color_btn.ForeColor;
                //Re draw
                draw_add();
            }
            else
            {
                MessageBox.Show("Please select a line to update.");
            }
        }

        public void draw_circle(List<Point> centers)
        {
            Graphics g = picture_box1.CreateGraphics();
            foreach (var item in centers)
            {
                //Set radius
                int r = 4;
                Pen pen = new Pen(color_btn.ForeColor);
                g.DrawEllipse(pen, item.X - r, item.Y - r, r * 2, r * 2);
            }
        }

        private void find_its_btn_Click(object sender, EventArgs e)
        {
            List<Point> intersections = new List<Point>();
            //Check every pair using nested loop
            for (int i = 0; i < _lines.Count; i++)
            {
                for (int j = i + 1; j < _lines.Count; j++)
                {
                    Point its = return_intersection(_lines[i], _lines[j]);
                    //If there is no intersection the X and Y of the Point will be -99
                    if (!(its.X == -99 && its.Y == -99))
                    {
                        intersections.Add(its);
                    }
                }
            }

            if (intersections.Count == 0)
            {
                MessageBox.Show("There may be overlap but no intersections.");
            }

            draw_circle(intersections);
        }

        private void draw_line(Line line)
        {
            using (Graphics g = picture_box1.CreateGraphics())
            {
                Pen pen = new Pen(color_btn.ForeColor);
                g.DrawLine(pen, line.Point1, line.Point2);
            }
        }

        private Point return_intersection(Line line1, Line line2)
        {
            int line1_x1 = line1.Point1.X;
            int line1_y1 = line1.Point1.Y;
            int line1_x2 = line1.Point2.X;
            int line1_y2 = line1.Point2.Y;

            int line2_x1 = line2.Point1.X;
            int line2_y1 = line2.Point1.Y;
            int line2_x2 = line2.Point2.X;
            int line2_y2 = line2.Point2.Y;

            int dx1 = line1_x1 - line1_x2;
            int dy1 = line1_y1 - line1_y2;
            int dx2 = line2_x1 - line2_x2;
            int dy2 = line2_y1 - line2_y2;
            //Check if parallel
            if (dx1 * dy2 == dy1 * dx2)
            {
                //Check if on the same line
                if ((line1_x1 - line2_x1) * dy1 == (line1_y1 - line2_y1) * dx1)
                {
                    //parallel to the y lable
                    if (dx1 == 0 && dx2 == 0)
                    {
                        int min_line1_y = Math.Min(line1_y1, line1_y2);
                        int max_line1_y = Math.Max(line1_y1, line1_y2);
                        int min_line2_y = Math.Min(line2_y1, line2_y2);
                        int max_line2_y = Math.Max(line2_y1, line2_y2);
                        //Check if overlap
                        if (!(max_line1_y < min_line2_y || min_line1_y > max_line2_y))
                        {
                            int max_y1 = Math.Max(line1_y1, line2_y1);
                            int min_y2 = Math.Min(line1_y2, line2_y2);
                            if (max_y1 == line1_y1)
                            {
                                //line1_point1
                                if (min_y2 == line1_y2)
                                {
                                    // line1 point1 and line1 point2
                                    Line line = new Line(line1.Point1, line1.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                                else
                                {
                                    //line1_point1 and line2 point2
                                    Line line = new Line(line1.Point1, line2.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                            }
                            else
                            {
                                //line 2 point 1 
                                if (min_y2 == line1_y2)
                                {
                                    //line 2 point 1 and line 1 point2 
                                    Line line = new Line(line2.Point1, line1.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                                else
                                {
                                    //line 2 point 1 and line 2 point2 
                                    Line line = new Line(line2.Point1, line2.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                            }
                        }
                    }
                    else
                    {
                        // not parallel to the x label
                        int min_line1 = Math.Min(line1_x1, line1_x2);
                        int max_line1 = Math.Max(line1_x1, line1_x2);
                        int min_line2 = Math.Min(line2_x1, line2_x2);
                        int max_line2 = Math.Max(line2_x1, line2_x2);
                        //Check overlap
                        if (!(max_line1 < min_line2 || min_line1 > max_line2))
                        {
                            int max_x1 = Math.Max(line1_x1, line2_x1);
                            int min_x2 = Math.Min(line1_x2, line2_x2);
                            if (max_x1 == line1_x1)
                            {
                                //line1 point1
                                if (min_x2 == line1_x2)
                                {
                                    //line1 point1 and line1_point2
                                    Line line = new Line(line1.Point1, line1.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                                else
                                {
                                    //line1 point1 and line2_point2
                                    Line line = new Line(line1.Point1, line2.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                            }
                            else
                            {
                                //line2 point1
                                if (min_x2 == line1_x2)
                                {
                                    //line2 point 1 and line1 point2
                                    Line line = new Line(line2.Point1, line1.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                                else
                                {
                                    //line2 point 1 and line2 point2
                                    Line line = new Line(line2.Point1, line2.Point2, color_btn.ForeColor);
                                    draw_line(line);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                // Lines are not parallel or coincident
                int denominator = (line1_x1 - line1_x2) * (line2_y1 - line2_y2) -
                                  (line1_y1 - line1_y2) * (line2_x1 - line2_x2);
                double intersection_x =
                    ((line1_x1 * line1_y2 - line1_y1 * line1_x2) * (line2_x1 - line2_x2) -
                     (line1_x1 - line1_x2) * (line2_x1 * line2_y2 - line2_y1 * line2_x2)) / denominator;
                double intersection_y =
                    ((line1_x1 * line1_y2 - line1_y1 * line1_x2) * (line2_y1 - line2_y2) -
                     (line1_y1 - line1_y2) * (line2_x1 * line2_y2 - line2_y1 * line2_x2)) / denominator;
                //Check if intersection within in limited line
                if (check_bounds(intersection_x, intersection_y, line1) &&
                    check_bounds(intersection_x, intersection_y, line2))
                {
                    return new Point((int)intersection_x, (int)intersection_y);
                }
            }

            return new Point(-99, -99);
        }

        private bool check_bounds(double x, double y, Line line)
        {
            int minX = Math.Min(line.Point1.X, line.Point2.X);
            int maxX = Math.Max(line.Point1.X, line.Point2.X);
            int minY = Math.Min(line.Point1.Y, line.Point2.Y);
            int maxY = Math.Max(line.Point1.Y, line.Point2.Y);

            return x >= minX && x <= maxX && y >= minY && y <= maxY;
        }
    }
}