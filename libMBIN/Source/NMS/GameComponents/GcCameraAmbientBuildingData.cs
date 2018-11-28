using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xE7B910E9C497C58E)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Animation;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DroneAnimation;
        /* 0x20 */ public float Offset;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
        [NMS( EnumType = typeof( GcBuildingClassification.BuildingClassEnum ) )]
        /* 0x26 */ public bool[] AvailableBuildings;
        [NMS( EnumType = typeof( GcAlienRace.AlienRaceEnum ) )]
        /* 0x43 */ public bool[] AvailableRaces;

        [NMS(Size = 0x6, Ignore = true)]
        /* 0x4A */ public byte[] EndPadding;
    }
}
