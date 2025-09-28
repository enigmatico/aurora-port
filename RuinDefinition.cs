// Decompiled with JetBrains decompiler
// Type: GClass174
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class RuinDefinition
{
    private sealed class Class1151
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystem == this.gclass1_0.SystemData;
        }

        internal bool method_1(SystemBodyData gclass1_1)
        {
            return gclass1_1.SystemData == this.gclass1_0.SystemData;
        }
    }


    private sealed class Class1152
    {
        public GameRace gclass21_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass21_0;
        }

        internal bool method_1(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.PrecursorMechBattalion;
        }

        internal bool method_2(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.PrecursorDefenceRegiment;
        }
    }


    private sealed class Class1153
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystem == this.gclass1_0.SystemData;
        }

        internal bool method_1(SystemBodyData gclass1_1)
        {
            return gclass1_1.SystemData == this.gclass1_0.SystemData;
        }
    }


    private sealed class Class1154
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;
        public PopulationData gclass146_0;

        internal bool method_0(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.Race == this.gclass21_0 && gclass83_0.ParentAdminCommand == null;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass21_0;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.System == this.gclass202_0 &&
                   gclass40_0.gclass22_0.MaxSpeed > 1;
        }

        internal bool method_3(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.System == this.gclass202_0;
        }

        internal bool method_4(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_5(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.System == this.gclass202_0;
        }

        internal bool method_6(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.System == this.gclass202_0;
        }

        internal bool method_7(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0;
        }

        internal bool method_8(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.gclass202_0 == this.gclass202_0;
        }
    }

    private GClass0 gclass0_0;
    public int RuinID;
    public int MaxChance;
    public int NoDefenders;
    public int FactoriesBase;
    public int FactoriesRandom;
    public int DefenceBases;
    public int OffenceBases;
    public int Fleet;
    public int Squadron;
    public int Patrol;
    public int STO;
    public int Regiment;
    public int FixedDSTS;
    public int RandomDSTS;
    public Decimal EmergenceModifier;
    public string Description;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;

    public RuinDefinition(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public int method_0(int int_14)
    {
        try
        {
            if (this.gclass0_0.EnhancedPrecursors == 1)
                int_14 = (int)(int_14 * 1.5);
            int num1 = (int)Math.Floor(int_14 / 100.0);
            int num2 = (int)(int_14 % 100.0);
            if (AuroraUtils.GetRandomInteger(100) <= num2)
                ++num1;
            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2658);
            return 0;
        }
    }

    public void method_1(
        GameRace gclass21_0,
        SystemBodyData gclass1_0,
        OperationalGroup gclass9_0,
        GroundUnitFormationTemplateData gclass102_0,
        int int_14,
        List<ShipClass> list_0)
    {
        try
        {
            Decimal num1 = this.decimal_3;
            if (gclass9_0 != null)
            {
                Decimal num2 = 0.01M * (AuroraUtils.GetRandomInteger(300) + AuroraUtils.GetRandomInteger(300)) *
                               AuroraUtils.decimal_29;
                Decimal num3 = 1M;
                if (gclass9_0.genum104_0 == GEnum104.const_4)
                    num3 = 3M;
                else if (gclass9_0.genum104_0 == GEnum104.const_19)
                    num3 = 2M;
                else if (gclass9_0.bool_1)
                    num3 = 1.5M;
                num1 = this.decimal_3 + num2 / num3;
            }

            this.gclass0_0.list_8.Add(new GClass172()
            {
                gclass1_0 = gclass1_0,
                gclass9_0 = gclass9_0,
                gclass102_0 = gclass102_0,
                int_0 = int_14,
                decimal_0 = num1
            });
            if (gclass9_0 == null)
                return;
            GClass173 gclass173 = this.gclass0_0.method_56(gclass21_0, gclass9_0, list_0, int_14);
            this.decimal_1 += gclass173.decimal_0;
            this.decimal_2 += gclass173.decimal_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3873);
        }
    }

    public void method_2(SystemBodyData gclass1_0_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RuinDefinition.Class1151 class1151 = new RuinDefinition.Class1151();
        // ISSUE: reference to a compiler-generated field
        class1151.gclass1_0 = gclass1_0_1;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RuinDefinition.Class1152 class1152 = new RuinDefinition.Class1152();
            if (AuroraUtils.GetRandomInteger(100) < this.NoDefenders)
                return;
            this.decimal_1 = 0M;
            this.decimal_2 = 0M;
            this.decimal_3 = this.gclass0_0.GameTime + 0.01M *
                (AuroraUtils.GetRandomInteger(1000) + AuroraUtils.GetRandomInteger(1000)) * AuroraUtils.decimal_29 /
                this.EmergenceModifier;
            // ISSUE: reference to a compiler-generated field
            class1152.gclass21_0 =
                this.gclass0_0.GameRaces.Values.FirstOrDefault<GameRace>(gclass21_0 =>
                    gclass21_0.SpecialNPRID == SpecialNPRIDs.Precursor);
            // ISSUE: reference to a compiler-generated method
            List<ShipClass> list = this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class1152.method_0)
                .ToList<ShipClass>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            if (class1152.gclass21_0.RacialSystemDictionary.Values.FirstOrDefault<RacialSystemSurvey>(class1151.method_0) == null)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1152.gclass21_0.method_262(class1151.gclass1_0.SystemData, 1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1152.gclass21_0.method_263(class1151.gclass1_0.SystemData, class1152.gclass21_0.SystemTheme, "",
                    true);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1152.gclass21_0.method_258(class1151.gclass1_0.SystemData, false);
            }

            // ISSUE: reference to a compiler-generated field
            class1152.gclass21_0.DesignDoctrine.NameList_3.OrderBy<GClass12, int>(gclass12_0 => gclass12_0.int_0)
                .ToList<GClass12>();
            int int_14_1 = this.method_0(this.DefenceBases);
            OperationalGroup gclass9_0_1 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.OrbitalDefences];
            if (gclass9_0_1 != null && int_14_1 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_1, null, int_14_1, list);
            }

            int int_14_2 = this.method_0(this.OffenceBases);
            OperationalGroup gclass9_0_2 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.OribitalMissileBase];
            if (gclass9_0_2 != null && int_14_2 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_2, null, int_14_2, list);
            }

            int int_14_3 = this.method_0(this.Fleet);
            OperationalGroup gclass9_0_3 = AuroraUtils.GetRandomInteger(4) != 1
                ? this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.MissileBattleFleet]
                : this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.BeamOnlyBattleFleet];
            if (gclass9_0_3 != null && int_14_3 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_3, null, int_14_3, list);
                int int_14_4 = this.method_0((int)Math.Floor(this.Fleet / 2.0));
                OperationalGroup gclass9_0_4 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.JumpPointDefence];
                if (gclass9_0_4 != null && int_14_4 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_4, null, int_14_4, list);
                }
            }

            int int_14_5 = this.method_0(this.Squadron);
            OperationalGroup gclass9_0_5 = AuroraUtils.GetRandomInteger(4) != 1
                ? this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.MissileBattleSquadron]
                : this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.BeamOnlyBattleSquadron];
            if (gclass9_0_5 != null && int_14_5 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_5, null, int_14_5, list);
                int int_14_6 = this.method_0((int)Math.Floor(this.Squadron / 2.0));
                OperationalGroup gclass9_0_6 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.JumpPointDefenceSmall];
                if (gclass9_0_6 != null && int_14_6 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_6, null, int_14_6, list);
                }
            }

            int int_14_7 = this.method_0(this.Patrol);
            OperationalGroup gclass9_0_7 = AuroraUtils.GetRandomInteger(4) != 1
                ? this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.FACHunterSquadron]
                : this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.BeamOnlyDDSquadron];
            if (gclass9_0_7 != null && int_14_7 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_7, null, int_14_7, list);
            }

            int int_14_8 = this.method_0(this.Patrol);
            OperationalGroup gclass9_0_8 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.FACFlotilla];
            if (gclass9_0_8 != null && int_14_8 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_8, null, int_14_8, list);
            }

            if (this.decimal_1 > 100000M)
            {
                int num = (int)Math.Floor(this.decimal_1 / 100000M);
                OperationalGroup gclass9_0_9 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.Scout];
                if (gclass9_0_9 != null && int_14_8 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_9, null, int_14_8, list);
                }
            }

            // ISSUE: reference to a compiler-generated method
            if (this.decimal_2 > 5000000M && this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(class1151.method_1)
                    .Where<SystemBodyData>(gclass1_0_2 =>
                        gclass1_0_2.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                        gclass1_0_2.BodyTypeId == AuroraSystemBodyType.Superjovian)
                    .Where<SystemBodyData>(gclass1_0_3 =>
                        gclass1_0_3.MineralDeposits.ContainsKey(AuroraElement.Sorium))
                    .OrderByDescending<SystemBodyData, Decimal>(gclass1_0_4 =>
                        gclass1_0_4.MineralDeposits[AuroraElement.Sorium].Accessibility)
                    .FirstOrDefault<SystemBodyData>() != null)
            {
                int num = (int)Math.Floor(this.decimal_2 / 5000000M);
                OperationalGroup gclass9_0_10 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.PrecursorHarvesterGroup];
                if (gclass9_0_10 != null && int_14_8 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_10, null, int_14_8, list);
                }

                OperationalGroup gclass9_0_11 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.Tanker];
                if (gclass9_0_11 != null && int_14_8 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_11, null, int_14_8, list);
                }
            }

            int int_14_9 = this.method_0(this.Regiment);
            int num1 = this.method_0(this.Regiment);
            if (int_14_9 > 0)
            {
                // ISSUE: reference to a compiler-generated method
                GroundUnitFormationTemplateData gclass102_0 =
                    this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(class1152.method_1);
                if (gclass102_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(class1152.gclass21_0, class1151.gclass1_0, null, gclass102_0, int_14_9, null);
                }
            }

            if (num1 <= 0)
                return;
            // ISSUE: reference to a compiler-generated method
            GroundUnitFormationTemplateData gclass102_0_1 =
                this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(class1152.method_2);
            if (gclass102_0_1 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.method_1(class1152.gclass21_0, class1151.gclass1_0, null, gclass102_0_1, int_14_9, null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3884);
        }
    }

    public void method_3(SystemBodyData gclass1_0_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RuinDefinition.Class1153 class1153 = new RuinDefinition.Class1153();
        // ISSUE: reference to a compiler-generated field
        class1153.gclass1_0 = gclass1_0_1;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RuinDefinition.Class1154 class1154 = new RuinDefinition.Class1154();
            if (this.gclass0_0.EnhancedPrecursors == 1)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_2(class1153.gclass1_0);
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1154.gclass21_0 =
                    this.gclass0_0.GameRaces.Values.FirstOrDefault<GameRace>(gclass21_0 =>
                        gclass21_0.SpecialNPRID == SpecialNPRIDs.Precursor);
                // ISSUE: reference to a compiler-generated field
                Species gclass194_1 = class1154.gclass21_0.method_165(SpecialNPRIDs.Precursor);
                // ISSUE: reference to a compiler-generated field
                class1154.gclass146_0 = null;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class1154.gclass202_0 =
                    class1154.gclass21_0.RacialSystemDictionary.Values.FirstOrDefault<RacialSystemSurvey>(class1153.method_0);
                // ISSUE: reference to a compiler-generated field
                if (class1154.gclass202_0 == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class1154.gclass21_0.method_262(class1153.gclass1_0.SystemData, 1);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class1154.gclass202_0 = class1154.gclass21_0.method_263(class1153.gclass1_0.SystemData,
                        class1154.gclass21_0.SystemTheme, "", true);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class1154.gclass21_0.method_258(class1153.gclass1_0.SystemData, false);
                }

                // ISSUE: reference to a compiler-generated method
                NavalAdminCommand gclass83_0 = this.gclass0_0.NavalAdminCommands.Values.FirstOrDefault<NavalAdminCommand>(class1154.method_0);
                // ISSUE: reference to a compiler-generated method
                List<ShipClass> list1 = this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class1154.method_1)
                    .ToList<ShipClass>();
                // ISSUE: reference to a compiler-generated field
                class1154.gclass21_0.DesignDoctrine.NameList_3.OrderBy<GClass12, int>(gclass12_0 => gclass12_0.int_0)
                    .ToList<GClass12>();
                int int_136_1 = this.method_0(this.DefenceBases);
                OperationalGroup gclass9_0_1 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.OrbitalDefences];
                if (gclass9_0_1 != null && int_136_1 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                        class1153.gclass1_0, gclass83_0, gclass9_0_1, list1, int_136_1, true);
                }

                int int_136_2 = this.method_0(this.OffenceBases);
                OperationalGroup gclass9_0_2 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.OribitalMissileBase];
                if (gclass9_0_2 != null && int_136_2 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                        class1153.gclass1_0, gclass83_0, gclass9_0_2, list1, int_136_2, true);
                }

                int int_136_3 = this.method_0(this.Fleet);
                OperationalGroup gclass9_0_3 = AuroraUtils.GetRandomInteger(4) != 1
                    ? this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.MissileBattleFleet]
                    : this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.BeamOnlyBattleFleet];
                if (gclass9_0_3 != null && int_136_3 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                        class1153.gclass1_0, gclass83_0, gclass9_0_3, list1, int_136_3, false);
                    int int_136_4 = this.method_0((int)Math.Floor(this.Fleet / 2.0));
                    OperationalGroup gclass9_0_4 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.JumpPointDefence];
                    if (gclass9_0_4 != null && int_136_4 > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                            class1153.gclass1_0, gclass83_0, gclass9_0_4, list1, int_136_4, true);
                    }
                }

                int int_136_5 = this.method_0(this.Squadron);
                OperationalGroup gclass9_0_5 = AuroraUtils.GetRandomInteger(4) != 1
                    ? this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.MissileBattleSquadron]
                    : this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.BeamOnlyBattleSquadron];
                if (gclass9_0_5 != null && int_136_5 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                        class1153.gclass1_0, gclass83_0, gclass9_0_5, list1, int_136_5, false);
                    int int_136_6 = this.method_0((int)Math.Floor(this.Squadron / 2.0));
                    OperationalGroup gclass9_0_6 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.JumpPointDefenceSmall];
                    if (gclass9_0_6 != null && int_136_6 > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                            class1153.gclass1_0, gclass83_0, gclass9_0_6, list1, int_136_6, true);
                    }
                }

                int int_136_7 = this.method_0(this.Patrol);
                OperationalGroup gclass9_0_7 = AuroraUtils.GetRandomInteger(4) != 1
                    ? this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.FACHunterSquadron]
                    : this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.BeamOnlyDDSquadron];
                if (gclass9_0_7 != null && int_136_7 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                        class1153.gclass1_0, gclass83_0, gclass9_0_7, list1, int_136_7, false);
                }

                int int_136_8 = this.method_0(this.Patrol);
                OperationalGroup gclass9_0_8 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.FACFlotilla];
                if (gclass9_0_8 != null && int_136_8 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                        class1153.gclass1_0, gclass83_0, gclass9_0_8, list1, int_136_8, false);
                }

                // ISSUE: reference to a compiler-generated method
                Decimal num1 = this.gclass0_0.Ships.Values.Where<ShipData>(class1154.method_2)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17);
                if (num1 > 100000M)
                {
                    int int_136_9 = (int)Math.Floor(num1 / 100000M);
                    OperationalGroup gclass9_0_9 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.Scout];
                    if (gclass9_0_9 != null && int_136_8 > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                            class1153.gclass1_0, gclass83_0, gclass9_0_9, list1, int_136_9, false);
                    }
                }

                // ISSUE: reference to a compiler-generated method
                int num2 = this.gclass0_0.Ships.Values.Where<ShipData>(class1154.method_3)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.FuelCapacity);
                if (num2 > 5000000)
                {
                    // ISSUE: reference to a compiler-generated method
                    SystemBodyData gclass1_1 = this.gclass0_0.SystemBodyRecordDic.Values
                        .Where<SystemBodyData>(class1153.method_1)
                        .Where<SystemBodyData>(gclass1_0_2 =>
                            gclass1_0_2.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                            gclass1_0_2.BodyTypeId == AuroraSystemBodyType.Superjovian)
                        .Where<SystemBodyData>(gclass1_0_3 =>
                            gclass1_0_3.MineralDeposits.ContainsKey(AuroraElement.Sorium))
                        .OrderByDescending<SystemBodyData, Decimal>(gclass1_0_4 =>
                            gclass1_0_4.MineralDeposits[AuroraElement.Sorium].Accessibility)
                        .FirstOrDefault<SystemBodyData>();
                    if (gclass1_1 != null)
                    {
                        int int_136_10 = (int)Math.Floor(num2 / 5000000.0);
                        OperationalGroup gclass9_0_10 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.PrecursorHarvesterGroup];
                        if (gclass9_0_10 != null && int_136_8 > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                                gclass1_1, gclass83_0, gclass9_0_10, list1, int_136_10, true);
                        }

                        OperationalGroup gclass9_0_11 = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.Tanker];
                        if (gclass9_0_11 != null && int_136_8 > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0,
                                gclass1_1, gclass83_0, gclass9_0_11, list1, 1, false);
                        }
                    }
                }

                int num3 = this.method_0(this.Regiment);
                int num4 = this.method_0(this.Regiment);
                int num5 = num3 + num4;
                if (num5 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class1154.gclass146_0 = class1154.gclass21_0.method_275(class1153.gclass1_0, gclass194_1);
                }

                if (num3 > 0)
                {
                    for (int int_72 = 1; int_72 <= num3; ++int_72)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1154.gclass21_0
                            .method_157(
                                $"{AuroraUtils.smethod_80(int_72)} {class1153.gclass1_0.method_78(class1154.gclass21_0)} Mech Regiment",
                                AutomatedGroundTemplateDesignType.PrecursorMechBattalion, class1154.gclass146_0, gclass194_1, null, false, false)
                            .FieldPosition = AuroraGroundFormationFieldPosition.FrontlineDefence;
                    }
                }

                if (num4 > 0)
                {
                    for (int int_72 = 1; int_72 <= num4; ++int_72)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1154.gclass21_0
                            .method_157(
                                $"{AuroraUtils.smethod_80(int_72)} {class1153.gclass1_0.method_78(class1154.gclass21_0)} Planetary Defence Regiment",
                                AutomatedGroundTemplateDesignType.PrecursorDefenceRegiment, class1154.gclass146_0, gclass194_1, null, false, false)
                            .FieldPosition = AuroraGroundFormationFieldPosition.RearEchelon;
                    }
                }

                if (num5 > 1)
                {
                    // ISSUE: reference to a compiler-generated method
                    int num6 = (int)Math.Ceiling((int)this.gclass0_0.FormationDictionary.Values
                                                     .Where<GroundUnitFormationData>(class1154.method_4)
                                                     .Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34()) /
                                                 250000.0);
                    if (num6 > 0)
                    {
                        for (int int_72 = 1; int_72 <= num6; ++int_72)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class1154.gclass21_0
                                .method_157(
                                    $"{AuroraUtils.smethod_80(int_72)} {class1153.gclass1_0.method_78(class1154.gclass21_0)} Planetary Headquarters",
                                    AutomatedGroundTemplateDesignType.PrecursorPlanetaryHQ, class1154.gclass146_0, gclass194_1, null, false, false)
                                .FieldPosition = AuroraGroundFormationFieldPosition.Support;
                        }

                        if (num3 > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            this.gclass0_0.method_540(class1154.gclass146_0, AutomatedGroundTemplateDesignType.PrecursorPlanetaryHQ, AutomatedGroundTemplateDesignType.PrecursorMechBattalion);
                        }

                        if (num4 > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            this.gclass0_0.method_540(class1154.gclass146_0, AutomatedGroundTemplateDesignType.PrecursorPlanetaryHQ, AutomatedGroundTemplateDesignType.PrecursorDefenceRegiment);
                        }
                    }
                }

                // ISSUE: reference to a compiler-generated method
                Decimal num7 = this.gclass0_0.Ships.Values.Where<ShipData>(class1154.method_5)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size);
                // ISSUE: reference to a compiler-generated method
                List<PopOrdnanceStock> list2 = this.gclass0_0.Ships.Values
                    .Where<ShipData>(class1154.method_6)
                    .SelectMany<ShipData, PopOrdnanceStock>(gclass40_0 => gclass40_0.gclass22_0.list_0)
                    .ToList<PopOrdnanceStock>();
                if (num7 > 0M)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class1154.gclass146_0 == null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1154.gclass146_0 = class1154.gclass21_0.method_275(class1153.gclass1_0, gclass194_1);
                    }

                    if (num1 > 0M)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1154.gclass146_0.method_65(AuroraInstallationType.RefuellingStation, 1M);
                    }

                    if (list2.Count > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1154.gclass146_0.method_65(AuroraInstallationType.OrdnanceTransferStation, 1M);
                        // ISSUE: reference to a compiler-generated field
                        class1154.gclass146_0.OrdnanceStocks = this.gclass0_0.method_399(list2, 4);
                    }

                    int decimal_90 = this.FixedDSTS + AuroraUtils.GetRandomInteger(this.RandomDSTS);
                    if (decimal_90 > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1154.gclass146_0.method_65(AuroraInstallationType.TrackingStation, decimal_90);
                    }
                }

                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                foreach (GroundUnitFormationElement gclass39 in this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1154.method_7)
                             .Where<GroundUnitFormationData>(class1154.method_8)
                             .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).ToList<GroundUnitFormationElement>())
                    gclass39.FortificationLevel = gclass39.GroundUnitClass.GroundUnitBaseTypeData.decimal_2;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2659);
        }
    }
}