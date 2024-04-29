using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A5370CC1B7EC37E, NameHash = 0x770E3F1934F2D769)]
    public class GcShipDialogue : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcShipDialogueTreeEnum.DialogueTreeEnum))]
        /* 0x0 */ public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
