using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81E26043353EE439, NameHash = 0x87AF3D11ECD3C009)]
    public class GcBaseBuildingPartsTable : NMSTemplate
    {
        public List<GcBaseBuildingPart> Parts;
    }
}
