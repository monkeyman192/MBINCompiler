namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87DB90412F957DEF, NameHash = 0x1667364CB586EB42)]
    public class GcBootLogoData : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x00 */ public float[] DisplayTime;
        [NMS(Size = 0x4)]
        /* 0x10 */ public NMSString0x100[] Textures;
    }
}
