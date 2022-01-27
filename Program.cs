using System;

namespace Tapshiriqlar_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

              //    1) 4 reqemli eded verilib.Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333 = 73338

              int a = 1234;
          
              if (a >= 1000 && a < 10000)
              {

                  a = a + 70000;
                  a = a * 10;
                  a = a + 8;
                Console.WriteLine(a);
              }
              else
              {
                  Console.WriteLine("4 reqemli eded deyildir");

              }
            
            //-------------------------------------------

            
           //    2) 3 reqemli eded verilib.Bu ededin axirina hemin ededdin ozunu yapishdir.example: 333 = 333333;

           int a = 333;
           bool successful = a >= 100 && a < 1000;

            if (successful)
            {
                //int m = a * 1000; //333000
                //int b = m + a;
                //Console.WriteLine(b);

                a = a + a * 1000;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }
            

            //----------------------------------------------------------------------
            

            //3) 5 reqemli eded verilib.Bu ededin evvel 18 % sonra ise 3 % tap.

            int a = 12345;
            bool successful = a >= 10000 && a < 100000;
            if (successful)
            {
                double b = a * 0.18;
                double c = b * 0.03;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
            
            //-----------------------------------------------------------------------
            
             
            //4) 3 reqemli eded verilib.Bu ededin axirina 7 artir.Sonra cavabin 7 % tap;

            int a = 123;
            bool successful = a >= 100 && a < 1000;
            if (successful)
            {
                int b = a * 10 + 7; //1237
                double c = b * 0.07;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
            

            //5) 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.
            
            int a = 1234;
            bool successful = a >= 1000 && a < 10000;
            if (successful)
            {
                a = a +40000; //41234
                a = a * 100 + 44; //4123444
                double b = a * 0.44;
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }

            //----------------------------------------------------------------------------------------

            //6) 4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.

            int a = 1234;
            double b = a * 0.20;
            b = b * 0.10;
            b = b * b;
            Console.WriteLine(b);

            //-----------------------------------------------------------
            
                        //7) 2 dene 5 reqemli eded verilib.Bu ededleri toplayib.Alinan cavabin evveline ve axirina 5 artir.Neticenin 5 % tap

                        int a = 12345;
                        int b = 67891;
                        bool qq = a >= 10000 && a < 100000;
                        bool rq = b >= 10000 && b < 100000;
                        if (qq == rq)
                        {
                            int c = a + b; //80236
                            c = c + 500000; //580236
                            c = c * 10 + 5; //5802365
                            double d = c * 0.05;
                            Console.WriteLine(d);

                        }
                        else
                        {
                            Console.WriteLine("shertler uygun deyil");
                        }
            

                       
                //-----------------------------------------------------------------------------------------------------
             

            //8) 2 dene eded verilib.I eded 4 reqemli II eded 7 reqemlidir.
            //  I ededin 4 % -ni tap.
            //  Sonra II ededin 9 % ni tap.
            //  Sonra Cavalari toplayib 10 % ni tap.

            int a = 1234;
            int b = 1234567;
            bool qq = a >= 1000 && a < 10000;
            bool ww = b >= 1000000 && b < 10000000;
            if (qq == ww)
            {
                double e = a * 0.04; //49.36
                double f = b * 0.09; //111111.03
                double g = e + f; //111160.39
                g = g * 0.10;  //11116.039
                Console.WriteLine(g);
            }
            else
            {
                Console.WriteLine("shertler uygun deyil");
            }
            

            //-------------------------------------------------------------------------------------

            //9) 3 dene 6 reqemli eded verilib.Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10 % tap.
            int a = 123123;
            int b = 123321;
            int c = 123213;
            bool qq = a >= 100000 && a < 1000000;
            bool ww = b >= 100000 && b < 1000000;
            bool ee = c >= 100000 && c < 1000000;

            if (qq == ww && ww == ee && ee == qq)
            {
                double z = a * 0.10;
                double x = b * 0.10;
                double y = c * 0.10;
                double t = z + x + y;
                t = t * 0.10;
                Console.WriteLine(t);

            }
            else
            {
                Console.WriteLine("deyildir");
            }
            
            //------------------------------------------------------------------------------------

            //10) 3 dene 4 reqemli eded verilib.I ededin 1 % -ni, II ededin 2 % , III ededin 3 % tap.
            // Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel

            int a = 1234;
            int b = 4321;
            int c = 2134;
            bool qq = a >=1000 && b >=1000 && c >=1000;
            bool rq = a <10000 && b <10000 && c < 10000;
            if (qq == rq)
            {
                double d = a * 0.01; //12.34
                double e = b * 0.02; //86.42
                double f = c * 0.03; //64.02
                double s = d - e - f;
                //short s = (short)(d - e - f);
                double t = c * 0.07; //149.38
                s = s + t;
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("shertler uygun deyil");
            }
            

                //-----------------------------------------------------------------------------------------------------------

            //11) 4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.
            //Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.

            int a = 11111;
            int b = 22222;
            int c = 33333;
            int d = 44444;
            bool qq = a >= 10000 && b >= 10000 && c >= 10000 && d >= 10000;
            bool ww = a <= 100000 && b <= 100000 && c <= 100000 && d <= 100000;
            if (qq == ww)
            {
                int e = a + c; //44444              
                int f = b + d; //66666
                double t = c * 0.03;            
                uint g = (uint)(e * f); //2962903704
                double m = g - t;
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine("shertler uygun deyil");
            }
            
                         //-----------------------------------------------------------------------------------------------

            //12) 4 dene 6 reqemli eded verilib.Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
            //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap

            int a = 111111;
            int b = 222222;
            int c = 333333;
            int d = 444444;
            bool qq = a >= 100000 && b >= 100000 && c >= 100000 && d >= 100000;
            bool ww = a <= 1000000 && b <= 1000000 && c <= 1000000 && d <= 1000000;
            if (qq == ww)
            {
                double m = (a * 0.10) + (b * 0.10) + (c * 0.10) + (d * 0.10); //111111
                double n = (a * 0.15) + (b * 0.15) + (c * 0.15) + (d * 0.15); //166666.5
                double e = m * n; //18518481481.5
                e = e * 0.10; //1851848148.15
                e = e * 0.11; //203703296.2965
                Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine("shertler uygun deyil");
            }
            
               //---------------------------------------------------------------------------------------------------------
            //13) 5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine.
            //Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.

            int a = 111;
            int b = 222;
            int c = 11111;
            int d = 22222;
            int e = 33333;
            bool qq = a >= 100 && b >= 100;
            bool rq = a <= 1000 && b <= 1000;
            bool ww = c >= 10000 && d >= 10000 && e >= 10000;
            bool we = c <= 100000 && d <= 100000 && e <= 100000;
            if (qq == rq == ww == we)
            {
                double s = (c * 0.05) * (d * 0.05) * (e * 0.05); //1028775720.4732503
                double l = (a * 0.03) + (b * 0.03); //9.99
                double k = (s * 0.10) + (l * 0.10); //102877573.04632503
                Console.WriteLine(k);

            }
            else
            {
                Console.WriteLine("sehvdi");
            }
            

            //14) 6 dene 6 reqemli eded verilib.Evvel hamisini topla.Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            //I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.

            long a = 100001;
            int b = 200002;
            int c = 300003;
            int d = 400004;
            int e = 500005;
            int f = 600006;
            bool qq = a >=100000 && b >=100000 && c >=100000 && d >=100000 && e >=100000 && f >=100000;
            bool ww = a <=1000000 && b <=1000000 && c <=1000000 && d <=1000000 && e <=1000000 && f <=1000000;
            if (qq == ww)
            {
                long s =a + b + c + d + e + f;
                long t = (a * 1000000) + c;
                decimal u = ((s - t) * 10) / 100;
                decimal v = (e + f) + u;
                decimal z = (v * 11) / 100;
                

                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("Shertler uygun deyil");
            }
            

            //-------------------------------------------------------------------------------------------------

            //15)*7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
            //3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            //Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.          
            //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.          
            //Sonra alinan cavabin ustune gel 6 reqemli ededi.           
            //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            
            //Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.


            int a = 123;
            int b = 456;
            int c = 1234;
            int d = 5678;
            int e = 12345;
            int f = 67891;
            int g = 123456;


            int q = ((a + b) + (c * d)) * 10 +7;            
            int t = e + f;
            q = q + t;
            int v = (a * b) * 10 + 1; 
            int w =(q - v) + g;            
            int y = a + b + c + d;
            int z = w - y;
            
            double i = z * 0.18;
            i = i * 0.03;
            i = i * 0.01;
            i = i + t;

            Console.WriteLine(i); // 84000.212398
            */












        }

    }
}
