using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE28BA6FB5EB5CDE, NameHash = 0x93C1244DBEE0E0CF)]
    public class GcStatusMessageDefinition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Message;
        /* 0x20 */ public NMSString0x10 Id;
        /* 0x30 */ public float DisplayDurationMultiplier;
        /* 0x34 */ public float Distance;
        /* 0x38 */ public GcStatusMessageMissionMarkup MissionMarkup;
        // size: 0x8
        public enum ReplicateToEnum : uint {
            None,
            Fireteam,
            Fireteam_SameUA,
            Global,
            Global_Distance,
            Fireteam_Distance,
            Fireteam_Global_Distance,
            Not_Fireteam,
        }
        /* 0x3C */ public ReplicateToEnum ReplicateTo;
        /* 0x40 */ public bool AddFriendlyDronePrefix;
        /* 0x41 */ public bool AddPetNamePrefix;
        /* 0x42 */ public bool AddPlayerNamePrefix;
        /* 0x43 */ public bool IncludePlayerName;
        /* 0x44 */ public bool OnlyInMultiplayer;
        /* 0x45 */ public bool OnlyOnFireteam;
        /* 0x46 */ public bool PostLocally;
    }
}
