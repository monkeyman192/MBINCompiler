using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21455514304418C2, NameHash = 0x4837448F)]
    public class GcBuildingClusterLayoutEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcBuildingClassification Building;
        [NMS(Index = 3)]
        /* 0x04 */ public int Max;
        [NMS(Index = 2)]
        /* 0x08 */ public int Min;
        [NMS(Index = 1)]
        /* 0x0C */ public float Probability;
        [NMS(Index = 4)]
        /* 0x10 */ public bool FacesCentre;
    }
}
