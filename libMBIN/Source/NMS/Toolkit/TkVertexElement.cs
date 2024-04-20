namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1E084E1510B4A072, NameHash = 0x8687A0CA8457FC32)]
    public class TkVertexElement : NMSTemplate
    {
        /* 0x00 */ public int SemanticID;
        /* 0x04 */ public int Size;
        /* 0x08 */ public int Type;
        /* 0x0C */ public int Offset;
        /* 0x10 */ public int Normalise;
        // size: 0x2
        public enum InstancingEnum : uint {
            PerVertex,
            PerModel,
        }
        /* 0x14 */ public InstancingEnum Instancing;
        /* 0x18 */ public long PlatformData;
    }
}
