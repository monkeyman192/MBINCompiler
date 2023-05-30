using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkMaterialData : NMSTemplate
    {
        public NMSString0x80 Name;
        public NMSString0x20 Class;
        public int TransparencyLayerID;
        public bool CastShadow;
        public bool DisableZTest;
        public NMSString0x80 Link;
        public NMSString0x80 Shader;
        public List<TkMaterialFlags> Flags;
        public List<TkMaterialUniform> Uniforms;
        public List<TkMaterialSampler> Samplers;
    }
}
