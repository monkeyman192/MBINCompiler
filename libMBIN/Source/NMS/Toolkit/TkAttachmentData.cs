using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6F7B6FDB3A0572E9, NameHash = 0x9756E001A603A3B1)]
    public class TkAttachmentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSTemplate> Components;
        [NMS(Index = 1, Size = 0x5)]
        /* 0x10 */ public float[] LodDistances;
    }
}
