using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3BA65C213C24E3DE, NameHash = 0x3B356CAA76CA79F8)]
    public class GcCreatureIkData : NMSTemplate
    {
        public GcCreatureIkType CreatureIkType;
        [NMS(Size = 0x100)]
        public string JointName;
    }
}
