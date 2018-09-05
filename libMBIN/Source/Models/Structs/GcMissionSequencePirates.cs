namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x81)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        public bool ScanCargo;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
