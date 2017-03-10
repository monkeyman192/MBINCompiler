using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkPhysicsComponentData : NMSTemplate
    {
        public TkPhysicsData Data;
        /* 0x018 */ public bool TriggerVolume;
        /* 0x01C */ public TkVolumeTriggerType VolumeTriggerType;
        /* 0x020 */ public bool Climbable;
        /* 0x021 */ public bool IgnoreModelOwner;
        [NMS(Size = 6, Ignore = true)]
        /* 0x022 */ public byte[] Padding22;
        /* 0x028 */ public NMSTemplate RagdollData;
    }
}
