using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28D9658D883EFB23, NameHash = 0xAF2F2B2DB8C8446A)]
    public class GcAmbientModeCameras : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCameraAmbientBuildingData> BuildingCameraAnimations;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcCameraAmbientSpaceData> SpaceCameraAnimations;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcCameraAmbientSpecialData> SpecialCameraAnimations;
    }
}
