using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47649772E59F4E26, NameHash = 0xAD33210D14B166A3)]
    public class GcWFCFace : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<NMSString0x10> ExcludedNeighboursR0;
        [NMS(Index = 4)]
        /* 0x10 */ public List<NMSString0x10> ExcludedNeighboursR1;
        [NMS(Index = 5)]
        /* 0x20 */ public List<NMSString0x10> ExcludedNeighboursR2;
        [NMS(Index = 6)]
        /* 0x30 */ public List<NMSString0x10> ExcludedNeighboursR3;
        [NMS(Index = 10)]
        /* 0x40 */ public NMSString0x10 Name;
        // size: 0x5
        public enum TransformEnum : uint {
            None,
            Rotated90,
            Rotated180,
            Rotated270,
            FlippedHorizontally,
        }
        [NMS(Index = 2)]
        /* 0x50 */ public TransformEnum Transform;
        [NMS(Index = 0)]
        /* 0x54 */ public NMSString0x20 Connector;
        [NMS(Index = 8)]
        /* 0x74 */ public bool Incomplete;
        [NMS(Index = 9)]
        /* 0x75 */ public bool IsEntrance;
        [NMS(Index = 1)]
        /* 0x76 */ public bool Symmetric;
        [NMS(Index = 7)]
        /* 0x77 */ public bool Walkable;
    }
}
