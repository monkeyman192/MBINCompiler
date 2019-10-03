using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x4AF25493757A559, NameHash = 0xF37361EE179B2EF6)]
    public class TkEmitterData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Particle;
    }
}
