using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x9AA8CC133BED2E72, NameHash = 0x56F9C280B6CFD741)]
    public class GcMissionConditionSeasonNumber : NMSTemplate
    {
        public int ActiveSeason;
    }
}
