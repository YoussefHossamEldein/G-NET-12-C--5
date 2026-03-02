using System.ComponentModel.Design;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            bool isParsed;
            DayOfWeek Day;
            do
            {
                Console.Write("Enter a day number : ");
                isParsed = Enum.TryParse<DayOfWeek>(Console.ReadLine(), true, out Day);

            } while (!isParsed | !Enum.IsDefined(Day));
            
            Console.WriteLine($"Day : {Day}");
            bool isWeekend = false;
            if(Day == DayOfWeek.Friday || Day == DayOfWeek.Saturday)
            {
                isWeekend = true;
            }
            switch(isWeekend)
            {
                case true:
                    Console.WriteLine("It's a weekend");
                    break;
                case false:
                    Console.WriteLine("Its a workday");
                    break;  
            }
            
               

            #endregion


        }
    }
}
