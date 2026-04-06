using System;

public class MyVector
{
    public double DirectionX { get; }
    public double DirectionY { get; }

    public MyVector(double dx, double dy)
    {
        DirectionX = dx;
        DirectionY = dy;
    }

    public override string ToString()
    {
        return "(" + DirectionX + ", " + DirectionY + ")";
    }

    // сложение
    public static MyVector operator +(MyVector v1, MyVector v2)
    {
        double resX = v1.DirectionX + v2.DirectionX;
        double resY = v1.DirectionY + v2.DirectionY;

        return new MyVector(resX, resY);
    }

    // вычитание
    public static MyVector operator -(MyVector first, MyVector second)
    {
        double x = first.DirectionX - second.DirectionX;
        double y = first.DirectionY - second.DirectionY;

        return new MyVector(x, y);
    }

    // скалярное произведение
    public static double operator *(MyVector left, MyVector right)
    {
        double result = left.DirectionX * right.DirectionX + left.DirectionY * right.DirectionY;

        return result;
    }

    // умножение на число
    public static MyVector operator *(MyVector vec, double k)
    {
        return new MyVector(vec.DirectionX * k, vec.DirectionY * k);
    }

    public static MyVector operator *(double k, MyVector vec)
    {
        return vec * k;
    }

    // длина вектора
    public static double operator +(MyVector vec)
    {
        return Math.Sqrt(vec.DirectionX * vec.DirectionX + vec.DirectionY * vec.DirectionY);
    }

    // сравнение
    public static bool operator ==(MyVector a, MyVector b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;

        return a.DirectionX == b.DirectionX && a.DirectionY == b.DirectionY;
    }

    public static bool operator !=(MyVector a, MyVector b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        if (obj is MyVector other)
            return this == other;

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(DirectionX, DirectionY);
    }
}