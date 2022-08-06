using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x767B76ECCDE3A3B0, NameHash = 0x800386833E2445B5)]
    public class GcSeasonSaveStateOnDeath : NMSTemplate
    {
        public enum SeasonSaveStateOnDeathEnum { Standard, ResetAndQuit, ResetPosSaveAndQuit, SaveAndQuit }
        public SeasonSaveStateOnDeathEnum SeasonSaveStateOnDeath;
    }
}
