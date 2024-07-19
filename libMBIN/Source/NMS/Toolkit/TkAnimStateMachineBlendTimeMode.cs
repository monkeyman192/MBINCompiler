namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6185D91A98076E0D, NameHash = 0x19E3FECA)]
    public class TkAnimStateMachineBlendTimeMode : NMSTemplate
    {
        // size: 0x2
        public enum TimeModeEnum : uint {
            Normalised,
            Seconds,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TimeModeEnum TimeMode;
    }
}
