namespace InterfaceIntro.UnitTesting
{
    public class DummyService
    {
        public void DoSomething(string text)
        {
            var firstChar = text[0];
            if (char.IsLetter(firstChar))
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
