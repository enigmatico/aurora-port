// Decompiled with JetBrains decompiler
// Type: GClass74
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
/// <summary>
/// 항모 클래스에 할당된 기본 전투기 클래스 상태를 나타내는 클래스
/// </summary>
public class ClassFighterTemplate
{
    public int Number;
    public ShipClass FighterClass;

    public string Combined { get; set; }

    public string method_0()
    {
        return
            string.Format("{0}x {1} {2}   Speed: {3} km/s    Size: {4}{5}", this.Number.ToString(),
                this.FighterClass.ClassName, this.FighterClass.ShipHull.Description, this.FighterClass.MaxSpeed.ToString(),
                AuroraUtils.FormatNumberToDigits(this.FighterClass.Size, 2), Environment.NewLine);
    }
}