using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcPlayerHazardData[] Table;
    }
}
