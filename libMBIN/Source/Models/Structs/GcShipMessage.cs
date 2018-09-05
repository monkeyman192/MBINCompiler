namespace libMBIN.Models.Structs
{
    public class GcShipMessage : NMSTemplate
    {
        public int MessageType;
        public string[] MessageTypeValues()
        {
            return new[] { "Leave", "Fight" };
        }
    }
}
