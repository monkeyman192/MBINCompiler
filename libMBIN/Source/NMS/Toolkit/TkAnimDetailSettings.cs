using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xED9F600E1FD8040, NameHash = 0x2FAF173AC809FC4C)]
    public class TkAnimDetailSettings : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimDetailSettingsData> AnimDistanceSettings;
        [NMS(Size = 0x3)]
        /* 0x10 */ public float[] AnimLODDistances;
        /* 0x1C */ public float MaxVisibleAngle;
    }
}
