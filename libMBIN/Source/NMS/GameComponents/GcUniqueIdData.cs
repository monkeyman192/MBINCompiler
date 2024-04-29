namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD77C33F5DDF8A996, NameHash = 0xCA58D35FFFB37091)]
    public class GcUniqueIdData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public ulong DeterministicSeed;
        [NMS(Index = 2)]
        /* 0x08 */ public uint Iteration;
        // size: 0x3
        public enum UniqueIdTypeEnum : uint {
            Invalid,
            Deterministic,
            UserSpawned,
        }
        [NMS(Index = 0)]
        /* 0x0C */ public UniqueIdTypeEnum UniqueIdType;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x40 OnlineID;
        [NMS(Index = 4)]
        /* 0x50 */ public NMSString0x20 PlatformID;
    }
}
