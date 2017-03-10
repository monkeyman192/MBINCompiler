using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string MissionID;
        /* 0x10 */ public bool AutoStart;
        /* 0x11 */ public bool RemoveOnCompletion;
        [NMS(Size = 6, Ignore = true)]
        /* 0x12 */ public byte[] Padding12;
        /* 0x18 */ public List<NMSTemplate> StartingConditions;
        /* 0x28 */ public List<NMSTemplate> CancelingConditions;
        /* 0x38 */ public List<NMSTemplate> NotificationSequence;
    }
}
