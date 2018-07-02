using System;
using System.Collections.Generic;

namespace TrReportingLibrary.ReportProviders
{
    public class TrReportProvider : IObservable<TrReportLine>
    {
        private List<IObserver<TrReportLine>> _observers;

        private List<TrReportLine> _trReportLines;
        public TrReportProvider()
        {
            _observers = new List<IObserver<TrReportLine>>();
            _trReportLines = new List<TrReportLine>();   
        }
        public IDisposable Subscribe(IObserver<TrReportLine> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber<TrReportLine>(_observers, observer);
        }

        public void ProvideDataToListeners(TrReportLine trReportLine)
        {
            _trReportLines.Add(trReportLine);

            foreach (var observer in _observers)
            {
                observer.OnNext(trReportLine);
            }
        }
    }
}
