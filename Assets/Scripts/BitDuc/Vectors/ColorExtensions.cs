using System;
using UnityEngine;

namespace BitDuc.Vectors
{
    public static class ColorExtensions
    {
        public static float ToValue(this Color color, Func<float, float, float, float> map) =>
            map(color.r, color.g, color.b);

        public static float ToValue(this Color color, Func<float, float, float, float, float> map) =>
            map(color.r, color.g, color.b, color.a);

        public static Vector2 ToVector2(this Color color, Func<float, float, float, (float x, float y)> map)
        {
            var (x, y) = map(color.r, color.g, color.b);
            return new(x, y);
        }

        public static Vector2 ToVector2(this Color color, Func<float, float, float, float, (float x, float y)> map)
        {
            var (x, y) = map(color.r, color.g, color.b, color.a);
            return new(x, y);
        }

        public static Vector3 ToVector3(this Color color, Func<float, float, float, (float x, float y, float z)> map)
        {
            var (x, y, z) = map(color.r, color.g, color.b);
            return new(x, y, z);
        }

        public static Vector3 ToVector3(this Color color, Func<float, float, float, float, (float x, float y, float z)> map)
        {
            var (x, y, z) = map(color.r, color.g, color.b, color.a);
            return new(x, y, z);
        }

        public static Color To(this Color color, Func<float, float, float, (float r, float g, float b)> map)
        {
            var (r, g, b) = map(color.r, color.g, color.b);
            return new Color(r, g, b);
        }

        public static Color To(this Color color, Func<float, float, float, (float r, float g, float b, float a)> map)
        {
            var (r, g, b, a) = map(color.r, color.g, color.b);
            return new Color(r, g, b, a);
        }

        public static Color To(this Color color, Func<float, float, float, float, (float r, float g, float b)> map)
        {
            var (r, g, b) = map(color.r, color.g, color.b, color.a);
            return new(r, g, b);
        }

        public static Color To(this Color color, Func<float, float, float, float, (float r, float g, float b, float a)> map)
        {
            var (r, g, b, a) = map(color.r, color.g, color.b, color.a);
            return new(r, g, b, a);
        }
    }
}