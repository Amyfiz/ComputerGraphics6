using System;
using System.Drawing;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Polyhedron polyhedron;
        private Bitmap bitmap;
        private Graphics graphics;

        float moveX;
        float moveY;
        float moveZ;

        float rotateX;
        float rotateY;
        float rotateZ;


        public Form1()
        {
            InitializeComponent();
            polyhedron = new Polyhedron();
            comboBox1.Items.AddRange(new string[] { "Куб", "Тетраэдр", "Октаэдр", "Deez" });
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Paint += new PaintEventHandler(this.PictureBox1_Paint);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            graphics.Clear(Color.White); // Очистка изображения
            polyhedron.DrawShape(graphics); // Отрисовка куба
            e.Graphics.DrawImage(bitmap, 0, 0); // Отображение изображения в PictureBox
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            Invalidate(); // Перерисовка формы при изменении размера
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*graphics.Clear(Color.White);
            pictureBox1.Invalidate();*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedShape = comboBox1.SelectedItem.ToString();
            float offsetX = pictureBox1.Width / 2;
            float offsetY = pictureBox1.Height / 2;
            float size = 100;

            switch (selectedShape)
            {
                case "Куб":
                    polyhedron.points.Add(new Point(-size / 2 + offsetX, -size / 2 + offsetY, -size / 2));
                    polyhedron.points.Add(new Point(size / 2 + offsetX, -size / 2 + offsetY, -size / 2));
                    polyhedron.points.Add(new Point(size / 2 + offsetX, size / 2 + offsetY, -size / 2));
                    polyhedron.points.Add(new Point(-size / 2 + offsetX, size / 2 + offsetY, -size / 2));
                    polyhedron.points.Add(new Point(-size / 2 + offsetX, -size / 2 + offsetY, size / 2));
                    polyhedron.points.Add(new Point(size / 2 + offsetX, -size / 2 + offsetY, size / 2));
                    polyhedron.points.Add(new Point(size / 2 + offsetX, size / 2 + offsetY, size / 2));
                    polyhedron.points.Add(new Point(-size / 2 + offsetX, size / 2 + offsetY, size / 2));
                    polyhedron.DrawShape(graphics);
                    break;
                case "Тетраэдр":
                    //polyhedron.CreateCube(50, offsetX, offsetY);
                    break;
                case "Октаэдр":
                    //polyhedron.CreateCube(25, offsetX, offsetY);
                    break;
                default:
                    break;
            }

            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e) // Scale
        {
            polyhedron.Scale(0.9f, 0.9f, 0.9f);
            graphics.Clear(Color.White); // Очистка изображения
            polyhedron.DrawShape(graphics); // Отрисовка куба
            graphics.DrawImage(bitmap, 0, 0); // Отображение изображения в PictureBox
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e) // Rotate
        {
            polyhedron.Scale(1.1f, 1.1f, 1.1f);
            graphics.Clear(Color.White); // Очистка изображения
            polyhedron.DrawShape(graphics); // Отрисовка куба
            graphics.DrawImage(bitmap, 0, 0); // Отображение изображения в PictureBox
            pictureBox1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            polyhedron.Move(moveX, moveY, moveZ);
            graphics.Clear(Color.White); // Очистка изображения
            polyhedron.DrawShape(graphics); // Отрисовка куба
            graphics.DrawImage(bitmap, 0, 0); // Отображение изображения в PictureBox
            pictureBox1.Invalidate();
        }

        private void textBox_MoveX_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MoveX.Text) || !float.TryParse(textBox_MoveX.Text, out moveX))
            {
                moveX = 0f;
            }
            else
                moveX = float.Parse(textBox_MoveX.Text);
        }

        private void textBox_MoveY_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MoveY.Text) || !float.TryParse(textBox_MoveY.Text, out moveX))
            {
                moveY = 0f;
            }
            else
                moveY = float.Parse(textBox_MoveY.Text);
        }

        private void textBox_MoveZ_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MoveZ.Text) || !float.TryParse(textBox_MoveZ.Text, out moveX))
            {
                moveZ = 0f;
            }
            else
                moveZ = float.Parse(textBox_MoveZ.Text);
        }

        private void textBox_RotateX_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_RotateX.Text) || !float.TryParse(textBox_RotateX.Text, out moveX))
            {
                rotateX = 0f;
            }
            else
                rotateX = float.Parse(textBox_RotateX.Text);
        }

        private void textBox_RotateY_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_RotateY.Text) || !float.TryParse(textBox_RotateY.Text, out moveX))
            {
                rotateY = 0f;
            }
            else
                rotateY = float.Parse(textBox_RotateY.Text);
        }

        private void textBox_RotateZ_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_RotateZ.Text) || !float.TryParse(textBox_RotateZ.Text, out moveX))
            {
                rotateZ = 0f;
            }
            else
                rotateZ = float.Parse(textBox_RotateZ.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            polyhedron.Rotate(rotateX, rotateY, rotateZ);
            graphics.Clear(Color.White); // Очистка изображения
            polyhedron.DrawShape(graphics); // Отрисовка куба
            graphics.DrawImage(bitmap, 0, 0); // Отображение изображения в PictureBox
            pictureBox1.Invalidate();
        }
    }
}
