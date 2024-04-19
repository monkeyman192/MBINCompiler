using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BAEA192DC4222BC, NameHash = 0xD14F8D38E31CAB20)]
    public class GcMissionSequenceCommunicator : NMSTemplate
    {
        /* 0x000 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x050 */ public NMSString0x20A OptionalWaitMessage;
        /* 0x070 */ public float MinTimeInSpaceBeforeCall;
        /* 0x074 */ public NMSString0x80 DebugText;
        /* 0x0F4 */ public NMSString0x80 Message;
        /* 0x174 */ public NMSString0x80 OSDMessage;
        /* 0x1F4 */ public NMSString0x80 VRMessage;
        /* 0x274 */ public NMSString0x20 FormatDialogIDWithSeasonData;
        /* 0x294 */ public bool AutoOpen;
        /* 0x295 */ public bool UsePulseEncounterObjectAsAttachment;
    }
}
