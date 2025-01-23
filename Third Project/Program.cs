namespace Third_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2.Override All System.Object Members (ToString, Equals,GetHasCode).
            //Duration D1 = new Duration(2,45,30);
            //Duration D2 = new Duration(2, 45, 30);

            //Console.WriteLine($"Duration01 : {D1}");
            //Console.WriteLine($"Duration02 : {D2}");

            //Console.WriteLine("Are both durations equal? " + D1.Equals(D2));

            //Console.WriteLine("Hash code of duration01: " + D1.GetHashCode());
            //Console.WriteLine("Hash code of duration02: " + D2.GetHashCode());

            #endregion

            #region 3.Define All Required Constructors to Produce this output
            ////1
            //Duration D01 = new Duration(2,44,30);
            //Console.WriteLine(D01.ToString());

            ////2
            //Duration D02 = new Duration(3600);
            //Console.WriteLine(D02.ToString());

            ////3
            //Duration D03 = new Duration(7800);
            //Console.WriteLine(D03.ToString());

            ////4
            //Duration D04 = new Duration(666);
            //Console.WriteLine(D04.ToString());
            #endregion

            #region Implement All required Operators overloading to enable this Code:
            ////1. D3=D1+D2
            //Duration D1 = new Duration(1, 30, 45); 
            //Duration D2 = new Duration(0, 45, 30); 

            //Duration D3 = D1 + D2;
            //Console.WriteLine(D3.ToString());

            ////2. D3=D1 + 7800
            //Duration D1 = new Duration(1, 30, 45);
            //Duration D3 = D1 + 7800;
            //Console.WriteLine(D3.ToString());

            ////3.D3 = 666 + D3
            //Duration D3 = new Duration(1, 10, 15);
            //Console.WriteLine(D3 = 666 + D3);

            ////4. D3= ++D1 (Increase One Minute)
            //Duration D1 = new Duration(1, 21, 30);
            //Duration D3 = ++D1;
            //Console.WriteLine(D3);

            //Duration D01 = new Duration(1, 60, 30);
            //Duration D03 = ++D01;
            //Console.WriteLine(D03);

            ////5. D3 = --D2 (Decrease One Minute)
            //Duration D1 = new Duration(1, 0, 30);
            //Duration D3 = --D1;
            //Console.WriteLine(D3);

            //Duration D01 = new Duration(1, 10, 30);
            //Duration D03 = --D01;
            //Console.WriteLine(D03);

            ////6.D1 = D1 - D2
            //Duration D1 = new Duration(4, 20, 40);
            //Duration D2 = new Duration(2, 10, 30);
            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            ////7. If (D1>D2)
            //Duration D1 = new Duration(2, 10, 30);  
            //Duration D2 = new Duration(1, 30, 45); 
            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1 > D2");
            //}
            //else if (D1 < D2)
            //{
            //    Console.WriteLine("D1 < D2.");
            //}

            ////8. If (D1<=D2)
            //Duration D1 = new Duration(1, 45, 30);  
            //Duration D2 = new Duration(2, 10, 15);  

            //if (D1 <= D2)
            //{
            //    Console.WriteLine("D1 <= D2.");
            //}
            //else if(D1 >= D2)
            //{
            //    Console.WriteLine("D1 >= D2.");
            //}

            ////9. if(D1) => true
            //Duration D1 = new Duration(1, 30, 0);  
            //Duration D2 = new Duration(0, 0, 0);  

            //if (D1)
            //{
            //    Console.WriteLine("D1 is a non-zero duration.");
            //}
            //else
            //{
            //    Console.WriteLine("D1 is a zero duration.");
            //}
            //if (D2)
            //{
            //    Console.WriteLine("D2 is a non-zero duration.");
            //}
            //else
            //{
            //    Console.WriteLine("D2 is a zero duration.");
            //}

            #endregion
        }
    }
}
