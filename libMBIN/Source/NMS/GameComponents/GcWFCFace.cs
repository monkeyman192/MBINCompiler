using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x765EA03C2ED802B0, NameHash = 0xAD33210D14B166A3)]
    public class GcWFCFace : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Connector;
        /* 0x20 */ public bool Symmetric;
        public enum TransformEnum { None, Rotated90, Rotated180, Rotated270, FlippedHorizontally }
        /* 0x24 */ public TransformEnum Transform;
        /* 0x28 */ public List<NMSString0x10> ExcludedNeighboursR0;
        /* 0x38 */ public List<NMSString0x10> ExcludedNeighboursR1;
        /* 0x48 */ public List<NMSString0x10> ExcludedNeighboursR2;
        /* 0x58 */ public List<NMSString0x10> ExcludedNeighboursR3;
        /* 0x68 */ public bool Walkable;
        /* 0x69 */ public bool Incomplete;
        /* 0x6A */ public bool IsEntrance;
        /* 0x70 */ public NMSString0x10 Name;
    }
}
