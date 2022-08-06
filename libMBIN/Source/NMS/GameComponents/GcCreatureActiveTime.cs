using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x565124FA3DA1E406, NameHash = 0x8A8A7AA901A0FC93)]
    public class GcCreatureActiveTime : NMSTemplate
    {
        // size: 0x5
        public enum CreatureActiveTimeEnum { OnlyDay, MostlyDay, AnyTime, MostlyNight, OnlyNight }
        public CreatureActiveTimeEnum CreatureActiveTime;
    }
}
