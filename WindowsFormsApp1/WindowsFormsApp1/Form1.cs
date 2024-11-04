using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Polyhedron polyhedron;
        private Bitmap bitmap;
        private Graphics graphics;

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
            graphics.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedShape = comboBox1.SelectedItem.ToString();
            float offsetX = pictureBox1.Width / 2;
            float offsetY = pictureBox1.Height / 2;

            switch (selectedShape)
            {
                case "Куб":
                    polyhedron.CreateCube(100, offsetX, offsetY);
                    break;
                case "Тетраэдр":
                    polyhedron.CreateCube(50, offsetX, offsetY);
                    break;
                case "Октаэдр":
                    polyhedron.CreateCube(25, offsetX, offsetY);
                    break;
            }

            pictureBox1.Invalidate();
        }
    }
}
