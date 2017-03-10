namespace MBINCompiler.Models.Structs
{
    public class GcCameraSpawnSetupData : NMSTemplate
    {
		/* 0x000 */ public float Distance;
		/* 0x004 */ public bool InFrontOfShip;
        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding5;
		/* 0x008 */ public float YawProportion;
		/* 0x00C */ public float HorizontalProportion;
	}
}