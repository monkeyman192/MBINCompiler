namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF833A2AB0D342C8F, NameHash = 0x94497FE7)]
    public class GcNetworkOwnershipPriority : NMSTemplate
    {
        // size: 0xB
        public enum NetworkOwnershipPriorityEnum : ushort {
            None = 0x0,
            CargoAlwaysRequiresPermission = 0x1,
            CargoAttractedByAttractor = 0x2,
            CargoInScrapyard = 0x4,
            CargoInCorvette = 0x8,
            CargoInTruck = 0x10,
            CargoHoveredByGravLaser = 0x20,
            CargoInContactWithPlayer = 0x40,
            CargoGrabbedByGravLaser = 0x80,
            IsBeingInteractedWith = 0x100,
            OwnedAndAbsolutelyBlocked = 0x200,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NetworkOwnershipPriorityEnum NetworkOwnershipPriority;
    }
}
