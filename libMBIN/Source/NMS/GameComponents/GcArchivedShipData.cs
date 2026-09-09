using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DB85BEC58F9A6C8, NameHash = 0xF25F122A)]
    public class GcArchivedShipData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcPlayerOwnershipData Ownership;
        [NMS(Index = 1)]
        /* 0x4E0 */ public GcCharacterCustomisationSaveData Customisation;
        [NMS(Index = 4)]
        /* 0x548 */ public GcSpaceshipClasses ArchivedClass;
        [NMS(Index = 5)]
        /* 0x54C */ public GcInventoryClass ArchivedInventoryClass;
        [NMS(Index = 3)]
        /* 0x550 */ public NMSString0x80 ArchivedName;
        [NMS(Index = 2)]
        /* 0x5D0 */ public bool UsesLegacyColours;
    }
}
