using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x67C05DCF8F3F183E, NameHash = 0x87C83AD7D0C1D117)]
    public class GcCreatureSwarmData : NMSTemplate
    {
        /* 0x00 */ public int MinCount;
        /* 0x04 */ public int MaxCount;
        /* 0x08 */ public float SwarmMovementSpeed;
        /* 0x0C */ public float SwarmMovementRadius;
		public enum SwarmMovementTypeEnum { None, Circle, Random, Search, FollowPlayer }
		public SwarmMovementTypeEnum SwarmMovementType;

        /* 0x14 */ public float Coherence;
        /* 0x18 */ public float Alignment;
        /* 0x1C */ public float Spacing;
        /* 0x20 */ public float Follow;
        /* 0x24 */ public float Range;
        /* 0x28 */ public float MaxbankingAmount;
        /* 0x2C */ public float TurnRequiredForMaxBanking;
        /* 0x30 */ public float MaxPitchAmount;
        /* 0x34 */ public float UpwardMovementForMaxPitch;
        /* 0x38 */ public float MaxSpeed;
        /* 0x3C */ public float AlignTime;
        /* 0x40 */ public float SpringSmoothTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] Padding44;

        /* 0x48 */ public List<NMSString0x10> RepelList;
    }
}
