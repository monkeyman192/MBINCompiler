namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x631C63205D55D63D, NameHash = 0x5F1BCF79)]
    public class GcHotActionMenuTypes : NMSTemplate
    {
        // size: 0x3
        public enum HotActionMenuTypesEnum : uint {
            OnFoot,
            InShip,
            InExocraft,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HotActionMenuTypesEnum HotActionMenuTypes;
    }
}
