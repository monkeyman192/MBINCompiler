using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DF8841262649003, NameHash = 0x3CBA48CA)]
    public class GcPlayerWeaponPropertiesTable : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x14, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x0000 */ public GcPlayerWeaponPropertiesData[] PropertiesData;
        [NMS(Index = 0)]
        /* 0x1A40 */ public GcCamouflageData CamouflageData;
    }
}
