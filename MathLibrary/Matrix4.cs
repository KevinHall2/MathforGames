using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Matrix4
    {
        public float
            m00, m01, m02, m03,
            m10, m11, m12, m13,
            m20, m21, m22, m23,
            m30, m31, m32, m33;

        public Matrix4(
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23,
            float m30, float m31, float m32, float m33)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
        }


        public static Matrix4 CreateTranslation(float x, float y, float z)
        {
            Matrix4 translationMatrix = new Matrix4();
            translationMatrix.Identify(translationMatrix);
            return new Matrix4(translationMatrix.m00 + x, translationMatrix.m01 + y, translationMatrix.m02 + z, translationMatrix.m03,
                               translationMatrix.m10 + x, translationMatrix.m11 + y, translationMatrix.m12 + z, translationMatrix.m13,
                               translationMatrix.m20 + x, translationMatrix.m21 + y, translationMatrix.m22 + z, translationMatrix.m23,
                               translationMatrix.m30 + x, translationMatrix.m31 + y, translationMatrix.m32 + z, translationMatrix.m33);
        }

        public static Matrix4 CreateScale(float x, float y, float z)
        {
            Matrix4 scaledMatrix = new Matrix4();
            scaledMatrix.Identify(scaledMatrix);
            return new Matrix4(scaledMatrix.m00 * x, scaledMatrix.m01, scaledMatrix.m02, scaledMatrix.m03,
                               scaledMatrix.m10,  scaledMatrix.m11 * y, scaledMatrix.m12, scaledMatrix.m13,
                               scaledMatrix.m20, scaledMatrix.m21, scaledMatrix.m22 * z, scaledMatrix.m23,
                               scaledMatrix.m30, scaledMatrix.m31, scaledMatrix.m32, scaledMatrix.m33);
        }

        public static Matrix4 CreateRotationX(float radians)
        {
            Matrix4 rotatedMatrix = new Matrix4();

            float cosRotation = (float)Math.Cos(radians);
            float sinRotation = (float)Math.Sin(radians);
            float negSinRotation = (float)-Math.Sin(radians);

            rotatedMatrix.Identify(rotatedMatrix);
            return new Matrix4(               1, rotatedMatrix.m01, rotatedMatrix.m02, rotatedMatrix.m03,
                               rotatedMatrix.m10,       cosRotation,       negSinRotation, rotatedMatrix.m13,
                               rotatedMatrix.m20,    sinRotation,       cosRotation, rotatedMatrix.m23,
                                               0,            0,            0,                1);


            // rotatedMatrix.m11 = Math.Cos(radians),
        }

        public static Matrix4 CreateRotationY(float radians)
        {
            Matrix4 rotatedMatrix = new Matrix4();

            float cosRotation = (float)Math.Cos(radians);
            float sinRotation = (float)Math.Sin(radians);
            float negSinRotation = (float)-Math.Sin(radians);

            rotatedMatrix.Identify(rotatedMatrix);
            return new Matrix4(cosRotation, rotatedMatrix.m01,     sinRotation, rotatedMatrix.m03,
                          rotatedMatrix.m10,                1, rotatedMatrix.m12, rotatedMatrix.m13,
                             negSinRotation, rotatedMatrix.m21,     cosRotation, rotatedMatrix.m23,
                                          0,                  0,              0,                1);
        }

        public static Matrix4 CreateRotationZ(float radians)
        {
            Matrix4 rotatedMatrix = new Matrix4();

            float cosRotation = (float)Math.Cos(radians);
            float sinRotation = (float)Math.Sin(radians);
            float negSinRotation = (float)-Math.Sin(radians);

            rotatedMatrix.Identify(rotatedMatrix);
            return new Matrix4( cosRotation,       negSinRotation, rotatedMatrix.m02, rotatedMatrix.m03,
                                sinRotation,          cosRotation, rotatedMatrix.m12, rotatedMatrix.m13,
                          rotatedMatrix.m20,    rotatedMatrix.m21, rotatedMatrix.m22, rotatedMatrix.m32,
                          rotatedMatrix.m30,    rotatedMatrix.m31, rotatedMatrix.m32, rotatedMatrix.m33);
        }

        //to use this function for testing at least: console.writeline(variableName.ToString());
        public override string ToString()
        {
            return m00 + "," + m01 + "," + m02 + "," + m03 + "," + "\n" +
                   m10 + "," + m11 + "," + m12 + "," + m13 + "," + "\n" +
                   m20 + "," + m21 + "," + m22 + "," + m23 + "," + "\n" +
                   m30 + "," + m31 + "," + m32 + "," + m33;
        }

        public static Matrix4 Identity
        {

            get
            {
                return new Matrix4
                    (1, 0, 0, 0,
                     0, 1, 0, 0,
                     0, 0, 1, 0,
                     0, 0, 0, 1);
            }
        }


        public Matrix4 Identify(Matrix4 other)
        {
            this = Identity;
            return this * other;
        }

        //operator overload for addition
        public static Matrix4 operator +(Matrix4 a, Matrix4 b)
        {
            return new Matrix4(a.m00 + b.m00, a.m01 + b.m01, a.m02 + b.m02, a.m03 + b.m03,

                               a.m10 + b.m10, a.m11 + b.m11, a.m12 + b.m12, a.m13 + b.m13,

                               a.m20 + b.m20, a.m21 + b.m21, a.m22 + b.m22, a.m23 + b.m23,
                               
                               a.m30 + b.m30, a.m31 + b.m31, a.m32 + b.m32, a.m33 + b.m33);
        }

        //operator overload for subtraction
        public static Matrix4 operator -(Matrix4 a, Matrix4 b)
        {
            return new Matrix4(a.m00 - b.m00, a.m01 - b.m01, a.m02 - b.m02, a.m03 - b.m03,

                               a.m10 - b.m10, a.m11 - b.m11, a.m12 - b.m12, a.m13 - b.m13,

                               a.m20 - b.m20, a.m21 - b.m21, a.m22 - b.m22, a.m23 - b.m23,

                               a.m30 - b.m30, a.m31 - b.m31, a.m32 - b.m32, a.m33 - b.m33);
        }

        //operator overload for multiplication
        public static Matrix4 operator *(Matrix4 a, Matrix4 b)
        {
                                                       //m00 position                                                                     m01 position                                        
         return new Matrix4((a.m00 * b.m00) + (a.m01 * b.m10) + (a.m02 * b.m20) + (a.m03 * b.m30),               (a.m00 * b.m01) + (a.m01 * b.m11) + (a.m02 * b.m21) + (a.m03 * b.m31), 
             
                                                       //m02 position                                                                     m03 position
                            (a.m00 * b.m02) + (a.m01 * b.m12) + (a.m02 * b.m22) + (a.m03 * b.m32),               (a.m00 * b.m03) + (a.m01 * b.m13) + (a.m02 * b.m23) + (a.m03 * b.m33),

                                                       //m10 position                                                                     m11 position                                       
                            (a.m10 * b.m00) + (a.m11 * b.m10) + (a.m12 * b.m20) + (a.m13 * b.m30),               (a.m10 * b.m01) + (a.m11 * b.m11) + (a.m12 * b.m21) + (a.m13 * b.m31),

                                                       //m12 posiiton                                                                     m13 position
                            (a.m10 * b.m02) + (a.m11 * b.m12) + (a.m12 * b.m22) + (a.m13 * b.m32),               (a.m10 * b.m03) + (a.m11 * b.m13) + (a.m12 * b.m23) + (a.m13 * b.m33),

                                                       //m20 position                                                                     m21 position
                            (a.m20 * b.m00) + (a.m21 * b.m10) + (a.m22 * b.m20) + (a.m23 * b.m30),               (a.m20 * b.m01) + (a.m21 * b.m11) + (a.m22 * b.m21) + (a.m30 * b.m31),
                              
                                                       //m22 position                                                                     m23 position
                            (a.m20 * b.m02) + (a.m21 * b.m12) + (a.m22 * b.m22) + (a.m23 * b.m32),               (a.m20 * b.m03) + (a.m21 * b.m13) + (a.m22 * b.m23) + (a.m23 * b.m33),
                            
                                                       //m30 position                                                                     m31 posiiton
                            (a.m30 * b.m00) + (a.m31 * b.m10) + (a.m32 * b.m20) + (a.m33 * b.m30),               (a.m30 * b.m01) + (a.m31 * b.m11) + (a.m32 * b.m21) + (a.m33 * b.m31),
                            
                                                       //m32 position                                                                     m33 position
                            (a.m30 * b.m02) + (a.m31 * b.m12) + (a.m32 * b.m22) + (a.m33 * b.m32),                (a.m30 * b.m03) + (a.m31 * b.m13) + (a.m32 * b.m23) + (a.m33 * b.m33));
        }

        public static Vector4 operator *(Matrix4 a, Vector4 b)
        {
            return new Vector4((a.m00 * b.x) + (a.m01 * b.y) + (a.m02 * b.z) + (a.m03 * b.w),
                               (a.m10 * b.x) + (a.m11 * b.y) + (a.m12 * b.z) + (a.m13 * b.w),
                               (a.m20 * b.x) + (a.m21 * b.y) + (a.m22 * b.z) + (a.m23 * b.w),
                               (a.m30 * b.x) + (a.m31 * b.y) + (a.m32 * b.z) + (a.m33 * b.w));
        }

        public static Vector4 operator *(Vector4 a, Matrix4 b)
        {
            return b * a;
        }


    }
}
