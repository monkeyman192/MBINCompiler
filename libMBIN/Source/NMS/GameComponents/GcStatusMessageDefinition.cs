using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0xB963F8CF76196E1, NameHash = 0x93C1244DBEE0E0CF)]
    public class GcStatusMessageDefinition : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Message;
        /* 0x30 */ public bool AddPlayerNamePrefix;
        /* 0x31 */ public bool IncludePlayerName;
        public enum ReplicateToEnum { None, Fireteam, Global, Global_Distance, Fireteam_Distance, Fireteam_Global_Distance }
        /* 0x34 */ public ReplicateToEnum ReplicateTo;
        /* 0x38 */ public bool PostLocally;
        /* 0x3C */ public float Distance;
        /* 0x40 */ public bool OnlyInMultiplayer;
        /* 0x41 */ public bool OnlyOnFireteam;
        /* 0x44 */ public GcStatusMessageMissionMarkup MissionMarkup;
    }
}
