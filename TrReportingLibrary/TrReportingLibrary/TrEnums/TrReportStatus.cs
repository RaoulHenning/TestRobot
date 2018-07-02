using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrReportingLibrary
{
    public enum TrReportStatus
    {
        ReportStepPassed,               // P
        ReportStepFailed,               // F
        ReportStepSkipped,              // S
        ReportStepManualExecuted,       // M
        ReportInterfaceDeviation,       // C
        ReportLogInfo,                  // L
        ReportDebug,                    // D
        ReportReportInfo,               // R
        ReportReportWarning,            // W
        ReportDioRetry,                 // D
        ReportMeasurement,              // X
        ReportCommand,                  // I
        ReportVersionInfo,              // V
        ControlMarker,                  // T
        FlowStartTestBatchInfo,         // G
        FlowEndTestBatchInfo,           // G
        FlowControlStatement,           // O
        SetoolMessage
    }
}
