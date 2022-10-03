using System;

namespace Console_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("---------------------");
                Console.WriteLine("Console Calculator Program");
                Console.WriteLine("---------------------");

                Console.Write("Enter number 1 (İlk sayıyı giriniz):");
                num1 = Convert.ToDouble(Console.ReadLine());


                Console.Write("Enter number 2 (İkinci sayıyı giriniz):");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operator (Yapacağınız işlemi seçiniz) :");
                Console.WriteLine("\t+ : Add (Toplama)");
                Console.WriteLine("\t- : Subtract (Çıkarma)");
                Console.WriteLine("\t* : Multiply (Çarpma)");
                Console.WriteLine("\t/ : Divide (Bölme)");
                Console.WriteLine("Enter an option (İşlemi yazınız) :");



                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result (Sonucunuz) : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result (Sonucunuz) : {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result (Sonucunuz) : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result (Sonucunuz) : {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option (Bu geçerli bir işlem değil)");
                        break;

                }
                Console.WriteLine("Would you like to continue (Devam etmek ister misiniz?) ? (Y: Yes / N: No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");


            Console.ReadKey();

            Environment.Exit(0);


        }
    }
}