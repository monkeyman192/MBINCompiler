using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFF1A219F4DEB9A2, NameHash = 0xE1CDA71E5D51FD24)]
    public class GcSelectableObjectSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcResourceElement Resource;
    }
}
