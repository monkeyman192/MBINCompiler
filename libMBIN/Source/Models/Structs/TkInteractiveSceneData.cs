using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class TkInteractiveSceneData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Id;
        public List<TkInteractiveControlData> Controls;
    }
}
