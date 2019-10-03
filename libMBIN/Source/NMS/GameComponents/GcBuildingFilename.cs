using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x400, GUID = 0x5714540BBB449EE5, NameHash = 0x5E68908664819224)]
    public class GcBuildingFilename : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string LSystem;
        [NMS(Size = 0x80)]
        public string Scene;
        [NMS(Size = 0x80)]
        public string UnderwaterLSystem;
        [NMS(Size = 0x80)]
        public string UnderwaterScene;
        [NMS(Size = 0x80)]
        public string AbandonedLSystem;
        [NMS(Size = 0x80)]
        public string AbandonedScene;
        [NMS(Size = 0x80)]
        public string AbandonedUnderwaterLSystem;
        [NMS(Size = 0x80)]
        public string AbandonedUnderwaterScene;
    }
}
