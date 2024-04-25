namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53DD30E98338ECB, NameHash = 0xFF61F85ED8456D83)]
    public class GcCharacterCustomisationBoneScaleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 BoneName;
        [NMS(Index = 1)]
        /* 0x10 */ public float Scale;
    }
}
