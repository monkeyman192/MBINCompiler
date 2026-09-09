using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A4B9CC956E9CAF2, NameHash = 0xAFEEEF4C)]
    public class GcCustomisationPreset : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcCharacterCustomisationData Data;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x68 */ public bool CanBeSeasonalStarter;
    }
}
