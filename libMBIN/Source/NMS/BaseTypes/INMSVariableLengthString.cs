using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    public interface INMSVariableLengthString: INMSString
    {
        string StringValue();
        string String { get; set; }
    }
}
