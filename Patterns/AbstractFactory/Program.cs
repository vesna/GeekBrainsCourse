class Program
{
    interface IButton
    {
        void Display();
    }

    interface ITextBox
    {
        void Display();
    }
    class WindowsButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("Отображаем кнопку Виндоус");
        }
    }

    class WindowsTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("отображаем окно вывода Виндоус");
        }
    }

    class MacOSButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("Отображаем кнопку Мак");
        }
    }

    class MacOSTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("отображаем окно вывода Мак");
        }
    }

    interface IControlsFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }

    class WindowsControlsFactory : IControlsFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ITextBox CreateTextBox() => new WindowsTextBox();
    }
    class MacOSControlsFactory : IControlsFactory
    {
        public IButton CreateButton() => new MacOSButton();
        public ITextBox CreateTextBox() => new MacOSTextBox();
    }
    public static void Main(string[] args)
    {
        bool oWindows = false;
        IControlsFactory factory = null;
        if(oWindows)
        {
            factory = new WindowsControlsFactory();
        }
        else
        {
            factory = new MacOSControlsFactory();
        }
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();

        button.Display();
        textBox.Display();

    }
}
