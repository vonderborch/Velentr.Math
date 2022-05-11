# Velentr.Math
A variety of helpful math-related helper methods and objects.

# Installation
A nuget package is available: [Velentr.Math](https://www.nuget.org/packages/Velentr.Math/)

# MathHelpers
Method | Description | Min Supported Version | Example Usage
--------- | ---------- | ----------- | ----------------------------- | -------------
Clamp | Clamps a number between a range. | 1.0.0 | `_ = MathHelpers.Clamp(11, 0, 10); // Returns 10`, `_ = MathHelpers.Clamp(-1, 0, 10); // Returns 0`, `_ = MathHelpers.Clamp(5, 0, 10); // Returns 5`

# ByteConversion
Namespace | Object/Class/File | Description | Min Supported Version | Example Usage
--------- | ---------- | ----------- | ----------------------------- | -------------
ByteConversion | SizeUnits | The available conversion size units | 1.1.0 | `var unit = SizeUnits.MB`
ByteConversion | ConvertToSize | Adds an extension to allow converting a long to a double of the appropriate unit, with an optional parameter allowing choosing between 1024 and 1000 for the base unit. | 1.1.0 | `var amount = ((long)2048).ToSizeUnit(SizeUnits.MB) // outputs 2`


# Fixed Point Mathematics
These structs enable usage of fixed-point mathematics, which may be preferable if floating point types do not provide enough precision for a particular use-case.

Currently, there are two different implementations of fixed-point math structs: FPL4, which is precise to four decimals, and FPL6, which is precise to six decimals.

Namespace | Object/Class/File | Description | Min Supported Version | Example Usage
--------- | ---------- | ----------- | ----------------------------- | -------------
FixedPointMath.Precision4 | FPL4 | A fixed-point math struct with precision to four decimal places. | 1.0.0 | `FPL4 num = 3.051;`
FixedPointMath.Precision4 | FPL4Math | A variety of math methods for use with FPL4 objects. | 1.0.0 | `var result = FPL4Math(3.051, 2);`
FixedPointMath.Precision4 | FPL4Vector2 | A variety of math methods for use with FPL4 objects. | 1.0.0 | `var vec2 = new FPL4Vector2(3.051, 4.128);`
FixedPointMath.Precision4 | FPL4Vector3 | A variety of math methods for use with FPL4 objects. | 1.0.0 | `var vec3 = new FPL4Vector2(3.051, 4.128, -1.24);`
FixedPointMath.Precision6 | FPL6 | A fixed-point math struct with precision to six decimal places. | 1.0.0 | `FPL6 num = 3.051;`
FixedPointMath.Precision6 | FPL6Math | A variety of math methods for use with FPL6 objects. | 1.0.0 | `var result = FPL6Math(3.051, 2);`
FixedPointMath.Precision6 | FPL6Vector2 | A variety of math methods for use with FPL6 objects. | 1.0.0 | `var vec2 = new FPL6Vector2(3.051, 4.128);`
FixedPointMath.Precision6 | FPL6Vector3 | A variety of math methods for use with FPL6 objects. | 1.0.0 | `var vec3 = new FPL6Vector2(3.051, 4.128, -1.24);`

# Random Generators
A variety (and growing) number of random generators are available.

All RNGs use the same abstract class and have largely the same methods available.

Example usage with the `SimpleRng` generator:
```
var rng = new SimpleRng();

var a = rng.GetUint(); // gets a random uint
var b = rng.GetDouble(0, 12.5); // gets a random double between 0 and 12.5
```

Namespace | Object/Class/File | Description | Min Supported Version | Example Usage
--------- | ---------- | ----------- | ----------------------------- | -------------
Random | AbstractRandomGenerator | A base random number generator that contains many helpful methods used during random generation. | 1.0.0 | N/A (Abstract class)
Random | SimpleRng | A simple RNG based on MWC, originally written by John D. Cook. | 1.0.0 | `var rng = new SimpleRng();`
Random | MT19937 | An implementation of a Mersenne Twister generator, originally written by Takuji Nishimura and Makoto Matsumoto and originally converted to C# by Dave Loeser. | 1.0.0 | `var rng = new MT19937();`


# Future Plans
See list of issues under the Milestones: https://github.com/vonderborch/Velentr.Math/milestones

Most additions to this library will be ad-hoc as I discover needs.
