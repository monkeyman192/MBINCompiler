using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkLSystemRestrictionData : NMSTemplate
    {
        public int Amount;
        public int Restriction;
        public string[] RestrictionValues()
        {
            return new[] { "NoMoreThan", "AtLeast", "AtLeastIfICan" };
        }
    }
}
