using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2F1BDD96239E523F, NameHash = 0x780D9DC36193A771)]
    public class TkVoxelGeneratorSettingsElement : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0000 */ public TkVoxelGeneratorData Max;
        [NMS(Index = 0)]
        /* 0x1540 */ public TkVoxelGeneratorData Min;
    }
}
