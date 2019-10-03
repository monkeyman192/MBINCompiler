using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x99B3D742D6891AE9, NameHash = 0x82286E866B7201D0)]
    public class GcGrabbableComponentData : NMSTemplate
    {
        public List<GcGrabbableData> GrabbableDataArray;
    }
}
