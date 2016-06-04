using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
    class InnerException
    {
        public static void Main(string[] args)
        {
            //To use the InnerException feature, use try-catch within another try-catch block
            try
            {
                try
                {
                    Console.Write("Enter First number: ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Second number: ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    int result = firstNumber / secondNumber;
                    Console.WriteLine($"Result: {result}");
                }
                //Original Exception occurs
                catch (Exception ex)
                {
                    string filePath = @"C:\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType());
                        sw.WriteLine(ex.Message);
                        Console.WriteLine("\nThere is a problem occured. Please check input values.");
                    }
                    else
                    {
                        //Throw new exception, and pass the original exception in the parameter so that we know what was the first exception that occured
                        throw new FileNotFoundException("File not found", ex);
                    }

                }
            }
            //Catch the new exception
            catch (Exception exception)
            {
                //Show the current exception
                Console.WriteLine($"\nCurrent Exception: {exception.GetType()} \nMessage: {exception.Message}");

                //Show the original exception/inner exception
                Console.WriteLine($"\nOriginal Exception: {exception.InnerException.GetType()} \nMessage: {exception.InnerException.Message} \n");
            }
        }
    }
}
