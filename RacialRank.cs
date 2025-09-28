// Decompiled with JetBrains decompiler
// Type: GClass61
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
// TODO : Probably this object is commander position
public class RacialRank
{
    public GameRace Race;
    public AuroraCommanderType CommanderType;
    public int RankID;
    public int RankNum;
    public int int_2;
    public int int_3;
    public string RankAbbreviation;
    public List<Commander> list_0 = new List<Commander>();

    public string RankName { get; set; }

    public string method_0() => this.RankAbbreviation == "" ? this.RankName : this.RankAbbreviation;

    public RacialRank method_1()
    {
        try
        {
            return this.Race.RacialRankDictionary.Values.Where<RacialRank>(gclass61_0 =>
                    gclass61_0.CommanderType == this.CommanderType &&
                    gclass61_0.RankNum == this.RankNum - 1)
                .FirstOrDefault<RacialRank>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 412);
            return null;
        }
    }

    public RacialRank method_2(int int_4)
    {
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.Race.RacialRankDictionary.Values.FirstOrDefault(
                gClass61 => gClass61.CommanderType == this.CommanderType
                            && gClass61.RankNum == this.RankNum + int_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 413);
            return null;
        }
    }

    public RacialRank method_3()
    {
        try
        {
            return this.Race.RacialRankDictionary.Values.Where<RacialRank>(gclass61_0 =>
                    gclass61_0.CommanderType == this.CommanderType &&
                    gclass61_0.RankNum == this.RankNum + 1)
                .FirstOrDefault<RacialRank>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 414);
            return null;
        }
    }
}