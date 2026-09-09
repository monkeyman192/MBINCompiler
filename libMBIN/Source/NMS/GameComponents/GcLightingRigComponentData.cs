using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85DB3DE419D232A2, NameHash = 0x20C96CD2)]
    public class GcLightingRigComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcHeroLightData> LightData;
        [NMS(Index = 5)]
        /* 0x10 */ public float BlendTime;
        // size: 0x3
        public enum LightRigTypeEnum : uint {
            Default,
            ThirdPerson,
            FirstPerson,
        }
        [NMS(Index = 1)]
        /* 0x14 */ public LightRigTypeEnum LightRigType;
        [NMS(Index = 4)]
        /* 0x18 */ public float PitchAngleMax;
        [NMS(Index = 3)]
        /* 0x1C */ public float PitchAngleMin;
        [NMS(Index = 2)]
        /* 0x20 */ public bool DynamicLightRigAllocation;
    }
}
