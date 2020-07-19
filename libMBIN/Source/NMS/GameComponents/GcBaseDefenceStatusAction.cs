using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xD0F90CAA3213CC4C, NameHash = 0x22FF5652DE949103)]
    public class GcBaseDefenceStatusAction : NMSTemplate
    {
        /* 0x0 */ public GcBaseDefenceStatusType TryState;
    }
}
