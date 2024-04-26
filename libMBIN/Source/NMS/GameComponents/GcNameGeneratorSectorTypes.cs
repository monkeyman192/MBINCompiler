namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DFB66DB33ABB5EA, NameHash = 0x2FBB792E633BA89B)]
    public class GcNameGeneratorSectorTypes : NMSTemplate
    {
        // size: 0xC
        public enum SectorNameEnum : uint {
            Generic,
            Elevated,
            Low,
            Trees,
            LushTrees,
            Lush,
            Wet,
            Cave,
            Dead,
            Buildings,
            Water,
            Ice,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SectorNameEnum SectorName;
    }
}
