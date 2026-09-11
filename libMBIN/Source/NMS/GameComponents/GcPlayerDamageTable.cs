using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE62C445C8DC342A4, NameHash = 0xE2349289)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "Id")]
        /* 0x0 */ public HashMap<GcPlayerDamageData> DamageTable;
    }
}
