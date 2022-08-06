using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAA78F3024F83AF77, NameHash = 0x87C83AD7D0C1D117)]
    public class GcCreatureSwarmData : NMSTemplate
    {
        /* 0x00 */ public int MinCount;
        /* 0x04 */ public int MaxCount;
        /* 0x08 */ public float SwarmMovementSpeed;
        /* 0x0C */ public float SwarmMovementRadius;
		public enum SwarmMovementTypeEnum { None, Circle, Random, Search, FollowPlayer, FollowPlayerLimited }
		/* 0x10 */ public SwarmMovementTypeEnum SwarmMovementType;
        /* 0x18 */ public List<GcCreatureSwarmDataParams> Params;
    }
}
