namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9C78044FF5BDB6D, NameHash = 0x9C2CE097)]
    public class GcByteBeatWave : NMSTemplate
    {
        // size: 0x4
        public enum ByteBeatWaveEnum : uint {
            SawTooth,
            Sine,
            Square,
            Triangle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ByteBeatWaveEnum ByteBeatWave;
    }
}
