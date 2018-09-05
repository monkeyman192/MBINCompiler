using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkAnimNodeFrameData : NMSTemplate      // size: 0x30
    {
        public List<short> Rotations;
        public List<Vector4f> Translations;
        public List<Vector4f> Scales;
    }

}
