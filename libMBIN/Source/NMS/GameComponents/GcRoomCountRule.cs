using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xA830DA965B664F6C, NameHash = 0x847F4524E9703A38)]
    public class GcRoomCountRule : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string RoomID;
        /* 0x10 */ public int Min;
        /* 0x14 */ public int Max;
    }
}
