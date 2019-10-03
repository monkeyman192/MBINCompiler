using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C, GUID = 0x7E08D2891797A237, NameHash = 0x9F76738BACABEAD2)]
    public class GcFiendCrimeSpawnData : NMSTemplate
    {
		/* 0x00 */ public GcCreatureTypes Type;
        /* 0x04 */ public float MinDist;
        /* 0x08 */ public float MaxDist;
        // I thought these used the GcFiendCrime struct as an enum, but it updated but the size of these arrays didn't, so maybe not...
        [NMS(Size = 0x6)]
        /* 0x0C */ public int[] MinNum;
        [NMS(Size = 0x6)]
        /* 0x24 */ public int[] MaxNum;
    }
}
