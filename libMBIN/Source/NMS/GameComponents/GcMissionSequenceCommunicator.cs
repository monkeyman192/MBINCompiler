using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76C44A64A4A9374A, NameHash = 0x9CB124D)]
    public class GcMissionSequenceCommunicator : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public GcPlayerCommunicatorMessage Comms;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x20A OptionalWaitMessage;
        [NMS(Index = 9)]
        /* 0x70 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x80 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x90 */ public VariableSizeString OSDMessage;
        [NMS(Index = 1)]
        /* 0xA0 */ public VariableSizeString VRMessage;
        [NMS(Index = 7)]
        /* 0xB0 */ public float MinTimeInSpaceBeforeCall;
        [NMS(Index = 8)]
        /* 0xB4 */ public NMSString0x20 FormatDialogIDWithSeasonData;
        [NMS(Index = 5)]
        /* 0xD4 */ public bool AutoOpen;
        [NMS(Index = 6)]
        /* 0xD5 */ public bool UsePulseEncounterObjectAsAttachment;
    }
}
