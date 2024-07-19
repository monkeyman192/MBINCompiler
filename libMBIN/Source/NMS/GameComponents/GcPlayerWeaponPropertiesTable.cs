using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x321FB2DDADEF82CF, NameHash = 0x3CBA48CA)]
    public class GcPlayerWeaponPropertiesTable : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x0000 */ public GcPlayerWeaponPropertiesData[] PropertiesData;
        [NMS(Index = 0)]
        /* 0x18F0 */ public GcCamouflageData CamouflageData;
    }
}
