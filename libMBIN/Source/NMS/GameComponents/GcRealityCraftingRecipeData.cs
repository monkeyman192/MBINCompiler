using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRealityCraftingRecipeData : NMSTemplate // 0x58 bytes
    {
        [NMS(Size = 3)]
        public GcRealitySubstanceCraftingMix[] Inputs;

        public NMSString0x10 OutputID;
    }
}
