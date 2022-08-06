using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7D72EC550373804, NameHash = 0xE71CD9CB0F5ED75B)]
    public class GcIkConstraint : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x100 JointName;
        /* 0x110 */ public GcCreatureIkType Type;
        /* 0x120 */ public GcPlayerCharacterIKOverrideData DefaultState;
        /* 0x140 */ public List<GcPlayerCharacterIKStateData> States;
    }
}
