using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xA9B0407BFF169C37, NameHash = 0x3FBB55C99E667F9E)]
    public class GcBaseLinkGridData : NMSTemplate
    {
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        /* 0x38 */ public int Rate;
        /* 0x3C */ public int Storage;
        public enum DependsOnEnvironmentEnum { None, DayNight, Storms }
        /* 0x40 */ public DependsOnEnvironmentEnum DependsOnEnvironment;
        public enum DependsOnHotspotsEnum { None, Power, Mineral, Gas }
        /* 0x44 */ public DependsOnHotspotsEnum DependsOnHotspots;
        /* 0x48 */ public List<GcBaseLinkGridConnectionDependency> DependentConnections;
    }
}
