using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x7972DF469D601F07, NameHash = 0x6F38B975D5E86126)]
    public class GcMissionConditionDefaultItem : NMSTemplate
    {
        public GcDefaultMissionProductEnum ProductType;
        public GcDefaultMissionSubstanceEnum SubstanceType;
        public NMSString0x10 ID;
    }
}
