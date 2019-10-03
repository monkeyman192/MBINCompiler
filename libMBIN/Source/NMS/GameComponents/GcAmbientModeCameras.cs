using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x1284E8A8B0A4B370, NameHash = 0xAF2F2B2DB8C8446A)]
    public class GcAmbientModeCameras : NMSTemplate
    {
        public List<GcCameraAmbientBuildingData> BuildingCameraAnimations;
        public List<GcCameraAmbientSpaceData> SpaceCameraAnimations;
        public List<GcCameraAmbientSpecialData> SpecialCameraAnimations;
    }
}
