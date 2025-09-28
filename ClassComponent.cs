// Decompiled with JetBrains decompiler
// Type: GClass228
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
/// <summary>
/// 배 설계 안에 지정된 부품1종과 그 구성 상태 정보
/// </summary>
public class ClassComponent
{
    public ShipComponent Component;
    public int ComponentID;
    public int ClassID;
    public int ChanceToHit;
    public int ElectronicCTH;
    public Decimal NumComponent;
    public Decimal decimal_1;
    public int int_4;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public Decimal decimal_5;
    public Decimal decimal_6;
    public Decimal decimal_7;

    public string Description { get; set; }

    public Decimal method_0() => this.Component.decimal_3 * this.NumComponent;

    public ClassComponent method_1()
    {
        try
        {
            ClassComponent gclass228 = new ClassComponent();
            return (ClassComponent)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2679);
            return null;
        }
    }
}