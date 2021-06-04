using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x64AA97FB40881F68, NameHash = 0x6955787592193D13)]
    public class TkAnimationDataTable : NMSTemplate
    {
        public List<TkAnimationData> Table;
    }
}