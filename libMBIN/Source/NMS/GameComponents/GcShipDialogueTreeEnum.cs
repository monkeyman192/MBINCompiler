namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBD94A72AECBA114, NameHash = 0xBC8B5F2250F65891)]
    public class GcShipDialogueTreeEnum : NMSTemplate
    {
        // size: 0x7
        public enum DialogueTreeEnum : uint {
            Bribe,
            Beg,
            Ambush,
            Trade,
            Help,
            Goods,
            Hostile,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DialogueTreeEnum DialogueTree;
    }
}
