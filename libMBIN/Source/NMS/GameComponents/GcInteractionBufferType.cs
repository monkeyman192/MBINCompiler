namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7327182011FA2C6, NameHash = 0xC317ACDD)]
    public class GcInteractionBufferType : NMSTemplate
    {
        // size: 0xB
        public enum InteractionBufferTypeEnum : uint {
            Distress_Signal,
            Crate,
            Destructable,
            Terrain,
            Cost,
            Building,
            Creature,
            Maintenance,
            Personal,
            Personal_Maintenance,
            FireteamSync,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InteractionBufferTypeEnum InteractionBufferType;
    }
}
