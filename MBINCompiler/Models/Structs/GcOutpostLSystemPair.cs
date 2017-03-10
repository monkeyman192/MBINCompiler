namespace MBINCompiler.Models.Structs
{
    public class GcOutpostLSystemPair : NMSTemplate // 0x320 bytes
    {
        [NMS(Size = 0x20)]
        public string Locator;
        [NMS(Size = 7)]
        public NMSString0x80[] LSystems;
    }
}
