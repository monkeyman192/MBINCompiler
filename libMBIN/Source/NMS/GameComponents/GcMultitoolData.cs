using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8263A567E7E6BE66, NameHash = 0x2AF78E5732410B4F)]
    public class GcMultitoolData : NMSTemplate
    {
        /* 0x000 */ public GcInWorldUIScreenData ScreenData;
        /* 0x030 */ public GcResourceElement Resource;
        /* 0x2D8 */ public GcInventoryContainer Store;
        /* 0x430 */ public GcCharacterCustomisationData CustomisationData;
        /* 0x478 */ public GcInventoryLayout Layout;
        /* 0x490 */ public GcSeed Seed;
        /* 0x4A0 */ public int PrimaryMode;
        /* 0x4A4 */ public int SecondaryMode;
        /* 0x4A8 */ public NMSString0x20 Name;
        /* 0x4C8 */ public bool IsLarge;
        /* 0x4C9 */ public bool UseLegacyColours;
    }
}
