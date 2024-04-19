namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x761B5B086FB9A7E8, NameHash = 0xC52227A9653C40A8)]
    public class GcMissionConditionInVR : NMSTemplate
    {
        /* 0x0 */ public bool NeedsHandControllers;
        /* 0x1 */ public bool NeedsNoHandControllers;
        /* 0x2 */ public bool NeedsSmoothMoveOn;
        /* 0x3 */ public bool NeedsSnapTurnOn;
        /* 0x4 */ public bool NeedsTeleportOn;
    }
}
