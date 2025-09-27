// Decompiled with JetBrains decompiler
// Type: GClass9
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class OperationalGroup
{
    public List<OperationalGroupElement> OperationalGroupElementList = new List<OperationalGroupElement>();
    public StandingOrderDefinition gclass136_0;
    public StandingOrderDefinition gclass136_1;
    public TechSystem gclass164_0;
    public GEnum104 genum104_0;
    public OperationalGroupID OperationalGroupId;
    public int int_0;
    public int int_1;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public string string_0;

    public List<RaceOperationalGroupElement> method_0(GameRace gclass21_0)
    {
        try
        {
            return gclass21_0.OperationalGroupElements.Where<RaceOperationalGroupElement>(gclass11_0 => gclass11_0.Element == this).ToList<RaceOperationalGroupElement>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 137);
            return null;
        }
    }

    public RaceOperationalGroupElement method_1(GameRace gclass21_0)
    {
        try
        {
            return gclass21_0.OperationalGroupElements.FirstOrDefault<RaceOperationalGroupElement>(gclass11_0 =>
                gclass11_0.Element == this && gclass11_0.KeyElement);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 137);
            return null;
        }
    }

    public int method_2(GameRace gclass21_0, AutomatedClassDesign gclass14_0)
    {
        try
        {
            return gclass21_0.OperationalGroupElements
                .Where<RaceOperationalGroupElement>(gClass11 => gClass11.Element == this && gClass11.AutomatedClassDesign == gclass14_0)
                .Sum<RaceOperationalGroupElement>(gclass11_0 => gclass11_0.NumShips);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3294);
            return 0;
        }
    }
}