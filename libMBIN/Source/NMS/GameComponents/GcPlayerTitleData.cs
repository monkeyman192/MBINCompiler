using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CD6BACEA37AB171, NameHash = 0xB76358D6)]
    public class GcPlayerTitleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcPlayerTitle> Titles;
    }
}
