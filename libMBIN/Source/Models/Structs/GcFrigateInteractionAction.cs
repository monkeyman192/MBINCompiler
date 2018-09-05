using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class GcFrigateInteractionAction : NMSTemplate
    {
        public int ActionType;
        public string[] ActionTypeValues()
        {
            return new[] { "Repair", "UpdateDamagedComponents", "CargoPhoneCall"};
        }
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x20)]
        public string CommunicatorDialog;
    }
}
