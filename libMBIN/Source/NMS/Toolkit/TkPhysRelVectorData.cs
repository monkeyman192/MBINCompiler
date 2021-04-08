using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x20, GUID = 0xE2F605E2E5EF42C1, NameHash = 0xA03B6D2AF8A02EAB)]
    public class TkPhysRelVectorData : NMSTemplate
    {
        public Vector3f Local;
        public Vector3f Offset;
    }
}