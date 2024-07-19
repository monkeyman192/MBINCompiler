namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DFB66DB33ABB5EA, NameHash = 0xDB1821A3)]
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
