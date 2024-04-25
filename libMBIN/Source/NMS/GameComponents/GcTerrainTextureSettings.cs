namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3754E474AA4EAEFF, NameHash = 0x3A5D1C2419669AFF)]
    public class GcTerrainTextureSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Brightness;
        [NMS(Index = 1)]
        /* 0x4 */ public float Contrast;
        [NMS(Index = 2)]
        /* 0x8 */ public float Specular;
    }
}
