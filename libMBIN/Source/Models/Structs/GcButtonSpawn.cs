namespace libMBIN.Models.Structs
{
    public class GcButtonSpawn : NMSTemplate        // size: 0x28       // in a global?
    {
        /* 0x00 */ public TkInputEnum Button;
		public enum EventEnum { None, Pirates, Police, Traders, Walker }
		public EventEnum Event;
        /* 0x08 */ public GcButtonSpawnOffset Offset;
    }
}
