using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x400, GUID = 0x5714540BBB449EE5, NameHash = 0x5E68908664819224)]
    public class GcBuildingFilename : NMSTemplate
    {
        public NMSString0x80 LSystem;
        public NMSString0x80 Scene;
        public NMSString0x80 UnderwaterLSystem;
        public NMSString0x80 UnderwaterScene;
        public NMSString0x80 AbandonedLSystem;
        public NMSString0x80 AbandonedScene;
        public NMSString0x80 AbandonedUnderwaterLSystem;
        public NMSString0x80 AbandonedUnderwaterScene;
    }
}
