using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32E1AA5C4BCC8D3B, NameHash = 0x798B3001AC5A7114)]
    public class GcMissionConditionWeaponMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerWeapons WeaponMode;
    }
}
