using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x60EFB41575ED04BC, NameHash = 0x59A54DA2535D6C79)]
    public class GcMovementDirection : NMSTemplate
    {
        // size: 0x4
        public enum MovementDirectionEnum { WorldRelative, BodyRelative, HeadRelative, NotSet };
        public MovementDirectionEnum MovementDirection;
    }
}
