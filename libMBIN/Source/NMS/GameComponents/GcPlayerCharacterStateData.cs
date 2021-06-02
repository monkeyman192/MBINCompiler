using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0x1A2D297CF203200D, NameHash = 0xCCEE5C02303ACEC6)]
    public class GcPlayerCharacterStateData : NMSTemplate
    {
        public NMSString0x10 Locomotion0H;
        public NMSString0x10 Locomotion1H;
        public NMSString0x10 Locomotion2H;
        public NMSString0x10 AimTree1HPitch;
        public NMSString0x10 AimTree1HYaw;
        public NMSString0x10 AimTree2HPitch;
        public NMSString0x10 AimTree2HYaw;
        public NMSString0x10 HitReact0H;
        public NMSString0x10 HitReac1H;
        public NMSString0x10 HitReac2H;
        public bool KeepHeadForward;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
