using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrReportingLibrary.TrEnums
{
    public enum TrFlowMessageType
    {
        /// <summary>
        /// Item is started
        /// </summary>
        Start,
        /// <summary>
        /// Item is ended
        /// </summary>
        End,
        /// <summary>
        /// Item is aborted
        /// </summary>
        Abort
    }
}
