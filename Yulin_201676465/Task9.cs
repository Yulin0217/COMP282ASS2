using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DrawLines
{
    public partial class Task9 : Form
    {
        private List<Line> _lines = new List<Line>();
        private List<Point> _points = new List<Point>();

        public Task9()
        {
            InitializeComponent();
        }


        private void color_btn_Click(object sender, EventArgs e)
        {
            if (color_dialog_2.ShowDialog() == DialogResult.OK)
            {
                color_btn.ForeColor = color_dialog_2.Color;
            }
        }

        public void draw_add()
        {
            try
            {
                remove_btn.Enabled = true;
                Graphics g = picture_box2.CreateGraphics();
                g.Clear(picture_box2.BackColor);
                dataGridView1.Rows.Clear();
                foreach (Line line in _lines)
                {
                    Pen pen = new Pen(line.LineColor);
                    g.DrawLine(pen, line.Point1, line.Point2);
                    //Add new line in datagridview
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = line.Point1.X;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = line.Point1.Y;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = line.Point2.X;
                    dataGridView1.Rows[rowIndex].Cells[3].Value = line.Point2.Y;
                    dataGridView1.Rows[rowIndex].Cells[4].Style.BackColor = line.LineColor;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void draw_line(Line line)
        {
            Graphics g = picture_box2.CreateGraphics();
            Pen pen = new Pen(color_btn.ForeColor);
            g.DrawLine(pen, line.Point1, line.Point2);
        }

        private void draw_line_for_grid()
        {
            Graphics g = picture_box2.CreateGraphics();
            g.Clear(picture_box2.BackColor);
            foreach (Line line in _lines)
            {
                Pen pen = new Pen(line.LineColor);
                g.DrawLine(pen, line.Point1, line.Point2);
            }
        }

        private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
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


        private void remove_btn_Click_1(object sender, EventArgs e)
        {
            // Get the currently selected item index
            DataGridViewCell selected_cell = dataGridView1.CurrentCell;

            //Check whether there is no line
            if (_lines.Count == 0)
            {
                MessageBox.Show("Nothing selected or select empty cell!!!");
                return;
            }

            //Check if selsect empty cell
            if (selected_cell.Value == null)
            {
                MessageBox.Show("Do not select empty cell!");
                return;
            }

            _lines.RemoveAt(selected_cell.RowIndex);
            draw_add();
            if (_lines.Count == 0)
            {
                // No lines left, disable remove button and clear picture box
                remove_btn.Enabled = false;
                Graphics g = picture_box2.CreateGraphics();
                g.Clear(Color.White);
                MessageBox.Show("All lines are deleted");
            }
        }

        private void dataGridView1_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selected_cell = dataGridView1.CurrentCell;

            //Get current cell index
            int row_index = e.RowIndex;
            int column_index = e.ColumnIndex;

            // Check if click color cell (4)
            if (column_index == 4)
            {
                //Check whether any of cell in this row is null
                var FirstX = dataGridView1.Rows[selected_cell.RowIndex].Cells[0].Value;
                var FirstY = dataGridView1.Rows[selected_cell.RowIndex].Cells[1].Value;
                var SecondX = dataGridView1.Rows[selected_cell.RowIndex].Cells[2].Value;
                var SecondY = dataGridView1.Rows[selected_cell.RowIndex].Cells[3].Value;
                if (FirstX == null || FirstY == null || SecondX == null || SecondY == null)
                {
                    MessageBox.Show("Please enter all coordinates before select color!");
                    return;
                }

                if (color_dialog_2.ShowDialog() == DialogResult.OK)
                {
                    var colorSet = color_dialog_2.Color;
                    _lines[row_index].LineColor = colorSet;
                    draw_add();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCell selected_cell = dataGridView1.CurrentCell;
                //If selected a null cell, stop continue, waiting for input
                if (selected_cell.Value == null)
                {
                    MessageBox.Show("Please enter all coordinates first!");
                    return;
                }

                //Check whether any of cell in this row is null
                var FirstX = dataGridView1.Rows[selected_cell.RowIndex].Cells[0].Value;
                var FirstY = dataGridView1.Rows[selected_cell.RowIndex].Cells[1].Value;
                var SecondX = dataGridView1.Rows[selected_cell.RowIndex].Cells[2].Value;
                var SecondY = dataGridView1.Rows[selected_cell.RowIndex].Cells[3].Value;
                if (FirstX == null || FirstY == null || SecondX == null || SecondY == null)
                {
                    return;
                }

                //Check if digits using regex
                string inputFirstx = FirstX.ToString();
                string inputFirsty = FirstY.ToString();
                string inputSecondx = SecondX.ToString();
                string inputSecondy = SecondY.ToString();
                if (!(Regex.IsMatch(inputFirstx, "^[0-9]+$") && Regex.IsMatch(inputFirsty, "^[0-9]+$") && Regex.IsMatch(
                        inputSecondx, "^[0-9]+$") && Regex.IsMatch(inputSecondy, "^[0-9]+$")))
                {
                    MessageBox.Show("Can't be not digits!!!");
                    return;
                }

                _lines.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // Get first element in row
                    int first_x = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    int first_y = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    int second_x = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    int second_y = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    Color line_color = dataGridView1.Rows[i].Cells[4].Style.BackColor;
                    Line line = new Line(new Point(first_x, first_y), new Point(second_x, second_y), line_color);
                    _lines.Add(line);
                }

                draw_line_for_grid();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Please click Color cell again");
            }
        }

        public void draw_circle(List<Point> centers)
        {
            Graphics g = picture_box2.CreateGraphics();
            foreach (var item in centers)
            {
                //Set radius
                int r = 4;
                Pen pen = new Pen(color_btn.ForeColor);
                g.DrawEllipse(pen, item.X - r, item.Y - r, r * 2, r * 2);
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
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
                if (check_bounds(intersection_x, intersection_y, line1) ||
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