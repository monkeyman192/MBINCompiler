namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x196A7234D4D7A5DA, NameHash = 0x88C80333)]
    public class GcStaticTag : NMSTemplate
    {
        // size: 0x17
        public enum StaticTagEnum : uint {
            None = 0x0,
            GravityLaserGrabbable = 0x1,
            TruckCargoObject = 0x2,
            TruckCargoSpecial = 0x4,
            TruckFlatbed = 0x8,
            ScrapyardFurnace = 0x10,
            ScrapyardToxBin = 0x20,
            ScrapyardRadBin = 0x40,
            ScrapyardExpBin = 0x80,
            TruckCargoSwarm = 0x100,
            AsteroidSpecial = 0x200,
            HulkCommon = 0x400,
            HulkSmuggle = 0x800,
            HulkBlackbox = 0x1000,
            HulkReactor = 0x2000,
            HulkCore = 0x4000,
            HulkLockbox = 0x8000,
            HulkAux = 0x10000,
            HulkDataCore = 0x20000,
            HulkCanister = 0x40000,
            SlimeCommon = 0x80000,
            SlimeBlob = 0x100000,
            SlimeStar = 0x200000,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StaticTagEnum StaticTag;
    }
}
