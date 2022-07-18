using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorTheme theme1 = new ColorTheme("White", "Black");
            ColorTheme theme2 = new ColorTheme("Red", "Blue");

            ColorThemeController controller = new ColorThemeController();

            TextElement text = new TextElement();
            text.Subscribe(controller);
            
            controller.SetTheme(theme1);

            BackgroundElement background = new BackgroundElement();
            background.Subscribe(controller);

            controller.SetTheme(theme2);

            controller.Unsubscribe(text);
            controller.SetTheme(theme1);





        }
    }
}
