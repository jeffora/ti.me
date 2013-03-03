using System;
using System.Reactive.Linq;
using ReactiveUI;

namespace ti.me
{
    public class Clock : ReactiveObject
    {
        public Clock()
        {
            Observable.Timer(TimeSpan.FromMilliseconds(100), TimeSpan.FromMilliseconds(100))
                .Select(_ => DateTime.Now)
                .ToProperty(this, c => c.Time);
        }

        ObservableAsPropertyHelper<DateTime> _Time;
        public DateTime Time
        {
            get { return _Time.Value; }
        }
    }
}