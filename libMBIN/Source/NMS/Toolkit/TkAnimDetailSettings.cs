using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x416BF4022E3DF7F3, NameHash = 0x95725F38)]
    public class TkAnimDetailSettings : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkAnimDetailSettingsData> AnimDistanceSettings;
        [NMS(Index = 2, Size = 0x3)]
        /* 0x10 */ public float[] AnimLODDistances;
        [NMS(Index = 0)]
        /* 0x1C */ public float MaxVisibleAngle;
    }
}
