namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56ED413C84FCF78F, NameHash = 0xE5F4952B)]
    public class GcLightProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour BounceColour;
        [NMS(Index = 1)]
        /* 0x10 */ public Colour LightColour;
        [NMS(Index = 0)]
        /* 0x20 */ public Colour SunColour;
    }
}
