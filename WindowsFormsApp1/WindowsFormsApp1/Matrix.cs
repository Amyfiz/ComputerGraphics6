using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Matrix
    {
        public float[,] Elements { get; set; }

        public Matrix()
        {
            Elements = new float[4, 4];
            for (int i = 0; i < 4; i++)
            {
                Elements[i, i] = 1;
            }
        }

        public static Matrix Translation(float dx, float dy, float dz)
        {
            Matrix matrix = new Matrix();
            matrix.Elements[0, 3] = dx;
            matrix.Elements[1, 3] = dy;
            matrix.Elements[2, 3] = dz;

            return matrix;
        }

        public static Matrix RotationX(float angle)
        {
            Matrix matrix = new Matrix();
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            matrix.Elements[1, 1] = cos;
            matrix.Elements[1, 2] = -sin;
            matrix.Elements[2, 1] = sin;
            matrix.Elements[2, 2] = cos;

            return matrix;
        }

        public static Matrix RotationY(float angle)
        {
            Matrix matrix = new Matrix();
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            matrix.Elements[1, 1] = cos;
            matrix.Elements[0, 2] = sin;
            matrix.Elements[2, 0] = -sin;
            matrix.Elements[2, 2] = cos;

            return matrix;
        }

        public static Matrix RotationZ(float angle)
        {
            Matrix matrix = new Matrix();
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            matrix.Elements[0, 0] = cos;
            matrix.Elements[0, 1] = -sin;
            matrix.Elements[1, 0] = sin;
            matrix.Elements[1, 1] = cos;

            return matrix;
        }

        public static Matrix Scale(float sx, float sy, float sz)
        {
            Matrix matrix = new Matrix();
            matrix.Elements[0, 0] = sx;
            matrix.Elements[1, 1] = sy;
            matrix.Elements[2, 2] = sz;

            return matrix;
        }

        public static Point TransformPoint(Point point, Matrix matrix)
        {
            float[] result = new float[4];
            float[] input = { point.X, point.Y, point.Z, 1 };
            for (int i = 0; i < 4; i++)
            {
                result[i] = 0;
                for (int j = 0; j < 4; j++)
                {
                    result[i] += result[j] * matrix.Elements[j, i];
                }
            }

            return new Point(result[0], result[1], result[2]);
        }

        
    }
}
