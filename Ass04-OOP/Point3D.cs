using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04_OOP
{
    internal class Point3D : IComparable , ICloneable
    {
        #region Attribute
        private int x;
        private int y;
        private int z;
        #endregion
        #region Property
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        #endregion
        #region Constructor
        public Point3D(int _x , int _y , int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        public Point3D(int _x , int _y) : this (_x , _y , 0)
        {

        }
        public Point3D()
        {
            X = Y = Z = 0;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        //Create Points
        public static Point3D CreatePoint()
        {
            int x; int y ; int z;
            bool flag01; bool flag02; bool flag03;

            do
            {
                Console.Write("Enter X : ");
                flag01 = int.TryParse(Console.ReadLine(), out x);
            }while (!flag01);

            do
            {
                Console.Write("Enter Y : ");
                flag02 = int.TryParse(Console.ReadLine(),out y);
            }while(!flag02);

            do
            {
                Console.Write("Enter Z : ");
                flag03 = int.TryParse(Console.ReadLine(), out z);
            }while(!flag03);

            return new Point3D(x, y, z);
        }

        //operator overloading
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1.x != p2.x || p1.y != p2.y || p1.z != p2.z;
        }

        //print array
        public static void PrintArray(Point3D[] array)
        {
            if(array is not null)
            {
                return;
            }
            for(int i = 0; i < array?.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //sort array
        public static void SortArray(Point3D[] array)
        {
            Array.Sort(array);
        }

        public int CompareTo(object? obj)
        {
            Point3D? p = (Point3D?) obj;
            if(p is not null)
            {
                if (x > p.x)
                    return 1;
                else if (p.x > x)
                    return -1;
                else if (y > p.y) 
                    return 1;
                else if (p.y > y)
                    return -1;
                else 
                    return 0;
            }
            return 0;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
