namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7EE03D9B8B7FC4A9, NameHash = 0x6D3C29390F888BFC)]
    public class TkAnim2dBlendNodeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSTemplate BlendChild;
        [NMS(Index = 0)]
        /* 0x50 */ public Vector2f Position;
    }
}
