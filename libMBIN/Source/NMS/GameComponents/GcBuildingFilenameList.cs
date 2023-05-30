using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBuildingFilenameList : NMSTemplate // 0x2C00 bytes
    {
        [NMS(Size = 0x16)]
        public GcBuildingFilename[] BuildingFiles;
    }
}
