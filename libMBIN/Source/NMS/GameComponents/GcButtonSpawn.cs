using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x499B00ABD95D0606, NameHash = 0x7F9FCEDE7E2CBFC0)]
    public class GcButtonSpawn : NMSTemplate
    {
        /* 0x0 */ public TkInputEnum Button;
		public enum EventEnum { None, Pirates, Police, Traders, Walker }
		/* 0x4 */ public EventEnum Event;
        /* 0x8 */ public GcButtonSpawnOffset Offset;
    }
}
