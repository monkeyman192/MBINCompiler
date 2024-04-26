using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C3833BCABB99E84, NameHash = 0x65201C557650B152)]
    public class GcCameraAerialViewDataTableEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public GcCameraAerialViewData CameraAerialViewData;
    }
}
