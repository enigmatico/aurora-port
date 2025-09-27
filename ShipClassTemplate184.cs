// Decompiled with JetBrains decompiler
// Type: GClass184
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;

#nullable disable
public class ShipClassTemplate184
{
    public List<ClassComponentTemplate186> ComponentTemplateList = new List<ClassComponentTemplate186>();
    public int ShipClassTemplateID;
    public int HullID;
    public int ArmourThickness = 1;
    public int Collier;
    public int ConscriptOnly;
    public int FuelTanker;
    public int SupplyShip;
    public int NoArmour;
    public int NoOfficers;
    public int SeniorCO;
    public int MinimumFuel;
    public int MinimumSupplies;
    public int RefuelPriority = 5;
    public int ResupplyPriority = 5;
    public int PDProtectionPriority;
    public int CommanderPriority;
    public int MaintPriority;
    public Decimal PlannedDeployment = 3M;
    public string ShipClassTemplateName = "";
}