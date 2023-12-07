namespace InterfaceIntro
{
    internal class BulletPoint : ITextElement
    {
        private string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }

        public void ShowHighlighted()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Show();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
