// Decompiled with JetBrains decompiler
// Type: GClass161
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Linq;

#nullable disable
public class ResearchProject
{
    private GClass0 gclass0_0;
    public GameRace gclass21_0;
    public PopulationData gclass146_0;
    public TechSystem gclass164_0;
    public GClass55 gclass55_0;
    public ResearchFieldData gclass162_0;
    public int int_0;
    public int ResearchProjectID;
    public Decimal decimal_0;
    public bool bool_0;
    public bool bool_1;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public string string_0 = "";

    public ResearchProject(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            PausedResearch gclass167 = new PausedResearch();
            gclass167.gclass164_0 = this.gclass164_0;
            gclass167.PointsAccumulated = this.gclass164_0.int_4 - (int)this.decimal_0;
            if (this.gclass164_0.int_4 - (int)this.decimal_0 > 0)
                this.gclass21_0.PausedResearches.Add(gclass167);
            foreach (ResearchQueue gclass166 in this.gclass21_0.ResearchQueues
                         .Where<ResearchQueue>(gclass166_0 => gclass166_0.CurrentProject == this).ToList<ResearchQueue>())
                this.gclass21_0.ResearchQueues.Remove(gclass166);
            this.gclass146_0.dictionary_1.Remove(this.ResearchProjectID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2604);
        }
    }
}