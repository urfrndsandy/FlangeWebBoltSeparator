// Decompiled with JetBrains decompiler
// Type: Tekla.Structures.India.Common.PointComparer
// Assembly: FlangeWebBoltSeparator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22369202-C8FF-4769-AE92-AAA858CB069E
// Assembly location: E:\Data_1\References\FlangeWebBoltSeparator.dll

using System.Collections.Generic;
using Tekla.Structures.Geometry3d;

namespace Tekla.Structures.India.Common
{
  public class PointComparer : IEqualityComparer<Point>
  {
    public bool Equals(Point x, Point y)
    {
      return Compare.IsEqual(new Vector(x - y).GetLength(), 0.0);
    }

    public int GetHashCode(Point obj)
    {
      return obj.GetHashCode();
    }
  }
}
