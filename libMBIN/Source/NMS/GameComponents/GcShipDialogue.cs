using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x268, GUID = 0xF653BDA2ED60AE1D, NameHash = 0x770E3F1934F2D769)]
    public class GcShipDialogue : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcShipDialogueTreeEnum.DialogueTreeEnum))]
        public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
