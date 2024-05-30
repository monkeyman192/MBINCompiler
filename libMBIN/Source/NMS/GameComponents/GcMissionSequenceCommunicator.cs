using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4DC82CF380BF99C, NameHash = 0xD14F8D38E31CAB20)]
    public class GcMissionSequenceCommunicator : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public GcPlayerCommunicatorMessage Comms;
        [NMS(Index = 2)]
        /* 0x050 */ public NMSString0x20A OptionalWaitMessage;
        [NMS(Index = 7)]
        /* 0x070 */ public float MinTimeInSpaceBeforeCall;
        [NMS(Index = 9)]
        /* 0x074 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0F4 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x174 */ public NMSString0x80 OSDMessage;
        [NMS(Index = 1)]
        /* 0x1F4 */ public NMSString0x80 VRMessage;
        [NMS(Index = 8)]
        /* 0x274 */ public NMSString0x20 FormatDialogIDWithSeasonData;
        [NMS(Index = 5)]
        /* 0x294 */ public bool AutoOpen;
        [NMS(Index = 6)]
        /* 0x295 */ public bool UsePulseEncounterObjectAsAttachment;
    }
}
