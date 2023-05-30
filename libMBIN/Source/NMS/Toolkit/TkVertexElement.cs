using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkVertexElement : NMSTemplate
    {
        public int SemanticID;
        public int Size;
        public int Type; // 0x140b(Vec4) or 0x1401(Vec2)
        public int Offset;
        public int Normalise;

        public int Instancing;
        public string[] InstancingValues()
        {
            return new[] { "PerVertex", "PerModel" };
        }

        [NMS(Size = 8)]
        public string PlatformData;
    }
}
