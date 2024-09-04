using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48025DE47669E30E, NameHash = 0xE2349289)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcPlayerDamageData> DamageTable;
    }
}
