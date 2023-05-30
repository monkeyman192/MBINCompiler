using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    public class GcSceneOptions : NMSTemplate // doesn't seem like any of this is used by the game..
    {
        public int Unknown0; // 2
        public int Unknown4; // 1
        public bool Unknown8; // 0

        public NMSString0x80 Unknown9; // METADATA/SIMULATION/SOLARSYSTEM/BIOMES/SUPERBIOME/SUPERBIOME.MXML
        public bool Unknown89; // 0

        public NMSString0x80 Unknown8A; // METADATA/SIMULATION/SOLARSYSTEM/BIOMES/DESERTBIOME.MXML
        public bool Unknown10A; // 0

        public NMSString0x80 Unknown10B; // null
        public bool Unknown18B; // 0

        public NMSString0x80 Unknown18C; // null
        public bool Unknown20C; // 0

        public NMSString0x80 Unknown20D; // null
        public bool Unknown28D; // 0

        public float Unknown290; // -11188.0
        public float Unknown294; // 3950.0
        public float Unknown298; // 9578.0
        public float Unknown29C; // 0.0
        public float Unknown2A0; // 10.0

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding2A4;
    }
}
