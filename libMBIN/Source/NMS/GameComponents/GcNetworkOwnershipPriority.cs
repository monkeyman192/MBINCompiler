namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63D492675A119CD5, NameHash = 0x94497FE7)]
    public class GcNetworkOwnershipPriority : NMSTemplate
    {
        // size: 0x9
        public enum NetworkOwnershipPriorityEnum : byte {
            None = 0x0,
            CargoAttractedByAttractor = 0x1,
            CargoInScrapyard = 0x2,
            CargoInVehicle = 0x4,
            CargoHoveredByGravLaser = 0x8,
            CargoInContactWithPlayer = 0x10,
            CargoGrabbedByGravLaser = 0x20,
            IsBeingInteractedWith = 0x40,
            OwnedAndAbsolutelyBlocked = 0x80,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NetworkOwnershipPriorityEnum NetworkOwnershipPriority;
    }
}
