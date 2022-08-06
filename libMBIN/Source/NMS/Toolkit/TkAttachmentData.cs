using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x87068490DC83B1C1, NameHash = 0x9756E001A603A3B1)]
    public class TkAttachmentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Components;
        [NMS(Size = 0x5)]
        /* 0x10 */ public float[] LodDistances;
    }
}
