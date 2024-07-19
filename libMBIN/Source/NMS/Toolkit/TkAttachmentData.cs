using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE5E19C61CDC316E2, NameHash = 0x6874FF60)]
    public class TkAttachmentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSTemplate> AdditionalData;
        [NMS(Index = 1)]
        /* 0x10 */ public List<LinkableNMSTemplate> Components;
        [NMS(Index = 2, Size = 0x5)]
        /* 0x20 */ public float[] LodDistances;
    }
}
