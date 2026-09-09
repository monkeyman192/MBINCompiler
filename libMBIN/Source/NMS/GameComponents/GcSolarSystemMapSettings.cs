using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x790B7ADD4F3DB791, NameHash = 0xE90309CE)]
    public class GcSolarSystemMapSettings : NMSTemplate
    {
        [NMS(Index = 17, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x0000 */ public GcSolarSystemMapObjectData[] SpacePoiObjectData;
        [NMS(Index = 16, Size = 0x9, EnumType = typeof(GcSolarSystemMapObjectType.SolarSystemMapObjectTypeEnum))]
        /* 0x0700 */ public GcSolarSystemMapObjectData[] MapObjectData;
        [NMS(Index = 28)]
        /* 0x0B80 */ public Colour MapPointLineColour;
        [NMS(Index = 29)]
        /* 0x0B90 */ public Colour MapPointLineColourDone;
        [NMS(Index = 30)]
        /* 0x0BA0 */ public Colour PopupHeaderColourDone;
        [NMS(Index = 6)]
        /* 0x0BB0 */ public Vector3f RealSpaceStationOffset;
        [NMS(Index = 35, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x0BC0 */ public GcSolarSystemMapPointSettings[] SpacePoiPointSettings;
        [NMS(Index = 34, Size = 0x9, EnumType = typeof(GcSolarSystemMapObjectType.SolarSystemMapObjectTypeEnum))]
        /* 0x0E60 */ public GcSolarSystemMapPointSettings[] MapPointSettings;
        [NMS(Index = 36, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1010 */ public TkTextureResource[] BackgroundTextures;
        [NMS(Index = 19)]
        /* 0x1088 */ public TkTextureResource GeneralMissionIcon;
        [NMS(Index = 18)]
        /* 0x10A0 */ public TkTextureResource LocationMarkerIcon;
        [NMS(Index = 26)]
        /* 0x10B8 */ public TkTextureResource MapPointDiamondIcon;
        [NMS(Index = 27)]
        /* 0x10D0 */ public TkTextureResource MapPointDiamondIconDone;
        [NMS(Index = 25)]
        /* 0x10E8 */ public TkTextureResource MapPointDotIcon;
        [NMS(Index = 22)]
        /* 0x1100 */ public TkTextureResource MapPointGlowImage;
        [NMS(Index = 21)]
        /* 0x1118 */ public TkTextureResource MapPointHighlightImage;
        [NMS(Index = 20)]
        /* 0x1130 */ public TkTextureResource PlayerShipCornerIcon;
        [NMS(Index = 23)]
        /* 0x1148 */ public GcFilename MapScanModelResource;
        [NMS(Index = 14)]
        /* 0x1158 */ public GcFilename SolarSystemMapBackgroundResource;
        [NMS(Index = 13)]
        /* 0x1168 */ public GcFilename SolarSystemMapResource;
        [NMS(Index = 15, Size = 0x5, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x1178 */ public float[] PlanetScales;
        [NMS(Index = 10)]
        /* 0x118C */ public float MapDistanceCompression;
        [NMS(Index = 32)]
        /* 0x1190 */ public float MapPointLineAlpha;
        [NMS(Index = 31)]
        /* 0x1194 */ public float MapPointLineLength;
        [NMS(Index = 33)]
        /* 0x1198 */ public float MapPointLineThickness;
        [NMS(Index = 24)]
        /* 0x119C */ public float MapScanCooldown;
        [NMS(Index = 12)]
        /* 0x11A0 */ public float MouseRotateSensitivity;
        [NMS(Index = 11)]
        /* 0x11A4 */ public float PadRotateSensitivity;
        [NMS(Index = 2)]
        /* 0x11A8 */ public float PlayerScale;
        [NMS(Index = 5)]
        /* 0x11AC */ public float RealSpaceStationScale;
        [NMS(Index = 9)]
        /* 0x11B0 */ public float SpacePoiMarkerRemovalDistance;
        [NMS(Index = 8)]
        /* 0x11B4 */ public float SpacePoiScale;
        [NMS(Index = 3)]
        /* 0x11B8 */ public float SpaceStationScale;
        [NMS(Index = 7)]
        /* 0x11BC */ public float SpaceStationSpinSpeed;
        [NMS(Index = 1)]
        /* 0x11C0 */ public float SystemCameraBounds;
        [NMS(Index = 0)]
        /* 0x11C4 */ public float SystemScale;
        [NMS(Index = 4)]
        /* 0x11C8 */ public bool UseRealSpaceStation;
    }
}
