using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD0A401791C65EBD, NameHash = 0x349D621C)]
    public class GcVibrationChannelData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x2
        public enum DataEnum {
            Left,
            Right,
        }
        [NMS(Index = 4, Size = 0x2, EnumType = typeof(DataEnum))]
        /* 0x10 */ public GcVibrationData[] Data;
        // size: 0x4
        public enum VRAffectedHandsEnum : uint {
            Both,
            LeftOnly,
            RightOnly,
            DisableInVR,
        }
        [NMS(Index = 1)]
        /* 0x40 */ public VRAffectedHandsEnum VRAffectedHands;
        [NMS(Index = 2)]
        /* 0x44 */ public bool VROnly;
        [NMS(Index = 3)]
        /* 0x45 */ public bool VRSwapHandForLeftHanded;
    }
}
