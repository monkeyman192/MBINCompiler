using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x896BC3E3FA9CFAB3, NameHash = 0x780D9DC36193A771)]
    public class TkVoxelGeneratorSettingsElement : NMSTemplate
    {
        /* 0x0000 */ public TkVoxelGeneratorData Min;
        /* 0x15D0 */ public TkVoxelGeneratorData Max;
    }
}
