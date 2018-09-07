namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class TkVertexElement : NMSTemplate
    {
        /* 0x00 */ public int SemanticID;
        /* 0x04 */ public int Size;
        /* 0x08 */ public int Type;
        /* 0x0C */ public int Offset;
        /* 0x10 */ public int Normalise;

		public enum InstancingEnum { PerVertex, PerModel }
		public InstancingEnum Instancing;

        [NMS(Size = 8)]
        /* 0x18 */ public string PlatformData;
    }
}
