using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xE7B910E9C497C58E, NameHash = 0xDF9F37F8504FFE4D)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Animation;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DroneAnimation;
        /* 0x20 */ public float Offset;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
        [NMS(Size = 0x23, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x26 */ public bool[] AvailableBuildings;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x49 */ public bool[] AvailableRaces;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x51 */ public byte[] EndPadding;
    }
}
