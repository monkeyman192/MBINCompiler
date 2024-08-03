using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5B8C67106DFFF28, NameHash = 0xE2349289)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcPlayerDamageData> DamageTable;
    }
}
