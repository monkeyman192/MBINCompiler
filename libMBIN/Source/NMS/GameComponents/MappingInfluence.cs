namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5D9BD01CE5291CE, NameHash = 0x9ED6EB52)]
    public class MappingInfluence : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f mTransformInClothT_Axis0;
        [NMS(Index = 4)]
        /* 0x10 */ public Vector3f mTransformInClothT_Axis1;
        [NMS(Index = 5)]
        /* 0x20 */ public Vector3f mTransformInClothT_Axis2;
        [NMS(Index = 2)]
        /* 0x30 */ public Vector3f mTransformInClothT_Pos;
        [NMS(Index = 1)]
        /* 0x40 */ public float DistanceSquared;
        [NMS(Index = 0)]
        /* 0x44 */ public int SimP;
    }
}
