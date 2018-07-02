using System;
using System.Collections.Generic;
using System.Text;
using TrReportingLibrary.TrEnums;

namespace Philips.Healthcare.IXR.ATT.TAF.Reporting
{
    /// <summary>
    /// Class that represents a "normal" script output message. (i.e. a script output line that logs info, a warning, an error, etc.)
    /// </summary>
    public class ScriptOutputMessage : ScriptMessageBase
    {
        private TrLineType m_LineType;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lineNr"></param>
        /// <param name="timeStamp"></param>
        /// <param name="lineType"></param>
        /// <param name="identifier"></param>
        /// <param name="enabled"></param>
        public ScriptOutputMessage(int lineNr, String timeStamp, TrLineType lineType, String identifier, Boolean enabled)
            : base(lineNr, timeStamp, lineType.ToString(), identifier, enabled)
        {
            m_LineType = lineType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The type of this line
        /// </summary>
        public TrLineType LineType
        {
            get
            {
                return m_LineType;
            }
        }

        #endregion

        #region ToString

        /// <summary>
        /// Default string representation of this message, using a given indent.
        /// </summary>
        public string ToString(int indent)
        {
            StringBuilder sb = new StringBuilder();

            while (indent != 0)
            {
                sb.Append("  ");

                indent--;
            }

            return String.Format("{0,-30} {1,-30} {2}", String.Format("{0}{1}", sb.ToString(), m_LineType), TimeStamp, Value);
        }

        /// <summary>
        /// Default string representation of this message.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0,-30} {1,-30} {2}", m_LineType, TimeStamp, Value);
        }

        #endregion
    }
}
