// Decompiled with JetBrains decompiler
// Type: GClass194
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Windows.Forms;

#nullable disable
// TODO: Probably species-related. maybe species itself
public class Species
{
    private GClass0 gclass0_0;
    public Dictionary<int, GClass195> dictionary_0;
    public SystemBodyData gclass1_0;
    public TechSystem gclass164_0;
    public Species gclass194_0;
    public AtmosphericGasDefinition gclass223_0;
    public SpecialNPRIDs genum6_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public int int_7;
    public int int_8;
    public int int_9;
    public int int_10;
    public int int_11 = 21;
    public double double_0;
    public double double_1;
    public double double_2;
    public double double_3;
    public double double_4;
    public double double_5;
    public double double_6;
    public double double_7;
    public double double_8;
    public double double_9;
    public double double_10;
    public double double_11;
    public double double_12;
    public Decimal decimal_0 = 1M;
    public Decimal decimal_1 = 1M;
    public Decimal decimal_2 = 1M;
    public Decimal decimal_3 = 1M;
    public string RaceImageFileName;
    public Decimal decimal_4;
    public Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition> dictionary_1 = new Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition>();

    public string SpeciesName { get; set; }

    public Species(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(Label label_0, Label label_1, Label label_2, Label label_3, Label label_4)
    {
        try
        {
            Label label1 = label_0;
            double num1 = Math.Round(this.double_7, 3);
            string str1 = num1.ToString();
            num1 = Math.Round(this.double_8, 3);
            string str2 = num1.ToString();
            string str3 = $"{str1}  to  {str2}";
            label1.Text = str3;
            Label label2 = label_2;
            double num2 = Math.Round(this.double_12 - AuroraUtils.int_17, 2);
            string str4 = num2.ToString();
            num2 = Math.Round(this.double_11 - AuroraUtils.int_17, 2);
            string str5 = num2.ToString();
            string str6 = $"{str4}  to  {str5}";
            label2.Text = str6;
            Label label3 = label_1;
            double num3 = Math.Round(this.double_9, 3);
            string str7 = num3.ToString();
            num3 = Math.Round(this.double_10, 3);
            string str8 = num3.ToString();
            string str9 = $"{str7}  to  {str8}";
            label3.Text = str9;
            label_4.Text = Math.Round(this.double_2, 2).ToString() + " atm";
            label_3.Text = this.gclass223_0.Name;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2932);
        }
    }
}