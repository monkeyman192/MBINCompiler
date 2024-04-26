namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0C0B856107BC556, NameHash = 0xEC6598B33FE9523A)]
    public class GcPlayerExperienceAsteroidCreatureSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x10 */ public Vector2f LargeMinMax;
        [NMS(Index = 3)]
        /* 0x18 */ public Vector2f MediumMinMax;
        [NMS(Index = 2)]
        /* 0x20 */ public Vector2f SmallMinMax;
        [NMS(Index = 1)]
        /* 0x28 */ public float Weight;
    }
}
