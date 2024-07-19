using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x50B6687634F26C3B, NameHash = 0x2570BAC3)]
    public class TkVoxelGeneratorSettingsElement : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0000 */ public TkVoxelGeneratorData Max;
        [NMS(Index = 0)]
        /* 0x1150 */ public TkVoxelGeneratorData Min;
    }
}
