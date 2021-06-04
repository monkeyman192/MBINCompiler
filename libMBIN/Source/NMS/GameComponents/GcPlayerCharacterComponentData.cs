using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, Alignment = 0x8, GUID = 0xE5F8BE3FDC17F3C2, NameHash = 0xE8C3B2237C130170)]
    public class GcPlayerCharacterComponentData : NMSTemplate
    {
        public List<GcCharacterJetpackEffect> JetpackEffects;
        public NMSString0x10 IntialPlayerControlMode;
        public List<GcPlayerControlModeEntry> PlayerControlModes;
    }
}