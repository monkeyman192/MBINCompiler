using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNPCHabitationType : NMSTemplate
    {
        public int NPCHabitationType
        public string[] NPCHabitationTypeValues()
        {
            return new[] { "None", "WeaponsExpert", "Farmer", "Builder", "Vehicles", "Scientist" };
        }
    }
}
