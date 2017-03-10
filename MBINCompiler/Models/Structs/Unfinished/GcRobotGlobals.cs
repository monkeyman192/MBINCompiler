namespace MBINCompiler.Models.Structs.Unfinished
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

        /* 0x100 */ public GcRobotLaserBeamData WalkerLaserData;
        /* 0x150 */ public GcRobotLaserBeamData QuadLaserData;
        /* 0x1A0 */ public GcDroneData DroneData;
    }
}
