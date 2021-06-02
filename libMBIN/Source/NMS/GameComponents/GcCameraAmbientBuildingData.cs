using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xE7B910E9C497C58E, NameHash = 0xDF9F37F8504FFE4D)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        /* 0x20 */ public float Offset;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
        [NMS(Size = 0x24, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x26 */ public bool[] AvailableBuildings;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x4A */ public bool[] AvailableRaces;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x52 */ public byte[] EndPadding;
    }
}
