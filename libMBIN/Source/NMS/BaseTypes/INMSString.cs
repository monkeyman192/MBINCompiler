using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    public interface INMSString
	: System.IComparable<INMSString>
	, System.IEquatable <INMSString>
	{
		string StringValue();
	}
}
