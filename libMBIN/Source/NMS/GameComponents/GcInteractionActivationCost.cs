using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Alignment = 0x8, Size = 0x38, GUID = 0x21E3CCED5C322A2A, NameHash = 0xDF5512FA05691ED2)]
    public class GcInteractionActivationCost : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SubstanceId;
        /* 0x10 */ public List<NMSString0x10> AltIds;
        /* 0x20 */ public int Cost;
        /* 0x24 */ public bool Repeat;
        [NMS(Size = 3, Ignore = true)]
        /* 0x25 */ public byte[] Padding25;
        /* 0x28 */ public NMSString0x10 RequiredTech;
    }
}
