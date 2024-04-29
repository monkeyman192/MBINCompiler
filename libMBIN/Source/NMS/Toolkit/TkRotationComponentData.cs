namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBD415EE67B7C2C5D, NameHash = 0xB808E542DB69E5FE)]
    public class TkRotationComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Axis;
        [NMS(Index = 0)]
        /* 0x10 */ public float Speed;
        [NMS(Index = 3)]
        /* 0x14 */ public int SyncGroup;
        [NMS(Index = 2)]
        /* 0x18 */ public bool AlwaysUpdate;
    }
}
