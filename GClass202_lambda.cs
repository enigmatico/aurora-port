using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aurora;

#nullable disable
public partial class RacialSystemSurvey
{
    [CompilerGenerated]
    private bool method_48(JumpPoint120 gclass120_0)
    {
        return gclass120_0.SystemData == this.ActualSystemData &&
               gclass120_0.RacialJumpPointSurveys[this.Race.RaceID].MilitaryRestricted == 0 &&
               gclass120_0.RacialJumpPointSurveys[this.Race.RaceID].Explored == 1;
    }

    [CompilerGenerated]
    private bool method_49(PopulationData gclass146_0)
    {
        return gclass146_0.gclass202_0 == this;
    }

    [CompilerGenerated]
    private bool method_50(AlienRaceInfo gclass110_1)
    {
        return gclass110_1.ActualAlienRace == this.gclass110_0.ActualAlienRace;
    }

    [CompilerGenerated]
    private bool method_51(PopulationData gclass146_0)
    {
        return gclass146_0.gclass202_0 == this;
    }

    [CompilerGenerated]
    private bool method_52(PopulationData gclass146_0)
    {
        if (gclass146_0.gclass202_0 != this)
            return false;
        return gclass146_0.Population > 0.01M || gclass146_0.dictionary_0.Count > 0;
    }

    [CompilerGenerated]
    private bool method_53(PopulationData gclass146_0)
    {
        return gclass146_0.gclass202_0 == this && gclass146_0.Population <= 0.01M && gclass146_0.dictionary_0.Count == 0;
    }

    [CompilerGenerated]
    private bool method_54(FCTMassDriverPacket126 gclass126_0)
    {
        return gclass126_0.System == this.ActualSystemData && gclass126_0.Race == this.Race;
    }

    [CompilerGenerated]
    private bool method_55(GClass214 gclass214_0)
    {
        return gclass214_0.gclass200_0 == this.ActualSystemData && gclass214_0.gclass21_0 == this.Race;
    }

    [CompilerGenerated]
    private bool method_56(GClass65 gclass65_0)
    {
        return gclass65_0.gclass200_0 == this.ActualSystemData && gclass65_0.gclass21_1 == this.Race &&
               gclass65_0.method_5() == AuroraContactStatus.Hostile;
    }

    [CompilerGenerated]
    private bool method_57(FleetData gclass85_1)
    {
        return gclass85_1.System == this;
    }

    [CompilerGenerated]
    private bool method_58(SurveyLocation213 gclass213_0)
    {
        return gclass213_0.list_0.Contains(this.Race.RaceID);
    }

    [CompilerGenerated]
    private bool method_59(Star197 gclass197_0)
    {
        return gclass197_0.SystemData == this.ActualSystemData;
    }

    [CompilerGenerated]
    private bool method_60(FCTShipData40 gclass40_0)
    {
        return gclass40_0.gclass22_0 == this.Race.SelectedClass;
    }

    [CompilerGenerated]
    private bool method_61(GClass65 gclass65_0)
    {
        return gclass65_0.gclass21_1 == this.Race &&
               gclass65_0.gclass21_0 == this.Race.gclass112_0.gclass110_0.ActualAlienRace &&
               gclass65_0.decimal_3 >= this.gclass0_0.GameTime - this.Race.int_47 &&
               gclass65_0.gclass200_0 == this.ActualSystemData;
    }

    [CompilerGenerated]
    private bool method_62(PopulationData gclass146_0)
    {
        return gclass146_0.gclass202_0 == this;
    }

    [CompilerGenerated]
    private bool method_63(JumpPoint120 gclass120_0)
    {
        return gclass120_0.SystemData == this.ActualSystemData &&
               gclass120_0.RacialJumpPointSurveys.ContainsKey(this.Race.RaceID);
    }

    [CompilerGenerated]
    private bool method_64(SurveyLocation213 gclass213_0)
    {
        return gclass213_0.list_0.Contains(this.Race.RaceID);
    }

    [CompilerGenerated]
    private bool method_65(SystemBodyData gclass1_1)
    {
        return gclass1_1.SystemData == this.ActualSystemData;
    }

    [CompilerGenerated]
    private bool method_66(SurveyLocation213 gclass213_0)
    {
        return gclass213_0.list_0.Contains(this.Race.RaceID);
    }

    [CompilerGenerated]
    private bool method_67(SystemBodyData gclass1_1)
    {
        return gclass1_1.SystemData == this.ActualSystemData;
    }

    [CompilerGenerated]
    private bool method_68(PopulationData gclass146_0)
    {
        return gclass146_0.RaceData == this.Race && gclass146_0.gclass202_0 == this;
    }

    [CompilerGenerated]
    [Serializable]
    private sealed class compStatics
    {
        internal SystemData200 method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.LinkedJumpPoint.SystemData;
        }

        internal AuroraSystemProtectionStatus method_1(AlienRaceSystemStatus gclass111_0)
        {
            return gclass111_0.auroraSystemProtectionStatus_0;
        }

        internal Decimal method_2(PopulationData gclass146_0)
        {
            return gclass146_0.method_190();
        }

        internal bool method_3(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0 != null;
        }

        internal Decimal method_4(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.DiscoveredTime;
        }

        internal bool method_5(RacialSystemSurvey gclass202_0)
        {
            return !gclass202_0.method_20();
        }

        internal bool method_6(RacialSystemSurvey gclass202_0)
        {
            return !gclass202_0.method_21();
        }

        internal int method_7(GClass214 gclass214_0)
        {
            return gclass214_0.int_3;
        }

        internal bool method_8(AlienRaceInfo gclass110_0)
        {
            return gclass110_0.bTradeTreaty;
        }

        internal GameRace method_9(AlienRaceInfo gclass110_0)
        {
            return gclass110_0.ActualAlienRace;
        }

        internal bool method_10(PopulationData gclass146_0)
        {
            return gclass146_0.dictionary_4.Values.FirstOrDefault<GClass190>(method_11) != null;
        }

        internal bool method_11(GClass190 gclass190_0)
        {
            return gclass190_0.decimal_1 > 10M;
        }

        internal IEnumerable<FCTShipData40> method_12(FleetData gclass85_0)
        {
            return gclass85_0.method_176();
        }

        internal Decimal method_13(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.decimal_10;
        }

        internal bool method_14(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost == 0M;
        }

        internal bool method_15(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost == 0M;
        }

        internal bool method_16(SystemBodyData gclass1_0)
        {
            return gclass1_0.BodyClass == PlanetBodyClass.Comet;
        }

        internal int method_17(Star197 gclass197_0)
        {
            return gclass197_0.Component;
        }

        internal double method_18(JumpPoint120 gclass120_0)
        {
            return gclass120_0.Distance;
        }

        internal double method_19(JumpPoint120 gclass120_0)
        {
            return gclass120_0.Distance;
        }

        internal bool method_20(SystemBodyData gclass1_0)
        {
            return gclass1_0.BodyClass != PlanetBodyClass.Comet && gclass1_0.BodyClass != PlanetBodyClass.Asteroid;
        }

        internal Decimal method_21(PopulationData gclass146_0)
        {
            return gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters);
        }

        internal SystemData200 method_22(JumpPoint120 gclass120_0)
        {
            return gclass120_0.LinkedJumpPoint.SystemData;
        }

        internal SystemData200 method_23(JumpPoint120 gclass120_0)
        {
            return gclass120_0.LinkedJumpPoint.SystemData;
        }

        internal SystemData200 method_24(JumpPoint120 gclass120_0)
        {
            return gclass120_0.LinkedJumpPoint.SystemData;
        }

        internal double method_25(JumpPoint120 gclass120_0)
        {
            return gclass120_0.Distance;
        }

        internal string method_26(AlienRaceInfo gclass110_0)
        {
            return gclass110_0.AlienRaceName;
        }

        internal Decimal method_27(PopulationData gclass146_0)
        {
            return gclass146_0.decimal_30;
        }
    }

    [CompilerGenerated]
    private sealed class Class1182
    {
        public List<SystemData200> list_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return this.list_0.Contains(gclass202_0.ActualSystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class1183
    {
        public KeyValuePair<AlienRaceInfo, AlienRaceSystemStatus> keyValuePair_0;

        internal bool method_0(AlienRaceInfo gclass110_0)
        {
            return gclass110_0.ActualAlienRace == this.keyValuePair_0.Key.ActualAlienRace;
        }
    }

    [CompilerGenerated]
    private sealed class Class1184
    {
        public RacialSystemSurvey gclass202_0;
        public RacialSystemSurvey gclass202_1;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystemData && gclass120_0.LinkedJumpPoint != null;
        }

        internal RacialSystemSurvey method_1(JumpPoint120 gclass120_0)
        {
            return this.gclass202_1.Race.method_128(gclass120_0.LinkedJumpPoint.SystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class1185
    {
        public double double_0;
        public double double_1;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return Math.Abs(gclass202_0.XCoord - this.double_0) < AuroraUtils.int_1 &&
                   Math.Abs(gclass202_0.YCoord - this.double_1) < AuroraUtils.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1186
    {
        public RacialSystemSurvey gclass202_0;
        public RacialSystemSurvey gclass202_1;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystemData &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass202_0.Race.RaceID);
        }

        internal bool method_1(JumpPoint120 gclass120_0)
        {
            return gclass120_0.RacialJumpPointSurveys[this.gclass202_0.Race.RaceID].Explored == 1 &&
                   gclass120_0.LinkedJumpPoint != null;
        }

        internal bool method_2(JumpPoint120 gclass120_0)
        {
            return gclass120_0.LinkedJumpPoint.SystemData == this.gclass202_1.ActualSystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class1187
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || gclass146_0.ColonistDestinationSetting != PopColonistSetting.Source)
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || !(gclass146_0.Population > AuroraUtils.decimal_12))
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.bIsCapital;
        }
    }

    [CompilerGenerated]
    private sealed class Class1188
    {
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal double method_0(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystemData.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class1189
    {
        public List<GameRace> list_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return this.list_0.Contains(gclass146_0.RaceData);
        }
    }

    [CompilerGenerated]
    private sealed class Class1190
    {
        public GClass194 gclass194_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass202_0.ActualSystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class1191
    {
        public Decimal decimal_0;
        public List<SystemBodyData> list_0;
        public RacialSystemSurvey.Class1190 class1190_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost >= 0M && gclass1_0.ColonyCost < 2M * this.decimal_0 &&
                   gclass1_0.Gravity >= this.class1190_0.gclass194_0.double_7;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost >= 0M && gclass1_0.ColonyCost < 2M * this.decimal_0;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost >= 2M * this.decimal_0 && gclass1_0.ColonyCost < 3M * this.decimal_0 &&
                   gclass1_0.Gravity >= this.class1190_0.gclass194_0.double_7;
        }

        internal bool method_3(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost >= 2M * this.decimal_0 && gclass1_0.ColonyCost < 3M * this.decimal_0;
        }

        internal bool method_4(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost >= 3M * this.decimal_0 && gclass1_0.ColonyCost < 5M * this.decimal_0 &&
                   gclass1_0.Gravity >= this.class1190_0.gclass194_0.double_7;
        }

        internal bool method_5(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost >= 3M * this.decimal_0 && gclass1_0.ColonyCost < 5M * this.decimal_0;
        }

        internal bool method_6(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost >= 0M && gclass1_0.MaxColonyCost < 2M * this.decimal_0 &&
                   gclass1_0.Gravity >= this.class1190_0.gclass194_0.double_7;
        }

        internal bool method_7(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost >= 0M && gclass1_0.MaxColonyCost < 2M * this.decimal_0;
        }

        internal bool method_8(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost >= 2M * this.decimal_0 && gclass1_0.MaxColonyCost < 3M * this.decimal_0 &&
                   gclass1_0.Gravity >= this.class1190_0.gclass194_0.double_7;
        }

        internal bool method_9(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost >= 2M * this.decimal_0 && gclass1_0.MaxColonyCost < 3M * this.decimal_0;
        }

        internal bool method_10(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost >= 3M * this.decimal_0 && gclass1_0.MaxColonyCost < 5M * this.decimal_0 &&
                   gclass1_0.Gravity >= this.class1190_0.gclass194_0.double_7;
        }

        internal bool method_11(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost >= 3M * this.decimal_0 && gclass1_0.MaxColonyCost < 5M * this.decimal_0;
        }

        internal bool method_12(GClass215 gclass215_0)
        {
            return gclass215_0.gclass21_0 == this.class1190_0.gclass202_0.Race &&
                   this.list_0.Contains(gclass215_0.gclass1_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1192
    {
        public RacialSystemSurvey gclass202_0;
        public bool bool_0;
        public bool bool_1;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystemData &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass202_0.Race.RaceID);
        }

        internal bool method_1(JumpPoint120 gclass120_0)
        {
            if (gclass120_0.RacialJumpPointSurveys[this.gclass202_0.Race.RaceID].Explored != 1 ||
                gclass120_0.LinkedJumpPoint == null)
                return false;
            return this.bool_0 || gclass120_0.JumpGateStrength > 0;
        }

        internal bool method_2(RacialSystemSurvey gclass202_1)
        {
            return !gclass202_1.bNoAutoRoute || !this.bool_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class1193
    {
        public List<SystemData200> list_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            RacialSystemSurvey.Class1194 class1194 = new RacialSystemSurvey.Class1194();
            class1194.gclass202_0 = gclass202_0;
            return this.list_0.Any<SystemData200>(class1194.method_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1194
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(SystemData200 gclass200_0)
        {
            return gclass200_0 == this.gclass202_0.ActualSystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class1195
    {
        public RacialSystemSurvey gclass202_0;
        public bool bool_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystemData &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass202_0.Race.RaceID);
        }

        internal bool method_1(JumpPoint120 gclass120_0)
        {
            if (gclass120_0.RacialJumpPointSurveys[this.gclass202_0.Race.RaceID].Explored != 1 ||
                gclass120_0.LinkedJumpPoint == null)
                return false;
            return this.bool_0 || gclass120_0.JumpGateStrength > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1196
    {
        public List<SystemData200> list_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            RacialSystemSurvey.Class1197 class1197 = new RacialSystemSurvey.Class1197();
            class1197.gclass202_0 = gclass202_0;
            return this.list_0.Any<SystemData200>(class1197.method_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1197
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(SystemData200 gclass200_0)
        {
            return gclass200_0 == this.gclass202_0.ActualSystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class1198
    {
        public RacialSystemSurvey gclass202_0;
        public bool bool_0;
        public GEnum96 genum96_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystemData &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass202_0.Race.RaceID);
        }

        internal bool method_1(JumpPoint120 gclass120_0)
        {
            if (gclass120_0.RacialJumpPointSurveys[this.gclass202_0.Race.RaceID].Explored != 1 ||
                gclass120_0.LinkedJumpPoint == null)
                return false;
            return this.bool_0 || gclass120_0.JumpGateStrength > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1199
    {
        public List<SystemData200> list_0;
        public RacialSystemSurvey.Class1198 class1198_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            RacialSystemSurvey.Class1200 class1200 = new RacialSystemSurvey.Class1200();
            class1200.gclass202_0 = gclass202_0;
            return this.list_0.Any<SystemData200>(class1200.method_0) &&
                   class1200.gclass202_0.gclass3_0.genum96_0 <= this.class1198_0.genum96_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1200
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(SystemData200 gclass200_0)
        {
            return gclass200_0 == this.gclass202_0.ActualSystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class1201
    {
        public List<SystemBodyData> list_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(GClass215 gclass215_0)
        {
            return gclass215_0.gclass21_0 == this.gclass202_0.Race && this.list_0.Contains(gclass215_0.gclass1_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1202
    {
        public Star197 gclass197_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.StarData == this.gclass197_0 && !gclass1_0.IsFixedBody;
        }
    }

    [CompilerGenerated]
    private sealed class Class1203
    {
        public List<SystemBodyData> list_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(GClass215 gclass215_0)
        {
            return gclass215_0.gclass21_0 == this.gclass202_0.Race && this.list_0.Contains(gclass215_0.gclass1_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1204
    {
        public RacialSystemSurvey gclass202_0;
        public GameRace gclass21_0;
        public Func<AlienRaceInfo, bool> func_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystemData;
        }

        internal bool method_1(AlienRaceInfo gclass110_0)
        {
            return gclass110_0.ActualAlienRace == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1205
    {
        public JumpPoint120 gclass120_0;

        internal double method_0(SurveyLocation213 gclass213_0)
        {
            return Math.Pow(gclass213_0.XCoord - this.gclass120_0.XCoord, 2.0) +
                   Math.Pow(gclass213_0.YCoord - this.gclass120_0.YCoord, 2.0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1206
    {
        public double double_0;

        internal bool method_0(SurveyLocation213 gclass213_0)
        {
            return Math.Pow(gclass213_0.XCoord, 2.0) + Math.Pow(gclass213_0.YCoord, 2.0) > this.double_0;
        }
    }
}