using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94962CF22ADBDA37, NameHash = 0x93C1244DBEE0E0CF)]
    public class GcStatusMessageDefinition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x20A Message;
        /* 0x30 */ public bool AddPlayerNamePrefix;
        /* 0x31 */ public bool AddPetNamePrefix;
        /* 0x32 */ public bool AddFriendlyDronePrefix;
        /* 0x33 */ public bool IncludePlayerName;
        // size: 0x8
        public enum ReplicateToEnum { None, Fireteam, Fireteam_SameUA, Global, Global_Distance, Fireteam_Distance,
            Fireteam_Global_Distance, Not_Fireteam
        }
        /* 0x34 */ public ReplicateToEnum ReplicateTo;
        /* 0x38 */ public bool PostLocally;
        /* 0x3C */ public float Distance;
        /* 0x40 */ public float DisplayDurationMultiplier;
        /* 0x44 */ public bool OnlyInMultiplayer;
        /* 0x45 */ public bool OnlyOnFireteam;
        /* 0x48 */ public GcStatusMessageMissionMarkup MissionMarkup;
    }
}
