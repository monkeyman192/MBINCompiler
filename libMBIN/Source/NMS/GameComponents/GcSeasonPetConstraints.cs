using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21BC6840801EF31B, NameHash = 0x154E67C8939691E0)]
    public class GcSeasonPetConstraints : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CreatureId;
        /* 0x10 */ public float MinRelativeScale;
        /* 0x14 */ public float MaxRelativeScale;
        /* 0x18 */ public bool SpecificBiome;
        /* 0x1C */ public GcBiomeType Biome;
        /* 0x20 */ public float StartingTrust;
        /* 0x28 */ public ulong TimeSinceLastEgg;
        /* 0x30 */ public ulong TimeSinceBirth;
    }
}
