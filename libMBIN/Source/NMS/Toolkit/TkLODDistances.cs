using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x55E54F984F8FC220, NameHash = 0xEBE7C90449AD2F8E)]
    public class TkLODDistances : NMSTemplate
    {
        [NMS(Size = 5)]
        public float[] Distances;
    }
}
