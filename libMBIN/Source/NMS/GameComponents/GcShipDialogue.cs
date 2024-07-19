using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DA71F6976CA99C5, NameHash = 0xD5492CC8)]
    public class GcShipDialogue : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcShipDialogueTreeEnum.DialogueTreeEnum))]
        /* 0x0 */ public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
