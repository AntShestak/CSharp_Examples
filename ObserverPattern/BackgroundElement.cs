using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class BackgroundElement : IObserver<ColorTheme>
    {
        private IDisposable _unsubscriber;
        private string _name = "Background";

        public void Subscribe(IObservable<ColorTheme> controller)
        {
            if (controller != null)
                _unsubscriber = controller.Subscribe(this);
        }

        public void OnCompleted()
        {
            _unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(ColorTheme value)
        {
            Console.WriteLine($"\t{_name} changed color to {value.PrimaryColor}");
        }
    }
}
