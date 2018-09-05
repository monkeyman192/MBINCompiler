namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x80)]
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        /* 0x000 */ public Vector4f PlayerPositionInSystem;
        /* 0x010 */ public Vector4f PlayerTransformAt;
        /* 0x020 */ public Vector4f ShipPositionInSystem;
        /* 0x030 */ public Vector4f ShipTransformAt;
        /* 0x040 */ public int LastKnownPlayerState;
        public string[] LastKnownPlayerStateValues()
        {
            return new[] { "OnFoot", "InShip", "InStation", "AboardFleet" };
        }
		[NMS(Size = 0xC, Ignore = true)]
        /* 0x044 */ public byte[] Padding54; 
		/* 0x050 */ public Vector4f FreighterPositionInSystem;
		/* 0x060 */ public Vector4f FreighterTransformAt;
		/* 0x070 */ public Vector4f FreighterTransformUp;
    }
}
