using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x40592D2BE6E8BA34, NameHash = 0x68CB2B62199F1EFA)]
    public class GcNPCWordReactionCategory : NMSTemplate
    {
        [NMS(Size = 0x7)]
        public GcNPCWordReactionList[] Categories;
        public GcNPCWordReactionList Fallback;
    }
}
