using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDE181AA52ECABAE, NameHash = 0xE90309CE)]
    public class GcSolarSystemMapSettings : NMSTemplate
    {
        [NMS(Index = 17, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x0000 */ public GcSolarSystemMapObjectData[] SpacePoiObjectData;
        [NMS(Index = 16, Size = 0x9, EnumType = typeof(GcSolarSystemMapObjectType.SolarSystemMapObjectTypeEnum))]
        /* 0x0700 */ public GcSolarSystemMapObjectData[] MapObjectData;
        [NMS(Index = 27)]
        /* 0x0B80 */ public Colour MapPointLineColour;
        [NMS(Index = 6)]
        /* 0x0B90 */ public Vector3f RealSpaceStationOffset;
        [NMS(Index = 32, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x0BA0 */ public GcSolarSystemMapPointSettings[] SpacePoiPointSettings;
        [NMS(Index = 31, Size = 0x9, EnumType = typeof(GcSolarSystemMapObjectType.SolarSystemMapObjectTypeEnum))]
        /* 0x0E40 */ public GcSolarSystemMapPointSettings[] MapPointSettings;
        [NMS(Index = 33, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0FF0 */ public TkTextureResource[] BackgroundTextures;
        [NMS(Index = 19)]
        /* 0x1068 */ public TkTextureResource GeneralMissionIcon;
        [NMS(Index = 18)]
        /* 0x1080 */ public TkTextureResource LocationMarkerIcon;
        [NMS(Index = 26)]
        /* 0x1098 */ public TkTextureResource MapPointDiamondIcon;
        [NMS(Index = 25)]
        /* 0x10B0 */ public TkTextureResource MapPointDotIcon;
        [NMS(Index = 22)]
        /* 0x10C8 */ public TkTextureResource MapPointGlowImage;
        [NMS(Index = 21)]
        /* 0x10E0 */ public TkTextureResource MapPointHighlightImage;
        [NMS(Index = 20)]
        /* 0x10F8 */ public TkTextureResource PlayerShipCornerIcon;
        [NMS(Index = 23)]
        /* 0x1110 */ public GcFilename MapScanModelResource;
        [NMS(Index = 14)]
        /* 0x1120 */ public GcFilename SolarSystemMapBackgroundResource;
        [NMS(Index = 13)]
        /* 0x1130 */ public GcFilename SolarSystemMapResource;
        [NMS(Index = 15, Size = 0x5, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x1140 */ public float[] PlanetScales;
        [NMS(Index = 10)]
        /* 0x1154 */ public float MapDistanceCompression;
        [NMS(Index = 29)]
        /* 0x1158 */ public float MapPointLineAlpha;
        [NMS(Index = 28)]
        /* 0x115C */ public float MapPointLineLength;
        [NMS(Index = 30)]
        /* 0x1160 */ public float MapPointLineThickness;
        [NMS(Index = 24)]
        /* 0x1164 */ public float MapScanCooldown;
        [NMS(Index = 12)]
        /* 0x1168 */ public float MouseRotateSensitivity;
        [NMS(Index = 11)]
        /* 0x116C */ public float PadRotateSensitivity;
        [NMS(Index = 2)]
        /* 0x1170 */ public float PlayerScale;
        [NMS(Index = 5)]
        /* 0x1174 */ public float RealSpaceStationScale;
        [NMS(Index = 9)]
        /* 0x1178 */ public float SpacePoiMarkerRemovalDistance;
        [NMS(Index = 8)]
        /* 0x117C */ public float SpacePoiScale;
        [NMS(Index = 3)]
        /* 0x1180 */ public float SpaceStationScale;
        [NMS(Index = 7)]
        /* 0x1184 */ public float SpaceStationSpinSpeed;
        [NMS(Index = 1)]
        /* 0x1188 */ public float SystemCameraBounds;
        [NMS(Index = 0)]
        /* 0x118C */ public float SystemScale;
        [NMS(Index = 4)]
        /* 0x1190 */ public bool UseRealSpaceStation;
    }
}
