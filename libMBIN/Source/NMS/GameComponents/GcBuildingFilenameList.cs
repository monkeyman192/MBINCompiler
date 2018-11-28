using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8400, GUID = 0x4DF76B86F24FAEC)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS( EnumType = typeof( GcBuildingClassification.BuildingClassEnum ) )]
        public GcBuildingFilename[] BuildingFiles;
    }
}
