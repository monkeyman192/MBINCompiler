using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42ECAED236415D8B, NameHash = 0x4D3FB3BF1BEB7DAE)]
    public class GcPlayerCharacterIKStateData : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCharacterIKOverrideData Data;
        /* 0x20 */ public List<GcPlayerCharacterAnimationOverrideData> AnimOverrides;
        /* 0x30 */ public GcPlayerCharacterStateType State;
    }
}
