using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xB9C81158A1FF0684, NameHash = 0xFA881469CD77285D)]
    public class GcAntagonistFriend : NMSTemplate
    {
        /* 0x0 */ public float ArticulationFactor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] Padding4;
        /* 0x8 */ public List<NMSString0x10> Perceptions;
    }
}