using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcEncounterComponentData : NMSTemplate
    {
        public int EncounterType;
        public string[] EncounterTypeValues()
        {
            return new[] { "Guards", "Patrol", "Ambush" };
        }
        public int EncounterRobot;
        public string[] EncounterRobotValues()
        {
            return new[] { "Drones", "Quads", "Walker" };
        }
        public int CountMin;
        public int CountMax;
    }
}
