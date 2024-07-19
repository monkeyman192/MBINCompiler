namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48765DB963EC9AB3, NameHash = 0xF2F4F1C8)]
    public class GcUnlockableItemTreeGroups : NMSTemplate
    {
        // size: 0xE
        public enum UnlockableItemTreeEnum : uint {
            Test,
            BasicBaseParts,
            BasicTechParts,
            BaseParts,
            SpecialBaseParts,
            SuitTech,
            ShipTech,
            WeapTech,
            ExocraftTech,
            CraftProducts,
            FreighterTech,
            S9BaseParts,
            S9ExoTech,
            S9ShipTech,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public UnlockableItemTreeEnum UnlockableItemTree;
    }
}
