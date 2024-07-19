using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2ADA807439157DCD, NameHash = 0xBB7EFD7B)]
    public class GcSelectableObjectSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcResourceElement Resource;
    }
}
