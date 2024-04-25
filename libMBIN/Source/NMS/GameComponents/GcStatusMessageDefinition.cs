using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE28BA6FB5EB5CDE, NameHash = 0x93C1244DBEE0E0CF)]
    public class GcStatusMessageDefinition : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Message;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 9)]
        /* 0x30 */ public float DisplayDurationMultiplier;
        [NMS(Index = 8)]
        /* 0x34 */ public float Distance;
        [NMS(Index = 12)]
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
        [NMS(Index = 6)]
        /* 0x3C */ public ReplicateToEnum ReplicateTo;
        [NMS(Index = 4)]
        /* 0x40 */ public bool AddFriendlyDronePrefix;
        [NMS(Index = 3)]
        /* 0x41 */ public bool AddPetNamePrefix;
        [NMS(Index = 2)]
        /* 0x42 */ public bool AddPlayerNamePrefix;
        [NMS(Index = 5)]
        /* 0x43 */ public bool IncludePlayerName;
        [NMS(Index = 10)]
        /* 0x44 */ public bool OnlyInMultiplayer;
        [NMS(Index = 11)]
        /* 0x45 */ public bool OnlyOnFireteam;
        [NMS(Index = 7)]
        /* 0x46 */ public bool PostLocally;
    }
}
