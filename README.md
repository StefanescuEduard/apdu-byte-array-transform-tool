# APDU to C# byte array transformation tool
A simple transformation tool for converting an APDU command to a C# byte array.

## Example
**Input**: 80 20 07 00 08 41 43 4F 53 54 45 53 54

**Output**:
```CSharp
var apdu = new byte[]
{
	0x80,
	0x20,
	0x07,
	0x00,
	0x08,
	0x41,
	0x43,
	0x4F,
	0x53,
	0x54,
	0x45,
	0x53,
	0x54
};
```
