using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38858A1D0C239576, NameHash = 0xBEC6F214)]
    public class GcGalaxyAudioSetupData : NMSTemplate
    {
        [NMS(Index = 6, MxmlName = "Event AddWaypoint")]
        /* 0x00 */ public GcAudioWwiseEvents EventAddWaypoint;
        [NMS(Index = 0, MxmlName = "Event MapEnter")]
        /* 0x04 */ public GcAudioWwiseEvents EventMapEnter;
        [NMS(Index = 1, MxmlName = "Event MapExit")]
        /* 0x08 */ public GcAudioWwiseEvents EventMapExit;
        [NMS(Index = 10, MxmlName = "Event Navmode Change")]
        /* 0x0C */ public GcAudioWwiseEvents EventNavmodeChange;
        [NMS(Index = 11, MxmlName = "Event Navmode Change Failed")]
        /* 0x10 */ public GcAudioWwiseEvents EventNavmodeChangeFailed;
        [NMS(Index = 12, MxmlName = "Event Navmode Path Move")]
        /* 0x14 */ public GcAudioWwiseEvents EventNavmodePathMove;
        [NMS(Index = 13, MxmlName = "Event PlanetRumble")]
        /* 0x18 */ public GcAudioWwiseEvents EventPlanetRumble;
        [NMS(Index = 7, MxmlName = "Event RemoveWaypoint")]
        /* 0x1C */ public GcAudioWwiseEvents EventRemoveWaypoint;
        [NMS(Index = 5, MxmlName = "Event RouteLines")]
        /* 0x20 */ public GcAudioWwiseEvents EventRouteLines;
        [NMS(Index = 3, MxmlName = "Event SystemDeselect")]
        /* 0x24 */ public GcAudioWwiseEvents EventSystemDeselect;
        [NMS(Index = 2, MxmlName = "Event SystemSelect")]
        /* 0x28 */ public GcAudioWwiseEvents EventSystemSelect;
        [NMS(Index = 4, MxmlName = "Event TextAppear")]
        /* 0x2C */ public GcAudioWwiseEvents EventTextAppear;
        [NMS(Index = 8, MxmlName = "Event WaypointError")]
        /* 0x30 */ public GcAudioWwiseEvents EventWaypointError;
        [NMS(Index = 9, MxmlName = "Event WaypointLoop")]
        /* 0x34 */ public GcAudioWwiseEvents EventWaypointLoop;
        [NMS(Index = 14, MxmlName = "RTPC Star Whoosh")]
        /* 0x38 */ public GcAudioWwiseRTPCs RTPCStarWhoosh;
        [NMS(Index = 15, MxmlName = "Whoosh Clip")]
        /* 0x3C */ public float WhooshClip;
        [NMS(Index = 16, MxmlName = "Whoosh Multiplier")]
        /* 0x40 */ public float WhooshMultiplier;
    }
}
