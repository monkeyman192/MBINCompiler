using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5CA3D7A16E66327, NameHash = 0xC50F2CF9)]
    public class GcPersistentBaseDifficultyData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcDifficultyPresetType DifficultyPreset;
        // size: 0x2
        [Flags]
        public enum PersistentBaseDifficultyFlagsEnum : uint {
            None,
            Locked,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public PersistentBaseDifficultyFlagsEnum PersistentBaseDifficultyFlags;
    }
}
