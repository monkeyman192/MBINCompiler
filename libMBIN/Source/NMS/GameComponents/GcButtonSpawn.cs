using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5116CB653D823AE4, NameHash = 0x7F9FCEDE7E2CBFC0)]
    public class GcButtonSpawn : NMSTemplate
    {
        /* 0x0 */ public TkInputEnum Button;
        // size: 0x5
        public enum EventEnum { None, Pirates, Police, Traders, Walker }
        /* 0x4 */ public EventEnum Event;
        /* 0x8 */ public GcButtonSpawnOffset Offset;
    }
}
