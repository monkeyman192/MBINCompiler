using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41AFBAF04BCE6504, NameHash = 0x832159F5794C47D5)]
    public class GcBasePartAudioLocation : NMSTemplate
    {
        // size: 0x5
        public enum BasePartAudioLocationEnum { None, Freighter_SpaceWalk, Freighter_BioRoom, Freighter_TechRoom, Freighter_IndustrialRoom }
        public BasePartAudioLocationEnum BasePartAudioLocation;
    }
}
