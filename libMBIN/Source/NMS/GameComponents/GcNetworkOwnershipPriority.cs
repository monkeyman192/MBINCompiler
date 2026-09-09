namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBBE48213EFB37E58, NameHash = 0x94497FE7)]
    public class GcNetworkOwnershipPriority : NMSTemplate
    {
        // size: 0x6
        public enum NetworkOwnershipPriorityEnum : byte {
            Lowest,
            CargoAttractedByAttractor,
            CargoInScrapyard,
            CargoOnTruckBed,
            CargoGrabbedByGravLaser,
            Highest,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NetworkOwnershipPriorityEnum NetworkOwnershipPriority;
    }
}
