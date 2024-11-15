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

|  Struct Properties | Purpose  |
|---|---|
|  Struct Variables m00, m01, m02, m10, m11, m12, m20, m21, m22 | These store the x1(m00), y1(m01), z1(m02), x2(m10), y2(m11), z2(m12), x3(m20), y3(m21), and z3(m22) values of the Matrix3  |
| Identity Property  | Returns a Matrix3 with the values of 1(m00), 0(m01), 0(m02), 0(m10), 1(m11), 0(m12), 0(m20), 0(m21), and 1(m22) and is called in the Identify function  |

| Functions  | Purpose  |
|---|---|
| Identify(Matrix3 other) | Returns the product of two Matrix3s; the first Matrix3 used is an identity matrix provided by the Identity property, and the second Matrix3 used is called as an argument for the function. Example for calling an argument: `rotatedMatrix.Identify(rotatedMatrix);`|
| CreateTranslation(float x, float y)  | Returns a new Matrix3 that has been identified as per the Identify(Matrix3 other) function, has the given x float variable added to the m02 position of the Matrix3, and has the given y float variable added to the m12 position of the Matrix3  |
|  CreateScale(float x, float y) | Returns a new Matrix3 that has been identified as per the Identify(Matrix3 other) function, has the m00 position being multiplied by the given x float value, and has the m11 position being multiplied by the given y float value   |
|  CreateRotation(float radians) | Contains three float variables that calculate the Sin, Cosine, and negative Sine of the radian value provided as an argument of the function. These are then used to return a new Matrix3 that has been identified as per the Identity(Matrix3 other) function, has the m00 position replaced with the value given by the Cosine variable, has the m01 position replaced with the value given by the negative Sine variable, has the m10 position replaced with the value given by the Sine variable, and has the m11 position repalced with the value given by the Cosine variable |
|  ToString() | Returns the Matrix3 as a string for display purposes  |

|  Operator Overloads | Purpose  |
|---|---|
| Addition  |  Allows for addition with two Matrix3s and returns the sum of their respective variables |
| Subtraction  |  Allows for subtraction with two Matrix3s and returns the difference of their respective variables |
| Matrix Multiplication  | Returns the product of two Matrix3s. Acquires the product for each position of the Matrix3 by multiplying the values in a row by the values in a column, and then adding them together. Example of the m00 position: `(a.m00 * b.m00) + (a.m01 * b.m10) + (a.m02 * b.m20),`  |
| Vector Multiplication  | Returns the product of a Matrix3 and a Vector3 as a Vector3. Acquires the product for the x, y, and z positions of the Vector3 by multiplying the Vector3 variables by the variables in a column and adding them together. Example of the X position: `(a.m00 * b.x) + (a.m01 * b.y) + (a.m02 * b.z),` |

### Matrix 4 Class {matrix4class-id}

|  Struct Properties | Purpose  |
|---|---|
|  Struct Variables m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33 | These store the x1(m00), y1(m01), z1(m02), w1(m03), x2(m10), y2(m11), z2(m12), w2(m13), x3(m20), y3(m21), z3(m22), w3(m23), x4(m30), y4(m31), z4(m32), w4(m33) values of the Matrix4  |
| Identity Property  | Returns a Matrix4 with the values of 1(m00), 0(m01), 0(m02), 0(m03), 0(m10), 1(m11), 0(m12), 0(m13), 0(m20), 0(m21), 1(m22), 0(m23), 0(m30), 0(m31), 0(m32), 1(m33) and is called in the Identity() function  |

| Functions  | Purpose  |
|---|---|
| Identify(Matrix4 other) | Works as the Identify(Matrix3 other) in the [Matrix3 class](#matrix3class-id) but uses Matrix4s instead. Arguments are also called in the same way as they are in the Matrix3 version of this function |
|  CreateTranslation(float x, float y, float z) | Returns a new Matrix4 that has been identified as per the Identify(Matrix4 other) function, has the given x float variable added to the m03 position of the Matrix4, has the given y float variable added to the m13 position of the Matrix4, and has the given z float variable added to the m23 position of the Matrix4  |
|  CreateScale(float x, float y, float z) | Returns a new Matrix4 that has been identified as per the Identify(Matrix4 other) function, has the m00 position being multiplied by the given x float value, has the m11 position being multiplied by the given y float value, and has the m22 position being multiplied by the given z float value  |
| CreateRotationX(float radians)  |   |
|   |   |