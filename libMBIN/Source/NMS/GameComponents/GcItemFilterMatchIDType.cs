namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB833EE9086DE092, NameHash = 0x5124D7C4788C2C68)]
    public class GcItemFilterMatchIDType : NMSTemplate
    {
        // size: 0x3
        public enum MatchItemIDTypeEnum : uint {
            Exact,
            Prefix,
            Postfix,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MatchItemIDTypeEnum MatchItemIDType;
    }
}
