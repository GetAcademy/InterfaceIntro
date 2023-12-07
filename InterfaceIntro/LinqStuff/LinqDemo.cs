namespace InterfaceIntro.LinqStuff
{
    internal class LinqDemo
    {
        public static void Run()
        {
            var s = "Hei";
            s.T

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numbersList = numbers.ToList();

            var first = numbers.First();
            var firstEven = numbers.First(n => n % 2 == 0);
            var firstOrDefault = numbers.FirstOrDefault();
            var firstOrDefaultEven = numbers.FirstOrDefault(n => n % 2 == 0);
            //var single = numbers.Single();
            //var single = numbers.Single(n => n % 2 == 0);
            //var single = numbers.SingleOrDefault();
            //var single = numbers.SingleOrDefault(n => n % 2 == 0);

            var evens = numbers.Where(n => n % 2 == 0); // tilsvarer JS filter
            var numbersHtml = numbers.Select(n => $"<li>{n}</li>"); // tilsvarer JS map

            var evenHtml = numbers
                .Where(n => n % 2 == 0)
                .Select(n => $"<li>{n}</li>")
                .ToArray();

            var evenHtml2 = from number in numbers
                where number % 2 == 0
                select $"<li>{number}</li>";
        }

        public static List<int> GetEvens(int[] numbers) // Where
        {
            var list = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    list.Add(number);
                }
            }
            return list;
        }

        public static List<string> GetHtml(int[] numbers) // Where
        {
            var list = new List<string>();
            foreach (var number in numbers)
            {
                list.Add($"<li>{number}</li>");
            }
            return list;
        }

        /*
           * Ev. litt om LINQ
           *  - FirstOrDefault, FirstOrDefault, Where, Select, ToArray, ToList
           *  - basert på interface
           *  - extension methods
           *  - builder pattern
         */
    }
}
