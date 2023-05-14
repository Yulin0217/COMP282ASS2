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

        private void DrawLine(Line line)
        {
            Graphics g = picture_box2.CreateGraphics();
            Pen pen = new Pen(color_btn.ForeColor);
            g.DrawLine(pen, line.Point1, line.Point2);
        }

        private void DrawLine_for_grid()
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
                    Line line = new Line(_points.ToArray()[0], _points.ToArray()[1], color_btn.ForeColor);
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
                MessageBox.Show("Nothing selected or select empty cell");
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
            }
        }

        private void dataGridView1_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            //Get current cell index
            int row_index = e.RowIndex;
            int column_index = e.ColumnIndex;

            // Check if click color cell (4)
            if (column_index == 4)
            {
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
                DataGridViewCell cell = dataGridView1.CurrentCell;

                if (cell.Value == null)
                {
                    return;
                }

                var FirstX = dataGridView1.Rows[cell.RowIndex].Cells[0].Value;
                var FirstY = dataGridView1.Rows[cell.RowIndex].Cells[1].Value;
                var SecondX = dataGridView1.Rows[cell.RowIndex].Cells[2].Value;
                var SecondY = dataGridView1.Rows[cell.RowIndex].Cells[3].Value;
                if (FirstX == null || FirstY == null || SecondX == null || SecondY == null)
                {
                    return;
                }

                //Check if digits using regex
                string inputFirstx = FirstX.ToString();
                string inputFirsty = FirstY.ToString();
                string inputSecondx = SecondX.ToString();
                string inputSecondy = SecondY.ToString();
                if (!(Regex.IsMatch(inputFirstx, "^[0-9]+$") || Regex.IsMatch(inputFirsty, "^[0-9]+$") || Regex.IsMatch(
                        inputSecondx, "^[0-9]+$") || Regex.IsMatch(inputSecondy, "^[0-9]+$")))
                {
                    MessageBox.Show("Can't be not digits!!!");
                    return;
                }

                _lines.Clear();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // Get first element in row
                    int X1 = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    int Y1 = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    int X2 = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    int Y2 = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    Color colorSet = dataGridView1.Rows[i].Cells[4].Style.BackColor;
                    Line line = new Line(new Point(X1, Y1), new Point(X2, Y2), colorSet);
                    _lines.Add(line);
                }

                DrawLine_for_grid();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Please click Color cell again");
            }
        }
    }
}