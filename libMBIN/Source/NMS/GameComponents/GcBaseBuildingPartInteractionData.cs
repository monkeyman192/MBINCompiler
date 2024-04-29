namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4EA31622EC58DB54, NameHash = 0x6A32C67831551CB7)]
    public class GcBaseBuildingPartInteractionData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f AtDir;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f LocalPos;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 InteractionID;
    }
}
