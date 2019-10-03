using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xAE882B312D5F93D5, NameHash = 0x380D960FAA1BF837)]
    public class TkDynamicChainComponentData : NMSTemplate      // possibly in a global...
    {
        public float AngularLimit;
        public float TwistLimit;
        public float MotorStrengthCone;
        public float MotorStrengthTwist;
        public float MaxMotorForce;
        public float Gravity;
        public float AirThickness;
        public float VertAirThickness;
        public float WindStrength;
        public float LinearDamping;
        public float AngularDamping;
        public float InitialBodyMass;
        public float BodyMassChange;
        public bool WeightByJointLength;

        public List<NMSString0x20> IgnoreJoints;
    }
}
