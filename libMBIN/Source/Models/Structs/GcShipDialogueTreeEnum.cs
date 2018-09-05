namespace libMBIN.Models.Structs
{
    public class GcShipDialogueTreeEnum : NMSTemplate
    {
        public int DialogueTree;
        public string[] DialogueTreeValues()
        {
            return new[]
            {
                "Bribe", "Beg", "Ambush", "Trade", "Help", "Goods", "Hostile"
            };
        }
    }
}
