using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSavedInteractionRaceData : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 6)]
        public float[] SavedRaceIndicies; // unsure if this is float[] or not, code for this template is very strange
    }
}
