using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cube: Polyhedron
    {

        /*public Cube(float size, float offsetX, float offsetY)
        {
            points.Add(new Point(-size / 2 + offsetX, -size / 2 + offsetY, -size / 2));
            points.Add(new Point(size / 2 + offsetX, -size / 2 + offsetY, -size / 2));
            points.Add(new Point(size / 2 + offsetX, size / 2 + offsetY, -size / 2));
            points.Add(new Point(-size / 2 + offsetX, size / 2 + offsetY, -size / 2));
            points.Add(new Point(-size / 2 + offsetX, -size / 2 + offsetY, size / 2));
            points.Add(new Point(size / 2 + offsetX, -size / 2 + offsetY, size / 2));
            points.Add(new Point(size / 2 + offsetX, size / 2 + offsetY, size / 2));
            points.Add(new Point(-size / 2 + offsetX, size / 2 + offsetY, size / 2));
        }*/
        public Cube(List<Point> points)
        {
            // Создание вершин куба
            for (int i = 0; i < points.Count; i++)
            {
                this.points[i] = points[i];
            }

            // Создание рёбер куба
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
    }
}
