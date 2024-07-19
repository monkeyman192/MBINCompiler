namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC35861E5E356A4C, NameHash = 0x6C078BF2)]
    public class GcShipFlareComponentData : NMSTemplate
    {
        // size: 0x1
        public enum FlareTypeEnum : uint {
            Default,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FlareTypeEnum FlareType;
    }
}
