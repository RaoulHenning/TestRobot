using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrReportingLibrary;

namespace ObserverPatternDataWriter
{
    public class TrXmlWriter : IObserver<TrReportLine>
    {
        private IDisposable _cancellation;

        public void OnNext(TrReportLine value)
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
            // Handel hier je memory af
        }
    }
}
