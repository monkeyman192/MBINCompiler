namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD24C7139B808A970, NameHash = 0xC52227A9653C40A8)]
    public class GcMissionConditionInVR : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool NeedsHandControllers;
        [NMS(Index = 2)]
        /* 0x1 */ public bool NeedsNoHandControllers;
        [NMS(Index = 4)]
        /* 0x2 */ public bool NeedsSmoothMoveOn;
        [NMS(Index = 1)]
        /* 0x3 */ public bool NeedsSnapTurnOn;
        [NMS(Index = 3)]
        /* 0x4 */ public bool NeedsTeleportOn;
    }
}
