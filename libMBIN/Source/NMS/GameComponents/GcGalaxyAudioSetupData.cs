using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x44, GUID = 0x2E538940E929A27C, NameHash = 0xA3F156D44BBFB2B9)]
    public class GcGalaxyAudioSetupData : NMSTemplate
    {
        /* 0x00 */ public GcAudioWwiseEvents EventMapEnter;
        /* 0x04 */ public GcAudioWwiseEvents EventMapExit;
        /* 0x08 */ public GcAudioWwiseEvents EventSystemSelect;
        /* 0x0C */ public GcAudioWwiseEvents EventSystemDeselect;
        /* 0x10 */ public GcAudioWwiseEvents EventTextAppear;
        /* 0x14 */ public GcAudioWwiseEvents EventRouteLines;
        /* 0x18 */ public GcAudioWwiseEvents EventAddWaypoint;
        /* 0x1C */ public GcAudioWwiseEvents EventRemoveWaypoint;
        /* 0x20 */ public GcAudioWwiseEvents EventWaypointError;
        /* 0x24 */ public GcAudioWwiseEvents EventWaypointLoop;
        /* 0x28 */ public GcAudioWwiseEvents EventNavmodeChange;
        /* 0x2C */ public GcAudioWwiseEvents EventNavmodeChangeFailed;
        /* 0x30 */ public GcAudioWwiseEvents EventNavmodePathMove;
        /* 0x34 */ public GcAudioWwiseEvents EventPlanetRumble;
        /* 0x38 */ public GcAudioWwiseRTPCs RTPCStarWhoosh;
        /* 0x3C */ public float WhooshClip;                             // 3DCCCCCDh
        /* 0x40 */ public float WhooshMultiplier;                       // 42C80000h
    }
}
