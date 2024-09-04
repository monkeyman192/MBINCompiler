using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B13724CF5F61F69, NameHash = 0xD5492CC8)]
    public class GcShipDialogue : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcShipDialogueTreeEnum.DialogueTreeEnum))]
        /* 0x0 */ public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
