//-------Task 1-----//

//using System;
//using System.Net.NetworkInformation;

//namespace Methods
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            float a = float.Parse(Console.ReadLine());
//            float b = float.Parse(Console.ReadLine());
//            string opinput = Console.ReadLine();



//            if (opinput.Length != 1)
//            {
//                Console.WriteLine("Operator daxil edin");
//                return;
//            }

//            char op = opinput[0];
//            float result = Hesabla(a, b, op);
//            Console.WriteLine(result);


//        }

//        static float Hesabla(float a, float b, char op)
//        {
//            switch (op)
//            {
//                case '+':
//                    return a + b;
//                case '-':
//                    return a - b;
//                case '*':
//                    return a * b;
//                case '/':
//                    if (b != 0)
//                        return a / b;
//                    else
//                    {
//                        Console.WriteLine("Sıfıra bölmək olmaz");
//                        return float.NaN;
//                    }
//                default:
//                    Console.WriteLine("Yanlış operator");
//                    return float.NaN;
//            }
//        }
//    }

//}

//----------Task 2 --------//

//using System;
//using System.Runtime.CompilerServices;
//using System.Runtime.Serialization.Formatters;

//namespace Methods
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a = Convert.ToDouble(Console.ReadLine());
//            string ikinciEded = Console.ReadLine();

//            if (ikinciEded != "")
//            {
//                double b = Convert.ToDouble(ikinciEded);
//                double result = method2(a, b);
//                Console.WriteLine(result);
//            }
//            else
//            {
//                double pow = method2(a);
//                Console.WriteLine(pow);

//            }
//        }
//        static double method2(double a,double b = 0)
//        {
//            if (b == 0)
//            {
//                return a * a;
//            }

//            else
//            {
//                double result = 1;
//                for (int i = 0; i < b; i++)
//                {
//                    result *= a;
//                }
//                return result;

//            }
//        }
//    }
//}

//-------Task 3-------//

//using System;
//using System.Diagnostics.Eventing.Reader;
//using System.Runtime.CompilerServices;
//using System.Runtime.Serialization.Formatters;

//namespace Methods
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string ad = Console.ReadLine();
//            string soyad = Console.ReadLine();
//            string ataAd = Console.ReadLine();
//            if (soyad != " " && ataAd != " ")
//            {
//                method3(ad, soyad, ataAd);
//            }
//            else if (soyad != " ")
//            {
//                method3(ad, soyad);
//            }
//            else
//            {
//                method3(ad);
//            }
//        }
//        static void method3(string ad)
//        {
//            Console.WriteLine(ad);
//        }
//        static void method3(string ad, string soyad)
//        {
//            Console.WriteLine(ad, soyad);
//        }
//        static void method3(string ad, string soyad, string ataAd)
//        {
//            char firstLetter = char.ToUpper(ad[0]);
//            Console.WriteLine(firstLetter + "." + soyad + ataAd);
//        }



//    }
//}








