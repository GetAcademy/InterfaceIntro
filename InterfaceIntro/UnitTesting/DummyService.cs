namespace InterfaceIntro.UnitTesting
{
    public class DummyService
    {
        public void DoSomething(string text)
        {
            var firstChar = text[0];
            var secondChar = text[1];

            if (char.IsLetter(firstChar))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

            if (char.IsLetter(secondChar))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
