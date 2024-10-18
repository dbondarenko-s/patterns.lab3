namespace Patterns.Lab3.Widgets
{
    public abstract class ContentControl : UIComponent
    {
        private string _text {  get; set; }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public ContentControl() : this(string.Empty)
        {
        }

        public ContentControl(string text)
        {
            _text = text;
        }

        public override int GetWidth()
        {
            return GetText().Length + 2;
        }

        public override int GetHeight()
        {
            return 1;
        }
    }
}
