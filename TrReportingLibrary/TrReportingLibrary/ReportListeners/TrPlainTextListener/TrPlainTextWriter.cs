using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrReportingLibrary.Constants;
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

        private static void MakeLineDescent(ref string reportLine, out char reportTag, bool isSeToolLine)
        {

            reportLine = reportLine.Trim();
            if (reportLine.Length <= 0)
            {
                reportTag = char.MinValue;
            }
            // If it is an SETool line, swap the timestamp and pass/fail indicator
            if (isSeToolLine && reportLine.Length >= 10)
            {
                // Only lines like "19:20:13 P" should be changed
                // There are also lines like "19:20:13 Line could not be parsed". For this a R must be added
                if (IsValidLineType(reportLine[9]) && string.IsNullOrWhiteSpace(reportLine.Substring(10, 1)))
                {
                    // Swap the SE-tool logtime and the special character
                    var specialCharString = reportLine.Substring(9, 2);
                    reportLine = reportLine.Remove(9, 2);
                    reportLine = specialCharString + reportLine;
                }
                else
                {
                    // Add an L, no F or E because R is neutral
                    reportLine = "R " + reportLine;
                }
            }
            reportLine = DateTime.Now.ToString(TrSeperators.ReportDateTimeStamp) + reportLine + Environment.NewLine;
            reportTag = reportLine[0];
        }

        private static bool IsValidLineType(char lineType)
        {
            switch (lineType)
            {
                case 'A': // Action/test step line
                case 'B': // Batch line
                case 'C': // Interface deviation
                case 'D': // DIO Retry
                case 'E': // Error
                case 'F': // Fail
                case 'W': // Warning
                case 'G': // General, usually non script execution related (pre/post cmd, duurtest file retrieval, etc.)
                case 'I': // Include text file
                case 'L': // LogInfo
                case 'M': // Manual execution
                case 'N': // Nested test case line
                case 'O': // Control statement marker
                case 'P': // Pass
                case 'R': // ReportInfo
                case 'S': // Skip
                case 'T': // Test case line
                case 'X': // Performance line
                case 'V': // Version info line
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
