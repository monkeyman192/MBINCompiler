using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x1FA54D54FA89D565, NameHash = 0x90485A00D3954CE2)]
    public class GcAtmosphereEntryComponentData : NMSTemplate
    {
        public bool AutoEntry;
        public float EntryTime;
        public float EntryOffset;
        public float EditTerrainRadius;
        public NMSString0x10 ImpactEffect;
        public NMSString0x10 FlareEffect;
    }
}
