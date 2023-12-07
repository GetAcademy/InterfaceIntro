namespace InterfaceIntro
{
    internal class CenteredHeader : ITextElement
    {
        private string _text;

        public CenteredHeader(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Show('-');
        }

        public void Show(char paddingChar)
        {
            var startPos = (Console.WindowWidth - _text.Length) / 2;
            var dashCount = startPos - 4;
            var dashes = "  " + new string(paddingChar, dashCount) + "  ";
            Console.Write(dashes);
            Console.Write(_text);
            Console.WriteLine(dashes);
        }

        public void ShowHighlighted()
        {
            Show('*');
        }
    }
}
