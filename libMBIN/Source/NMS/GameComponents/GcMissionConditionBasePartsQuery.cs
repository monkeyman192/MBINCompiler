using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x551F2CE669AC9111, NameHash = 0xDC4640E07A221674)]
    public class GcMissionConditionBasePartsQuery : NMSTemplate
    {
        public GcBasePartSearchFilter PartsSeachFilter;
        public int MinPartsFound;
        public int MaxPartsFound;
        public GcBaseSearchFilter ExcludeBasesFilter;
        public bool ExcludeGlobalBuffer;
        public float SearchDistanceLimit;
    }
}
