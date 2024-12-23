﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Polyhedron
    {
        public List<Point> points;
        public List<Edge> edges;

        public Polyhedron()
        {
            points = new List<Point>();
            edges = new List<Edge>();
        }
        private void UpdateEdges()
        {
            if (points.Count == 0)
                return;
            edges.Clear();
            edges.Add(new Edge(points[0], points[1]));
            edges.Add(new Edge(points[1], points[2]));
            edges.Add(new Edge(points[2], points[3]));
            edges.Add(new Edge(points[3], points[0]));
            edges.Add(new Edge(points[4], points[5]));
            edges.Add(new Edge(points[5], points[6]));
            edges.Add(new Edge(points[6], points[7]));
            edges.Add(new Edge(points[7], points[4]));
            edges.Add(new Edge(points[0], points[4]));
            edges.Add(new Edge(points[1], points[5]));
            edges.Add(new Edge(points[2], points[6]));
            edges.Add(new Edge(points[3], points[7]));
        }
        public void DrawShape(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            UpdateEdges();

            foreach (var edge in edges)
            {
                g.DrawLine(pen, edge.start.ToPointF(), edge.end.ToPointF());
            }
        }

        public void Move(float mx, float my, float mz)
        {
            Matrix translationMatrix = Matrix.Translation(mx, my, mz);

            for (int i = 0; i < points.Count; i++)
            {
                Point p = points[i];
                float[] pointArray = { p.X, p.Y, p.Z, 1 };
                float[] resultArray = new float[4];

                for (int row = 0; row < 4; row++)
                {
                    resultArray[row] = 0;
                    for (int col = 0; col < 4; col++)
                    {
                        resultArray[row] += translationMatrix.Elements[row, col] * pointArray[col];
                    }
                }

                points[i] = new Point(resultArray[0], resultArray[1], resultArray[2]);
            }

            UpdateEdges();
        }

        public void Rotate(float rx, float ry, float rz)
        {
            float centerX = points.Average(p => p.X);
            float centerY = points.Average(p => p.Y);
            float centerZ = points.Average(p => p.Z);

            MessageBox.Show(centerX + " " + centerY + " " + centerZ);

            Matrix rotationX = Matrix.RotationX(rx);
            Matrix rotationY = Matrix.RotationX(ry);
            Matrix rotationZ = Matrix.RotationX(rz);

            Matrix rotationMatrix = rotationX * rotationY * rotationZ;

            for (int i = 0; i < points.Count; i++)
            {
                Point p = points[i];
                float[] pointArray = { p.X, p.Y, p.Z, 1 };
                float[] resultArray = new float[4];

                for (int row = 0; row < 4; row++)
                {
                    resultArray[row] = 0;
                    for (int col = 0; col < 4; col++)
                    {
                        resultArray[row] += rotationMatrix.Elements[row, col] * pointArray[col];
                    }
                }

                points[i] = new Point(resultArray[0], resultArray[1], resultArray[2]);
            }
            centerX = points.Average(p => p.X);
            centerY = points.Average(p => p.Y);
            centerZ = points.Average(p => p.Z);

            MessageBox.Show(centerX + " " + centerY + " " + centerZ);

            UpdateEdges();
        }

        public void Scale(float sx, float sy, float sz)
        {
            Matrix scaleMatrix = Matrix.Scale(sx, sy, sz);

            // Вычисляем центр фигуры
            float centerX = points.Average(p => p.X);
            float centerY = points.Average(p => p.Y);
            float centerZ = points.Average(p => p.Z);

            for (int i = 0; i < points.Count; i++)
            {
                Point p = points[i];
                float[] pointArray = { p.X - centerX, p.Y - centerY, p.Z - centerZ, 1 };
                float[] resultArray = new float[4];

                for (int row = 0; row < 4; row++)
                {
                    resultArray[row] = 0;
                    for (int col = 0; col < 4; col++)
                    {
                        resultArray[row] += scaleMatrix.Elements[row, col] * pointArray[col];
                    }
                }

                points[i] = new Point(resultArray[0] + centerX, resultArray[1] + centerY, resultArray[2] + centerZ);
            }

            UpdateEdges();
        }


    }
}
