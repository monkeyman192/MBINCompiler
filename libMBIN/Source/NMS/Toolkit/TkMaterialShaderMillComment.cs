namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFB4627C4B173185C, NameHash = 0x69D7A72052C55F5E)]
    public class TkMaterialShaderMillComment : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public int PosMaxX;
        [NMS(Index = 4)]
        /* 0x04 */ public int PosMaxY;
        [NMS(Index = 1)]
        /* 0x08 */ public int PosMinX;
        [NMS(Index = 2)]
        /* 0x0C */ public int PosMinY;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x400 Text;
    }
}
