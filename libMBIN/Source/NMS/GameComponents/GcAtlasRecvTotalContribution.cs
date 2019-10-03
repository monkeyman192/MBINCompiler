using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x95AC0992C92BD05E, NameHash = 0x0BB8B54516B54A343, Alignment = 0x8)]
    public class GcAtlasRecvTotalContribution : NMSTemplate {
        /* 0x0000 */ public long ClientUserData;
        /* 0x0008 */ public bool Success;
        /* 0x0010 */ public long TotalContribution;
    }

}
