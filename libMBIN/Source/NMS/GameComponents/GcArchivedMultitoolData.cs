using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x821F28EC5D7482E, NameHash = 0x5401D7B)]
    public class GcArchivedMultitoolData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMultitoolData MultitoolData;
        [NMS(Index = 2)]
        /* 0x290 */ public GcInventoryClass ArchivedInventoryClass;
        [NMS(Index = 3)]
        /* 0x294 */ public GcWeaponClasses WeaponClass;
        [NMS(Index = 1)]
        /* 0x298 */ public NMSString0x20 ArchivedName;
    }
}
