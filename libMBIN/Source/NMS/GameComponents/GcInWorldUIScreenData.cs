namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5948C9BA5BF28374, NameHash = 0xFFAAB9AB630ACB70)]
    public class GcInWorldUIScreenData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f ScreenOffset;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector4f ScreenRotation;
        [NMS(Index = 0)]
        /* 0x20 */ public float ScreenScale;
    }
}
