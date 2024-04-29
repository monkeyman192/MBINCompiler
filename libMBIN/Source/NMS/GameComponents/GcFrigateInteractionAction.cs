namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58B35C5F35E9B5E6, NameHash = 0xD1183794AF82FF99)]
    public class GcFrigateInteractionAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CommunicatorDialog;
        // size: 0x3
        public enum ActionTypeEnum : uint {
            Repair,
            UpdateDamagedComponents,
            CargoPhoneCall,
        }
        [NMS(Index = 0)]
        /* 0x20 */ public ActionTypeEnum ActionType;
    }
}
