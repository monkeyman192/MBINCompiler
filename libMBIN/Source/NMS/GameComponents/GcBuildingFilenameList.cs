using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C00, GUID = 0x4DF76B86F24FAEC, NameHash = 0xC9E2EEA2B81DBE00)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Size = 0x23, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        public GcBuildingFilename[] BuildingFiles;
    }
}
