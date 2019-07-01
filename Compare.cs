// Decompiled with JetBrains decompiler
// Type: Tekla.Structures.India.Common.Compare
// Assembly: FlangeWebBoltSeparator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22369202-C8FF-4769-AE92-AAA858CB069E
// Assembly location: E:\Data_1\References\FlangeWebBoltSeparator.dll

using System;
using Tekla.Structures.Geometry3d;

namespace Tekla.Structures.India.Common
{
  public static class Compare
  {
    private static double _Length_EPS = 0.001;
    private static double _Anglular_EPS = 0.1;

    public static double Length_EPS
    {
      get
      {
        return Compare._Length_EPS;
      }
      set
      {
        Compare._Length_EPS = value;
      }
    }

    public static double Anglular_EPS
    {
      get
      {
        return Compare._Anglular_EPS;
      }
      set
      {
        Compare._Anglular_EPS = value;
      }
    }

    public static bool IsEqual(double val1, double val2)
    {
      return Math.Abs(val1 - val2) < Compare.Length_EPS;
    }

    public static bool IsEqual(double val1, double val2, double eps)
    {
      return Math.Abs(val1 - val2) < eps;
    }

    public static bool IsEqual(Point point1, Point point2)
    {
      if (Compare.IsEqual(point1.X, point2.X) && Compare.IsEqual(point1.Y, point2.Y))
        return Compare.IsEqual(point1.Z, point2.Z);
      return false;
    }

    public static bool IsGreaterThan(double greaterValue, double lesserValue)
    {
      return greaterValue - lesserValue > Compare.Length_EPS;
    }

    public static bool IsLessThan(double lesserValue, double greaterValue)
    {
      return greaterValue - lesserValue > Compare.Length_EPS;
    }

    public static bool IsGreaterThanOrEqual(double greaterValue, double lesserValue)
    {
      if (!Compare.IsGreaterThan(greaterValue, lesserValue))
        return Compare.IsEqual(greaterValue, lesserValue);
      return true;
    }

    public static bool IsLessThanOrEqual(double lesserValue, double greaterValue)
    {
      if (!Compare.IsLessThan(lesserValue, greaterValue))
        return Compare.IsEqual(greaterValue, lesserValue);
      return true;
    }
  }
}
