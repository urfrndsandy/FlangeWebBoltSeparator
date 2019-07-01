// Decompiled with JetBrains decompiler
// Type: FlangeWebBoltSeparator.BoltSeparator
// Assembly: FlangeWebBoltSeparator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22369202-C8FF-4769-AE92-AAA858CB069E
// Assembly location: E:\Data_1\References\FlangeWebBoltSeparator.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Tekla.Structures;
using Tekla.Structures.CustomPropertyPlugin;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.India.Common;
using Tekla.Structures.Model;

namespace FlangeWebBoltSeparator
{
  [Export(typeof (ICustomPropertyPlugin))]
  [ExportMetadata("CustomProperty", "CUSTOM.BOLTSEPARATOR")]
  public class BoltSeparator : ICustomPropertyPlugin
  {
    private Tekla.Structures.Model.Model model;
    private const string deafultValue = "UNKNOWN";
    private const string flangeBoltValue = "FLANGEBOLT";
    private const string webBoltValue = "WEBBOLT";

    public double GetDoubleProperty(int objectId)
    {
      throw new NotImplementedException();
    }

    public int GetIntegerProperty(int objectId)
    {
      try
      {
        string str = this.CheckPart(objectId);
        if (str == "UNKNOWN")
          return 0;
        if (str == "FLANGEBOLT")
          return 1;
        return str == "WEBBOLT" ? 2 : 0;
      }
      catch (Exception ex)
      {
        return 0;
      }
    }

    public string GetStringProperty(int objectId)
    {
      return this.CheckPart(objectId);
    }

    private string CheckPart(int objectId)
    {
      string str = "UNKNOWN";
      try
      {
        if (this.model == null)
          this.model = new Tekla.Structures.Model.Model();
        BoltGroup boltGroup = this.model.SelectModelObject(new Identifier(objectId)) as BoltGroup;
        if (boltGroup == null)
          return str;
        return this.SeparateBolt(boltGroup);
      }
      catch (Exception ex)
      {
        return str;
      }
    }

    private string SeparateBolt(BoltGroup boltGroup)
    {
      string str = "UNKNOWN";
      List<Part> connectedParts = this.GetConnectedParts(boltGroup);
      if (connectedParts == null || connectedParts.Count <= 0)
        return str;
      return this.CompareCoordinates(boltGroup, connectedParts) ? "FLANGEBOLT" : "WEBBOLT";
    }

    private bool CompareCoordinates(BoltGroup boltGroup, List<Part> connectedItems)
    {
      CoordinateSystem coordinateSystem = boltGroup.GetCoordinateSystem();
      Vector Vector2 = coordinateSystem.AxisX.Cross(coordinateSystem.AxisY);
      bool flag = false;
      foreach (ModelObject connectedItem in connectedItems)
      {
        if (Geometry.VectorIsParallel(connectedItem.GetCoordinateSystem().AxisY, Vector2))
        {
          flag = true;
          return flag;
        }
      }
      return flag;
    }

    private List<Part> GetConnectedParts(BoltGroup boltGroup)
    {
      List<Part> partList = new List<Part>();
      if (boltGroup.PartToBoltTo != null)
      {
        Part partToBoltTo = boltGroup.PartToBoltTo;
        if (partToBoltTo != null && this.FilterProfile(partToBoltTo))
          partList.Add(partToBoltTo);
        Part partToBeBolted = boltGroup.PartToBeBolted;
        if (partToBeBolted != null && this.FilterProfile(partToBeBolted))
          partList.Add(partToBeBolted);
        ArrayList otherPartsToBolt = boltGroup.OtherPartsToBolt;
        if (otherPartsToBolt != null)
        {
          foreach (Part part in otherPartsToBolt)
          {
            if (this.FilterProfile(part))
              partList.Add(part);
          }
        }
      }
      return partList;
    }

    private bool FilterProfile(Part part)
    {
      bool flag = false;
      string empty = string.Empty;
      part.GetReportProperty("PROFILE_TYPE", ref empty);
      if (empty == string.Empty || !(empty == "I") && !(empty == "C") && (!(empty == "T") && !(empty == "U")))
        return flag;
      flag = true;
      return flag;
    }
  }
}
