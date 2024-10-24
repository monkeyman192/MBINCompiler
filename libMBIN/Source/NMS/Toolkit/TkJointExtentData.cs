namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBAE3710A56D0DDF2, NameHash = 0xDF60B5BF)]
    public class TkJointExtentData : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x3)]
        /* 0x00 */ public float[] JointExtentCenter;
        [NMS(Index = 1, Size = 0x3)]
        /* 0x0C */ public float[] JointExtentMax;
        [NMS(Index = 0, Size = 0x3)]
        /* 0x18 */ public float[] JointExtentMin;
        [NMS(Index = 3, Size = 0x3)]
        /* 0x24 */ public float[] JointExtentStdDev;
    }
}
