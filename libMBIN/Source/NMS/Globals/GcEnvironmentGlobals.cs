using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    public class GcEnvironmentGlobals : NMSTemplate
    {
        // Vector4f fields below might be Colour fields instead

        public Vector4f Unknown0;

        public bool Unknown10;
        public bool Unknown11;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;

        public Vector4f Unknown20;
        public Vector4f Unknown30;
        public Vector4f Unknown40;
        public Vector4f Unknown50;

        public bool Unknown60;
        public float Unknown64;
        public int Unknown68;
        public float Unknown6C;

        public Vector4f Unknown70;
        public Vector4f Unknown80;
        public Vector4f Unknown90;
        public Vector4f UnknownA0;
        public Vector4f UnknownB0;
        public Vector4f UnknownC0;
        public Vector4f UnknownD0;
        public Vector4f UnknownE0;
        public Vector4f UnknownF0;
        public Vector4f Unknown100;
        public Vector4f Unknown110;
        public Vector4f Unknown120;
        public Vector4f Unknown130;
        public Vector4f Unknown140;
        public Vector4f Unknown150;
        public Vector4f Unknown160;
        public Vector4f Unknown170;
        public Vector4f Unknown180;
        public Vector4f Unknown190;

        public bool Unknown1A0;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding1A1;

        [NMS(Size = 3)]
        public TkShearWindData[] Unknown1A8;
    }
}
