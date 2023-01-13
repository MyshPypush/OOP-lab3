using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyFigures
{
    public class Rocket
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int number;
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public Triangle head { get; set; }
        public Triangle Left_ear { get; set; }
        public Triangle Right_ear { get; set; }
        public Triangle Eye { get; set; }
        public Triangle Body { get; set; }
        public Triangle Tail { get; set; }
        public Triangle Left_leg { get; set; }
        public Triangle Right_leg { get; set; }
        public List<Triangle> Rocket_parts { get; set; } = new List<Triangle>();

        /// <summary>
        /// Ручка
        /// </summary>
        public Pen pen;

        public int left_x, high_y, right_x, low_y;
        static public int count = 0;

        public Rocket() { }

        public Rocket(int x, int y, int width, int height)
        {
            this.pen = new Pen(Color.Black, 3);
            this.x = x; this.y = y; this.width = width; this.height = height;
            left_x = x;
            high_y = y;
            right_x = x + width;
            low_y = y + height;
            if (left_x < 0 || high_y < 0 || right_x > pictureBox.Width || low_y > pictureBox.Height)
            {
                throw new Exception("Фигура должна помещаться на холст!");
            }
            else
            {
                Create_head();
                Create_left_ear();
                Create_right_ear();
                Create_eye();
                Create_body();
                Create_tail();
                Create_left_leg();
                Create_right_leg();
                FiguresContainer.RocketsList.Add(this);
                number = count;
                count++;
            }
        }
        private void Create_head()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x, y + height * 23 / 100);
                points[1] = new Point(x + width * 5 / 10, y + height * 33 / 100);
                points[2] = new Point(x + width * 5 / 10, y + height * 10 / 100);
                head = new Triangle(points, false);
                Rocket_parts.Add(head);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void Create_left_ear()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x + width * 32 / 100, y + height * 14 / 100);
                points[1] = new Point(x + width * 4 / 10, y + height * 2 / 100);
                points[2] = new Point(x + width * 4 / 10, y + height * 12 / 100);
                Left_ear = new Triangle(points, false);
                Rocket_parts.Add(Left_ear);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void Create_right_ear()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x + width * 42 / 100, y + height * 12 / 100);
                points[1] = new Point(x + width * 5 / 10, y);
                points[2] = new Point(x + width * 5 / 10, y + height * 1 / 10);
                Right_ear = new Triangle(points, false);
                Rocket_parts.Add(Right_ear);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void Create_eye()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x + width * 34 / 100, y + height * 22 / 100);
                points[1] = new Point(x + width * 37 / 100, y + height * 185 / 1000);
                points[2] = new Point(x + width * 40 / 100, y + height * 22 / 100);
                Eye = new Triangle(points, false);
                Rocket_parts.Add(Eye);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void Create_body()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x + width * 376 / 1000, y + height * 32 / 100);
                points[1] = new Point(x + width * 9 / 100, y + height * 87 / 100);
                points[2] = new Point(x + width * 63 / 100, y + height * 87 / 100);
                Body = new Triangle(points, false);
                Rocket_parts.Add(Body);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void Create_tail()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x + width * 578 / 1000, y + height * 729 / 1000);
                points[1] = new Point(x + width * 96 / 100, y + height * 4 / 10);
                points[2] = new Point(x + width, y + height * 63 / 100);
                Tail = new Triangle(points, false);
                Rocket_parts.Add(Tail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void Create_left_leg()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x + width * 25 / 100, y + height * 88 / 100);
                points[1] = new Point(x + width * 19 / 100, y + height);
                points[2] = new Point(x + width * 33 / 100, y + height);
                Left_leg = new Triangle(points, false);
                Rocket_parts.Add(Left_leg);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        private void Create_right_leg()
        {
            try
            {
                Point[] points = new Point[3];
                points[0] = new Point(x + width * 44 / 100, y + height * 88 / 100);
                points[1] = new Point(x + width * 38 / 100, y + height);
                points[2] = new Point(x + width * 52 / 100, y + height);
                Right_leg = new Triangle(points, false);
                Rocket_parts.Add(Right_leg);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        public void Draw(bool flag = true)
        {
            foreach (Triangle part in Rocket_parts)
            {                
                part.Draw(pen);
            }
            DrawText("Fox ", number, x, y + height * 3 / 5, width, height * 2 / 5);
        }

        public void MoveTo(int dx, int dy)
        {
            try
            {
                x += dx; 
                y += dy;
                left_x = x;
                high_y = y;
                right_x = x + width;
                low_y = y + height;
                if (left_x < 0 || high_y < 0 || right_x > pictureBox.Width || low_y > pictureBox.Height)
                {
                    throw new Exception("Фигура должна помещаться на холст!");
                }

                foreach (Triangle part in Rocket_parts)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        part.points[i].X += dx;
                        part.points[i].Y += dy;
                    }
                }

                DeleteF(this, false);
                //Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        public void ResizeRocket(int width, int height)
        {
            try
            {
                this.width = width; this.height = height;
                left_x = x - width;
                high_y = y - height;
                right_x = x + width * 2;
                low_y = y + height * 2;
                if (left_x < 0 || high_y < 0 || right_x > pictureBox.Width || low_y > pictureBox.Height)
                {
                    throw new Exception("Фигура должна помещаться на холст!");
                }
                
                Create_head();
                Create_left_ear();
                Create_right_ear();
                Create_eye();
                Create_tail();
                Create_left_leg();
                Create_body();
                Create_right_leg();
                DeleteF(this, false);
                //Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }

        }
        private void Button_New_Size_Click(object sender, EventArgs e)
        {
            try
            {
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        public void ClearMap()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.WhiteSmoke);
            pictureBox.Image = bitmap;
        }

        public void DeleteF(Rocket figure, bool flag)
        {
            Graphics g = Graphics.FromImage(bitmap);
            FiguresContainer.RocketsList.Remove(figure);
            ClearMap();

            if (flag != true)
            {
                FiguresContainer.RocketsList.Add(figure);
            }
            foreach (Rocket f in FiguresContainer.RocketsList)
            {
                f.Draw(false);
            }

            pictureBox.Image = bitmap;
        }
        public void DrawText(string type, int number)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString($"{type} {number}", new Font("Times New Roman", 10), Brushes.Gray, new RectangleF(x, y, width, height), sf);
        }
        public void DrawText(string type, int number, int x, int y, int width, int height)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString($"{type} {number}", new Font("Times New Roman", 10), Brushes.Gray, new RectangleF(x, y, width, height), sf);
        }
    }
}
