namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E789F51CF31C9D9, NameHash = 0xBBF7B05E)]
    public class GcBasePartAudioLocation : NMSTemplate
    {
        // size: 0x5
        public enum BasePartAudioLocationEnum : uint {
            None,
            Freighter_SpaceWalk,
            Freighter_BioRoom,
            Freighter_TechRoom,
            Freighter_IndustrialRoom,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BasePartAudioLocationEnum BasePartAudioLocation;
    }
}
