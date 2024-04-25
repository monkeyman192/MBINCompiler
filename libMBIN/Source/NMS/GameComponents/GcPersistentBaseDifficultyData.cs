using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x287BA08F43914FB5, NameHash = 0x6E51E89E7E62BE51)]
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
