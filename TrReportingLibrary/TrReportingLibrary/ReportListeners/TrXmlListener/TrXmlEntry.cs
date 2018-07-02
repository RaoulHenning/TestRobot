using System;
using System.Collections.Generic;
using System.Text;
using TrReportingLibrary.TrEnums;

namespace Philips.Healthcare.IXR.ATT.TAF.Reporting.XML
{
    public enum TafTestReportItemMainType
    {
        TestItem,
        ScriptOutputLine
    }

    public class TrXmlEntry
    {
        private TrXmlEntry currentSubItem = null;
        private String m_EndTime = String.Empty;

        public TrXmlEntry()
        {
            ReportItems = new List<TrXmlEntry>();
        }

        public TrXmlEntry(ScriptMessageBase message)
            :this()
        {
            LineNr = message.LineNr;
            StartTime = message.TimeStamp;
            Type = message.Type;
            Value = message.Value;
            Enabled = message.Enabled;
        }

        public TrXmlEntry(ScriptOutputMessage message)
            : this(message as ScriptMessageBase)
        {
            MainType = TafTestReportItemMainType.ScriptOutputLine;
            EndTime = message.TimeStamp;
        }

        public TrXmlEntry(ScriptFlowMessage flowMessage)
            : this(flowMessage as ScriptMessageBase)
        {
            MainType = TafTestReportItemMainType.TestItem;
        }

        public int? LineNr;

        public String StartTime;

        public String EndTime
        {
            get
            {
                if (String.IsNullOrEmpty(m_EndTime))
                {
                    if (ReportItems != null)
                    {
                        if (ReportItems.Count != 0)
                        {
                            m_EndTime = ReportItems[ReportItems.Count - 1].EndTime;
                        }
                    }
                }

                if (String.IsNullOrEmpty(m_EndTime))
                {
                    m_EndTime = StartTime;
                }

                return m_EndTime;
            }
            set
            {
                m_EndTime = value;
            }
        }

        public TafTestReportItemMainType MainType;

        public String Type;

        public String Tag;

        public String Value;

        public Boolean? Enabled;

        public List<TrXmlEntry> ReportItems;

        internal virtual bool HandleScriptFlowMessage(ScriptFlowMessage flowMessage)
        {
            bool closeThisItem = false;

            // Check if we have a subitem that must handle this line
            if (currentSubItem != null)
            {
                if (currentSubItem.HandleScriptFlowMessage(flowMessage))
                {
                    // The subItem handled the request and notified us that it must be closed
                    currentSubItem = null;
                }
            }
            else
            {
                // Check if a new subItem must be created
                if (flowMessage.MessageType == TrFlowMessageType.Start)
                {
                    currentSubItem = new TrXmlEntry(flowMessage);
                    ReportItems.Add(currentSubItem);
                }
                else if (flowMessage.MessageType == TrFlowMessageType.End)
                {
                    if ((String.IsNullOrEmpty(Type)) || (Type.StartsWith(flowMessage.TestItemType.ToString())))
                    {
                        Tag = TrTestReportItemState.Finished.ToString();
                        EndTime = flowMessage.TimeStamp;
                        closeThisItem = true;
                    }
                }
            }

            if (flowMessage.MessageType == TrFlowMessageType.Abort)
            {
                // Always abort this item too if an abort message comes in
                Tag = TrTestReportItemState.Aborted.ToString();
                EndTime = flowMessage.TimeStamp;
                closeThisItem = true;
            }

            return closeThisItem;
        }

        internal virtual void HandleScriptOutputMessage(ScriptOutputMessage message)
        {
            // Check if we have a subitem that must also handle this line
            if (currentSubItem != null)
            {
                currentSubItem.HandleScriptOutputMessage(message);
            }
            else
            {
                ReportItems.Add(new TrXmlEntry(message));
            }
        }
    }
}
