namespace libMBIN.NMS
{
    public interface IHashMap {
        object GetElements();

        uint Count { get; }
        int EndPaddingLShift { get; }
    }
}
