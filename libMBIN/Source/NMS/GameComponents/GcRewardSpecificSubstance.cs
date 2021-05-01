﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, Alignment = 0x8, GUID = 0x7054017D3ADCD382, NameHash = 0xF3F4ABE3661F3779)]
    public class GcRewardSpecificSubstance : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProduct Default;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string ID;
        /* 0x18 */ public int AmountMin;
        /* 0x1C */ public int AmountMax;
        /* 0x20 */ public float HardModeMultiplier;
        /* 0x24 */ public bool DisableMultiplier;
        /* 0x25 */ public bool RewardAsBlobs;
        /* 0x26 */ public bool UseFuelMultiplier;
        /* 0x27 */ public bool Silent;
    }
}
