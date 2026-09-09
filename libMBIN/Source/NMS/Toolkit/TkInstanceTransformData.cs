namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x50C20A1735AEE7B3, NameHash = 0x34020672)]
    public class TkInstanceTransformData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10)]
        /* 0x0 */ public float[] Matrix;
    }
}
