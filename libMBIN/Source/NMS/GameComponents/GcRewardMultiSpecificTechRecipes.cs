using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x136E13A651F354A7, NameHash = 0x345E30DE4D2B5AAC)]
    public class GcRewardMultiSpecificTechRecipes : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TechIds;
		/* 0x10 */ public NMSString0x10 DisplayTechId;
        /* 0x20 */ public NMSString0x20A Setname;
        /* 0x40 */ public bool Silent;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x41 */ public byte[] EndPadding;
    }
}