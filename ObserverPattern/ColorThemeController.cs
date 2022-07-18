using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class ColorThemeController : IObservable<ColorTheme>
    {

        public List<IObserver<ColorTheme>> _observers;

        public ColorThemeController()
        {
            _observers = new List<IObserver<ColorTheme>>();
        }

        public IDisposable Subscribe(IObserver<ColorTheme> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        public void Unsubscribe(IObserver<ColorTheme> observer)
        {
            if (_observers.Contains(observer))
                observer.OnCompleted();
            
        }

        public void SetTheme(ColorTheme newTheme)
        {
            Console.WriteLine($"Changed color theme to: {newTheme.PrimaryColor} | {newTheme.SecondaryColor}");
            foreach (var obs in _observers)
            {
                obs.OnNext(newTheme);
            }

        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<ColorTheme>> _observers;
            private IObserver<ColorTheme> _observer;

            public Unsubscriber(List<IObserver<ColorTheme>> observers, IObserver<ColorTheme> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
