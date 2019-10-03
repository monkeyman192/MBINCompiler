using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x3D20567D24DE0F28, NameHash = 0xE9A41D09A14F59E1)]
    public class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
    {
        public GcMissionConditionIsScanEventLocal Local;
        public float MaxDistance;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Endpadding;
    }
}
