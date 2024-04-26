namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x901A4F810577784F, NameHash = 0xB2C5F1A083F1473A)]
    public class GcNodeActivationAction : NMSTemplate
    {
        // size: 0x6
        public enum NodeActiveStateEnum : uint {
            Activate,
            Deactivate,
            Toggle,
            Add,
            Remove,
            RemoveChildren,
        }
        [NMS(Index = 0)]
        /* 0x000 */ public NodeActiveStateEnum NodeActiveState;
        [NMS(Index = 1)]
        /* 0x004 */ public NMSString0x80 Name;
        [NMS(Index = 2)]
        /* 0x084 */ public NMSString0x80 SceneToAdd;
        [NMS(Index = 9)]
        /* 0x104 */ public bool AffectModels;
        [NMS(Index = 4)]
        /* 0x105 */ public bool IncludeChildPhysics;
        [NMS(Index = 3)]
        /* 0x106 */ public bool IncludePhysics;
        [NMS(Index = 5)]
        /* 0x107 */ public bool NotifyNPC;
        [NMS(Index = 8)]
        /* 0x108 */ public bool RestartEmitters;
        [NMS(Index = 7)]
        /* 0x109 */ public bool UseLocalNode;
        [NMS(Index = 6)]
        /* 0x10A */ public bool UseMasterModel;
    }
}
