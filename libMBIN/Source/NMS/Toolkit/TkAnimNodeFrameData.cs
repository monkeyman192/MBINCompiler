using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAnimNodeFrameData : NMSTemplate
    {
        public List<Vector4f> Rotations;
        public List<Vector4f> Translations; // actually Vector3f
        public List<Vector4f> Scales; // actually Vector3f
    }
}
