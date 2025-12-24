namespace SexyCalculator
{
/// <summary> Initializes calculating Functions between VarInt and Integer Values. </summary>

public static class VarInt
{
/** <summary> Calculates a VarInt from a given Integer Value. </summary>

<param name = "v"> The Integer where the VarInt will be Calculated from. </param>

<returns> The Varint Value Calculated. </returns> */

public static int ConvertTo(int v)
{
using NativeBuffer buffer = new(5);
buffer.SetVarInt(0, v, out _);

return buffer.GetInt32(0);
}

/** <summary> Calculates an Integer from a given VarInt Value. </summary>

<param name = "v"> The VarInt where the Integer will be Calculated from. </param>

<returns> The Integer Calculated. </returns> */

public static int ConvertFrom(int v)
{
using NativeBuffer buffer = new(5);
buffer.SetInt32(0, v);

return buffer.GetVarInt(0, out _);
}

}

}