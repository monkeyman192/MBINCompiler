namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8C)]
    public class TkLODModelResource : NMSTemplate
    {
        /* 0x00 */ public TkModelResource LODModel;
        /* 0x84 */ public float CrossFadeTime;
        /* 0x88 */ public float CrossFadeOverlap;
    }
}
