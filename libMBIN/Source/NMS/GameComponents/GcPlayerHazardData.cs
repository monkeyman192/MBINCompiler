using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMSDescription("A class to define various environmental hazard damage and effects on the player.<br/>" +
                    "For more details see [here](https://wiki.step-project.com/NMS:Reference_Guides/HazardTable)")]
	[NMS(Size = 0x58, GUID = 0xBBCFC24EB018B5F3, NameHash = 0x18642126695741B5)]
    public class GcPlayerHazardData : NMSTemplate
    {
        [NMSDescription("Time in seconds before starting depleting protection charge")]
        public float ProtectionInitialTime;
        [NMSDescription("*x component*: Time in seconds to deplete an amount of 100 protection charges below TriggerValue<br/>" +
                        "*y component*: Time in seconds to deplete an amount of 100 protection charges over CapValue")]
        public Vector2f ProtectionTime;
        public Vector2f DamageRate;
        public Vector2f WoundRate;
        [NMSDescription("Time in seconds before starting replenishing protection charge")]
        public float RechargeInitialTime;
        [NMSDescription("Time in seconds to replenish 100 protection charges")]
        public float RechargeTime;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
        [NMSDescription("Type of damages if protection falls to 0")]
        public NMSString0x10 Damage;
        public bool Increases;
        public TkCurveType Curve;
        [NMSDescription("Under this value, depletion rate is described by *ProtectionTime.x*")]
        public float TriggerValue;
        [NMSDescription("Over this value, depletion rate is described by *ProtectionTime.y*")]
        public float CapValue;
        [NMSDescription("Notification trigger")]
        public float CriticalValue;
        public float OutputMultiplier;
        public float OutputMinAddition;
        public float OutputMaxAddition;
    }
}