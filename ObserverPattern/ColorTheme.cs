using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ColorTheme
    {
        public string PrimaryColor { get; }
        public string SecondaryColor { get; }

        public ColorTheme(string primary, string secondary)
        {
            PrimaryColor = primary;
            SecondaryColor = secondary;
        }

    }
}
