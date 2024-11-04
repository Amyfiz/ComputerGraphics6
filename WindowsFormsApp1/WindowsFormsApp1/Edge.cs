using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Edge
    {
        public Point start { get; set; }
        public Point end { get; set; }
        List<Point> neighbors;


        public Edge(Point _a, Point _b)
        {
            start = _a;
            end = _b;
        }
    }
}
