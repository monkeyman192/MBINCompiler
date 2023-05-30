using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcInteractionComponentData : NMSTemplate
    {
        /* 0x000 */ public int InteractionAction;
        public string[] InteractionActionValues()
        {
            return new[] { "PressButton", "HoldButton", "Shoot" };
        }

        /* 0x004 */ public GcInteractionType InteractionType;
        [NMS(Size = 8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public TkModelRendererData Renderer;
        /* 0x080 */ public GcAlienRace Race;
        /* 0x084 */ public float AttractDistanceSq;
        /* 0x088 */ public bool RepeatInteraction;
        /* 0x089 */ public bool UseInteractCamera;

        /* 0x08C */ public float BlendToCameraTime;
        /* 0x090 */ public float BlendFromCameraTime;
        /* 0x098 */ public GcInteractionActivationCost ActivationCost;

        [NMS(Size = 0x10)]
        /* 0x0C0 */ public string TriggerAction;

        /* 0x0D0 */ public bool BroadcastTriggerAction;
        /* 0x0D4 */ public float InteractAngle;
        /* 0x0D8 */ public float InteractDistance;
        /* 0x0DC */ public bool InteractInvertFace;
        /* 0x0E0 */ public GcInteractionType SecondaryInteractionType;
        /* 0x0E8 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x110 */ public List<TkModelRendererData> EventRenderers;

        /* 0x120 */ public float SecondaryCameraTransitionTime;
        /* 0x124 */ public bool DoInteractionsInOrder;

        [NMS(Size = 0xB, Ignore = true)]
        /* 0x125 */ public byte[] Padding125;
    }
}
