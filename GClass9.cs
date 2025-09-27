// Decompiled with JetBrains decompiler
// Type: GClass9
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass9
{
    public List<OperationalGroupElement> OperationalGroupElementList = new List<OperationalGroupElement>();
    public StandingOrderDefinition gclass136_0;
    public StandingOrderDefinition gclass136_1;
    public TechData164 gclass164_0;
    public GEnum104 genum104_0;
    public OperationalGroup genum105_0;
    public int int_0;
    public int int_1;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public string string_0;

    public List<GClass11> method_0(FCTRaceRecordC21 gclass21_0)
    {
        try
        {
            return gclass21_0.list_0.Where<GClass11>(gclass11_0 => gclass11_0.gclass9_0 == this).ToList<GClass11>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 137);
            return null;
        }
    }

    public GClass11 method_1(FCTRaceRecordC21 gclass21_0)
    {
        try
        {
            return gclass21_0.list_0.FirstOrDefault<GClass11>(gclass11_0 =>
                gclass11_0.gclass9_0 == this && gclass11_0.bool_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 137);
            return null;
        }
    }

    public int method_2(FCTRaceRecordC21 gclass21_0, AutomatedClassDesignData gclass14_0)
    {
        try
        {
            return gclass21_0.list_0
                .Where<GClass11>(gClass11 => gClass11.gclass9_0 == this && gClass11.gclass14_0 == gclass14_0)
                .Sum<GClass11>(gclass11_0 => gclass11_0.int_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3294);
            return 0;
        }
    }
}