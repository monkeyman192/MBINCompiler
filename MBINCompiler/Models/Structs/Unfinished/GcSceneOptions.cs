namespace MBINCompiler.Models.Structs.Unfinished
{
    public class GcSceneOptions : NMSTemplate // doesn't seem like any of this is used by the game..
    {
        public int Unknown0; // 2
        public int Unknown4; // 1
        public bool Unknown8; // 0

        [NMS(Size = 0x80)]
        public string Unknown9; // METADATA/SIMULATION/SOLARSYSTEM/BIOMES/SUPERBIOME/SUPERBIOME.MXML
        public bool Unknown89; // 0

        [NMS(Size = 0x80)]
        public string Unknown8A; // METADATA/SIMULATION/SOLARSYSTEM/BIOMES/DESERTBIOME.MXML
        public bool Unknown10A; // 0

        [NMS(Size = 0x80)]
        public string Unknown10B; // null
        public bool Unknown18B; // 0

        [NMS(Size = 0x80)]
        public string Unknown18C; // null
        public bool Unknown20C; // 0

        [NMS(Size = 0x80)]
        public string Unknown20D; // null
        public bool Unknown28D; // 0

        public float Unknown290; // -11188.0
        public float Unknown294; // 3950.0
        public float Unknown298; // 9578.0
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding29C;       // was a float, but this doesn't appear in the exe...
        public float Unknown2A0; // 10.0

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding2A4;
    }
}
