using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78384C0812C1E917, NameHash = 0x6A32C67831551CB7)]
    public class GcBaseBuildingPartInteractionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 InteractionID;
        /* 0x10 */ public Vector3f LocalPos;
        /* 0x20 */ public Vector3f AtDir;
    }
}
