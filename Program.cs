using System;
using System.Collections.Generic;
using System.Linq;

namespace conLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DansLearning> dansLearning = new List<DansLearning>()
            {
                new DansLearning() {Subject = "Linq", PCLearned = 25, DansEnjoyement = 10},
                new DansLearning() {Subject = "DI", PCLearned = 10, DansEnjoyement = 80},
                new DansLearning() {Subject = "Async", PCLearned = 75, DansEnjoyement = 5},
                new DansLearning() {Subject = "C#", PCLearned = 50, DansEnjoyement = 25},
                new DansLearning() {Subject = "Winform", PCLearned = 10, DansEnjoyement = 45},
                new DansLearning() {Subject = "WPF", PCLearned = 25, DansEnjoyement = 70},
                new DansLearning() {Subject = "SQL", PCLearned = 90, DansEnjoyement = 30}
            };

            dansLearning.Where(x => x.PCLearned < 50).ToList().ForEach
            (
                dan => Console.WriteLine($"{dan.Subject} : {dan.PCLearned} : {dan.DansEnjoyement}")
            );

            //Get Object Subject = Linq
            var getLinq = dansLearning.Select(x => x.Subject).Contains("Linq");

            //Get First Object (or default if error)
            var getFirstOrDefault = dansLearning.Where(x => x.PCLearned < 1).FirstOrDefault();

            //Order by PCLearned desc
            var orderByPCLearned = dansLearning.OrderByDescending(x => x.PCLearned).ToList();

            var distinctPCLearnedOrdered = dansLearning.Select(x => x.PCLearned).Distinct().ToList().OrderBy(x=>x);

            int? i = 1;

            string str;
        }
    }
}
