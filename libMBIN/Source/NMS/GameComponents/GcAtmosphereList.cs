using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD65533C3D75FF9E4, NameHash = 0x594FCBE47D02F5DF)]
    public class GcAtmosphereList : NMSTemplate
    {
        public List<NMSString0x80> Atmospheres;
    }
}
