﻿using System.Numerics;

namespace SPICA.Math3D
{
    public struct Matrix3x4
    {
        private Matrix4x4 m;

        private static readonly Matrix3x4 _identity = new Matrix3x4(Matrix4x4.Identity);

        public static Matrix3x4 Identity { get { return _identity; } }

        public float M11 { get { return m.M11; } set { m.M11 = value; } }
        public float M12 { get { return m.M12; } set { m.M12 = value; } }
        public float M13 { get { return m.M13; } set { m.M13 = value; } }

        public float M21 { get { return m.M21; } set { m.M21 = value; } }
        public float M22 { get { return m.M22; } set { m.M22 = value; } }
        public float M23 { get { return m.M23; } set { m.M23 = value; } }

        public float M31 { get { return m.M31; } set { m.M31 = value; } }
        public float M32 { get { return m.M32; } set { m.M32 = value; } }
        public float M33 { get { return m.M33; } set { m.M33 = value; } }

        public float M41 { get { return m.M41; } set { m.M41 = value; } }
        public float M42 { get { return m.M42; } set { m.M42 = value; } }
        public float M43 { get { return m.M43; } set { m.M43 = value; } }

        public Matrix3x4(Matrix4x4 Matrix)
        {
            m = Matrix;
        }

        public Matrix3x4(float m11, float m12, float m13,
                         float m21, float m22, float m23,
                         float m31, float m32, float m33,
                         float m41, float m42, float m43)
        {
            m = new Matrix4x4(
                m11, m12, m13, 0f,
                m21, m22, m23, 0f,
                m31, m32, m33, 0f,
                m41, m42, m43, 1f);
        }

        public Matrix3x4()
        {
            m = Matrix4x4.Identity;
        }

        public Matrix4x4 ToMatrix4x4()
        {
            return m;
        }

        public static implicit operator Matrix4x4(Matrix3x4 m)
        {
            return m.ToMatrix4x4();
        }

        public override string ToString()
        {
            return m.ToString();
        }
    }
}
