using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcScanEventData : NMSTemplate // 0xD0 bytes
    {
        public NMSString0x10 Name;
        public NMSString0x10 NextOption;

        public int TriggerEventStartType;
        public string[] TriggerEventStartTypeValues()
        {
            return new[] { "None", "Special", "Discovered", "Timer", "ObjectScan", "LeaveBuilding" };
        }

        public int TriggerEventEndType;
        public string[] TriggerEventEndTypeValues()
        {
            return new[] { "None", "Proximity", "Interact", "EnterBuilding" };
        }

        public int TriggerEventPriority;
        public string[] TriggerEventPriorityValues()
        {
            return new[] { "Regular", "High" };
        }

        public float MessagesStartTime;
        public float MessagesMessageTime;
        public float MessagesMessageDisplayTime;
        public GcAudioWwiseEvents MessagesAkEvent;
        public float MessagesIconTime;
        public float MessagesTooltipTime;
        public bool MessagesTooltipRepeats;
        public bool MessagesShowEndTooltip;
        public NMSString0x20 MessagesOSDMessage;
        public NMSString0x20 MessagesTooltipMessage;
        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding86;

        public int TargetBuildingLocation;
        public string[] TargetBuildingLocationValues()
        {
            return new[] { "Nearest", "Random", "RandomOnNearPlanet", "RandomOnFarPlanet" };
        }
        public int TargetBuildingType;
        public string[] TargetBuildingTypeValues()
        {
            return new[] { "Any", "AnyShelter", "BuildingClass", "Specific", "SpaceStation", "SpaceAnomaly", "Freighter", "SpaceStation"};
        }

        public GcBuildingClassification TargetBuildingClassification;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding94;

        public Vector4f TargetSpecificBuildingLoc;
        public NMSString0x10 TargetForceInteraction;
        public GcInteractionType TargetInterationType;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] PaddingC4;
    }
}
