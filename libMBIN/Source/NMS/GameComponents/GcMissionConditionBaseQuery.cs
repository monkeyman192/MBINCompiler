using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xA504BB8D38C93B8C, NameHash = 0xDAD32FDD35922F28)]
    public class GcMissionConditionBaseQuery : NMSTemplate
    {
        public GcBaseSearchFilter BaseSearchFilter;
        public int MinBasesFound;
        public int MaxBasesFound;
        public float SearchDistanceLimit;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
