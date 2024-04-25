namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C939A1F96BFC9A6, NameHash = 0x11682D56DC3AFBF1)]
    public class GcWonderCreatureCategory : NMSTemplate
    {
        // size: 0xF
        public enum WonderCreatureCategoryEnum : uint {
            HerbivoreSizeMax,
            HerbivoreSizeMin,
            CarnivoreSizeMax,
            CarnivoreSizeMin,
            IntelligenceMax,
            ViciousnessMax,
            Hot,
            Cold,
            Tox,
            Rad,
            Weird,
            Water,
            Robot,
            Flyer,
            Cave,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderCreatureCategoryEnum WonderCreatureCategory;
    }
}
