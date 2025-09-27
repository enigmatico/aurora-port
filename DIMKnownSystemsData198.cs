// Decompiled with JetBrains decompiler
// Type: GClass198
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;

#nullable disable
public class DIMKnownSystemsData198
{
    public Dictionary<int, StellarType> dictionary_0 = new Dictionary<int, StellarType>();
    public int KnownSystemID;
    public int int_1;
    public int C3OrbitType;
    public int C4OrbitType;
    public double C2Orbit;
    public double C3Orbit;
    public double C4Orbit;
    public double X;
    public double Y;
    public double Z;
    public double Distance;
    public double double_7;
    public double double_8;
    public double double_9;
    public double double_10;
    public string Name;
    public string ConstellationName;
    public bool bool_0;
    public bool bool_1;

    public string method_0(int int_4)
    {
        try
        {
            return this.ConstellationName.Length > 1 && int_4 == 1 ? this.ConstellationName : this.Name;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3367);
            return this.Name;
        }
    }
}