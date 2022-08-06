using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA216EBAC011E5BA1, NameHash = 0x20BC4D823F8443DB)]
    public class GcFrigateFlybyType : NMSTemplate
    {
        // size: 0x5
        public enum FrigateFlybyTypeEnum { SingleShip, AmbientGroup, ScriptedGroup, DeepSpace, DeepSpaceCommon }
        /* 0x0 */ public FrigateFlybyTypeEnum FrigateFlybyType;
    }
}
