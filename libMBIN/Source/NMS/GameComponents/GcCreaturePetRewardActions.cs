namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7BB173D3DEC06E0, NameHash = 0xA78B3BB0870D4585)]
    public class GcCreaturePetRewardActions : NMSTemplate
    {
        // size: 0x9
        public enum PetActionEnum : uint {
            Tickle,
            Treat,
            Ride,
            Customise,
            Abandon,
            LayEgg,
            Adopt,
            Milk,
            HarvestSpecial,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetActionEnum PetAction;
    }
}
