﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{

    // need matrix3 * vector3
    // need matrix4 with create rotation xyz(float)
    // need matrix4 * vector4
    public struct Matrix3
    {
        public float
            m00, m01, m02,
            m10, m11, m12,
            m20, m21, m22;

        public Matrix3(
            float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
        }


        public static Matrix3 CreateTranslation(float x, float y)
        {
            Matrix3 translationMatrix = new Matrix3();
            translationMatrix.Identify3(translationMatrix);
            return new Matrix3(translationMatrix.m00 + x, translationMatrix.m01 + x, translationMatrix.m02,
                               translationMatrix.m10 + y, translationMatrix.m11 + y, translationMatrix.m12,
                               translationMatrix.m20, translationMatrix.m21, translationMatrix.m22);
        }

        public static Matrix3 CreateScale(float x, float y)
        {
            Matrix3 scaledMatrix = new Matrix3();
            scaledMatrix.Identify3(scaledMatrix);
            return new Matrix3(scaledMatrix.m00 * x, scaledMatrix.m01, scaledMatrix.m02,
                               scaledMatrix.m10,   scaledMatrix.m11 * y, scaledMatrix.m12,
                               scaledMatrix.m20,     scaledMatrix.m21,  scaledMatrix.m22);
        }

        public static Matrix3 CreateRotation(float radians)
        {
            Matrix3 rotatedMatrix = new Matrix3();

            float cosRotation = (float)Math.Cos(radians);
            float sinRotation = (float)Math.Sin(radians);
            float negSinRotation = (-(float)Math.Sin(radians));
            rotatedMatrix.Identify3(rotatedMatrix);
            return new Matrix3(   cosRotation,         negSinRotation,    rotatedMatrix.m02,
                                  sinRotation,      cosRotation,    rotatedMatrix.m12,
                            rotatedMatrix.m20,   rotatedMatrix.m21,               1);
        }

        //to use this function for testing at least: console.writeline(variableName.ToString());
        public override string ToString()
        {
            return m00 + "," + m01 + "," + m02 + "," + "\n" +
                   m10 + "," + m11 + "," + m12 + "," + "\n" +
                   m20 + "," + m21 + "," + m22;
        }

        public static Matrix3 Identity
        {
            
            get
            {
                return new Matrix3
                    (1, 0, 0, 
                    0, 1, 0, 
                    0, 0, 1);
            }
        }

        public Matrix3 Identified
        {
            get
            {
                return this * Identity;
            }
        }

        public Matrix3 Identify3(Matrix3 other)
        {
            this = Identity;
            return this * other;
        }

        //operator overload for addition
        public static Matrix3 operator +(Matrix3 a, Matrix3 b)
        {
            return new Matrix3(a.m00 + b.m00, a.m01 + b.m01, a.m02 + b.m02,
                                a.m10 + b.m10, a.m11 + b.m11, a.m12 + b.m12,
                                a.m20 + b.m20, a.m21 + b.m21, a.m22 + b.m22);
        }

        //operator overload for subtraction
        public static Matrix3 operator -(Matrix3 a, Matrix3 b)
        {
            return new Matrix3(a.m00 - b.m00, a.m01 - b.m01, a.m02 - b.m02,
                                a.m10 - b.m10, a.m11 - b.m11, a.m12 - b.m12,
                                a.m20 - b.m20, a.m21 - b.m21, a.m22 - b.m22);
        }

        //operator overload for multiplication
        public static Matrix3 operator *(Matrix3 a, Matrix3 b)
        {
                                             //m00 position                                     m01 position                                          m02 position
         return new Matrix3((a.m00 * b.m00) + (a.m01 * b.m10) + (a.m02 * b.m20), (a.m00 * b.m01) + (a.m01 * b.m11) + (a.m02 * b.m21), (a.m00 * b.m02) + (a.m01 * b.m12) + (a.m02 * b.m22),

                                            //m10 position                                   m11 position                                          m12 position
                           (a.m10 * b.m00) + (a.m11 * b.m10) + (a.m12 * b.m20), (a.m10 * b.m01) + (a.m11 * b.m11) + (a.m12 * b.m21), (a.m10 * b.m02) + (a.m11 * b.m12) + (a.m12 * b.m22),

                                           //m20 position                                     m21 position                                          m22 position 
                           (a.m20 * b.m00) + (a.m21 * b.m10) + (a.m22 * b.m20), (a.m20 * b.m01) + (a.m21 * b.m11) + (a.m22 * b.m21), (a.m20 * b.m02) + (a.m21 * b.m12) + (a.m22 * b.m22));
        }

        public static Vector3 operator *(Matrix3 a, Vector3 b)
        {
            return new Vector3((a.m00 * b.x) + (a.m01 * b.y) + (a.m02 * b.z),
                               (a.m10 * b.x) + (a.m11 * b.y) + (a.m12 * b.z),
                               (a.m20 * b.x) + (a.m21 * b.y) + (a.m22 * b.z));
        }

        public static Vector3 operator *(Vector3 a, Matrix3 b)
        {
           return b * a;
        }



    }
}
