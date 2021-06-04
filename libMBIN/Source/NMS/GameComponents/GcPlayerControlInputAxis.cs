using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0xBF40484C12B59807, NameHash = 0x52A4BE1415A68ECA)]
    public class GcPlayerControlInputAxis : NMSTemplate
    {
        /* 0x00 */ public GcInputActions InputX;
        /* 0x04 */ public GcInputActions InputY;
        public enum InputRelativeToEnum { CameraRelative, CameraRelativeTopDown, Raw };
        /* 0x08 */ public InputRelativeToEnum InputRelativeTo;
        /* 0x10 */ public NMSString0x10 Output;
        /* 0x20 */ public NMSString0x10 OutputLength;
    }
}
