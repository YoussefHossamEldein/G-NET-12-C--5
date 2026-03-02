using System.ComponentModel.Design;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //bool isParsed;
            //DayOfWeek Day;
            //do
            //{
            //    Console.Write("Enter a day number : ");
            //    isParsed = Enum.TryParse<DayOfWeek>(Console.ReadLine(), true, out Day);

            //} while (!isParsed | !Enum.IsDefined(Day));
            
            //Console.WriteLine($"Day : {Day}");
            //bool isWeekend = false;
            //if(Day == DayOfWeek.Friday || Day == DayOfWeek.Saturday)
            //{
            //    isWeekend = true;
            //}
            //switch(isWeekend)
            //{
            //    case true:
            //        Console.WriteLine("It's a weekend");
            //        break;
            //    case false:
            //        Console.WriteLine("Its a workday");
            //        break;  
            //}



            #endregion

            #region Question02
            bool isParsed;
            double num1;
            double num2;
            char operation;
            double result = 0;
            do
            {
                Console.Write("Enter the first number : ");
                isParsed = double.TryParse(Console.ReadLine(), out num1);
               
            } while (!isParsed);
            do
            {
                Console.Write("Enter the second number : ");
                isParsed = double.TryParse(Console.ReadLine(), out num2);

            } while (!isParsed);
            do
            {
                Console.Write("Enter the operation you need : ");
                isParsed = char.TryParse(Console.ReadLine(), out operation);
            } while (!isParsed || !(operation == '+' || operation == '-'  || operation == '*' || operation == '/'));
            switch(operation)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Subtract(num1, num2);
                    break;
                case '*':
                    result = Multiply(num1, num2);
                    break;
                case '/':
                    if (num2 == 0) { 
                        Console.WriteLine("can not divide by zero");
                        return;
                    } 
                    result = Divide(num1, num2);
                    break;
            }
            Console.WriteLine($"Result of {operation} of {num1} & {num2} is = {result}");

            #endregion 

        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x *y;
        }
        static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
