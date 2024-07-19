using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDE93BFF3669E1E8, NameHash = 0xE15978A5)]
    public class GcCameraAerialViewDataTableEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public GcCameraAerialViewData CameraAerialViewData;
    }
}
