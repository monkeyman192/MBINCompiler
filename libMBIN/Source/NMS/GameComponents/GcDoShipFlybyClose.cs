using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A90AA1BA5899070, NameHash = 0x9C74A74AB0211EF6)]
    public class GcDoShipFlybyClose : NMSTemplate
    {
        public float LockOffset;        // 42C80000h
        public float LockTime;          // 40A00000h
        public float LockSpread;        // 41200000h
        public bool StayCloseAtLowSpeed;// 0
        public bool HailingBehaviour; // dummy for now maybe? Or might indicate whether it can/will hail.
    }
}
