namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1E084E1510B4A072, NameHash = 0x8687A0CA8457FC32)]
    public class TkVertexElement : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public long PlatformData;
        // size: 0x2
        public enum InstancingEnum : uint {
            PerVertex,
            PerModel,
        }
        [NMS(Index = 5)]
        /* 0x08 */ public InstancingEnum Instancing;
        [NMS(Index = 4)]
        /* 0x0C */ public int Normalise;
        [NMS(Index = 3)]
        /* 0x10 */ public int Offset;
        [NMS(Index = 0)]
        /* 0x14 */ public int SemanticID;
        [NMS(Index = 1)]
        /* 0x18 */ public int Size;
        [NMS(Index = 2)]
        /* 0x1C */ public int Type;
    }
}
