namespace SexyCalculator
{
/** <summary> Initializes ciphering Functions for Integers. </summary>

<remarks> This ofuscation is used in some Values from <c>PvZ 2 China</c> </remarks> **/

public static class IntGuard
{
/// <summary> Bits rotation: left </summary>

private const int SHIFT_LEFT = 13;

/// <summary> Bits rotation: right </summary>

private const int SHIFT_RIGHT = 19;

// Rotate bits

private static uint RotateBits(uint v, int left, int right) => (v >> right) | (v << left);

/** <summary> Encrypts an Integer value by Performing some bitwise Operations on it. </summary>

<param name = "v"> The Value to Encrypt. </param>

<returns> The Encrypted Value. </returns> */

public static int Encrypt(uint v)
{
uint x = v ^ SHIFT_LEFT;

return (int)RotateBits(x, SHIFT_LEFT, SHIFT_RIGHT);
}

/** <summary> Decrypts an Integer value by Performing some bitwise Operations on it. </summary>

<param name = "v"> The Value to Decrypt. </param>

<returns> The Decrypted Value. </returns> */

public static int Decrypt(uint v)
{
var x = RotateBits(v, SHIFT_RIGHT, SHIFT_LEFT);

return (int)(x ^ SHIFT_LEFT);
}

}

}
