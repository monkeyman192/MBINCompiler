namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB29B1EEBB6B552F9, NameHash = 0x41EC737F)]
    public class ShapePoint : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector2f Uv;
    }
}
