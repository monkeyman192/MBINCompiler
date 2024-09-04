using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82162ED16C0A5CD9, NameHash = 0x42545E4E)]
    public class GcPlayerCharacterIKStateData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerCharacterIKOverrideData Data;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcPlayerCharacterAnimationOverrideData> AnimOverrides;
        [NMS(Index = 0)]
        /* 0x30 */ public GcPlayerCharacterStateType State;
    }
}
