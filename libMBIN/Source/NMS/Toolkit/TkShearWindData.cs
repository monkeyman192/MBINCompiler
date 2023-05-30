using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkShearWindData : NMSTemplate
    {
        public NMSString0x10 Name;
        public float OverallWindStrength;
        public float LdsWindStrength;
        public float LdsWindSpeed;
        public float ShearWindSpeed;
        public float WindShearVertpushStrength;
        public float WindShearGradientStrength;
        public float WindShearToDotLdsFactor;
        public TkShearWindOctaveData Octave0;
        public TkShearWindOctaveData Octave1;
        public TkShearWindOctaveData Octave2;
        public TkShearWindOctaveData Octave3;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding7C;
    }
}
