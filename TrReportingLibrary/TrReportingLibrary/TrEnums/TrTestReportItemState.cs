using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrReportingLibrary.TrEnums
{
    public enum TrTestReportItemState
    {
        Unknown,
        /// <summary>
        /// The item is active (i.e. being executed)
        /// </summary>
        Active,
        /// <summary>
        /// The item has finished
        /// </summary>
        Finished,
        /// <summary>
        /// The item has been aborted
        /// </summary>
        Aborted
    }
}
