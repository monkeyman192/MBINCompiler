using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD5472A0D4EFF6E62, NameHash = 0x93F33A9E)]
    public class TkAnimNodeFrameHalfData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<ushort> Rotations;
        [NMS(Index = 2)]
        /* 0x10 */ public List<halfVector3> Scales;
        [NMS(Index = 1)]
        /* 0x20 */ public List<halfVector3> Translations;
    }
}
