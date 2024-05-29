using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x429F34BDADDF6D5A, NameHash = 0xB9F3B9FAC994498B)]
    public class GcRewardSpecificFrigate : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A NameOverride;
        [NMS(Index = 9)]
        /* 0x20 */ public NMSString0x10 PrimaryTrait;
        [NMS(Index = 1)]
        /* 0x30 */ public ulong FrigateSeed;
        [NMS(Index = 2)]
        /* 0x38 */ public ulong SystemSeed;
        [NMS(Index = 3)]
        /* 0x40 */ public GcAlienRace AlienRace;
        [NMS(Index = 0)]
        /* 0x44 */ public GcFrigateClass FrigateClass;
        [NMS(Index = 7)]
        /* 0x48 */ public bool FormatAsSeasonal;
        [NMS(Index = 5)]
        /* 0x49 */ public bool IsGift;
        [NMS(Index = 6)]
        /* 0x4A */ public bool IsRewardFrigate;
        [NMS(Index = 8)]
        /* 0x4B */ public bool UseSeedFromCommunicator;
    }
}
