using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DC8CE7827F7AD94, NameHash = 0xB9F3B9FAC994498B)]
    public class GcRewardSpecificFrigate : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A NameOverride;
        /* 0x20 */ public NMSString0x10 PrimaryTrait;
        /* 0x30 */ public ulong FrigateSeed;
        /* 0x38 */ public ulong SystemSeed;
        /* 0x40 */ public GcAlienRace AlienRace;
        /* 0x44 */ public GcFrigateClass FrigateClass;
        /* 0x48 */ public bool FormatAsSeasonal;
        /* 0x49 */ public bool IsGift;
        /* 0x4A */ public bool IsRewardFrigate;
        /* 0x4B */ public bool UseSeedFromCommunicator;
    }
}
