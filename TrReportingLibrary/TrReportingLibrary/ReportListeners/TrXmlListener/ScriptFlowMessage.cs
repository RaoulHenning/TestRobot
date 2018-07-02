using System;
using System.Collections.Generic;
using System.Text;
using TrReportingLibrary.TrEnums;

namespace Philips.Healthcare.IXR.ATT.TAF.Reporting
{
    /// <summary>
    /// Class that represents a script output message that marks the start or end of a test item (e.g. test batch, test case, keyword, loop, etc.)
    /// </summary>
    public class ScriptFlowMessage : ScriptMessageBase
    {
        private TrFlowMessageType m_MarkerType;
        private TrTestItemType m_TestItemType;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lineNr">The line number in the test script output that represents the start of this item</param>
        /// <param name="timeStamp">The time and data of the moment this item was started</param>
        /// <param name="markerType">Marks if the item was started, ended or aborted</param>
        /// <param name="testItemType">The type of the item (Loop, Test batch etc.)</param>
        /// <param name="identifier">The name of the item</param>
        /// <param name="enabled">True if the item is executed;False otherwise</param>
        public ScriptFlowMessage(int lineNr, String timeStamp, TrFlowMessageType markerType, TrTestItemType testItemType, String identifier, Boolean enabled)
            : base(lineNr, timeStamp, testItemType.ToString(), identifier, enabled)
        {
            m_MarkerType = markerType;
            m_TestItemType = testItemType;

            if ((m_TestItemType == TrTestItemType.TestBatch) || (m_TestItemType == TrTestItemType.NormalTestCase))
            {
                // The identifier of these types have an extension (.xml or .xls). Remove those

                m_Value = m_Value.Replace(".xml", "");
                m_Value = m_Value.Replace(".xls", "");
            }

            if (m_TestItemType == TrTestItemType.NormalTestCase)
            {
                // The test case identifiers also contain the type of test case. Move this to the type field i.s.o. the value field
                if (m_Value.Contains("("))
                {
                    m_Type = String.Format("{0} {1}", m_Type, m_Value.Substring(m_Value.IndexOf("(")));
                    m_Value = m_Value.Substring(0, m_Value.IndexOf("("));
                }
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Marks if the item was started, ended or aborted
        /// </summary>
        public TrFlowMessageType MessageType
        {
            get
            {
                return m_MarkerType;
            }
        }

        /// <summary>
        /// The type of the item (Loop, Test batch etc.)
        /// </summary>
        public TrTestItemType TestItemType
        {
            get
            {
                return m_TestItemType;
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

            return String.Format("{0,-30} {1,-30} {2}", String.Format("{0}{1}.{2}", sb.ToString(), m_TestItemType, m_MarkerType), TimeStamp, Value);
        }

        /// <summary>
        /// Default string representation of this message.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0,-30} {1,-30} {2}", String.Format("{0}.{1}", m_TestItemType, m_MarkerType), TimeStamp, Value);
        }

        #endregion
    }
}
