using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x38, GUID = 0x8999A8B76829CCD5, NameHash = 0x4F8B68FB20F9A030)]
    public class TkLSystemInnerRule : NMSTemplate // 0x38 bytes
    {
        public NMSString0x20 LocatorType;
		public enum MergeProbabilityOptionsEnum { Balance, Prioritize, Replace }
		public MergeProbabilityOptionsEnum MergeProbabilityOptions;

        public List<TkLSystemLocatorEntry> Entries;
    }
}