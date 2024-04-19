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
        /* 0x000 */ public NodeActiveStateEnum NodeActiveState;
        /* 0x004 */ public NMSString0x80 Name;
        /* 0x084 */ public NMSString0x80 SceneToAdd;
        /* 0x104 */ public bool AffectModels;
        /* 0x105 */ public bool IncludeChildPhysics;
        /* 0x106 */ public bool IncludePhysics;
        /* 0x107 */ public bool NotifyNPC;
        /* 0x108 */ public bool RestartEmitters;
        /* 0x109 */ public bool UseLocalNode;
        /* 0x10A */ public bool UseMasterModel;
    }
}
