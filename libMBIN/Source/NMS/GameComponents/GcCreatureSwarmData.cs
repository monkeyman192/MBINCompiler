using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x8B6B3A0500BDBF5D, NameHash = 0x87C83AD7D0C1D117)]
    public class GcCreatureSwarmData : NMSTemplate
    {
        /* 0x00 */ public int MinCount;
        /* 0x04 */ public int MaxCount;
        /* 0x08 */ public float SwarmMovementSpeed;
        /* 0x0C */ public float SwarmMovementRadius;
		public enum SwarmMovementTypeEnum { None, Circle, Random, Search, FollowPlayer, FollowPlayerLimited }
		/* 0x10 */ public SwarmMovementTypeEnum SwarmMovementType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Coherence;
        /* 0x18 */ public List<GcCreatureSwarmDataParams> Params;
    }
}
