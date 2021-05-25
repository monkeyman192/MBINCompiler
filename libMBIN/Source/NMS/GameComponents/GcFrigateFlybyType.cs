using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xA63ABD9C5969E9A1, NameHash = 0x20BC4D823F8443DB)]
    public class GcFrigateFlybyType : NMSTemplate
    {
        public enum FrigateFlybyTypeEnum { SingleShip, Diplomatic };
        public FrigateFlybyTypeEnum FrigateFlybyType;
    }
}
