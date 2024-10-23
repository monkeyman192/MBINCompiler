using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE9789D3E977ADB6A, NameHash = 0xA29CFBD3)]
    public class GcStatusMessageDefinition : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A CustomPrefixLocID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Message;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Id;
        [NMS(Index = 10)]
        /* 0x50 */ public float DisplayDurationMultiplier;
        [NMS(Index = 9)]
        /* 0x54 */ public float Distance;
        [NMS(Index = 13)]
        /* 0x58 */ public GcStatusMessageMissionMarkup MissionMarkup;
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
        [NMS(Index = 7)]
        /* 0x5C */ public ReplicateToEnum ReplicateTo;
        [NMS(Index = 4)]
        /* 0x60 */ public bool AddFriendlyDronePrefix;
        [NMS(Index = 3)]
        /* 0x61 */ public bool AddPetNamePrefix;
        [NMS(Index = 2)]
        /* 0x62 */ public bool AddPlayerNamePrefix;
        [NMS(Index = 6)]
        /* 0x63 */ public bool IncludePlayerName;
        [NMS(Index = 11)]
        /* 0x64 */ public bool OnlyInMultiplayer;
        [NMS(Index = 12)]
        /* 0x65 */ public bool OnlyOnFireteam;
        [NMS(Index = 8)]
        /* 0x66 */ public bool PostLocally;
    }
}
