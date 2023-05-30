using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcLegality : NMSTemplate
    {
        public int Legality;

        public string[] LegalityValues()
        {
            return new[] { "Legal", "Illegal", "None" };
        }
    }
}
