namespace InterfaceIntro.Enumers
{
    internal class EnumerDemo
    {
        public static void Run()
        {
            IEnumerable<string> a; // Noe som man kan gå gjennom
            IEnumerator<string> b; // Gjennomgang


            var terjeNumbers = new TerjeNumbers();
            foreach (var terjeNumber in terjeNumbers)
            {
                Console.WriteLine(terjeNumber);
            }
        }
    }
}
