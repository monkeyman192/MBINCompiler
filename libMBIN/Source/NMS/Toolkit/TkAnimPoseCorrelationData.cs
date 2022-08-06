using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xE39536D6A25C5F9, NameHash = 0x36EF2564DBF81DFA)]
    public class TkAnimPoseCorrelationData : NMSTemplate // 0x28 bytes
    {
        public NMSString0x10 ItemA;
        public NMSString0x10 ItemB;
        public float Correlation;
    }
}