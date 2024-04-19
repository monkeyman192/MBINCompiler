using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95F7AB7D4A3778A0, NameHash = 0xAD33210D14B166A3)]
    public class GcWFCFace : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ExcludedNeighboursR0;
        /* 0x10 */ public List<NMSString0x10> ExcludedNeighboursR1;
        /* 0x20 */ public List<NMSString0x10> ExcludedNeighboursR2;
        /* 0x30 */ public List<NMSString0x10> ExcludedNeighboursR3;
        /* 0x40 */ public NMSString0x10 Name;
        // size: 0x5
        public enum TransformEnum : uint {
            None,
            Rotated90,
            Rotated180,
            Rotated270,
            FlippedHorizontally,
        }
        /* 0x50 */ public TransformEnum Transform;
        /* 0x54 */ public NMSString0x20 Connector;
        /* 0x74 */ public bool Incomplete;
        /* 0x75 */ public bool IsEntrance;
        /* 0x76 */ public bool Symmetric;
        /* 0x77 */ public bool Walkable;
    }
}
