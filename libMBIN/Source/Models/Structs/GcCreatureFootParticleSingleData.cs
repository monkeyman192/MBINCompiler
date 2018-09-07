namespace libMBIN.Models.Structs
{
    public class GcCreatureFootParticleSingleData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string EffectName;

        public float Scale;
        public float MinCreatureSize;
        public float MaxCreatureSize;
		public enum MoveSpeedEnum { Always, Walk, Run }
		public MoveSpeedEnum MoveSpeed;
    }
}
