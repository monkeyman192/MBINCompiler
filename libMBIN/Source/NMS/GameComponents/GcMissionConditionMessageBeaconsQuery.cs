using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE369D2131B9DFC07, NameHash = 0x7A896811854A127F)]
    public class GcMissionConditionMessageBeaconsQuery : NMSTemplate
    {
        public int MinPartsFound;
        public int MaxPartsFound;
        public float SearchDistanceLimit;
    }
}
