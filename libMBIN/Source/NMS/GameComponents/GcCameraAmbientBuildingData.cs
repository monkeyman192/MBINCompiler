using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3426A684FE1AE00, NameHash = 0xDF9F37F8504FFE4D)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        /* 0x20 */ public float Offset;
        [NMS(Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x24 */ public bool[] AvailableBuildings;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x5B */ public bool[] AvailableRaces;
        /* 0x64 */ public bool AvoidTerrain;
        /* 0x65 */ public bool UseLookAt;
    }
}
