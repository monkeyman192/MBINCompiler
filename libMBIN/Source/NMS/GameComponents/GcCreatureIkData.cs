using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0x3BA65C213C24E3DE, NameHash = 0x3B356CAA76CA79F8)]
    public class GcCreatureIkData : NMSTemplate
    {
        public GcCreatureIkType CreatureIkType;
        public NMSString0x100 JointName;
    }
}