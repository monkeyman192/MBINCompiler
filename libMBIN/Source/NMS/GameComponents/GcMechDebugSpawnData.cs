using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE311A3F1EFC41615, NameHash = 0xCD20631E8DC06987)]
    public class GcMechDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Destination;
        /* 0x10 */ public Vector3f Facing;
        /* 0x20 */ public Vector3f Position;
        /* 0x30 */ public Vector3f Up;
        /* 0x40 */ public GcCharacterCustomisationSaveData CustomisatonData;
        /* 0x98 */ public float MoveDelay;
        /* 0x9C */ public float TitanFallDelay;
        /* 0xA0 */ public bool Running;
        /* 0xA1 */ public bool UseCustomisation;
    }
}
