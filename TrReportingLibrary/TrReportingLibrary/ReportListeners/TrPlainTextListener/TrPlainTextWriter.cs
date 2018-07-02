using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrReportingLibrary.ReportProviders;

namespace TrReportingLibrary.ReportListeners.TrPlainTextListener
{
    public class TrPlainTextWriter : IObserver<TrReportLine>
    {
        private IDisposable _cancellation;

        public TrPlainTextWriter(string fileOutputPath)
        {
            
        }
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

        public virtual void Subscribe(TrReportProvider provider)
        {
            _cancellation = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
            // Handel hier je memory af
        }


        private void WriteLineToTextReport(string line, bool isSeToolLine)
        {
            
        }

        private static void MakeLineDescent(ref string line, out char reportTag, bool isSeToolLine)
        {

            line = line.Trim();
            if (line.Length <= 0)
            {
                reportTag = char.MinValue;
            }
            // If it is an SETool line, swap the timestamp and pass/fail indicator
            if (isSeToolLine && line.Length >= 10)
            {
                // Only lines like "19:20:13 P" should be changed
                // There are also lines like "19:20:13 Line could not be parsed". For this a R must be added
                if()
            }
        }

        private static bool IsValidLineType(char lineType)
        {
            
        }
    }
}
