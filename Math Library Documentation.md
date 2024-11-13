# Math Library Documentation
[Vector 2 Class](#vector2class-id)

[Vector 3 Class](#vector3class-id)

[Vector 4 Class](#vector4class-id)

[Matrix 3 Class](#matrix3class-id)

[Matrix 4 Class](#matrix4class-id)

### Vector 2 Class {#vector2class-id}

| Struct Properties  |  Purpose |
|---|---|
|  Struct Variables x and y | These store the x and y values of the Vector2 respectively |
|  Magnitude Property | This is used to get the magnitude of the Vector2 by calculating the square root of the sum of the squared struct variables `return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));`|
| Normalized Property  | This is used to normalize the Vector2 by dividing the vector by its magnitude if the magnitude isn't 0 and is called in the Normalize() function  |

| Functions  |  Purpose |
|---|---|
|  Normalize() | This function normalizes the vector, dividing it by its magnitude to give it a length of 1 so that further vector math can be done without bloated numbers.  |
|  ToString() | Returns the vector as a string for display purposes.  |
|  DotProduct(Vector2 other) | Returns the dot product of two Vector2s, which is the sum of the products of the vectors' x and y values.  |
|  Distance(Vector2 other) | Returns the distance between two Vector2s by acquiring the magnitude of the difference of those two Vector2s.  |

| Operator Overloads  |  Purpose |
|---|---|
|  Addition (Vector2 left, Vector2 right)|  Allows for addition with two Vector2s and returns the sum of their respective variables |
| Subtraction (Vector2 left, Vector2 right) | Allows for subtraction with two Vector2s and returns the difference of their respective variables  |
|  Vector Multiplication (Vector2 left, Vector2 right)|  Allows for multiplication with two Vector2s and returns the product of their respective variables |
| Scalar Multiplication (Vector2 left, float scalar) or (float scalar, Vector2 right) as an overload | Allows for multiplication with a Vector2 by a scalar value  |
|  Division (Vector2 left, float scalar) |  Allows for division with a Vector2 by a scalar value |
| Implicit Conversion for System.Numerics `Vector2(System.Numerics.Vector2 vector)` | Makes an implicit conversion from the System.Numerics.Vector2 math library to this Vector2 math library  |
| Implicit Conversion for MathLibrary.Vector2 `System.Numerics.Vector2(Vector2 vector)` |  Makes an implicit conversion from this Vector2 math library to the System.Numerics.Vector2 math library |


### Vector 3 Class {#vector3class-id}

|  Struct Properties |  Purpose |
|---|---|
|  Struct Variables x, y, and z | These store the x, y, and z values of the Vector3 respectively  |
|  Magnitude Property | This is used to get the magnitude of the Vector3 as per the Magnitude property in the [Vector2 class](#vector2class-id)  |
| Normalized Property  | This is used to normalize the Vector3 and is called in the Normalize() function as per the Normalized property in the [Vector2 class](#vector2class-id) |

|  Functions |  Purpose |
|---|---|
|  Normalize() | Normalizes the Vector3 as per the Normalize() function in the [Vector2 class](#vector2class-id)  |
|  ToString() | Returns the vector as a string as per the ToString() function in the [Vector2 class](#vector2class-id)  |
| DotProduct(Vector3 left, Vector3 right) or DotProduct(Vector3 other) as an overload | Returns the dot product of two Vector3s as per the DotProduct(Vector2 other) function in the [Vector2 class](#vector2class-id), but uses the x, y, and z variables instead of just x and y  |
| CrossProduct(Vector3 other) or CrossProduct(Vector3 left, Vector3 right) as an overload   |  Returns the cross product of two Vector3s ```return new Vector3((this.y * other.z) - (this.z * other.y), (this.z * other.x) - (this.x * other.z), (this.x * other.y) - (this.y * other.x));```|

|  Operator Overloads |  Purpose |
|---|---|
|  Is Equal To (==) | Has been overloaded to compare the x, y, and z values of two Vector3s with && operators and return True if they are equal or False if they aren't  |
| Not Equal To (!=)  | Has been overloaded to compare the x, y, and z values of two Vector3s with ! and == operators and return True if they aren't equal or False if they are |
| Addition  |  Allows for addition with two Vector3s and returns the sum of their respective variables |
| Subtraction  | Allows for subtraction with two Vector3s and returns the difference of their respective variables  |
|  Vector Multiplication (Vector3 left, Vector3 right) | Allows for multiplication with two Vector3s and returns the product of their respective variables  |
| Scalar Multiplication (Vector3 left, float scalar) or (float scalar, Vector3 right) as an overload  | Allows for multiplication with a Vector3 by a scalar value   |
| Division (Vector3 left, float scalar)  | Allows for division with a Vector3 by a scalar value  |
| Implicit Conversion for System.Numerics `Vector3(System.Numerics.Vector3 vector)` | Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector3s instead  |
| Implicit Conversion for Math.Library.Vector3 `System.Numerics.Vector2(Vector3 vector)` |  Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector3s instead |

### Vector 4 Class {vector4class-id}

|  Struct Properties |  Purpose |
|---|---|
|  Struct Variables x, y, z, and w | These store the x, y, z, and w values of the Vector4 respectively  |
|  Magnitude Property | This is used to get the magnitude of the Vector4 as per the Magnitude property in the [Vector2 class](#vector2class-id)  |
| Normalized Property  | This is used to normalize the Vector3 and is called in the Normalize() function as per the Normalized property in the [Vector2 class](#vector2class-id)

| Functions  |  Purpose |
|---|---|
| Normalize() | Normalizes the Vector4 as per the Normalize() function in the [Vector2 class](#vector2class-id) |
| ToString() | Returns the vector as a string as per the ToString() function in the [Vector2 class](#vector2class-id) |
| DotProduct(Vector4 left, Vector4 right) or DotProduct(Vector4 other) as an overload |Returns the dot product of two Vector4s as per the DotProduct(Vector2 other) function in the [Vector2 class](#vector2class-id), but uses the x, y, z, and w variables instead |
| CrossProduct(Vector4 left, Vector4 right) or CrossProduct(Vector4 other) as an overload | Returns the cross product of two Vector4s `return new Vector4((y * other.z) - (z * other.y), (z * other.x) - (x * other.z), (x * other.y) - (y * other.x), 0);` |

| Operator Overloads  |  Purpose |
|---|---|
| Is Equal To (==)  | Works the same as it does in the [Vector3 class](#vector3class-id), but compares the x, y, z, and w variables instead  |
| Not Equal To (!=)  | Works the same as it does in the [Vector3 class](#vector3class-id), but compares the variables of two Vector4s instead  |
| Addition  | Allows for addition with two Vector4s and returns the sum of their respective variables  |
|  Subtraction | Allows for subtraction with two Vector4s and returns the difference of their respective variables  |
| Vector Multiplication (Vector4 left, Vector4 right) | Allows for multiplication with two Vector4s and returns the product of their respective variables|
| Scalar Multiplication (Vector4 left, float scalar) or (float scalar, Vector4 right) as an overload | Allows for multiplication with a Vector4 by a scalar value|
| Division | Allows for division with a Vector4 by a scalar value|
| Implicit Conversion for System.Numerics `Vector4(System.Numerics.Vector4 vector)`|Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector4s instead |
| Implicit Conversion for Math.Library.Vector4 `System.Numerics.Vector2(Vector4 vector)` | Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector4s instead |

### Matrix 3 Class {matrix3class-id}