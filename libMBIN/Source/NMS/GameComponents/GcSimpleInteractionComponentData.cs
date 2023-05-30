using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        public int SimpleInteractionType;
        public string[] SimpleInteractionTypeValues()
        {
            return new[] { "Interact", "Treasure", "Beacon", "Scan", "Save", "CallShip", "Word", "Tech", "GenericReward", "Feed" };
        }

        public float InteractDistance;
        public NMSString0x10 Id;

        public GcRarity Rarity;
        public GcSizeIndicator SizeIndicator;
        public NMSString0x10 TriggerAction;
        public bool BroadcastTriggerAction;
        public float Delay;

        public bool InteractIsCrime;
        public int InteractCrimeLevel;
        public GcInteractionActivationCost ActivationCost;

        public NMSString0x20 Name;
    }
}
