using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardTeleport : NMSTemplate
    {
        public int TeleportRewardType;
        public string[] TeleportRewardTypeValues()
        {
            return new[] { "None", "ToBase", "Station0", "Station1", "Station2", "Station3" };
        }
    }
}
