using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, Alignment = 0x8, GUID = 0xAD1975B8FA694E7C, NameHash = 0xD1183794AF82FF99)]
    public class GcFrigateInteractionAction : NMSTemplate
    {
        public enum ActionTypeEnum { Repair, UpdateDamagedComponents, CargoPhoneCall }
        public ActionTypeEnum ActionType;
        public NMSString0x20A CommunicatorDialog;
    }
}
