namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA28003C2F8842CB, NameHash = 0xB1D42EFA923F8574)]
    public class GcSolarSystemLocatorTypes : NMSTemplate
    {
        // size: 0x4
        public enum LocatorTypeEnum : uint {
            Generic1,
            Generic2,
            Generic3,
            Generic4,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LocatorTypeEnum LocatorType;
    }
}
