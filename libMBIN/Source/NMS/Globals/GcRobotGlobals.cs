using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    public class GcRobotGlobals : NMSTemplate
    {
        public bool Unknown0;
        public bool Unknown1;
        public float Unknown4;
        public float Unknown8;
        public float UnknownC;

        public Vector4f Unknown10;
        public float Unknown20;
        public bool Unknown24;
        public float Unknown28;
        public float Unknown2C;

        public Vector4f Unknown30;

        public float Unknown40;
        public float Unknown44;
        public int Unknown48;
        public int Unknown4C;

        public int Unknown50;
        public int Unknown54;
        public float Unknown58;
        public float Unknown5C;

        public Vector4f Unknown60;
        public Vector4f Unknown70;
        public Vector4f Unknown80;
        public Vector4f Unknown90;
        public Vector4f UnknownA0;
        public Vector4f UnknownB0;
        public Vector4f UnknownC0;
        public Vector4f UnknownD0;
        public Vector4f UnknownE0;

        public float UnknownF0;
        public float UnknownF4;

        [NMS(Size = 8, Ignore = true)]
        public byte[] PaddingF8;

        public NMSString0x10 Unknown100;

        public float Unknown110;
        public float Unknown114;
        public int Unknown118;
        public float Unknown11C;

        public float Unknown120;
        public float Unknown124;
        public float Unknown128;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding12C;

        public float Unknown130; // maybe int?
        public float Unknown134; // maybe int?
        public float Unknown138;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding13C;

        public Vector4f Unknown140;

        public NMSString0x10 Unknown150;

        public float Unknown160;
        public float Unknown164;
        public float Unknown168;
        public float Unknown16C;

        public float Unknown170;
        public float Unknown174;
        public float Unknown178;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding17C;

        public float Unknown180; // maybe int?
        public float Unknown184; // maybe int?
        public float Unknown188;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding18C;

        public Vector4f Unknown190;
        public GcDroneData Unknown1A0;
    }
}
