// Decompiled with JetBrains decompiler
// Type: Tekla.Structures.India.Common.Geometry
// Assembly: FlangeWebBoltSeparator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22369202-C8FF-4769-AE92-AAA858CB069E
// Assembly location: E:\Data_1\References\FlangeWebBoltSeparator.dll

using System;
using System.Collections.Generic;
using System.Linq;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

namespace Tekla.Structures.India.Common
{
  public static class Geometry
  {
    public static Vector GetColumnMovement(Position position, double height, double width)
    {
      Vector vector = new Vector(0.0, 0.0, 0.0);
      if (position.Rotation == Position.RotationEnum.FRONT || position.Rotation == Position.RotationEnum.BACK)
      {
        double num = height;
        height = width;
        width = num;
      }
      switch (position.Plane)
      {
        case Position.PlaneEnum.MIDDLE:
          vector.Y += 0.0 + position.PlaneOffset;
          break;
        case Position.PlaneEnum.LEFT:
          vector.Y -= width * 0.5 + position.PlaneOffset;
          break;
        case Position.PlaneEnum.RIGHT:
          vector.Y += width * 0.5 + position.PlaneOffset;
          break;
      }
      switch (position.Depth)
      {
        case Position.DepthEnum.MIDDLE:
          vector.X -= 0.0 + position.DepthOffset;
          break;
        case Position.DepthEnum.FRONT:
          vector.X -= height * 0.5 + position.DepthOffset;
          break;
        case Position.DepthEnum.BEHIND:
          vector.X += height * 0.5 + position.DepthOffset;
          break;
      }
      return vector;
    }

    public static Vector GetBeamMovement(Position position, double height, double width)
    {
      Vector vector = new Vector(0.0, 0.0, 0.0);
      if (position.Rotation == Position.RotationEnum.FRONT || position.Rotation == Position.RotationEnum.BACK)
      {
        double num = height;
        height = width;
        width = num;
      }
      switch (position.Plane)
      {
        case Position.PlaneEnum.MIDDLE:
          vector.Y += 0.0 + position.PlaneOffset;
          break;
        case Position.PlaneEnum.LEFT:
          vector.Y -= width * 0.5 + position.PlaneOffset;
          break;
        case Position.PlaneEnum.RIGHT:
          vector.Y += width * 0.5 + position.PlaneOffset;
          break;
      }
      switch (position.Depth)
      {
        case Position.DepthEnum.MIDDLE:
          vector.Z += 0.0 + position.DepthOffset;
          break;
        case Position.DepthEnum.FRONT:
          vector.Z += height * 0.5 + position.DepthOffset;
          break;
        case Position.DepthEnum.BEHIND:
          vector.Z -= height * 0.5 + position.DepthOffset;
          break;
      }
      return vector;
    }

    public static Vector GetColumnMovement(
      Position position,
      double heightTop,
      double heightBottom,
      double widthLeft,
      double widthRight)
    {
      Vector vector = new Vector(0.0, 0.0, 0.0);
      switch (position.Rotation)
      {
        case Position.RotationEnum.FRONT:
          double num1 = heightTop;
          heightTop = widthRight;
          widthRight = heightBottom;
          heightBottom = widthLeft;
          widthLeft = num1;
          break;
        case Position.RotationEnum.BACK:
          double num2 = heightTop;
          heightTop = widthLeft;
          widthLeft = heightBottom;
          heightBottom = widthRight;
          widthRight = num2;
          break;
        case Position.RotationEnum.BELOW:
          double num3 = heightTop;
          heightTop = heightBottom;
          heightBottom = num3;
          double num4 = widthLeft;
          widthLeft = widthRight;
          widthRight = num4;
          break;
      }
      switch (position.Plane)
      {
        case Position.PlaneEnum.MIDDLE:
          vector.Y += 0.0 + position.PlaneOffset;
          break;
        case Position.PlaneEnum.LEFT:
          vector.Y -= widthLeft + position.PlaneOffset;
          break;
        case Position.PlaneEnum.RIGHT:
          vector.Y += widthRight + position.PlaneOffset;
          break;
      }
      switch (position.Depth)
      {
        case Position.DepthEnum.MIDDLE:
          vector.X -= 0.0 + position.DepthOffset;
          break;
        case Position.DepthEnum.FRONT:
          vector.X -= heightBottom + position.DepthOffset;
          break;
        case Position.DepthEnum.BEHIND:
          vector.X += heightTop + position.DepthOffset;
          break;
      }
      return vector;
    }

    public static Vector GetBeamMovement(
      Position position,
      double heightTop,
      double heightBottom,
      double widthLeft,
      double widthRight)
    {
      Vector vector = new Vector(0.0, 0.0, 0.0);
      switch (position.Rotation)
      {
        case Position.RotationEnum.FRONT:
          double num1 = heightTop;
          heightTop = widthRight;
          widthRight = heightBottom;
          heightBottom = widthLeft;
          widthLeft = num1;
          break;
        case Position.RotationEnum.BACK:
          double num2 = heightTop;
          heightTop = widthLeft;
          widthLeft = heightBottom;
          heightBottom = widthRight;
          widthRight = num2;
          break;
        case Position.RotationEnum.BELOW:
          double num3 = heightTop;
          heightTop = heightBottom;
          heightBottom = num3;
          double num4 = widthLeft;
          widthLeft = widthRight;
          widthRight = num4;
          break;
      }
      switch (position.Plane)
      {
        case Position.PlaneEnum.MIDDLE:
          vector.Y += 0.0 + position.PlaneOffset;
          break;
        case Position.PlaneEnum.LEFT:
          vector.Y -= widthLeft + position.PlaneOffset;
          break;
        case Position.PlaneEnum.RIGHT:
          vector.Y += widthRight + position.PlaneOffset;
          break;
      }
      switch (position.Depth)
      {
        case Position.DepthEnum.MIDDLE:
          vector.Z += 0.0 + position.DepthOffset;
          break;
        case Position.DepthEnum.FRONT:
          vector.Z += heightBottom + position.DepthOffset;
          break;
        case Position.DepthEnum.BEHIND:
          vector.Z -= heightTop + position.DepthOffset;
          break;
      }
      return vector;
    }

    public static Vector GetBeamMovementTopAlign(
      Position position,
      double heightTop,
      double heightBottom,
      double widthLeft,
      double widthRight)
    {
      Vector vector = new Vector(0.0, 0.0, 0.0);
      switch (position.Rotation)
      {
        case Position.RotationEnum.FRONT:
          double num1 = heightTop;
          heightTop = widthRight;
          widthRight = heightBottom;
          heightBottom = widthLeft;
          widthLeft = num1;
          break;
        case Position.RotationEnum.BACK:
          double num2 = heightTop;
          heightTop = widthLeft;
          widthLeft = heightBottom;
          heightBottom = widthRight;
          widthRight = num2;
          break;
        case Position.RotationEnum.BELOW:
          double num3 = heightTop;
          heightTop = heightBottom;
          heightBottom = num3;
          double num4 = widthLeft;
          widthLeft = widthRight;
          widthRight = num4;
          break;
      }
      switch (position.Plane)
      {
        case Position.PlaneEnum.MIDDLE:
          vector.Y += 0.0 + position.PlaneOffset;
          break;
        case Position.PlaneEnum.LEFT:
          vector.Y -= widthLeft + position.PlaneOffset;
          break;
        case Position.PlaneEnum.RIGHT:
          vector.Y += widthRight + position.PlaneOffset;
          break;
      }
      switch (position.Depth)
      {
        case Position.DepthEnum.MIDDLE:
          vector.Z += position.DepthOffset - heightBottom;
          break;
        case Position.DepthEnum.FRONT:
          vector.Z += position.DepthOffset;
          break;
        case Position.DepthEnum.BEHIND:
          vector.Z -= heightBottom + heightTop + position.DepthOffset;
          break;
      }
      return vector;
    }

    public static List<Point> GetColumnPoints(
      Tekla.Structures.Model.Model Model,
      Point ptStart,
      double firstLevel,
      double secondLevel)
    {
      TransformationPlane transformationPlane = Model.GetWorkPlaneHandler().GetCurrentTransformationPlane();
      Matrix transformationMatrixToLocal = transformationPlane.TransformationMatrixToLocal;
      Point point = transformationPlane.TransformationMatrixToGlobal.Transform(ptStart);
      Vector vector1 = new Vector(0.0, 0.0, firstLevel);
      Vector vector2 = new Vector(0.0, 0.0, secondLevel);
      point.Z = 0.0;
      Point p1 = point + (Point) vector1;
      Point p2 = point + (Point) vector2;
      return new List<Point>()
      {
        transformationMatrixToLocal.Transform(p1),
        transformationMatrixToLocal.Transform(p2)
      };
    }

    public static List<Point> GetColumnPoints(
      Tekla.Structures.Model.Model Model,
      Point ptStart,
      Point ptEnd,
      double firstLevel,
      double secondLevel)
    {
      Vector vector1 = new Vector(ptEnd - ptStart);
      Vector vector2 = vector1.GetNormal() * firstLevel;
      Vector vector3 = vector1.GetNormal() * secondLevel;
      return new List<Point>()
      {
        ptStart + (Point) vector2,
        ptStart + (Point) vector3
      };
    }

    public static double DegreeToRadian(double deg)
    {
      return Math.PI * deg / 180.0;
    }

    public static double RadianToDegree(double rad)
    {
      return 180.0 * rad / Math.PI;
    }

    public static Point MidPoint(Point pt1, Point pt2)
    {
      return new Point((pt1.X + pt2.X) / 2.0, (pt1.Y + pt2.Y) / 2.0, (pt1.Z + pt2.Z) / 2.0);
    }

    public static Point RelativePoint(Point pt1, Point pt2, double relativeVal)
    {
      Vector vector = new Vector(pt2 - pt1);
      return pt1 + (Point) (vector * relativeVal);
    }

    public static bool IsCollinear(Point point1, Point point2, Point point3)
    {
      return Parallel.VectorToVector(new Vector(point1 - point2), new Vector(point2 - point3), Geometry.DegreeToRadian(Compare.Anglular_EPS));
    }

    public static Point AddVectorToPoint(Point point, Vector vector)
    {
      return new Point(point.X + vector.X, point.Y + vector.Y, point.Z + vector.Z);
    }

    public static Point PolarPoint(Point basePoint, Vector direction, double distance)
    {
      Vector vector = new Vector((Point) direction);
      vector.Normalize(distance);
      return Geometry.AddVectorToPoint(basePoint, vector);
    }

    public static double AngleBetweenVectors(Vector vector1, Vector vector2)
    {
      return Math.Acos(vector1.GetNormal().Dot(vector2.GetNormal()));
    }

    public static double AngleBetweenVectors(Vector vector1, Vector vector2, Vector NormalVector)
    {
      Vector normal1 = vector1.GetNormal();
      Vector normal2 = vector2.GetNormal();
      if (new Vector((Point) vector1.Cross(vector2)).Dot(NormalVector) > 0.0)
        return Math.Acos(normal1.Dot(normal2));
      return Geometry.DegreeToRadian(360.0) - Math.Acos(normal1.Dot(normal2));
    }

    public static double VectorLength(Vector vec)
    {
      return Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
    }

    public static Vector VectorProjection(Vector vec, Vector onVec)
    {
      Vector normal = onVec.GetNormal();
      return normal * normal.Dot(vec);
    }

    public static Vector VectorProjectionAcross(Vector vec, Vector onVec)
    {
      Vector normal = onVec.GetNormal();
      double val1 = normal.Dot(vec.GetNormal());
      if (Compare.IsEqual(val1, 0.0))
        return new Vector(0.0, 0.0, 0.0);
      return normal * (Geometry.VectorLength(vec) / val1);
    }

    public static Vector VectorRotate(
      Vector InputVector,
      double AngleInDegree,
      Vector NormalVector)
    {
      return new Vector(MatrixFactory.Rotate(Geometry.DegreeToRadian(AngleInDegree), NormalVector).Transform((Point) InputVector));
    }

    public static CoordinateSystem Transform(Matrix matToTrans, CoordinateSystem cs)
    {
      Point Origin = matToTrans.Transform(cs.Origin);
      Vector vector1 = Geometry.Transform(matToTrans, cs.AxisX);
      Vector vector2 = Geometry.Transform(matToTrans, cs.AxisY);
      Vector AxisX = vector1;
      Vector AxisY = vector2;
      return new CoordinateSystem(Origin, AxisX, AxisY);
    }

    public static Plane Transform(Matrix matToTrans, Plane plane)
    {
      return new Plane()
      {
        Origin = matToTrans.Transform(plane.Origin),
        AxisX = Geometry.Transform(matToTrans, plane.AxisX),
        AxisY = Geometry.Transform(matToTrans, plane.AxisY)
      };
    }

    public static GeometricPlane Transform(Matrix matToTrans, GeometricPlane plane)
    {
      return new GeometricPlane()
      {
        Origin = matToTrans.Transform(plane.Origin),
        Normal = Geometry.Transform(matToTrans, plane.Normal)
      };
    }

    public static void DrawCoordinates()
    {
      GraphicsDrawer graphicsDrawer = new GraphicsDrawer();
      graphicsDrawer.DrawLineSegment(new Point(0.0, 0.0, 0.0), new Point(1000.0, 0.0, 0.0), new Color(1.0, 0.0, 0.0));
      graphicsDrawer.DrawLineSegment(new Point(0.0, 0.0, 0.0), new Point(0.0, 3000.0, 0.0), new Color(0.0, 1.0, 0.0));
      graphicsDrawer.DrawLineSegment(new Point(0.0, 0.0, 0.0), new Point(0.0, 0.0, 9000.0), new Color(0.0, 0.0, 1.0));
    }

    public static Vector Transform(Matrix matToTrans, Vector vec)
    {
      return new Vector(new Matrix(matToTrans)
      {
        [3, 0] = 0.0,
        [3, 1] = 0.0,
        [3, 2] = 0.0
      }.Transform((Point) vec));
    }

    public static Vector VectorToPlane(GeometricPlane plane, Vector vIn)
    {
      Vector normal = vIn.GetNormal();
      Vector Vector = new Vector((Point) plane.Normal);
      Vector vec = Vector.Cross(normal);
      if (Compare.IsEqual(Geometry.VectorLength(vec), 0.0))
        return vec;
      Vector onVec = vec.Cross(Vector);
      onVec.Normalize();
      return Geometry.VectorProjection(vIn, onVec);
    }

    public static Vector VectorToPlaneAlong(GeometricPlane plane, Vector vIn, Vector vAlong)
    {
      if (Geometry.VectorIsParallel(plane.Normal, vAlong))
        return Geometry.VectorToPlane(plane, vIn);
      Vector plane1 = Geometry.VectorToPlane(plane, vAlong);
      Vector onVec = vAlong.Cross(vIn).Cross(vAlong);
      return Geometry.VectorProjectionAcross(Geometry.VectorProjectionAcross(vIn, onVec), plane1);
    }

    public static Point PointToPlaneAlong(GeometricPlane plane, Point ptIn, Vector vAlong)
    {
      Vector vector = Geometry.VectorProjectionAcross(new Vector(Projection.PointToPlane(ptIn, plane) - ptIn), vAlong);
      return ptIn + (Point) vector;
    }

    public static List<Point> GetSimpleOffset(this List<Point> points, double offset)
    {
      double num = points.Area() < 0.0 ? -1.0 : 1.0;
      int count = points.Count;
      List<Line> lines = new List<Line>();
      for (int index1 = 0; index1 < points.Count; ++index1)
      {
        int index2 = index1 == count - 1 ? 0 : index1 + 1;
        Point point1 = points[index1];
        Point point2 = points[index2];
        Vector vector = new Vector(point2 - point1).Cross(new Vector(0.0, 0.0, 1.0));
        vector.Normalize(num * offset);
        Point p1 = point1 + (Point) vector;
        Point p2 = point2 + (Point) vector;
        lines.Add(new Line(p1, p2));
      }
      List<Point> trimAtIntersections = lines.GetTrimAtIntersections();
      lines.Clear();
      return trimAtIntersections;
    }

    private static List<Point> GetTrimAtIntersections(this List<Line> lines)
    {
      List<Point> pointList = new List<Point>();
      int count = lines.Count;
      for (int index1 = 0; index1 < count; ++index1)
      {
        int index2 = index1 == count - 1 ? 0 : index1 + 1;
        LineSegment line = Intersection.LineToLine(lines[index1], lines[index2]);
        pointList.Add(line.Point1);
      }
      return pointList;
    }

    public static double Area(this List<Point> points)
    {
      int index1 = points.Count - 1;
      if (index1 < 2)
        return 0.0;
      double num = points[index1].X * points[0].Y - points[0].X * points[index1].Y;
      for (int index2 = 0; index2 < index1; ++index2)
        num += points[index2].X * points[index2 + 1].Y - points[index2 + 1].X * points[index2].Y;
      return num / 2.0;
    }

    public static bool VectorIsParallel(Vector Vector1, Vector Vector2)
    {
      return Compare.IsEqual(Geometry.VectorLength(Vector1.Cross(Vector2)), 0.0);
    }

    public static bool VectorIsCoDirectional(Vector Vector1, Vector Vector2)
    {
      return Parallel.VectorToVector(Vector1, Vector2) && Compare.IsEqual(Vector1.GetNormal().Dot(Vector2.GetNormal()), 1.0, 0.0001);
    }

    public static bool VectorIsParallel(Vector vector1, Vector vector2, double angleInDegree)
    {
      return Compare.IsGreaterThan(Math.Abs(vector1.GetNormal().Dot(vector2.GetNormal())), Math.Cos(Geometry.DegreeToRadian(angleInDegree)));
    }

    public static Point CircleCenterPoint(
      Point FirstPoint,
      Point SecondPoint,
      Point ThirdPoint)
    {
      Vector InputVector = new Vector(SecondPoint - FirstPoint);
      Vector vector1 = new Vector(ThirdPoint - FirstPoint);
      Vector NormalVector = InputVector.Cross(vector1);
      Point point1 = new Point();
      Point point2 = new Point();
      Point point3 = Geometry.MidPoint(FirstPoint, SecondPoint);
      Point point4 = Geometry.MidPoint(FirstPoint, ThirdPoint);
      Vector vector2 = new Vector();
      Vector vector3 = new Vector();
      Vector vector4 = Geometry.VectorRotate(InputVector, 90.0, NormalVector);
      Vector vector5 = Geometry.VectorRotate(vector1, 90.0, NormalVector);
      Point p2_1 = new Point(point3) + (Point) vector4;
      Point p2_2 = new Point(point4) + (Point) vector5;
      Line line1 = new Line(point3, p2_1);
      Line line = new Line(point4, p2_2);
      LineSegment lineSegment = new LineSegment();
      Line line2 = line;
      return Intersection.LineToLine(line1, line2).Point1;
    }

    public static bool IsIntersected(Beam beam, Plane plane)
    {
      GeometricPlane plane1 = new GeometricPlane(plane.Origin, plane.AxisX, plane.AxisY);
      beam.Select();
      return !(Intersection.LineSegmentToPlane(new LineSegment(beam.StartPoint, beam.EndPoint), plane1) == (Point) null);
    }

    public static List<Point> GetEndPoints(ModelObject obj)
    {
      List<Point> pointList = new List<Point>();
      if (obj is Beam)
      {
        Beam beam = obj as Beam;
        if (obj != null)
        {
          beam.Select();
          pointList.Add(beam.StartPoint);
          pointList.Add(beam.EndPoint);
        }
        return pointList;
      }
      if (!(obj is BaseComponent))
        return pointList;
      BaseComponent baseComponent = obj as BaseComponent;
      if (baseComponent != null)
      {
        ModelObjectEnumerator children = baseComponent.GetChildren();
        while (children.MoveNext())
        {
          Beam current = children.Current as Beam;
          if (current != null)
          {
            current.Select();
            pointList.Add(current.StartPoint);
            pointList.Add(current.EndPoint);
            return pointList;
          }
        }
      }
      return pointList;
    }

    public static Point GetClosestPoint(LineSegment ls, Point pt)
    {
      return Geometry.GetClosestPoint(ls.Point1, ls.Point2, pt);
    }

    public static bool IsliesBetweenEnd(LineSegment ls, Point pt)
    {
      Point closestPoint = Geometry.GetClosestPoint(ls.Point1, ls.Point2, pt);
      double point1 = Distance.PointToPoint(ls.Point1, ls.Point2);
      double point2 = Distance.PointToPoint(ls.Point1, closestPoint);
      double point3 = Distance.PointToPoint(ls.Point2, closestPoint);
      double greaterValue = point1;
      return Compare.IsLessThanOrEqual(point2, greaterValue) && Compare.IsLessThanOrEqual(point3, point1);
    }

    public static bool IsliesBetweenEnd(Line line, Point pt)
    {
      Point closestPoint = Geometry.GetClosestPoint(line.Origin, line.Origin + (Point) line.Direction, pt);
      double greaterValue1 = Geometry.VectorLength(line.Direction);
      double point1 = Distance.PointToPoint(line.Origin, closestPoint);
      double point2 = Distance.PointToPoint(line.Origin + (Point) line.Direction, closestPoint);
      double greaterValue2 = greaterValue1;
      return Compare.IsLessThanOrEqual(point1, greaterValue2) && Compare.IsLessThanOrEqual(point2, greaterValue1);
    }

    public static Point GetClosestPoint(Line line, Point pt)
    {
      return Geometry.GetClosestPoint(line.Origin, line.Origin + (Point) line.Direction, pt);
    }

    public static Point GetClosestPoint(Point pt1, Point pt2, Point ptTobeProjected)
    {
      Point point = new Point(pt1);
      Vector onVec = new Vector(pt2 - pt1);
      Vector vector = Geometry.VectorProjection(new Vector(ptTobeProjected - pt1), onVec);
      return point + (Point) vector;
    }

    public static Vector VectorBisector(Vector Vector1, Vector Vector2)
    {
      Vector vector1 = new Vector((Point) Vector1);
      Vector vector2 = new Vector((Point) Vector2);
      vector1.Normalize(1.0);
      vector2.Normalize(1.0);
      return new Vector((Point) vector1 + (Point) vector2);
    }

    public static Line ConvertLineSegmentToLine(LineSegment lineSegment)
    {
      return new Line(lineSegment.Point1, lineSegment.Point2);
    }

    public static LineSegment OffsetLineSegment(
      LineSegment inputLineSegment,
      Vector dirVector,
      double distance)
    {
      dirVector.Normalize(distance);
      return new LineSegment(new Point(inputLineSegment.Point1 + (Point) dirVector), new Point(inputLineSegment.Point2 + (Point) dirVector));
    }

    public static LineSegment Lengthen(
      LineSegment inputLineSegment,
      Point lengtheningSidePoint,
      double distance)
    {
      Vector vector = new Vector(inputLineSegment.Point2 - inputLineSegment.Point1);
      if (distance < 0.0 && distance > 0.0)
        vector.Normalize(distance);
      if (Compare.IsEqual(inputLineSegment.Point2.X, lengtheningSidePoint.X) && Compare.IsEqual(inputLineSegment.Point2.Y, lengtheningSidePoint.Y) && Compare.IsEqual(inputLineSegment.Point2.Z, lengtheningSidePoint.Z))
        inputLineSegment.Point2 += (Point) vector;
      else
        inputLineSegment.Point1 += (Point) vector;
      return inputLineSegment;
    }

    public static Vector GetLengthenVector(
      LineSegment inputLineSegment,
      Point lengtheningSidePoint)
    {
      if (Compare.IsEqual(inputLineSegment.Point2.X, lengtheningSidePoint.X) && Compare.IsEqual(inputLineSegment.Point2.Y, lengtheningSidePoint.Y) && Compare.IsEqual(inputLineSegment.Point2.Z, lengtheningSidePoint.Z))
        return new Vector(inputLineSegment.Point2 - inputLineSegment.Point1);
      return new Vector(inputLineSegment.Point1 - inputLineSegment.Point2);
    }

    public static bool IsPolygonClockwise(Polygon polygon)
    {
      if (polygon.Points.Count < 3)
        return false;
      Point point1 = polygon.Points[0] as Point;
      Point point2 = polygon.Points[1] as Point;
      Point point3 = polygon.Points[2] as Point;
      return point2.X * point3.Y + point1.X * point2.Y + point1.Y * point3.X - (point1.Y * point2.X + point2.Y * point3.X + point1.X * point3.Y) > 0.0;
    }

    public static bool IntersectLineSegmentToLineSegment(
      LineSegment lineSegment1,
      LineSegment lineSegment2,
      ref List<Point> interesectPoints)
    {
      Line line1 = new Line(lineSegment1);
      Line line2 = new Line(lineSegment2);
      LineSegment line3 = Intersection.LineToLine(line1, line2);
      interesectPoints.Clear();
      if (line3 != (LineSegment) null)
      {
        if (Compare.IsEqual(line3.Point1, line3.Point2))
        {
          interesectPoints.Add(line3.Point1);
        }
        else
        {
          interesectPoints.Add(line3.Point1);
          interesectPoints.Add(line3.Point2);
        }
        for (int index = 0; index < interesectPoints.Count; ++index)
        {
          if (!Geometry.IsliesBetweenEnd(line1, interesectPoints[index]) || !Geometry.IsliesBetweenEnd(line2, interesectPoints[index]))
          {
            interesectPoints.RemoveAt(index);
            --index;
          }
        }
      }
      return interesectPoints.Count > 0;
    }

    public static bool GetInnerPoint(Point pt1, Point pt2, Point pt3, ref Point innerPoint)
    {
      if (Geometry.IsCollinear(pt1, pt2, pt3))
        return false;
      List<double> source = new List<double>();
      Vector vector1 = new Vector(pt2 - pt1);
      source.Add(vector1.Normalize());
      Vector vector2 = new Vector(pt3 - pt1);
      source.Add(vector2.Normalize());
      Vector vector3 = new Vector(pt3 - pt2);
      source.Add(vector3.Normalize());
      Vector vector4 = new Vector(pt1 - pt2);
      vector4.Normalize();
      Vector vector5 = new Vector((Point) vector1 + (Point) vector2);
      Vector vector6 = new Vector((Point) vector3 + (Point) vector4);
      double NewLength = source.Max();
      vector5.Normalize(NewLength);
      vector6.Normalize(NewLength);
      LineSegment line = Intersection.LineToLine(new Line(pt1, pt1 + (Point) vector5), new Line(pt2, pt2 + (Point) vector6));
      int num = Compare.IsEqual(line.Length(), 0.0) ? 1 : 0;
      innerPoint = line.Point1;
      return num != 0;
    }

    public static bool GetIntersectionPoints(
      List<Point> pts,
      LineSegment lineSegment,
      out List<Point> interPoints)
    {
      int count = pts.Count;
      interPoints = new List<Point>();
      for (int index = 0; index < count; ++index)
      {
        LineSegment lineSegment1 = new LineSegment(pts[index], pts[(index + 1) % count]);
        List<Point> pointList = new List<Point>();
        LineSegment lineSegment2 = lineSegment;
        ref List<Point> local = ref pointList;
        if (Geometry.IntersectLineSegmentToLineSegment(lineSegment1, lineSegment2, ref local))
          interPoints.AddRange((IEnumerable<Point>) pointList);
      }
      return interPoints.Count > 0;
    }

    public static bool FindExtremePoints(List<Point> pts, out Point pt1, out Point pt2)
    {
      pt1 = new Point(0.0, 0.0, 0.0);
      pt2 = new Point(0.0, 0.0, 0.0);
      if (pts == null && pts.Count < 2)
        return false;
      if (pts.Count == 2)
      {
        pt1 = new Point(pts[0]);
        pt2 = new Point(pts[1]);
        return true;
      }
      int count = pts.Count;
      int index1 = -1;
      int index2 = -1;
      for (int index3 = 0; index3 < count - 1; ++index3)
      {
        for (int index4 = index3 + 1; index4 < count; ++index4)
        {
          if (Compare.IsGreaterThan(Distance.PointToPoint(pts[index3], pts[index4]), 0.0))
          {
            index1 = index3;
            index2 = index4;
          }
        }
      }
      if (index1 <= -1 || index2 <= -1)
        return false;
      pt1 = new Point(pts[index1]);
      pt2 = new Point(pts[index2]);
      return true;
    }
  }
}
