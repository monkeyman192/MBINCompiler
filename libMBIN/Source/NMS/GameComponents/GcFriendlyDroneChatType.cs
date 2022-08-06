using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA0B4D7494AE4965, NameHash = 0x006E9F63DB3D3055)]
    public class GcFriendlyDroneChatType : NMSTemplate
    {
        // size: 0x5
        public enum FriendlyDroneChatTypeEnum { Summoned, Unsummoned, BecomeWanted, LoseWanted, Idle }
        /* 0x0 */ public FriendlyDroneChatTypeEnum FriendlyDroneChatType;
    }
}
