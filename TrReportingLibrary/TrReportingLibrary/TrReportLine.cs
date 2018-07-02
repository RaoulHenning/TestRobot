using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrReportingLibrary
{
    public class TrReportLine
    {
        public TrReportStatus TrReportStatus { get; set; }
        public string TrReportMessage { get; set; }
        public TrReportLine(TrReportStatus trReportStatus, string trReportMessage)
        {
            TrReportStatus = trReportStatus;
            TrReportMessage = trReportMessage;
        }
    }
}
