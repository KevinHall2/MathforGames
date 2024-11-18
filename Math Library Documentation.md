# Math Library Documentation
[Vector 2 Class](#vector2class-id)

[Vector 3 Class](#vector3class-id)

[Vector 4 Class](#vector4class-id)

[Matrix 3 Class](#matrix3class-id)

[Matrix 4 Class](#matrix4class-id)

### Vector 2 Class {#vector2class-id}

| Struct Properties  |  Purpose |
|---|---|
|  Public Struct Variables x and y | These store the x and y values of the Vector2 respectively |
|  Public Magnitude Property | This is used to get the magnitude of the Vector2 by calculating the square root of the sum of the squared struct variables `return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));`|
| Public Normalized Property  | This is used to normalize the Vector2 by dividing the vector by its magnitude if the magnitude isn't 0 and is called in the Normalize() function  |

| Functions  |  Purpose |
|---|---|
|  Public Normalize() | This function normalizes the vector, dividing it by its magnitude to give it a length of 1 so that further vector math can be done without bloated numbers.  |
|  Public Override ToString() | Returns the vector as a string for display purposes.  |
| Public DotProduct(Vector2 other) | Returns the dot product of two Vector2s, which is the sum of the products of the vectors' x and y values.  |
| Public Distance(Vector2 other) | Returns the distance between two Vector2s by acquiring the magnitude of the difference of those two Vector2s.  |

| Operator Overloads  |  Purpose |
|---|---|
|Public Static Is Equal To (==) | Has been overloaded to compare the x and y values of two Vector2s with && operators and return True if they are equal or False if they aren't  |
|Public Static Is Not Equal To (!=) | Has been overloaded to compare the x and y values of two Vector2s with ! and == operators and return True if they aren't equal or False if they are |
|  Public Static Addition (Vector2 left, Vector2 right)|  Allows for addition with two Vector2s and returns the sum of their respective variables |
| Public Static Subtraction (Vector2 left, Vector2 right) | Allows for subtraction with two Vector2s and returns the difference of their respective variables  |
|  Public Static Vector Multiplication (Vector2 left, Vector2 right)|  Allows for multiplication with two Vector2s and returns the product of their respective variables |
| Public Static Scalar Multiplication (Vector2 left, float scalar) or (float scalar, Vector2 right) as an overload | Allows for multiplication with a Vector2 by a scalar value  |
|  Public Static Division (Vector2 left, float scalar) |  Allows for division with a Vector2 by a scalar value |
| Public Static Implicit Conversion for System.Numerics `Vector2(System.Numerics.Vector2 vector)` | Makes an implicit conversion from the System.Numerics.Vector2 math library to this Vector2 math library  |
| Public Static Implicit Conversion for MathLibrary.Vector2 `System.Numerics.Vector2(Vector2 vector)` |  Makes an implicit conversion from this Vector2 math library to the System.Numerics.Vector2 math library |


### Vector 3 Class {#vector3class-id}

|  Struct Properties |  Purpose |
|---|---|
| Public Struct Variables x, y, and z | These store the x, y, and z values of the Vector3 respectively  |
| Public Magnitude Property | This is used to get the magnitude of the Vector3 as per the Magnitude property in the [Vector2 class](#vector2class-id)  |
| Public Normalized Property  | This is used to normalize the Vector3 and is called in the Normalize() function as per the Normalized property in the [Vector2 class](#vector2class-id) |

|  Functions |  Purpose |
|---|---|
| Public Normalize() | Normalizes the Vector3 as per the Normalize() function in the [Vector2 class](#vector2class-id)  |
| Public Override ToString() | Returns the vector as a string as per the ToString() function in the [Vector2 class](#vector2class-id)  |
| Public Static DotProduct(Vector3 left, Vector3 right) or Public DotProduct(Vector3 other) as an overload | Returns the dot product of two Vector3s as per the DotProduct(Vector2 other) function in the [Vector2 class](#vector2class-id), but uses the x, y, and z variables instead of just x and y  |
| Public CrossProduct(Vector3 other) or (Vector3 left, Vector3 right) as an overload   |  Returns the cross product of two Vector3s |
```
return new Vector3((this.y * other.z) - (this.z * other.y), (this.z * other.x) - (this.x * other.z), (this.x * other.y) - (this.y * other.x));
```

|  Operator Overloads |  Purpose |
|---|---|
| Public Static Is Equal To (==) | Has been overloaded to compare the x, y, and z values of two Vector3s with && operators and return True if they are equal or False if they aren't  |
| Public Static Not Equal To (!=)  | Has been overloaded to compare the x, y, and z values of two Vector3s with ! and == operators and return True if they aren't equal or False if they are |
| Public Static Addition  |  Allows for addition with two Vector3s and returns the sum of their respective variables |
| Public Static Subtraction  | Allows for subtraction with two Vector3s and returns the difference of their respective variables  |
| Public Static Vector Multiplication (Vector3 left, Vector3 right) | Allows for multiplication with two Vector3s and returns the product of their respective variables  |
| Public Static Scalar Multiplication (Vector3 left, float scalar) or (float scalar, Vector3 right) as an overload  | Allows for multiplication with a Vector3 by a scalar value   |
| Public Static Division (Vector3 left, float scalar)  | Allows for division with a Vector3 by a scalar value  |
| Public Static Implicit Conversion for System.Numerics `Vector3(System.Numerics.Vector3 vector)` | Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector3s instead  |
| Public Static Implicit Conversion for Math.Library.Vector3 `System.Numerics.Vector2(Vector3 vector)` |  Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector3s instead |

### Vector 4 Class {vector4class-id}

|  Struct Properties |  Purpose |
|---|---|
| Public Struct Variables x, y, z, and w | These store the x, y, z, and w values of the Vector4 respectively  |
| Public Magnitude Property | This is used to get the magnitude of the Vector4 as per the Magnitude property in the [Vector2 class](#vector2class-id)  |
| Public Normalized Property  | This is used to normalize the Vector3 and is called in the Normalize() function as per the Normalized property in the [Vector2 class](#vector2class-id)

| Functions  |  Purpose |
|---|---|
| Public Normalize() | Normalizes the Vector4 as per the Normalize() function in the [Vector2 class](#vector2class-id) |
| Public Override ToString() | Returns the vector as a string as per the ToString() function in the [Vector2 class](#vector2class-id) |
| Public Static DotProduct(Vector4 left, Vector4 right) or Public DotProduct(Vector4 other) as an overload |Returns the dot product of two Vector4s as per the DotProduct(Vector2 other) function in the [Vector2 class](#vector2class-id), but uses the x, y, z, and w variables instead |
| Public CrossProduct(Vector4 left, Vector4 right) or (Vector4 other) as an overload | Returns the cross product of two Vector4s `return new Vector4((y * other.z) - (z * other.y), (z * other.x) - (x * other.z), (x * other.y) - (y * other.x), 0);` |

| Operator Overloads  |  Purpose |
|---|---|
| Public Static Is Equal To (==)  | Works the same as it does in the [Vector3 class](#vector3class-id), but compares the x, y, z, and w variables instead  |
| Public Static Not Equal To (!=)  | Works the same as it does in the [Vector3 class](#vector3class-id), but compares the variables of two Vector4s instead  |
| Public Static Addition  | Allows for addition with two Vector4s and returns the sum of their respective variables  |
| Public Static Subtraction | Allows for subtraction with two Vector4s and returns the difference of their respective variables  |
| Public Static Vector Multiplication (Vector4 left, Vector4 right) | Allows for multiplication with two Vector4s and returns the product of their respective variables|
| Public Static Scalar Multiplication (Vector4 left, float scalar) or (float scalar, Vector4 right) as an overload | Allows for multiplication with a Vector4 by a scalar value|
| Public Static Division | Allows for division with a Vector4 by a scalar value|
| Public Static Implicit Conversion for System.Numerics `Vector4(System.Numerics.Vector4 vector)`|Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector4s instead |
| Public Static Implicit Conversion for Math.Library.Vector4 `System.Numerics.Vector2(Vector4 vector)` | Makes an implicit conversion as stated in the [Vector2 class](#vector2class-id), but for Vector4s instead |

### Matrix 3 Class {matrix3class-id}

|  Struct Properties | Purpose  |
|---|---|
| Public Struct Variables m00, m01, m02, m10, m11, m12, m20, m21, m22 | These store the x1(m00), y1(m01), z1(m02), x2(m10), y2(m11), z2(m12), x3(m20), y3(m21), and z3(m22) values of the Matrix3  |
| Public Static Identity Property  | Returns a Matrix3 with the values of 1(m00), 0(m01), 0(m02), 0(m10), 1(m11), 0(m12), 0(m20), 0(m21), and 1(m22) and is called in the Identify function  |
```
return new Matrix3
                    (1, 0, 0, 
                     0, 1, 0, 
                     0, 0, 1);
```

| Functions  | Purpose  |
|---|---|
| Public Identify(Matrix3 other) | Returns the product of two Matrix3s; the first Matrix3 used is an identity matrix provided by the Identity property, and the second Matrix3 used is called as an argument for the function. Example for calling an argument: `rotatedMatrix.Identify(rotatedMatrix);`|
| Public Static CreateTranslation(float x, float y)  | Returns an Identity Matrix3 that has the given x float variable added to the m02 position of the Matrix3, and has the given y float variable added to the m12 position of the Matrix3  |\
```
            return new Matrix3(translationMatrix.m00, translationMatrix.m01, translationMatrix.m02 + x,
                               translationMatrix.m10, translationMatrix.m11, translationMatrix.m12 + y,
                               translationMatrix.m20, translationMatrix.m21, translationMatrix.m22);
```
| | |
|
| Public Static CreateScale(float x, float y) | Returns an Identity Matrix3 that has the m00 position being multiplied by the given x float value, and has the m11 position being multiplied by the given y float value   |
```
            return new Matrix3(scaledMatrix.m00 * x, scaledMatrix.m01, scaledMatrix.m02,
                               scaledMatrix.m10,   scaledMatrix.m11 * y, scaledMatrix.m12,
                               scaledMatrix.m20,     scaledMatrix.m21,  scaledMatrix.m22);
```
| | | 
|
| Public Static CreateRotation(float radians) | Contains three float variables that calculate the Sine, Cosine, and negative Sine of the radians variable provided as an argument of the function. These are then used to return an Identity Matrix3 that has the m00 position replaced with the value given by the Cosine variable, has the m01 position replaced with the value given by the negative Sine variable, has the m10 position replaced with the value given by the Sine variable, and has the m11 position repalced with the value given by the Cosine variable |
```
 return new Matrix3(   cosRotation,         negSinRotation,    rotatedMatrix.m02,
                       sinRotation,            cosRotation,    rotatedMatrix.m12,
                 rotatedMatrix.m20,      rotatedMatrix.m21,    rotatedMatrix.m22);
```
| | |
|
| Public Override ToString() | Returns the Matrix3 as a string for display purposes  |

|  Operator Overloads | Purpose  |
|---|---|
| Public Static Addition  |  Allows for addition with two Matrix3s and returns the sum of their respective variables |
| Public Static Subtraction  |  Allows for subtraction with two Matrix3s and returns the difference of their respective variables |
| Public Static Matrix Multiplication  | Returns the product of two Matrix3s. Acquires the product for each position of the new Matrix3 by multiplying the values in a row by the values in a column, and then adding them together. Example of the m00 position: `(a.m00 * b.m00) + (a.m01 * b.m10) + (a.m02 * b.m20),`  |
| Public Static Vector Multiplication  | Returns the product of a Matrix3 and a Vector3 as a Vector3. Acquires the product for the x, y, and z positions of the Vector3 by multiplying the Vector3 variables by the variables in a column and adding them together. Example of the X position: `(a.m00 * b.x) + (a.m01 * b.y) + (a.m02 * b.z),` |

### Matrix 4 Class {matrix4class-id}

|  Struct Properties | Purpose  |
|---|---|
| Public Struct Variables m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33 | These store the x1(m00), y1(m01), z1(m02), w1(m03), x2(m10), y2(m11), z2(m12), w2(m13), x3(m20), y3(m21), z3(m22), w3(m23), x4(m30), y4(m31), z4(m32), w4(m33) values of the Matrix4  |
| Public Static Identity Property  | Returns a Matrix4 with the values of 1(m00), 0(m01), 0(m02), 0(m03), 0(m10), 1(m11), 0(m12), 0(m13), 0(m20), 0(m21), 1(m22), 0(m23), 0(m30), 0(m31), 0(m32), 1(m33) and is called in the Identity() function  |
```
                return new Matrix4
                    (1, 0, 0, 0,
                     0, 1, 0, 0,
                     0, 0, 1, 0,
                     0, 0, 0, 1);
```
| Functions  | Purpose  |
|---|---|
| Public Identify(Matrix4 other) | Works as the Identify(Matrix3 other) in the [Matrix3 class](#matrix3class-id) but uses Matrix4s instead. Arguments are also called in the same way as they are in the Matrix3 version of this function |
| Public Static CreateTranslation(float x, float y, float z) | Returns an Identity Matrix4 that has the given x float variable added to the m03 position of the Matrix4, has the given y float variable added to the m13 position of the Matrix4, and has the given z float variable added to the m23 position of the Matrix4  |
```
return new Matrix4(translationMatrix.m00, translationMatrix.m01, translationMatrix.m02, translationMatrix.m03 + x,
                   translationMatrix.m10, translationMatrix.m11, translationMatrix.m12, translationMatrix.m13 + y,
                   translationMatrix.m20, translationMatrix.m21, translationMatrix.m22, translationMatrix.m23 + z,
                   translationMatrix.m30, translationMatrix.m31, translationMatrix.m32, translationMatrix.m33);
```

| | |
|
| Public Static CreateScale(float x, float y, float z) | Returns an Identity Matrix4 that has the m00 position being multiplied by the given x float value, has the m11 position being multiplied by the given y float value, and has the m22 position being multiplied by the given z float value  |
```
            return new Matrix4(scaledMatrix.m00 * x, scaledMatrix.m01, scaledMatrix.m02, scaledMatrix.m03,
                               scaledMatrix.m10,  scaledMatrix.m11 * y, scaledMatrix.m12, scaledMatrix.m13,
                               scaledMatrix.m20, scaledMatrix.m21, scaledMatrix.m22 * z, scaledMatrix.m23,
                               scaledMatrix.m30, scaledMatrix.m31, scaledMatrix.m32, scaledMatrix.m33);
```
| | |
| | |
| Public Static CreateRotationX(float radians)  |  This rotates the Matrix4 around the x axis, and contains three float variables that calculate the Sine, Cosine, and negative Sine of the radians variable. These are then used to return a new Identity Matrix4 that has the m11, m12, m21, and m22 positions replaced with the values given by the Sine, Cosine, and negative Sine variables.    |
``` 
            return new Matrix4(rotatedMatrix.m00, rotatedMatrix.m01,    rotatedMatrix.m02, rotatedMatrix.m03,
                               rotatedMatrix.m10,       cosRotation,       negSinRotation, rotatedMatrix.m13,
                               rotatedMatrix.m20,       sinRotation,          cosRotation, rotatedMatrix.m23,
                               rotatedMatrix.m30, rotatedMatrix.m31,    rotatedMatrix.m32, rotatedMatrix.m33);
```
| | |
| | |
| Public Static CreateRotationY(float radians)  | This rotates the Matrix4 around the y axis, and contains three float variables that have the same purpose that they have in the CreateRotationX() function. These variables are then used to return a new Identity Matrix4 that has the m00, m02, m20, and m22 positions replaced with the values given by those variables.  |
```
return new Matrix4(cosRotation,  rotatedMatrix.m01,       sinRotation, rotatedMatrix.m03,
             rotatedMatrix.m10,  rotatedMatrix.m11, rotatedMatrix.m12, rotatedMatrix.m13,
                negSinRotation,  rotatedMatrix.m21,       cosRotation, rotatedMatrix.m23,
             rotatedMatrix.m30,  rotatedMatrix.m31, rotatedMatrix.m32, rotatedMatrix.m33);
```
| | |
|
| Public Static CreateRotationZ(float radians)  | This rotates the Matrix4 around the z axis, and contains three float variables that have the same purpose that they have in the CreateRotationY() and CreateRotationX() functions. These variables are then used to return a new Identity Matrix4 that has the m00, m01, m10, and m11 positions replaced with the values given by those variables. |
```
return new Matrix4( cosRotation,       negSinRotation, rotatedMatrix.m02, rotatedMatrix.m03,
                    sinRotation,          cosRotation, rotatedMatrix.m12, rotatedMatrix.m13,
              rotatedMatrix.m20,    rotatedMatrix.m21, rotatedMatrix.m22, rotatedMatrix.m32,
              rotatedMatrix.m30,    rotatedMatrix.m31, rotatedMatrix.m32, rotatedMatrix.m33);
```
| | |
|
| Public Override ToString() | Returns the Matrix4 as a string for display purposes |

| Operator Overloads| Purpose|
|---|---|
| Public Static Addition| Allows for addition with two Matrix4s and returns the sum of their respective variables|
|Public Static Subtraction | Allows for subtraction with two Matrix4s and returns the difference of their respective variables |
|Public Static Matrix Multiplication | Returns the product of two Matrix4s. Acquires the product for each position of the new Matrix4 by multiplying the values in a row by the values in a column, and then adding them together. Example of the m00 position: `(a.m00 * b.m00) + (a.m01 * b.m10) + (a.m02 * b.m20) + (a.m03 * b.m30)` |
|Public Static Vector Multiplication | Returns the product of a Matrix4 and a Vector4 as a Vector4. Acquires the product for the x, y, z, and w positions of the Vector4 by multiplying the Vector4 variables by the variables in a Matrix4 column and adding them together. Example of the X position: `(a.m00 * b.x) + (a.m01 * b.y) + (a.m02 * b.z) + (a.m03 * b.w),`|