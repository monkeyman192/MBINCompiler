using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24DAA4A4A6637213, NameHash = 0x65201C557650B152)]
    public class GcCameraAerialViewDataTableEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public GcCameraAerialViewData CameraAerialViewData;
    }
}
