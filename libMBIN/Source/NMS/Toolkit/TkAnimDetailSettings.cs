using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0x3E92534447257CA6, NameHash = 0x2FAF173AC809FC4C)]
    public class TkAnimDetailSettings : NMSTemplate
    {
        public float MaxVisibleAngle;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<TkAnimDetailSettingsData> AnimDistanceSettings;
        [NMS(Size = 0x3)]
        public float[] AnimLODDistances;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;

    }
}
