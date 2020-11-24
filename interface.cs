using System;

namespace ConsoleApp13
{
      public class A : IArOperation
        {
        double My_x, My_y;
        public double x { 
            set { My_x = value; }
            get { return My_x; }
        }
        public double y { 
            set { My_y = value; } 
            get { return My_y; } 
        }
        public A() { }
            public A(double x, double y)
            {
            this.x = x;
            this.y = y;
            }
            public double Del()
            {
                return x / y;
            }
            public double Otr()
            {
                return x - y;
            }
            public double Prz()
            {
                return x * y;
            }
            public virtual double Sum()
            {
                return x + y;
            }
            public virtual void rewrite()
            {
            Console.WriteLine(x);
            }

    }
      public class Aa : A
     {
          public double z;
          public Aa(double x, double y, double Z)
            :base(x,y)
          {
            this.z = Z;
          }
        public override void rewrite()
        {
            base.rewrite();
        }
        public override double Sum()
        {
            return x + y + z;
        }

    }
        class Ab : A, ISqrSqrt
        {
        public double Sqr(double x, double y)
        {
            return Math.Pow(x,y);
        }
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        
    }
    public interface IArOperation
    {
        double Del();
        double Otr();
        double Prz();
        double Sum();

    }
    public interface ISqrSqrt
    {
        double Sqr(double x,double y);
        double Sqrt(double x);
    }
    class Program
    {
        static void Main()
        {
            A a = new A(4, 4);
            Aa aa = new Aa(4, 4, 4);
            Ab ab = new Ab();
            Console.WriteLine(a.Sum());
            Console.WriteLine(aa.Sum());
            Console.WriteLine(ab.Sqr(4,4));
            Console.WriteLine(ab.Sqrt(16));
            Console.Read();
        }
    }

}
