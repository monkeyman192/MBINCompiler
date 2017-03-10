namespace MBINCompiler.Models.Structs
{
    public class GcAudio3PointDopplerData : NMSTemplate
    {
        /* 0x000 */ public float Front;
		/* 0x004 */ public float Mid;
		/* 0x008 */ public float Rear;
		[NMS(Size = 18, Ignore = true)] // Not sure if this padding is necessary
        public byte[] Padding9;

		}
    }
}
