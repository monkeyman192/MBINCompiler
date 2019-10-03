using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8F21833376B03851, NameHash = 0x5CEC8CD158852BFE)]
    public class GcRealityCraftingRecipeData : NMSTemplate // 0x58 bytes
    {
        [NMS(Size = 3)]
        public GcRealitySubstanceCraftingMix[] Inputs;

        [NMS(Size = 0x10)]
        public string OutputID;
    }
}
