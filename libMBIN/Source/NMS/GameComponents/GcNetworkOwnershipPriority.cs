namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2407553FEC1F9C70, NameHash = 0x94497FE7)]
    public class GcNetworkOwnershipPriority : NMSTemplate
    {
        // size: 0xA
        public enum NetworkOwnershipPriorityEnum : ushort {
            None = 0x0,
            CargoAlwaysRequiresPermission = 0x1,
            CargoAttractedByAttractor = 0x2,
            CargoInScrapyard = 0x4,
            CargoInVehicle = 0x8,
            CargoHoveredByGravLaser = 0x10,
            CargoInContactWithPlayer = 0x20,
            CargoGrabbedByGravLaser = 0x40,
            IsBeingInteractedWith = 0x80,
            OwnedAndAbsolutelyBlocked = 0x100,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NetworkOwnershipPriorityEnum NetworkOwnershipPriority;
    }
}
