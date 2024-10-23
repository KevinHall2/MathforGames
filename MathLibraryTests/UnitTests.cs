using MathLibrary;

namespace MathLibraryTests
{
    [TestClass]
    public class UnitTests
    {
const float DEFAULT_TOLERANCE = 0.0001f;
        Matrix3 Transpose(Matrix3 mat)
        {
            return new Matrix3
                (
                    mat.m00, mat.m10, mat.m20,
                    mat.m01, mat.m11, mat.m21,
                    mat.m02, mat.m12, mat.m22
                );
        }

        Matrix3 Transpose(Matrix3 mat)
        {
            return new Matrix4
                (
                    mat.m00, mat.m10, mat.m20, mat.m30,
                    mat.m01, mat.m11, mat.m21, mat.m31,
                    mat.m02, mat.m12, mat.m22, mat.m32,
                    mat.m03, mat.m13, mat.m23, mat.m33
                );
        }

        string Matrix3ToString(Matrix3 mat)
        {
            string result = mat.m00 + " " + mat.m01 + " " + mat.m02 + "\n" +
                            mat.m10 + " " + mat.m11 + " " + mat.m12 + "\n" +
                            mat.m20 + " " + mat.m21 + " " + mat.m22;

            return result;
        }

        string Matrix4ToString(Matrix3 mat)
        {
            string result = mat.m00 + " " + mat.m01 + " " + mat.m02 + " " + mat.m03 + "\n" +
                            mat.m10 + " " + mat.m11 + " " + mat.m12 + " " + mat.m13 + "\n" +
                            mat.m20 + " " + mat.m21 + " " + mat.m22 + " " + mat.m23 + "\n" +
                            mat.m30 + " " + mat.m31 + " " + mat.m32 + " " + mat.m33;

            return result;
        }
        string Vector2ToString(Vector2 vec)
        {
            return vec.x + " " + vec.y;
        }

        string Vector3ToString(Vector3 vec)
        {
            return vec.x + " " + vec.y + " " + vec.z;
        }

        string Vector4ToString(Vector4 vec)
        {
            return vec.x + " " + vec.y + " " + vec.z + " " + vec.w;
        }

        bool compare(float a, float b, float tolerance = DEFAULT_TOLERANCE)
        {
            if (Math.Abs(a - b) > tolerance)
                return false;
            return true;
        }

        bool compare(Vector3 a, Vector3 b, float tolerance = DEFAULT_TOLERANCE)
        {
            if (Math.Abs(a.x - b.x) > tolerance ||
                Math.Abs(a.y - b.y) > tolerance ||
                Math.Abs(a.z - b.z) > tolerance)
                return false;
            return true;
        }

        bool compare(Vector4 a, Vector4 b, float tolerance = DEFAULT_TOLERANCE)
        {
            if (Math.Abs(a.x - b.x) > tolerance ||
                Math.Abs(a.y - b.y) > tolerance ||
                Math.Abs(a.z - b.z) > tolerance ||
                Math.Abs(a.w - b.w) > tolerance)
                return false;
            return true;
        }

        bool compare(Matrix3 a, Matrix3 b, float tolerance = DEFAULT_TOLERANCE)
        {
            if (Math.Abs(a.m00 - b.m00) > tolerance || Math.Abs(a.m01 - b.m01) > tolerance || Math.Abs(a.m02 - b.m02) > tolerance ||
                Math.Abs(a.m10 - b.m10) > tolerance || Math.Abs(a.m11 - b.m11) > tolerance || Math.Abs(a.m12 - b.m12) > tolerance ||
                Math.Abs(a.m20 - b.m20) > tolerance || Math.Abs(a.m21 - b.m21) > tolerance || Math.Abs(a.m22 - b.m22) > tolerance)
                return false;
            return true;
        }

        bool compare(Matrix3 a, Matrix3 b, float tolerance = DEFAULT_TOLERANCE)
        {
            if (Math.Abs(a.m00 - b.m00) > tolerance || Math.Abs(a.m01 - b.m01) > tolerance || Math.Abs(a.m02 - b.m02) > tolerance || Math.Abs(a.m03 - b.m03) > tolerance ||
                Math.Abs(a.m10 - b.m10) > tolerance || Math.Abs(a.m11 - b.m11) > tolerance || Math.Abs(a.m12 - b.m12) > tolerance || Math.Abs(a.m13 - b.m13) > tolerance ||
                Math.Abs(a.m20 - b.m20) > tolerance || Math.Abs(a.m21 - b.m21) > tolerance || Math.Abs(a.m22 - b.m22) > tolerance || Math.Abs(a.m23 - b.m23) > tolerance ||
                Math.Abs(a.m30 - b.m30) > tolerance || Math.Abs(a.m31 - b.m31) > tolerance || Math.Abs(a.m32 - b.m32) > tolerance || Math.Abs(a.m33 - b.m33) > tolerance)
                return false;
            return true;
        }

        [TestMethod]
        public void Vector3Addition()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3b = new Vector3(5, 3.99f, -12);
            Vector3 v3c = v3a + v3b;
            Vector3 expected = new Vector3(18.5f, -44.24f, 850);

            Assert.IsTrue(compare(expected, v3c), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3c));
        }

        [TestMethod]
        public void Vector4Addition()
        {
            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4b = new Vector4(5, 3.99f, -12, 1);
            Vector4 v4c = v4a + v4b;
            Vector4 expected = new Vector4(18.5f, -44.24f, 850, 1);
            Assert.IsTrue(compare(expected, v4c), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector3Subtraction()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3b = new Vector3(5, 3.99f, -12);
            Vector3 v3c = v3a - v3b;
            Vector3 expected = new Vector3(8.5f, -52.22f, 874);

            Assert.IsTrue(compare(new Vector3(8.5f, -52.22f, 874), v3c), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3c));
        }

        [TestMethod]
        public void Vector4Subtraction()
        {
            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4b = new Vector4(5, 3.99f, -12, 1);
            Vector4 v4c = v4a - v4b;
            Vector4 expected = new Vector4(8.5f, -52.22f, 874, -1);
            Assert.IsTrue(compare(new Vector4(8.5f, -52.22f, 874, -1), v4c), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector3PostScale()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3c = v3a * 0.256f;
            Vector3 expected = new Vector3(3.45600008965f, -12.3468809128f, 220.672012329f);
            Assert.IsTrue(compare(new Vector3(3.45600008965f, -12.3468809128f, 220.672012329f), v3c), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3c));
        }

        [TestMethod]
        public void Vector4PostScale()
        {
            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4c = v4a * 4.89f;
            Vector4 expected = new Vector4(66.0149993896f, -235.844696045f, 4215.1796875f, 0);
            Assert.IsTrue(compare(new Vector4(66.0149993896f, -235.844696045f, 4215.1796875f, 0), v4c), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector3PreScale()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3c = 0.256f * v3a;
            Vector3 expected = new Vector3(3.45600008965f, -12.3468809128f, 220.672012329f);
            Assert.IsTrue(compare(new Vector3(3.45600008965f, -12.3468809128f, 220.672012329f), v3c), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3c));
        }

        [TestMethod]
        public void Vector4PreScale()
        {
            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4c = 4.89f * v4a;
            Vector4 expected = new Vector4(66.0149993896f, -235.844696045f, 4215.1796875f, 0);
            Assert.IsTrue(compare(new Vector4(66.0149993896f, -235.844696045f, 4215.1796875f, 0), v4c), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector3Dot()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3b = new Vector3(5, 3.99f, -12);
            float dot3 = v3a.DotProduct(v3b);
            float expected = -10468.9375f;
            Assert.AreEqual(dot3, -10468.9375f, DEFAULT_TOLERANCE, "Expected: " + expected + "\n" + "Received: " + dot3);
        }

        [TestMethod]
        public void Vector4Dot()
        {
            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4b = new Vector4(5, 3.99f, -12, 1);
            float dot4 = v4a.DotProduct(v4b);

            float expected = -10468.9375f;
            Assert.AreEqual(dot4, -10468.9375f, DEFAULT_TOLERANCE, "Expected: " + expected + "\n" + "Received: " + dot4);
        }

        [TestMethod]
        public void Vector3Cross()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3b = new Vector3(5, 3.99f, -12);
            Vector3 v3c = v3a.CrossProduct(v3b);
            Vector3 expected = new Vector3(-2860.62011719f, 4472.00000000f, 295.01498413f);
            Assert.IsTrue(compare(v3c, new Vector3(-2860.62011719f, 4472.00000000f, 295.01498413f)), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3c));
        }

        [TestMethod]
        public void Vector4Cross()
        {
            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4b = new Vector4(5, 3.99f, -12, 1);
            Vector4 v4c = v4a.CrossProduct(v4b);
            Vector4 expected = new Vector4(-2860.62011719f, 4472.00000000f, 295.01498413f, 0);
            Assert.IsTrue(compare(v4c, new Vector4(-2860.62011719f, 4472.00000000f, 295.01498413f, 0)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector3Magnitude()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            float mag3 = v3a.Magnitude;
            float expected = 863.453735352f;
            Assert.AreEqual(mag3, 863.453735352f, DEFAULT_TOLERANCE, "Expected: " + expected + "\n" + "Received: " + mag3);
        }

        [TestMethod]
        public void Vector4Magnitude()
        {
            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            float mag4 = v4a.Magnitude;

            float expected = 863.453735352f;
            Assert.AreEqual(mag4, 863.453735352f, DEFAULT_TOLERANCE, "Expected: " + expected + "\n" + "Received: " + mag4);
        }

        [TestMethod]
        public void Vector3Normalise()
        {
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862f);
            v3a.Normalize();
            Vector3 expected = new Vector3(0.0156349f, -0.0558571f, 0.998316f);
            Assert.IsTrue(compare(v3a, new Vector3(0.0156349f, -0.0558571f, 0.998316f)), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3a));
        }

        [TestMethod]
        public void Vector4Normalise()
        {
            Vector4 v4a = new Vector4(243, -48.23f, 862, 0);
            v4a.Normalize();
            Vector4 expected = new Vector4(0.270935f, -0.0537745f, 0.961094f, 0);
            Assert.IsTrue(compare(v4a, new Vector4(0.270935f, -0.0537745f, 0.961094f, 0)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4a));
        }

        [TestMethod]
        public void Matrix4SetRotateX()
        {
            Matrix3 m4a = new Matrix3();
            m4a = Matrix3.CreateRotationX(4.5f);

            m4a = Transpose(m4a);

            Matrix3 expected = new Matrix4(1, 0, 0, 0, 0, -0.210796f, -0.97753f, 0, 0, 0.97753f, -0.210796f, 0, 0, 0, 0, 1);
            Assert.IsTrue(compare(m4a,
                new Matrix4(1, 0, 0, 0, 0, -0.210796f, -0.97753f, 0, 0, 0.97753f, -0.210796f, 0, 0, 0, 0, 1)), "Expected: " + Matrix4ToString(expected) + "\n" + "Received: " + Matrix4ToString(m4a));
        }

        [TestMethod]
        public void Matrix4SetRotateY()
        {
            Matrix3 m4b = new Matrix3();
            m4b = Matrix3.CreateRotationY(-2.6f);

            m4b = Transpose(m4b);

            Matrix3 expected = new Matrix4(-0.856889f, 0, 0.515501f, 0, 0, 1, 0, 0, -0.515501f, 0, -0.856889f, 0, 0, 0, 0, 1);
            Assert.IsTrue(compare(m4b,
                new Matrix4(-0.856889f, 0, 0.515501f, 0, 0, 1, 0, 0, -0.515501f, 0, -0.856889f, 0, 0, 0, 0, 1)), "Expected: " + Matrix4ToString(expected) + "\n" + "Received: " + Matrix4ToString(m4b));
        }

        [TestMethod]
        public void Matrix3SetRotate()
        {
            Matrix3 m3c = new Matrix3();
            m3c = Matrix3.CreateRotation(9.62f);

            m3c = Transpose(m3c);

            Matrix3 expected = new Matrix3(-0.981005f, -0.193984f, 0, 0.193984f, -0.981005f, 0, 0, 0, 1);
            Assert.IsTrue(compare(m3c,
                new Matrix3(-0.981005f, -0.193984f, 0, 0.193984f, -0.981005f, 0, 0, 0, 1)), "Expected: " + Matrix3ToString(expected) + "\n" + "Received: " + Matrix3ToString(m3c));
        }

        [TestMethod]
        public void Matrix4SetRotateZ()
        {
            Matrix3 m4c = new Matrix3();
            m4c = Matrix3.CreateRotationZ(0.72f);

            m4c = Transpose(m4c);

            Matrix3 expected = new Matrix4(0.751806f, 0.659385f, 0, 0, -0.659385f, 0.751806f, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
            Assert.IsTrue(compare(m4c,
                new Matrix4(0.751806f, 0.659385f, 0, 0, -0.659385f, 0.751806f, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1)), "Expected: " + Matrix4ToString(expected) + "\n" + "Received: " + Matrix4ToString(m4c));
        }

        [TestMethod]
        public void Vector3MatrixTransform2()
        {
            Matrix3 m3c = new Matrix3();
            m3c = Matrix3.CreateRotation(9.62f);

            //m3c = Transpose(m3c);

            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3c = m3c * v3a;

            Vector3 expected = new Vector3(-22.599422f, 44.69507f, 862);

            Assert.IsTrue(compare(v3c, expected), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3c));
        }

        [TestMethod]
        public void Vector4MatrixTransform()
        {
            Matrix3 m4b = new Matrix3();
            m4b = Matrix3.CreateRotationY(-2.6f);

            //m4b = Transpose(m4b);

            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4b = m4b * v4a;
            Vector4 expected = new Vector4(-455.930236816f, -48.2299995422f, -731.678771973f, 0);

            Assert.IsTrue(compare(v4b,
                new Vector4(-455.930236816f, -48.2299995422f, -731.678771973f, 0)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4b));
        }

        [TestMethod]
        public void Vector4MatrixTransform2()
        {
            Matrix3 m4c = new Matrix3();
            m4c = Matrix3.CreateRotationZ(0.72f);

            //m4c = Transpose(m4c);

            Vector4 v4a = new Vector4(13.5f, -48.23f, 862, 0);
            Vector4 v4b = m4c * v4a;
            Vector4 expected = new Vector4(41.951499939f, -27.3578968048f, 862, 0);

            Assert.IsTrue(compare(v4b,
                new Vector4(41.951499939f, -27.3578968048f, 862, 0)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4b));
        }

        [TestMethod]
        public void Matrix3Multiply()
        {
            Matrix3 m3b = new Matrix3();
            m3b = Matrix3.CreateTranslation(2, 3);

            Matrix3 m3c = new Matrix3();
            m3c = Matrix3.CreateTranslation(3, 15);

            Matrix3 m4d = m3b * m3c;
            m4d = Transpose(m4d);
            Matrix3 expected = new Matrix3(1, 0, 0, 0, 1, 0, 5, 18, 1);

            Assert.IsTrue(compare(m4d,
                new Matrix3(1, 0, 0, 0, 1, 0, 5, 18, 1)), "Expected: \n" + Matrix3ToString(expected) + "\n" + "Received: \n" + Matrix3ToString(m4d));
        }

        [TestMethod]
        public void Matrix4Multiply()
        {
            Matrix3 m4b = new Matrix3();
            m4b = Matrix3.CreateRotationY(-2.6f);
            m4b = Transpose(m4b);

            Matrix3 m4c = new Matrix3();
            m4c = Matrix3.CreateRotationZ(0.72f);
            m4c = Transpose(m4c);

            Matrix3 m4d = m4c * m4b;

            Matrix3 expected = new Matrix4(-0.644213855267f, 0.659384668f, 0.3875569210f, 0, 0.5650192710f, 0.751805722713f, -0.3399137459f, 0, -0.51550144f, 0, -0.856888711452f, 0, 0, 0, 0, 1);
            Assert.IsTrue(compare(m4d, expected), "Expected: \n" + Matrix4ToString(expected) + "\n" + "Received: \n" + Matrix4ToString(m4d));
        }

        [TestMethod]
        public void Vector3MatrixTranslation()
        {
            // homogeneous point translation
            Matrix3 m3b = new Matrix3(1, 0, 0,
                                        0, 1, 0,
                                        55, 44, 1);

            m3b = Transpose(m3b);

            Vector3 v3a = new Vector3(13.5f, -48.23f, 1);

            Vector3 v3b = m3b * v3a;
            Vector3 expected = new Vector3(68.5f, -4.23f, 1);

            Assert.IsTrue(compare(v3b, new Vector3(68.5f, -4.23f, 1)), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3b));
        }


        [TestMethod]
        public void Vector4MatrixTranslation()
        {
            // homogeneous point translation
            Matrix3 m4b = new Matrix4(1, 0, 0, 0,
                                        0, 1, 0, 0,
                                        0, 0, 1, 0,
                                        55, 44, 99, 1);
            m4b = Transpose(m4b);

            Vector4 v4a = new Vector4(13.5f, -48.23f, -54, 1);

            Vector4 v4c = m4b * v4a;
            Vector4 expected = new Vector4(68.5f, -4.23f, 45, 1);

            Assert.IsTrue(compare(v4c, new Vector4(68.5f, -4.23f, 45, 1)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector4MatrixTranslation2()
        {
            // homogeneous point translation
            Matrix3 m4c = Matrix3.CreateRotationZ(2.2f);

            //m4c = Transpose(m4c);
            m4c.m03 = 55; m4c.m13 = 44; m4c.m23 = 99; m4c.m33 = 1;

            Vector4 v4a = new Vector4(13.5f, -48.23f, -54, 1);

            Vector4 v4c = m4c * v4a;
            Vector4 expected = new Vector4(86.0490112305f, 83.2981109619f, 45, 1);
            Assert.IsTrue(compare(v4c, new Vector4(86.0490112305f, 83.2981109619f, 45, 1)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector3MatrixTranslation3()
        {
            // homogeneous point translation
            Matrix3 m3b = new Matrix3(1, 0, 0,
                                        0, 1, 0,
                                        55, 44, 1);

            m3b = Transpose(m3b);

            Vector3 v3a = new Vector3(13.5f, -48.23f, 0);

            Vector3 v3b = m3b * v3a;
            Vector3 expected = new Vector3(13.5f, -48.23f, 0);

            Assert.IsTrue(compare(v3b, new Vector3(13.5f, -48.23f, 0)), "Expected: " + Vector3ToString(expected) + "\n" + "Received: " + Vector3ToString(v3b));
        }

        [TestMethod]
        public void Vector4MatrixTranslation3()
        {
            // homogeneous point translation
            Matrix3 m4b = new Matrix4(1, 0, 0, 0,
                                        0, 1, 0, 0,
                                        0, 0, 1, 0,
                                        55, 44, 99, 1);

            m4b = Transpose(m4b);

            Vector4 v4a = new Vector4(13.5f, -48.23f, -54, 0);

            Vector4 v4c = m4b * v4a;
            Vector4 expected = new Vector4(13.5f, -48.23f, -54, 0);
            Assert.IsTrue(compare(v4c, new Vector4(13.5f, -48.23f, -54, 0)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

        [TestMethod]
        public void Vector4MatrixTranslation4()
        {
            // homogeneous point translation
            Matrix3 m4c = Matrix3.CreateRotationZ(2.2f);
            //m4c = Transpose(m4c);
            m4c.m03 = 55; m4c.m13 = 44; m4c.m23 = 99; m4c.m33 = 1;

            Vector4 v4a = new Vector4(13.5f, -48.23f, -54, 0);

            Vector4 v4c = m4c * v4a;
            Vector4 expected = new Vector4(31.0490131378f, 39.2981109619f, -54, 0);
            Assert.IsTrue(compare(v4c, new Vector4(31.0490131378f, 39.2981109619f, -54, 0)), "Expected: " + Vector4ToString(expected) + "\n" + "Received: " + Vector4ToString(v4c));
        }

    }
}