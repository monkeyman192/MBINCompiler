using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xCFF95D1DE4A528CD, NameHash = 0xC5B9CCD1978B8755)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string SelectedPreset;
        /* 0x10 */ public GcCharacterCustomisationData CustomData;
    }
}
