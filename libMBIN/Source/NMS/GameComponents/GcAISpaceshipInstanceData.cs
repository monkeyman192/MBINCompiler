using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBD8A1BAD12326FE2, NameHash = 0xADEC3C497457F525)]
    public class GcAISpaceshipInstanceData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string File;
    }
}
