using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection
{
    class Range
    {
        public void IntersectPeriods(List<dynamic> SetA, List<dynamic> SetB)
        {
            foreach (TimeRange PeriodSetA in SetA)
            {
                foreach (TimeRange PeriodSetB in SetB)
                {
                    if ((PeriodSetA.EndDate > PeriodSetA.StartDate) && (PeriodSetB.EndDate > PeriodSetB.StartDate))
                    {
                        if (((PeriodSetA.StartDate <= PeriodSetB.StartDate) && (PeriodSetA.EndDate <= PeriodSetB.EndDate)) && ((PeriodSetA.EndDate >= PeriodSetB.StartDate)))
                            Console.WriteLine(PeriodSetB.StartDate + " - " + PeriodSetA.EndDate);
                        else if ((PeriodSetA.StartDate >= PeriodSetB.StartDate) && (PeriodSetA.EndDate >= PeriodSetB.EndDate) && ((PeriodSetA.EndDate >= PeriodSetB.StartDate)))
                            Console.WriteLine(PeriodSetA.StartDate + " - " + PeriodSetB.EndDate);
                        else if ((PeriodSetA.StartDate >= PeriodSetB.StartDate) && (PeriodSetA.EndDate <= PeriodSetB.EndDate))
                            Console.WriteLine(PeriodSetA.StartDate + " - " + PeriodSetA.EndDate);
                        else if ((PeriodSetA.StartDate <= PeriodSetB.StartDate) && (PeriodSetA.EndDate >= PeriodSetB.EndDate))
                            Console.WriteLine(PeriodSetB.StartDate + " - " + PeriodSetB.EndDate);
                        else
                            Console.WriteLine("No Intersection");
                    }
                    else
                        Console.WriteLine("Wrong Entry");
                }
            }
        }

        static void Main(string[] args)
        {
            Program Range = new Program();
            var ListSetA = new List<dynamic>();
            var ListSetB = new List<dynamic>();
            Console.WriteLine("Enter the number of periods in setA");
            int NumberOfPeriodsSetA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of periods in setB");
            int NumberOfPeriodSetB = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < NumberOfPeriodsSetA; index++)
            {
                Console.WriteLine("Enter your period range {0} in setA: ", (index + 1));
                TimeRange period1 = new TimeRange(Convert.ToDateTime(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
                ListSetA.Add(period1);
            }
            for (int index = 0; index < NumberOfPeriodSetB; index++)
            {
                Console.WriteLine("Enter your period range {0} in setB: ", (index + 1));
                TimeRange period2 = new TimeRange(Convert.ToDateTime(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
                ListSetB.Add(period2);
            }
            Range.IntersectPeriods(ListSetA, ListSetB);
            Console.ReadLine();
        }
    }

}
