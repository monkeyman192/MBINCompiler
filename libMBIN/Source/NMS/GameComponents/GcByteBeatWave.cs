using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61E4EF20CE38F6A1, NameHash = 0x9860FF852C2CBCD3)]
    public class GcByteBeatWave : NMSTemplate
    {
        public enum ByteBeatWaveEnum { Sawtooth, Sine, Square, Triangle }
        public ByteBeatWaveEnum ByteBeatWave;
    }
}
