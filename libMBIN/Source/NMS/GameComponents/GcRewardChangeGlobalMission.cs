using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardChangeGlobalMission : NMSTemplate
    {
        public int GlobalMission;

        public string[] GlobalMissionValues()
        {
            return new[] { "Atlas", "BlackHole", "Anomaly", "Explore" };
        }
    }
}
