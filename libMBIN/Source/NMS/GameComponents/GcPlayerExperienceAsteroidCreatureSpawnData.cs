using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF44118A54573310B, NameHash = 0xEC6598B33FE9523A)]
    public class GcPlayerExperienceAsteroidCreatureSpawnData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float Weight;
        /* 0x14 */ public Vector2f SmallMinMax;
        /* 0x1C */ public Vector2f MediumMinMax;
        /* 0x24 */ public Vector2f LargeMinMax;
    }
}
