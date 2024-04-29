namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98FCAC717CA6836E, NameHash = 0x1667364CB586EB42)]
    public class GcBootLogoData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4)]
        /* 0x00 */ public float[] DisplayTime;
        [NMS(Index = 0, Size = 0x4)]
        /* 0x10 */ public NMSString0x100[] Textures;
    }
}
