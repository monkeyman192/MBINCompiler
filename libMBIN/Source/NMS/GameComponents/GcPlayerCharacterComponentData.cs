using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60495EA305E0B504, NameHash = 0xE8C3B2237C130170)]
    public class GcPlayerCharacterComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 IntialPlayerControlMode;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcCharacterJetpackEffect> JetpackEffects;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcPlayerControlModeEntry> PlayerControlModes;
    }
}
