using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xCFE1C74A7BD0885A)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS( EnumType = typeof( GcFrigateClass.FrigateClassEnum ) )]
        public GcPassiveFrigateIncome[] Array;
    }
}
