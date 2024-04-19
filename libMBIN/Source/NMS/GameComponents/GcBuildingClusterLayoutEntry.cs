using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9768061264DDEEE2, NameHash = 0x3C79A95C7D8D0B89)]
    public class GcBuildingClusterLayoutEntry : NMSTemplate
    {
        /* 0x00 */ public GcBuildingClassification Building;
        /* 0x04 */ public int Max;
        /* 0x08 */ public int Min;
        /* 0x0C */ public float Probability;
        /* 0x10 */ public bool FacesCentre;
    }
}
