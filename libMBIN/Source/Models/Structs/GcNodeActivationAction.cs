namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x108)]
    public class GcNodeActivationAction : NMSTemplate
    {
        public int NodeActiveState;
        /* 0x000 */ public string[] NodeActiveStateValues()
        {
            return new[] { "Activate", "Deactivate", "Toggle", "Add", "Remove", "RemoveChildren" };
        }

        [NMS(Size = 0x80)]
        /* 0x004 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string SceneToAdd;
        /* 0x104 */ public bool IncludePhysics;
        /* 0x105 */ public bool NotifyNPC;
        /* 0x106 */ public bool UseMasterModel;
        /* 0x107 */ public bool RestartEmitters;
    }
}
