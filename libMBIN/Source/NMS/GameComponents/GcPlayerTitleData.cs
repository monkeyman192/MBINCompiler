using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33A7431E9BB8B62E, NameHash = 0xB76358D6)]
    public class GcPlayerTitleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcPlayerTitle> Titles;
    }
}
