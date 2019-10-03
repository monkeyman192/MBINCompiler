using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x34, GUID = 0x45FE3137E90587F4, NameHash = 0x566CA1D9F6501832)]
    public class GcCharacterLookAtData : NMSTemplate
    {
        public float InteractionLookAtRadius;
        public float CreatureLookAtRadius;
        public float SpaceshipLookAtRadius;
        public float LookAtRunGlanceMinTime;
        public float LookAtRunGlanceMaxTime;
        public float LookAtRunMinTime;
        public float LookAtRunMaxTime;
        public float LookAtTargetGlanceMinTime;
        public float LookAtTargetGlanceMaxTime;
        public float LookAtTargetWaitMinTime;
        public float LookAtTargetWaitMaxTime;
        public float LookAtMaxYaw;
        public float LookAtMaxPitch;
    }
}
