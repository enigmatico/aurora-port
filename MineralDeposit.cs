// Decompiled with JetBrains decompiler
// Type: GClass124
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class MineralDeposit
{
    public AuroraElement MaterialID;
    public int SystemBodyID;
    public Decimal Amount;
    public Decimal Accessibility;
    public Decimal HalfOriginalAmount;
    public Decimal OriginalAcc;

    public string method_0()
    {
        return $"{string.Format("{0:0,0}", this.Amount)}  Acc {this.Accessibility.ToString()}";
    }
}