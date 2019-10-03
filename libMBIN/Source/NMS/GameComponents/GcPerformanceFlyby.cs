using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1C154290758F1D41, NameHash = 0x5384022399CAF09)]
    public class GcPerformanceFlyby : NMSTemplate       // size: 0x18       in global??
    {
        public float Length;            // 44FA0000h
        public float Offset;            // 43480000h
        public bool Locked;             // 0
        public float LockedOffset;      // 42C80000h
        public float LockTime;          // 40A00000h
        public float LockSpeed;         // 3F000000h
    }
}
