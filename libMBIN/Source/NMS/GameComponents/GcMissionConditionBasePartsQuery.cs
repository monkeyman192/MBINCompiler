using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE0, GUID = 0x6BA56557969E3928, NameHash = 0xDC4640E07A221674)]
    public class GcMissionConditionBasePartsQuery : NMSTemplate
    {
        public GcBasePartSearchFilter PartsSearchFilter;
        public int MinPartsFound;
        public int MaxPartsFound;
        public GcBaseSearchFilter ExcludeBasesFilter;
        public bool ExcludeGlobalBuffer;
        public float SearchDistanceLimit;
    }
}
