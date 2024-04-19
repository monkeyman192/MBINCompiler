using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5AC84CD0356FFBAD, NameHash = 0x8E91F497B8C8D2F3)]
    public class TkBlackboardDefaultValueVector : NMSTemplate
    {
        /* 0x00 */ public Vector3f DefaultValue;
        /* 0x10 */ public NMSString0x10 BlackboardKey;
        /* 0x20 */ public TkBlackboardCategory BlackboardCategory;
    }
}
