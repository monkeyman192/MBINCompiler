using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xDE2E43A676CF479D, NameHash = 0x1F15CCCBBBCEC86A)]
    public class GcCreatureMovementData : NMSTemplate
    {
        public List<GcCreatureMoveAnimData> Anims;

        public float MoveRange;
        public float MoveSpeedScale;
        public float HeightMin;
        public float HeightMax;
        public float HeightTime;
        public bool Herd;

        [NMS(Size = 3, Ignore = true)]
        public byte[] EndPadding;
    }
}
