using System;
using System.Collections.Generic;
using System.Text;

namespace Philips.Healthcare.IXR.ATT.TAF.Reporting
{
    /// <summary>
    /// Base class for classes that store script messages
    /// </summary>
    public abstract class ScriptMessageBase
    {
        protected int m_LineNr;
        protected String m_TimeStamp;
        protected String m_Type;
        protected String m_Value;
        protected Boolean m_Enabled;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lineNr">The line number in the test script output that represents this item or the start of this item</param>
        /// <param name="timeStamp">The time and data of the moment this item was executed</param>
        /// <param name="type">The type of this item (test item type or line type)</param>
        /// <param name="value">The output string of the script</param>
        /// <param name="enabled">True if this item was enabled; False otherwise</param>
        public ScriptMessageBase(int lineNr, String timeStamp, String type, String value, Boolean enabled)
        {
            m_LineNr = lineNr;
            m_TimeStamp = timeStamp;
            m_Type = type;
            m_Value = value;
            m_Enabled = enabled;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The line number in the test script output that represents this item or the start of this item
        /// </summary>
        public int LineNr
        {
            get
            {
                return m_LineNr;
            }
        }

        /// <summary>
        /// The time and data of the moment this item was executed
        /// </summary>
        public String TimeStamp
        {
            get
            {
                return m_TimeStamp;
            }
        }

        /// <summary>
        /// The type of this item (test item type or line type)
        /// </summary>
        public String Type
        {
            get
            {
                return m_Type;
            }
        }

        /// <summary>
        /// The output string of the script
        /// </summary>
        public String Value
        {
            get
            {
                return m_Value;
            }
        }

        /// <summary>
        /// True if this item was enabled; False otherwise
        /// </summary>
        public Boolean Enabled
        {
            get
            {
                return m_Enabled;
            }
        }

        #endregion
    }
}
