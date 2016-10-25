using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        public class Complex
        {
            //Real part
            private double a; //kryfh metavliti, synithizetai
            public double Real
            {
                get { return a; }
                set { a = value; }
            }

            //Imaginary part
            private double b;
            public double Imaginary
            {
                get { return b; }
                set { b = value; }
            }

            //Constructors
            public Complex() //xwris parametrous, san na exoun midenikh timh
            {
                a = 0;
                b = 0;
            }

            public Complex(double x) //sumvasi atyph.oti h mia parametros einai to real meros
            {
                a = x;
                b = 0;
            }


        public Complex(double x, double y)
        {
            a = x;
            b = y;
        }

        //Complex sum1=z1.Add(z2); //kalwntas th synartisi ws methodo tou antikeimenou, dinei apotelesma sum(real parts) + sum(imaginary parts)
    public Complex Add(Complex x) //epistrefei complex
        {
            double r = this.a + x.Real;
            double i = this.Imaginary + x.Imaginary;
            return new Complex(r, i);
            //return new Complex(r, i); san na grafw: Complex z =  new Complex(r, i)
            //return (z);
        }

        //Complex sum2 = Complex.Add(z1,z2);
        public static Complex Add(Complex x, Complex y) //an bazame this tha evgaze lathos
        {
            double r = x.Real + y.Real;
            double i = x.Imaginary + y.Imaginary;
            return new Complex(r, i);

        }

    //Complex sum3 = z1 + z2;
    public static Complex operator +(Complex x, Complex y)
    //xrhsimopoioume enan telesth kai oxi mia shnarthsh
    {
        double r = x.Real + y.Real;
        double i = x.Imaginary + y.Imaginary;
        return new Complex(r, i);
        //enallaktika:
        //return new Complex(x.a + y.a, x.b + y.b); a,b dioti eimaste mesa sthn klash alliws: x.Real + y.Real, x.Imaginary + y.Imaginary
    }

    public override string ToString() //override dioti yparxcei hdh h ToString
    {
//return $"({this.Real},{this.Imaginary})"; //typvnei (7,10)
return $"{this.Real}+{this.Imaginary}i"; //typwnei 7+10i
    }



    static void Main(string[] args)
    {
        Complex z1 = new Complex(5);
        Complex z2 = new Complex(2, 10);

        //Pws tha mporousa na kanw prosthesi? (tha ylopoihsoume kai touw treis tropous
        Complex sum1 = z1.Add(z2);
        Complex sum2 = Complex.Add(z1, z2); //edw to add einai statiki methodos, den xreiazetai na kalesoume to antikeimeno
        Complex sum3 = z1 + z2;

        //System.Math.Abs(-4); kalw thn methodo abs san statik kai oxi -4.Abs....

        Console.WriteLine(sum1); //typwnei ayto: Exercise1_12_10_2016.Program + Complex, vl.parapanw "ToString"
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);


        Console.ReadKey();


    }
}
}
}