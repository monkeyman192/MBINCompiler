using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkLSystemInnerRule : NMSTemplate // 0x38 bytes
    {
        public NMSString0x20 LocatorType;
        public int MergeProbabilityOptions;
        public string[] MergeProbabilityOptionsValues()
        {
            return new[] { "Balance", "Prioritize", "Replace" };
        }

        public List<TkLSystemLocatorEntry> Entries;
    }
}
