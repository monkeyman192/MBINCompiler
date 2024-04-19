using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8F66D1290EEC0E7, NameHash = 0x3FBB55C99E667F9E)]
    public class GcBaseLinkGridData : NMSTemplate
    {
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        /* 0x38 */ public List<GcBaseLinkGridConnectionDependency> DependentConnections;
        // size: 0x3
        public enum DependsOnEnvironmentEnum : uint {
            None,
            DayNight,
            Storms,
        }
        /* 0x48 */ public DependsOnEnvironmentEnum DependsOnEnvironment;
        // size: 0x4
        public enum DependsOnHotspotsEnum : uint {
            None,
            Power,
            Mineral,
            Gas,
        }
        /* 0x4C */ public DependsOnHotspotsEnum DependsOnHotspots;
        /* 0x50 */ public int Rate;
        /* 0x54 */ public int Storage;
    }
}
