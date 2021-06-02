using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x4A9DE083678EC5C2, NameHash = 0x783F7F56522EAFC6)]
    public class GcPlayerMissionUpgradeMapEntry : NMSTemplate       // size: 0x38
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public int MinProgress;
        /* 0x14 */ public int CompletePoint;
        /* 0x18 */ public NMSString0x10 NewMission;

        /* 0x28 */ public List<NMSString0x10> CompleteMissions;
    }
}