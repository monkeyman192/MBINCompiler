using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB6EBBD7E6C55765C, NameHash = 0x60EEF97D074917CD)]
    public class GcMissionGalacticFeature : NMSTemplate
    {
		public enum GalacticFeatureEnum { Anomaly, Atlas, BlackHole }
		public GalacticFeatureEnum GalacticFeature;
    }
}