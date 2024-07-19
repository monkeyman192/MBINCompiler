namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5065A14F755E52F4, NameHash = 0xA7F341E9)]
    public class TkAnim2dBlendNodeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public Vector2f Position;
        [NMS(Index = 1)]
        /* 0x8 */ public NMSTemplate BlendChild;
    }
}
