namespace libMBIN.Models.Structs
{
    public class GcGoToStateAction : NMSTemplate        // size: 0x18
    {
        [NMS(Size = 0x10)]
        public string State;

        public bool Broadcast;
		public enum BroadcastLevelEnum { Scene, LocalModel, Local }
		public BroadcastLevelEnum BroadcastLevel;
    }
}
