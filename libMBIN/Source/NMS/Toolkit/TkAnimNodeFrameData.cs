using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB2E78D75B9088DB6, NameHash = 0xADF5F9C3)]
    public class TkAnimNodeFrameData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<ushort> Rotations;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Vector3f> Scales;
        [NMS(Index = 1)]
        /* 0x20 */ public List<Vector3f> Translations;
    }
}
