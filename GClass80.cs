// Decompiled with JetBrains decompiler
// Type: GClass80
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass80
{
    public List<WreckComponents> list_0 = new List<WreckComponents>();
    public AllMineralsValue gclass123_0;

    public void method_0(ShipComponent gclass230_0, int int_0)
    {
        WreckComponents gclass235 = this.list_0.FirstOrDefault(v => v.Component == gclass230_0);
        if (gclass235 == null)
        {
            // ISSUE: reference to a compiler-generated field
            this.list_0.Add(new WreckComponents()
            {
                Component = gclass230_0,
                Amount = int_0
            });
        }
        else
            gclass235.Amount += int_0;
    }
}