using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = DivideNumbers(a, b);
                Console.WriteLine("Результат деления: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }


        public static int DivideNumbers(int a, int b)
        {
            if (b == 0)
            {

                throw new DivideByZeroException("Деление на ноль недопустимо");
            }

            return a / b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ConsoleAppModule05
{
    internal class task1
    {
        static void Main()
        {
            string url = "http://example.com/nonexistentpage";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string content = client.DownloadString(url);
                    Console.WriteLine("Содержимое ресурса: " + content);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Произошла ошибка запроса к веб-ресурсу: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule05
{
    internal class task3
    {
        static void Main()
        {
            try
            {
                FirstMethod();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
            Console.ReadKey();
        }

        static void FirstMethod()
        {
            try
            {
                SecondMethod();
            }
            catch (Exception ex)
            {
                throw new CustomException("error in FirstMethod", ex);
            }
        }

        static void SecondMethod()
        {
            throw new InvalidOperationException("error in SecondMethod");
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}