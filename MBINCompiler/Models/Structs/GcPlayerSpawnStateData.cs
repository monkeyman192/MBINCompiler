namespace MBINCompiler.Models.Structs
{
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        /* 0x000 */ public Vector4f PlayerPositionInSystem;
        /* 0x010 */ public Vector4f PlayerTransformAt;
        /* 0x020 */ public Vector4f ShipPositionInSystem;
        /* 0x030 */ public Vector4f ShipTransformAt;
        /* 0x040 */ public int LastKnownPlayerState;
        /* 0x050 */ public string[] LastKnownPlayerStateValues()
        {
            return new[] { "OnFoot", "InShip", "OnStation" };
        }
		[NMS(Size = 0xC, Ignore = true)]
        /* 0x054 */ public byte[] Padding54; 
		/* 0x060 */ public Vector4f FreighterPositionInSystem;
		/* 0x070 */ public Vector4f FreighterTransformAt;
		/* 0x080 */ public Vector4f FreighterTransformUp;
    }
}
