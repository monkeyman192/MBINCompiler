using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BEC6F9B911BA470, NameHash = 0x363A73C6)]
    public class GcItemCostTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcItemCostData> Items;
    }
}
