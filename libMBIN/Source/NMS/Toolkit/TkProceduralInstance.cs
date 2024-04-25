using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x932C48023A84AC1B, NameHash = 0x4D8A5C89BC8B3F)]
    public class TkProceduralInstance : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10)]
        /* 0x0 */ public TkProceduralInstanceData[] Data;
    }
}
