using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Aurora;

public partial class GClass0
{
    public void method_63()
    {
        try
        {
            Cursor.Current = Cursors.WaitCursor;
            using (SQLiteConnection sqliteConnection_0 = new SQLiteConnection(AuroraUtils.string_1))
            {
                sqliteConnection_0.Open();
                using (SQLiteTransaction sqLiteTransaction = sqliteConnection_0.BeginTransaction())
                {
                    this.method_64();
                    this.UpsertGClass0(sqliteConnection_0);
                    this.UpsertRacialTables(sqliteConnection_0);
                    this.method_67(sqliteConnection_0);
                    this.method_77(sqliteConnection_0);
                    this.method_78(sqliteConnection_0);
                    this.method_79(sqliteConnection_0);
                    this.method_84(sqliteConnection_0);
                    this.method_85(sqliteConnection_0);
                    this.method_86(sqliteConnection_0);
                    this.method_147(sqliteConnection_0);
                    this.method_148(sqliteConnection_0);
                    this.method_87(sqliteConnection_0);
                    this.method_88(sqliteConnection_0);
                    this.method_90(sqliteConnection_0);
                    this.method_80(sqliteConnection_0);
                    this.method_91(sqliteConnection_0);
                    this.method_93(sqliteConnection_0);
                    this.method_92(sqliteConnection_0);
                    this.method_94(sqliteConnection_0);
                    this.method_95(sqliteConnection_0);
                    this.method_107(sqliteConnection_0);
                    this.method_98(sqliteConnection_0);
                    this.method_99(sqliteConnection_0);
                    this.method_100(sqliteConnection_0);
                    this.method_101(sqliteConnection_0);
                    this.method_102(sqliteConnection_0);
                    this.method_103(sqliteConnection_0);
                    this.method_104(sqliteConnection_0);
                    this.method_105(sqliteConnection_0);
                    this.method_106(sqliteConnection_0);
                    this.method_108(sqliteConnection_0);
                    this.method_109(sqliteConnection_0);
                    this.method_81(sqliteConnection_0);
                    this.method_110(sqliteConnection_0);
                    this.method_111(sqliteConnection_0);
                    this.method_112(sqliteConnection_0);
                    this.method_113(sqliteConnection_0);
                    this.method_114(sqliteConnection_0);
                    this.method_115(sqliteConnection_0);
                    this.method_117(sqliteConnection_0);
                    this.method_118(sqliteConnection_0);
                    this.method_119(sqliteConnection_0);
                    this.method_120(sqliteConnection_0);
                    this.method_121(sqliteConnection_0);
                    this.method_122(sqliteConnection_0);
                    this.method_123(sqliteConnection_0);
                    this.method_124(sqliteConnection_0);
                    this.method_125(sqliteConnection_0);
                    this.method_96(sqliteConnection_0);
                    this.method_126(sqliteConnection_0);
                    this.method_127(sqliteConnection_0);
                    this.method_128(sqliteConnection_0);
                    this.method_129(sqliteConnection_0);
                    this.method_130(sqliteConnection_0);
                    this.method_131(sqliteConnection_0);
                    this.method_136(sqliteConnection_0);
                    this.method_132(sqliteConnection_0);
                    this.method_133(sqliteConnection_0);
                    this.method_134(sqliteConnection_0);
                    this.method_135(sqliteConnection_0);
                    this.method_137(sqliteConnection_0);
                    this.method_138(sqliteConnection_0);
                    this.method_139(sqliteConnection_0);
                    this.method_140(sqliteConnection_0);
                    this.method_141(sqliteConnection_0);
                    this.method_145(sqliteConnection_0);
                    this.method_146(sqliteConnection_0);
                    this.method_143(sqliteConnection_0);
                    this.method_144(sqliteConnection_0);
                    this.method_142(sqliteConnection_0);
                    this.method_151(sqliteConnection_0);
                    this.method_152(sqliteConnection_0);
                    this.method_153(sqliteConnection_0);
                    this.method_150(sqliteConnection_0);
                    this.method_149(sqliteConnection_0);
                    this.method_76(sqliteConnection_0);
                    this.method_82(sqliteConnection_0);
                    this.method_75(sqliteConnection_0);
                    this.method_74(sqliteConnection_0);
                    this.method_73(sqliteConnection_0);
                    this.method_72(sqliteConnection_0);
                    this.method_71(sqliteConnection_0);
                    this.method_83(sqliteConnection_0);
                    this.method_116(sqliteConnection_0);
                    this.method_68(sqliteConnection_0);
                    this.method_69(sqliteConnection_0);
                    this.method_70(sqliteConnection_0);
                    this.method_89(sqliteConnection_0);
                    this.method_97(sqliteConnection_0);
                    sqLiteTransaction.Commit();
                }

                sqliteConnection_0.Close();
            }

            Cursor.Current = Cursors.Default;
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1425);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1426);
        }
    }

    public void method_67(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_System WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (SystemData200 gclass200 in this.SystemDataDictionary.Values)
                {
                    try
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_System (SystemID, SystemNumber, Age, AbundanceModifier, Stars, GameID, JumpPointSurveyPoints, SystemTypeID, DustDensity, SolSystem, NoSensorChecks, SupernovaForce, SupernovaElapsedTime ) \r\n                                VALUES ( @SystemID, @SystemNumber, @Age, @AbundanceModifier, @Stars, @GameID, @JumpPointSurveyPoints, @SystemTypeID, @DustDensity, @SolSystem, @NoSensorChecks, @SupernovaForce, @SupernovaElapsedTime)";
                        sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass200.SystemID);
                        sqLiteCommand.Parameters.AddWithValue("@SystemNumber", gclass200.SystemNumber);
                        sqLiteCommand.Parameters.AddWithValue("@Age", gclass200.Age);
                        sqLiteCommand.Parameters.AddWithValue("@AbundanceModifier", gclass200.AbundanceModifier);
                        sqLiteCommand.Parameters.AddWithValue("@Stars", gclass200.Stars);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@JumpPointSurveyPoints",
                            gclass200.JumpPointSurveyPoints);
                        sqLiteCommand.Parameters.AddWithValue("@SystemTypeID", gclass200.SystemTypeID);
                        sqLiteCommand.Parameters.AddWithValue("@DustDensity", gclass200.DustDensity);
                        sqLiteCommand.Parameters.AddWithValue("@SolSystem", gclass200.IsSolSystem);
                        sqLiteCommand.Parameters.AddWithValue("@NoSensorChecks", gclass200.NoSensorChecks);
                        sqLiteCommand.Parameters.AddWithValue("@SupernovaForce", gclass200.SupernovaForce);
                        sqLiteCommand.Parameters.AddWithValue("@SupernovaElapsedTime", gclass200.SupernovaElapsedTime);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        int int0 = gclass200.SystemID;
                        AuroraUtils.ShowExceptionPopupForItem(ex, 3249, int0);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1430);
        }
    }

    public void method_68(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_RaceMedals WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (FCTRaceMedalRecord gclass42 in this.RaceMedalDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_RaceMedals (RaceID, MedalFileName, MedalName, MedalDescription, MedalPoints, GameID, MultipleAwards, MedalID, Abbreviation ) \r\n                        VALUES ( @RaceID, @MedalFileName, @MedalName, @MedalDescription, @MedalPoints, @GameID, @MultipleAwards, @MedalID, @Abbreviation )";
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass42.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@MedalFileName", gclass42.MedalFileName);
                    sqLiteCommand.Parameters.AddWithValue("@MedalName", gclass42.MedalName);
                    sqLiteCommand.Parameters.AddWithValue("@MedalDescription", gclass42.MedalDescription);
                    sqLiteCommand.Parameters.AddWithValue("@MedalPoints", gclass42.MedalPoints);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@MultipleAwards", gclass42.AllowMultipleAward);
                    sqLiteCommand.Parameters.AddWithValue("@MedalID", gclass42.MedalID);
                    sqLiteCommand.Parameters.AddWithValue("@Abbreviation", gclass42.Abbreviation);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1431);
        }
    }

    public void method_69(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MedalConditionAssignment WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass44 gclass44 in this.list_1)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MedalConditionAssignment (MedalConditionID, MedalID, GameID ) \r\n                        VALUES ( @MedalConditionID, @MedalID, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@MedalConditionID", gclass44.gclass43_0.MedalConditionID);
                    sqLiteCommand.Parameters.AddWithValue("@MedalID", gclass44.gclass42_0.MedalID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1432);
        }
    }

    public void method_70(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Squadron WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (FCTSquadronData70 gclass70 in this.FCTShipDataDictionary.Values
                             .SelectMany<FCTShipData40, FCTSquadronData70>(gclass40_0 =>
                                 gclass40_0.ChildSquadronDictionary.Values).ToList<FCTSquadronData70>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Squadron (SquadronID, GameID, SquadronName, ParentShipID ) \r\n                        VALUES ( @SquadronID, @GameID, @SquadronName, @ParentShipID )";
                    sqLiteCommand.Parameters.AddWithValue("@SquadronID", gclass70.SquadronID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SquadronName", gclass70.SquadronName);
                    sqLiteCommand.Parameters.AddWithValue("@ParentShipID", gclass70.ParentShipData.int_8);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3413);
        }
    }

    public void method_71(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_WindowPosition WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (WindowPosition207 gclass207 in this.WindowPositionDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_WindowPosition (WindowName, Left, Top, GameID ) \r\n                        VALUES ( @WindowName, @Left, @Top, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@WindowName", gclass207.WindowName);
                    sqLiteCommand.Parameters.AddWithValue("@Left", gclass207.Left);
                    sqLiteCommand.Parameters.AddWithValue("@Top", gclass207.Top);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1433);
        }
    }

    public void method_72(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_GroundUnitFormationElement WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand(
                "DELETE FROM FCT_GroundUnitFormationElementTemplates WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ElementRecharge WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_STODetected WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GroundUnitFormationElement gclass39 in this.FormationDictionary.Values
                             .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).ToList<GroundUnitFormationElement>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_GroundUnitFormationElement (GameID, FormationID, Units, ClassID, TemplateID, SpeciesID, Morale, FortificationLevel, CurrentSupply, TargetSelection, FiringDistribution, ElementID ) \r\n                        VALUES ( @GameID, @FormationID, @Units, @ClassID, @TemplateID, @SpeciesID, @Morale, @FortificationLevel, @CurrentSupply, @TargetSelection, @FiringDistribution, @ElementID)";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@FormationID", gclass39.Formation.FormationID);
                    sqLiteCommand.Parameters.AddWithValue("@Units", gclass39.UnitCount);
                    sqLiteCommand.Parameters.AddWithValue("@ClassID", gclass39.GroundUnitClass.ClassID);
                    sqLiteCommand.Parameters.AddWithValue("@TemplateID", 0);
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass39.RaceData.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Morale", gclass39.Morale);
                    sqLiteCommand.Parameters.AddWithValue("@FortificationLevel", gclass39.FortificationLevel);
                    sqLiteCommand.Parameters.AddWithValue("@CurrentSupply", gclass39.CurrentSupply);
                    sqLiteCommand.Parameters.AddWithValue("@TargetSelection", gclass39.TargetSelectionType);
                    sqLiteCommand.Parameters.AddWithValue("@FiringDistribution", gclass39.FiringDistribution);
                    sqLiteCommand.Parameters.AddWithValue("@ElementID", gclass39.ElementID);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (int num in gclass39.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ElementRecharge ( GameID, ElementID, RechargeRemaining ) VALUES ( @GameID, @ElementID, @RechargeRemaining )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ElementID", gclass39.ElementID);
                        sqLiteCommand.Parameters.AddWithValue("@RechargeRemaining", num);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GameRace gclass21 in gclass39.DetectingRaceList)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_STODetected ( GameID, ElementID, DetectingRaceID ) VALUES ( @GameID, @ElementID, @DetectingRaceID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ElementID", gclass39.ElementID);
                        sqLiteCommand.Parameters.AddWithValue("@DetectingRaceID", gclass21.RaceID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }

                foreach (GroundUnitFormationElement gclass39 in this.FormationTemplateRecordDic.Values
                             .SelectMany<GroundUnitFormationTemplateData, GroundUnitFormationElement>(gclass102_0 => gclass102_0.FormationElementList).ToList<GroundUnitFormationElement>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_GroundUnitFormationElementTemplates (GameID, FormationTemplateID, ClassID, Units ) VALUES ( @GameID, @FormationTemplateID, @ClassID, @Units)";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@FormationTemplateID", gclass39.FormationTemplate.TemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@Units", gclass39.UnitCount);
                    sqLiteCommand.Parameters.AddWithValue("@ClassID", gclass39.GroundUnitClass.ClassID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1434);
        }
    }

    public void method_73(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_GroundUnitFormationTemplate WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GroundUnitFormationTemplateData gclass102 in this.FormationTemplateRecordDic.Values)
                {
                    int num = 0;
                    if (gclass102.RequiredRankData != null)
                        num = gclass102.RequiredRankData.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_GroundUnitFormationTemplate (GameID, RaceID, Name, Abbreviation, TemplateID, RequiredRank, AutomatedTemplateID, FormationsTrained, Obsolete ) \r\n                        VALUES ( @GameID, @RaceID, @Name, @Abbreviation, @TemplateID, @RequiredRank, @AutomatedTemplateID, @FormationsTrained, @Obsolete)";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass102.RaceData.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass102.Name);
                    sqLiteCommand.Parameters.AddWithValue("@Abbreviation", gclass102.Abbreviation);
                    sqLiteCommand.Parameters.AddWithValue("@TemplateID", gclass102.TemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@RequiredRank", num);
                    sqLiteCommand.Parameters.AddWithValue("@AutomatedTemplateID", gclass102.AutomatedTemplateType);
                    sqLiteCommand.Parameters.AddWithValue("@FormationsTrained", gclass102.FormationTrained);
                    sqLiteCommand.Parameters.AddWithValue("@Obsolete", gclass102.Obsolete);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1438);
        }
    }

    public void method_74(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_GroundUnitFormation WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GroundUnitFormationData gclass103 in this.FormationDictionary.Values)
                {
                    try
                    {
                        int num1 = 0;
                        int num2 = 0;
                        int num3 = 0;
                        int num4 = 0;
                        int num5 = 0;
                        int num6 = 0;
                        int num7 = 0;
                        if (gclass103.PopulationData != null)
                            num2 = gclass103.PopulationData.PopulationID;
                        if (gclass103.ShipData != null)
                            num1 = gclass103.ShipData.int_8;
                        if (gclass103.ParentFormationData != null)
                            num3 = gclass103.ParentFormationData.FormationID;
                        if (gclass103.AssignedFormationData != null)
                            num4 = gclass103.AssignedFormationData.FormationID;
                        if (gclass103.RequiredRankData != null)
                            num5 = gclass103.RequiredRankData.int_0;
                        if (gclass103.OriginalTemplateData != null)
                            num6 = gclass103.OriginalTemplateData.TemplateID;
                        if (gclass103.ReplacementTemplateData != null)
                            num7 = gclass103.ReplacementTemplateData.TemplateID;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_GroundUnitFormation (FormationID, Name, Abbreviation, RaceID, GameID, OriginalTemplateID, ReplacementTemplateID, PopulationID, ShipID, ParentFormationID, BoardingStatus, ActiveSensorsOn, FieldPosition, RequiredRank, AssignedFormationID, Civilian, UseForReplacements, ReplacementPriority, OrgLinkID, DoNotRecover ) \r\n                            VALUES ( @FormationID, @Name, @Abbreviation, @RaceID, @GameID, @OriginalTemplateID, @ReplacementTemplateID, @PopulationID, @ShipID, @ParentFormationID, @BoardingStatus, @ActiveSensorsOn, @FieldPosition, @RequiredRank, @AssignedFormationID, @Civilian, @UseForReplacements, @ReplacementPriority, @OrgLinkID, @DoNotRecover)";
                        sqLiteCommand.Parameters.AddWithValue("@FormationID", gclass103.FormationID);
                        sqLiteCommand.Parameters.AddWithValue("@Name", gclass103.Name);
                        sqLiteCommand.Parameters.AddWithValue("@Abbreviation", gclass103.Abbreviation);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass103.RaceData.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@OriginalTemplateID", num6);
                        sqLiteCommand.Parameters.AddWithValue("@ReplacementTemplateID", num7);
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", num2);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", num1);
                        sqLiteCommand.Parameters.AddWithValue("@ParentFormationID", num3);
                        sqLiteCommand.Parameters.AddWithValue("@BoardingStatus", gclass103.BoardingStatus);
                        sqLiteCommand.Parameters.AddWithValue("@ActiveSensorsOn", gclass103.bActiveSensorsOn);
                        sqLiteCommand.Parameters.AddWithValue("@FieldPosition",
                            gclass103.FieldPosition);
                        sqLiteCommand.Parameters.AddWithValue("@RequiredRank", num5);
                        sqLiteCommand.Parameters.AddWithValue("@AssignedFormationID", num4);
                        sqLiteCommand.Parameters.AddWithValue("@Civilian", gclass103.bCivilian);
                        sqLiteCommand.Parameters.AddWithValue("@UseForReplacements", gclass103.bUseForReplacements);
                        sqLiteCommand.Parameters.AddWithValue("@ReplacementPriority", gclass103.ReplacementPriority);
                        sqLiteCommand.Parameters.AddWithValue("@OrgLinkID", gclass103.OrgLinkID);
                        sqLiteCommand.Parameters.AddWithValue("@DoNotRecover", gclass103.bDoNotRecover);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3250);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1439);
        }
    }

    public void method_75(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_GroundUnitClass WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_GroundUnitCapability WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GroundUnitClass101 gclass101 in this.GroundUnitClassDictionary.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    int num4 = 0;
                    int num5 = 0;
                    if (gclass101.GroundUnitComponentList.Count > 0)
                        num1 = (int)gclass101.GroundUnitComponentList[0].GroundUnitComponentType;
                    if (gclass101.GroundUnitComponentList.Count > 1)
                        num2 = (int)gclass101.GroundUnitComponentList[1].GroundUnitComponentType;
                    if (gclass101.GroundUnitComponentList.Count > 2)
                        num3 = (int)gclass101.GroundUnitComponentList[2].GroundUnitComponentType;
                    if (gclass101.GroundUnitComponentList.Count > 3)
                        num4 = (int)gclass101.GroundUnitComponentList[3].GroundUnitComponentType;
                    if (gclass101.gclass230_0 != null)
                        num5 = gclass101.gclass230_0.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_GroundUnitClass (BaseType, GroundUnitClassID, TechSystemID, ClassName, ArmourType, ComponentA, ComponentB, ComponentC, ComponentD, ArmourStrengthModifier, WeaponStrengthModifier, Size, Cost, GameID, STOWeapon, MaxWeaponRange, MaxFireControlRange, ActiveSensorRange, SensorStrength, TrackingSpeed, ECCM, GUClassType, UnitSupplyCost, RechargeTime, ConstructionRating, HQCapacity, NonCombatClass, PointDefenceWeapon,\r\n                                    Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite) \r\n                        VALUES ( @BaseType, @GroundUnitClassID, @TechSystemID, @ClassName, @ArmourType, @ComponentA, @ComponentB, @ComponentC, @ComponentD, @ArmourStrengthModifier, @WeaponStrengthModifier, @Size, @Cost, @GameID, @STOWeapon, @MaxWeaponRange, @MaxFireControlRange, @ActiveSensorRange, @SensorStrength, @TrackingSpeed, @ECCM, @GUClassType, @UnitSupplyCost, @RechargeTime, @ConstructionRating, @HQCapacity, @NonCombatClass, @PointDefenceWeapon,\r\n                                    @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite)";
                    sqLiteCommand.Parameters.AddWithValue("@BaseType", gclass101.GroundUnitBaseTypeData.genum112_0);
                    sqLiteCommand.Parameters.AddWithValue("@GroundUnitClassID", gclass101.ClassID);
                    sqLiteCommand.Parameters.AddWithValue("@TechSystemID", gclass101.TechData.TechSystemID);
                    sqLiteCommand.Parameters.AddWithValue("@ClassName", gclass101.ClassName);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourType", gclass101.ArmourType.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentA", num1);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentB", num2);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentC", num3);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentD", num4);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourStrengthModifier", gclass101.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@WeaponStrengthModifier", gclass101.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@Size", gclass101.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@Cost", gclass101.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@STOWeapon", num5);
                    sqLiteCommand.Parameters.AddWithValue("@MaxWeaponRange", gclass101.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@MaxFireControlRange", gclass101.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@ActiveSensorRange", gclass101.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@SensorStrength", gclass101.decimal_5);
                    sqLiteCommand.Parameters.AddWithValue("@TrackingSpeed", gclass101.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@ECCM", gclass101.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@GUClassType", gclass101.genum115_0);
                    sqLiteCommand.Parameters.AddWithValue("@UnitSupplyCost", gclass101.decimal_4);
                    sqLiteCommand.Parameters.AddWithValue("@RechargeTime", gclass101.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@ConstructionRating", gclass101.decimal_6);
                    sqLiteCommand.Parameters.AddWithValue("@HQCapacity", gclass101.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@NonCombatClass", gclass101.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@PointDefenceWeapon", gclass101.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass101.gclass123_0.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass101.gclass123_0.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass101.gclass123_0.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass101.gclass123_0.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass101.gclass123_0.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass101.gclass123_0.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass101.gclass123_0.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass101.gclass123_0.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass101.gclass123_0.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass101.gclass123_0.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass101.gclass123_0.Gallicite);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (GroundUnitCapabilityDefinition gclass98 in gclass101.dictionary_0.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_GroundUnitCapability ( GroundUnitClassID, CapabilityID, GameID ) VALUES ( @GroundUnitClassID, @CapabilityID, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@GroundUnitClassID", gclass101.ClassID);
                        sqLiteCommand.Parameters.AddWithValue("@CapabilityID", gclass98.GroundUnitCapability);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1440);
        }
    }

    public void method_76(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MapLabel WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (MapLabelData122 gclass122 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, MapLabelData122>(
                                 gclass21_0 => gclass21_0.MapLabelList).ToList<MapLabelData122>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MapLabel (Caption, Colour, FontBold, FontItalic, FontName, FontSize, GameID, RaceID, Xcor, Ycor) \r\n                        VALUES ( @Caption, @Colour, @FontBold, @FontItalic, @FontName, @FontSize, @GameID, @RaceID, @Xcor, @Ycor) ";
                    sqLiteCommand.Parameters.AddWithValue("@Caption", gclass122.Caption);
                    sqLiteCommand.Parameters.AddWithValue("@Colour", gclass122.Color.ToArgb());
                    sqLiteCommand.Parameters.AddWithValue("@FontBold", gclass122.Font.Bold);
                    sqLiteCommand.Parameters.AddWithValue("@FontItalic", gclass122.Font.Italic);
                    sqLiteCommand.Parameters.AddWithValue("@FontName", gclass122.Font.Name);
                    sqLiteCommand.Parameters.AddWithValue("@FontSize", gclass122.Font.Size);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass122.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass122.XCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass122.YCoord);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1441);
        }
    }

    public void method_77(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_SurveyLocation WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_RaceSurveyLocation WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (SurveyLocation213 gclass213 in this.SystemDataDictionary.Values
                             .SelectMany<SystemData200, SurveyLocation213>(gclass200_0 =>
                                 gclass200_0.SurveyLocationDictionary.Values).ToList<SurveyLocation213>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_SurveyLocation (SurveyLocationID, GameID, SystemID, LocationNumber, Xcor, Ycor ) VALUES ( @SurveyLocationID, @GameID, @SystemID, @LocationNumber, @Xcor, @Ycor)";
                    sqLiteCommand.Parameters.AddWithValue("@SurveyLocationID", gclass213.SurveyLocationID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass213.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@LocationNumber", gclass213.LocationNumber);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass213.XCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass213.YCoord);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (int num in gclass213.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_RaceSurveyLocation ( RaceID, GameID, SystemID, LocationNumber ) VALUES ( @RaceID, @GameID, @SystemID, @LocationNumber )";
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", num);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass213.SystemID);
                        sqLiteCommand.Parameters.AddWithValue("@LocationNumber", gclass213.LocationNumber);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1442);
        }
    }

    public void method_78(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Star WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (Star197 gclass197 in this.StarDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Star (StarID, GameID, SystemID, StarTypeID, Name, Protostar, Xcor, Ycor, Component, OrbitingComponent, Bearing, Luminosity, OrbitalPeriod, OrbitalDistance, DisasterStatus, Eccentricity, EccentricityDirection, MeanOrbitalSpeed, DistanceToParent, DistanceToOrbitCentre, CurrentOrbitalSpeed ) \r\n                        VALUES ( @StarID, @GameID, @SystemID, @StarTypeID, @Name, @Protostar, @Xcor, @Ycor, @Component, @OrbitingComponent, @Bearing, @Luminosity, @OrbitalPeriod, @OrbitalDistance, @DisasterStatus, @Eccentricity, @EccentricityDirection, @MeanOrbitalSpeed, @DistanceToParent, @DistanceToOrbitCentre, @CurrentOrbitalSpeed )";
                    sqLiteCommand.Parameters.AddWithValue("@StarID", gclass197.StarID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass197.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@StarTypeID", gclass197.StellarType.StellarTypeID);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass197.Name);
                    sqLiteCommand.Parameters.AddWithValue("@Protostar", gclass197.ProtoStar);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass197.XCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass197.YCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Component", gclass197.Component);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitingComponent", gclass197.OrbitingComponent);
                    sqLiteCommand.Parameters.AddWithValue("@Bearing", gclass197.Bearing);
                    sqLiteCommand.Parameters.AddWithValue("@Luminosity", gclass197.Luminosity);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitalPeriod", gclass197.OrbitalPeriod);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitalDistance", gclass197.OrbitalDistance);
                    sqLiteCommand.Parameters.AddWithValue("@DisasterStatus", gclass197.genum30_0);
                    sqLiteCommand.Parameters.AddWithValue("@Eccentricity", gclass197.Eccentricity);
                    sqLiteCommand.Parameters.AddWithValue("@EccentricityDirection", gclass197.EccentricityDirection);
                    sqLiteCommand.Parameters.AddWithValue("@MeanOrbitalSpeed", gclass197.MeanOrbitalSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@CurrentOrbitalSpeed", gclass197.CurrentOrbitalSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@DistanceToParent", gclass197.DistanceToParent);
                    sqLiteCommand.Parameters.AddWithValue("@DistanceToOrbitCentre", gclass197.DistanceToOrbitCentre);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1443);
        }
    }

    public void method_79(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_JumpPoint WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (JumpPoint120 gclass120 in this.JumpPointDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_JumpPoint (WarpPointID, GameID, SystemID, Distance, Bearing, WPLink, Xcor, Ycor, JumpGateStrength, JumpGateRaceID ) VALUES ( @WarpPointID, @GameID, @SystemID, @Distance, @Bearing, @WPLink, @Xcor, @Ycor, @JumpGateStrength, @JumpGateRaceID)";
                    sqLiteCommand.Parameters.AddWithValue("@WarpPointID", gclass120.WarpPointID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass120.SystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@Distance", gclass120.Distance);
                    sqLiteCommand.Parameters.AddWithValue("@Bearing", gclass120.Bearing);
                    sqLiteCommand.Parameters.AddWithValue("@WPLink", gclass120.LinkedWarpPointID);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass120.XCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass120.YCoord);
                    sqLiteCommand.Parameters.AddWithValue("@JumpGateStrength", gclass120.JumpGateStrength);
                    sqLiteCommand.Parameters.AddWithValue("@JumpGateRaceID", gclass120.JumpGateRaceID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1444);
        }
    }

    public void method_80(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_OrderTemplate WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (OrderTemplateData gclass144 in this.MoveOrderTemplateDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_OrderTemplate (GameID, OrderTemplateID, RaceID, StartSystemID, TemplateName ) VALUES ( @GameID, @OrderTemplateID, @RaceID, @StartSystemID, @TemplateName)";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@OrderTemplateID", gclass144.OrderTemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass144.RaceData.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@StartSystemID", gclass144.RaceSystem.ActualSystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@TemplateName", gclass144.TemplateName);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1445);
        }
    }

    public void method_81(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AcidAttack WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (AcidAttack gclass25 in this.AcidAttackList)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AcidAttack (ArmourColumn, GameID, TargetShipID, PointOfDamageTime, RemainingDamage, LastDamageTime ) VALUES ( @ArmourColumn, @GameID, @TargetShipID, @PointOfDamageTime, @RemainingDamage, @LastDamageTime)";
                    sqLiteCommand.Parameters.AddWithValue("@ArmourColumn", gclass25.ArmourColumn);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@TargetShipID", gclass25.TargetShip.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@PointOfDamageTime", gclass25.PointOfDamageTime);
                    sqLiteCommand.Parameters.AddWithValue("@RemainingDamage", gclass25.RemainingDamage);
                    sqLiteCommand.Parameters.AddWithValue("@LastDamageTime", gclass25.LastDamageTime);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1446);
        }
    }

    public void method_82(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShipTechData WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ShipTechData182 gclass182 in this.FCTShipDataDictionary.Values
                             .SelectMany<FCTShipData40, ShipTechData182>(gclass40_0 => gclass40_0.ShipTechDataList)
                             .ToList<ShipTechData182>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ShipTechData (GameID, ShipID, TechID, TechPoints ) VALUES ( @GameID, @ShipID, @TechID, @TechPoints)";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass182.ShipData.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@TechID", gclass182.TechData.TechSystemID);
                    sqLiteCommand.Parameters.AddWithValue("@TechPoints", gclass182.TechPoints);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1447);
        }
    }

    public void method_83(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_TechProgressionRace WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (DIMDesignPhilosophyTechProgression gclass19 in this.DesignPhilosophyTechProgressionsDictionary)
                {
                    foreach (GameRace gclass21 in gclass19.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_TechProgressionRace (ProgressionOrder, RaceID, GameID ) VALUES ( @ProgressionOrder, @RaceID, @GameID)";
                        sqLiteCommand.Parameters.AddWithValue("@ProgressionOrder", gclass19.ProgressionOrder);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass21.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1448);
        }
    }

    public void method_84(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Waypoint WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass214 gclass214 in this.dictionary_13.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Waypoint (WaypointID, GameID, RaceID, SystemID, OrbitBodyID, CreationTime, Xcor, Ycor, Number, WaypointType, Name, JumpPointID, FleetID ) \r\n                                VALUES ( @WaypointID, @GameID, @RaceID, @SystemID, @OrbitBodyID, @CreationTime, @Xcor, @Ycor, @Number, @WaypointType, @Name, @JumpPointID, @FleetID)";
                    sqLiteCommand.Parameters.AddWithValue("@WaypointID", gclass214.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass214.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass214.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitBodyID", gclass214.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@CreationTime", gclass214.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass214.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass214.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@Number", gclass214.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@WaypointType", gclass214.wayPointType_0);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass214.Name);
                    sqLiteCommand.Parameters.AddWithValue("@JumpPointID", gclass214.method_0());
                    sqLiteCommand.Parameters.AddWithValue("@FleetID", gclass214.int_2);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1449);
        }
    }

    public void method_85(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MassDriverPackets WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (FCTMassDriverPacket126 gclass126 in this.MassDriverPacketsDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MassDriverPackets (PacketID, GameID, RaceID, SysID, DestID, TotalSize, Speed, Xcor, Ycor, LastXcor, LastYcor, IncrementStartX, IncrementStartY, Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite ) \r\n                        VALUES ( @PacketID, @GameID, @RaceID, @SysID, @DestID, @TotalSize, @Speed, @Xcor, @Ycor, @LastXcor, @LastYcor, @IncrementStartX, @IncrementStartY, @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite)";
                    sqLiteCommand.Parameters.AddWithValue("@PacketID", gclass126.PacketID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass126.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SysID", gclass126.System.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@DestID", gclass126.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@TotalSize", gclass126.TotalSize);
                    sqLiteCommand.Parameters.AddWithValue("@Speed", gclass126.Speed);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass126.XCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass126.YCoord);
                    sqLiteCommand.Parameters.AddWithValue("@LastXcor", gclass126.LastXCoord);
                    sqLiteCommand.Parameters.AddWithValue("@LastYcor", gclass126.LastYCoord);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartX", gclass126.IncrementStartX);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartY", gclass126.IncrementStartY);
                    sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass126.MineralsValue.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass126.MineralsValue.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass126.MineralsValue.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass126.MineralsValue.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass126.MineralsValue.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass126.MineralsValue.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass126.MineralsValue.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass126.MineralsValue.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass126.MineralsValue.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass126.MineralsValue.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass126.MineralsValue.Gallicite);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1450);
        }
    }

    public void method_86(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_LagrangePoint WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass212 gclass212 in this.dictionary_14.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_LagrangePoint (LaGrangePointID, GameID, SystemID, StarID, PlanetID, Xcor, Ycor, Distance, Bearing ) VALUES ( @LaGrangePointID, @GameID, @SystemID, @StarID, @PlanetID, @Xcor, @Ycor, @Distance, @Bearing)";
                    sqLiteCommand.Parameters.AddWithValue("@LaGrangePointID", gclass212.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass212.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@StarID", gclass212.gclass197_0.StarID);
                    sqLiteCommand.Parameters.AddWithValue("@PlanetID", gclass212.gclass1_0.SystemBodyID);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass212.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass212.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@Distance", gclass212.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@Bearing", gclass212.double_3);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1451);
        }
    }

    public void method_87(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_PopTradeBalance WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass190 gclass190 in this.PopulationDataDictionary.Values
                             .SelectMany<PopulationData, GClass190>(gclass146_0 => gclass146_0.dictionary_4.Values)
                             .ToList<GClass190>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_PopTradeBalance (PopulationID, TradeGoodID, GameID, ProductionRate, TradeBalance, LastTradeBalance ) VALUES ( @PopulationID, @TradeGoodID, @GameID, @ProductionRate, @TradeBalance, @LastTradeBalance )";
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass190.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@TradeGoodID", gclass190.gclass189_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@ProductionRate", gclass190.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@TradeBalance", gclass190.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@LastTradeBalance", gclass190.decimal_2);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1452);
        }
    }

    public void method_88(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShippingWealthData WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ShippingWealthData gclass188 in this.ShippingLineDictionary.Values
                             .SelectMany<ShippingLineData, ShippingWealthData>(gclass187_0 => gclass187_0.WealthDataList)
                             .Where<ShippingWealthData>(gclass188_0 =>
                                 this.GameTime - gclass188_0.TradeTime < AuroraUtils.decimal_29).ToList<ShippingWealthData>())
                {
                    int num1 = 0;
                    int num2 = 0;
                    if (gclass188.Ship != null)
                        num1 = gclass188.Ship.int_8;
                    if (gclass188.TradeGood != null)
                        num2 = gclass188.TradeGood.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ShippingWealthData (GameID, ShippingLineID, ShipID, Contract, Colonist, Fuel, Amount, TradeGood, TradeTime, OriginPop, DestinationPop ) VALUES ( @GameID, @ShippingLineID, @ShipID, @Contract, @Colonist, @Fuel, @Amount, @TradeGood, @TradeTime, @OriginPop, @DestinationPop )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@ShippingLineID", gclass188.ShippingLine.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@Contract", gclass188.Contract);
                    sqLiteCommand.Parameters.AddWithValue("@Colonist", gclass188.Colonist);
                    sqLiteCommand.Parameters.AddWithValue("@Fuel", gclass188.Fuel);
                    sqLiteCommand.Parameters.AddWithValue("@Amount", gclass188.Amount);
                    sqLiteCommand.Parameters.AddWithValue("@TradeGood", num2);
                    sqLiteCommand.Parameters.AddWithValue("@TradeTime", gclass188.TradeTime);
                    sqLiteCommand.Parameters.AddWithValue("@OriginPop", gclass188.method_0());
                    sqLiteCommand.Parameters.AddWithValue("@DestinationPop", gclass188.method_1());
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1453);
        }
    }

    public void method_89(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_PrecursorTombGroup WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass172 gclass172 in this.list_8)
                {
                    int num1 = 0;
                    OperationalGroupID genum105 = OperationalGroupID.None;
                    int num2 = 0;
                    if (gclass172.gclass1_0 != null)
                        num1 = gclass172.gclass1_0.SystemBodyID;
                    if (gclass172.gclass9_0 != null)
                        genum105 = gclass172.gclass9_0.OperationalGroupId;
                    if (gclass172.gclass102_0 != null)
                        num2 = gclass172.gclass102_0.TemplateID;
                    if (gclass172.int_0 >= 1 && (genum105 != OperationalGroupID.None || num2 != 0))
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_PrecursorTombGroup (GameID, EmergenceTime, LastTriggerEvent, NumGroups, SystemBodyID, FormationTemplateID, OperationalGroupID) \r\n                        VALUES ( @GameID, @EmergenceTime, @LastTriggerEvent, @NumGroups, @SystemBodyID, @FormationTemplateID, @OperationalGroupID)";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@EmergenceTime", gclass172.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@LastTriggerEvent", gclass172.decimal_1);
                        sqLiteCommand.Parameters.AddWithValue("@NumGroups", gclass172.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", num1);
                        sqLiteCommand.Parameters.AddWithValue("@FormationTemplateID", num2);
                        sqLiteCommand.Parameters.AddWithValue("@OperationalGroupID", genum105);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1453);
        }
    }

    public void method_90(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MoveOrders WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (MoveOrder gclass139 in this.FleetDictionary.Values
                             .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                             .ToList<MoveOrder>())
                {
                    Decimal num1 = 0M;
                    Decimal num2 = 0M;
                    Decimal num3 = 0M;
                    if (gclass139.Population != null)
                        num1 = gclass139.Population.PopulationID;
                    if (gclass139.NewSystem != null)
                        num2 = gclass139.NewSystem.ActualSystemData.SystemID;
                    if (gclass139.NewJumpPoint != null)
                        num3 = gclass139.NewJumpPoint.WarpPointID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MoveOrders (MoveOrderID, GameID, RaceID, FleetID, MoveActionID, MoveOrder, StartSystemID, DestinationType, DestinationID, PopulationID, DestinationItemType, DestinationItemID, MaxItems, OrderDelay, OrderDelayRemaining, OrbDistance, MinDistance, MinQuantity, NewSystemID, NewWarpPointID, Description, Arrived, SurveyPointsRequired, TimeRequired, MessageText, LoadSubUnits ) \r\n                        VALUES ( @MoveOrderID, @GameID, @RaceID, @FleetID, @MoveActionID, @MoveOrder, @StartSystemID, @DestinationType, @DestinationID, @PopulationID, @DestinationItemType, @DestinationItemID, @MaxItems, @OrderDelay, @OrderDelayRemaining, @OrbDistance, @MinDistance, @MinQuantity, @NewSystemID, @NewWarpPointID, @Description, @Arrived, @SurveyPointsRequired, @TimeRequired, @MessageText, @LoadSubUnits )";
                    sqLiteCommand.Parameters.AddWithValue("@MoveOrderID", gclass139.MoveOrderID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass139.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@FleetID", gclass139.Fleet.FleetID);
                    sqLiteCommand.Parameters.AddWithValue("@MoveActionID", gclass139.MoveActionType.MoveActionType);
                    sqLiteCommand.Parameters.AddWithValue("@MoveOrder", gclass139.OrderValue);
                    sqLiteCommand.Parameters.AddWithValue("@StartSystemID", gclass139.StartSystem.ActualSystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationType", gclass139.DestinationType);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationID", gclass139.DestinationID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationItemType", gclass139.DestinationItemType);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationItemID", gclass139.DestinationItemID);
                    sqLiteCommand.Parameters.AddWithValue("@MaxItems", gclass139.MaxItems);
                    sqLiteCommand.Parameters.AddWithValue("@OrderDelay", gclass139.Delay);
                    sqLiteCommand.Parameters.AddWithValue("@OrderDelayRemaining", gclass139.DelayRemaining);
                    sqLiteCommand.Parameters.AddWithValue("@OrbDistance", gclass139.OrbDistance);
                    sqLiteCommand.Parameters.AddWithValue("@MinDistance", gclass139.MinDistance);
                    sqLiteCommand.Parameters.AddWithValue("@MinQuantity", gclass139.MinQuantity);
                    sqLiteCommand.Parameters.AddWithValue("@NewSystemID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@NewWarpPointID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@Description", gclass139.Description);
                    sqLiteCommand.Parameters.AddWithValue("@Arrived", gclass139.bArrived);
                    sqLiteCommand.Parameters.AddWithValue("@SurveyPointsRequired", gclass139.SurveyPointsRequired);
                    sqLiteCommand.Parameters.AddWithValue("@TimeRequired", gclass139.TimeRequired);
                    sqLiteCommand.Parameters.AddWithValue("@MessageText", gclass139.MessageText);
                    sqLiteCommand.Parameters.AddWithValue("@LoadSubUnits", gclass139.bLoadSubUnits);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1454);
        }
    }

    public void method_91(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MoveOrderTemplate WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (TMoveOrder gclass145 in this.MoveOrderTemplateDictionary.Values
                             .SelectMany<OrderTemplateData, TMoveOrder>(gclass144_0 => gclass144_0.TMoveOrderList).ToList<TMoveOrder>())
                {
                    Decimal num1 = 0M;
                    Decimal num2 = 0M;
                    Decimal num3 = 0M;
                    if (gclass145.Population != null)
                        num1 = gclass145.Population.PopulationID;
                    if (gclass145.NewSystem != null)
                        num2 = gclass145.NewSystem.ActualSystemData.SystemID;
                    if (gclass145.NewJumpPoint != null)
                        num3 = gclass145.NewJumpPoint.WarpPointID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MoveOrderTemplate (OrderTemplateID, MoveIndex, GameID, MoveActionID, StartSystemID, DestinationType, DestinationID, PopulationID, DestinationItemType, DestinationItemID, MaxItems, OrderDelay, OrbDistance, MinDistance, MinQuantity, NewSystemID, NewJumpPointID, Description, SurveyPointsRequired, MessageText, LoadSubUnits ) \r\n                        VALUES ( @OrderTemplateID, @MoveIndex, @GameID, @MoveActionID, @StartSystemID, @DestinationType, @DestinationID, @PopulationID, @DestinationItemType, @DestinationItemID, @MaxItems, @OrderDelay, @OrbDistance, @MinDistance, @MinQuantity, @NewSystemID, @NewJumpPointID, @Description, @SurveyPointsRequired, @MessageText, @LoadSubUnits )";
                    sqLiteCommand.Parameters.AddWithValue("@OrderTemplateID", gclass145.OrderTemplate.OrderTemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@MoveIndex", gclass145.MoveIndex);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@MoveActionID", gclass145.MoveAction.MoveActionType);
                    sqLiteCommand.Parameters.AddWithValue("@StartSystemID", gclass145.StartSystem.ActualSystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationType", gclass145.DestinationType);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationID", gclass145.DestinationID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationItemType", gclass145.DestinationItemType);
                    sqLiteCommand.Parameters.AddWithValue("@DestinationItemID", gclass145.DestinationItemID);
                    sqLiteCommand.Parameters.AddWithValue("@MaxItems", gclass145.MaxItems);
                    sqLiteCommand.Parameters.AddWithValue("@OrderDelay", gclass145.OrderDelay);
                    sqLiteCommand.Parameters.AddWithValue("@OrbDistance", gclass145.OrbDistance);
                    sqLiteCommand.Parameters.AddWithValue("@MinDistance", gclass145.MinDistance);
                    sqLiteCommand.Parameters.AddWithValue("@MinQuantity", gclass145.MinQuantity);
                    sqLiteCommand.Parameters.AddWithValue("@NewSystemID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@NewJumpPointID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@Description", gclass145.Description);
                    sqLiteCommand.Parameters.AddWithValue("@SurveyPointsRequired", gclass145.SurveyPointsRequired);
                    sqLiteCommand.Parameters.AddWithValue("@MessageText", gclass145.MessageText);
                    sqLiteCommand.Parameters.AddWithValue("@LoadSubUnits", gclass145.bLoadSubUnits);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1455);
        }
    }

    public void method_92(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (SystemBodyData gclass1 in this.SystemBodyRecordDic.Values
                             .Where<SystemBodyData>(gclass1_0 => gclass1_0.UnknownEnumDBUpdateNeedState == Unknown_SystemBodyDataUpdateLevel.FullUpdate)
                             .ToList<SystemBodyData>())
                {
                    gclass1.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.BasicUpdate; // 2-to-zero
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_SystemBody (SystemBodyID, DominantTerrain, SystemID, StarID, GameID, PlanetNumber, OrbitNumber, BodyClass, Radius, ParentBodyID, ParentBodyType, BodyTypeID, Tilt, TectonicActivity, HydroID, HydroExt, RuinID, RuinRaceID, AbandonedFactories, TrojanAsteroid, OrbitalDistance, DistanceToOrbitCentre, DistanceToParent, Bearing, Density, Mass, Gravity, EscapeVelocity, Year, TidalForce, \r\n                        Eccentricity, DayValue, Roche, MagneticField, BaseTemp, SurfaceTemp, AtmosPress, Albedo, GHFactor, AGHFactor, Xcor, Ycor, RadiationLevel, DustLevel, TidalLock, Ring, GroundMineralSurvey, Name, PlanetIcon, AsteroidBeltID, EccentricityDirection, MeanOrbitalSpeed, CurrentOrbitalSpeed, FixedBody, FixedBodyParentID) \r\n                        VALUES (@SystemBodyID, @DominantTerrain, @SystemID, @StarID, @GameID, @PlanetNumber, @OrbitNumber, @BodyClass, @Radius, @ParentBodyID, @ParentBodyType, @BodyTypeID, @Tilt, @TectonicActivity, @HydroID, @HydroExt, @RuinID, @RuinRaceID, @AbandonedFactories, @TrojanAsteroid, @OrbitalDistance, @DistanceToOrbitCentre, @DistanceToParent, @Bearing, @Density, @Mass, @Gravity, @EscapeVelocity, @Year, @TidalForce, \r\n                        @Eccentricity, @DayValue, @Roche, @MagneticField, @BaseTemp, @SurfaceTemp, @AtmosPress, @Albedo, @GHFactor, @AGHFactor, @Xcor, @Ycor, @RadiationLevel, @DustLevel, @TidalLock, @Ring, @GroundMineralSurvey, @Name, @PlanetIcon, @AsteroidBeltID, @EccentricityDirection, @MeanOrbitalSpeed, @CurrentOrbitalSpeed, @FixedBody, @FixedBodyParentID)";
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass1.SystemBodyID);
                    sqLiteCommand.Parameters.AddWithValue("@DominantTerrain", gclass1.DominantTerrain.DominantTerrainType);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass1.SystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@StarID", gclass1.StarID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@PlanetNumber", gclass1.PlanetNumber);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitNumber", gclass1.OrbitNumber);
                    sqLiteCommand.Parameters.AddWithValue("@BodyClass", gclass1.BodyClass);
                    sqLiteCommand.Parameters.AddWithValue("@Radius", gclass1.Radius);
                    sqLiteCommand.Parameters.AddWithValue("@ParentBodyID", gclass1.ParentBodyID);
                    sqLiteCommand.Parameters.AddWithValue("@ParentBodyType", gclass1.ParentBodyType);
                    sqLiteCommand.Parameters.AddWithValue("@BodyTypeID", gclass1.BodyTypeId);
                    sqLiteCommand.Parameters.AddWithValue("@Tilt", gclass1.Tilt);
                    sqLiteCommand.Parameters.AddWithValue("@TectonicActivity", gclass1.TectonicActivity);
                    sqLiteCommand.Parameters.AddWithValue("@HydroID", gclass1.HydrosphereTypeId);
                    sqLiteCommand.Parameters.AddWithValue("@HydroExt", gclass1.HydroExtent);
                    sqLiteCommand.Parameters.AddWithValue("@RuinID", gclass1.RuinID);
                    sqLiteCommand.Parameters.AddWithValue("@RuinRaceID", gclass1.RuinRaceID);
                    sqLiteCommand.Parameters.AddWithValue("@AbandonedFactories", gclass1.AbandonedFactories);
                    sqLiteCommand.Parameters.AddWithValue("@TrojanAsteroid", gclass1.TrojanOffset);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitalDistance", gclass1.OrbitalDistance);
                    sqLiteCommand.Parameters.AddWithValue("@DistanceToOrbitCentre", gclass1.DistanceToOrbitCentre);
                    sqLiteCommand.Parameters.AddWithValue("@DistanceToParent", gclass1.DistanceToParent);
                    sqLiteCommand.Parameters.AddWithValue("@Bearing", gclass1.Bearing);
                    sqLiteCommand.Parameters.AddWithValue("@Density", gclass1.Density);
                    sqLiteCommand.Parameters.AddWithValue("@Mass", gclass1.Mass);
                    sqLiteCommand.Parameters.AddWithValue("@Gravity", gclass1.Gravity);
                    sqLiteCommand.Parameters.AddWithValue("@EscapeVelocity", gclass1.Escape);
                    sqLiteCommand.Parameters.AddWithValue("@Year", gclass1.Year);
                    sqLiteCommand.Parameters.AddWithValue("@TidalForce", gclass1.TidalForce);
                    sqLiteCommand.Parameters.AddWithValue("@Eccentricity", gclass1.Eccentricity);
                    sqLiteCommand.Parameters.AddWithValue("@DayValue", gclass1.Day);
                    sqLiteCommand.Parameters.AddWithValue("@Roche", gclass1.Roche);
                    sqLiteCommand.Parameters.AddWithValue("@MagneticField", gclass1.MagneticField);
                    sqLiteCommand.Parameters.AddWithValue("@BaseTemp", gclass1.BaseTemp);
                    sqLiteCommand.Parameters.AddWithValue("@SurfaceTemp", gclass1.SurfaceTemp);
                    sqLiteCommand.Parameters.AddWithValue("@AtmosPress", gclass1.AtmospherePressure);
                    sqLiteCommand.Parameters.AddWithValue("@Albedo", gclass1.Albedo);
                    sqLiteCommand.Parameters.AddWithValue("@GHFactor", gclass1.GreenhouseFactor);
                    sqLiteCommand.Parameters.AddWithValue("@AGHFactor", gclass1.AntiGreenhouseFactor);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass1.XCoordinate);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass1.YCoordinate);
                    sqLiteCommand.Parameters.AddWithValue("@RadiationLevel", gclass1.RadiationLevel);
                    sqLiteCommand.Parameters.AddWithValue("@DustLevel", gclass1.DustLevel);
                    sqLiteCommand.Parameters.AddWithValue("@TidalLock", gclass1.TidalLock);
                    sqLiteCommand.Parameters.AddWithValue("@Ring", gclass1.Ring);
                    sqLiteCommand.Parameters.AddWithValue("@GroundMineralSurvey", gclass1.GroundMineralSurveyState);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass1.Name);
                    sqLiteCommand.Parameters.AddWithValue("@PlanetIcon", gclass1.PlanetIcon);
                    sqLiteCommand.Parameters.AddWithValue("@AsteroidBeltID", gclass1.AsteroidBeltID);
                    sqLiteCommand.Parameters.AddWithValue("@EccentricityDirection", gclass1.EccentricityDirection);
                    sqLiteCommand.Parameters.AddWithValue("@MeanOrbitalSpeed", gclass1.MeanOrbitalSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@CurrentOrbitalSpeed", gclass1.CurrentOrbitalSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@FixedBody", gclass1.IsFixedBody);
                    sqLiteCommand.Parameters.AddWithValue("@FixedBodyParentID", gclass1.FixedBodyParentID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1456);
        }
    }

    public void method_93(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (SystemBodyData gclass1 in this.list_0)
                {
                    sqLiteCommand.CommandText =
                        "DELETE FROM FCT_SystemBody WHERE SystemBodyID = " + gclass1.SystemBodyID.ToString();
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1457);
        }
    }
    
    
    public void method_94(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (SystemBodyData gclass1 in this.SystemBodyRecordDic.Values
                             .Where<SystemBodyData>(gclass1_0 => gclass1_0.UnknownEnumDBUpdateNeedState == Unknown_SystemBodyDataUpdateLevel.BasicUpdate)
                             .ToList<SystemBodyData>())
                {
                    sqLiteCommand.CommandText =
                        "UPDATE FCT_SystemBody SET DominantTerrain = @DominantTerrain, AbandonedFactories = @AbandonedFactories, RuinID = @RuinID, RuinRaceID = @RuinRaceID, Bearing = @Bearing, SurfaceTemp = @SurfaceTemp, AtmosPress = @AtmosPress, Albedo = @Albedo, GHFactor = @GHFactor, AGHFactor = @AGHFactor, Xcor = @Xcor, Ycor = @Ycor, RadiationLevel = @RadiationLevel, DustLevel = @DustLevel, \r\n                        GroundMineralSurvey = @GroundMineralSurvey, Name = @Name, HydroExt = @HydroExt, HydroID = @HydroID, DistanceToOrbitCentre = @DistanceToOrbitCentre, DistanceToParent = @DistanceToParent, CurrentOrbitalSpeed = @CurrentOrbitalSpeed, MeanOrbitalSpeed = @MeanOrbitalSpeed\r\n                        WHERE SystemBodyID = @SystemBodyID";
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass1.SystemBodyID);
                    sqLiteCommand.Parameters.AddWithValue("@DominantTerrain", gclass1.DominantTerrain.DominantTerrainType);
                    sqLiteCommand.Parameters.AddWithValue("@AbandonedFactories", gclass1.AbandonedFactories);
                    sqLiteCommand.Parameters.AddWithValue("@RuinID", gclass1.RuinID);
                    sqLiteCommand.Parameters.AddWithValue("@RuinRaceID", gclass1.RuinRaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Bearing", gclass1.Bearing);
                    sqLiteCommand.Parameters.AddWithValue("@SurfaceTemp", gclass1.SurfaceTemp);
                    sqLiteCommand.Parameters.AddWithValue("@AtmosPress", gclass1.AtmospherePressure);
                    sqLiteCommand.Parameters.AddWithValue("@Albedo", gclass1.Albedo);
                    sqLiteCommand.Parameters.AddWithValue("@GHFactor", gclass1.GreenhouseFactor);
                    sqLiteCommand.Parameters.AddWithValue("@AGHFactor", gclass1.AntiGreenhouseFactor);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass1.XCoordinate);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass1.YCoordinate);
                    sqLiteCommand.Parameters.AddWithValue("@RadiationLevel", gclass1.RadiationLevel);
                    sqLiteCommand.Parameters.AddWithValue("@DustLevel", gclass1.DustLevel);
                    sqLiteCommand.Parameters.AddWithValue("@GroundMineralSurvey", gclass1.GroundMineralSurveyState);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass1.Name);
                    sqLiteCommand.Parameters.AddWithValue("@HydroExt", gclass1.HydroExtent);
                    sqLiteCommand.Parameters.AddWithValue("@HydroID", gclass1.HydrosphereTypeId);
                    sqLiteCommand.Parameters.AddWithValue("@DistanceToOrbitCentre", gclass1.DistanceToOrbitCentre);
                    sqLiteCommand.Parameters.AddWithValue("@DistanceToParent", gclass1.DistanceToParent);
                    sqLiteCommand.Parameters.AddWithValue("@CurrentOrbitalSpeed", gclass1.CurrentOrbitalSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@MeanOrbitalSpeed", gclass1.MeanOrbitalSpeed);
                    sqLiteCommand.ExecuteNonQuery();
                }

                foreach (SystemBodyData gclass1 in this.SystemBodyRecordDic.Values
                             .Where<SystemBodyData>(gclass1_0 => gclass1_0.UnknownEnumDBUpdateNeedState == Unknown_SystemBodyDataUpdateLevel.ExtendedUpdate)
                             .ToList<SystemBodyData>())
                {
                    sqLiteCommand.CommandText =
                        "UPDATE FCT_SystemBody SET DominantTerrain = @DominantTerrain, AbandonedFactories = @AbandonedFactories, RuinID = @RuinID, RuinRaceID = @RuinRaceID, Bearing = @Bearing, SurfaceTemp = @SurfaceTemp, AtmosPress = @AtmosPress, Albedo = @Albedo, GHFactor = @GHFactor, AGHFactor = @AGHFactor, Xcor = @Xcor, Ycor = @Ycor, RadiationLevel = @RadiationLevel, DustLevel = @DustLevel, \r\n                        GroundMineralSurvey = @GroundMineralSurvey, Name = @Name, HydroExt = @HydroExt, HydroID = @HydroID, PlanetNumber = @PlanetNumber, OrbitNumber = @OrbitNumber, Radius = @Radius, OrbitalDistance = @OrbitalDistance, Density = @Density, Mass = @Mass, Gravity = @Gravity, EscapeVelocity = @EscapeVelocity, Year = @Year, TidalForce = @TidalForce,\r\n                        EccentricityDirection = @EccentricityDirection, Eccentricity = @Eccentricity, MeanOrbitalSpeed = @MeanOrbitalSpeed, CurrentOrbitalSpeed = @CurrentOrbitalSpeed,\r\n                        DayValue = @DayValue, BaseTemp = @BaseTemp, TidalLock = @TidalLock, Ring = @Ring\r\n                        WHERE SystemBodyID = @SystemBodyID";
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass1.SystemBodyID);
                    sqLiteCommand.Parameters.AddWithValue("@DominantTerrain", gclass1.DominantTerrain.DominantTerrainType);
                    sqLiteCommand.Parameters.AddWithValue("@AbandonedFactories", gclass1.AbandonedFactories);
                    sqLiteCommand.Parameters.AddWithValue("@RuinID", gclass1.RuinID);
                    sqLiteCommand.Parameters.AddWithValue("@RuinRaceID", gclass1.RuinRaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Bearing", gclass1.Bearing);
                    sqLiteCommand.Parameters.AddWithValue("@SurfaceTemp", gclass1.SurfaceTemp);
                    sqLiteCommand.Parameters.AddWithValue("@AtmosPress", gclass1.AtmospherePressure);
                    sqLiteCommand.Parameters.AddWithValue("@Albedo", gclass1.Albedo);
                    sqLiteCommand.Parameters.AddWithValue("@GHFactor", gclass1.GreenhouseFactor);
                    sqLiteCommand.Parameters.AddWithValue("@AGHFactor", gclass1.AntiGreenhouseFactor);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass1.XCoordinate);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass1.YCoordinate);
                    sqLiteCommand.Parameters.AddWithValue("@RadiationLevel", gclass1.RadiationLevel);
                    sqLiteCommand.Parameters.AddWithValue("@DustLevel", gclass1.DustLevel);
                    sqLiteCommand.Parameters.AddWithValue("@GroundMineralSurvey", gclass1.GroundMineralSurveyState);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass1.Name);
                    sqLiteCommand.Parameters.AddWithValue("@HydroExt", gclass1.HydroExtent);
                    sqLiteCommand.Parameters.AddWithValue("@HydroID", gclass1.HydrosphereTypeId);
                    sqLiteCommand.Parameters.AddWithValue("@PlanetNumber", gclass1.PlanetNumber);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitNumber", gclass1.OrbitNumber);
                    sqLiteCommand.Parameters.AddWithValue("@Radius", gclass1.Radius);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitalDistance", gclass1.OrbitalDistance);
                    sqLiteCommand.Parameters.AddWithValue("@Density", gclass1.Density);
                    sqLiteCommand.Parameters.AddWithValue("@Mass", gclass1.Mass);
                    sqLiteCommand.Parameters.AddWithValue("@Gravity", gclass1.Gravity);
                    sqLiteCommand.Parameters.AddWithValue("@EscapeVelocity", gclass1.Escape);
                    sqLiteCommand.Parameters.AddWithValue("@Year", gclass1.Year);
                    sqLiteCommand.Parameters.AddWithValue("@TidalForce", gclass1.TidalForce);
                    sqLiteCommand.Parameters.AddWithValue("@DayValue", gclass1.Day);
                    sqLiteCommand.Parameters.AddWithValue("@BaseTemp", gclass1.BaseTemp);
                    sqLiteCommand.Parameters.AddWithValue("@TidalLock", gclass1.TidalLock);
                    sqLiteCommand.Parameters.AddWithValue("@Ring", gclass1.Ring);
                    sqLiteCommand.Parameters.AddWithValue("@MeanOrbitalSpeed", gclass1.MeanOrbitalSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@CurrentOrbitalSpeed", gclass1.CurrentOrbitalSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@EccentricityDirection", gclass1.EccentricityDirection);
                    sqLiteCommand.Parameters.AddWithValue("@Eccentricity", gclass1.Eccentricity);
                    sqLiteCommand.ExecuteNonQuery();
                    gclass1.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.BasicUpdate; // 1-to-zero
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1458);
        }
    }

    public void method_95(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            if (!this.bool_22)
            {
                using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
                {
                    foreach (GClass215 gclass215 in this.list_9
                                 .Where<GClass215>(gclass215_0 => gclass215_0.genum5_0 == Unknown_SystemBodyDataUpdateLevel.FullUpdate)
                                 .ToList<GClass215>())
                    {
                        gclass215.genum5_0 = Unknown_SystemBodyDataUpdateLevel.BasicUpdate;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_SystemBodySurveys ( GameID, RaceID, SystemBodyID) VALUES ( @GameID, @RaceID, @SystemBodyID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass215.gclass21_0.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass215.gclass1_0.SystemBodyID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                new SQLiteCommand("DELETE FROM FCT_SystemBodySurveys WHERE GameID = " + this.GameID.ToString(),
                    sqliteConnection_0).ExecuteNonQuery();
                using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
                {
                    foreach (GClass215 gclass215 in this.list_9)
                    {
                        gclass215.genum5_0 = Unknown_SystemBodyDataUpdateLevel.BasicUpdate;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_SystemBodySurveys ( GameID, RaceID, SystemBodyID) VALUES ( @GameID, @RaceID, @SystemBodyID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass215.gclass21_0.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass215.gclass1_0.SystemBodyID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }

                this.bool_22 = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1459);
        }
    }

    public void method_96(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_SubFleets WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (SubFleet gclass84 in this.SubFleetDictionary.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    if (gclass84.AnchorFleet != null)
                        num1 = gclass84.AnchorFleet.FleetID;
                    if (gclass84.gclass117_0 != null)
                        num2 = gclass84.gclass117_0.int_0;
                    int num3 = 0;
                    if (gclass84.ParentSubFleet != null)
                        num3 = gclass84.ParentSubFleet.SubFleetID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_SubFleets (SubFleetID, GameID, RaceID, ParentFleetID, ParentSubFleetID, SubFleetName, AnchorFleetID, SpecificThreatID, AnchorFleetDistance, AnchorFleetBearingOffset, GuardNearestHostileContact, GuardNearestKnownWarship, UseAnchorDestination ) \r\n                            VALUES ( @SubFleetID, @GameID, @RaceID, @ParentFleetID, @ParentSubFleetID, @SubFleetName, @AnchorFleetID, @SpecificThreatID, @AnchorFleetDistance, @AnchorFleetBearingOffset, @GuardNearestHostileContact, @GuardNearestKnownWarship, @UseAnchorDestination )";
                    sqLiteCommand.Parameters.AddWithValue("@SubFleetID", gclass84.SubFleetID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass84.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ParentFleetID", gclass84.ParentFleet.FleetID);
                    sqLiteCommand.Parameters.AddWithValue("@ParentSubFleetID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@SubFleetName", gclass84.SubFleetName);
                    sqLiteCommand.Parameters.AddWithValue("@AnchorFleetID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@SpecificThreatID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@AnchorFleetDistance", gclass84.AnchorFleetDistance);
                    sqLiteCommand.Parameters.AddWithValue("@AnchorFleetBearingOffset", gclass84.AnchorFleetBearingOffset);
                    sqLiteCommand.Parameters.AddWithValue("@GuardNearestHostileContact", gclass84.bGuardNearestHostileContact);
                    sqLiteCommand.Parameters.AddWithValue("@GuardNearestKnownWarship", gclass84.bGuardNearestKnownWarship);
                    sqLiteCommand.Parameters.AddWithValue("@UseAnchorDestination", gclass84.bUseAnchorDestination);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1487);
        }
    }

    public void method_97(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_StandingOrderTemplate WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_StandingOrderTemplateOrder WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GameRace gclass21 in this.FCTRaceRecordDic.Values)
                {
                    foreach (GClass135 gclass135 in gclass21.dictionary_9.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_StandingOrderTemplate (GameID, RaceID, TemplateID, TemplateName ) \r\n                                    VALUES ( @GameID, @RaceID, @TemplateID, @TemplateName )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass21.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@TemplateID", gclass135.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@TemplateName", gclass135.string_0);
                        sqLiteCommand.ExecuteNonQuery();
                        foreach (KeyValuePair<int, StandingOrderDefinition> keyValuePair in gclass135.dictionary_0)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_StandingOrderTemplateOrder ( GameID, RaceID, TemplateID, OrderID, ConditionID, Priority ) \r\n                                        VALUES ( @GameID, @RaceID, @TemplateID, @OrderID, @ConditionID, @Priority )";
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass21.RaceID);
                            sqLiteCommand.Parameters.AddWithValue("@TemplateID", gclass135.int_0);
                            sqLiteCommand.Parameters.AddWithValue("@OrderID", keyValuePair.Value.auroraStandingOrder_0);
                            sqLiteCommand.Parameters.AddWithValue("@ConditionID", 0);
                            sqLiteCommand.Parameters.AddWithValue("@Priority", keyValuePair.Key);
                            sqLiteCommand.ExecuteNonQuery();
                        }

                        foreach (KeyValuePair<int, FleetConditionalOrder> keyValuePair in gclass135.dictionary_1)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_StandingOrderTemplateOrder ( GameID, RaceID, TemplateID, OrderID, ConditionID, Priority, CreateFWP ) \r\n                                        VALUES ( @GameID, @RaceID, @TemplateID, @OrderID, @ConditionID, @Priority, @CreateFWP )";
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass21.RaceID);
                            sqLiteCommand.Parameters.AddWithValue("@TemplateID", gclass135.int_0);
                            sqLiteCommand.Parameters.AddWithValue("@OrderID", keyValuePair.Value.StandingOrder);
                            sqLiteCommand.Parameters.AddWithValue("@ConditionID",
                                keyValuePair.Value.Condition);
                            sqLiteCommand.Parameters.AddWithValue("@Priority", keyValuePair.Key);
                            sqLiteCommand.Parameters.AddWithValue("@CreateFWP", keyValuePair.Value.CreateFleetWaypoint);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3913);
        }
    }

    public void method_98(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Fleet WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_FleetHistory WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_FleetStandingOrder WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_FleetConditionalOrder WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (FleetData gclass85 in this.FleetDictionary.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    int num4 = 0;
                    OperationalGroupID genum105 = OperationalGroupID.None;
                    int num5 = 0;
                    int num6 = 0;
                    bool flag = false;
                    if (gclass85.AssignedPopulation != null)
                        num1 = gclass85.AssignedPopulation.PopulationID;
                    if (gclass85.OrbitingBody != null)
                        num2 = gclass85.OrbitingBody.SystemBodyID;
                    if (gclass85.AnchorFleet != null)
                        num3 = gclass85.AnchorFleet.FleetID;
                    if (gclass85.gclass117_0 != null)
                        num6 = gclass85.gclass117_0.int_0;
                    if (gclass85.EntryJumpPoint != null)
                        num4 = gclass85.EntryJumpPoint.WarpPointID;
                    if (gclass85.NPROperationGroup != null)
                        genum105 = gclass85.NPROperationGroup.OperationalGroupId;
                    if (gclass85.ShippingLine != null)
                        num5 = gclass85.ShippingLine.int_0;
                    if (gclass85.NPRSomething != null)
                        flag = gclass85.NPRSomething.bRedeployOrderGiven;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Fleet (FleetID, GameID, FleetName, AssignedPopulationID, ParentCommandID, OrbitBodyID, OrbitDistance, OrbitBearing, RaceID, SystemID, TradeLocation, CivilianFunction, NPRHomeGuard, Speed, MaxNebulaSpeed, Xcor, Ycor, LastXcor, LastYcor, LastMoveTime, LastTransitTime, IncrementStartX, IncrementStartY,\r\n                        EntryJPID, CycleMoves, JustDivided, AnchorFleetID, SpecificThreatID, AnchorFleetDistance, AnchorFleetBearingOffset, AvoidAlienSystems, AvoidDanger, DisplaySensors, DisplayWeapons, NPROperationalGroupID, ShippingLine, UseMaximumSpeed, RedeployOrderGiven, \r\n                        MaxStandingOrderDistance, NoSurrender, GuardNearestHostileContact, GuardNearestKnownWarship, UseAnchorDestination, AssumeJumpCapable, EscapeTimeRemaining, LastFleetDamageTime, DetachedStanding, DetachedConditional, IncludeSquadrons, IgnoreStanding, IgnoreConditional) \r\n                        \r\n                        VALUES ( @FleetID, @GameID, @FleetName, @AssignedPopulationID, @ParentCommandID, @OrbitBodyID, @OrbitDistance, @OrbitBearing, @RaceID, @SystemID, @TradeLocation, @CivilianFunction, @NPRHomeGuard, @Speed, @MaxNebulaSpeed, @Xcor, @Ycor, @LastXcor, @LastYcor, @LastMoveTime, @LastTransitTime, @IncrementStartX, @IncrementStartY, \r\n                        @EntryJPID, @CycleMoves, @JustDivided, @AnchorFleetID, @SpecificThreatID, @AnchorFleetDistance, @AnchorFleetBearingOffset, @AvoidAlienSystems, @AvoidDanger, @DisplaySensors, @DisplayWeapons, @NPROperationalGroupID, @ShippingLine, @UseMaximumSpeed, @RedeployOrderGiven, \r\n                        @MaxStandingOrderDistance, @NoSurrender, @GuardNearestHostileContact, @GuardNearestKnownWarship, @UseAnchorDestination, @AssumeJumpCapable, @EscapeTimeRemaining, @LastFleetDamageTime, @DetachedStanding, @DetachedConditional, @IncludeSquadrons, @IgnoreStanding, @IgnoreConditional)";
                    sqLiteCommand.Parameters.AddWithValue("@FleetID", gclass85.FleetID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@FleetName", gclass85.FleetName);
                    sqLiteCommand.Parameters.AddWithValue("@AssignedPopulationID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@ParentCommandID", gclass85.ParentNavalCommand.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitBodyID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitDistance", gclass85.OrbitDistance);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitBearing", gclass85.OrbitBearing);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass85.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass85.System.ActualSystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@TradeLocation", gclass85.TradeLocation);
                    sqLiteCommand.Parameters.AddWithValue("@CivilianFunction", gclass85.CivilianFunction);
                    sqLiteCommand.Parameters.AddWithValue("@NPRHomeGuard", gclass85.IsNPRHomeguard);
                    sqLiteCommand.Parameters.AddWithValue("@Speed", gclass85.Speed);
                    sqLiteCommand.Parameters.AddWithValue("@MaxNebulaSpeed", gclass85.MaxNebulaSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass85.XCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass85.YCoord);
                    sqLiteCommand.Parameters.AddWithValue("@LastXcor", gclass85.LastXCoord);
                    sqLiteCommand.Parameters.AddWithValue("@LastYcor", gclass85.LastYCoord);
                    sqLiteCommand.Parameters.AddWithValue("@LastMoveTime", gclass85.LastMoveTime);
                    sqLiteCommand.Parameters.AddWithValue("@LastTransitTime", gclass85.LastTransitTime);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartX", gclass85.IncrementStartX);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartY", gclass85.IncrementStartY);
                    sqLiteCommand.Parameters.AddWithValue("@EntryJPID", num4);
                    sqLiteCommand.Parameters.AddWithValue("@CycleMoves", gclass85.checkState_0);
                    sqLiteCommand.Parameters.AddWithValue("@JustDivided", gclass85.JustDivided);
                    sqLiteCommand.Parameters.AddWithValue("@AnchorFleetID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@SpecificThreatID", num6);
                    sqLiteCommand.Parameters.AddWithValue("@AnchorFleetDistance", gclass85.AnchorFleetDistance);
                    sqLiteCommand.Parameters.AddWithValue("@AnchorFleetBearingOffset", gclass85.AnchorFleetBearingOffset);
                    sqLiteCommand.Parameters.AddWithValue("@AvoidAlienSystems", gclass85.bAvoidAlienSystem);
                    sqLiteCommand.Parameters.AddWithValue("@AvoidDanger", gclass85.bAvoidDanger);
                    sqLiteCommand.Parameters.AddWithValue("@DisplaySensors", gclass85.bDisplaySensors);
                    sqLiteCommand.Parameters.AddWithValue("@DisplayWeapons", gclass85.bDisplayWeapons);
                    sqLiteCommand.Parameters.AddWithValue("@NPROperationalGroupID", genum105);
                    sqLiteCommand.Parameters.AddWithValue("@ShippingLine", num5);
                    sqLiteCommand.Parameters.AddWithValue("@UseMaximumSpeed", gclass85.bUseMaximumSpeed);
                    sqLiteCommand.Parameters.AddWithValue("@RedeployOrderGiven", flag);
                    sqLiteCommand.Parameters.AddWithValue("@MaxStandingOrderDistance", gclass85.MaxStandingOrderDistance);
                    sqLiteCommand.Parameters.AddWithValue("@NoSurrender", gclass85.bNoSurrender);
                    sqLiteCommand.Parameters.AddWithValue("@GuardNearestHostileContact", gclass85.bGuardNearestHostileContact);
                    sqLiteCommand.Parameters.AddWithValue("@GuardNearestKnownWarship", gclass85.bGuardNearestKnownWarship);
                    sqLiteCommand.Parameters.AddWithValue("@UseAnchorDestination", gclass85.bUseAnchorDestination);
                    sqLiteCommand.Parameters.AddWithValue("@AssumeJumpCapable", gclass85.bAssumeJumpCapable);
                    sqLiteCommand.Parameters.AddWithValue("@EscapeTimeRemaining", gclass85.EscapeTimeRemaining);
                    sqLiteCommand.Parameters.AddWithValue("@LastFleetDamageTime", gclass85.LastFleetDamageTime);
                    sqLiteCommand.Parameters.AddWithValue("@DetachedStanding", gclass85.bDetachedStanding);
                    sqLiteCommand.Parameters.AddWithValue("@DetachedConditional", gclass85.bDetachedCondition);
                    sqLiteCommand.Parameters.AddWithValue("@IncludeSquadrons", gclass85.bIncludeSquadrons);
                    sqLiteCommand.Parameters.AddWithValue("@IgnoreStanding", gclass85.bIgnoreStanding);
                    sqLiteCommand.Parameters.AddWithValue("@IgnoreConditional", gclass85.bIgnoreConditional);
                    sqLiteCommand.ExecuteNonQuery();
                    if (gclass85.Race.NPR || gclass85.ShippingLine != null)
                        gclass85.list_0 = gclass85.list_0.Where<GClass177>(gclass177_0 =>
                            gclass177_0.decimal_0 > this.GameTime - AuroraUtils.decimal_30).ToList<GClass177>();
                    foreach (GClass177 gclass177 in gclass85.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_FleetHistory ( GameID, FleetID, Description, GameTime ) VALUES ( @GameID, @FleetID, @Description, @GameTime )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@FleetID", gclass85.FleetID);
                        sqLiteCommand.Parameters.AddWithValue("@Description", gclass177.Description);
                        sqLiteCommand.Parameters.AddWithValue("@GameTime", gclass177.decimal_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (KeyValuePair<int, StandingOrderDefinition> keyValuePair in gclass85.StandingOrdersDictionary)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_FleetStandingOrder ( GameID, FleetID, StandingOrderID, Priority ) VALUES ( @GameID, @FleetID, @StandingOrderID, @Priority )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@FleetID", gclass85.FleetID);
                        sqLiteCommand.Parameters.AddWithValue("@StandingOrderID",
                            keyValuePair.Value.auroraStandingOrder_0);
                        sqLiteCommand.Parameters.AddWithValue("@Priority", keyValuePair.Key);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (KeyValuePair<int, FleetConditionalOrder> keyValuePair in gclass85.ConditionalOrdersDictionary)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_FleetConditionalOrder ( GameID, FleetID, ConditionalOrderID, ConditionID, Priority, CreateFWP ) VALUES ( @GameID, @FleetID, @ConditionalOrderID, @ConditionID, @Priority, @CreateFWP )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@FleetID", gclass85.FleetID);
                        sqLiteCommand.Parameters.AddWithValue("@ConditionalOrderID",
                            keyValuePair.Value.StandingOrder);
                        sqLiteCommand.Parameters.AddWithValue("@ConditionID",
                            keyValuePair.Value.Condition);
                        sqLiteCommand.Parameters.AddWithValue("@Priority", keyValuePair.Key);
                        sqLiteCommand.Parameters.AddWithValue("@CreateFWP", keyValuePair.Value.CreateFleetWaypoint);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1460);
        }
    }

    public void method_99(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_PopulationInstallations WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass158 gclass158 in this.PopulationDataDictionary.Values
                             .SelectMany<PopulationData, GClass158>(gclass146_0 => gclass146_0.dictionary_0.Values)
                             .ToList<GClass158>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_PopulationInstallations ( GameID, PopID, PlanetaryInstallationID, Amount ) VALUES ( @GameID, @PopID, @PlanetaryInstallationID, @Amount )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@PopID", gclass158.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@PlanetaryInstallationID",
                        gclass158.gclass157_0.InstallationType);
                    sqLiteCommand.Parameters.AddWithValue("@Amount", gclass158.decimal_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1461);
        }
    }

    public void method_100(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShipCargo WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (FCTShipData40 gclass40 in this.FCTShipDataDictionary.Values)
                {
                    foreach (GClass158 gclass158 in gclass40.dictionary_2.Values)
                    {
                        try
                        {
                            int num = 0;
                            if (gclass158.gclass146_1 != null)
                                num = gclass158.gclass146_1.PopulationID;
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_ShipCargo ( GameID, ShipID, CargoTypeID, CargoID, Amount, SpeciesID, StartingPop, Neutral ) VALUES ( @GameID, @ShipID, @CargoTypeID, @CargoID, @Amount, @SpeciesID, @StartingPop, @Neutral )";
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                            sqLiteCommand.Parameters.AddWithValue("@CargoTypeID", 2);
                            sqLiteCommand.Parameters.AddWithValue("@CargoID",
                                gclass158.gclass157_0.InstallationType);
                            sqLiteCommand.Parameters.AddWithValue("@Amount", gclass158.decimal_0);
                            sqLiteCommand.Parameters.AddWithValue("@SpeciesID", 0);
                            sqLiteCommand.Parameters.AddWithValue("@StartingPop", num);
                            sqLiteCommand.Parameters.AddWithValue("@Neutral", false);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            AuroraUtils.ShowExceptionPopup(ex, 3239);
                        }
                    }

                    foreach (GClass191 gclass191 in gclass40.dictionary_3.Values)
                    {
                        int num = 0;
                        if (gclass191.gclass146_0 != null)
                            num = gclass191.gclass146_0.PopulationID;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ShipCargo ( GameID, ShipID, CargoTypeID, CargoID, Amount, SpeciesID, StartingPop, Neutral ) VALUES ( @GameID, @ShipID, @CargoTypeID, @CargoID, @Amount, @SpeciesID, @StartingPop, @Neutral )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@CargoTypeID", 7);
                        sqLiteCommand.Parameters.AddWithValue("@CargoID", gclass191.gclass189_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass191.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@SpeciesID", 0);
                        sqLiteCommand.Parameters.AddWithValue("@StartingPop", num);
                        sqLiteCommand.Parameters.AddWithValue("@Neutral", false);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass181 gclass181 in gclass40.list_18)
                    {
                        int num = 0;
                        if (gclass181.gclass146_0 != null)
                            num = gclass181.gclass146_0.PopulationID;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ShipCargo ( GameID, ShipID, CargoTypeID, CargoID, Amount, SpeciesID, StartingPop, Neutral ) VALUES ( @GameID, @ShipID, @CargoTypeID, @CargoID, @Amount, @SpeciesID, @StartingPop, @Neutral )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@CargoTypeID", GEnum26.const_0);
                        sqLiteCommand.Parameters.AddWithValue("@CargoID", 0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass181.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass181.gclass194_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@StartingPop", num);
                        sqLiteCommand.Parameters.AddWithValue("@Neutral", gclass181.bool_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass73 gclass73 in gclass40.list_17)
                    {
                        int num = 0;
                        if (gclass73.gclass146_0 != null)
                            num = gclass73.gclass146_0.PopulationID;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ShipCargo ( GameID, ShipID, CargoTypeID, CargoID, Amount, SpeciesID, StartingPop, Neutral ) VALUES ( @GameID, @ShipID, @CargoTypeID, @CargoID, @Amount, @SpeciesID, @StartingPop, @Neutral )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@CargoTypeID", GEnum26.const_4);
                        sqLiteCommand.Parameters.AddWithValue("@CargoID", gclass73.gclass230_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass73.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@SpeciesID", 0);
                        sqLiteCommand.Parameters.AddWithValue("@StartingPop", num);
                        sqLiteCommand.Parameters.AddWithValue("@Neutral", false);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (SingleMineralValue gclass125 in gclass40.gclass123_0.GetAsSingleMineralValueList())
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ShipCargo ( GameID, ShipID, CargoTypeID, CargoID, Amount, SpeciesID, StartingPop, Neutral ) VALUES ( @GameID, @ShipID, @CargoTypeID, @CargoID, @Amount, @SpeciesID, @StartingPop, @Neutral )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@CargoTypeID", GEnum26.const_2);
                        sqLiteCommand.Parameters.AddWithValue("@CargoID", gclass125.auroraElement_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass125.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@SpeciesID", 0);
                        sqLiteCommand.Parameters.AddWithValue("@StartingPop", 0);
                        sqLiteCommand.Parameters.AddWithValue("@Neutral", false);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1462);
        }
    }

    public void method_101(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Population WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_PopulationWeapon WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_PopComponent WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_PopMDChanges WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_Prisoners WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_PopInstallationDemand WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (PopulationData gclass146 in this.PopulationDataDictionary.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    int num4 = 0;
                    AtmosphericGas genum47 = AtmosphericGas.const_0;
                    int num5 = 0;
                    int num6 = 0;
                    int num7 = 0;
                    if (gclass146.FighterDestFleet != null)
                        num1 = gclass146.FighterDestFleet.FleetID;
                    if (gclass146.SpaceStationDestFleet != null)
                        num2 = gclass146.SpaceStationDestFleet.FleetID;
                    if (gclass146.ParasiteSource != null)
                        num3 = gclass146.ParasiteSource.FleetID;
                    if (gclass146.GenModSpeciesData != null)
                        num4 = gclass146.GenModSpeciesData.int_0;
                    if (gclass146.TerraformingTargetGas != null)
                        genum47 = gclass146.TerraformingTargetGas.AtmosphericGas;
                    if (gclass146.MassDriverDestPopulation != null)
                        num5 = gclass146.MassDriverDestPopulation.PopulationID;
                    if (gclass146.gclass6_0 != null)
                        num6 = (int)gclass146.gclass6_0.genum97_0;
                    if (gclass146.gclass21_1 != null)
                        num7 = gclass146.gclass21_1.RaceID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Population ( PopulationID, GameID, RaceID, SpeciesID, PopName, AcademyOfficers, Capital, TerraformStatus, PurchaseCivilianMinerals, ColonistDestination, Efficiency, FighterDestFleetID, SpaceStationDestFleetID, ParasiteSourceID, FuelProdStatus, GeneticProdStatus, FuelStockpile, GenModSpeciesID, GroundAttackID, LastColonyCost, MaintenanceStockpile, MaintProdStatus, MassDriverDest, MaxAtm,\r\n                        NoStatusChange, PoliticalStatus, Population, PreviousUnrest, ProvideColonists, ReqInf, StatusPoints, SystemID, SystemBodyID, TempMF, TerraformingGasID, UnrestPoints, GroundGeoSurvey, DestroyedInstallationSize, Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite,\r\n                        LastDuranium, LastNeutronium, LastCorbomite, LastTritanium, LastBoronide, LastMercassium, LastVendarite, LastSorium, LastUridium, LastCorundium, LastGallicite, ReserveDuranium, ReserveNeutronium, ReserveCorbomite, ReserveTritanium, ReserveBoronide, ReserveMercassium, ReserveVendarite, ReserveSorium, ReserveUridium, ReserveCorundium, ReserveGallicite, \r\n                        AIValue, InvasionStagingPoint, OriginalRaceID, DoNotDelete, MilitaryRestrictedColony, AutoRefuel, AcademyName, BonusOne, BonusTwo, BonusThree, AutoAssign, Importance, AvailableColonists, ColonizationPressure, WarningFuel, WarningMSP, WarningConstant) \r\n                        VALUES ( @PopulationID, @GameID, @RaceID, @SpeciesID, @PopName, @AcademyOfficers, @Capital, @TerraformStatus, @PurchaseCivilianMinerals, @ColonistDestination, @Efficiency, @FighterDestFleetID, @SpaceStationDestFleetID, @ParasiteSourceID, @FuelProdStatus, @GeneticProdStatus, @FuelStockpile, @GenModSpeciesID, @GroundAttackID, @LastColonyCost, @MaintenanceStockpile, @MaintProdStatus, @MassDriverDest, @MaxAtm,\r\n                        @NoStatusChange, @PoliticalStatus, @Population, @PreviousUnrest, @ProvideColonists, @ReqInf, @StatusPoints, @SystemID, @SystemBodyID, @TempMF, @TerraformingGasID, @UnrestPoints, @GroundGeoSurvey, @DestroyedInstallationSize, @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite,\r\n                        @LastDuranium, @LastNeutronium, @LastCorbomite, @LastTritanium, @LastBoronide, @LastMercassium, @LastVendarite, @LastSorium, @LastUridium, @LastCorundium, @LastGallicite, @ReserveDuranium, @ReserveNeutronium, @ReserveCorbomite, @ReserveTritanium, @ReserveBoronide, @ReserveMercassium, @ReserveVendarite, @ReserveSorium, @ReserveUridium, @ReserveCorundium, @ReserveGallicite, \r\n                        @AIValue, @InvasionStagingPoint, @OriginalRaceID, @DoNotDelete, @MilitaryRestrictedColony, @AutoRefuel, @AcademyName, @BonusOne, @BonusTwo, @BonusThree, @AutoAssign, @Importance, @AvailableColonists, @ColonizationPressure, @WarningFuel, @WarningMSP, @WarningConstant)";
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass146.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass146.RaceData.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass146.SpeciesData.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@PopName", gclass146.PopName);
                    sqLiteCommand.Parameters.AddWithValue("@AcademyOfficers", gclass146.AcademyOfficers);
                    sqLiteCommand.Parameters.AddWithValue("@Capital", gclass146.bIsCapital);
                    sqLiteCommand.Parameters.AddWithValue("@TerraformStatus", gclass146.TerraformStatus);
                    sqLiteCommand.Parameters.AddWithValue("@PurchaseCivilianMinerals", gclass146.bPurchaseCivilianMineral);
                    sqLiteCommand.Parameters.AddWithValue("@ColonistDestination", gclass146.ColonistDestinationSetting);
                    sqLiteCommand.Parameters.AddWithValue("@Efficiency", gclass146.Efficiency);
                    sqLiteCommand.Parameters.AddWithValue("@FighterDestFleetID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@SpaceStationDestFleetID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@ParasiteSourceID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@FuelProdStatus", gclass146.bFuelProdStatus);
                    sqLiteCommand.Parameters.AddWithValue("@GeneticProdStatus", gclass146.bGeneticProdStatus);
                    sqLiteCommand.Parameters.AddWithValue("@FuelStockpile", gclass146.FuelStockpile);
                    sqLiteCommand.Parameters.AddWithValue("@GenModSpeciesID", num4);
                    sqLiteCommand.Parameters.AddWithValue("@GroundAttackID", gclass146.GroundAttackID);
                    sqLiteCommand.Parameters.AddWithValue("@LastColonyCost", gclass146.LastColonyCost);
                    sqLiteCommand.Parameters.AddWithValue("@MaintenanceStockpile", gclass146.MaintenanceStockpile);
                    sqLiteCommand.Parameters.AddWithValue("@MaintProdStatus", gclass146.bMaintProdStatus);
                    sqLiteCommand.Parameters.AddWithValue("@MassDriverDest", num5);
                    sqLiteCommand.Parameters.AddWithValue("@MaxAtm", gclass146.MaxAtm);
                    sqLiteCommand.Parameters.AddWithValue("@NoStatusChange", gclass146.NoStatusChange);
                    sqLiteCommand.Parameters.AddWithValue("@PoliticalStatus", gclass146.PopulationPoliticalStatus.PoliticalStatusType);
                    sqLiteCommand.Parameters.AddWithValue("@Population", gclass146.Population);
                    sqLiteCommand.Parameters.AddWithValue("@PreviousUnrest", gclass146.PreviousUnrest);
                    sqLiteCommand.Parameters.AddWithValue("@ProvideColonists", gclass146.ProvideColonists);
                    sqLiteCommand.Parameters.AddWithValue("@ReqInf", gclass146.ReqInf);
                    sqLiteCommand.Parameters.AddWithValue("@StatusPoints", gclass146.StatusPoints);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass146.gclass202_0.ActualSystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass146.SystemBodyData.SystemBodyID);
                    sqLiteCommand.Parameters.AddWithValue("@TempMF", gclass146.TempMF);
                    sqLiteCommand.Parameters.AddWithValue("@TerraformingGasID", genum47);
                    sqLiteCommand.Parameters.AddWithValue("@UnrestPoints", gclass146.UnrestPoints);
                    sqLiteCommand.Parameters.AddWithValue("@GroundGeoSurvey", gclass146.GroundGeoSurvey);
                    sqLiteCommand.Parameters.AddWithValue("@DestroyedInstallationSize", gclass146.DestroyedInstallationSize);
                    sqLiteCommand.Parameters.AddWithValue("@AvailableColonists", gclass146.AvailableColonists);
                    sqLiteCommand.Parameters.AddWithValue("@ColonizationPressure", gclass146.ColonizationPressure);
                    sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass146.CurrentMinerals.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass146.CurrentMinerals.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass146.CurrentMinerals.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass146.CurrentMinerals.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass146.CurrentMinerals.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass146.CurrentMinerals.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass146.CurrentMinerals.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass146.CurrentMinerals.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass146.CurrentMinerals.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass146.CurrentMinerals.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass146.CurrentMinerals.Gallicite);
                    sqLiteCommand.Parameters.AddWithValue("@LastDuranium", gclass146.LastMinerals.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@LastNeutronium", gclass146.LastMinerals.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@LastCorbomite", gclass146.LastMinerals.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@LastTritanium", gclass146.LastMinerals.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@LastBoronide", gclass146.LastMinerals.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@LastMercassium", gclass146.LastMinerals.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@LastVendarite", gclass146.LastMinerals.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@LastSorium", gclass146.LastMinerals.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@LastUridium", gclass146.LastMinerals.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@LastCorundium", gclass146.LastMinerals.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@LastGallicite", gclass146.LastMinerals.Gallicite);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveDuranium", gclass146.ReserveMinerals.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveNeutronium", gclass146.ReserveMinerals.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveCorbomite", gclass146.ReserveMinerals.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveTritanium", gclass146.ReserveMinerals.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveBoronide", gclass146.ReserveMinerals.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveMercassium", gclass146.ReserveMinerals.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveVendarite", gclass146.ReserveMinerals.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveSorium", gclass146.ReserveMinerals.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveUridium", gclass146.ReserveMinerals.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveCorundium", gclass146.ReserveMinerals.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@ReserveGallicite", gclass146.ReserveMinerals.Gallicite);
                    sqLiteCommand.Parameters.AddWithValue("@AIValue", num6);
                    sqLiteCommand.Parameters.AddWithValue("@InvasionStagingPoint", gclass146.bIsInvasionStagingPoint);
                    sqLiteCommand.Parameters.AddWithValue("@OriginalRaceID", num7);
                    sqLiteCommand.Parameters.AddWithValue("@DoNotDelete", gclass146.bDoNotDelete);
                    sqLiteCommand.Parameters.AddWithValue("@MilitaryRestrictedColony", gclass146.bMilitaryRestrictedColony);
                    sqLiteCommand.Parameters.AddWithValue("@AcademyName", gclass146.AcademyName);
                    sqLiteCommand.Parameters.AddWithValue("@AutoRefuel", gclass146.bAutoRefuel);
                    sqLiteCommand.Parameters.AddWithValue("@BonusOne", gclass146.BonusOne);
                    sqLiteCommand.Parameters.AddWithValue("@BonusTwo", gclass146.BonusTwo);
                    sqLiteCommand.Parameters.AddWithValue("@BonusThree", gclass146.BonusThree);
                    sqLiteCommand.Parameters.AddWithValue("@AutoAssign", gclass146.genum64_0);
                    sqLiteCommand.Parameters.AddWithValue("@Importance", gclass146.Importance);
                    sqLiteCommand.Parameters.AddWithValue("@WarningFuel", gclass146.WarningFuel);
                    sqLiteCommand.Parameters.AddWithValue("@WarningMSP", gclass146.WarningMSP);
                    sqLiteCommand.Parameters.AddWithValue("@WarningConstant", gclass146.WarningConstant);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (GClass130 gclass130 in gclass146.list_1)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_PopulationWeapon (GameID, PopulationID, MissileID, Amount ) VALUES ( @GameID, @PopulationID, @MissileID, @Amount )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass146.PopulationID);
                        sqLiteCommand.Parameters.AddWithValue("@MissileID", gclass130.gclass129_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass130.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass147 gclass147 in gclass146.list_3)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_Prisoners (GameID, NumPrisoners, NumProcessed, PopulationID, PrisonerRaceID, PrisonerSpeciesID ) VALUES ( @GameID, @NumPrisoners, @NumProcessed, @PopulationID, @PrisonerRaceID, @PrisonerSpeciesID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@NumPrisoners", gclass147.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@NumProcessed", gclass147.int_1);
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass146.PopulationID);
                        sqLiteCommand.Parameters.AddWithValue("@PrisonerRaceID", gclass147.gclass21_0.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@PrisonerSpeciesID", gclass147.gclass194_0.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass73 gclass73 in gclass146.list_2)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_PopComponent (ComponentID, PopulationID, GameID, Amount ) VALUES ( @ComponentID, @PopulationID, @GameID, @Amount )";
                        sqLiteCommand.Parameters.AddWithValue("@ComponentID", gclass73.gclass230_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass146.PopulationID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass73.decimal_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass148 gclass148 in gclass146.dictionary_5.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_PopInstallationDemand (PopulationID, InstallationID, Amount, GameID, Export, NonEssential ) VALUES ( @PopulationID, @InstallationID, @Amount, @GameID, @Export, @NonEssential )";
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass146.PopulationID);
                        sqLiteCommand.Parameters.AddWithValue("@InstallationID",
                            gclass148.gclass157_0.InstallationType);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass148.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@Export", gclass148.bool_0);
                        sqLiteCommand.Parameters.AddWithValue("@NonEssential", gclass148.bool_1);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    if (gclass146.gclass123_3.HasAnyNonZeroMineralValue())
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_PopMDChanges (PopulationID, GameID, Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite ) VALUES ( @PopulationID, @GameID, @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite )";
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass146.PopulationID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass146.gclass123_3.Duranium);
                        sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass146.gclass123_3.Neutronium);
                        sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass146.gclass123_3.Corbomite);
                        sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass146.gclass123_3.Tritanium);
                        sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass146.gclass123_3.Boronide);
                        sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass146.gclass123_3.Mercassium);
                        sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass146.gclass123_3.Vendarite);
                        sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass146.gclass123_3.Sorium);
                        sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass146.gclass123_3.Uridium);
                        sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass146.gclass123_3.Corundium);
                        sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass146.gclass123_3.Gallicite);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1463);
        }
    }

    public void method_102(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MineralDeposit WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass124 gclass124 in this.SystemBodyRecordDic.Values
                             .SelectMany<SystemBodyData, GClass124>(gclass1_0 =>
                                 this.gclass1_0.dictionary_0.Values).ToList<GClass124>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MineralDeposit ( GameID, MaterialID, SystemID, SystemBodyID, Amount, Accessibility, HalfOriginalAmount, OriginalAcc ) VALUES ( @GameID, @MaterialID, @SystemID, @SystemBodyID, @Amount, @Accessibility, @HalfOriginalAmount, @OriginalAcc )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@MaterialID", gclass124.auroraElement_0);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", this.SystemBodyRecordDic[gclass124.int_0].SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass124.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Amount", gclass124.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@Accessibility", gclass124.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@HalfOriginalAmount", gclass124.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@OriginalAcc", gclass124.decimal_3);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1464);
        }
    }

    public void method_103(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShipClass WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ClassMaterials WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ClassOrdnanceTemplate WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ClassComponent WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ClassSC WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ClassGroundTemplates WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                int num1 = 0;
                foreach (GClass22 gclass22 in this.dictionary_3.Values)
                {
                    int num2 = 0;
                    num1 = 0;
                    int num3 = 0;
                    AutomatedClassDesignType genum120 = AutomatedClassDesignType.const_0;
                    int num4 = 0;
                    int num5 = 25;
                    if (gclass22.gclass187_0 != null)
                        num2 = gclass22.gclass187_0.int_0;
                    if (gclass22.gclass163_0 != null)
                        num3 = (int)gclass22.gclass163_0.TechType;
                    if (gclass22.gclass14_0 != null)
                        genum120 = gclass22.gclass14_0.AutomatedClassDesignTypeID;
                    if (gclass22.gclass140_0 != null)
                        num4 = gclass22.gclass140_0.ThemeID;
                    if (gclass22.gclass76_0 != null)
                        num5 = gclass22.gclass76_0.ShipHullDescriptionID;
                    int num6 = gclass22.gclass61_0 != null
                        ? gclass22.gclass21_0.method_254(gclass22.gclass61_0, AuroraCommanderType.Naval)
                        : gclass22.int_18;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ShipClass (ShipClassID, ClassShippingLineID, AutomatedDesignID, ClassName, GameID, RaceID, ActiveSensorStrength, ArmourThickness, ArmourWidth, BaseFailureChance, CargoCapacity, ClassCrossSection, ClassThermal, Collier, ColonistCapacity, CommanderPriority, CommercialJumpDrive, MilitaryEngines, ControlRating, ConscriptOnly, \r\n                        Cost, Crew, CrewQuartersHS, TroopTransportType, DCRating, ActiveJammerStrength, FireControlJammerStrength, MissileJammerStrength, MissileJammerCount, ELINTRating, DiplomacyRating, BioEnergyCapacity, ClassHullNumbers, NoOfficers, RepairYardCapacity, ArkShip, FlagBridge,\r\n                        EMSensorStrength, EnginePower, ESMaxDACRoll, FighterClass, Commercial, FuelCapacity, FuelEfficiency, FuelTanker, GeoSurvey, GravSurvey, Harvesters, HullDescriptionID, JGConstructionTime, JumpDistance, JumpRating, Locked, MagazineCapacity, DecoyCapacity, MaxChance, MaxDACRoll, MaxSpeed, MaintModules, MinimumFuel, MinimumSupplies, MiningModules, NameThemeID, NoArmour, \r\n                        Notes, MainFunction, Obsolete, OtherRaceClassID, ParasiteCapacity, PassiveSensorStrength, PlannedDeployment, PreTNT, ProtectionValue, RankRequired, ReactorPower, RecreationalModule, MoraleCheckRequired, RefuelPriority, ResupplyPriority, RefuellingRate, RequiredPower, SalvageRate, SensorReduction, ShieldStrength, Size, MaintSupplies, STSTractor, \r\n                        SupplyShip, Terraformers, TotalNumber, CargoShuttleStrength, TroopCapacity, WorkerCapacity, MaintPriority, CommercialHangar, OrdnanceTransferRate, OrdnanceTransferHub, SeniorCO, PrefixName, SuffixName, RandomShipNameFromTheme, PDProtectionPriority, CrewDesignEfficiency) \r\n                        VALUES ( @ShipClassID, @ClassShippingLineID, @AutomatedDesignID, @ClassName, @GameID, @RaceID, @ActiveSensorStrength, @ArmourThickness, @ArmourWidth, @BaseFailureChance, @CargoCapacity, @ClassCrossSection, @ClassThermal, @Collier, @ColonistCapacity, @CommanderPriority, @CommercialJumpDrive, @MilitaryEngines, @ControlRating, @ConscriptOnly, \r\n                        @Cost, @Crew, @CrewQuartersHS, @TroopTransportType, @DCRating, @ActiveJammerStrength, @FireControlJammerStrength, @MissileJammerStrength, @MissileJammerCount,@ELINTRating, @DiplomacyRating, @BioEnergyCapacity, @ClassHullNumbers, @NoOfficers, @RepairYardCapacity, @ArkShip, @FlagBridge,\r\n                        @EMSensorStrength, @EnginePower, @ESMaxDACRoll, @FighterClass, @Commercial, @FuelCapacity, @FuelEfficiency, @FuelTanker, @GeoSurvey, @GravSurvey, @Harvesters, @HullDescriptionID, @JGConstructionTime, @JumpDistance, @JumpRating, @Locked, @MagazineCapacity, @DecoyCapacity, @MaxChance, @MaxDACRoll, @MaxSpeed, @MaintModules, @MinimumFuel, @MinimumSupplies, @MiningModules, @NameThemeID, @NoArmour,\r\n                        @Notes, @MainFunction, @Obsolete, @OtherRaceClassID, @ParasiteCapacity, @PassiveSensorStrength, @PlannedDeployment, @PreTNT, @ProtectionValue, @RankRequired, @ReactorPower, @RecreationalModule, @MoraleCheckRequired, @RefuelPriority, @ResupplyPriority, @RefuellingRate, @RequiredPower, @SalvageRate, @SensorReduction, @ShieldStrength, @Size, @MaintSupplies, @STSTractor, \r\n                        @SupplyShip, @Terraformers, @TotalNumber, @CargoShuttleStrength, @TroopCapacity, @WorkerCapacity, @MaintPriority, @CommercialHangar, @OrdnanceTransferRate, @OrdnanceTransferHub, @SeniorCO, @PrefixName, @SuffixName, @RandomShipNameFromTheme, @PDProtectionPriority, @CrewDesignEfficiency)";
                    sqLiteCommand.Parameters.AddWithValue("@ShipClassID", gclass22.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ClassShippingLineID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@AutomatedDesignID", genum120);
                    sqLiteCommand.Parameters.AddWithValue("@ClassName", gclass22.ClassName);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass22.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ActiveSensorStrength", gclass22.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourThickness", gclass22.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourWidth", gclass22.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@BaseFailureChance", gclass22.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@CargoCapacity", gclass22.int_62);
                    sqLiteCommand.Parameters.AddWithValue("@ClassCrossSection", gclass22.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@ClassThermal", gclass22.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@Collier", gclass22.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@SeniorCO", gclass22.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@ColonistCapacity", gclass22.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@CommanderPriority", gclass22.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@CommercialJumpDrive", gclass22.int_14);
                    sqLiteCommand.Parameters.AddWithValue("@MilitaryEngines", gclass22.bool_8);
                    sqLiteCommand.Parameters.AddWithValue("@ControlRating", gclass22.int_9);
                    sqLiteCommand.Parameters.AddWithValue("@ConscriptOnly", gclass22.int_10);
                    sqLiteCommand.Parameters.AddWithValue("@NoOfficers", gclass22.int_15);
                    sqLiteCommand.Parameters.AddWithValue("@Cost", gclass22.decimal_4);
                    sqLiteCommand.Parameters.AddWithValue("@Crew", gclass22.int_11);
                    sqLiteCommand.Parameters.AddWithValue("@CrewQuartersHS", gclass22.decimal_5);
                    sqLiteCommand.Parameters.AddWithValue("@TroopTransportType", num3);
                    sqLiteCommand.Parameters.AddWithValue("@DCRating", gclass22.int_17);
                    sqLiteCommand.Parameters.AddWithValue("@ActiveJammerStrength", gclass22.decimal_18);
                    sqLiteCommand.Parameters.AddWithValue("@FireControlJammerStrength", gclass22.decimal_19);
                    sqLiteCommand.Parameters.AddWithValue("@MissileJammerStrength", gclass22.decimal_20);
                    sqLiteCommand.Parameters.AddWithValue("@MissileJammerCount", gclass22.int_20);
                    sqLiteCommand.Parameters.AddWithValue("@ELINTRating", gclass22.int_12);
                    sqLiteCommand.Parameters.AddWithValue("@DiplomacyRating", gclass22.int_13);
                    sqLiteCommand.Parameters.AddWithValue("@EMSensorStrength", gclass22.int_21);
                    sqLiteCommand.Parameters.AddWithValue("@EnginePower", gclass22.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@ESMaxDACRoll", gclass22.int_22);
                    sqLiteCommand.Parameters.AddWithValue("@FighterClass", gclass22.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@Commercial", gclass22.bool_2);
                    sqLiteCommand.Parameters.AddWithValue("@FuelCapacity", gclass22.int_63);
                    sqLiteCommand.Parameters.AddWithValue("@FuelEfficiency", gclass22.decimal_6);
                    sqLiteCommand.Parameters.AddWithValue("@FuelTanker", gclass22.int_23);
                    sqLiteCommand.Parameters.AddWithValue("@GeoSurvey", gclass22.decimal_17);
                    sqLiteCommand.Parameters.AddWithValue("@GravSurvey", gclass22.int_24);
                    sqLiteCommand.Parameters.AddWithValue("@Harvesters", gclass22.int_25);
                    sqLiteCommand.Parameters.AddWithValue("@HullDescriptionID", num5);
                    sqLiteCommand.Parameters.AddWithValue("@JGConstructionTime", gclass22.int_27);
                    sqLiteCommand.Parameters.AddWithValue("@JumpDistance", gclass22.int_28);
                    sqLiteCommand.Parameters.AddWithValue("@JumpRating", gclass22.int_29);
                    sqLiteCommand.Parameters.AddWithValue("@Locked", gclass22.bool_3);
                    sqLiteCommand.Parameters.AddWithValue("@MagazineCapacity", gclass22.decimal_11);
                    sqLiteCommand.Parameters.AddWithValue("@DecoyCapacity", gclass22.decimal_12);
                    sqLiteCommand.Parameters.AddWithValue("@MaxChance", gclass22.int_30);
                    sqLiteCommand.Parameters.AddWithValue("@MaxDACRoll", gclass22.int_31);
                    sqLiteCommand.Parameters.AddWithValue("@MaxSpeed", gclass22.int_32);
                    sqLiteCommand.Parameters.AddWithValue("@MaintModules", gclass22.int_33);
                    sqLiteCommand.Parameters.AddWithValue("@MinimumFuel", gclass22.int_46);
                    sqLiteCommand.Parameters.AddWithValue("@MinimumSupplies", gclass22.int_47);
                    sqLiteCommand.Parameters.AddWithValue("@MiningModules", gclass22.int_36);
                    sqLiteCommand.Parameters.AddWithValue("@NameThemeID", num4);
                    sqLiteCommand.Parameters.AddWithValue("@NoArmour", gclass22.int_37);
                    sqLiteCommand.Parameters.AddWithValue("@Notes", gclass22.string_1);
                    sqLiteCommand.Parameters.AddWithValue("@MainFunction", gclass22.auroraClassMainFunction_0);
                    sqLiteCommand.Parameters.AddWithValue("@Obsolete", gclass22.int_38);
                    sqLiteCommand.Parameters.AddWithValue("@OtherRaceClassID", gclass22.int_39);
                    sqLiteCommand.Parameters.AddWithValue("@ParasiteCapacity", gclass22.decimal_8);
                    sqLiteCommand.Parameters.AddWithValue("@PassiveSensorStrength", gclass22.int_40);
                    sqLiteCommand.Parameters.AddWithValue("@PlannedDeployment", gclass22.decimal_9);
                    sqLiteCommand.Parameters.AddWithValue("@PreTNT", gclass22.bool_4);
                    sqLiteCommand.Parameters.AddWithValue("@ProtectionValue", gclass22.decimal_10);
                    sqLiteCommand.Parameters.AddWithValue("@RankRequired", num6);
                    sqLiteCommand.Parameters.AddWithValue("@ReactorPower", gclass22.decimal_15);
                    sqLiteCommand.Parameters.AddWithValue("@RecreationalModule", gclass22.bool_5);
                    sqLiteCommand.Parameters.AddWithValue("@MoraleCheckRequired", gclass22.bool_7);
                    sqLiteCommand.Parameters.AddWithValue("@RefuelPriority", gclass22.int_44);
                    sqLiteCommand.Parameters.AddWithValue("@ResupplyPriority", gclass22.int_45);
                    sqLiteCommand.Parameters.AddWithValue("@RefuellingRate", gclass22.int_43);
                    sqLiteCommand.Parameters.AddWithValue("@RequiredPower", gclass22.decimal_16);
                    sqLiteCommand.Parameters.AddWithValue("@SalvageRate", gclass22.int_41);
                    sqLiteCommand.Parameters.AddWithValue("@SensorReduction", gclass22.decimal_13);
                    sqLiteCommand.Parameters.AddWithValue("@ShieldStrength", gclass22.int_42);
                    sqLiteCommand.Parameters.AddWithValue("@Size", gclass22.decimal_14);
                    sqLiteCommand.Parameters.AddWithValue("@MaintSupplies", gclass22.int_50);
                    sqLiteCommand.Parameters.AddWithValue("@STSTractor", gclass22.int_51);
                    sqLiteCommand.Parameters.AddWithValue("@SupplyShip", gclass22.int_52);
                    sqLiteCommand.Parameters.AddWithValue("@Terraformers", gclass22.int_53);
                    sqLiteCommand.Parameters.AddWithValue("@TotalNumber", gclass22.int_55);
                    sqLiteCommand.Parameters.AddWithValue("@CargoShuttleStrength", gclass22.int_56);
                    sqLiteCommand.Parameters.AddWithValue("@TroopCapacity", gclass22.int_57);
                    sqLiteCommand.Parameters.AddWithValue("@WorkerCapacity", gclass22.int_58);
                    sqLiteCommand.Parameters.AddWithValue("@MaintPriority", gclass22.int_34);
                    sqLiteCommand.Parameters.AddWithValue("@CommercialHangar", gclass22.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@OrdnanceTransferRate", gclass22.int_48);
                    sqLiteCommand.Parameters.AddWithValue("@OrdnanceTransferHub", gclass22.int_54);
                    sqLiteCommand.Parameters.AddWithValue("@BioEnergyCapacity", gclass22.int_64);
                    sqLiteCommand.Parameters.AddWithValue("@PrefixName", gclass22.string_3);
                    sqLiteCommand.Parameters.AddWithValue("@SuffixName", gclass22.string_4);
                    sqLiteCommand.Parameters.AddWithValue("@RandomShipNameFromTheme", gclass22.int_35);
                    sqLiteCommand.Parameters.AddWithValue("@ClassHullNumbers", gclass22.int_65);
                    sqLiteCommand.Parameters.AddWithValue("@RepairYardCapacity", gclass22.int_19);
                    sqLiteCommand.Parameters.AddWithValue("@ArkShip", gclass22.bool_9);
                    sqLiteCommand.Parameters.AddWithValue("@PDProtectionPriority", gclass22.int_16);
                    sqLiteCommand.Parameters.AddWithValue("@CrewDesignEfficiency", gclass22.decimal_21);
                    sqLiteCommand.Parameters.AddWithValue("@FlagBridge", gclass22.bool_10);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (SingleMineralValue gclass125 in gclass22.gclass123_0.GetAsSingleMineralValueList())
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ClassMaterials ( GameID, ClassID, MaterialID, Amount ) VALUES ( @GameID, @ClassID, @MaterialID, @Amount )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ClassID", gclass22.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@MaterialID", gclass125.auroraElement_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass125.decimal_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass130 gclass130 in gclass22.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ClassOrdnanceTemplate (GameID, ShipClassID, MissileID, Amount ) VALUES ( @GameID, @ShipClassID, @MissileID, @Amount )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipClassID", gclass22.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@MissileID", gclass130.gclass129_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass130.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass228 gclass228 in gclass22.dictionary_0.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ClassComponent (GameID, ClassID, ComponentID, NumComponent, ChanceToHit, ElectronicCTH ) VALUES ( @GameID, @ClassID, @ComponentID, @NumComponent, @ChanceToHit, @ElectronicCTH )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipClassID", gclass22.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@ComponentID", gclass228.gclass230_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@NumComponent", gclass228.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@ChanceToHit", gclass228.int_2);
                        sqLiteCommand.Parameters.AddWithValue("@ElectronicCTH", gclass228.int_3);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass74 gclass74 in gclass22.list_1)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ClassSC (GameID, ShipClassID, FighterClassID, Number ) VALUES ( @GameID, @ShipClassID, @FighterClassID, @Number )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipClassID", gclass22.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@FighterClassID", gclass74.gclass22_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Number", gclass74.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass75 gclass75 in gclass22.list_2)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ClassGroundTemplates (GameID, ShipClassID, TemplateID, Number ) VALUES ( @GameID, @ShipClassID, @TemplateID, @Number )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipClassID", gclass22.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@TemplateID", gclass75.gclass102_0.TemplateID);
                        sqLiteCommand.Parameters.AddWithValue("@Number", gclass75.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1465);
        }
    }

    public void method_104(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_SystemBodyName WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass218 gclass218 in this.SystemBodyRecordDic.Values
                             .SelectMany<SystemBodyData, GClass218>(gclass1_0 =>
                                 this.gclass1_0.dictionary_1.Values).ToList<GClass218>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_SystemBodyName ( RaceID, SystemBodyID, GameID, SystemID, Name ) VALUES ( @RaceID, @SystemBodyID, @GameID, @SystemID, @Name )";
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass218.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass218.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", this.SystemBodyRecordDic[gclass218.int_0].SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass218.string_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1466);
        }
    }

    public void method_105(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Survivors WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass180 gclass180 in this.FCTShipDataDictionary.Values
                             .SelectMany<FCTShipData40, GClass180>(gclass40_0 => gclass40_0.list_1).ToList<GClass180>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Survivors ( GameID, RaceID, SpeciesID, ShipID, Crew ) VALUES ( @GameID, @RaceID, @SpeciesID, @ShipID, @Crew )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass180.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass180.gclass194_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass180.gclass40_0.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@Crew", gclass180.int_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1467);
        }
    }

    public void method_106(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AncientConstruct WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass220 gclass220 in this.dictionary_27.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AncientConstruct ( AncientConstructID, GameID, SystemBodyID, AncientConstructTypeID, ResearchField, ResearchBonus, Active ) VALUES ( @AncientConstructID, @GameID, @SystemBodyID, @AncientConstructTypeID, @ResearchField, @ResearchBonus, @Active )";
                    sqLiteCommand.Parameters.AddWithValue("@AncientConstructID", gclass220.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass220.gclass1_0.SystemBodyID);
                    sqLiteCommand.Parameters.AddWithValue("@AncientConstructTypeID", gclass220.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@ResearchField", gclass220.gclass162_0.ResearchFieldID);
                    sqLiteCommand.Parameters.AddWithValue("@ResearchBonus", gclass220.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@Active", gclass220.bool_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1468);
        }
    }

    public void method_107(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MissileGeoSurvey WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass216 gclass216 in this.list_10)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MissileGeoSurvey ( SystemBodyID, RaceID, SurveyPoints, GameID ) VALUES ( @SystemBodyID, @RaceID, @SurveyPoints, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass216.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass216.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@SurveyPoints", gclass216.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1469);
        }
    }

    public void method_108(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_RuinRace WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (RuinRaceData gclass171 in this.RuinRaceDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_RuinRace (RuinRaceID, GameID, Title, Name, RacePic, FlagPic, Level) \r\n                        VALUES ( @RuinRaceID, @GameID, @Title, @Name, @RacePic, @FlagPic, @Level)";
                    sqLiteCommand.Parameters.AddWithValue("@RuinRaceID", gclass171.RuinRaceID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@Title", gclass171.Title);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass171.Name);
                    sqLiteCommand.Parameters.AddWithValue("@RacePic", gclass171.RacePic);
                    sqLiteCommand.Parameters.AddWithValue("@FlagPic", gclass171.FlagPic);
                    sqLiteCommand.Parameters.AddWithValue("@Level", gclass171.Level);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1470);
        }
    }

    public void method_109(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Ship WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ShipWeapon WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ShipOrdnanceTemplate WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_DamagedComponent WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ShipHistory WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_WeaponRecharge WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_WeaponAssignment WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_DecoyAssignment WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_FireControlAssignment WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_MissileAssignment WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ArmourDamage WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ShipMeasurement WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (FCTShipData40 gclass40 in this.FCTShipDataDictionary.Values)
                {
                    try
                    {
                        int num1 = 0;
                        int num2 = 0;
                        int num3 = 0;
                        int num4 = 0;
                        int num5 = 0;
                        int num6 = 0;
                        int num7 = 0;
                        int num8 = 0;
                        int num9 = 0;
                        if (gclass40.gclass84_0 != null)
                            num1 = gclass40.gclass84_0.SubFleetID;
                        if (gclass40.gclass40_1 != null)
                            num2 = gclass40.gclass40_1.int_8;
                        if (gclass40.gclass40_0 != null)
                            num3 = gclass40.gclass40_0.int_8;
                        if (gclass40.gclass187_0 != null)
                            num4 = gclass40.gclass187_0.int_0;
                        if (gclass40.gclass40_2 != null)
                            num6 = gclass40.gclass40_2.int_8;
                        if (gclass40.gclass193_0 != null)
                            num5 = gclass40.gclass193_0.int_0;
                        if (gclass40.gclass40_3 != null)
                            num7 = gclass40.gclass40_3.int_8;
                        if (gclass40.gclass103_0 != null)
                            num8 = gclass40.gclass103_0.FormationID;
                        if (gclass40.SquadronData != null)
                            num9 = gclass40.SquadronData.SquadronID;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_Ship (ShipID, GameID, FleetID, ShipName, SubFleetID, ActiveSensorsOn, AssignedMSID, Autofire, BoardingCombatClock, Constructed, CrewMorale, CurrentCrew, CurrentShieldStrength, CurrentMaintSupplies, DamageControlID, Destroyed, FireDelay, Fuel, GradePoints, HoldTechData, \r\n                                LastLaunchTime, LastMissileHitTime, LastBeamHitTime, LastShipDamageTime, LastPenetratingDamageTime, LastOverhaul, BioEnergy, OverhaulFactor, LastShoreLeave, LaunchMorale, MaintenanceState, MothershipID, RaceID, RefuelPriority, ResupplyPriority, RefuelStatus, OrdnanceTransferStatus, ScrapFlag, SensorDelay, \r\n                                ShieldsActive, ShipClassID, ShipNotes, ShippingLineID, SpeciesID, ParentSquadronID, SyncFire, TFPoints, TractorTargetShipID, TractorTargetShipyardID, TractorParentShipID, TransponderActive, HangarLoadType, AutomatedDamageControl, AssignedFormationID, DistanceTravelled, HullNumber, \r\n                                AssignedSquadronID, LastFiringTime, LastTransitTime, ResupplyStatus, DecoyThreshold, DesignateAsTarget, LoadDistance ) \r\n                        VALUES ( @ShipID, @GameID, @FleetID, @ShipName, @SubFleetID, @ActiveSensorsOn, @AssignedMSID, @Autofire, @BoardingCombatClock, @Constructed, @CrewMorale, @CurrentCrew, @CurrentShieldStrength, @CurrentMaintSupplies, @DamageControlID, @Destroyed, @FireDelay, @Fuel, @GradePoints, @HoldTechData, \r\n                                @LastLaunchTime, @LastMissileHitTime, @LastBeamHitTime, @LastShipDamageTime, @LastPenetratingDamageTime, @LastOverhaul, @BioEnergy, @OverhaulFactor, @LastShoreLeave, @LaunchMorale, @MaintenanceState, @MothershipID, @RaceID, @RefuelPriority, @ResupplyPriority, @RefuelStatus, @OrdnanceTransferStatus, @ScrapFlag, @SensorDelay, \r\n                                @ShieldsActive, @ShipClassID, @ShipNotes, @ShippingLineID, @SpeciesID, @ParentSquadronID, @SyncFire, @TFPoints, @TractorTargetShipID, @TractorTargetShipyardID, @TractorParentShipID, @TransponderActive, @HangarLoadType, @AutomatedDamageControl, @AssignedFormationID, @DistanceTravelled, @HullNumber, \r\n                                @AssignedSquadronID, @LastFiringTime, @LastTransitTime, @ResupplyStatus, @DecoyThreshold, @DesignateAsTarget, @LoadDistance )";
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@FleetID", gclass40.gclass85_0.FleetID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipName", gclass40.ShipName);
                        sqLiteCommand.Parameters.AddWithValue("@SubFleetID", num1);
                        sqLiteCommand.Parameters.AddWithValue("@ActiveSensorsOn", gclass40.bool_8);
                        sqLiteCommand.Parameters.AddWithValue("@AssignedMSID", num2);
                        sqLiteCommand.Parameters.AddWithValue("@Autofire", gclass40.int_9);
                        sqLiteCommand.Parameters.AddWithValue("@BoardingCombatClock", gclass40.int_10);
                        sqLiteCommand.Parameters.AddWithValue("@Constructed", gclass40.decimal_1);
                        sqLiteCommand.Parameters.AddWithValue("@CrewMorale", gclass40.decimal_2);
                        sqLiteCommand.Parameters.AddWithValue("@CurrentCrew", gclass40.int_11);
                        sqLiteCommand.Parameters.AddWithValue("@CurrentShieldStrength", gclass40.decimal_3);
                        sqLiteCommand.Parameters.AddWithValue("@CurrentMaintSupplies", gclass40.decimal_4);
                        sqLiteCommand.Parameters.AddWithValue("@DamageControlID", gclass40.int_12);
                        sqLiteCommand.Parameters.AddWithValue("@Destroyed", gclass40.bool_9);
                        sqLiteCommand.Parameters.AddWithValue("@FireDelay", gclass40.int_13);
                        sqLiteCommand.Parameters.AddWithValue("@Fuel", gclass40.decimal_14);
                        sqLiteCommand.Parameters.AddWithValue("@GradePoints", gclass40.decimal_15);
                        sqLiteCommand.Parameters.AddWithValue("@HoldTechData", gclass40.int_14);
                        sqLiteCommand.Parameters.AddWithValue("@LastLaunchTime", gclass40.decimal_5);
                        sqLiteCommand.Parameters.AddWithValue("@LastMissileHitTime", gclass40.decimal_19);
                        sqLiteCommand.Parameters.AddWithValue("@LastBeamHitTime", gclass40.decimal_20);
                        sqLiteCommand.Parameters.AddWithValue("@LastShipDamageTime", gclass40.decimal_18);
                        sqLiteCommand.Parameters.AddWithValue("@LastPenetratingDamageTime", gclass40.decimal_21);
                        sqLiteCommand.Parameters.AddWithValue("@LastOverhaul", gclass40.decimal_6);
                        sqLiteCommand.Parameters.AddWithValue("@LastShoreLeave", gclass40.decimal_7);
                        sqLiteCommand.Parameters.AddWithValue("@LaunchMorale", gclass40.decimal_8);
                        sqLiteCommand.Parameters.AddWithValue("@MaintenanceState", gclass40.genum29_0);
                        sqLiteCommand.Parameters.AddWithValue("@MothershipID", num3);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass40.gclass21_0.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@RefuelPriority", gclass40.int_18);
                        sqLiteCommand.Parameters.AddWithValue("@ResupplyStatus", gclass40.auroraResupplyStatus_0);
                        sqLiteCommand.Parameters.AddWithValue("@ResupplyPriority", gclass40.int_19);
                        sqLiteCommand.Parameters.AddWithValue("@RefuelStatus", gclass40.auroraRefuelStatus_0);
                        sqLiteCommand.Parameters.AddWithValue("@OrdnanceTransferStatus",
                            gclass40.auroraOrdnanceTransferStatus_0);
                        sqLiteCommand.Parameters.AddWithValue("@ScrapFlag", gclass40.bool_11);
                        sqLiteCommand.Parameters.AddWithValue("@SensorDelay", gclass40.int_15);
                        sqLiteCommand.Parameters.AddWithValue("@ShieldsActive", gclass40.bool_10);
                        sqLiteCommand.Parameters.AddWithValue("@ShipClassID", gclass40.gclass22_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@ShipNotes", gclass40.string_0);
                        sqLiteCommand.Parameters.AddWithValue("@ShippingLineID", num4);
                        sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass40.gclass194_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@ParentSquadronID", num9);
                        sqLiteCommand.Parameters.AddWithValue("@SyncFire", gclass40.int_17);
                        sqLiteCommand.Parameters.AddWithValue("@TFPoints", gclass40.decimal_16);
                        sqLiteCommand.Parameters.AddWithValue("@TractorTargetShipID", num6);
                        sqLiteCommand.Parameters.AddWithValue("@TractorParentShipID", num7);
                        sqLiteCommand.Parameters.AddWithValue("@TractorTargetShipyardID", num5);
                        sqLiteCommand.Parameters.AddWithValue("@TransponderActive", gclass40.genum78_0);
                        sqLiteCommand.Parameters.AddWithValue("@HangarLoadType", gclass40.genum43_0);
                        sqLiteCommand.Parameters.AddWithValue("@AutomatedDamageControl", gclass40.bool_14);
                        sqLiteCommand.Parameters.AddWithValue("@BioEnergy", gclass40.decimal_17);
                        sqLiteCommand.Parameters.AddWithValue("@AssignedFormationID", num8);
                        sqLiteCommand.Parameters.AddWithValue("@DistanceTravelled", gclass40.decimal_10);
                        sqLiteCommand.Parameters.AddWithValue("@HullNumber", gclass40.int_20);
                        sqLiteCommand.Parameters.AddWithValue("@AssignedSquadronID", gclass40.LinkedSquadronID);
                        sqLiteCommand.Parameters.AddWithValue("@OverhaulFactor", gclass40.decimal_9);
                        sqLiteCommand.Parameters.AddWithValue("@LastFiringTime", gclass40.decimal_13);
                        sqLiteCommand.Parameters.AddWithValue("@LastTransitTime", gclass40.decimal_12);
                        sqLiteCommand.Parameters.AddWithValue("@DecoyThreshold", gclass40.int_23);
                        sqLiteCommand.Parameters.AddWithValue("@DesignateAsTarget", gclass40.int_24);
                        sqLiteCommand.Parameters.AddWithValue("@LoadDistance", gclass40.decimal_11);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3676);
                        break;
                    }

                    foreach (GClass130 gclass130 in gclass40.list_9)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ShipOrdnanceTemplate (GameID, ShipID, MissileID, Amount ) VALUES ( @GameID, @ShipID, @MissileID, @Amount )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@MissileID", gclass130.gclass129_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass130.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    try
                    {
                        foreach (GClass54 gclass54 in gclass40.list_0)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_ShipMeasurement ( ShipID, MeasurementType, Amount, StrikeGroup, GameID ) VALUES ( @ShipID, @MeasurementType, @Amount, @StrikeGroup, @GameID )";
                            sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                            sqLiteCommand.Parameters.AddWithValue("@MeasurementType", gclass54.auroraMeasurementType_0);
                            sqLiteCommand.Parameters.AddWithValue("@Amount", gclass54.decimal_0);
                            sqLiteCommand.Parameters.AddWithValue("@StrikeGroup", gclass54.bool_0);
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3677);
                        break;
                    }

                    foreach (GClass130 gclass130 in gclass40.list_10)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ShipWeapon (GameID, ShipID, MissileID, Amount ) VALUES ( @GameID, @ShipID, @MissileID, @Amount )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@MissileID", gclass130.gclass129_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass130.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass178 gclass178 in gclass40.list_12)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_DamagedComponent (ShipID, ComponentID, GameID, Number ) VALUES ( @ShipID, @ComponentID, @GameID, @Number )";
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@ComponentID", gclass178.gclass230_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@Number", gclass178.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    try
                    {
                        foreach (GClass177 gclass177 in gclass40.list_11)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_ShipHistory ( GameID, ShipID, Description, GameTime ) VALUES ( @GameID, @ShipID, @Description, @GameTime )";
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                            sqLiteCommand.Parameters.AddWithValue("@Description", gclass177.Description);
                            sqLiteCommand.Parameters.AddWithValue("@GameTime", gclass177.decimal_0);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3678);
                        break;
                    }

                    foreach (WeaponComponentRechargeStatus gclass27 in gclass40.list_7)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_WeaponRecharge (GameID, RechargeRemaining, ShipID, WeaponID, WeaponNumber ) VALUES ( @GameID, @RechargeRemaining, @ShipID, @WeaponID, @WeaponNumber )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RechargeRemaining", gclass27.RemainingRecharge);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@WeaponID", gclass27.WeaponComponent.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@WeaponNumber", gclass27.WeaponNumber);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    try
                    {
                        foreach (WeaponFireControlAssignment gclass31 in gclass40.list_2)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_WeaponAssignment (ShipID, WeaponID, WeaponNum, FCTypeID, FCNum, GameID ) VALUES ( @ShipID, @WeaponID, @WeaponNum, @FCTypeID, @FCNum, @GameID )";
                            sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                            sqLiteCommand.Parameters.AddWithValue("@WeaponID", gclass31.WeaponComponent.int_0);
                            sqLiteCommand.Parameters.AddWithValue("@WeaponNum", gclass31.WeaponNum);
                            sqLiteCommand.Parameters.AddWithValue("@FCTypeID", gclass31.FireControlComponent.int_0);
                            sqLiteCommand.Parameters.AddWithValue("@FCNum", gclass31.FireControlNum);
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3679);
                        break;
                    }

                    try
                    {
                        foreach (FCTDecoyAssignmentData32 gclass32 in gclass40.DecoyAssignmentList)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_DecoyAssignment (GameID, ShipID, LauncherID, LauncherNum ) VALUES ( @GameID, @ShipID, @LauncherID, @LauncherNum )";
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                            sqLiteCommand.Parameters.AddWithValue("@LauncherID", gclass32.LauncherData.int_0);
                            sqLiteCommand.Parameters.AddWithValue("@LauncherNum", gclass32.LauncherNum);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3682);
                        break;
                    }

                    try
                    {
                        foreach (FireControlAssignment gclass36 in gclass40.list_4)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_FireControlAssignment (ShipID, GameID, FCTypeID, FCNum, TargetID, TargetType, OpenFire, NodeExpand, PointDefenceMode, FiredThisPhase, PDFireConcentration, PointDefencePriority, MinimumAMMRange ) VALUES ( @ShipID, @GameID, @FCTypeID, @FCNum, @TargetID, @TargetType, @OpenFire, @NodeExpand, @PointDefenceMode, @FiredThisPhase, @PDFireConcentration, @PointDefencePriority, @MinimumAMMRange )";
                            sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.Parameters.AddWithValue("@FCTypeID", gclass36.FCComponent.int_0);
                            sqLiteCommand.Parameters.AddWithValue("@FCNum", gclass36.FCNum);
                            sqLiteCommand.Parameters.AddWithValue("@TargetID", gclass36.TargetID);
                            sqLiteCommand.Parameters.AddWithValue("@TargetType", gclass36.TargetContactType);
                            sqLiteCommand.Parameters.AddWithValue("@OpenFire", gclass36.IsOpeningFire);
                            sqLiteCommand.Parameters.AddWithValue("@NodeExpand", gclass36.NodeViewExpanded);
                            sqLiteCommand.Parameters.AddWithValue("@PointDefenceMode",
                                gclass36.PointDefenceMode);
                            sqLiteCommand.Parameters.AddWithValue("@FiredThisPhase", gclass36.HasFiredThisPhase);
                            sqLiteCommand.Parameters.AddWithValue("@PDFireConcentration",
                                gclass36.PointDefenceConcentration);
                            sqLiteCommand.Parameters.AddWithValue("@PointDefencePriority",
                                gclass36.PointDefencePriority);
                            sqLiteCommand.Parameters.AddWithValue("@MinimumAMMRange", gclass36.MinimumAMMRange);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3680);
                        break;
                    }

                    foreach (MissileAssignment gclass30 in gclass40.FiredMissiles)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_MissileAssignment (ShipID, MissileID, WeaponID, WeaponNum, GameID ) VALUES ( @ShipID, @MissileID, @WeaponID, @WeaponNum, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                        sqLiteCommand.Parameters.AddWithValue("@MissileID", gclass30.Missile.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@WeaponID", gclass30.FiringWeaponComponent.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@WeaponNum", gclass30.WeaponNum);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    try
                    {
                        foreach (KeyValuePair<int, int> keyValuePair in gclass40.dictionary_5)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_ArmourDamage (ShipID, ArmourColumn, Damage, GameID ) VALUES ( @ShipID, @ArmourColumn, @Damage, @GameID )";
                            sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass40.int_8);
                            sqLiteCommand.Parameters.AddWithValue("@ArmourColumn", keyValuePair.Key);
                            sqLiteCommand.Parameters.AddWithValue("@Damage", keyValuePair.Value);
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3675);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1471);
        }
    }

    public void method_110(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Contacts WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass65 gclass65 in this.dictionary_28.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Contacts (UniqueID, ContactID, GameID, SystemID, DetectRaceID, ContactRaceID, ContactName, CreationTime, Reestablished, LastUpdate, ContactMethod, ContactType, ContactStrength, ContactNumber, Resolution, ContinualContactTime, Xcor, Ycor, LastXcor, LastYcor, Speed, Msg, IncrementStartX, IncrementStartY ) \r\n                        VALUES ( @UniqueID, @ContactID, @GameID, @SystemID, @DetectRaceID, @ContactRaceID, @ContactName, @CreationTime, @Reestablished, @LastUpdate, @ContactMethod, @ContactType, @ContactStrength, @ContactNumber, @Resolution, @ContinualContactTime, @Xcor, @Ycor, @LastXcor, @LastYcor, @Speed, @Msg, @IncrementStartX, @IncrementStartY)";
                    switch (gclass65.auroraContactType_0)
                    {
                        case AuroraContactType.Ship:
                            if (this.FCTShipDataDictionary.ContainsKey(gclass65.int_1))
                            {
                                gclass65.gclass40_0 = this.FCTShipDataDictionary[gclass65.int_1];
                                break;
                            }

                            break;
                        case AuroraContactType.Salvo:
                            if (this.dictionary_6.ContainsKey(gclass65.int_1))
                            {
                                gclass65.gclass132_0 = this.dictionary_6[gclass65.int_1];
                                break;
                            }

                            break;
                        case AuroraContactType.Population:
                            if (this.PopulationDataDictionary.ContainsKey(gclass65.int_1))
                            {
                                gclass65.gclass146_0 = this.PopulationDataDictionary[gclass65.int_1];
                                break;
                            }

                            break;
                    }

                    sqLiteCommand.Parameters.AddWithValue("@UniqueID", gclass65.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ContactID", gclass65.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass65.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@DetectRaceID", gclass65.gclass21_1.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ContactRaceID", gclass65.method_3());
                    sqLiteCommand.Parameters.AddWithValue("@ContactName", gclass65.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@CreationTime", gclass65.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@Reestablished", gclass65.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@LastUpdate", gclass65.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@ContactMethod", gclass65.genum10_0);
                    sqLiteCommand.Parameters.AddWithValue("@ContactType", gclass65.auroraContactType_0);
                    sqLiteCommand.Parameters.AddWithValue("@ContactStrength", gclass65.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@ContactNumber", gclass65.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@Resolution", gclass65.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@ContinualContactTime", gclass65.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass65.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass65.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@LastXcor", gclass65.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@LastYcor", gclass65.double_3);
                    sqLiteCommand.Parameters.AddWithValue("@Speed", gclass65.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@Msg", gclass65.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartX", gclass65.double_4);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartY", gclass65.double_5);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1472);
        }
    }

    public void method_111(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Wrecks WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_WreckTech WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_WreckComponents WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass233 gclass233 in this.dictionary_29.Values)
                {
                    int num = 0;
                    if (gclass233.gclass1_0 != null)
                        num = gclass233.gclass1_0.SystemBodyID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Wrecks (WreckID, GameID, RaceID, SystemID, OrbitBodyID, ClassID, Size, EffectiveSize, StarSwarmHatching, QueenStatus, Xcor, Ycor, Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite, ShipID ) \r\n                        VALUES ( @WreckID, @GameID, @RaceID, @SystemID, @OrbitBodyID, @ClassID, @Size, @EffectiveSize, @StarSwarmHatching, @QueenStatus, @Xcor, @Ycor, @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite, @ShipID )";
                    sqLiteCommand.Parameters.AddWithValue("@WreckID", gclass233.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass233.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass233.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitBodyID", num);
                    sqLiteCommand.Parameters.AddWithValue("@ClassID", gclass233.gclass22_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Size", gclass233.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@EffectiveSize", gclass233.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@StarSwarmHatching", gclass233.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@QueenStatus", gclass233.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass233.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass233.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass233.gclass123_0.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass233.gclass123_0.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass233.gclass123_0.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass233.gclass123_0.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass233.gclass123_0.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass233.gclass123_0.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass233.gclass123_0.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass233.gclass123_0.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass233.gclass123_0.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass233.gclass123_0.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass233.gclass123_0.Gallicite);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass233.int_1);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (GClass234 gclass234 in gclass233.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_WreckTech ( GameID, WreckID, TechID, Percentage ) VALUES ( @GameID, @WreckID, @TechID, @Percentage )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@WreckID", gclass233.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@TechID", gclass234.gclass164_0.TechSystemID);
                        sqLiteCommand.Parameters.AddWithValue("@Percentage", gclass234.decimal_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass235 gclass235 in gclass233.list_1)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_WreckComponents ( WreckID, ComponentID, GameID, Amount ) VALUES ( @WreckID, @ComponentID, @GameID, @Amount )";
                        sqLiteCommand.Parameters.AddWithValue("@WreckID", gclass233.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@ComponentID", gclass235.gclass230_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass235.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1473);
        }
    }

    public void method_112(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_IndustrialProjects WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                List<GClass156> list = this.PopulationDataDictionary.Values
                    .SelectMany<PopulationData, GClass156>(gclass146_0 => gclass146_0.dictionary_2.Values)
                    .ToList<GClass156>();
                int num1 = 0;
                foreach (GClass156 gclass156 in list)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_IndustrialProjects (ProjectID, GameID, RaceID, PopulationID, SpeciesID, Percentage, ProductionType, ProductionID, RefitClassID, WealthUse, Amount, PartialCompletion, ProdPerUnit, Description, Pause, Queue, FuelRequired, Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite) \r\n                        VALUES ( @ProjectID, @GameID, @RaceID, @PopulationID, @SpeciesID, @Percentage, @ProductionType, @ProductionID, @RefitClassID, @WealthUse, @Amount, @PartialCompletion, @ProdPerUnit, @Description, @Pause, @Queue, @FuelRequired, @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite)";
                    int num2 = 0;
                    if (gclass156.gclass22_1 != null)
                        num2 = gclass156.gclass22_1.int_0;
                    switch (gclass156.auroraProductionType_0)
                    {
                        case AuroraProductionType.Construction:
                            num1 = (int)gclass156.gclass157_0.InstallationType;
                            break;
                        case AuroraProductionType.Ordnance:
                            num1 = gclass156.gclass129_0.int_0;
                            break;
                        case AuroraProductionType.Fighter:
                        case AuroraProductionType.SpaceStation:
                            num1 = gclass156.gclass22_0.int_0;
                            break;
                        case AuroraProductionType.Components:
                            num1 = gclass156.gclass230_0.int_0;
                            break;
                    }

                    sqLiteCommand.Parameters.AddWithValue("@ProjectID", gclass156.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass156.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass156.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass156.gclass194_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Percentage", gclass156.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@ProductionType", gclass156.auroraProductionType_0);
                    sqLiteCommand.Parameters.AddWithValue("@ProductionID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@RefitClassID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@WealthUse", gclass156.gclass150_0.WealthUsage);
                    sqLiteCommand.Parameters.AddWithValue("@Amount", gclass156.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@PartialCompletion", gclass156.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@ProdPerUnit", gclass156.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@Description", gclass156.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@Pause", gclass156.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@Queue", gclass156.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@FuelRequired", gclass156.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass156.gclass123_0.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass156.gclass123_0.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass156.gclass123_0.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass156.gclass123_0.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass156.gclass123_0.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass156.gclass123_0.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass156.gclass123_0.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass156.gclass123_0.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass156.gclass123_0.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass156.gclass123_0.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass156.gclass123_0.Gallicite);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1474);
        }
    }

    public void method_113(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MissileSalvo WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_Missile WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass132 gclass132 in this.dictionary_6.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    if (gclass132.gclass40_0 != null)
                        num1 = gclass132.gclass40_0.int_8;
                    if (gclass132.gclass1_0 != null)
                        num2 = gclass132.gclass1_0.SystemBodyID;
                    if (gclass132.gclass230_0 != null)
                        num3 = gclass132.gclass230_0.int_0;
                    if (gclass132.gclass40_1 != null || gclass132.gclass132_0 != null ||
                        gclass132.gclass146_0 != null || gclass132.gclass214_0 != null)
                        ;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MissileSalvo (MissileSalvoID, GameID, ShipID, RaceID, SystemID, OrbitBodyID, MissileID, LaunchTime, FireControlID, FCNum, TargetID, TargetType, MissileSpeed, ModifierToHit, Endurance, Xcor, Ycor, LastXcor, LastYcor, LastTargetX, LastTargetY, IncrementStartX, IncrementStartY, HomingMethod, CurrentDetonationRange ) \r\n                        VALUES ( @MissileSalvoID, @GameID, @ShipID, @RaceID, @SystemID, @OrbitBodyID, @MissileID, @LaunchTime, @FireControlID, @FCNum, @TargetID, @TargetType, @MissileSpeed, @ModifierToHit, @Endurance, @Xcor, @Ycor, @LastXcor, @LastYcor, @LastTargetX, @LastTargetY, @IncrementStartX, @IncrementStartY, @HomingMethod, @CurrentDetonationRange )";
                    sqLiteCommand.Parameters.AddWithValue("@MissileSalvoID", gclass132.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass132.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass132.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@OrbitBodyID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@MissileID", gclass132.gclass129_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@LaunchTime", gclass132.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@FireControlID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@FCNum", gclass132.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@TargetID", gclass132.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@TargetType", gclass132.auroraContactType_0);
                    sqLiteCommand.Parameters.AddWithValue("@MissileSpeed", gclass132.double_9);
                    sqLiteCommand.Parameters.AddWithValue("@ModifierToHit", gclass132.double_8);
                    sqLiteCommand.Parameters.AddWithValue("@Endurance", gclass132.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass132.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass132.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@LastXcor", gclass132.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@LastYcor", gclass132.double_3);
                    sqLiteCommand.Parameters.AddWithValue("@LastTargetX", gclass132.double_4);
                    sqLiteCommand.Parameters.AddWithValue("@LastTargetY", gclass132.double_5);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartX", gclass132.double_6);
                    sqLiteCommand.Parameters.AddWithValue("@IncrementStartY", gclass132.double_7);
                    sqLiteCommand.Parameters.AddWithValue("@HomingMethod", gclass132.genum58_0);
                    sqLiteCommand.Parameters.AddWithValue("@CurrentDetonationRange", gclass132.decimal_2);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (KeyValuePair<int, int> keyValuePair in gclass132.dictionary_2)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_Missile (MissileNumber, RemainingDecoys, SalvoID, GameID ) VALUES ( @MissileNumber, @RemainingDecoys, @SalvoID, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@MissileNumber", keyValuePair.Key);
                        sqLiteCommand.Parameters.AddWithValue("@RemainingDecoys", keyValuePair.Value);
                        sqLiteCommand.Parameters.AddWithValue("@SalvoID", gclass132.int_1);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1475);
        }
    }

    public void method_114(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_MissileType WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (RaceMissile gclass129 in this.RaceMissileDictionary.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    if (gclass129.gclass230_0 != null)
                        num1 = gclass129.gclass230_0.int_0;
                    if (gclass129.gclass129_0 != null)
                        num2 = gclass129.gclass129_0.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_MissileType (MissileID, GameID,  Name, MissileSeriesID, EngineID, NumEngines, PrecursorMissile, MissilesRequired, MissilesAvailable, Cost, Size, Speed, RadDamage, FuelRequired, Endurance, MaxRange, WarheadStrength, SensorStrength, SensorResolution, SensorRange, ThermalStrength, EMStrength, EMSensitivity, GeoStrength, TotalFlightTime, \r\n                        NumDecoys, MissileECM, MultipleWarheads, MSPMultipleWarheads, SecondStageID, NumSS, SeparationRange, Corbomite, Tritanium, Boronide, Uridium, Gallicite, PreTNT, MSPReactor, MSPWarhead, MSPEngine, MSPFuel, MSPActive, MSPThermal, MSPEM, MSPGeo, MSPDecoys, ECCM, GroundAP, GroundDamage, GroundBaseDamage, GroundShots, PowerMod, ATG, Retargeting, \r\n                        LaserWarhead, MinDetonationRange, MaxDetonationRange, LaserWarheadRangeModifier, ShipDecoy ) \r\n                        VALUES ( @MissileID, @GameID, @Name, @MissileSeriesID, @EngineID, @NumEngines, @PrecursorMissile, @MissilesRequired, @MissilesAvailable, @Cost, @Size, @Speed, @RadDamage, @FuelRequired, @Endurance, @MaxRange, @WarheadStrength, @SensorStrength, @SensorResolution, @SensorRange, @ThermalStrength, @EMStrength, @EMSensitivity, @GeoStrength, @TotalFlightTime, \r\n                        @NumDecoys, @MissileECM, @MultipleWarheads, @MSPMultipleWarheads, @SecondStageID, @NumSS, @SeparationRange, @Corbomite, @Tritanium, @Boronide, @Uridium, @Gallicite, @PreTNT, @MSPReactor, @MSPWarhead, @MSPEngine, @MSPFuel, @MSPActive, @MSPThermal, @MSPEM, @MSPGeo, @MSPDecoys, @ECCM, @GroundAP, @GroundDamage, @GroundBaseDamage, @GroundShots, @PowerMod, @ATG, @Retargeting, \r\n                        @LaserWarhead, @MinDetonationRange, @MaxDetonationRange, @LaserWarheadRangeModifier, @ShipDecoy )";
                    sqLiteCommand.Parameters.AddWithValue("@MissileID", gclass129.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass129.Name);
                    sqLiteCommand.Parameters.AddWithValue("@MissileSeriesID", gclass129.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@EngineID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@NumEngines", gclass129.int_9);
                    sqLiteCommand.Parameters.AddWithValue("@PrecursorMissile", gclass129.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@MissilesRequired", gclass129.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@MissilesAvailable", gclass129.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@Cost", gclass129.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@Size", gclass129.decimal_4);
                    sqLiteCommand.Parameters.AddWithValue("@Speed", gclass129.decimal_5);
                    sqLiteCommand.Parameters.AddWithValue("@RadDamage", gclass129.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@FuelRequired", gclass129.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@Endurance", gclass129.decimal_21);
                    sqLiteCommand.Parameters.AddWithValue("@MaxRange", gclass129.double_5);
                    sqLiteCommand.Parameters.AddWithValue("@WarheadStrength", gclass129.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@SensorStrength", gclass129.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@SensorResolution", gclass129.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@SensorRange", gclass129.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@ThermalStrength", gclass129.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@EMStrength", gclass129.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@EMSensitivity", gclass129.double_3);
                    sqLiteCommand.Parameters.AddWithValue("@GeoStrength", gclass129.decimal_16);
                    sqLiteCommand.Parameters.AddWithValue("@TotalFlightTime", gclass129.decimal_22);
                    sqLiteCommand.Parameters.AddWithValue("@NumDecoys", gclass129.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@MissileECM", gclass129.int_12);
                    sqLiteCommand.Parameters.AddWithValue("@SecondStageID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@NumSS", gclass129.int_16);
                    sqLiteCommand.Parameters.AddWithValue("@SeparationRange", gclass129.int_17);
                    sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass129.gclass123_0.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass129.gclass123_0.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass129.gclass123_0.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass129.gclass123_0.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass129.gclass123_0.Gallicite);
                    sqLiteCommand.Parameters.AddWithValue("@PreTNT", gclass129.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@MSPReactor", gclass129.decimal_6);
                    sqLiteCommand.Parameters.AddWithValue("@MSPWarhead", gclass129.decimal_7);
                    sqLiteCommand.Parameters.AddWithValue("@MSPEngine", gclass129.decimal_8);
                    sqLiteCommand.Parameters.AddWithValue("@MSPFuel", gclass129.decimal_9);
                    sqLiteCommand.Parameters.AddWithValue("@MSPActive", gclass129.decimal_10);
                    sqLiteCommand.Parameters.AddWithValue("@MSPThermal", gclass129.decimal_11);
                    sqLiteCommand.Parameters.AddWithValue("@MSPEM", gclass129.decimal_12);
                    sqLiteCommand.Parameters.AddWithValue("@MSPGeo", gclass129.decimal_13);
                    sqLiteCommand.Parameters.AddWithValue("@MSPDecoys", gclass129.decimal_14);
                    sqLiteCommand.Parameters.AddWithValue("@ECCM", gclass129.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@GroundAP", gclass129.decimal_17);
                    sqLiteCommand.Parameters.AddWithValue("@GroundDamage", gclass129.decimal_18);
                    sqLiteCommand.Parameters.AddWithValue("@GroundBaseDamage", gclass129.decimal_20);
                    sqLiteCommand.Parameters.AddWithValue("@GroundShots", gclass129.decimal_19);
                    sqLiteCommand.Parameters.AddWithValue("@PowerMod", gclass129.decimal_23);
                    sqLiteCommand.Parameters.AddWithValue("@ATG", gclass129.decimal_26);
                    sqLiteCommand.Parameters.AddWithValue("@Retargeting", gclass129.int_10);
                    sqLiteCommand.Parameters.AddWithValue("@LaserWarhead", gclass129.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@MinDetonationRange", gclass129.decimal_24);
                    sqLiteCommand.Parameters.AddWithValue("@MaxDetonationRange", gclass129.decimal_25);
                    sqLiteCommand.Parameters.AddWithValue("@LaserWarheadRangeModifier", gclass129.int_11);
                    sqLiteCommand.Parameters.AddWithValue("@MultipleWarheads", gclass129.int_13);
                    sqLiteCommand.Parameters.AddWithValue("@MSPMultipleWarheads", gclass129.decimal_15);
                    sqLiteCommand.Parameters.AddWithValue("@ShipDecoy", gclass129.int_14);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1476);
        }
    }

    public void method_115(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AtmosphericGas WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass224 gclass224 in this.SystemBodyRecordDic.Values
                             .SelectMany<SystemBodyData, GClass224>(gclass1_0 => gclass1_0.list_0)
                             .Where<GClass224>(gclass224_0 => gclass224_0.double_0 > 0.0).ToList<GClass224>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AtmosphericGas (GameID, SystemBodyID, AtmosGasID, AtmosGasAmount, GasAtm, FrozenOut ) VALUES ( @GameID, @SystemBodyID, @AtmosGasID, @AtmosGasAmount, @GasAtm, @FrozenOut )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass224.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@AtmosGasID", gclass224.gclass223_0.AtmosphericGas);
                    sqLiteCommand.Parameters.AddWithValue("@AtmosGasAmount", gclass224.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@GasAtm", gclass224.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@FrozenOut", gclass224.bool_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1477);
        }
    }

    public void method_116(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_DamageControlQueue WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass26 gclass26 in this.FCTShipDataDictionary.Values
                             .SelectMany<FCTShipData40, GClass26>(gclass40_0 => gclass40_0.list_13).ToList<GClass26>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_DamageControlQueue (ComponentID, GameID, RepairOrder, ShipID ) VALUES ( @ComponentID, @GameID, @RepairOrder, @ShipID )";
                    sqLiteCommand.Parameters.AddWithValue("@ComponentID", gclass26.gclass230_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RepairOrder", gclass26.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass26.gclass40_0.int_8);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1478);
        }
    }

    public void method_117(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_HullDescription", sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ShipHull gclass76 in this.ShipHullDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_HullDescription (HullDescriptionID, Description, HullAbbr ) VALUES ( @HullDescriptionID, @Description, @HullAbbr )";
                    sqLiteCommand.Parameters.AddWithValue("@HullDescriptionID", gclass76.ShipHullDescriptionID);
                    sqLiteCommand.Parameters.AddWithValue("@Description", gclass76.Description);
                    sqLiteCommand.Parameters.AddWithValue("@HullAbbr", gclass76.Abbreviation);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1479);
        }
    }

    public void method_118(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Commander WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_CommanderHistory WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_CommanderMedal WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_CommanderMeasurement WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_CommanderBonuses WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_CommanderTraits WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                List<GClass55> list = this.dictionary_42.Values.ToList<GClass55>();
                list.AddRange(this.dictionary_43.Values
                    .Where<GClass55>(gclass55_0 => gclass55_0.bool_3 || gclass55_0.bool_4).ToList<GClass55>());
                foreach (GClass55 gclass55 in list)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    int num4 = 0;
                    int num5 = 0;
                    int num6 = 0;
                    int num7 = 0;
                    int num8 = 0;
                    if (gclass55.gclass146_0 != null)
                        num2 = gclass55.gclass146_0.PopulationID;
                    if (gclass55.gclass146_2 != null)
                        num7 = gclass55.gclass146_2.PopulationID;
                    if (gclass55.gclass40_0 != null)
                        num3 = gclass55.gclass40_0.int_8;
                    if (gclass55.gclass59_0 != null)
                        num4 = gclass55.gclass59_0.int_0;
                    if (gclass55.gclass1_0 != null)
                        num5 = gclass55.gclass1_0.SystemBodyID;
                    if (gclass55.gclass21_1 != null)
                        num6 = gclass55.gclass21_1.RaceID;
                    if (gclass55.gclass61_0 != null)
                        num8 = gclass55.gclass61_0.int_0;
                    switch (gclass55.auroraCommandType_0)
                    {
                        case AuroraCommandType.Ship:
                            num1 = gclass55.gclass40_1.int_8;
                            break;
                        case AuroraCommandType.Colony:
                            num1 = gclass55.gclass146_1.PopulationID;
                            break;
                        case AuroraCommandType.Sector:
                            num1 = gclass55.gclass62_0.int_0;
                            break;
                        case AuroraCommandType.GroundFormation:
                            num1 = gclass55.gclass103_0.FormationID;
                            break;
                        case AuroraCommandType.ResearchProject:
                            num1 = gclass55.gclass161_0.ResearchProjectID;
                            break;
                        case AuroraCommandType.ExecutiveOfficer:
                            num1 = gclass55.gclass40_2.int_8;
                            break;
                        case AuroraCommandType.ChiefEngineer:
                            num1 = gclass55.gclass40_3.int_8;
                            break;
                        case AuroraCommandType.ScienceOfficer:
                            num1 = gclass55.gclass40_4.int_8;
                            break;
                        case AuroraCommandType.TacticalOfficer:
                            num1 = gclass55.gclass40_5.int_8;
                            break;
                        case AuroraCommandType.NavalAdminCommand:
                            num1 = gclass55.gclass83_0.int_0;
                            break;
                        case AuroraCommandType.CAG:
                            num1 = gclass55.gclass40_6.int_8;
                            break;
                        case AuroraCommandType.AcademyCommandant:
                            num1 = gclass55.gclass146_3.PopulationID;
                            break;
                    }

                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Commander (CommanderID, GameID,  RaceID, SpeciesID, Name, ResSpecID, CommanderType, Title, RankID, PromotionScore, PopPromotionScore, GameTimePromoted, GameTimeAssigned, DoNotRelieve, CommandType, CommandID, PopLocationID, TransportShipID, Seniority, RetireStatus, DoNotPromote, StoryCharacter, LifepodID, Orders, Notes, HomeworldID, \r\n                        POWRaceID, CareerStart, Loyalty, HealthRisk, Female, KillTonnageCommercial, KillTonnageMilitary, EducationColony, RetainRetired, Prisoner, Processed ) \r\n                        VALUES ( @CommanderID, @GameID, @RaceID, @SpeciesID, @Name, @ResSpecID, @CommanderType, @Title, @RankID, @PromotionScore, @PopPromotionScore, @GameTimePromoted, @GameTimeAssigned, @DoNotRelieve, @CommandType, @CommandID, @PopLocationID, @TransportShipID, @Seniority, @RetireStatus, @DoNotPromote, @StoryCharacter, @LifepodID, @Orders, @Notes, @HomeworldID, \r\n                        @POWRaceID, @CareerStart, @Loyalty, @HealthRisk, @Female, @KillTonnageCommercial, @KillTonnageMilitary, @EducationColony, @RetainRetired, @Prisoner, @Processed )";
                    sqLiteCommand.Parameters.AddWithValue("@CommanderID", gclass55.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass55.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass55.gclass194_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass55.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@ResSpecID", gclass55.gclass162_0.ResearchFieldID);
                    sqLiteCommand.Parameters.AddWithValue("@CommanderType", gclass55.auroraCommanderType_0);
                    sqLiteCommand.Parameters.AddWithValue("@Title", gclass55.string_1);
                    sqLiteCommand.Parameters.AddWithValue("@RankID", num8);
                    sqLiteCommand.Parameters.AddWithValue("@PromotionScore", gclass55.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@PopPromotionScore", gclass55.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@GameTimePromoted", gclass55.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameTimeAssigned", gclass55.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@DoNotRelieve", gclass55.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@CommandType", gclass55.auroraCommandType_0);
                    sqLiteCommand.Parameters.AddWithValue("@CommandID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@PopLocationID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@TransportShipID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@Seniority", gclass55.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@RetireStatus", gclass55.auroraRetirementStatus_0);
                    sqLiteCommand.Parameters.AddWithValue("@DoNotPromote", gclass55.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@StoryCharacter", gclass55.bool_2);
                    sqLiteCommand.Parameters.AddWithValue("@LifepodID", num4);
                    sqLiteCommand.Parameters.AddWithValue("@Orders", gclass55.string_2);
                    sqLiteCommand.Parameters.AddWithValue("@Notes", gclass55.string_3);
                    sqLiteCommand.Parameters.AddWithValue("@HomeworldID", num5);
                    sqLiteCommand.Parameters.AddWithValue("@POWRaceID", num6);
                    sqLiteCommand.Parameters.AddWithValue("@CareerStart", gclass55.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@Loyalty", gclass55.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@HealthRisk", gclass55.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@Female", gclass55.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@KillTonnageCommercial", gclass55.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@KillTonnageMilitary", gclass55.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@EducationColony", num7);
                    sqLiteCommand.Parameters.AddWithValue("@RetainRetired", gclass55.bool_3);
                    sqLiteCommand.Parameters.AddWithValue("@Prisoner", gclass55.bool_4);
                    sqLiteCommand.Parameters.AddWithValue("@Processed", gclass55.bool_5);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (GClass177 gclass177 in gclass55.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_CommanderHistory ( GameID, CommanderID, HistoryText, GameTime ) VALUES ( @GameID, @CommanderID, @HistoryText, @GameTime )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@CommanderID", gclass55.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@HistoryText", gclass177.Description);
                        sqLiteCommand.Parameters.AddWithValue("@GameTime", gclass177.decimal_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass53 gclass53 in gclass55.dictionary_1.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_CommanderMedal ( NumAwarded, MedalID, CommanderID, GameID, AwardReason ) VALUES ( @NumAwarded, @MedalID, @CommanderID, @GameID, @AwardReason )";
                        sqLiteCommand.Parameters.AddWithValue("@NumAwarded", gclass53.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@MedalID", gclass53.gclass42_0.MedalID);
                        sqLiteCommand.Parameters.AddWithValue("@CommanderID", gclass55.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@AwardReason", gclass53.string_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass54 gclass54 in gclass55.dictionary_2.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_CommanderMeasurement ( CommanderID, MeasurementType, Amount, GameID ) VALUES ( @CommanderID, @MeasurementType, @Amount,  @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@CommanderID", gclass55.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@MeasurementType", gclass54.auroraMeasurementType_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass54.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass52 gclass52 in gclass55.dictionary_0.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_CommanderBonuses ( GameID, CommanderID, BonusID, BonusValue ) VALUES ( @GameID, @CommanderID, @BonusID, @BonusValue )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@CommanderID", gclass55.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@BonusID", gclass52.gclass50_0.CommanderBonusType);
                        sqLiteCommand.Parameters.AddWithValue("@BonusValue", gclass52.decimal_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (int num9 in gclass55.list_1)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_CommanderTraits ( GameID, CmdrID, TraitID ) VALUES ( @GameID, @CmdrID, @TraitID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@CmdrID", gclass55.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@TraitID", num9);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1480);
        }
    }

    public void method_119(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Shipyard WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass193 gclass193 in this.dictionary_31.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    int num4 = 0;
                    int num5 = 0;
                    int num6 = 0;
                    int num7 = 0;
                    if (gclass193.gclass22_0 != null)
                        num1 = gclass193.gclass22_0.int_0;
                    if (gclass193.gclass22_1 != null)
                        num2 = gclass193.gclass22_1.int_0;
                    if (gclass193.gclass85_0 != null)
                        num3 = gclass193.gclass85_0.FleetID;
                    if (gclass193.gclass40_0 != null)
                        num4 = gclass193.gclass40_0.int_8;
                    if (gclass193.gclass40_1 != null)
                        num6 = gclass193.gclass40_1.int_8;
                    if (gclass193.gclass146_0 != null)
                        num5 = gclass193.gclass146_0.PopulationID;
                    if (gclass193.gclass83_0 != null)
                        num7 = gclass193.gclass83_0.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Shipyard (ShipyardID, GameID, PopulationID, SYType, ShipyardName, Slipways, Capacity, BuildClassID, RetoolClassID, TaskType, RequiredBP, CompletedBP, PauseActivity, DefaultFleetID, DefaultNavalAdminID, Xcor, Ycor, RaceID, TractorParentShipID, CapacityTarget, ParentShipID, UseAdmin ) \r\n                        VALUES ( @ShipyardID, @GameID, @PopulationID, @SYType, @ShipyardName, @Slipways, @Capacity, @BuildClassID, @RetoolClassID, @TaskType, @RequiredBP, @CompletedBP, @PauseActivity, @DefaultFleetID, @DefaultNavalAdminID, @Xcor, @Ycor, @RaceID, @TractorParentShipID, @CapacityTarget, @ParentShipID, @UseAdmin)";
                    sqLiteCommand.Parameters.AddWithValue("@ShipyardID", gclass193.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", num5);
                    sqLiteCommand.Parameters.AddWithValue("@SYType", gclass193.auroraShipyardType_0);
                    sqLiteCommand.Parameters.AddWithValue("@ShipyardName", gclass193.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@Slipways", gclass193.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@Capacity", gclass193.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@BuildClassID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@RetoolClassID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@TaskType", gclass193.auroraShipyardUpgradeType_0);
                    sqLiteCommand.Parameters.AddWithValue("@RequiredBP", gclass193.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@CompletedBP", gclass193.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@PauseActivity", gclass193.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@DefaultFleetID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@DefaultNavalAdminID", num7);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass193.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass193.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass193.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@TractorParentShipID", num4);
                    sqLiteCommand.Parameters.AddWithValue("@CapacityTarget", gclass193.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@ParentShipID", num6);
                    sqLiteCommand.Parameters.AddWithValue("@UseAdmin", gclass193.int_3);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1481);
        }
    }

    public void method_120(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShipyardTask WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass192 gclass192 in this.dictionary_32.Values)
                {
                    if (gclass192 != null)
                    {
                        int num1 = 0;
                        int num2 = 0;
                        int num3 = 0;
                        int num4 = 0;
                        int num5 = 0;
                        if (gclass192.gclass40_0 != null)
                            num1 = gclass192.gclass40_0.int_8;
                        if (gclass192.gclass83_0 != null)
                            num2 = gclass192.gclass83_0.int_0;
                        if (gclass192.gclass22_0 != null)
                            num3 = gclass192.gclass22_0.int_0;
                        if (gclass192.gclass22_1 != null)
                            num4 = gclass192.gclass22_1.int_0;
                        if (gclass192.gclass85_0 != null)
                            num5 = gclass192.gclass85_0.FleetID;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ShipyardTask (TaskID, GameID, RaceID, PopulationID, ShipyardID, TaskTypeID, Freighter, FleetID, ShipID, NavalAdminID, ClassID, NPRShip, UseComponents, RefitID, TotalBP, CompletedBP, Paused, UnitName, Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite ) \r\n                        VALUES ( @TaskID, @GameID, @RaceID, @PopulationID, @ShipyardID, @TaskTypeID, @Freighter, @FleetID, @ShipID, @NavalAdminID, @ClassID, @NPRShip, @UseComponents, @RefitID, @TotalBP, @CompletedBP, @Paused, @UnitName, @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite )";
                        sqLiteCommand.Parameters.AddWithValue("@TaskID", gclass192.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass192.gclass21_0.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass192.gclass146_0.PopulationID);
                        sqLiteCommand.Parameters.AddWithValue("@ShipyardID", gclass192.gclass193_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@TaskTypeID", gclass192.auroraSYTaskType_0);
                        sqLiteCommand.Parameters.AddWithValue("@Freighter", gclass192.bool_0);
                        sqLiteCommand.Parameters.AddWithValue("@FleetID", num5);
                        sqLiteCommand.Parameters.AddWithValue("@ShipID", num1);
                        sqLiteCommand.Parameters.AddWithValue("@NavalAdminID", num2);
                        sqLiteCommand.Parameters.AddWithValue("@ClassID", num3);
                        sqLiteCommand.Parameters.AddWithValue("@NPRShip", gclass192.bool_1);
                        sqLiteCommand.Parameters.AddWithValue("@UseComponents", gclass192.bool_3);
                        sqLiteCommand.Parameters.AddWithValue("@RefitID", num4);
                        sqLiteCommand.Parameters.AddWithValue("@TotalBP", gclass192.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@CompletedBP", gclass192.decimal_1);
                        sqLiteCommand.Parameters.AddWithValue("@Paused", gclass192.bool_2);
                        sqLiteCommand.Parameters.AddWithValue("@UnitName", gclass192.string_0);
                        sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass192.gclass123_0.Duranium);
                        sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass192.gclass123_0.Neutronium);
                        sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass192.gclass123_0.Corbomite);
                        sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass192.gclass123_0.Tritanium);
                        sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass192.gclass123_0.Boronide);
                        sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass192.gclass123_0.Mercassium);
                        sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass192.gclass123_0.Vendarite);
                        sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass192.gclass123_0.Sorium);
                        sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass192.gclass123_0.Uridium);
                        sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass192.gclass123_0.Corundium);
                        sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass192.gclass123_0.Gallicite);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1482);
        }
    }

    public void method_121(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Species WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_KnownSpecies WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass194 gclass194 in this.SpeciesDictionary.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    if (gclass194.gclass164_0 != null)
                        num1 = gclass194.gclass164_0.TechSystemID;
                    if (gclass194.gclass1_0 != null)
                        num2 = gclass194.gclass1_0.SystemBodyID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Species (SpeciesID, GameID, TechSystemID, HomeworldID, DerivedSpeciesID, SpeciesName, RacePic, BreatheID, Oxygen, OxyDev, PressMax, \r\n                                Temperature, TempDev, Gravity, GravDev, Xenophobia, Diplomacy, Translation, Militancy, Expansionism, Determination, Trade, SpecialNPRID, \r\n                                PopulationDensityModifier, PopulationGrowthModifier, ResearchRateModifier, ProductionRateModifier, GraduationAge ) \r\n                        VALUES ( @SpeciesID, @GameID, @TechSystemID, @HomeworldID, @DerivedSpeciesID, @SpeciesName, @RacePic, @BreatheID, @Oxygen, @OxyDev, @PressMax, \r\n                                @Temperature, @TempDev, @Gravity, @GravDev, @Xenophobia, @Diplomacy, @Translation, @Militancy, @Expansionism, @Determination, @Trade, @SpecialNPRID, \r\n                                @PopulationDensityModifier, @PopulationGrowthModifier, @ResearchRateModifier, @ProductionRateModifier, @GraduationAge)";
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass194.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@TechSystemID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@HomeworldID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@DerivedSpeciesID", gclass194.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesName", gclass194.SpeciesName);
                    sqLiteCommand.Parameters.AddWithValue("@RacePic", gclass194.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@BreatheID", gclass194.gclass223_0.AtmosphericGas);
                    sqLiteCommand.Parameters.AddWithValue("@Oxygen", gclass194.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@OxyDev", gclass194.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@PressMax", gclass194.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@Temperature", gclass194.double_3);
                    sqLiteCommand.Parameters.AddWithValue("@TempDev", gclass194.double_4);
                    sqLiteCommand.Parameters.AddWithValue("@Gravity", gclass194.double_5);
                    sqLiteCommand.Parameters.AddWithValue("@GravDev", gclass194.double_6);
                    sqLiteCommand.Parameters.AddWithValue("@Xenophobia", gclass194.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@Diplomacy", gclass194.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@Translation", gclass194.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@Militancy", gclass194.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@Expansionism", gclass194.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@Determination", gclass194.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@Trade", gclass194.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationDensityModifier", gclass194.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationGrowthModifier", gclass194.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@ResearchRateModifier", gclass194.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@ProductionRateModifier", gclass194.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@SpecialNPRID", gclass194.genum6_0);
                    sqLiteCommand.Parameters.AddWithValue("@GraduationAge", gclass194.int_11);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (GClass195 gclass195 in gclass194.dictionary_0.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_KnownSpecies ( GameID, SpeciesID, ViewRaceID, Status ) VALUES ( @GameID, @SpeciesID, @ViewRaceID, @Status )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass194.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@ViewRaceID", gclass195.gclass21_0.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@Status", gclass195.genum25_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1483);
        }
    }

    public void method_122(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_WealthData WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass151 gclass151 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, GClass151>(gclass21_0 => gclass21_0.list_3)
                             .Where<GClass151>(gclass151_0 =>
                                 gclass151_0.decimal_1 - this.GameTime < AuroraUtils.decimal_29).ToList<GClass151>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_WealthData (GameID, RaceID, Amount, UseID, TimeUsed ) VALUES ( @GameID, @RaceID, @Amount, @UseID, @TimeUsed )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass151.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Amount", gclass151.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@UseID", gclass151.gclass150_0.WealthUsage);
                    sqLiteCommand.Parameters.AddWithValue("@TimeUsed", gclass151.decimal_1);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1484);
        }
    }

    public void method_123(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_RaceMineralData WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass153 gclass153 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, GClass153>(gclass21_0 => gclass21_0.list_4)
                             .Where<GClass153>(gclass153_0 =>
                                 gclass153_0.decimal_1 - this.GameTime < AuroraUtils.decimal_29).ToList<GClass153>())
                {
                    int num = 0;
                    if (gclass153.gclass146_0 != null)
                        num = gclass153.gclass146_0.PopulationID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_RaceMineralData (GameID, RaceID, PopulationID, Amount, MineralDataType, MineralID, Time ) VALUES ( @GameID, @RaceID, @PopulationID, @Amount, @MineralDataType, @MineralID, @Time )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass153.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", num);
                    sqLiteCommand.Parameters.AddWithValue("@Amount", gclass153.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@MineralDataType", gclass153.genum85_0);
                    sqLiteCommand.Parameters.AddWithValue("@MineralID", gclass153.auroraElement_0);
                    sqLiteCommand.Parameters.AddWithValue("@Time", gclass153.decimal_1);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3948);
        }
    }

    public void method_124(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShippingLines WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ShippingLineData gclass187 in this.ShippingLineDictionary.Values)
                {
                    int num = 0;
                    if (gclass187.gclass230_0 != null)
                        num = gclass187.gclass230_0.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ShippingLines (ShippingLineID, GameID, EmpireID, NPRace, LineName, ShortName, ShipNum, WealthBalance, LastDividendPaid, LastDividendTime, CommEngineID, CommercialEngines ) \r\n                        VALUES ( @ShippingLineID, @GameID, @EmpireID, @NPRace, @LineName, @ShortName, @ShipNum, @WealthBalance, @LastDividendPaid, @LastDividendTime, @CommEngineID, @CommercialEngines )";
                    sqLiteCommand.Parameters.AddWithValue("@ShippingLineID", gclass187.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@EmpireID", gclass187.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@NPRace", gclass187.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@LineName", gclass187.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@ShortName", gclass187.string_1);
                    sqLiteCommand.Parameters.AddWithValue("@ShipNum", gclass187.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@WealthBalance", gclass187.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@LastDividendPaid", gclass187.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@LastDividendTime", gclass187.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@CommEngineID", num);
                    sqLiteCommand.Parameters.AddWithValue("@CommercialEngines", gclass187.int_2);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1485);
        }
    }

    public void method_125(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_NavalAdminCommand WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (NavalAdminCommand gclass83 in this.NavalAdminCommands.Values)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    if (gclass83.gclass146_0 != null)
                        num1 = gclass83.gclass146_0.PopulationID;
                    if (gclass83.gclass40_0 != null)
                        num3 = gclass83.gclass40_0.int_8;
                    if (gclass83.ParentAdminCommand != null)
                        num2 = gclass83.ParentAdminCommand.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_NavalAdminCommand (NavalAdminCommandID, GameID, RaceID, PopulationID, ParentAdminCommandID, AdminCommandTypeID, AdminCommandName, BonusOne, BonusTwo, BonusThree, AutoAssign, \r\n                                CommandPriority, MinimumRankPriority, FleetNodeExpanded, ShipID ) \r\n                            VALUES ( @NavalAdminCommandID, @GameID, @RaceID, @PopulationID, @ParentAdminCommandID, @AdminCommandTypeID, @AdminCommandName, @BonusOne, @BonusTwo, @BonusThree, @AutoAssign, \r\n                                @CommandPriority, @MinimumRankPriority, @FleetNodeExpanded, @ShipID )";
                    sqLiteCommand.Parameters.AddWithValue("@NavalAdminCommandID", gclass83.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass83.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@ParentAdminCommandID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@AdminCommandTypeID", gclass83.gclass79_0.AdminCommandType);
                    sqLiteCommand.Parameters.AddWithValue("@AdminCommandName", gclass83.AdminCommandName);
                    sqLiteCommand.Parameters.AddWithValue("@BonusOne", gclass83.genum121_0);
                    sqLiteCommand.Parameters.AddWithValue("@BonusTwo", gclass83.genum121_1);
                    sqLiteCommand.Parameters.AddWithValue("@BonusThree", gclass83.genum121_2);
                    sqLiteCommand.Parameters.AddWithValue("@AutoAssign", gclass83.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@CommandPriority", gclass83.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@MinimumRankPriority", gclass83.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@FleetNodeExpanded", gclass83.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", num3);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1486);
        }
    }

    public void method_126(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Lifepods WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass59 gclass59 in this.dictionary_30.Values)
                {
                    int num = 0;
                    if (gclass59.gclass22_0 != null)
                        num = gclass59.gclass22_0.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Lifepods (LifepodID, GameID, RaceID, SpeciesID, SystemID, ClassID, ShipName, Crew, Xcor, Ycor, CreationTime, GradePoints ) VALUES ( @LifepodID, @GameID, @RaceID, @SpeciesID, @SystemID, @ClassID, @ShipName, @Crew, @Xcor, @Ycor, @CreationTime, @GradePoints )";
                    sqLiteCommand.Parameters.AddWithValue("@LifepodID", gclass59.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass59.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass59.gclass194_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass59.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@ClassID", num);
                    sqLiteCommand.Parameters.AddWithValue("@ShipName", gclass59.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@Crew", gclass59.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass59.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass59.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@CreationTime", gclass59.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@GradePoints", gclass59.decimal_1);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1488);
        }
    }

    public void method_127(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_GroundUnitTraining WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass106 gclass106 in this.PopulationDataDictionary.Values
                             .SelectMany<PopulationData, GClass106>(gclass146_0 => gclass146_0.dictionary_3.Values)
                             .ToList<GClass106>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_GroundUnitTraining (TaskID, GameID, RaceID, PopulationID, FormationTemplateID, TotalBP, CompletedBP, FormationName, TaskPercentage, OrganizationLinkID, ParentLinkID, FieldPosition) VALUES ( @TaskID, @GameID, @RaceID, @PopulationID, @FormationTemplateID, @TotalBP, @CompletedBP, @FormationName, @TaskPercentage, @OrganizationLinkID, @ParentLinkID, @FieldPosition )";
                    sqLiteCommand.Parameters.AddWithValue("@TaskID", gclass106.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass106.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass106.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@FormationTemplateID", gclass106.gclass102_0.TemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@TotalBP", gclass106.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@CompletedBP", gclass106.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@FormationName", gclass106.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@TaskPercentage", gclass106.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@OrganizationLinkID", gclass106.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@ParentLinkID", gclass106.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@FieldPosition",
                        gclass106.auroraGroundFormationFieldPosition_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1489);
        }
    }

    public void method_128(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_GroundUnitTrainingQueue WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass107 gclass107 in this.PopulationDataDictionary.Values
                             .SelectMany<PopulationData, GClass107>(gclass146_0 => gclass146_0.list_0)
                             .ToList<GClass107>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_GroundUnitTrainingQueue (QueueID, GameID, PopulationID, FormationTemplateID, FormationName, TaskPercentage, OrganizationLinkID, ParentLinkID, FieldPosition) VALUES ( @QueueID, @GameID, @PopulationID, @FormationTemplateID, @FormationName, @TaskPercentage, @OrganizationLinkID, @ParentLinkID, @FieldPosition )";
                    sqLiteCommand.Parameters.AddWithValue("@QueueID", gclass107.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass107.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@FormationTemplateID", gclass107.gclass102_0.TemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@FormationName", gclass107.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@TaskPercentage", gclass107.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@OrganizationLinkID", gclass107.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@ParentLinkID", gclass107.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@FieldPosition",
                        gclass107.auroraGroundFormationFieldPosition_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1489);
        }
    }

    public void method_129(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ResearchProject WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ResearchProject gclass161 in this.PopulationDataDictionary.Values
                             .SelectMany<PopulationData, ResearchProject>(gclass146_0 => gclass146_0.dictionary_1.Values)
                             .ToList<ResearchProject>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ResearchProject (ProjectID, GameID, TechID, RaceID, PopulationID, Facilities, ResSpecID, ResearchPointsRequired, Pause, AssignNew) VALUES ( @ProjectID, @GameID, @TechID, @RaceID, @PopulationID, @Facilities, @ResSpecID, @ResearchPointsRequired, @Pause, @AssignNew )";
                    sqLiteCommand.Parameters.AddWithValue("@ProjectID", gclass161.ResearchProjectID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@TechID", gclass161.gclass164_0.TechSystemID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass161.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass161.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@Facilities", gclass161.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ResSpecID", gclass161.gclass162_0.ResearchFieldID);
                    sqLiteCommand.Parameters.AddWithValue("@ResearchPointsRequired", gclass161.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@Pause", gclass161.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@AssignNew", gclass161.bool_1);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1490);
        }
    }

    public void method_130(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_SectorCommand WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass62 gclass62 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, GClass62>(
                                 gclass21_0 => gclass21_0.dictionary_2.Values).ToList<GClass62>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_SectorCommand (SectorCommandID, RaceID, PopulationID, SectorName, Colour, GameID) VALUES ( @SectorCommandID, @RaceID, @PopulationID, @SectorName, @Colour, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@SectorCommandID", gclass62.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass62.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass62.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@SectorName", gclass62.SectorName);
                    sqLiteCommand.Parameters.AddWithValue("@Colour", gclass62.color_0.ToArgb());
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1491);
        }
    }

    public void method_131(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AlienRace WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_AlienRaceSpecies WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_AlienSystem WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (AlienRaceInfo gclass110 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, AlienRaceInfo>(gclass21_0 => gclass21_0.PerceivedAliens.Values).ToList<AlienRaceInfo>())
                {
                    int num = 0;
                    if (gclass110.ClassTheme != null)
                        num = gclass110.ClassTheme.ThemeID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AlienRace (AlienRaceID, ViewRaceID, GameID, AlienRaceName, FixedRelationship, ClassThemeID, FirstDetected, ContactStatus, Abbrev, CommStatus, CommModifier, CommEstablished, DiplomaticPoints, \r\n                                AlienRaceIntelligencePoints, TradeTreaty, TechTreaty, GeoTreaty, GravTreaty, RealClassNames, DamageCausedByAlienRace, RandomNameOrder, PortraitShown ) \r\n                        VALUES ( @AlienRaceID, @ViewRaceID, @GameID, @AlienRaceName, @FixedRelationship, @ClassThemeID, @FirstDetected, @ContactStatus, @Abbrev, @CommStatus, @CommModifier, @CommEstablished, @DiplomaticPoints, \r\n                                @AlienRaceIntelligencePoints, @TradeTreaty, @TechTreaty, @GeoTreaty, @GravTreaty, @RealClassNames, @DamageCausedByAlienRace, @RandomNameOrder, @PortraitShown )";
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass110.ActualAlienRaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ViewRaceID", gclass110.ViewingRace.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceName", gclass110.AlienRaceName);
                    sqLiteCommand.Parameters.AddWithValue("@FixedRelationship", gclass110.FixedRelationShip);
                    sqLiteCommand.Parameters.AddWithValue("@ClassThemeID", num);
                    sqLiteCommand.Parameters.AddWithValue("@FirstDetected", gclass110.FirstDetected);
                    sqLiteCommand.Parameters.AddWithValue("@ContactStatus", gclass110.ContactStatus);
                    sqLiteCommand.Parameters.AddWithValue("@Abbrev", gclass110.Abbreviation);
                    sqLiteCommand.Parameters.AddWithValue("@CommStatus", gclass110.CommStatus);
                    sqLiteCommand.Parameters.AddWithValue("@CommModifier", gclass110.CommModifier);
                    sqLiteCommand.Parameters.AddWithValue("@CommEstablished", gclass110.CommEstablished);
                    sqLiteCommand.Parameters.AddWithValue("@DiplomaticPoints", gclass110.DiplomaticPoints);
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceIntelligencePoints", gclass110.AlienRaceIntelPoints);
                    sqLiteCommand.Parameters.AddWithValue("@TradeTreaty", gclass110.bTradeTreaty);
                    sqLiteCommand.Parameters.AddWithValue("@TechTreaty", gclass110.bTechTreaty);
                    sqLiteCommand.Parameters.AddWithValue("@GeoTreaty", gclass110.bGeoTreaty);
                    sqLiteCommand.Parameters.AddWithValue("@GravTreaty", gclass110.bGravTreaty);
                    sqLiteCommand.Parameters.AddWithValue("@RealClassNames", gclass110.UseRealClassNames);
                    sqLiteCommand.Parameters.AddWithValue("@DamageCausedByAlienRace", gclass110.DamageCausedByAlienRace);
                    sqLiteCommand.Parameters.AddWithValue("@RandomNameOrder", gclass110.RandomNameOrder);
                    sqLiteCommand.Parameters.AddWithValue("@PortraitShown", gclass110.bPortraitShown);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (GClass194 gclass194 in gclass110.dictionary_0.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_AlienRaceSpecies (AlienRaceID, SpeciesID, DetectRaceID, GameID ) VALUES ( @AlienRaceID, @SpeciesID, @DetectRaceID, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass110.ActualAlienRaceID);
                        sqLiteCommand.Parameters.AddWithValue("@SpeciesID", gclass194.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@DetectRaceID", gclass110.ViewingRace.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (SystemData200 gclass200 in gclass110.dictionary_1.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_AlienSystem (GameID, SystemID, AlienRaceID, DetectRaceID ) VALUES ( @GameID, @SystemID, @AlienRaceID, @DetectRaceID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass200.SystemID);
                        sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass110.ActualAlienRaceID);
                        sqLiteCommand.Parameters.AddWithValue("@DetectRaceID", gclass110.ViewingRace.RaceID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1492);
        }
    }

    public void method_132(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AlienClass WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_AlienClassSensor WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_AlienClassWeapon WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_AlienClassTech WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass115 gclass115 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, GClass115>(gclass21_0 => gclass21_0.dictionary_11.Values).ToList<GClass115>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AlienClass (AlienClassID, GameID, AlienRaceID, ActualClassID, ViewRaceID, HullID, ClassName, TCS, ThermalSignature, ShieldStrength, ShieldRecharge, ArmourStrength, MaxSpeed, JumpDistance, ActiveJammerStrength, FireControlJammerStrength, MissileJammerStrength, Notes, Summary, ShipCount, FirstDetected, MaxEnergyPDShots, TotalEnergyPDShots, TotalEnergyPDHits, AlienClassRole, ObservedMissileDefence, DiplomaticShip, EngineType ) \r\n                        VALUES ( @AlienClassID, @GameID, @AlienRaceID, @ActualClassID, @ViewRaceID, @HullID, @ClassName, @TCS, @ThermalSignature, @ShieldStrength, @ShieldRecharge, @ArmourStrength, @MaxSpeed, @JumpDistance, @ActiveJammerStrength, @FireControlJammerStrength, @MissileJammerStrength, @Notes, @Summary, @ShipCount, @FirstDetected, @MaxEnergyPDShots, @TotalEnergyPDShots, @TotalEnergyPDHits, @AlienClassRole, @ObservedMissileDefence, @DiplomaticShip, @EngineType )";
                    sqLiteCommand.Parameters.AddWithValue("@AlienClassID", gclass115.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass115.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ActualClassID", gclass115.gclass22_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ViewRaceID", gclass115.gclass21_1.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@HullID", gclass115.gclass76_0.ShipHullDescriptionID);
                    sqLiteCommand.Parameters.AddWithValue("@ClassName", gclass115.ClassName);
                    sqLiteCommand.Parameters.AddWithValue("@TCS", gclass115.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@ThermalSignature", gclass115.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@ShieldStrength", gclass115.decimal_4);
                    sqLiteCommand.Parameters.AddWithValue("@ShieldRecharge", gclass115.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourStrength", gclass115.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@MaxSpeed", gclass115.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@JumpDistance", gclass115.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@ActiveJammerStrength", gclass115.decimal_5);
                    sqLiteCommand.Parameters.AddWithValue("@FireControlJammerStrength", gclass115.decimal_6);
                    sqLiteCommand.Parameters.AddWithValue("@MissileJammerStrength", gclass115.decimal_7);
                    sqLiteCommand.Parameters.AddWithValue("@Notes", gclass115.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@Summary", gclass115.string_1);
                    sqLiteCommand.Parameters.AddWithValue("@ShipCount", gclass115.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@FirstDetected", gclass115.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@MaxEnergyPDShots", gclass115.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@TotalEnergyPDShots", gclass115.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@TotalEnergyPDHits", gclass115.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@AlienClassRole", gclass115.genum57_0);
                    sqLiteCommand.Parameters.AddWithValue("@ObservedMissileDefence", gclass115.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@DiplomaticShip", gclass115.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@EngineType", gclass115.genum70_0);
                    sqLiteCommand.ExecuteNonQuery();
                    foreach (GClass118 gclass118 in gclass115.list_0)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_AlienClassSensor (GameID, AlienClassID, AlienSensorID ) VALUES ( @GameID, @AlienClassID, @AlienSensorID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@AlienClassID", gclass115.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@AlienSensorID", gclass118.int_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GClass119 gclass119 in gclass115.list_1)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_AlienClassWeapon (AlienClassID, Amount, GameID, ROF, Range, WeaponID, LastFired) VALUES ( @AlienClassID, @Amount, @GameID, @ROF, @Range, @WeaponID, @LastFired )";
                        sqLiteCommand.Parameters.AddWithValue("@AlienClassID", gclass115.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Amount", gclass119.int_1);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@ROF", gclass119.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@Range", gclass119.double_0);
                        sqLiteCommand.Parameters.AddWithValue("@WeaponID", gclass119.gclass230_0.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@LastFired", gclass119.decimal_0);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (TechSystem gclass164 in gclass115.list_2)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_AlienClassTech (GameID, AlienClassID, TechID ) VALUES ( @GameID, @AlienClassID, @TechID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@AlienClassID", gclass115.int_0);
                        sqLiteCommand.Parameters.AddWithValue("@TechID", gclass164.TechSystemID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1493);
        }
    }

    public void method_133(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AlienRaceSensor WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass118 gclass118 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace,
                                 AlienRaceInfo>(gclass21_0 => gclass21_0.PerceivedAliens.Values)
                             .SelectMany<AlienRaceInfo, GClass118>(gclass110_0 => gclass110_0.dictionary_2.Values)
                             .Distinct<GClass118>().ToList<GClass118>())
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    if (gclass118.gclass230_0 != null)
                        num1 = gclass118.gclass230_0.int_0;
                    if (gclass118.gclass129_0 != null)
                        num2 = gclass118.gclass129_0.int_0;
                    if (gclass118.gclass101_0 != null)
                        num3 = gclass118.gclass101_0.ClassID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AlienRaceSensor (AlienSensorID, GameID, Strength, Resolution, Range, IntelligencePoints, ActualSensor, ActualMissile, ActualGroundUnitClass, AlienRaceID, ViewingRaceID, Name ) VALUES ( @AlienSensorID, @GameID, @Strength, @Resolution, @Range, @IntelligencePoints, @ActualSensor, @ActualMissile, @ActualGroundUnitClass, @AlienRaceID, @ViewingRaceID, @Name )";
                    sqLiteCommand.Parameters.AddWithValue("@AlienSensorID", gclass118.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@Strength", gclass118.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@Resolution", gclass118.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@Range", gclass118.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@IntelligencePoints", gclass118.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@ActualSensor", num1);
                    sqLiteCommand.Parameters.AddWithValue("@ActualMissile", num2);
                    sqLiteCommand.Parameters.AddWithValue("@ActualGroundUnitClass", num3);
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass118.gclass21_1.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ViewingRaceID", gclass118.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass118.string_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1494);
        }
    }

    public void method_134(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AlienShip WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass117 gclass117 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, GClass117>(gclass21_0 => gclass21_0.dictionary_12.Values).ToList<GClass117>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AlienShip (GameID, AlienRaceID, AlienClassID, ViewRaceID, ShipID, Name, Speed, LastX, LastY, LastSysID, LastContactTime, FirstDetected, Destroyed, DamageTaken, GameTimeDamaged, ArmourDamage, ShieldDamage, PenetratingDamage, Salvaged ) \r\n                        VALUES ( @GameID, @AlienRaceID, @AlienClassID, @ViewRaceID, @ShipID, @Name, @Speed, @LastX, @LastY, @LastSysID, @LastContactTime, @FirstDetected, @Destroyed, @DamageTaken, @GameTimeDamaged, @ArmourDamage, @ShieldDamage, @PenetratingDamage, @Salvaged )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass117.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@AlienClassID", gclass117.gclass115_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ViewRaceID", gclass117.gclass21_1.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ShipID", gclass117.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass117.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@Speed", gclass117.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@LastX", gclass117.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@LastY", gclass117.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@LastSysID", this.method_161(gclass117.gclass200_0));
                    sqLiteCommand.Parameters.AddWithValue("@LastContactTime", gclass117.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@FirstDetected", gclass117.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@Destroyed", gclass117.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@DamageTaken", gclass117.decimal_6);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourDamage", gclass117.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@ShieldDamage", gclass117.decimal_7);
                    sqLiteCommand.Parameters.AddWithValue("@PenetratingDamage", gclass117.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@GameTimeDamaged", gclass117.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@Salvaged", gclass117.bool_1);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1495);
        }
    }

    public void method_135(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AlienGroundUnitClass WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass114 gclass114 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, GClass114>(gclass21_0 => gclass21_0.dictionary_14.Values).ToList<GClass114>())
                {
                    int num = 0;
                    if (gclass114.gclass101_0 != null)
                        num = gclass114.gclass101_0.ClassID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AlienGroundUnitClass (GameID, AlienRaceID, ActualUnitClassID, ViewRaceID, AlienGroundUnitClassID, Name, Hits, Penetrated, Destroyed, WeaponsKnown ) \r\n                        VALUES ( @GameID, @AlienRaceID, @ActualUnitClassID, @ViewRaceID, @AlienGroundUnitClassID, @Name, @Hits, @Penetrated, @Destroyed, @WeaponsKnown )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass114.gclass21_1.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@ActualUnitClassID", num);
                    sqLiteCommand.Parameters.AddWithValue("@ViewRaceID", gclass114.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@AlienGroundUnitClassID", gclass114.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass114.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@Hits", gclass114.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@Penetrated", gclass114.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@Destroyed", gclass114.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@WeaponsKnown", gclass114.bool_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1496);
        }
    }

    public void method_136(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AlienPopulation WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass113 gclass113 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, GClass113>(gclass21_0 => gclass21_0.dictionary_13.Values).ToList<GClass113>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AlienPopulation (GameID, AlienRaceID, ViewingRaceID, PopulationID, Installations, Mines, Factories, Refineries, ResearchFacilities, MaintenanceFacilities, GFTF, Spaceport, RefuellingStation, NavalHeadquarters, SectorCommand, OrdnanceTransfer, CargoStation, PopulationAmount, AlienPopulationIntelligencePoints, MaxIntelligence, PreviousMaxIntelligence, PopulationName, EMSignature, ThermalSignature ) \r\n                        VALUES ( @GameID, @AlienRaceID, @ViewingRaceID, @PopulationID, @Installations, @Mines, @Factories, @Refineries, @ResearchFacilities, @MaintenanceFacilities, @GFTF, @Spaceport, @RefuellingStation, @NavalHeadquarters, @SectorCommand, @OrdnanceTransfer, @CargoStation, @PopulationAmount, @AlienPopulationIntelligencePoints, @MaxIntelligence, @PreviousMaxIntelligence, @PopulationName, @EMSignature, @ThermalSignature )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass113.gclass110_0.ActualAlienRace.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", gclass113.gclass146_0.PopulationID);
                    sqLiteCommand.Parameters.AddWithValue("@ViewingRaceID", gclass113.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Installations", gclass113.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@Mines", gclass113.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@Factories", gclass113.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@Refineries", gclass113.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@ResearchFacilities", gclass113.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@MaintenanceFacilities", gclass113.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@GFTF", gclass113.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@Spaceport", gclass113.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@RefuellingStation", gclass113.bool_3);
                    sqLiteCommand.Parameters.AddWithValue("@NavalHeadquarters", gclass113.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@SectorCommand", gclass113.bool_2);
                    sqLiteCommand.Parameters.AddWithValue("@OrdnanceTransfer", gclass113.bool_4);
                    sqLiteCommand.Parameters.AddWithValue("@CargoStation", gclass113.bool_5);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationAmount", gclass113.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@AlienPopulationIntelligencePoints", gclass113.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@MaxIntelligence", gclass113.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@PreviousMaxIntelligence", gclass113.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationName", gclass113.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@EMSignature", gclass113.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@ThermalSignature", gclass113.decimal_3);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1497);
        }
    }

    public void method_137(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_RaceTech WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass165 gclass165 in this.TechDataDictionary.Values
                             .SelectMany<TechSystem, GClass165>(gclass164_0 => gclass164_0.dictionary_0.Values)
                             .ToList<GClass165>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_RaceTech (GameID, TechID, RaceID, Obsolete ) \r\n                        VALUES ( @GameID, @TechID, @RaceID, @Obsolete )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@TechID", gclass165.gclass164_0.TechSystemID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass165.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@Obsolete", gclass165.bool_0);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1498);
        }
    }

    public void method_138(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_EligibleProjects WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GameRace gclass21 in this.FCTRaceRecordDic.Values)
                {
                    foreach (TechSystem gclass164 in gclass21.list_18)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_EligibleProjects (GameID, RaceID, TechSystemID  ) \r\n                                    VALUES ( @GameID, @RaceID, @TechSystemID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass21.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@TechSystemID", gclass164.TechSystemID);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1498);
        }
    }

    public void method_139(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_TechSystem WHERE GameID = 0 OR GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (TechSystem gclass164 in this.TechDataDictionary.Values)
                {
                    try
                    {
                        if (gclass164.gclass21_0 != null)
                            gclass164.int_1 = gclass164.gclass21_0.RaceID;
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_TechSystem (TechSystemID, GameID, Name, ComponentName, CategoryID, RaceID, TechTypeID, NoTechScan, RuinOnly, Prerequisite1, Prerequisite2, StartingSystem, ConventionalSystem, DevelopCost, AdditionalInfo, AdditionalInfo2, AdditionalInfo3, AdditionalInfo4, TechDescription, AutomaticResearch ) \r\n                        VALUES ( @TechSystemID, @GameID, @Name, @ComponentName, @CategoryID, @RaceID, @TechTypeID, @NoTechScan, @RuinOnly, @Prerequisite1, @Prerequisite2, @StartingSystem, @ConventionalSystem, @DevelopCost, @AdditionalInfo, @AdditionalInfo2, @AdditionalInfo3, @AdditionalInfo4, @TechDescription, @AutomaticResearch )";
                        sqLiteCommand.Parameters.AddWithValue("@TechSystemID", gclass164.TechSystemID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", gclass164.int_5);
                        sqLiteCommand.Parameters.AddWithValue("@Name", gclass164.Name);
                        sqLiteCommand.Parameters.AddWithValue("@ComponentName", gclass164.string_0);
                        sqLiteCommand.Parameters.AddWithValue("@CategoryID", gclass164.genum119_0);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass164.int_1);
                        sqLiteCommand.Parameters.AddWithValue("@TechTypeID", this.method_162(gclass164.gclass163_0));
                        sqLiteCommand.Parameters.AddWithValue("@NoTechScan", gclass164.bool_0);
                        sqLiteCommand.Parameters.AddWithValue("@RuinOnly", gclass164.bool_1);
                        sqLiteCommand.Parameters.AddWithValue("@Prerequisite1", gclass164.int_2);
                        sqLiteCommand.Parameters.AddWithValue("@Prerequisite2", gclass164.int_3);
                        sqLiteCommand.Parameters.AddWithValue("@StartingSystem", gclass164.bool_2);
                        sqLiteCommand.Parameters.AddWithValue("@ConventionalSystem", gclass164.bool_3);
                        sqLiteCommand.Parameters.AddWithValue("@DevelopCost", gclass164.int_4);
                        sqLiteCommand.Parameters.AddWithValue("@AdditionalInfo", gclass164.decimal_0);
                        sqLiteCommand.Parameters.AddWithValue("@AdditionalInfo2", gclass164.decimal_1);
                        sqLiteCommand.Parameters.AddWithValue("@AdditionalInfo3", gclass164.decimal_2);
                        sqLiteCommand.Parameters.AddWithValue("@AdditionalInfo4", gclass164.decimal_3);
                        sqLiteCommand.Parameters.AddWithValue("@TechDescription", gclass164.string_1);
                        sqLiteCommand.Parameters.AddWithValue("@AutomaticResearch", gclass164.bool_4);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        AuroraUtils.ShowExceptionPopup(ex, 3230);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1499);
        }
    }

    public void method_140(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand(
                "DELETE FROM FCT_ShipDesignComponents WHERE GameID = 0 OR GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ShipComponent gclass230 in this.ComponentDataDictionary.Values)
                {
                    int num = 0;
                    if (gclass230.gclass185_0 != null)
                        num = gclass230.gclass185_0.int_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ShipDesignComponents (SDComponentID, GameID, Name, NoScrap, MilitarySystem, ShipyardRepairOnly, ShippingLineSystem, BeamWeapon, Crew, Size, Cost, ComponentTypeID, ComponentValue, PowerRequirement, RechargeRate, ElectronicSystem, ElectronicCTD, TrackingSpeed, SpecialFunction, WeaponToHitModifier, MaxSensorRange, Resolution, HTK, FuelUse, NoMaintFailure, HangarReloadOnly,\r\n                        ExplosionChance, MaxExplosionSize, DamageOutput, NumberOfShots, RangeModifier, MaxWeaponRange, SpinalWeapon, JumpDistance, JumpRating, RateOfFire, MaxPercentage, FuelEfficiency, IgnoreShields, IgnoreArmour, ElectronicOnly, StealthRating, CloakRating, Weapon, BGTech1, BGTech2, BGTech3, BGTech4, BGTech5, BGTech6, BGTech7,\r\n                        Duranium, Neutronium, Corbomite, Tritanium, Boronide, Mercassium, Vendarite, Sorium, Uridium, Corundium, Gallicite, SingleSystemOnly, ECCM, ArmourRetardation, Prototype, TurretWeaponID, ShipComponentTemplateID, EnginePowerMod, ExtraHTK, FCSpeedModifier, FCRangeModifier ) \r\n                        VALUES ( @SDComponentID, @GameID, @Name, @NoScrap, @MilitarySystem, @ShipyardRepairOnly, @ShippingLineSystem, @BeamWeapon, @Crew, @Size, @Cost, @ComponentTypeID, @ComponentValue, @PowerRequirement, @RechargeRate, @ElectronicSystem, @ElectronicCTD, @TrackingSpeed, @SpecialFunction, @WeaponToHitModifier, @MaxSensorRange, @Resolution, @HTK, @FuelUse, @NoMaintFailure, @HangarReloadOnly,\r\n                        @ExplosionChance, @MaxExplosionSize, @DamageOutput, @NumberOfShots, @RangeModifier, @MaxWeaponRange, @SpinalWeapon, @JumpDistance, @JumpRating, @RateOfFire, @MaxPercentage, @FuelEfficiency, @IgnoreShields, @IgnoreArmour, @ElectronicOnly, @StealthRating, @CloakRating, @Weapon, @BGTech1, @BGTech2, @BGTech3, @BGTech4, @BGTech5, @BGTech6, @BGTech7,\r\n                        @Duranium, @Neutronium, @Corbomite, @Tritanium, @Boronide, @Mercassium, @Vendarite, @Sorium, @Uridium, @Corundium, @Gallicite, @SingleSystemOnly, @ECCM, @ArmourRetardation, @Prototype, @TurretWeaponID, @ShipComponentTemplateID, @EnginePowerMod, @ExtraHTK, @FCSpeedModifier, @FCRangeModifier )";
                    sqLiteCommand.Parameters.AddWithValue("@SDComponentID", gclass230.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", gclass230.int_13);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass230.Name);
                    sqLiteCommand.Parameters.AddWithValue("@NoScrap", gclass230.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@MilitarySystem", gclass230.bool_1);
                    sqLiteCommand.Parameters.AddWithValue("@ShipyardRepairOnly", gclass230.bool_2);
                    sqLiteCommand.Parameters.AddWithValue("@ShippingLineSystem", gclass230.bool_3);
                    sqLiteCommand.Parameters.AddWithValue("@BeamWeapon", gclass230.bool_4);
                    sqLiteCommand.Parameters.AddWithValue("@Crew", gclass230.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@Size", gclass230.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@Cost", gclass230.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentTypeID",
                        gclass230.gclass231_0.ComponentTypeID);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentValue", gclass230.decimal_3);
                    sqLiteCommand.Parameters.AddWithValue("@PowerRequirement", gclass230.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@RechargeRate", gclass230.decimal_4);
                    sqLiteCommand.Parameters.AddWithValue("@ElectronicSystem", gclass230.bool_5);
                    sqLiteCommand.Parameters.AddWithValue("@ElectronicCTD", gclass230.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@TrackingSpeed", gclass230.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@SpecialFunction", gclass230.genum87_0);
                    sqLiteCommand.Parameters.AddWithValue("@WeaponToHitModifier", gclass230.decimal_5);
                    sqLiteCommand.Parameters.AddWithValue("@MaxSensorRange", gclass230.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Resolution", gclass230.decimal_6);
                    sqLiteCommand.Parameters.AddWithValue("@HTK", gclass230.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@FuelUse", gclass230.decimal_7);
                    sqLiteCommand.Parameters.AddWithValue("@NoMaintFailure", gclass230.bool_6);
                    sqLiteCommand.Parameters.AddWithValue("@HangarReloadOnly", gclass230.bool_7);
                    sqLiteCommand.Parameters.AddWithValue("@ExplosionChance", gclass230.decimal_11);
                    sqLiteCommand.Parameters.AddWithValue("@MaxExplosionSize", gclass230.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@DamageOutput", gclass230.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@NumberOfShots", gclass230.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@RangeModifier", gclass230.decimal_17);
                    sqLiteCommand.Parameters.AddWithValue("@MaxWeaponRange", gclass230.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@SpinalWeapon", gclass230.bool_13);
                    sqLiteCommand.Parameters.AddWithValue("@JumpDistance", gclass230.int_9);
                    sqLiteCommand.Parameters.AddWithValue("@JumpRating", gclass230.int_10);
                    sqLiteCommand.Parameters.AddWithValue("@RateOfFire", gclass230.int_11);
                    sqLiteCommand.Parameters.AddWithValue("@MaxPercentage", gclass230.int_12);
                    sqLiteCommand.Parameters.AddWithValue("@FuelEfficiency", gclass230.decimal_8);
                    sqLiteCommand.Parameters.AddWithValue("@IgnoreShields", gclass230.bool_9);
                    sqLiteCommand.Parameters.AddWithValue("@IgnoreArmour", gclass230.bool_8);
                    sqLiteCommand.Parameters.AddWithValue("@ElectronicOnly", gclass230.bool_10);
                    sqLiteCommand.Parameters.AddWithValue("@StealthRating", gclass230.decimal_9);
                    sqLiteCommand.Parameters.AddWithValue("@CloakRating", gclass230.decimal_10);
                    sqLiteCommand.Parameters.AddWithValue("@Weapon", gclass230.bool_11);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech1", gclass230.int_16);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech2", gclass230.int_17);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech3", gclass230.int_18);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech4", gclass230.int_19);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech5", gclass230.int_20);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech6", gclass230.int_21);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech7", gclass230.int_22);
                    sqLiteCommand.Parameters.AddWithValue("@Duranium", gclass230.gclass123_0.Duranium);
                    sqLiteCommand.Parameters.AddWithValue("@Neutronium", gclass230.gclass123_0.Neutronium);
                    sqLiteCommand.Parameters.AddWithValue("@Corbomite", gclass230.gclass123_0.Corbomite);
                    sqLiteCommand.Parameters.AddWithValue("@Tritanium", gclass230.gclass123_0.Tritanium);
                    sqLiteCommand.Parameters.AddWithValue("@Boronide", gclass230.gclass123_0.Boronide);
                    sqLiteCommand.Parameters.AddWithValue("@Mercassium", gclass230.gclass123_0.Mercassium);
                    sqLiteCommand.Parameters.AddWithValue("@Vendarite", gclass230.gclass123_0.Vendarite);
                    sqLiteCommand.Parameters.AddWithValue("@Sorium", gclass230.gclass123_0.Sorium);
                    sqLiteCommand.Parameters.AddWithValue("@Uridium", gclass230.gclass123_0.Uridium);
                    sqLiteCommand.Parameters.AddWithValue("@Corundium", gclass230.gclass123_0.Corundium);
                    sqLiteCommand.Parameters.AddWithValue("@Gallicite", gclass230.gclass123_0.Gallicite);
                    sqLiteCommand.Parameters.AddWithValue("@SingleSystemOnly", gclass230.bool_12);
                    sqLiteCommand.Parameters.AddWithValue("@ECCM", gclass230.decimal_13);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourRetardation", gclass230.decimal_12);
                    sqLiteCommand.Parameters.AddWithValue("@Prototype", gclass230.genum86_0);
                    sqLiteCommand.Parameters.AddWithValue("@TurretWeaponID", gclass230.int_14);
                    sqLiteCommand.Parameters.AddWithValue("@ShipComponentTemplateID", num);
                    sqLiteCommand.Parameters.AddWithValue("@EnginePowerMod", gclass230.decimal_14);
                    sqLiteCommand.Parameters.AddWithValue("@ExtraHTK", gclass230.int_15);
                    sqLiteCommand.Parameters.AddWithValue("@FCSpeedModifier", gclass230.decimal_16);
                    sqLiteCommand.Parameters.AddWithValue("@FCRangeModifier", gclass230.decimal_15);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1500);
        }
    }

    public void method_141(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Increments WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass91 gclass91 in this.gclass92_0.dictionary_0.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Increments (IncrementID, GameID, GameTime, Length ) \r\n                        VALUES ( @IncrementID, @GameID, @GameTime, @Length )";
                    sqLiteCommand.Parameters.AddWithValue("@IncrementID", gclass91.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@GameTime", gclass91.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@Length", gclass91.int_1);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1501);
        }
    }

    public void method_142(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShipComponentTemplate", sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass185 gclass185 in this.dictionary_76.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ShipComponentTemplate (ShipComponentTemplateID, ComponentTypeID, Resolution, NumberOfShots, ExtraHTK, BGTech1, BGTech2, BGTech3, BGTech4, BGTech5, BGTech6, BGTech7, EnginePowerMod, ComponentSize, ComponentName, TurretWeaponTemplateID, TrackingSpeed, ComponentValue) \r\n                        VALUES ( @ShipComponentTemplateID, @ComponentTypeID, @Resolution, @NumberOfShots, @ExtraHTK, @BGTech1, @BGTech2, @BGTech3, @BGTech4, @BGTech5, @BGTech6, @BGTech7, @EnginePowerMod, @ComponentSize, @ComponentName, @TurretWeaponTemplateID, @TrackingSpeed, @ComponentValue )";
                    sqLiteCommand.Parameters.AddWithValue("@ShipComponentTemplateID", gclass185.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentTypeID", gclass185.auroraComponentType_0);
                    sqLiteCommand.Parameters.AddWithValue("@Resolution", gclass185.int_9);
                    sqLiteCommand.Parameters.AddWithValue("@NumberOfShots", gclass185.int_10);
                    sqLiteCommand.Parameters.AddWithValue("@ExtraHTK", gclass185.int_11);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech1", gclass185.int_2);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech2", gclass185.int_3);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech3", gclass185.int_4);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech4", gclass185.int_5);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech5", gclass185.int_6);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech6", gclass185.int_7);
                    sqLiteCommand.Parameters.AddWithValue("@BGTech7", gclass185.int_8);
                    sqLiteCommand.Parameters.AddWithValue("@EnginePowerMod", gclass185.decimal_1);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentSize", gclass185.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentName", gclass185.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@ComponentValue", gclass185.decimal_2);
                    sqLiteCommand.Parameters.AddWithValue("@TurretWeaponTemplateID", gclass185.int_1);
                    sqLiteCommand.Parameters.AddWithValue("@TrackingSpeed", gclass185.int_12);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1501);
        }
    }

    public void method_143(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ShipClassTemplate", sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ShipClassTemplate184 gclass184 in this.ShipClassTemplateDictionary.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ShipClassTemplate (ShipClassTemplateID, ShipClassTemplateName, HullID, ArmourThickness, Collier, ConscriptOnly, FuelTanker, SupplyShip, NoArmour, NoOfficers, PlannedDeployment, SeniorCO, \r\n                                MinimumSupplies, MinimumFuel, ResupplyPriority, RefuelPriority, PDProtectionPriority, CommanderPriority, MaintPriority ) \r\n                        VALUES ( @ShipClassTemplateID, @ShipClassTemplateName, @HullID, @ArmourThickness, @Collier, @ConscriptOnly, @FuelTanker, @SupplyShip, @NoArmour, @NoOfficers, @PlannedDeployment, @SeniorCO, \r\n                                @MinimumSupplies, @MinimumFuel, @ResupplyPriority, @RefuelPriority, @PDProtectionPriority, @CommanderPriority, @MaintPriority )";
                    sqLiteCommand.Parameters.AddWithValue("@ShipClassTemplateID", gclass184.ShipClassTemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@ShipClassTemplateName", gclass184.ShipClassTemplateName);
                    sqLiteCommand.Parameters.AddWithValue("@HullID", gclass184.HullID);
                    sqLiteCommand.Parameters.AddWithValue("@ArmourThickness", gclass184.ArmourThickness);
                    sqLiteCommand.Parameters.AddWithValue("@Collier", gclass184.Collier);
                    sqLiteCommand.Parameters.AddWithValue("@ConscriptOnly", gclass184.ConscriptOnly);
                    sqLiteCommand.Parameters.AddWithValue("@FuelTanker", gclass184.FuelTanker);
                    sqLiteCommand.Parameters.AddWithValue("@SupplyShip", gclass184.SupplyShip);
                    sqLiteCommand.Parameters.AddWithValue("@NoArmour", gclass184.NoArmour);
                    sqLiteCommand.Parameters.AddWithValue("@NoOfficers", gclass184.NoOfficers);
                    sqLiteCommand.Parameters.AddWithValue("@PlannedDeployment", gclass184.PlannedDeployment);
                    sqLiteCommand.Parameters.AddWithValue("@SeniorCO", gclass184.SeniorCO);
                    sqLiteCommand.Parameters.AddWithValue("@MinimumSupplies", gclass184.MinimumSupplies);
                    sqLiteCommand.Parameters.AddWithValue("@MinimumFuel", gclass184.MinimumFuel);
                    sqLiteCommand.Parameters.AddWithValue("@ResupplyPriority", gclass184.ResupplyPriority);
                    sqLiteCommand.Parameters.AddWithValue("@RefuelPriority", gclass184.RefuelPriority);
                    sqLiteCommand.Parameters.AddWithValue("@PDProtectionPriority", gclass184.PDProtectionPriority);
                    sqLiteCommand.Parameters.AddWithValue("@CommanderPriority", gclass184.CommanderPriority);
                    sqLiteCommand.Parameters.AddWithValue("@MaintPriority", gclass184.MaintPriority);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3717);
        }
    }

    public void method_144(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_ClassComponentTemplate", sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (ClassComponentTemplate186 gclass186 in this.ShipClassTemplateDictionary.Values
                             .SelectMany<ShipClassTemplate184, ClassComponentTemplate186>(gclass184_0 =>
                                 gclass184_0.ComponentTemplateList).ToList<ClassComponentTemplate186>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_ClassComponentTemplate (ShipClassTemplateID, ShipComponentTemplateID, StandardComponentID, NumComponent ) \r\n                        VALUES ( @ShipClassTemplateID, @ShipComponentTemplateID, @StandardComponentID, @NumComponent )";
                    sqLiteCommand.Parameters.AddWithValue("@ShipClassTemplateID", gclass186.ShipClassTemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@ShipComponentTemplateID",
                        gclass186.ShipComponentTemplateID);
                    sqLiteCommand.Parameters.AddWithValue("@StandardComponentID", gclass186.StandardComponentID);
                    sqLiteCommand.Parameters.AddWithValue("@NumComponent", gclass186.NumComponent);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3718);
        }
    }

    public void method_145(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_GameLog WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass87 gclass87 in this.gclass92_0.dictionary_0.Values
                             .Where<GClass91>(gclass91_0 =>
                                 this.GameTime - gclass91_0.decimal_0 < AuroraUtils.decimal_30)
                             .SelectMany<GClass91, GClass87>(gclass91_0 => gclass91_0.list_0).ToList<GClass87>())
                {
                    int num1 = 0;
                    int num2 = 0;
                    if (gclass87.gclass200_0 != null)
                        num1 = gclass87.gclass200_0.SystemID;
                    if (gclass87.gclass146_0 != null)
                        num2 = gclass87.gclass146_0.PopulationID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_GameLog (IncrementID, GameID, RaceID, SMOnly, Time, EventType, MessageText, SystemID, Xcor, Ycor, IDType, PopulationID ) \r\n                        VALUES ( @IncrementID, @GameID, @RaceID, @SMOnly, @Time, @EventType, @MessageText, @SystemID, @Xcor, @Ycor, @IDType, @PopulationID )";
                    sqLiteCommand.Parameters.AddWithValue("@IncrementID", gclass87.gclass91_0.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass87.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SMOnly", gclass87.bool_0);
                    sqLiteCommand.Parameters.AddWithValue("@Time", gclass87.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@EventType", gclass87.gclass88_0.EventTypeId);
                    sqLiteCommand.Parameters.AddWithValue("@MessageText", gclass87.string_0);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass87.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass87.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@IDType", gclass87.auroraEventCategory_0);
                    sqLiteCommand.Parameters.AddWithValue("@PopulationID", num2);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1502);
        }
    }

    public void method_146(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_EventColour WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (EventColourSetting gclass90 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, EventColourSetting>(
                                 gclass21_0 => gclass21_0.EventColourSettings.Values).Distinct<EventColourSetting>()
                             .ToList<EventColourSetting>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_EventColour (EventTypeID, RaceID, GameID, AlertColour, TextColour ) \r\n                        VALUES ( @EventTypeID, @RaceID, @GameID, @AlertColour, @TextColour )";
                    sqLiteCommand.Parameters.AddWithValue("@EventTypeID", gclass90.EventType.EventTypeId);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass90.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@AlertColour", gclass90.TextColour.ToArgb());
                    sqLiteCommand.Parameters.AddWithValue("@TextColour", gclass90.AlertColour.ToArgb());
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1503);
        }
    }

    public void method_147(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AetherRift WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass211 gclass211 in this.dictionary_15.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AetherRift (SystemID, Diameter, Xcor, Ycor, GameID) \r\n                        VALUES ( @SystemID, @Diameter, @Xcor, @Ycor, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass211.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@Diameter", gclass211.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass211.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass211.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3261);
        }
    }

    public void method_148(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_AetherGates WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GClass210 gclass210 in this.dictionary_16.Values)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AetherGates (AetherGateID, SystemID, Xcor, Ycor, CreationTime, CooldownTime, GameID) \r\n                        VALUES ( @AetherGateID, @SystemID, @Xcor, @Ycor, @CreationTime, @CooldownTime, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@AetherGateID", gclass210.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass210.gclass200_0.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass210.double_0);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass210.double_1);
                    sqLiteCommand.Parameters.AddWithValue("@CreationTime", gclass210.decimal_0);
                    sqLiteCommand.Parameters.AddWithValue("@CooldownTime", gclass210.double_2);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3405);
        }
    }

    public void method_149(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_OrganizationNode WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (OrganizationNodeC93 gclass93 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, OrganizationNodeC93>(gclass21_0 => gclass21_0.OrganizationNodeDictionary.Values).ToList<OrganizationNodeC93>())
                {
                    int num1 = 0;
                    int num2 = 0;
                    if (gclass93.ParentOrganizationNode != null)
                        num1 = gclass93.ParentOrganizationNode.OrganizationID;
                    if (gclass93.FormationTemplate != null)
                        num2 = gclass93.FormationTemplate.TemplateID;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_OrganizationNode (OrganizationID, OrganizationName, RaceID, GameID, ParentOrganizationID, FormationTemplateID, NodeExpanded, FieldPosition) \r\n                        VALUES ( @OrganizationID, @OrganizationName, @RaceID, @GameID, @ParentOrganizationID, @FormationTemplateID, @NodeExpanded, @FieldPosition )";
                    sqLiteCommand.Parameters.AddWithValue("@OrganizationID", gclass93.OrganizationID);
                    sqLiteCommand.Parameters.AddWithValue("@OrganizationName", gclass93.OrganizationName);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass93.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@ParentOrganizationID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@FormationTemplateID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@NodeExpanded", gclass93.NodeExpanded);
                    sqLiteCommand.Parameters.AddWithValue("@FieldPosition", gclass93.FieldPosition);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3405);
        }
    }

    public void method_150(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Ranks WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (RankThemeEntry gclass61 in this.FCTRaceRecordDic.Values
                             .SelectMany<GameRace, RankThemeEntry>(
                                 gclass21_0 => gclass21_0.RacialRankDictionary.Values).ToList<RankThemeEntry>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_Ranks (RankID, RaceID, RankName, Priority, RankType, RankAbbrev, GameID) \r\n                        VALUES ( @RankID, @RaceID, @RankName, @Priority, @RankType, @RankAbbrev, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@RankID", gclass61.int_0);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass61.gclass21_0.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@RankName", gclass61.RankName);
                    sqLiteCommand.Parameters.AddWithValue("@Priority", gclass61.RankNum);
                    sqLiteCommand.Parameters.AddWithValue("@RankType", gclass61.CommanderType);
                    sqLiteCommand.Parameters.AddWithValue("@RankAbbrev", gclass61.RankAbbreviation);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1504);
        }
    }

    public void method_151(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_HideEvents WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (HideEventData gclass89 in this.HideEventList)
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_HideEvents (RaceID, EventID, GameID ) \r\n                        VALUES ( @RaceID, @EventID, @GameID )";
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass89.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@EventID", gclass89.EventType);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1505);
        }
    }

    public void method_152(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_RaceSysSurvey WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_RaceJumpPointSurvey WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_AlienRaceSystemStatus WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                List<RacialSystemSurvey> list = this.FCTRaceRecordDic.Values
                    .SelectMany<GameRace, RacialSystemSurvey>(gclass21_0 => gclass21_0.RacialSystemDictionary.Values)
                    .ToList<RacialSystemSurvey>();
                foreach (RacialSystemSurvey gclass202 in list)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int num3 = 0;
                    int num4 = 1;
                    if (gclass202.NamingTheme != null)
                        num1 = gclass202.NamingTheme.ThemeID;
                    if (gclass202.gclass110_0 != null)
                        num2 = gclass202.gclass110_0.ActualAlienRaceID;
                    if (gclass202.gclass62_0 != null)
                        num3 = gclass202.gclass62_0.int_0;
                    if (gclass202.gclass3_0 != null)
                        num4 = (int)gclass202.gclass3_0.genum95_0;
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_RaceSysSurvey (GameID, RaceID, SystemID, Name, DangerRating, RaidRating, SysTPStatus, ControlRaceID, ForeignFleetRaceID, SectorID, NameThemeID, Discovered, Xcor, Ycor, ClosedWP, SurveyDone, GeoSurveyDefaultDone, SelectedBodyXcor, SelectedBodyYcor, KmPerPixel, DiscoveredTime, NoAutoRoute, MilitaryRestrictedSystem, SystemValue, AutoProtectionStatus, MineralSearchFlag ) \r\n                        VALUES (@GameID, @RaceID, @SystemID, @Name, @DangerRating, @RaidRating, @SysTPStatus, @ControlRaceID, @ForeignFleetRaceID, @SectorID, @NameThemeID, @Discovered, @Xcor, @Ycor, @ClosedWP, @SurveyDone, @GeoSurveyDefaultDone, @SelectedBodyXcor, @SelectedBodyYcor, @KmPerPixel, @DiscoveredTime, @NoAutoRoute, @MilitaryRestrictedSystem, @SystemValue, @AutoProtectionStatus, @MineralSearchFlag )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass202.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass202.ActualSystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@Name", gclass202.Name);
                    sqLiteCommand.Parameters.AddWithValue("@DangerRating", gclass202.DangerRating);
                    sqLiteCommand.Parameters.AddWithValue("@RaidRating", gclass202.RaidRating);
                    sqLiteCommand.Parameters.AddWithValue("@SysTPStatus", gclass202.bSysTPStatus);
                    sqLiteCommand.Parameters.AddWithValue("@ControlRaceID", num2);
                    sqLiteCommand.Parameters.AddWithValue("@ForeignFleetRaceID", gclass202.ForeignFleetRaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SectorID", num3);
                    sqLiteCommand.Parameters.AddWithValue("@NameThemeID", num1);
                    sqLiteCommand.Parameters.AddWithValue("@Discovered", gclass202.Discovered);
                    sqLiteCommand.Parameters.AddWithValue("@Xcor", gclass202.XCoord);
                    sqLiteCommand.Parameters.AddWithValue("@Ycor", gclass202.YCoord);
                    sqLiteCommand.Parameters.AddWithValue("@ClosedWP", gclass202.ClosedWP);
                    sqLiteCommand.Parameters.AddWithValue("@SurveyDone", gclass202.bSurveyComplete);
                    sqLiteCommand.Parameters.AddWithValue("@GeoSurveyDefaultDone", gclass202.bGeoSurveyDefaultDone);
                    sqLiteCommand.Parameters.AddWithValue("@SelectedBodyXcor", gclass202.SelectedBodyXCoord);
                    sqLiteCommand.Parameters.AddWithValue("@SelectedBodyYcor", gclass202.SelectedBodyYCoord);
                    sqLiteCommand.Parameters.AddWithValue("@DiscoveredTime", gclass202.DiscoveredTime);
                    sqLiteCommand.Parameters.AddWithValue("@KmPerPixel", gclass202.KmPerPixel / AuroraUtils.double_15);
                    sqLiteCommand.Parameters.AddWithValue("@NoAutoRoute", gclass202.bNoAutoRoute);
                    sqLiteCommand.Parameters.AddWithValue("@MilitaryRestrictedSystem", gclass202.bMilitaryRestrictedSystem);
                    sqLiteCommand.Parameters.AddWithValue("@SystemValue", num4);
                    sqLiteCommand.Parameters.AddWithValue("@AutoProtectionStatus",
                        gclass202.AutoSystemProtectionStatus);
                    sqLiteCommand.Parameters.AddWithValue("@MineralSearchFlag", gclass202.bMineralSearchFlag);
                    sqLiteCommand.ExecuteNonQuery();
                }

                foreach (RaceJumpPointSurvey gclass203 in this.JumpPointDictionary.Values
                             .SelectMany<JumpPoint120, RaceJumpPointSurvey>(gclass120_0 => gclass120_0.RacialJumpPointSurveys.Values)
                             .ToList<RaceJumpPointSurvey>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_RaceJumpPointSurvey (GameID, RaceID, WarpPointID, Explored, Charted, AlienUnits, Hide, MilitaryRestricted, IgnoreForDistance ) \r\n                        VALUES (@GameID, @RaceID, @WarpPointID, @Explored, @Charted, @AlienUnits, @Hide, @MilitaryRestricted, @IgnoreForDistance  )";
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass203.Race.RaceID);
                    sqLiteCommand.Parameters.AddWithValue("@WarpPointID", gclass203.JumpPoint.WarpPointID);
                    sqLiteCommand.Parameters.AddWithValue("@Explored", gclass203.Explored);
                    sqLiteCommand.Parameters.AddWithValue("@Charted", gclass203.Charted);
                    sqLiteCommand.Parameters.AddWithValue("@AlienUnits", gclass203.bAlienUnits);
                    sqLiteCommand.Parameters.AddWithValue("@Hide", gclass203.Hide);
                    sqLiteCommand.Parameters.AddWithValue("@MilitaryRestricted", gclass203.MilitaryRestricted);
                    sqLiteCommand.Parameters.AddWithValue("@IgnoreForDistance", gclass203.IgnoreForDistance);
                    sqLiteCommand.ExecuteNonQuery();
                }

                foreach (AlienRaceSystemStatus gclass111 in list
                             .SelectMany<RacialSystemSurvey, AlienRaceSystemStatus>(gclass202_0 => gclass202_0.dictionary_0.Values)
                             .ToList<AlienRaceSystemStatus>())
                {
                    sqLiteCommand.CommandText =
                        "INSERT INTO FCT_AlienRaceSystemStatus (AlienRaceID, SystemID, ProtectionStatusID, GameID, ViewingRaceID ) \r\n                        VALUES (@AlienRaceID, @SystemID, @ProtectionStatusID, @GameID, @ViewingRaceID )";
                    sqLiteCommand.Parameters.AddWithValue("@AlienRaceID", gclass111.gclass110_0.ActualAlienRaceID);
                    sqLiteCommand.Parameters.AddWithValue("@SystemID", gclass111.gclass202_0.ActualSystemData.SystemID);
                    sqLiteCommand.Parameters.AddWithValue("@ProtectionStatusID",
                        gclass111.auroraSystemProtectionStatus_0);
                    sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                    sqLiteCommand.Parameters.AddWithValue("@ViewingRaceID", gclass111.gclass202_0.Race.RaceID);
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1506);
        }
    }

    public void method_153(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_DesignPhilosophy WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand(
                "DELETE FROM FCT_DesignPhilosophyTechProgressionCategories WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (DesignDoctrine gclass20 in this.FCTRaceRecordDic.Values
                             .Select<GameRace, DesignDoctrine>(gclass21_0 => gclass21_0.DesignDoctrine)
                             .ToList<DesignDoctrine>())
                {
                    if (gclass20 != null)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_DesignPhilosophy (GameID, RaceID, ActiveAntiMissile, ActiveAntiMissileSmall, ActiveAntiFAC, ActiveAntiFighter, ActiveLarge, ActiveVeryLarge, ActiveNavigation, ActiveStandard, ActiveSmall, ActiveFighterMissile, \r\n                            ActiveFighterBeam, FireControlAntiMissile, FireControlAntiFAC, FireControlAntiFighter, FireControlStandardMissile, FireControlFACMissile, FireControlBeamRange, FireControlBeamShortRange, FireControlBeamSpeed, \r\n                            JumpDriveDreadnought, JumpDriveBattlecruiser, JumpDriveCruiser, JumpDriveDestroyer, JumpDriveSurvey, PointDefenceWeapon, Carronade, CIWS, Gauss, Meson, MesonPointDefence, RailgunPointDefence, LaserLarge, LaserPointDefence, \r\n                            LaserSpinal, ParticleBeam, Railgun, LauncherFAC, LauncherStandard, LauncherMine, LauncherPointDefence, LauncherDecoy, HighPowerMicrowaveLarge, HighPowerMicrowaveSmall, NPRMissileStrategy,\r\n                            EngineCommercial, EngineMilitary, EngineFAC, EngineFighter, EngineSurvey, CloakDD, CloakCA, CloakBC, ShieldProportion, EMSensorSize1, EMSensorSize2, EMSensorSize3, EMSensorSize6, ThermalSensorSize1, \r\n                            ThermalSensorSize2, ThermalSensorSize3, ThermalSensorSize6, PrimaryBeamPreference, AlternativeBeamPreference, PointDefencePreference, JumpDriveMediumHive, JumpDriveLargeHive, JumpDriveVeryLargeHive,\r\n                            MissileFAC, MissileCaptorMine, MissileMineSecondStage, MissilePointDefence, MissileStandard, DecoyMissile, NumCommercialEngines, EngineSizeMilitary, EngineSizeCommercial, LauncherSize, LauncherDecoySize, LauncherAMMSize, \r\n                            NumSalvos, NumSalvosAMM, WarshipArmour, WarshipEngineering, WarshipEngineProportion, NumWarshipEngines, WarshipHullSize, ActiveResolution, SurveyEngineBoost, MilitaryEngineBoost, SurveySensors, TerraformModules, \r\n                            HarvesterModules, MiningModules, LauncherSizeModifier, MaxGeo, MaxGrav, MaxScout, MaxDiplomatic, MaxStabilisation, MaxSalvage, MaxTanker, UseJumpDrives, OrdnanceFactories, FighterFactories, ArmourMultiplier, \r\n                            GroundForceDeploymentThemeID, OpGroupProgressionType, FireControlFighterMissile, FireControlFighterBeam, FighterBeamWeapon, FighterEngineSize, HybridCarriers) \r\n                        VALUES ( @GameID, @RaceID, @ActiveAntiMissile, @ActiveAntiMissileSmall, @ActiveAntiFAC, @ActiveAntiFighter, @ActiveLarge, @ActiveVeryLarge, @ActiveNavigation, @ActiveStandard, @ActiveSmall, @ActiveFighterMissile, \r\n                            @ActiveFighterBeam, @FireControlAntiMissile, @FireControlAntiFAC, @FireControlAntiFighter, @FireControlStandardMissile, @FireControlFACMissile, @FireControlBeamRange, @FireControlBeamShortRange, @FireControlBeamSpeed,\r\n                            @JumpDriveDreadnought, @JumpDriveBattlecruiser, @JumpDriveCruiser, @JumpDriveDestroyer, @JumpDriveSurvey, @PointDefenceWeapon, @Carronade, @CIWS, @Gauss, @Meson, @MesonPointDefence, @RailgunPointDefence, @LaserLarge, @LaserPointDefence, \r\n                            @LaserSpinal, @ParticleBeam, @Railgun, @LauncherFAC, @LauncherStandard, @LauncherMine, @LauncherPointDefence, @LauncherDecoy, @HighPowerMicrowaveLarge, @HighPowerMicrowaveSmall, @NPRMissileStrategy,\r\n                            @EngineCommercial, @EngineMilitary, @EngineFAC, @EngineFighter, @EngineSurvey, @CloakDD, @CloakCA, @CloakBC, @ShieldProportion, @EMSensorSize1, @EMSensorSize2, @EMSensorSize3, @EMSensorSize6, @ThermalSensorSize1, \r\n                            @ThermalSensorSize2, @ThermalSensorSize3, @ThermalSensorSize6, @PrimaryBeamPreference, @AlternativeBeamPreference, @PointDefencePreference, @JumpDriveMediumHive, @JumpDriveLargeHive, @JumpDriveVeryLargeHive,\r\n                            @MissileFAC, @MissileCaptorMine, @MissileMineSecondStage, @MissilePointDefence, @MissileStandard, @DecoyMissile, @NumCommercialEngines, @EngineSizeMilitary, @EngineSizeCommercial, @LauncherSize, @LauncherDecoySize, @LauncherAMMSize, \r\n                            @NumSalvos, @NumSalvosAMM, @WarshipArmour, @WarshipEngineering, @WarshipEngineProportion, @NumWarshipEngines, @WarshipHullSize, @ActiveResolution, @SurveyEngineBoost, @MilitaryEngineBoost, @SurveySensors, @TerraformModules, \r\n                            @HarvesterModules, @MiningModules, @LauncherSizeModifier, @MaxGeo, @MaxGrav, @MaxScout, @MaxDiplomatic, @MaxStabilisation, @MaxSalvage, @MaxTanker, @UseJumpDrives, @OrdnanceFactories, @FighterFactories, @ArmourMultiplier, \r\n                            @GroundForceDeploymentThemeID, @OpGroupProgressionType, @FireControlFighterMissile, @FireControlFighterBeam, @FighterBeamWeapon, @FighterEngineSize, @HybridCarriers)";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass20.Race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@ActiveAntiMissile",
                            this.method_158(gclass20.ActiveAntiMissile));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveAntiMissileSmall",
                            this.method_158(gclass20.ActiveAntiMissileSmall));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveAntiFAC", this.method_158(gclass20.ActiveAntiFAC));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveAntiFighter",
                            this.method_158(gclass20.ActiveAntiFighter));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveLarge", this.method_158(gclass20.ActiveLarge));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveVeryLarge",
                            this.method_158(gclass20.ActiveVeryLarge));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveNavigation",
                            this.method_158(gclass20.ActiveNavigation));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveStandard", this.method_158(gclass20.ActiveStandard));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveSmall", this.method_158(gclass20.ActiveSmall));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveFighterMissile",
                            this.method_158(gclass20.ActiveFighterMissile));
                        sqLiteCommand.Parameters.AddWithValue("@ActiveFighterBeam",
                            this.method_158(gclass20.ActiveFighterBeam));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlAntiMissile",
                            this.method_158(gclass20.FCSAntiMissile));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlAntiFAC",
                            this.method_158(gclass20.FCSAntiFAC));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlAntiFighter",
                            this.method_158(gclass20.FCSAntiFighter));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlStandardMissile",
                            this.method_158(gclass20.FCSStandardMissile));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlFACMissile",
                            this.method_158(gclass20.FCSFastAttackCraftMissile));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlBeamRange",
                            this.method_158(gclass20.BeamFCSRange));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlBeamShortRange",
                            this.method_158(gclass20.BeamFCSShortRange));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlBeamSpeed",
                            this.method_158(gclass20.BeamFCSSpeed));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlFighterMissile",
                            this.method_158(gclass20.FCSFighterMissile));
                        sqLiteCommand.Parameters.AddWithValue("@FireControlFighterBeam",
                            this.method_158(gclass20.BeamFCSFighter));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveDreadnought",
                            this.method_158(gclass20.JumpDriveDreadnought));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveBattlecruiser",
                            this.method_158(gclass20.JumpDriveBattlecruiser));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveCruiser",
                            this.method_158(gclass20.JumpDriveCruiser));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveDestroyer",
                            this.method_158(gclass20.JumpDriveDestroyer));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveSurvey",
                            this.method_158(gclass20.JumpDriveSurvey));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveMediumHive",
                            this.method_158(gclass20.JumpDriveMediumHive));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveLargeHive",
                            this.method_158(gclass20.JumpDriveLargeHive));
                        sqLiteCommand.Parameters.AddWithValue("@JumpDriveVeryLargeHive",
                            this.method_158(gclass20.JumpDriveVeryLargeHive));
                        sqLiteCommand.Parameters.AddWithValue("@PointDefenceWeapon",
                            this.method_158(gclass20.PointDefenceWeapon));
                        sqLiteCommand.Parameters.AddWithValue("@Carronade", this.method_158(gclass20.Carronade));
                        sqLiteCommand.Parameters.AddWithValue("@CIWS", this.method_158(gclass20.CIWS));
                        sqLiteCommand.Parameters.AddWithValue("@Gauss", this.method_158(gclass20.Gauss));
                        sqLiteCommand.Parameters.AddWithValue("@Meson", this.method_158(gclass20.Meson));
                        sqLiteCommand.Parameters.AddWithValue("@MesonPointDefence",
                            this.method_158(gclass20.MesonPointDefence));
                        sqLiteCommand.Parameters.AddWithValue("@RailgunPointDefence",
                            this.method_158(gclass20.RailgunPointDefence));
                        sqLiteCommand.Parameters.AddWithValue("@LaserLarge", this.method_158(gclass20.LaserLarge));
                        sqLiteCommand.Parameters.AddWithValue("@LaserPointDefence",
                            this.method_158(gclass20.LaserPointDefence));
                        sqLiteCommand.Parameters.AddWithValue("@LaserSpinal", this.method_158(gclass20.LaserSpinal));
                        sqLiteCommand.Parameters.AddWithValue("@ParticleBeam", this.method_158(gclass20.ParticleBeam));
                        sqLiteCommand.Parameters.AddWithValue("@Railgun", this.method_158(gclass20.Railgun));
                        sqLiteCommand.Parameters.AddWithValue("@HighPowerMicrowaveLarge",
                            this.method_158(gclass20.HighPowerMicrowaveLarge));
                        sqLiteCommand.Parameters.AddWithValue("@HighPowerMicrowaveSmall",
                            this.method_158(gclass20.HighPowerMicrowaveSmall));
                        sqLiteCommand.Parameters.AddWithValue("@FighterBeamWeapon",
                            this.method_158(gclass20.FighterBeamWeapon));
                        sqLiteCommand.Parameters.AddWithValue("@LauncherFAC", this.method_158(gclass20.LauncherFAC));
                        sqLiteCommand.Parameters.AddWithValue("@LauncherStandard",
                            this.method_158(gclass20.LauncherStandard));
                        sqLiteCommand.Parameters.AddWithValue("@LauncherMine", this.method_158(gclass20.LauncherMine));
                        sqLiteCommand.Parameters.AddWithValue("@LauncherPointDefence",
                            this.method_158(gclass20.LauncherPointDefence));
                        sqLiteCommand.Parameters.AddWithValue("@LauncherDecoy", this.method_158(gclass20.LauncherDecoy));
                        sqLiteCommand.Parameters.AddWithValue("@EngineCommercial",
                            this.method_158(gclass20.EngineCommercial));
                        sqLiteCommand.Parameters.AddWithValue("@EngineMilitary",
                            this.method_158(gclass20.EngineMilitary));
                        sqLiteCommand.Parameters.AddWithValue("@EngineFAC", this.method_158(gclass20.EngineFAC));
                        sqLiteCommand.Parameters.AddWithValue("@EngineFighter", this.method_158(gclass20.EngineFighter));
                        sqLiteCommand.Parameters.AddWithValue("@EngineSurvey", this.method_158(gclass20.EngineSurvey));
                        sqLiteCommand.Parameters.AddWithValue("@ShieldProportion", gclass20.ShieldProportion);
                        sqLiteCommand.Parameters.AddWithValue("@CloakDD", this.method_158(gclass20.CloakDD));
                        sqLiteCommand.Parameters.AddWithValue("@CloakCA", this.method_158(gclass20.CloakCA));
                        sqLiteCommand.Parameters.AddWithValue("@CloakBC", this.method_158(gclass20.CloakBC));
                        sqLiteCommand.Parameters.AddWithValue("@EMSensorSize1", this.method_158(gclass20.EMSensorSize1));
                        sqLiteCommand.Parameters.AddWithValue("@EMSensorSize2", this.method_158(gclass20.EMSensorSize2));
                        sqLiteCommand.Parameters.AddWithValue("@EMSensorSize3", this.method_158(gclass20.EMSensorSize3));
                        sqLiteCommand.Parameters.AddWithValue("@EMSensorSize6", this.method_158(gclass20.EMSensorSize6));
                        sqLiteCommand.Parameters.AddWithValue("@ThermalSensorSize1",
                            this.method_158(gclass20.ThermalSensorSize1));
                        sqLiteCommand.Parameters.AddWithValue("@ThermalSensorSize2",
                            this.method_158(gclass20.ThermalSensorSize2));
                        sqLiteCommand.Parameters.AddWithValue("@ThermalSensorSize3",
                            this.method_158(gclass20.ThermalSensorSize3));
                        sqLiteCommand.Parameters.AddWithValue("@ThermalSensorSize6",
                            this.method_158(gclass20.ThermalSensorSize6));
                        sqLiteCommand.Parameters.AddWithValue("@LauncherSizeModifier",
                            this.method_159(gclass20.gclass164_0));
                        sqLiteCommand.Parameters.AddWithValue("@PrimaryBeamPreference", gclass20.PrimaryBeamPreference);
                        sqLiteCommand.Parameters.AddWithValue("@AlternativeBeamPreference", gclass20.AlternativeBeamPreference);
                        sqLiteCommand.Parameters.AddWithValue("@PointDefencePreference", gclass20.PointDefencePreference);
                        sqLiteCommand.Parameters.AddWithValue("@FighterEngineSize", gclass20.FighterEngineSize);
                        sqLiteCommand.Parameters.AddWithValue("@MissileFAC", this.method_160(gclass20.MissileFAC));
                        sqLiteCommand.Parameters.AddWithValue("@MissileCaptorMine",
                            this.method_160(gclass20.MissileCaptorMine));
                        sqLiteCommand.Parameters.AddWithValue("@MissileMineSecondStage",
                            this.method_160(gclass20.MissileMineSecondStage));
                        sqLiteCommand.Parameters.AddWithValue("@MissilePointDefence",
                            this.method_160(gclass20.MissilePointDefence));
                        sqLiteCommand.Parameters.AddWithValue("@MissileStandard",
                            this.method_160(gclass20.MissileStandard));
                        sqLiteCommand.Parameters.AddWithValue("@DecoyMissile", this.method_160(gclass20.DecoyMissile));
                        sqLiteCommand.Parameters.AddWithValue("@NumCommercialEngines", gclass20.NumCommercialEngines);
                        sqLiteCommand.Parameters.AddWithValue("@EngineSizeMilitary", gclass20.EngineSizeMilitary);
                        sqLiteCommand.Parameters.AddWithValue("@EngineSizeCommercial", gclass20.EngineSizeCommercial);
                        sqLiteCommand.Parameters.AddWithValue("@LauncherSize", gclass20.LauncherSize);
                        sqLiteCommand.Parameters.AddWithValue("@LauncherDecoySize", gclass20.LauncherDecoySize);
                        sqLiteCommand.Parameters.AddWithValue("@LauncherAMMSize", gclass20.LauncherAMMSize);
                        sqLiteCommand.Parameters.AddWithValue("@NumSalvos", gclass20.NumSalvos);
                        sqLiteCommand.Parameters.AddWithValue("@NumSalvosAMM", gclass20.NumSalvosAMM);
                        sqLiteCommand.Parameters.AddWithValue("@WarshipArmour", gclass20.WarshipArmour);
                        sqLiteCommand.Parameters.AddWithValue("@WarshipEngineering", gclass20.WarshipEngineering);
                        sqLiteCommand.Parameters.AddWithValue("@WarshipEngineProportion", gclass20.WarshipEngineProportion);
                        sqLiteCommand.Parameters.AddWithValue("@NumWarshipEngines", gclass20.NumWarshipEngines);
                        sqLiteCommand.Parameters.AddWithValue("@WarshipHullSize", gclass20.WarshipHullSize);
                        sqLiteCommand.Parameters.AddWithValue("@ActiveResolution", gclass20.ActiveResolution);
                        sqLiteCommand.Parameters.AddWithValue("@SurveyEngineBoost", gclass20.SurveyEngineBoost);
                        sqLiteCommand.Parameters.AddWithValue("@MilitaryEngineBoost", gclass20.MilitaryEngineBoost);
                        sqLiteCommand.Parameters.AddWithValue("@SurveySensors", gclass20.SurveySensors);
                        sqLiteCommand.Parameters.AddWithValue("@TerraformModules", gclass20.TerraformModules);
                        sqLiteCommand.Parameters.AddWithValue("@HarvesterModules", gclass20.HarvesterModule);
                        sqLiteCommand.Parameters.AddWithValue("@MiningModules", gclass20.MiningModules);
                        sqLiteCommand.Parameters.AddWithValue("@NPRMissileStrategy", gclass20.NPRMissileStrategy);
                        sqLiteCommand.Parameters.AddWithValue("@MaxGeo", gclass20.MaxGeo);
                        sqLiteCommand.Parameters.AddWithValue("@MaxGrav", gclass20.MaxGrav);
                        sqLiteCommand.Parameters.AddWithValue("@MaxScout", gclass20.MaxScout);
                        sqLiteCommand.Parameters.AddWithValue("@MaxDiplomatic", gclass20.MaxDiplomatic);
                        sqLiteCommand.Parameters.AddWithValue("@MaxStabilisation", gclass20.MaxStabilisation);
                        sqLiteCommand.Parameters.AddWithValue("@MaxSalvage", gclass20.MaxSalvage);
                        sqLiteCommand.Parameters.AddWithValue("@MaxTanker", gclass20.MaxTanker);
                        sqLiteCommand.Parameters.AddWithValue("@UseJumpDrives", gclass20.bUseJumpDrive);
                        sqLiteCommand.Parameters.AddWithValue("@OrdnanceFactories", gclass20.bOrdnanceFactories);
                        sqLiteCommand.Parameters.AddWithValue("@FighterFactories", gclass20.bFighterFactories);
                        sqLiteCommand.Parameters.AddWithValue("@ArmourMultiplier", gclass20.ArmourMultiplier);
                        sqLiteCommand.Parameters.AddWithValue("@GroundForceDeploymentThemeID", gclass20.GroundForceDeploymentThemeID);
                        sqLiteCommand.Parameters.AddWithValue("@OpGroupProgressionType", gclass20.OperationGroupProgressionType);
                        sqLiteCommand.Parameters.AddWithValue("@HybridCarriers", gclass20.bHybridCarriers);
                        sqLiteCommand.ExecuteNonQuery();
                        foreach (TechProgressionCategoryType genum89 in gclass20.list_2)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_DesignPhilosophyTechProgressionCategories (RaceID, GameID, TechProgressionCategoryID ) VALUES ( @RaceID, @GameID, @TechProgressionCategoryID )";
                            sqLiteCommand.Parameters.AddWithValue("@RaceID", gclass20.Race.RaceID);
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.Parameters.AddWithValue("@TechProgressionCategoryID", genum89);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1507);
        }
    }
    
    public void method_157(int int_136, string string_10)
    {
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(AuroraUtils.string_1))
            {
                connection.Open();
                using (SQLiteCommand sqLiteCommand = new SQLiteCommand(connection))
                {
                    using (SQLiteTransaction sqLiteTransaction = connection.BeginTransaction())
                    {
                        sqLiteCommand.CommandText = "UPDATE FCT_Game SET GameName = @GameName WHERE GameID =" +
                                                    int_136.ToString();
                        sqLiteCommand.Parameters.AddWithValue("@GameName", string_10);
                        sqLiteCommand.ExecuteNonQuery();
                        sqLiteTransaction.Commit();
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1428);
        }
    }
}