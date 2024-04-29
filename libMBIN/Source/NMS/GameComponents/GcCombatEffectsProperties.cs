namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57F4BBA247F58C80, NameHash = 0xC39E8583E846A389)]
    public class GcCombatEffectsProperties : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x0 */ public float DamageMultiplier;
        [NMS(Index = 3)]
        /* 0x4 */ public float DurationMultiplier;
        [NMS(Index = 1)]
        /* 0x8 */ public bool IgnoreFromOtherPlayers;
        [NMS(Index = 2)]
        /* 0x9 */ public bool IgnoreFromSelf;
        [NMS(Index = 0)]
        /* 0xA */ public bool IsAffected;
    }
}
