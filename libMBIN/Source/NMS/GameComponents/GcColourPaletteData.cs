namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99579791A89F2068, NameHash = 0x5206D5AE)]
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5)]
        /* 0x00 */ public Colour[] Colours;
        [NMS(Index = 1, Size = 0x5)]
        /* 0x50 */ public int[] ColourIndices;
    }
}
