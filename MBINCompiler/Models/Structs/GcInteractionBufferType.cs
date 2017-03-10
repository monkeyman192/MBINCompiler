namespace MBINCompiler.Models.Structs
{
    public class GcInteractionBufferType : NMSTemplate // 0x7D10 bytes
    {
        public int InterationBufferType;
        public string[] InterationBufferTypeValues()
        {
            return new[] { "DistressSignal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature"};
        }
    }
}
