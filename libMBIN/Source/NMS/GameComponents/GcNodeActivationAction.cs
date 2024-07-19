namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9233A0DB879EF40A, NameHash = 0xA239840C)]
    public class GcNodeActivationAction : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString SceneToAdd;
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
        /* 0x10 */ public NodeActiveStateEnum NodeActiveState;
        [NMS(Index = 1)]
        /* 0x14 */ public NMSString0x80 Name;
        [NMS(Index = 9)]
        /* 0x94 */ public bool AffectModels;
        [NMS(Index = 4)]
        /* 0x95 */ public bool IncludeChildPhysics;
        [NMS(Index = 3)]
        /* 0x96 */ public bool IncludePhysics;
        [NMS(Index = 5)]
        /* 0x97 */ public bool NotifyNPC;
        [NMS(Index = 8)]
        /* 0x98 */ public bool RestartEmitters;
        [NMS(Index = 7)]
        /* 0x99 */ public bool UseLocalNode;
        [NMS(Index = 6)]
        /* 0x9A */ public bool UseMasterModel;
    }
}
