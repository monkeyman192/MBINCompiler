using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x996945D0E0B275B2, NameHash = 0xE90309CE)]
    public class GcSolarSystemMapSettings : NMSTemplate
    {
        [NMS(Index = 17, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x0000 */ public GcSolarSystemMapObjectData[] SpacePoiObjectData;
        [NMS(Index = 16, Size = 0x9, EnumType = typeof(GcSolarSystemMapObjectType.SolarSystemMapObjectTypeEnum))]
        /* 0x08C0 */ public GcSolarSystemMapObjectData[] MapObjectData;
        [NMS(Index = 29)]
        /* 0x0E60 */ public Colour MapPointLineColour;
        [NMS(Index = 30)]
        /* 0x0E70 */ public Colour MapPointLineColourDone;
        [NMS(Index = 31)]
        /* 0x0E80 */ public Colour PopupHeaderColourDone;
        [NMS(Index = 6)]
        /* 0x0E90 */ public Vector3f RealSpaceStationOffset;
        [NMS(Index = 36, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x0EA0 */ public GcSolarSystemMapPointSettings[] SpacePoiPointSettings;
        [NMS(Index = 35, Size = 0x9, EnumType = typeof(GcSolarSystemMapObjectType.SolarSystemMapObjectTypeEnum))]
        /* 0x1140 */ public GcSolarSystemMapPointSettings[] MapPointSettings;
        [NMS(Index = 37, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x12F0 */ public TkTextureResource[] BackgroundTextures;
        [NMS(Index = 19)]
        /* 0x1368 */ public TkTextureResource GeneralMissionIcon;
        [NMS(Index = 18)]
        /* 0x1380 */ public TkTextureResource LocationMarkerIcon;
        [NMS(Index = 27)]
        /* 0x1398 */ public TkTextureResource MapPointDiamondIcon;
        [NMS(Index = 28)]
        /* 0x13B0 */ public TkTextureResource MapPointDiamondIconDone;
        [NMS(Index = 26)]
        /* 0x13C8 */ public TkTextureResource MapPointDotIcon;
        [NMS(Index = 23)]
        /* 0x13E0 */ public TkTextureResource MapPointGlowImage;
        [NMS(Index = 22)]
        /* 0x13F8 */ public TkTextureResource MapPointHighlightImage;
        [NMS(Index = 20)]
        /* 0x1410 */ public TkTextureResource PlayerShipCornerIcon;
        [NMS(Index = 21)]
        /* 0x1428 */ public TkTextureResource RemoteShipCornerIcon;
        [NMS(Index = 24)]
        /* 0x1440 */ public GcFilename MapScanModelResource;
        [NMS(Index = 14)]
        /* 0x1450 */ public GcFilename SolarSystemMapBackgroundResource;
        [NMS(Index = 13)]
        /* 0x1460 */ public GcFilename SolarSystemMapResource;
        [NMS(Index = 15, Size = 0x5, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x1470 */ public float[] PlanetScales;
        [NMS(Index = 10)]
        /* 0x1484 */ public float MapDistanceCompression;
        [NMS(Index = 33)]
        /* 0x1488 */ public float MapPointLineAlpha;
        [NMS(Index = 32)]
        /* 0x148C */ public float MapPointLineLength;
        [NMS(Index = 34)]
        /* 0x1490 */ public float MapPointLineThickness;
        [NMS(Index = 25)]
        /* 0x1494 */ public float MapScanCooldown;
        [NMS(Index = 12)]
        /* 0x1498 */ public float MouseRotateSensitivity;
        [NMS(Index = 11)]
        /* 0x149C */ public float PadRotateSensitivity;
        [NMS(Index = 2)]
        /* 0x14A0 */ public float PlayerScale;
        [NMS(Index = 5)]
        /* 0x14A4 */ public float RealSpaceStationScale;
        [NMS(Index = 9)]
        /* 0x14A8 */ public float SpacePoiMarkerRemovalDistance;
        [NMS(Index = 8)]
        /* 0x14AC */ public float SpacePoiScale;
        [NMS(Index = 3)]
        /* 0x14B0 */ public float SpaceStationScale;
        [NMS(Index = 7)]
        /* 0x14B4 */ public float SpaceStationSpinSpeed;
        [NMS(Index = 1)]
        /* 0x14B8 */ public float SystemCameraBounds;
        [NMS(Index = 0)]
        /* 0x14BC */ public float SystemScale;
        [NMS(Index = 4)]
        /* 0x14C0 */ public bool UseRealSpaceStation;
    }
}
