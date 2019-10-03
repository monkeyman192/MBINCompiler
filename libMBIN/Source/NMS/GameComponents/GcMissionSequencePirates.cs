using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, GUID = 0x75AF77832304823D, NameHash = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        public bool ScanCargo;
        public int NumSquads;
        [NMS(Size = 0x10)]
        public string AttackDefinition;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
