using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x2AE00E7A5251AFA8, NameHash = 0x6955787592193D13)]
    public class TkAnimationDataTable : NMSTemplate
    {
        public List<TkAnimationData> Table;
    }
}
