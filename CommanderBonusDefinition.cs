// Decompiled with JetBrains decompiler
// Type: GClass50
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class CommanderBonusDefinition
{
    public CommanderBonusType CommanderBonusType;
    public int DisplayOrder;
    public Decimal MaximumBonus;
    public string BonusAbbrev;
    public bool Percentage;
    public bool Naval;
    public bool Ground;
    public bool Civilian;
    public bool Scientist;

    public string Description { get; set; }
}