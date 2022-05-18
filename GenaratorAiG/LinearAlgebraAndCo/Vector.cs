using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraAndCo
{
    public class Vector
    {
        public int[] Coordinates { get; private set; }
        public Vector(params int[] coordinates)
        {
            Coordinates = coordinates;
        }
        public static Vector GenerateRandomVector(int n, Random random, int minCoord, int maxCoord)
        {
            if (n < 1) return null;
            int[] coords = new int[n];
            do
            {
                for (int i = 0; i < n; i++)
                {
                    coords[i] = random.Next(minCoord, maxCoord);
                }
            } while (coords.All(s => s == 0));
            return new Vector(coords);
        }
        public int ScalarProduct(Vector x) 
        {
            if (x.Coordinates.Length != Coordinates.Length)
            {
                throw new Exception("Размерности векторов не равны");
            }
            int scalarProduct = 0;
            for (int i = 0; i < Coordinates.Length; i++)
            {
                scalarProduct += Coordinates[i] * x.Coordinates[i];
            }
            return scalarProduct;
        }
        public static Vector operator +(Vector a) => a;
        public static Vector operator -(Vector a)
        {
            int[] newCoords = new int[a.Coordinates.Length];
            for (int i = 0; i < a.Coordinates.Length; i++)
            {
                newCoords[i] = -a.Coordinates[i];
            }
            return new Vector(newCoords);
        }
        public static Vector operator +(Vector a, Vector b)
        {
            if (a.Coordinates.Length == b.Coordinates.Length)
            {
                int[] newCoords = new int[a.Coordinates.Length];
                for (int i = 0; i < a.Coordinates.Length; i++)
                {
                    newCoords[i] = a.Coordinates[i] + b.Coordinates[i];
                }
                return new Vector(newCoords);
            }
            return null;
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return a + (-b);
        }
    }
}
