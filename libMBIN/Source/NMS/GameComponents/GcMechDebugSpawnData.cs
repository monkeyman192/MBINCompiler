using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA43D68EF9CEF5F8C, NameHash = 0xCA24AFF)]
    public class GcMechDebugSpawnData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f Destination;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f Facing;
        [NMS(Index = 0)]
        /* 0x20 */ public Vector3f Position;
        [NMS(Index = 2)]
        /* 0x30 */ public Vector3f Up;
        [NMS(Index = 8)]
        /* 0x40 */ public GcCharacterCustomisationSaveData CustomisatonData;
        [NMS(Index = 6)]
        /* 0xA8 */ public float MoveDelay;
        [NMS(Index = 5)]
        /* 0xAC */ public float TitanFallDelay;
        [NMS(Index = 4)]
        /* 0xB0 */ public bool Running;
        [NMS(Index = 7)]
        /* 0xB1 */ public bool UseCustomisation;
    }
}
