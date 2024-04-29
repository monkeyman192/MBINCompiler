using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C4C882A9E203E36, NameHash = 0xAF919B46C646D940)]
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
