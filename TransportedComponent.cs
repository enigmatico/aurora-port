// Decompiled with JetBrains decompiler
// Type: GClass73
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class TransportedComponent
{
    public ShipComponent Component;
    public PopulationData PopOrigin;
    public int int_0;
    public Decimal Amount;
    public bool bool_0;

    public string Combined { get; set; }

    public string method_0()
    {
        return $"{this.Amount.ToString()}x {this.Component.Name}{Environment.NewLine}";
    }
}