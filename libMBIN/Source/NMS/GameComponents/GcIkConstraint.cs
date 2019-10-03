using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x150, GUID = 0xE2461DFD81E6A7DB, NameHash = 0xE71CD9CB0F5ED75B)]
    public class GcIkConstraint : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x100)]
        /* 0x010 */ public string JointName;
        /* 0x110 */ public GcCreatureIkType Type;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x114 */ public byte[] Padding114;
        /* 0x120 */ public GcPlayerCharacterIKOverrideData DefaultState;
        /* 0x140 */ public List<GcPlayerCharacterIKStateData> States;
    }
}
