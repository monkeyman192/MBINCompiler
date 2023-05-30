using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkEngineSettingsMapping : NMSTemplate
    {
        public float ShadowMultiplierLow;
        public float ShadowMultiplierNormal;
        public float ShadowMultiplierHigh;
        public float ShadowMultiplierUltra;
        public float ReflectionMultiplierLow;
        public float ReflectionMultiplierNormal;
        public float ReflectionMultiplierHigh;

        /* unsure what these mean, all are labelled "NeedsGameRestart", first one is checked and if true another 0x13 are read? */
        public bool NeedsGameRestart;
        public bool NeedsGameRestart1;
        public bool NeedsGameRestart2;
        public bool NeedsGameRestart3;
        public bool NeedsGameRestart4;
        public bool NeedsGameRestart5;
        public bool NeedsGameRestart6;
        public bool NeedsGameRestart7;
        public bool NeedsGameRestart8;
        public bool NeedsGameRestart9;
        public bool NeedsGameRestart10;
        public bool NeedsGameRestart11;
        public bool NeedsGameRestart12;
        public bool NeedsGameRestart13;
        public bool NeedsGameRestart14;
        public bool NeedsGameRestart15;
        public bool NeedsGameRestart16;
        public bool NeedsGameRestart17;
        public bool NeedsGameRestart18;
        public bool NeedsGameRestart19;
    }
}
