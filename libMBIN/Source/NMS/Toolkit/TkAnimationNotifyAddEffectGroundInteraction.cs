namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2DEF634DF212DD56, NameHash = 0xDFD01A1)]
    public class TkAnimationNotifyAddEffectGroundInteraction : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public float FadeOutHeightBegin;
        [NMS(Index = 4)]
        /* 0x4 */ public float FadeOutHeightEnd;
        [NMS(Index = 5)]
        /* 0x8 */ public float TravelSpeed;
        [NMS(Index = 0)]
        /* 0xC */ public bool ClampToGround;
        [NMS(Index = 1)]
        /* 0xD */ public bool UseGroundNormal;
        [NMS(Index = 2)]
        /* 0xE */ public bool UseWaterSurface;
    }
}
