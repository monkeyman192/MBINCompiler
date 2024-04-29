using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE2513E76F155AB0, NameHash = 0xDF9F37F8504FFE4D)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Animation;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        [NMS(Index = 2)]
        /* 0x20 */ public float Offset;
        [NMS(Index = 5, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x24 */ public bool[] AvailableBuildings;
        [NMS(Index = 6, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x5B */ public bool[] AvailableRaces;
        [NMS(Index = 4)]
        /* 0x64 */ public bool AvoidTerrain;
        [NMS(Index = 3)]
        /* 0x65 */ public bool UseLookAt;
    }
}
