using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrReportingLibrary.Constants
{
    public class TrSeperators
    {

        // **************************************************************
        // * Constants used in generated script and textual report file *
        // **************************************************************

        // When a report line has more data fields, they are seperated by this
        public const string Separator = " # ";

        // Start and end of a test batch
        public const string StartBatch = "Starting test batch (Todo: Remove) ";
        public const string EndBatch = "End test batch (Todo: Remove): ";

        // Start and end of a test loop
        public const string StartLoop = "Starting test loop ";
        public const string EndLoop = "End test loop: ";

        // Start and end of a test case
        public const string StartCase = "Starting test case: ";
        public const string TestCaseVersion = "Test case version number: ";
        public const string EndCase = "End test case: ";

        // Start and end of a nested (or sub) test case
        public const string StartNestedCase = "Starting nested test case: ";
        public const string EndNestedCase = "End nested test case: ";

        // Start and end of a test step
        public const string StartStep = "Starting test step: ";
        public const string EndStep = "End test step: ";

        // Start and end of SUT description
        //public const String StartSutDescr = "Starting description of SUT: "
        //public const String EndSutDescr = "End description of SUT: "

        // Some control statements (ForAll*) have code that can fail. These statements are 
        // marked so they can be traced back and the error reported in the Excel report.
        public const string MarkControl = "Marked control statement: ";

        // Within test step
        //public const String StepTestCase = "Test case: "
        public const string StepExcelRow = "Excel row: ";

        // Lines added at start of a batch
        //public const String TafKeywordLib = "TAF keyword library: "
        //public const String UserKeywordLib = "User keyword library: "
        //public const String KeywordLibPrecedence = "Keyword library precedence: "
        //public const String GenerationDateTime = "Batch generation date and time: "
        //public const String TesterName = "Tester name: "
        //public const String PtlMode = "PTL mode: "

        //public const String TestSystemName = "Test system name: "    ' (Legacy) as logged by TAF 2, still used in frmPerfDataCollector
        //public const String TestSystemDef = "Test system: "         ' (New)    test system definition as reported by TAF 3
        //public const String TafVersionConvert = "TAF version used for batch conversion: "
        //public const String TafVersionExecute = "TAF version used for batch execution: "
        //public const String BatchVersion = "Batch version number: "
        //public const String NrTestCaseLoops = "Nr of loops: "
        //public const String ReportRemark = "Remark for in report: "
        public const string Parameter = "PARAM ";
        //public const String TestCase = "CASE "

        //public const String TestClientSE = "SE Tool";
        //public const String TestClientTSS = "TSS";
        //public const String TSS = "TSS: ";
        //public const String TestAdapter = "Test adapter: ";
        //public const String System = "System: ";
        //public const String Name = "Name: ";
        //public const String Version = "Version: ";
        //public const String TaVersion = "Test adapter version: ";
        //public const String SwVersion = "Software version: ";
        //public const String Location = "Location: ";

        public const string StartGeneralBlock = "Starting: ";
        public const string EndGeneralBlock = "End: ";
        //public const String StartEndSutConnection = "Connecting to test systems";
        //public const String ConnectingToSE = "Attempting to connect to SE tool at: ";
        //public const String ConnectingToTSS = "Attempting to connect to TSS at: ";
        //public const String ConnectedToSut = "Succesfully connected to: ";
        //public const String FailedToConnectToTssAt = "Failed to connect to TSS at: ";
        //public const String FailedToConnectToSeAt = "Failed to connect to SE tool at: ";
        //public const String StartEndAskRunPermission = "Asking run permission";
        //public const String AskingRunPermissionOn = "Asking run permission on: ";
        //public const String RunPermissionGranted = "Run permission granted on: ";
        //public const String RunPermissionSimEnv = "VMware detected, run permission not needed on: ";
        //public const String RunPermissionDenied = "Run permission denied on: ";
        //public const String RunPermissionError = "Error asking run permission on: ";
        //public const String StartEndPreRunCmd = "Pre-run command";
        //public const String StartEndPostRunCmd = "Post-run command";
        //public const String ExecutingCmd = "Executing command: ";
        //public const String ExecutingCmdFinished = "Command executed, exit code was: ";
        //public const String ExecutingCmdFail = "Command failed: ";

        // Library type indication for keyword as in 09:24:48 A Starting test step: Com_CMD_ShowPopup (TAF keyword library)
        //public const String KeywordFromTafLib = "(TAF keyword)";
        //public const String KeywordFromUserLib = "(User keyword)";

        // Misc. constants
        //public const String None = "None";
        public const string IncludeTextFile = "Include text file: ";
        public const string TestCaseLoop = "Loop: ";
        public const string PreLoopTestCase = " (Pre-Batch test case)";
        public const string PostLoopTestCase = " (Post-Batch test case)";
        public const string BetweenLoopsTestCase = " (Between-Loops test case)";

        public const string ReportDateTimeStamp = "yyyy-MM-dd HH:mm:ss.fff ";

        // (Better) detection of why a batch was interrupted
        //public const String BatchInterrupted = "The batch was interrupted: ";
        //public const String BatchInterruptedScriptError = "VBScript Error.";
        public const string BatchInterruptedStoppedUser = "User pressed stop.";
        //public const String BatchInterruptedStopTime = "Stop time reached.";
        //public const String BatchInterruptedStopOnFail = "'Stop on Fail' selected and failed step detected.";
        //public const String BatchInterruptedUnknown = "Unknown.";

        public const int ExcelEditorRowOffset = 4;
    }
}
