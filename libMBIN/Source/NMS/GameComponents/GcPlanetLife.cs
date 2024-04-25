namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0116FA38588CC26, NameHash = 0x1E27C6F2466B2426)]
    public class GcPlanetLife : NMSTemplate
    {
        // size: 0x4
        public enum LifeSettingEnum : uint {
            Dead,
            Low,
            Mid,
            Full,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LifeSettingEnum LifeSetting;
    }
}
