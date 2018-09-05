namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x400)]
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
