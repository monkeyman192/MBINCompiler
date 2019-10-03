using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0xBDD07BD52E596B40, NameHash = 0xE4A9F22B5EB5CBF8)]
    public class GcDroneComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis PrimaryAxis;
        public float Scaler;
        public GcCreatureHealthData Health;
    }
}
