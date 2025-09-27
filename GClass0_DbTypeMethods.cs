using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aurora;

public partial class GClass0
{
    public void ReadMaxRecordIDForEachTableFromDB()
    {
        try
        {
            SQLiteDatabaseC1181 sqLiteDatabaseC1181 = new SQLiteDatabaseC1181();
            this.MaxGameID = sqLiteDatabaseC1181.method_1("FCT_Game", "GameID");
            this.MaxIncrementID = sqLiteDatabaseC1181.method_1("FCT_Increments", "IncrementID");
            this.MaxRuinRaceID = sqLiteDatabaseC1181.method_1("FCT_RuinRace", "RuinRaceID");
            this.MaxSystemID = sqLiteDatabaseC1181.method_1("FCT_System", "SystemID");
            this.MaxOrderTemplateID = sqLiteDatabaseC1181.method_1("FCT_OrderTemplate", "OrderTemplateID");
            this.MaxSystemBodyID = sqLiteDatabaseC1181.method_1("FCT_SystemBody", "SystemBodyID");
            this.MaxStarID = sqLiteDatabaseC1181.method_1("FCT_Star", "StarID");
            this.MaxWarpPointID = sqLiteDatabaseC1181.method_1("FCT_JumpPoint", "WarpPointID");
            this.int_7 = sqLiteDatabaseC1181.method_1("FCT_LagrangePoint", "LaGrangePointID");
            this.int_8 = sqLiteDatabaseC1181.method_1("FCT_AncientConstruct", "AncientConstructID");
            this.int_9 = sqLiteDatabaseC1181.method_1("FCT_SurveyLocation", "SurveyLocationID");
            this.int_10 = sqLiteDatabaseC1181.method_1("FCT_Species", "SpeciesID");
            this.int_11 = sqLiteDatabaseC1181.method_1("FCT_Race", "RaceID");
            this.int_12 = sqLiteDatabaseC1181.method_1("FCT_Ranks", "RankID");
            this.int_13 = sqLiteDatabaseC1181.method_1("FCT_WayPoint", "WayPointID");
            this.int_56 = sqLiteDatabaseC1181.method_1("FCT_TechSystem", "TechSystemID");
            this.int_14 = sqLiteDatabaseC1181.method_1("FCT_ShipDesignComponents", "SDComponentID");
            this.int_15 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitClass", "GroundUnitClassID");
            this.int_16 = sqLiteDatabaseC1181.method_1("FCT_MissileType", "MissileID");
            this.int_17 = sqLiteDatabaseC1181.method_1("FCT_ShipClass", "ShipClassID");
            this.int_18 = sqLiteDatabaseC1181.method_1("FCT_Population", "PopulationID");
            this.int_19 = sqLiteDatabaseC1181.method_1("FCT_NavalAdminCommand", "NavalAdminCommandID");
            this.int_20 = sqLiteDatabaseC1181.method_1("FCT_Fleet", "FleetID");
            this.int_21 = sqLiteDatabaseC1181.method_1("FCT_SubFleets", "SubFleetID");
            this.int_22 = sqLiteDatabaseC1181.method_1("FCT_ShippingLines", "ShippingLineID");
            this.int_23 = sqLiteDatabaseC1181.method_1("FCT_Ship", "ShipID");
            this.int_24 = sqLiteDatabaseC1181.method_1("FCT_Shipyard", "ShipyardID");
            this.int_25 = sqLiteDatabaseC1181.method_1("FCT_ShipyardTask", "TaskID");
            this.int_26 = sqLiteDatabaseC1181.method_1("FCT_IndustrialProjects", "ProjectID");
            this.int_27 = sqLiteDatabaseC1181.method_1("FCT_MassDriverPackets", "PacketID");
            this.int_28 = sqLiteDatabaseC1181.method_1("FCT_Lifepods", "LifepodID");
            this.int_30 = sqLiteDatabaseC1181.method_1("FCT_SectorCommand", "SectorCommandID");
            this.int_31 = sqLiteDatabaseC1181.method_1("FCT_ResearchProject", "ProjectID");
            this.int_32 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitFormation", "FormationID");
            this.int_33 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitFormationTemplate", "TemplateID");
            this.int_34 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitTraining", "TaskID");
            this.int_35 = sqLiteDatabaseC1181.method_1("FCT_Commander", "CommanderID");
            this.int_36 = sqLiteDatabaseC1181.method_1("FCT_Contacts", "UniqueID");
            this.int_37 = sqLiteDatabaseC1181.method_1("FCT_MoveOrders", "MoveOrderID");
            this.int_38 = sqLiteDatabaseC1181.method_1("FCT_MissileSalvo", "MissileSalvoID");
            this.int_39 = sqLiteDatabaseC1181.method_1("FCT_AlienClass", "AlienClassID");
            this.int_40 = sqLiteDatabaseC1181.method_1("FCT_Wrecks", "WreckID");
            this.int_42 = sqLiteDatabaseC1181.method_1("FCT_HullDescription", "HullDescriptionID");
            this.int_43 = sqLiteDatabaseC1181.method_1("FCT_AlienRaceSensor", "AlienSensorID");
            this.int_44 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitFormationElement", "ElementID");
            this.int_47 = sqLiteDatabaseC1181.method_1("FCT_RaceMedals", "MedalID");
            this.int_48 = sqLiteDatabaseC1181.method_1("DIM_NamingThemeTypes", "ThemeID");
            this.int_49 = sqLiteDatabaseC1181.method_1("DIM_CommanderNameTheme", "NameThemeID");
            this.int_45 = sqLiteDatabaseC1181.method_1("FCT_AlienGroundUnitClass", "AlienGroundUnitClassID");
            this.int_50 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitSeries", "GroundUnitSeriesID");
            this.int_29 = sqLiteDatabaseC1181.method_1("FCT_AetherGates", "AetherGateID");
            this.int_53 = sqLiteDatabaseC1181.method_1("FCT_ShipClassTemplate", "ShipClassTemplateID");
            this.int_54 = sqLiteDatabaseC1181.method_1("FCT_ShipComponentTemplate", "ShipComponentTemplateID");
            this.int_51 = sqLiteDatabaseC1181.method_1("FCT_Squadron", "SquadronID");
            this.int_52 = sqLiteDatabaseC1181.method_1("FCT_OrganizationNode", "OrganizationID");
            this.int_55 = sqLiteDatabaseC1181.method_1("FCT_StandingOrderTemplate", "TemplateID");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1402);
        }
    }
    
    public void LoadFCTRaceNameThemes()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_RaceNameThemes where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                RaceNameTheme RaceNameTheme = new RaceNameTheme();
                int nameThemeID = Convert.ToInt32(row["NameThemeID"]);
                if (this.NameThemeDictionary.ContainsKey(nameThemeID))
                {
                    RaceNameTheme.CommanderNameThemeData = this.NameThemeDictionary[nameThemeID];
                    int raceID = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(raceID))
                    {
                        RaceNameTheme.Chance = Convert.ToInt32(row["Chance"]);
                        this.FCTRaceRecordDic[raceID].RaceNameThemeList.Add(RaceNameTheme);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1127);
        }
    }

    public void LoadFCTSquadron()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_Squadron where GameID = {this.GameID.ToString()}").Rows)
            {
                FCTSquadronData70 squadronData = new FCTSquadronData70(this);
                int parentShipId = Convert.ToInt32(row["ParentShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(parentShipId))
                {
                    squadronData.ParentShipData = this.FCTShipDataDictionary[parentShipId];
                    squadronData.SquadronID = Convert.ToInt32(row["SquadronID"]);
                    squadronData.SquadronName = row["SquadronName"].ToString();
                    squadronData.ParentShipData.ChildSquadronDictionary.Add(squadronData.SquadronID, squadronData);
                }
            }

            // 연관지울수 있는 SquadronData가 확인되어야만 LinkedSquadronID를 할당한다 AssignedSquadronID는 DB에서 꺼낸 날것의 값으로 존재를 보장하지 못함
            List<FCTShipData40> list = this.FCTShipDataDictionary.Values
                .Where(shipData => shipData.AssignedSquadronID > 0).ToList();
            Dictionary<int, FCTSquadronData70> existingShipsChildSquadronDic = this.FCTShipDataDictionary.Values
                .SelectMany(
                    ship => ship.ChildSquadronDictionary)
                .ToDictionary(kvPair => kvPair.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (FCTShipData40 shipDataInList in list)
            {
                if (existingShipsChildSquadronDic.ContainsKey(shipDataInList.AssignedSquadronID))
                {
                    shipDataInList.SquadronData = existingShipsChildSquadronDic[shipDataInList.AssignedSquadronID];
                    shipDataInList.LinkedSquadronID = shipDataInList.SquadronData.SquadronID;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3512);
        }
    }

    public void LoadFCTBannedBodyFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_BannedBodies where GameID = {this.GameID.ToString()}").Rows)
            {
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceID))
                {
                    int systemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                    if (this.SystemBodyRecordDic.ContainsKey(systemBodyID))
                        this.FCTRaceRecordDic[raceID].BannedSystemBodies.Add(this.SystemBodyRecordDic[systemBodyID]);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1128);
        }
    }

    public void LoadFCTShipClassTemplateFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_ShipClassTemplate").Rows)
            {
                ShipClassTemplate184 shipClassTemplate = new ShipClassTemplate184();
                shipClassTemplate.HullID = Convert.ToInt32(row["HullID"]);
                if (this.ShipHullDictionary.ContainsKey(shipClassTemplate.HullID))
                {
                    shipClassTemplate.ShipClassTemplateID = Convert.ToInt32(row["ShipClassTemplateID"]);
                    shipClassTemplate.ShipClassTemplateName = row["ShipClassTemplateName"].ToString();
                    shipClassTemplate.ArmourThickness = Convert.ToInt32(row["ArmourThickness"]);
                    shipClassTemplate.Collier = Convert.ToInt32(row["Collier"]);
                    shipClassTemplate.ConscriptOnly = Convert.ToInt32(row["ConscriptOnly"]);
                    shipClassTemplate.FuelTanker = Convert.ToInt32(row["FuelTanker"]);
                    shipClassTemplate.SupplyShip = Convert.ToInt32(row["SupplyShip"]);
                    shipClassTemplate.NoArmour = Convert.ToInt32(row["NoArmour"]);
                    shipClassTemplate.NoOfficers = Convert.ToInt32(row["NoOfficers"]);
                    shipClassTemplate.SeniorCO = Convert.ToInt32(row["SeniorCO"]);
                    shipClassTemplate.MinimumSupplies = Convert.ToInt32(row["MinimumSupplies"]);
                    shipClassTemplate.MinimumFuel = Convert.ToInt32(row["MinimumFuel"]);
                    shipClassTemplate.ResupplyPriority = Convert.ToInt32(row["ResupplyPriority"]);
                    shipClassTemplate.RefuelPriority = Convert.ToInt32(row["RefuelPriority"]);
                    shipClassTemplate.PDProtectionPriority = Convert.ToInt32(row["PDProtectionPriority"]);
                    shipClassTemplate.CommanderPriority = Convert.ToInt32(row["CommanderPriority"]);
                    shipClassTemplate.MaintPriority = Convert.ToInt32(row["MaintPriority"]);
                    shipClassTemplate.PlannedDeployment = Convert.ToDecimal(row["PlannedDeployment"]);
                    this.ShipClassTemplateDictionary.Add(shipClassTemplate.ShipClassTemplateID, shipClassTemplate);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3715);
        }
    }

    public void LoadFCTClassComponentTemplateFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_ClassComponentTemplate").Rows)
            {
                ClassComponentTemplate186 classComponentTemplate = new ClassComponentTemplate186(this);
                classComponentTemplate.ShipClassTemplateID = Convert.ToInt32(row["ShipClassTemplateID"]);
                if (this.ShipClassTemplateDictionary.ContainsKey(classComponentTemplate.ShipClassTemplateID))
                {
                    classComponentTemplate.ShipComponentTemplateID = Convert.ToInt32(row["ShipComponentTemplateID"]);
                    classComponentTemplate.StandardComponentID = Convert.ToInt32(row["StandardComponentID"]);
                    classComponentTemplate.NumComponent = Convert.ToInt32(row["NumComponent"]);
                    this.ShipClassTemplateDictionary[classComponentTemplate.ShipClassTemplateID].ComponentTemplateList
                        .Add(classComponentTemplate);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3716);
        }
    }

    public void LoadFCTWindowPositionFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_WindowPosition where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                WindowPosition207 winPosition = new WindowPosition207();
                winPosition.Left = Convert.ToInt32(row["Left"]);
                winPosition.Top = Convert.ToInt32(row["Top"]);
                winPosition.WindowName = row["WindowName"].ToString();
                this.WindowPositionDictionary.Add(winPosition.WindowName, winPosition);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1131);
        }
    }

    public void LoadFCTSystemFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_System where GameID = {this.GameID.ToString()}").Rows)
            {
                SystemData200 systemData = new SystemData200(this);
                systemData.SystemNumber = Convert.ToInt32(row["SystemNumber"]);
                if (this.UseKnownStars == 1 && this.KnownSystemDataDictionary.ContainsKey(systemData.SystemNumber))
                    systemData.KnownSystemData = this.KnownSystemDataDictionary[systemData.SystemNumber];
                systemData.SystemID = Convert.ToInt32(row["SystemID"]);
                systemData.AbundanceModifier = Convert.ToInt32(row["AbundanceModifier"]);
                systemData.Stars = Convert.ToInt32(row["Stars"]);
                systemData.JumpPointSurveyPoints = Convert.ToInt32(row["JumpPointSurveyPoints"]);
                systemData.SystemTypeID = Convert.ToInt32(row["SystemTypeID"]);
                systemData.DustDensity = Convert.ToInt32(row["DustDensity"]);
                systemData.NoSensorChecks = Convert.ToInt32(row["NoSensorChecks"]);
                systemData.SupernovaForce = Convert.ToInt32(row["SupernovaForce"]);
                systemData.SupernovaElapsedTime = Convert.ToInt32(row["SupernovaElapsedTime"]);
                systemData.Age = Convert.ToDouble(row["Age"]);
                systemData.IsSolSystem = Convert.ToBoolean(row["SolSystem"]);
                this.SystemDataDictionary.Add(systemData.SystemID, systemData);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1132);
        }
    }

    public void LoadFCTMapLabelsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_MapLabel where GameID = {this.GameID.ToString()}").Rows)
            {
                MapLabelData122 mapLabel = new MapLabelData122(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceID))
                {
                    mapLabel.Race = this.FCTRaceRecordDic[raceID];
                    int colorArgb = Convert.ToInt32(row["Colour"]);
                    mapLabel.Color = Color.FromArgb(colorArgb);
                    mapLabel.XCoord = Convert.ToDouble(row["Xcor"]);
                    mapLabel.YCoord = Convert.ToDouble(row["Ycor"]);
                    mapLabel.Caption = row["Caption"].ToString();
                    mapLabel.SavedXCoord = mapLabel.XCoord;
                    mapLabel.SavedYCoord = mapLabel.YCoord;
                    int fontSize = Convert.ToInt32(row["FontSize"]);
                    string fontFamilyName = row["FontName"].ToString();
                    bool italic = Convert.ToBoolean(row["FontItalic"]);
                    bool bold = Convert.ToBoolean(row["FontBold"]);
                    mapLabel.Font = !italic || !bold
                        ? (!bold
                            ? (!italic
                                ? new Font(fontFamilyName, fontSize)
                                : new Font(fontFamilyName, fontSize, FontStyle.Italic))
                            : new Font(fontFamilyName, fontSize, FontStyle.Bold))
                        : new Font(fontFamilyName, fontSize, FontStyle.Bold | FontStyle.Italic);
                    mapLabel.Race.MapLabelList.Add(mapLabel);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1141);
        }
    }


    public void LoadFCTSurveyLocationFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_SurveyLocation where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                SurveyLocation213 surveyLocation = new SurveyLocation213();
                int systemId = Convert.ToInt32(row["SystemID"]);
                if (this.SystemDataDictionary.ContainsKey(systemId))
                {
                    surveyLocation.SurveyLocationID = Convert.ToInt32(row["SurveyLocationID"]);
                    surveyLocation.SystemID = Convert.ToInt32(row["SystemID"]);
                    surveyLocation.LocationNumber = Convert.ToInt32(row["LocationNumber"]);
                    surveyLocation.XCoord = Convert.ToDouble(row["Xcor"]);
                    surveyLocation.YCoord = Convert.ToDouble(row["Ycor"]);
                    this.SystemDataDictionary[systemId].SurveyLocationDictionary
                        .Add(surveyLocation.LocationNumber, surveyLocation);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1142);
        }
    }
    
    public void LoadFCTAcidAttakFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_AcidAttack").Rows)
            {
                AcidAttack gclass25 = new AcidAttack();
                int targetShipID = Convert.ToInt32(row["TargetShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(targetShipID))
                {
                    gclass25.TargetShip = this.FCTShipDataDictionary[targetShipID];
                    gclass25.ArmourColumn = Convert.ToInt32(row["ArmourColumn"]);
                    gclass25.RemainingDamage = Convert.ToInt32(row["RemainingDamage"]);
                    gclass25.PointOfDamageTime = Convert.ToInt32(row["PointOfDamageTime"]);
                    gclass25.LastDamageTime = Convert.ToDecimal(row["LastDamageTime"]);
                    this.AcidAttackList.Add(gclass25);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1133);
        }
    }
    
    public void LoadFCTMassDriverPacketsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_MassDriverPackets where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                FCTMassDriverPacket126 gclass126 = new FCTMassDriverPacket126();
                int destID = Convert.ToInt32(row["DestID"]);
                if (this.PopulationDataDictionary.ContainsKey(destID))
                {
                    gclass126.gclass146_0 = this.PopulationDataDictionary[destID];
                    int raceID = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(raceID))
                    {
                        gclass126.Race = this.FCTRaceRecordDic[raceID];
                        int systemID = Convert.ToInt32(row["SysID"]);
                        if (this.SystemDataDictionary.ContainsKey(systemID))
                        {
                            gclass126.System = this.SystemDataDictionary[systemID];
                            gclass126.PacketID = Convert.ToInt32(row["PacketID"]);
                            gclass126.Speed = Convert.ToDecimal(row["Speed"]);
                            gclass126.TotalSize = Convert.ToDecimal(row["TotalSize"]);
                            gclass126.XCoord = Convert.ToDouble(row["Xcor"]);
                            gclass126.YCoord = Convert.ToDouble(row["Ycor"]);
                            gclass126.LastXCoord = Convert.ToDouble(row["LastXcor"]);
                            gclass126.LastYCoord = Convert.ToDouble(row["LastYcor"]);
                            gclass126.IncrementStartX = Convert.ToDouble(row["IncrementStartX"]);
                            gclass126.IncrementStartY = Convert.ToDouble(row["IncrementStartY"]);
                            gclass126.MineralsValue = new AllMineralsValue(this);
                            gclass126.MineralsValue.Duranium = Convert.ToDecimal(row["Duranium"]);
                            gclass126.MineralsValue.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                            gclass126.MineralsValue.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                            gclass126.MineralsValue.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                            gclass126.MineralsValue.Boronide = Convert.ToDecimal(row["Boronide"]);
                            gclass126.MineralsValue.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                            gclass126.MineralsValue.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                            gclass126.MineralsValue.Sorium = Convert.ToDecimal(row["Sorium"]);
                            gclass126.MineralsValue.Uridium = Convert.ToDecimal(row["Uridium"]);
                            gclass126.MineralsValue.Corundium = Convert.ToDecimal(row["Corundium"]);
                            gclass126.MineralsValue.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                            this.MassDriverPacketsDictionary.Add(gclass126.PacketID, gclass126);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1147);
        }
    }
    
    public void LoadFCTRaceOperationalGroupElementsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_RaceOperationalGroupElements WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                RaceOperationalGroupElement gclass11 = new RaceOperationalGroupElement();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    OperationalGroupID int32_2 = (OperationalGroupID)Convert.ToInt32(row["OperationalGroupID"]);
                    if (this.OperationalGroupDictionary.ContainsKey(int32_2))
                    {
                        gclass11.Element = this.OperationalGroupDictionary[int32_2];
                        AutomatedClassDesignType int32_3 = (AutomatedClassDesignType)Convert.ToInt32(row["AutomatedDesignID"]);
                        if (this.AutomatedClassDesignDictionary.ContainsKey(int32_3))
                        {
                            gclass11.AutomatedClassDesign = this.AutomatedClassDesignDictionary[int32_3];
                            gclass11.NumShips = Convert.ToInt32(row["NumShips"]);
                            gclass11.KeyElement = Convert.ToBoolean(row["KeyElement"]);
                            this.FCTRaceRecordDic[int32_1].OperationalGroupElements.Add(gclass11);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3293);
        }
    }
    
    public void LoadFCTTechProgressionRaceFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_TechProgressionRace where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class83 class83 = new GClass0.Class83();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32))
                {
                    // ISSUE: reference to a compiler-generated field
                    class83.int_0 = Convert.ToInt32(row["ProgressionOrder"]);
                    // ISSUE: reference to a compiler-generated method
                    this.DesignPhilosophyTechProgressionsDictionary.FirstOrDefault(class83.method_0)?.list_0
                        .Add(this.FCTRaceRecordDic[int32]);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1139);
        }
    }
    
    public void LoadFCTWaypointFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_WayPoint where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass214 gclass214 = new GClass214(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass214.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["SystemID"]);
                    if (this.SystemDataDictionary.ContainsKey(int32_2))
                    {
                        gclass214.gclass200_0 = this.SystemDataDictionary[int32_2];
                        gclass214.int_1 = Convert.ToInt32(row["OrbitBodyID"]);
                        if (this.SystemBodyRecordDic.ContainsKey(gclass214.int_1))
                            gclass214.gclass1_0 = this.SystemBodyRecordDic[gclass214.int_1];
                        gclass214.int_2 = Convert.ToInt32(row["FleetID"]);
                        if (this.FleetDictionary.ContainsKey(gclass214.int_2) || gclass214.int_2 <= 0)
                        {
                            int int32_3 = Convert.ToInt32(row["JumpPointID"]);
                            if (this.JumpPointDictionary.ContainsKey(int32_3))
                                gclass214.gclass120_0 = this.JumpPointDictionary[int32_3];
                            gclass214.int_0 = Convert.ToInt32(row["WaypointID"]);
                            gclass214.int_3 = Convert.ToInt32(row["Number"]);
                            gclass214.wayPointType_0 = (WayPointType)Convert.ToInt32(row["WaypointType"]);
                            gclass214.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass214.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass214.decimal_0 = Convert.ToDecimal(row["CreationTime"]);
                            gclass214.Name = row["Name"].ToString();
                            this.dictionary_13.Add(gclass214.int_0, gclass214);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1146);
        }
    }

    public void LoadFCTWealthHistoryFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_WealthHistory where GameID = {this.GameID.ToString()}").Rows)
            {
                WealthHistory wealthHistory = new WealthHistory();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32))
                {
                    wealthHistory.IncrementTime = Convert.ToDecimal(row["IncrementTime"]);
                    wealthHistory.WealthAmount = Convert.ToDecimal(row["WealthAmount"]);
                    this.FCTRaceRecordDic[int32].list_12.Add(wealthHistory);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1127);
        }
    }

    public void LoadFCTOrganizationNodeFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_OrganizationNode where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                OrganizationNodeC93 gclass93 = new OrganizationNodeC93();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass93.Race = this.FCTRaceRecordDic[int32_1];
                    int formationTemplateID = Convert.ToInt32(row["FormationTemplateID"]);
                    if (this.FormationTemplateRecordDic.ContainsKey(formationTemplateID))
                        gclass93.FormationTemplate = this.FormationTemplateRecordDic[formationTemplateID];
                    gclass93.ParentOrganizationID = Convert.ToInt32(row["ParentOrganizationID"]);
                    gclass93.OrganizationID = Convert.ToInt32(row["OrganizationID"]);
                    gclass93.FieldPosition = (AuroraGroundFormationFieldPosition)Convert.ToInt32(row["FieldPosition"]);
                    gclass93.OrganizationName = row["OrganizationName"].ToString();
                    gclass93.NodeExpanded = Convert.ToBoolean(row["NodeExpanded"]);
                    this.FCTRaceRecordDic[int32_1].OrganizationNodeDictionary.Add(gclass93.OrganizationID, gclass93);
                }
            }

            List<OrganizationNodeC93> list = this.FCTRaceRecordDic.Values
                .SelectMany(race =>
                    race.OrganizationNodeDictionary.Values).ToList();
            foreach (OrganizationNodeC93 orgNode in list)
            {
                if (orgNode.ParentOrganizationID != 0)
                {
                    orgNode.ParentOrganizationNode =
                        list.FirstOrDefault(node =>
                            node.OrganizationID == orgNode.ParentOrganizationID);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1127);
        }
    }

    public void LoadFCTRaceMedalsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_RaceMedals where GameID = {this.GameID.ToString()}").Rows)
            {
                FCTRaceMedalRecord raceMedal = new FCTRaceMedalRecord(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceID))
                {
                    raceMedal.Race = this.FCTRaceRecordDic[raceID];
                    raceMedal.MedalID = Convert.ToInt32(row["MedalID"]);
                    raceMedal.MedalPoints = Convert.ToInt32(row["MedalPoints"]);
                    raceMedal.AllowMultipleAward = Convert.ToBoolean(row["MultipleAwards"]);
                    raceMedal.MedalName = row["MedalName"].ToString();
                    raceMedal.MedalDescription = row["MedalDescription"].ToString();
                    raceMedal.MedalFileName = row["MedalFileName"].ToString();
                    raceMedal.Abbreviation = row["Abbreviation"].ToString();
                    try
                    {
                        raceMedal.MedalImageLoaded =
                            Image.FromFile($"{Application.StartupPath}\\Medals\\{raceMedal.MedalFileName}");
                    }
                    catch
                    {
                        int num = (int)MessageBox.Show("No Image found for Medal: " + raceMedal.MedalName);
                    }

                    this.RaceMedalDictionary.Add(raceMedal.MedalID, raceMedal);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1130);
        }
    }

    public void LoadRaceGroundCombatFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_RaceGroundCombat where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                RaceGroundCombat raceGroundCombat = new RaceGroundCombat();
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceID))
                {
                    int systemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                    if (this.SystemBodyRecordDic.ContainsKey(systemBodyID))
                        raceGroundCombat.SystemBody = this.SystemBodyRecordDic[systemBodyID];
                    raceGroundCombat.ConsecutiveCombatRounds = Convert.ToInt32(row["ConsecutiveCombatRounds"]);
                    this.FCTRaceRecordDic[raceID].raceGroundCombatRecord
                        .Add(raceGroundCombat.SystemBody, raceGroundCombat);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1129);
        }
    }

    public void LoadFCTDecoyAssignmentFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_DecoyAssignment WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                FCTDecoyAssignmentData32 decoyAssignment = new FCTDecoyAssignmentData32();
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(shipID))
                {
                    decoyAssignment.FCTShipData = this.FCTShipDataDictionary[shipID];
                    int launcherID = Convert.ToInt32(row["LauncherID"]);
                    if (this.ComponentDataDictionary.ContainsKey(launcherID))
                    {
                        decoyAssignment.LauncherData = this.ComponentDataDictionary[launcherID];
                        decoyAssignment.LauncherNum = Convert.ToInt32(row["LauncherNum"]);
                        this.FCTShipDataDictionary[shipID].DecoyAssignmentList.Add(decoyAssignment);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3681);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3681);
        }
    }

    public void LoadGameRacesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Race where GameID = {this.GameID.ToString()}").Rows)
            {
                GameRace raceRecord = new GameRace(this);
                int int32_1 = Convert.ToInt32(row["SystemThemeID"]);
                if (this.ThemeDictionary.ContainsKey(int32_1))
                    raceRecord.SystemTheme = this.ThemeDictionary[int32_1];
                int int32_2 = Convert.ToInt32(row["ClassThemeID"]);
                if (this.ThemeDictionary.ContainsKey(int32_2))
                    raceRecord.ClassTheme = this.ThemeDictionary[int32_2];
                int int32_3 = Convert.ToInt32(row["MissileThemeID"]);
                if (this.ThemeDictionary.ContainsKey(int32_3))
                    raceRecord.MissileTheme = this.ThemeDictionary[int32_3];
                int int32_4 = Convert.ToInt32(row["GroundThemeID"]);
                if (this.ThemeDictionary.ContainsKey(int32_4))
                    raceRecord.GroundTheme = this.ThemeDictionary[int32_4];
                raceRecord.RaceID = Convert.ToInt32(row["RaceID"]);
                raceRecord.SpecialNPRID = (SpecialNPRIDs)Convert.ToInt32(row["SpecialNPRID"]);
                raceRecord.RaceStartingLevel = (GEnum82)Convert.ToInt32(row["RaceStartingLevel"]);
                raceRecord.RaceGridSize = Convert.ToInt32(row["RaceGridSize"]);
                raceRecord.GovTypeID = Convert.ToInt32(row["GovTypeID"]);
                raceRecord.UnreadMessages = Convert.ToInt32(row["UnreadMessages"]);
                raceRecord.Contacts = Convert.ToInt32(row["Contacts"]);
                raceRecord.Colour = Convert.ToInt32(row["Colour"]);
                raceRecord.Red = Convert.ToInt32(row["Red"]);
                raceRecord.Green = Convert.ToInt32(row["Green"]);
                raceRecord.Blue = Convert.ToInt32(row["Blue"]);
                raceRecord.ThemeID = Convert.ToInt32(row["ThemeID"]);
                raceRecord.DisplayGrade = Convert.ToInt32(row["DisplayGrade"]);
                raceRecord.ShowHighlight = Convert.ToInt32(row["ShowHighlight"]);
                raceRecord.MapRed = Convert.ToInt32(row["MapRed"]);
                raceRecord.MapGreen = Convert.ToInt32(row["MapGreen"]);
                raceRecord.MapBlue = Convert.ToInt32(row["MapBlue"]);
                raceRecord.FleetViewOption = Convert.ToInt32(row["FleetViewOption"]);
                raceRecord.SelectRace = Convert.ToInt32(row["SelectRace"]);
                raceRecord.FleetsVisible = Convert.ToInt32(row["FleetsVisible"]);
                raceRecord.LastMapSystemViewed = Convert.ToInt32(row["LastMapSystemViewed"]);
                raceRecord.chkAllowAny = Convert.ToInt32(row["chkAllowAny"]);
                raceRecord.chkAutoAssign = Convert.ToInt32(row["chkAutoAssign"]);
                raceRecord.chkTons = Convert.ToInt32(row["chkTons"]);
                raceRecord.StandardTour = Convert.ToInt32(row["StandardTour"]);
                raceRecord.CurrentXenophobia = Convert.ToInt32(row["CurrentXenophobia"]);
                raceRecord.Research = Convert.ToInt32(row["Research"]);
                raceRecord.PlanetarySensorStrength = Convert.ToInt32(row["PlanetarySensorStrength"]);
                raceRecord.TrainingLevel = Convert.ToInt32(row["TrainingLevel"]);
                raceRecord.GUStrength = Convert.ToInt32(row["GUStrength"]);
                raceRecord.StartTechPoints = Convert.ToInt32(row["StartTechPoints"]);
                raceRecord.StartBuildPoints = Convert.ToInt32(row["StartBuildPoints"]);
                raceRecord.MSPProduction = Convert.ToInt32(row["MSPProduction"]);
                raceRecord.MaintenanceCapacity = Convert.ToInt32(row["MaintenanceCapacity"]);
                raceRecord.MaxRefuellingRate = Convert.ToInt32(row["MaxRefuellingRate"]);
                raceRecord.MaxOrdnanceTransferRate = Convert.ToInt32(row["MaxOrdnanceTransferRate"]);
                raceRecord.CargoShuttleLoadModifier = Convert.ToInt32(row["CargoShuttleLoadModifier"]);
                raceRecord.GroundFormationConstructionRate = Convert.ToInt32(row["GroundFormationConstructionRate"]);
                raceRecord.ResearchTargetCost = Convert.ToInt32(row["ResearchTargetCost"]);
                raceRecord.MaximumOrbitalMiningDiameter = Convert.ToInt32(row["MaximumOrbitalMiningDiameter"]);
                raceRecord.ColonyDensity = Convert.ToInt32(row["ColonyDensity"]);
                raceRecord.LastProgressionOrder = Convert.ToInt32(row["LastProgressionOrder"]);
                raceRecord.MaxOrganizationLinkID = Convert.ToInt32(row["MaxOrganizationLinkID"]);
                raceRecord.SelectedClassIcon = Convert.ToInt32(row["SelectedClassIcon"]);
                raceRecord.SelectedAdminIcon = Convert.ToInt32(row["SelectedAdminIcon"]);
                raceRecord.AnnualWealth = Convert.ToDecimal(row["AnnualWealth"]);
                raceRecord.AcademyCrewmen = Convert.ToDecimal(row["AcademyCrewmen"]);
                raceRecord.WealthPoints = Convert.ToDecimal(row["WealthPoints"]);
                raceRecord.StartingWealth = Convert.ToDecimal(row["StartingWealth"]);
                raceRecord.LastAssignment = Convert.ToDecimal(row["LastAssignment"]);
                raceRecord.OrdnanceCapacity = Convert.ToDecimal(row["OrdnanceCapacity"]);
                raceRecord.FighterCapacity = Convert.ToDecimal(row["FighterCapacity"]);
                raceRecord.ShipBuilding = Convert.ToDecimal(row["ShipBuilding"]);
                raceRecord.FuelProduction = Convert.ToDecimal(row["FuelProduction"]);
                raceRecord.ConstructionProduction = Convert.ToDecimal(row["ConstructionProduction"]);
                raceRecord.OrdnanceProduction = Convert.ToDecimal(row["OrdnanceProduction"]);
                raceRecord.FighterProduction = Convert.ToDecimal(row["FighterProduction"]);
                raceRecord.MineProduction = Convert.ToDecimal(row["MineProduction"]);
                raceRecord.GeneticConversionRate = Convert.ToDecimal(row["GeneticConversionRate"]);
                raceRecord.TerraformingRate = Convert.ToDecimal(row["TerraformingRate"]);
                raceRecord.ColonizationSkill = Convert.ToDecimal(row["ColonizationSkill"]);
                raceRecord.WealthCreationRate = Convert.ToDecimal(row["WealthCreationRate"]);
                raceRecord.EconomicProdModifier = Convert.ToDecimal(row["EconomicProdModifier"]);
                raceRecord.ShipyardOperations = Convert.ToDecimal(row["ShipyardOperations"]);
                raceRecord.UnderwayReplenishmentRate = Convert.ToDecimal(row["UnderwayReplenishmentRate"]);
                raceRecord.CurrentResearchTotal = Convert.ToDecimal(row["CurrentResearchTotal"]);
                raceRecord.TonnageSent = Convert.ToDouble(row["TonnageSent"]);
                raceRecord.ShippingLineTax = Convert.ToDecimal(row["ShippingLineTax"]);
                raceRecord.ZoomSetting = Convert.ToDouble(row["ZoomSetting"]);
                raceRecord.MinMapFontSize = Convert.ToDouble(row["MinMapFontSize"]);
                raceRecord.CrewDesignEfficiency = Convert.ToDecimal(row["CrewDesignEfficiency"]);
                raceRecord.NPR = Convert.ToBoolean(row["NPR"]);
                raceRecord.NeutralRace = Convert.ToBoolean(row["NeutralRace"]);
                raceRecord.BioShips = Convert.ToBoolean(row["BioShips"]);
                raceRecord.RaceName = row["RaceName"].ToString();
                raceRecord.RaceTitle = row["RaceTitle"].ToString();
                raceRecord.FlagPic = row["FlagPic"].ToString();
                raceRecord.HullPic = row["HullPic"].ToString();
                raceRecord.SpaceStationPic = row["SpaceStationPic"].ToString();
                raceRecord.Password = row["Password"].ToString();
                raceRecord.RankScientist = row["RankScientist"].ToString();
                raceRecord.RankAdministrator = row["RankAdministrator"].ToString();
                raceRecord.Hostile = Convert.ToInt32(row["Hostile"]);
                raceRecord.Neutral = Convert.ToInt32(row["Neutral"]);
                raceRecord.Friendly = Convert.ToInt32(row["Friendly"]);
                raceRecord.Allied = Convert.ToInt32(row["Allied"]);
                raceRecord.Civilian = Convert.ToInt32(row["Civilian"]);
                raceRecord.HideCMCPop = Convert.ToBoolean(row["HideCMCPop"]);
                raceRecord.ShowPopStar = Convert.ToBoolean(row["ShowPopStar"]);
                raceRecord.ShowPopSystemBody = Convert.ToBoolean(row["ShowPopSystemBody"]);
                raceRecord.PopByFunction = Convert.ToBoolean(row["PopByFunction"]);
                raceRecord.chkPlanets = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPlanets"]));
                raceRecord.chkDwarf = AuroraUtils.smethod_26(Convert.ToInt32(row["chkDwarf"]));
                raceRecord.chkMoons = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMoons"]));
                raceRecord.chkAst = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAst"]));
                raceRecord.chkWP = AuroraUtils.smethod_26(Convert.ToInt32(row["chkWP"]));
                raceRecord.chkStarOrbits = AuroraUtils.smethod_26(Convert.ToInt32(row["chkStarOrbits"]));
                raceRecord.chkPlanetOrbits = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPlanetOrbits"]));
                raceRecord.chkDwarfOrbits = AuroraUtils.smethod_26(Convert.ToInt32(row["chkDwarfOrbits"]));
                raceRecord.chkMoonOrbits = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMoonOrbits"]));
                raceRecord.chkAsteroidOrbits = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAsteroidOrbits"]));
                raceRecord.chkSelectedOrbit = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSelectedOrbit"]));
                raceRecord.chkStarNames = AuroraUtils.smethod_26(Convert.ToInt32(row["chkStarNames"]));
                raceRecord.chkPlanetNames = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPlanetNames"]));
                raceRecord.chkDwarfNames = AuroraUtils.smethod_26(Convert.ToInt32(row["chkDwarfNames"]));
                raceRecord.chkMoonNames = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMoonNames"]));
                raceRecord.chkAstNames = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAstNames"]));
                raceRecord.chkFleets = AuroraUtils.smethod_26(Convert.ToInt32(row["chkFleets"]));
                raceRecord.chkMoveTail = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMoveTail"]));
                raceRecord.chkColonies = AuroraUtils.smethod_26(Convert.ToInt32(row["chkColonies"]));
                raceRecord.chkCentre = AuroraUtils.smethod_26(Convert.ToInt32(row["chkCentre"]));
                raceRecord.chkSL = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSL"]));
                raceRecord.chkWaypoint = AuroraUtils.smethod_26(Convert.ToInt32(row["chkWaypoint"]));
                raceRecord.chkOrder = AuroraUtils.smethod_26(Convert.ToInt32(row["chkOrder"]));
                raceRecord.chkNoOverlap = AuroraUtils.smethod_26(Convert.ToInt32(row["chkNoOverlap"]));
                raceRecord.chkPassive10 = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPassive10"]));
                raceRecord.chkPassive100 = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPassive100"]));
                raceRecord.chkPassive1000 = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPassive1000"]));
                raceRecord.chkPassive10000 = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPassive10000"]));
                raceRecord.chkActiveSensors = AuroraUtils.smethod_26(Convert.ToInt32(row["chkActiveSensors"]));
                raceRecord.chkUseHullNumbers = AuroraUtils.smethod_26(Convert.ToInt32(row["chkUseHullNumbers"]));
                raceRecord.chkTracking = AuroraUtils.smethod_26(Convert.ToInt32(row["chkTracking"]));
                raceRecord.chkActiveOnly = AuroraUtils.smethod_26(Convert.ToInt32(row["chkActiveOnly"]));
                raceRecord.chkShowDist = AuroraUtils.smethod_26(Convert.ToInt32(row["chkShowDist"]));
                raceRecord.chkSBSurvey = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSBSurvey"]));
                raceRecord.chkMinerals = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMinerals"]));
                raceRecord.chkCometPath = AuroraUtils.smethod_26(Convert.ToInt32(row["chkCometPath"]));
                raceRecord.chkAstColOnly = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAstColOnly"]));
                raceRecord.chkAstMinOnly = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAstMinOnly"]));
                raceRecord.chkTAD = AuroraUtils.smethod_26(Convert.ToInt32(row["chkTAD"]));
                raceRecord.chkFiringRanges = AuroraUtils.smethod_26(Convert.ToInt32(row["chkFiringRanges"]));
                raceRecord.chkAllRace = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAllRace"]));
                raceRecord.chkDisplayAllForms = AuroraUtils.smethod_26(Convert.ToInt32(row["chkDisplayAllForms"]));
                raceRecord.chkHullCategory = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHullCategory"]));
                raceRecord.chkSalvoOrigin = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSalvoOrigin"]));
                raceRecord.chkSalvoTarget = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSalvoTarget"]));
                raceRecord.chkEscorts = AuroraUtils.smethod_26(Convert.ToInt32(row["chkEscorts"]));
                raceRecord.chkFireControlRange = AuroraUtils.smethod_26(Convert.ToInt32(row["chkFireControlRange"]));
                raceRecord.PassiveSensor = AuroraUtils.smethod_26(Convert.ToInt32(row["PassiveSensor"]));
                raceRecord.ActiveSensor = AuroraUtils.smethod_26(Convert.ToInt32(row["ActiveSensor"]));
                raceRecord.DetRange = AuroraUtils.smethod_26(Convert.ToInt32(row["DetRange"]));
                raceRecord.chkHideIDs = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHideIDs"]));
                raceRecord.chkHideWreckIDs = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHideWreckIDs"]));
                raceRecord.chkHideSL = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHideSL"]));
                raceRecord.chkEvents = AuroraUtils.smethod_26(Convert.ToInt32(row["chkEvents"]));
                raceRecord.chkEventsAllRaces = AuroraUtils.smethod_26(Convert.ToInt32(row["chkEventsAllRaces"]));
                raceRecord.chkPackets = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPackets"]));
                raceRecord.chkMPC = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMPC"]));
                raceRecord.chkLifepods = AuroraUtils.smethod_26(Convert.ToInt32(row["chkLifepods"]));
                raceRecord.chkWrecks = AuroraUtils.smethod_26(Convert.ToInt32(row["chkWrecks"]));
                raceRecord.chkHostileSensors = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHostileSensors"]));
                raceRecord.chkGeoPoints = AuroraUtils.smethod_26(Convert.ToInt32(row["chkGeoPoints"]));
                raceRecord.chkBearing = AuroraUtils.smethod_26(Convert.ToInt32(row["chkBearing"]));
                raceRecord.chkCoordinates = AuroraUtils.smethod_26(Convert.ToInt32(row["chkCoordinates"]));
                raceRecord.chkLostContacts = AuroraUtils.smethod_26(Convert.ToInt32(row["chkLostContacts"]));
                raceRecord.chkLostContactsOneYear =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkLostContactsOneYear"]));
                raceRecord.chkLostContactsOneDay =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkLostContactsOneDay"]));
                raceRecord.chkSystemOnly = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSystemOnly"]));
                raceRecord.chkShowCivilianOOB = AuroraUtils.smethod_26(Convert.ToInt32(row["chkShowCivilianOOB"]));
                raceRecord.chkHostile = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHostile"]));
                raceRecord.chkFriendly = AuroraUtils.smethod_26(Convert.ToInt32(row["chkFriendly"]));
                raceRecord.chkAllied = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAllied"]));
                raceRecord.chkNeutral = AuroraUtils.smethod_26(Convert.ToInt32(row["chkNeutral"]));
                raceRecord.chkCivilian = AuroraUtils.smethod_26(Convert.ToInt32(row["chkCivilian"]));
                raceRecord.chkContactsCurrentSystem =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkContactsCurrentSystem"]));
                raceRecord.chkUnexJP = AuroraUtils.smethod_26(Convert.ToInt32(row["chkUnexJP"]));
                raceRecord.chkJPSurveyStatus = AuroraUtils.smethod_26(Convert.ToInt32(row["chkJPSurveyStatus"]));
                raceRecord.chkSurveyLocationPoints =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkSurveyLocationPoints"]));
                raceRecord.chkSurveyedSystemBodies =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkSurveyedSystemBodies"]));
                raceRecord.chkHabRangeWorlds = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHabRangeWorlds"]));
                raceRecord.chkHabRangeWorldsLowG =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkHabRangeWorldsLowG"]));
                raceRecord.chkLowCCNormalG = AuroraUtils.smethod_26(Convert.ToInt32(row["chkLowCCNormalG"]));
                raceRecord.chkMediumCCNormalG = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMediumCCNormalG"]));
                raceRecord.chkLowCCLowG = AuroraUtils.smethod_26(Convert.ToInt32(row["chkLowCCLowG"]));
                raceRecord.chkMediumCCLowG = AuroraUtils.smethod_26(Convert.ToInt32(row["chkMediumCCLowG"]));
                raceRecord.chkUseMaxCCDisplay = AuroraUtils.smethod_26(Convert.ToInt32(row["chkUseMaxCCDisplay"]));
                raceRecord.UseRoman = AuroraUtils.smethod_26(Convert.ToInt32(row["UseRoman"]));
                raceRecord.chkNumCometsPlanetlessSystem =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkNumCometsPlanetlessSystem"]));
                raceRecord.chkDistanceFromSelected =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkDistanceFromSelected"]));
                raceRecord.chkDistanceFromSelectedMR =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkDistanceFromSelectedMR"]));
                raceRecord.chkDistanceRealSpace = AuroraUtils.smethod_26(Convert.ToInt32(row["chkDistanceRealSpace"]));
                raceRecord.chkWarshipLocation = AuroraUtils.smethod_26(Convert.ToInt32(row["chkWarshipLocation"]));
                raceRecord.chkClassIcon = AuroraUtils.smethod_26(Convert.ToInt32(row["chkClassIcon"]));
                raceRecord.chkAdminIcon = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAdminIcon"]));
                raceRecord.chkAllFleetLocations = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAllFleetLocations"]));
                raceRecord.chkKnownAlienForces = AuroraUtils.smethod_26(Convert.ToInt32(row["chkKnownAlienForces"]));
                raceRecord.chkAlienControlledSystems =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkAlienControlledSystems"]));
                raceRecord.chkPopulatedSystem = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPopulatedSystem"]));
                raceRecord.chkBlocked = AuroraUtils.smethod_26(Convert.ToInt32(row["chkBlocked"]));
                raceRecord.chkMilitaryRestricted =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkMilitaryRestricted"]));
                raceRecord.chkMilitaryRestrictedJP =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkMilitaryRestrictedJP"]));
                raceRecord.chkDisplayMineralSearch =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkDisplayMineralSearch"]));
                raceRecord.chkShipyardComplexes = AuroraUtils.smethod_26(Convert.ToInt32(row["chkShipyardComplexes"]));
                raceRecord.chkNavalHeadquarters = AuroraUtils.smethod_26(Convert.ToInt32(row["chkNavalHeadquarters"]));
                raceRecord.chkSectors = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSectors"]));
                raceRecord.chkPossibleDormantJP = AuroraUtils.smethod_26(Convert.ToInt32(row["chkPossibleDormantJP"]));
                raceRecord.chkSecurityStatus = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSecurityStatus"]));
                raceRecord.chkDiscoveryDate = AuroraUtils.smethod_26(Convert.ToInt32(row["chkDiscoveryDate"]));
                raceRecord.chkML = AuroraUtils.smethod_26(Convert.ToInt32(row["chkML"]));
                raceRecord.chkAetherRift = AuroraUtils.smethod_26(Convert.ToInt32(row["chkAetherRift"]));
                raceRecord.chkNumWrecks = AuroraUtils.smethod_26(Convert.ToInt32(row["chkNumWrecks"]));
                raceRecord.chkGroundSurveyLocations =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkGroundSurveyLocations"]));
                raceRecord.chkHideOrbitFleets = AuroraUtils.smethod_26(Convert.ToInt32(row["chkHideOrbitFleets"]));
                raceRecord.chkSupernovaImpactTime =
                    AuroraUtils.smethod_26(Convert.ToInt32(row["chkSupernovaImpactTime"]));
                raceRecord.chkSystemIconOnly = AuroraUtils.smethod_26(Convert.ToInt32(row["chkSystemIconOnly"]));
                try
                {
                    raceRecord.FlagPicLoadedImg =
                        Image.FromFile($"{Application.StartupPath}\\Flags\\{raceRecord.FlagPic}");
                }
                catch
                {
                }

                try
                {
                    raceRecord.ShipIconLoadedImg =
                        Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{raceRecord.HullPic}");
                }
                catch
                {
                }

                try
                {
                    raceRecord.SpaceStationPicLoadedImg =
                        Image.FromFile($"{Application.StartupPath}\\StationIcons\\{raceRecord.SpaceStationPic}");
                }
                catch
                {
                }

                Color color1 = Color.FromArgb(byte.MaxValue, Color.FromArgb(raceRecord.Allied));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Allied, color1);
                Color color2 = Color.FromArgb(byte.MaxValue, Color.FromArgb(raceRecord.Friendly));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Friendly, color2);
                Color color3 = Color.FromArgb(byte.MaxValue, Color.FromArgb(raceRecord.Neutral));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Neutral, color3);
                Color color4 = Color.FromArgb(byte.MaxValue, Color.FromArgb(raceRecord.Hostile));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Hostile, color4);
                Color color5 = Color.FromArgb(byte.MaxValue, Color.FromArgb(raceRecord.Civilian));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Civilian, color5);
                this.RaceTitleList.Add(raceRecord.RaceTitle);
                this.FCTRaceRecordDic.Add(raceRecord.RaceID, raceRecord);
                if (raceRecord.NPR)
                    raceRecord.UnknownNprClass = new UnknownNPRClass2(this, raceRecord);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1126);
        }
    }
    
    public void LoadFCTLagrangePointsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_LagrangePoint where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass212 gclass212 = new GClass212(this);
                int int32_1 = Convert.ToInt32(row["PlanetID"]);
                if (this.SystemBodyRecordDic.ContainsKey(int32_1))
                {
                    gclass212.gclass1_0 = this.SystemBodyRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["StarID"]);
                    if (this.StarDictionary.ContainsKey(int32_2))
                    {
                        gclass212.gclass197_0 = this.StarDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["SystemID"]);
                        if (this.SystemDataDictionary.ContainsKey(int32_3))
                        {
                            gclass212.gclass200_0 = this.SystemDataDictionary[int32_3];
                            gclass212.int_0 = Convert.ToInt32(row["LaGrangePointID"]);
                            gclass212.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass212.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass212.double_2 = Convert.ToDouble(row["Distance"]);
                            gclass212.double_3 = Convert.ToDouble(row["Bearing"]);
                            this.dictionary_14.Add(gclass212.int_0, gclass212);
                        }
                    }
                }
            }

            foreach (SystemData200 gclass200 in this.SystemDataDictionary.Values)
                gclass200.method_28();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1148);
        }
    }
    
    public void LoadFCTPopInstallationDemandFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_PopInstallationDemand where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass148 gclass148 = new GClass148();
                AuroraInstallationType int32_1 = (AuroraInstallationType)Convert.ToInt32(row["InstallationID"]);
                if (this.PlanetaryInstallationDictionary.ContainsKey(int32_1))
                {
                    gclass148.gclass157_0 = this.PlanetaryInstallationDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                    {
                        gclass148.gclass146_0 = this.PopulationDataDictionary[int32_2];
                        gclass148.decimal_0 = Convert.ToDecimal(row["Amount"]);
                        gclass148.bool_0 = Convert.ToBoolean(row["Export"]);
                        gclass148.bool_1 = Convert.ToBoolean(row["NonEssential"]);
                        gclass148.gclass146_0.dictionary_5.Add(int32_1, gclass148);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1149);
        }
    }

    public void LoadFCTPopTradeBalanceFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_PopTradeBalance where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass190 gclass190 = new GClass190();
                int int32_1 = Convert.ToInt32(row["TradeGoodID"]);
                if (this.TradeGoodsDictionary.ContainsKey(int32_1))
                {
                    gclass190.gclass189_0 = this.TradeGoodsDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                    {
                        gclass190.gclass146_0 = this.PopulationDataDictionary[int32_2];
                        gclass190.decimal_0 = Convert.ToDecimal(row["ProductionRate"]);
                        gclass190.decimal_1 = Convert.ToDecimal(row["TradeBalance"]);
                        gclass190.decimal_2 = Convert.ToDecimal(row["LastTradeBalance"]);
                        this.PopulationDataDictionary[int32_2].dictionary_4.Add(gclass190.gclass189_0.int_0, gclass190);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1150);
        }
    }
    
    public void LoadFCTHullNumberFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_HullNumber where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["HullTypeID"]);
                if (this.ShipHullDictionary.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["HullCount"]);
                        this.FCTRaceRecordDic[int32_2].ShipHullCountDictionary.Add(this.ShipHullDictionary[int32_1], int32_3);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1153);
        }
    }

    public void LoadFCTGroundUnitClassFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_GroundUnitClass WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GroundUnitClass101 gclass101 = new GroundUnitClass101(this);
                int int32_1 = Convert.ToInt32(row["TechSystemID"]);
                if (this.TechDataDictionary.ContainsKey(int32_1))
                {
                    gclass101.TechData = this.TechDataDictionary[int32_1];
                    GroundUnitBaseType int32_2 = (GroundUnitBaseType)Convert.ToInt32(row["BaseType"]);
                    if (this.GroundUnitBaseTypeDictionary.ContainsKey(int32_2))
                    {
                        gclass101.GroundUnitBaseTypeData = this.GroundUnitBaseTypeDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["ArmourType"]);
                        if (this.ArmourTypeDictionary.ContainsKey(int32_3))
                        {
                            gclass101.ArmourType = this.ArmourTypeDictionary[int32_3];
                            GroundUnitComponent int32_4 = (GroundUnitComponent)Convert.ToInt32(row["ComponentA"]);
                            if (this.GroundUnitComponentDataDictionary.ContainsKey(int32_4))
                                gclass101.GroundUnitComponentList.Add(this.GroundUnitComponentDataDictionary[int32_4]);
                            GroundUnitComponent int32_5 = (GroundUnitComponent)Convert.ToInt32(row["ComponentB"]);
                            if (this.GroundUnitComponentDataDictionary.ContainsKey(int32_5))
                                gclass101.GroundUnitComponentList.Add(this.GroundUnitComponentDataDictionary[int32_5]);
                            GroundUnitComponent int32_6 = (GroundUnitComponent)Convert.ToInt32(row["ComponentC"]);
                            if (this.GroundUnitComponentDataDictionary.ContainsKey(int32_6))
                                gclass101.GroundUnitComponentList.Add(this.GroundUnitComponentDataDictionary[int32_6]);
                            GroundUnitComponent int32_7 = (GroundUnitComponent)Convert.ToInt32(row["ComponentD"]);
                            if (this.GroundUnitComponentDataDictionary.ContainsKey(int32_7))
                                gclass101.GroundUnitComponentList.Add(this.GroundUnitComponentDataDictionary[int32_7]);
                            int int32_8 = Convert.ToInt32(row["STOWeapon"]);
                            if (this.ComponentDataDictionary.ContainsKey(int32_8))
                                gclass101.gclass230_0 = this.ComponentDataDictionary[int32_8];
                            gclass101.genum115_0 = (GroundUnitClassType)Convert.ToInt32(row["GUClassType"]);
                            gclass101.ClassID = Convert.ToInt32(row["GroundUnitClassID"]);
                            gclass101.int_1 = Convert.ToInt32(row["MaxWeaponRange"]);
                            gclass101.int_2 = Convert.ToInt32(row["MaxFireControlRange"]);
                            gclass101.int_3 = Convert.ToInt32(row["ActiveSensorRange"]);
                            gclass101.int_4 = Convert.ToInt32(row["TrackingSpeed"]);
                            gclass101.int_7 = Convert.ToInt32(row["ECCM"]);
                            gclass101.int_5 = Convert.ToInt32(row["RechargeTime"]);
                            gclass101.int_6 = Convert.ToInt32(row["HQCapacity"]);
                            gclass101.decimal_5 = Convert.ToDecimal(row["SensorStrength"]);
                            gclass101.decimal_0 = Convert.ToDecimal(row["ArmourStrengthModifier"]);
                            gclass101.decimal_1 = Convert.ToDecimal(row["WeaponStrengthModifier"]);
                            gclass101.decimal_2 = Convert.ToDecimal(row["Size"]);
                            gclass101.decimal_3 = Convert.ToDecimal(row["Cost"]);
                            gclass101.decimal_4 = Convert.ToDecimal(row["UnitSupplyCost"]);
                            gclass101.decimal_6 = Convert.ToDecimal(row["ConstructionRating"]);
                            gclass101.bool_0 = Convert.ToBoolean(row["NonCombatClass"]);
                            gclass101.bool_1 = Convert.ToBoolean(row["PointDefenceWeapon"]);
                            gclass101.ClassName = row["ClassName"].ToString();
                            gclass101.gclass123_0 = new AllMineralsValue(this);
                            gclass101.gclass123_0.Duranium = Convert.ToDecimal(row["Duranium"]);
                            gclass101.gclass123_0.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                            gclass101.gclass123_0.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                            gclass101.gclass123_0.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                            gclass101.gclass123_0.Boronide = Convert.ToDecimal(row["Boronide"]);
                            gclass101.gclass123_0.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                            gclass101.gclass123_0.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                            gclass101.gclass123_0.Sorium = Convert.ToDecimal(row["Sorium"]);
                            gclass101.gclass123_0.Uridium = Convert.ToDecimal(row["Uridium"]);
                            gclass101.gclass123_0.Corundium = Convert.ToDecimal(row["Corundium"]);
                            gclass101.gclass123_0.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                            this.GroundUnitClassDictionary.Add(gclass101.ClassID, gclass101);
                        }
                    }
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"select * from FCT_GroundUnitCapability WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GroundUnitCapability int32_9 = (GroundUnitCapability)Convert.ToInt32(row["CapabilityID"]);
                if (this.GroundUnitCapabilityDictionary.ContainsKey(int32_9))
                {
                    int int32_10 = Convert.ToInt32(row["GroundUnitClassID"]);
                    if (this.GroundUnitClassDictionary.ContainsKey(int32_10))
                        this.GroundUnitClassDictionary[int32_10].dictionary_0.Add(int32_9, this.GroundUnitCapabilityDictionary[int32_9]);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1157);
        }
    }

    public void method_214()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_GroundUnitFormation where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GroundUnitFormationData gclass103 = new GroundUnitFormationData(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass103.RaceData = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["RequiredRank"]);
                    if (gclass103.RaceData.RacialRankDictionary.ContainsKey(int32_2))
                        gclass103.RequiredRankData = gclass103.RaceData.RacialRankDictionary[int32_2];
                    gclass103.FormationID = Convert.ToInt32(row["FormationID"]);
                    gclass103.ParentFormationID = Convert.ToInt32(row["ParentFormationID"]);
                    gclass103.AssignedFormationID = Convert.ToInt32(row["AssignedFormationID"]);
                    gclass103.FieldPosition =
                        (AuroraGroundFormationFieldPosition)Convert.ToInt32(row["FieldPosition"]);
                    gclass103.BoardingStatus = (GUBoardingStatus)Convert.ToInt32(row["BoardingStatus"]);
                    gclass103.ReplacementPriority = Convert.ToInt32(row["ReplacementPriority"]);
                    gclass103.OrgLinkID = Convert.ToInt32(row["OrgLinkID"]);
                    gclass103.bDoNotRecover = Convert.ToInt32(row["DoNotRecover"]);
                    gclass103.bActiveSensorsOn = Convert.ToBoolean(row["ActiveSensorsOn"]);
                    gclass103.bCivilian = Convert.ToBoolean(row["Civilian"]);
                    gclass103.bUseForReplacements = Convert.ToBoolean(row["UseForReplacements"]);
                    gclass103.Name = row["Name"].ToString();
                    gclass103.Abbreviation = row["Abbreviation"].ToString();
                    int int32_3 = Convert.ToInt32(row["OriginalTemplateID"]);
                    if (this.FormationTemplateRecordDic.ContainsKey(int32_3))
                        gclass103.OriginalTemplateData = this.FormationTemplateRecordDic[int32_3];
                    int int32_4 = Convert.ToInt32(row["ReplacementTemplateID"]);
                    if (this.FormationTemplateRecordDic.ContainsKey(int32_4))
                        gclass103.ReplacementTemplateData = this.FormationTemplateRecordDic[int32_4];
                    int int32_5 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_5))
                        gclass103.PopulationData = this.PopulationDataDictionary[int32_5];
                    int int32_6 = Convert.ToInt32(row["ShipID"]);
                    if (this.FCTShipDataDictionary.ContainsKey(int32_6))
                        gclass103.ShipData = this.FCTShipDataDictionary[int32_6];
                    if (int32_6 != 0 || int32_5 != 0)
                        this.FormationDictionary.Add(gclass103.FormationID, gclass103);
                }
            }

            foreach (GroundUnitFormationData gclass103 in this.FormationDictionary.Values)
            {
                if (gclass103.ParentFormationID > 0 && this.FormationDictionary.ContainsKey(gclass103.ParentFormationID))
                    gclass103.ParentFormationData = this.FormationDictionary[gclass103.ParentFormationID];
                if (gclass103.AssignedFormationID > 0 && this.FormationDictionary.ContainsKey(gclass103.AssignedFormationID))
                    gclass103.AssignedFormationData = this.FormationDictionary[gclass103.AssignedFormationID];
            }

            foreach (FCTShipData40 gclass40 in this.FCTShipDataDictionary.Values
                         .Where(gclass40_0 => gclass40_0.int_31 > 0).ToList())
            {
                if (this.FormationDictionary.ContainsKey(gclass40.int_31))
                    gclass40.gclass103_0 = this.FormationDictionary[gclass40.int_31];
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1158);
        }
    }

    public void method_215()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_GroundUnitFormationTemplate where GameID = {this.GameID.ToString()}").Rows)
            {
                GroundUnitFormationTemplateData gclass102 = new GroundUnitFormationTemplateData(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass102.RaceData = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["RequiredRank"]);
                    if (gclass102.RaceData.RacialRankDictionary.ContainsKey(int32_2))
                        gclass102.RequiredRankData = gclass102.RaceData.RacialRankDictionary[int32_2];
                    gclass102.AutomatedTemplateType = (AutomatedGroundTemplateDesignType)Convert.ToInt32(row["AutomatedTemplateID"]);
                    gclass102.TemplateID = Convert.ToInt32(row["TemplateID"]);
                    gclass102.FormationTrained = Convert.ToInt32(row["FormationsTrained"]);
                    gclass102.Obsolete = Convert.ToInt32(row["Obsolete"]);
                    gclass102.Name = row["Name"].ToString();
                    gclass102.Abbreviation = row["Abbreviation"].ToString();
                    this.FormationTemplateRecordDic.Add(gclass102.TemplateID, gclass102);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1159);
        }
    }

    public void method_216()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_GroundUnitFormationElement where GameID = {this.GameID.ToString()}").Rows)
            {
                GroundUnitFormationElement GUElement = new GroundUnitFormationElement(this);
                int int32_1 = Convert.ToInt32(row["FormationID"]);
                if (this.FormationDictionary.ContainsKey(int32_1))
                {
                    GUElement.Formation = this.FormationDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["ClassID"]);
                    if (this.GroundUnitClassDictionary.ContainsKey(int32_2))
                    {
                        GUElement.GroundUnitClass = this.GroundUnitClassDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["SpeciesID"]);
                        if (this.SpeciesDictionary.ContainsKey(int32_3))
                        {
                            GUElement.RaceData = this.SpeciesDictionary[int32_3];
                            GUElement.ElementID = Convert.ToInt32(row["ElementID"]);
                            GUElement.CurrentSupply = Convert.ToInt32(row["CurrentSupply"]);
                            GUElement.TargetSelectionType =
                                (AuroraTargetSelection)Convert.ToInt32(row["TargetSelection"]);
                            GUElement.FiringDistribution = Convert.ToInt32(row["FiringDistribution"]);
                            GUElement.Morale = Convert.ToDecimal(row["Morale"]);
                            GUElement.FortificationLevel = Convert.ToDecimal(row["FortificationLevel"]);
                            GUElement.UnitCount = Convert.ToInt32(row["Units"]);
                            GUElement.Formation.ElementList.Add(GUElement);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1160);
        }
    }

    public void LoadFCTElementRechargeFromDB() //휘발성 정보인 사격 딜레이를 등록할 뿐이라 전용 데이터 오브젝트가 없음
    {
        try
        {
            DataTable dataTable =
                new SQLiteDatabaseC1181().ExecuteQuery($"select * from FCT_ElementRecharge where GameID = {this.GameID.ToString()}");
            if (dataTable.Rows.Count == 0)
                return;
            Dictionary<int, GroundUnitFormationElement> dictionary = this.FormationDictionary.Values
                .SelectMany(gclass103_0 => gclass103_0.ElementList)
                .ToDictionary(gclass39_0 => gclass39_0.ElementID, gclass39_0 => gclass39_0);
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                int rechargeRemaining = Convert.ToInt32(row["RechargeRemaining"]);
                int elementID = Convert.ToInt32(row["ElementID"]);
                if (dictionary.ContainsKey(elementID))
                    dictionary[elementID].list_0.Add(rechargeRemaining);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1161);
        }
    }

    public void LoadFCTDetectedSTOFromDB()
    {
        try
        {
            DataTable dataTable =
                new SQLiteDatabaseC1181().ExecuteQuery($"select * from FCT_STODetected where GameID = {this.GameID.ToString()}");
            if (dataTable.Rows.Count == 0)
                return;
            Dictionary<int, GroundUnitFormationElement> dictionary = this.FormationDictionary.Values
                .SelectMany(formationData => formationData.ElementList)
                .ToDictionary(formationElement => formationElement.ElementID, formationElement => formationElement);
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                int detectingRaceID = Convert.ToInt32(row["DetectingRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(detectingRaceID))
                {
                    int targeElementId = Convert.ToInt32(row["ElementID"]);
                    if (dictionary.ContainsKey(targeElementId))
                        dictionary[targeElementId].DetectingRaceList.Add(this.FCTRaceRecordDic[detectingRaceID]);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1162);
        }
    }

    public void method_219()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_GroundUnitFormationElementTemplates where GameID = {GameID.ToString()}").Rows)
            {
                GroundUnitFormationElement formationElement = new GroundUnitFormationElement(this);
                int groundFormationTemplateID = Convert.ToInt32(row["FormationTemplateID"]);
                if (this.FormationTemplateRecordDic.ContainsKey(groundFormationTemplateID))
                {
                    formationElement.FormationTemplate = this.FormationTemplateRecordDic[groundFormationTemplateID];
                    int int32_2 = Convert.ToInt32(row["ClassID"]);
                    if (this.GroundUnitClassDictionary.ContainsKey(int32_2))
                    {
                        formationElement.GroundUnitClass = this.GroundUnitClassDictionary[int32_2];
                        formationElement.UnitCount = Convert.ToInt32(row["Units"]);
                        formationElement.FormationTemplate.FormationElementList.Add(formationElement);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1163);
        }
    }

    public void LoadFCTGroundUnitSeriesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_GroundUnitSeries where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GroundUnitSeriesData unitSeries = new GroundUnitSeriesData();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32))
                {
                    unitSeries.GroundUnitSeriesID = Convert.ToInt32(row["GroundUnitSeriesID"]);
                    unitSeries.Description = row["Description"].ToString();
                    this.FCTRaceRecordDic[int32].GroundUnitSeriesDictionary.Add(unitSeries.GroundUnitSeriesID, unitSeries);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3339);
        }
    }

    public void LoadFCTGroundUnitSeriesClassesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_GroundUnitSeriesClass where GameID = {this.GameID.ToString()}").Rows)
            {
                GroundUnitSeriesClassData groundUnitSeriesClassData = new GroundUnitSeriesClassData();
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceID))
                {
                    int unitClassId = Convert.ToInt32(row["GroundUnitClassID"]);
                    if (this.GroundUnitClassDictionary.ContainsKey(unitClassId))
                    {
                        groundUnitSeriesClassData.UnitClass = this.GroundUnitClassDictionary[unitClassId];
                        int seriesID = Convert.ToInt32(row["GroundUnitSeriesID"]);
                        if (this.FCTRaceRecordDic[raceID].GroundUnitSeriesDictionary.ContainsKey(seriesID))
                        {
                            groundUnitSeriesClassData.UnitSeriesData = this.FCTRaceRecordDic[raceID].GroundUnitSeriesDictionary[seriesID];
                            groundUnitSeriesClassData.Priority = Convert.ToInt32(row["Priority"]);
                            this.FCTRaceRecordDic[raceID].GroundUnitSeriesClassList.Add(groundUnitSeriesClassData);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3339);
        }
    }

    

    public void LoadFCTOrderTemplatesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_OrderTemplate where GameID = {this.GameID.ToString()}").Rows)
            {
                OrderTemplateData orderTemplate = new OrderTemplateData(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceID))
                {
                    orderTemplate.RaceData = this.FCTRaceRecordDic[raceID];
                    int int32_2 = Convert.ToInt32(row["StartSystemID"]);
                    if (orderTemplate.RaceData.RacialSystemDictionary.ContainsKey(int32_2))
                    {
                        orderTemplate.RaceSystem = orderTemplate.RaceData.RacialSystemDictionary[int32_2];
                        orderTemplate.OrderTemplateID = Convert.ToInt32(row["OrderTemplateID"]);
                        orderTemplate.TemplateName = row["TemplateName"].ToString();
                        this.MoveOrderTemplateDictionary.Add(orderTemplate.OrderTemplateID, orderTemplate);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1166);
        }
    }

    public void LoadFCTShippingWealthDataFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_ShippingWealthData where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                ShippingWealthData shippingLineWealthData = new ShippingWealthData();
                int shippingLineID = Convert.ToInt32(row["ShippingLineID"]);
                if (this.ShippingLineDictionary.ContainsKey(shippingLineID))
                {
                    shippingLineWealthData.ShippingLine = this.ShippingLineDictionary[shippingLineID];
                    int int32_2 = Convert.ToInt32(row["OriginPop"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                    {
                        shippingLineWealthData.OriginPop = this.PopulationDataDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["DestinationPop"]);
                        if (this.PopulationDataDictionary.ContainsKey(int32_3))
                        {
                            shippingLineWealthData.DestinationPop = this.PopulationDataDictionary[int32_3];
                            int int32_4 = Convert.ToInt32(row["TradeGood"]);
                            if (this.TradeGoodsDictionary.ContainsKey(int32_4))
                                shippingLineWealthData.TradeGood = this.TradeGoodsDictionary[int32_4];
                            int int32_5 = Convert.ToInt32(row["ShipID"]);
                            if (this.FCTShipDataDictionary.ContainsKey(int32_5))
                                shippingLineWealthData.Ship = this.FCTShipDataDictionary[int32_5];
                            shippingLineWealthData.TradeTime = Convert.ToDecimal(row["TradeTime"]);
                            shippingLineWealthData.Amount = Convert.ToDecimal(row["Amount"]);
                            shippingLineWealthData.Contract = Convert.ToBoolean(row["Contract"]);
                            shippingLineWealthData.Colonist = Convert.ToBoolean(row["Colonist"]);
                            shippingLineWealthData.Fuel = Convert.ToBoolean(row["Fuel"]);
                            shippingLineWealthData.ShippingLine.WealthDataList.Add(shippingLineWealthData);
                        }
                    }
                }
            }

            //TODO: NO-OP Code here, I disabled by comment. Intention unknown
            //this.ShippingLineDictionary.Values.SelectMany<ShippingLineData, ShippingWealthData>(gclass187_0 => gclass187_0.WealthDataList).ToList<ShippingWealthData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1167);
        }
    }

    public void LoadFCTMoveOrdersFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"SELECT * FROM FCT_MoveOrders WHERE GameID = {this.GameID.ToString()} ORDER BY MoveOrder")
                         .Rows)
            {
                MoveOrder MoveOrder = new MoveOrder();
                int raceId = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceId))
                {
                    MoveOrder.Race = this.FCTRaceRecordDic[raceId];
                    int int32_2 = Convert.ToInt32(row["FleetID"]);
                    if (this.FleetDictionary.ContainsKey(int32_2))
                    {
                        MoveOrder.Fleet = this.FleetDictionary[int32_2];
                        int startSystemID = Convert.ToInt32(row["StartSystemID"]);
                        if (MoveOrder.Race.RacialSystemDictionary.ContainsKey(startSystemID))
                        {
                            MoveOrder.StartSystem = MoveOrder.Race.RacialSystemDictionary[startSystemID];
                            //Convert.ToInt32(row["MoveActionID"]); //Garbage, I disabled it. probably just not cleaned up by original author
                            MoveOrder.MoveActionType = this.MoveActionDictionary[(MoveActionType)Convert.ToInt32(row["MoveActionID"])];
                            int int32_4 = Convert.ToInt32(row["NewSystemID"]);
                            if (int32_4 > 0)
                            {
                                if (MoveOrder.Race.RacialSystemDictionary.ContainsKey(int32_4))
                                    MoveOrder.NewSystem = MoveOrder.Race.RacialSystemDictionary[int32_4];
                                else
                                    continue;
                            }

                            int int32_5 = Convert.ToInt32(row["NewWarpPointID"]);
                            if (int32_5 > 0)
                            {
                                if (this.JumpPointDictionary.ContainsKey(int32_5))
                                    MoveOrder.NewJumpPoint = this.JumpPointDictionary[int32_5];
                                else
                                    continue;
                            }

                            int int32_6 = Convert.ToInt32(row["PopulationID"]);
                            if (int32_6 > 0)
                            {
                                if (this.PopulationDataDictionary.ContainsKey(int32_6))
                                    MoveOrder.Population = this.PopulationDataDictionary[int32_6];
                                else
                                    continue;
                            }

                            MoveOrder.MoveOrderID = Convert.ToInt32(row["MoveOrderID"]);
                            MoveOrder.OrderValue = Convert.ToInt32(row["MoveOrder"]);
                            MoveOrder.DestinationID = Convert.ToInt32(row["DestinationID"]);
                            MoveOrder.Delay = Convert.ToInt32(row["OrderDelay"]);
                            MoveOrder.DelayRemaining = Convert.ToInt32(row["OrderDelayRemaining"]);
                            MoveOrder.MinDistance = Convert.ToDouble(row["MinDistance"]);
                            MoveOrder.MinQuantity = Convert.ToInt32(row["MinQuantity"]);
                            MoveOrder.OrbDistance = Convert.ToInt32(row["OrbDistance"]);
                            MoveOrder.TimeRequired = Convert.ToInt32(row["TimeRequired"]);
                            MoveOrder.DestinationItemID = Convert.ToInt32(row["DestinationItemID"]);
                            MoveOrder.MaxItems = Convert.ToDecimal(row["MaxItems"]);
                            MoveOrder.SurveyPointsRequired = Convert.ToDecimal(row["SurveyPointsRequired"]);
                            MoveOrder.DestinationType = (DestinationType)Convert.ToInt32(row["DestinationType"]);
                            MoveOrder.DestinationItemType = (DestinationItemType)Convert.ToInt32(row["DestinationItemType"]);
                            MoveOrder.bArrived = Convert.ToBoolean(row["Arrived"]);
                            MoveOrder.bLoadSubUnits = Convert.ToBoolean(row["LoadSubUnits"]);
                            MoveOrder.Description = row["Description"].ToString();
                            MoveOrder.MessageText = row["MessageText"].ToString();
                            MoveOrder.Fleet.MoveOrderDictionary.Add(MoveOrder.MoveOrderID, MoveOrder);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowDbExceptionPopupForDb(ex);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1168);
        }
    }

    public void LoadFCTMoveOrderTemplatesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MoveOrderTemplate WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                TMoveOrder moveOrder = new TMoveOrder(this);
                int orderTemplateID = Convert.ToInt32(row["OrderTemplateID"]);
                if (this.MoveOrderTemplateDictionary.ContainsKey(orderTemplateID))
                {
                    moveOrder.OrderTemplate = this.MoveOrderTemplateDictionary[orderTemplateID];
                    int startSystemID = Convert.ToInt32(row["StartSystemID"]);
                    if (moveOrder.OrderTemplate.RaceData.RacialSystemDictionary.ContainsKey(startSystemID))
                    {
                        moveOrder.StartSystem = moveOrder.OrderTemplate.RaceData.RacialSystemDictionary[startSystemID];
                        Convert.ToInt32(row["MoveActionID"]);
                        moveOrder.MoveAction = this.MoveActionDictionary[(MoveActionType)Convert.ToInt32(row["MoveActionID"])];
                        int int32_3 = Convert.ToInt32(row["NewSystemID"]);
                        if (moveOrder.OrderTemplate.RaceData.RacialSystemDictionary.ContainsKey(int32_3))
                            moveOrder.NewSystem = moveOrder.OrderTemplate.RaceData.RacialSystemDictionary[int32_3];
                        int int32_4 = Convert.ToInt32(row["NewJumpPointID"]);
                        if (this.JumpPointDictionary.ContainsKey(int32_4))
                            moveOrder.NewJumpPoint = this.JumpPointDictionary[int32_4];
                        int int32_5 = Convert.ToInt32(row["PopulationID"]);
                        if (this.PopulationDataDictionary.ContainsKey(int32_5))
                            moveOrder.Population = this.PopulationDataDictionary[int32_5];
                        moveOrder.MoveIndex = Convert.ToInt32(row["MoveIndex"]);
                        moveOrder.DestinationID = Convert.ToInt32(row["DestinationID"]);
                        moveOrder.OrderDelay = Convert.ToInt32(row["OrderDelay"]);
                        moveOrder.MinDistance = Convert.ToDouble(row["MinDistance"]);
                        moveOrder.MinQuantity = Convert.ToInt32(row["MinQuantity"]);
                        moveOrder.OrbDistance = Convert.ToInt32(row["OrbDistance"]);
                        moveOrder.DestinationItemID = Convert.ToInt32(row["DestinationItemID"]);
                        moveOrder.MaxItems = Convert.ToDecimal(row["MaxItems"]);
                        moveOrder.SurveyPointsRequired = Convert.ToDecimal(row["SurveyPointsRequired"]);
                        moveOrder.DestinationType = (DestinationType)Convert.ToInt32(row["DestinationType"]);
                        moveOrder.DestinationItemType = (DestinationItemType)Convert.ToInt32(row["DestinationItemType"]);
                        moveOrder.bLoadSubUnits = Convert.ToBoolean(row["LoadSubUnits"]);
                        moveOrder.Description = row["Description"].ToString();
                        moveOrder.MessageText = row["MessageText"].ToString();
                        moveOrder.OrderTemplate.TMoveOrderList.Add(moveOrder);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowDbExceptionPopupForDb(ex);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1169);
        }
    }

    public void LoadFCTSystemBodyFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_SystemBody where GameID = {this.GameID.ToString()}").Rows)
            {
                SystemBodyData systemBody = new SystemBodyData(this);
                PlanetDominantTerrain int32 = (PlanetDominantTerrain)Convert.ToInt32(row["DominantTerrain"]);
                systemBody.DominantTerrain = !this.DominantTerrainTypeDictionary.ContainsKey(int32)
                    ? this.DominantTerrainTypeDictionary[PlanetDominantTerrain.const_0]
                    : this.DominantTerrainTypeDictionary[int32];
                systemBody.SystemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                systemBody.SystemID = Convert.ToInt32(row["SystemID"]);
                systemBody.StarID = Convert.ToInt32(row["StarID"]);
                if (this.SystemDataDictionary.ContainsKey(systemBody.SystemID))
                {
                    systemBody.SystemData = this.SystemDataDictionary[systemBody.SystemID];
                    if (this.StarDictionary.ContainsKey(systemBody.StarID))
                    {
                        systemBody.StarData = this.StarDictionary[systemBody.StarID];
                        systemBody.PlanetNumber = Convert.ToInt32(row["PlanetNumber"]);
                        systemBody.OrbitNumber = Convert.ToInt32(row["OrbitNumber"]);
                        systemBody.BodyClass = (PlanetBodyClass)Convert.ToInt32(row["BodyClass"]);
                        systemBody.Radius = Convert.ToInt32(row["Radius"]);
                        systemBody.ParentBodyID = Convert.ToInt32(row["ParentBodyID"]);
                        systemBody.FixedBodyParentID = Convert.ToInt32(row["FixedBodyParentID"]);
                        systemBody.ParentBodyType = (ParentBodyType)Convert.ToInt32(row["ParentBodyType"]);
                        systemBody.BodyTypeId = (AuroraSystemBodyType)Convert.ToInt32(row["BodyTypeID"]);
                        systemBody.Tilt = Convert.ToInt32(row["Tilt"]);
                        systemBody.TectonicActivity = (AuroraTectonics)Convert.ToInt32(row["TectonicActivity"]);
                        systemBody.HydrosphereTypeId = (AuroraHydrosphereType)Convert.ToInt32(row["HydroID"]);
                        systemBody.GroundMineralSurveyState =
                            (AuroraGroundMineralSurvey)Convert.ToInt32(row["GroundMineralSurvey"]);
                        systemBody.AsteroidBeltID = Convert.ToInt32(row["AsteroidBeltID"]);
                        systemBody.HydroExtent = Convert.ToDouble(row["HydroExt"]);
                        systemBody.TrojanOffset = Convert.ToDouble(row["TrojanAsteroid"]);
                        systemBody.OrbitalDistance = Convert.ToDouble(row["OrbitalDistance"]);
                        systemBody.DistanceToOrbitCentre = Convert.ToDouble(row["DistanceToOrbitCentre"]);
                        systemBody.DistanceToParent = Convert.ToDouble(row["DistanceToParent"]);
                        systemBody.Bearing = Convert.ToDouble(row["Bearing"]);
                        systemBody.Density = Convert.ToDouble(row["Density"]);
                        systemBody.Mass = Convert.ToDouble(row["Mass"]);
                        systemBody.Gravity = Convert.ToDouble(row["Gravity"]);
                        systemBody.Escape = Convert.ToDouble(row["EscapeVelocity"]);
                        systemBody.Year = Convert.ToDouble(row["Year"]);
                        systemBody.TidalForce = Convert.ToDouble(row["TidalForce"]);
                        systemBody.Eccentricity = Convert.ToDouble(row["Eccentricity"]);
                        systemBody.Day = Convert.ToDouble(row["DayValue"]);
                        systemBody.Roche = Convert.ToDouble(row["Roche"]);
                        systemBody.MagneticField = Convert.ToDouble(row["MagneticField"]);
                        systemBody.BaseTemp = Convert.ToDouble(row["BaseTemp"]);
                        systemBody.SurfaceTemp = Convert.ToDouble(row["SurfaceTemp"]);
                        systemBody.AtmospherePressure = Convert.ToDouble(row["AtmosPress"]);
                        systemBody.Albedo = Convert.ToDouble(row["Albedo"]);
                        systemBody.GreenhouseFactor = Convert.ToDouble(row["GHFactor"]);
                        systemBody.AntiGreenhouseFactor = Convert.ToDouble(row["AGHFactor"]);
                        systemBody.XCoordinate = Convert.ToDouble(row["Xcor"]);
                        systemBody.YCoordinate = Convert.ToDouble(row["Ycor"]);
                        systemBody.EccentricityDirection = Convert.ToDouble(row["EccentricityDirection"]);
                        systemBody.CurrentOrbitalSpeed = Convert.ToDouble(row["CurrentOrbitalSpeed"]);
                        systemBody.RadiationLevel = Convert.ToDecimal(row["RadiationLevel"]);
                        systemBody.DustLevel = Convert.ToDecimal(row["DustLevel"]);
                        systemBody.MeanOrbitalSpeed = !row.IsNull("MeanOrbitalSpeed")
                            ? Convert.ToDouble(row["MeanOrbitalSpeed"])
                            : 0.0;
                        if (systemBody.MeanOrbitalSpeed == 0.0 && systemBody.Eccentricity > 0.0)
                            systemBody.MeanOrbitalSpeed =
                                Math.Sqrt(2.0 / systemBody.OrbitalDistance - 1.0 / systemBody.OrbitalDistance);
                        if (systemBody.CurrentOrbitalSpeed == 0.0 && systemBody.Eccentricity > 0.0)
                            systemBody.CurrentOrbitalSpeed = systemBody.MeanOrbitalSpeed;
                        if (systemBody.Mass == 0.0)
                        {
                            double num = Math.Pow(systemBody.Radius / 6380.0, 3.0) * systemBody.Density;
                            systemBody.Mass = num;
                        }

                        systemBody.TidalLock = Convert.ToBoolean(row["TidalLock"]);
                        systemBody.Ring = Convert.ToBoolean(row["Ring"]);
                        systemBody.IsFixedBody = Convert.ToBoolean(row["FixedBody"]);
                        systemBody.Name = row["Name"].ToString();
                        systemBody.PlanetIcon = row["PlanetIcon"].ToString();
                        systemBody.RuinID = Convert.ToInt32(row["RuinID"]);
                        systemBody.RuinRaceID = Convert.ToInt32(row["RuinRaceID"]);
                        systemBody.AbandonedFactories = Convert.ToInt32(row["AbandonedFactories"]);
                        if (systemBody.AbandonedFactories > 0)
                        {
                            if (systemBody.RuinRaceID > 0 && systemBody.RuinID > 0)
                            {
                                systemBody.RuinRaceData = this.RuinRaceDictionary[systemBody.RuinRaceID];
                                systemBody.RuinData = this.RuinDefinitionDictionary[systemBody.RuinID];
                            }
                            else
                            {
                                systemBody.AbandonedFactories = 0;
                                systemBody.RuinRaceID = 0;
                                systemBody.RuinID = 0;
                            }
                        }

                        systemBody.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.BasicUpdate;
                        this.SystemBodyRecordDic.Add(systemBody.SystemBodyID, systemBody);
                    }
                }
            }

            this.method_573();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1170);
        }
    }

    public void LoadFCTSubFleetsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_SubFleets WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                SubFleet subFleet = new SubFleet(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(raceID))
                {
                    int parentFleetID = Convert.ToInt32(row["ParentFleetID"]);
                    if (this.FleetDictionary.ContainsKey(parentFleetID))
                    {
                        subFleet.AnchorFleetID = Convert.ToInt32(row["AnchorFleetID"]);
                        if (this.FleetDictionary.ContainsKey(subFleet.AnchorFleetID))
                            subFleet.AnchorFleet = this.FleetDictionary[subFleet.AnchorFleetID];
                        subFleet.Race = this.FCTRaceRecordDic[raceID];
                        subFleet.ParentFleet = this.FleetDictionary[parentFleetID];
                        subFleet.SubFleetID = Convert.ToInt32(row["SubFleetID"]);
                        subFleet.ParentSubFleetID = Convert.ToInt32(row["ParentSubFleetID"]);
                        subFleet.SubFleetName = row["SubFleetName"].ToString();
                        subFleet.SpecificThreatID = Convert.ToInt32(row["SpecificThreatID"]);
                        subFleet.AnchorFleetBearingOffset = Convert.ToInt32(row["AnchorFleetBearingOffset"]);
                        subFleet.AnchorFleetDistance = Convert.ToDouble(row["AnchorFleetDistance"]);
                        subFleet.bGuardNearestHostileContact = Convert.ToBoolean(row["GuardNearestHostileContact"]);
                        subFleet.bGuardNearestKnownWarship = Convert.ToBoolean(row["GuardNearestKnownWarship"]);
                        subFleet.bUseAnchorDestination = Convert.ToBoolean(row["UseAnchorDestination"]);
                        this.SubFleetDictionary.Add(subFleet.SubFleetID, subFleet);
                    }
                }
            }

            foreach (SubFleet subFleet in this.SubFleetDictionary.Values)
            {
                if (this.SubFleetDictionary.ContainsKey(subFleet.ParentSubFleetID))
                    subFleet.ParentSubFleet = this.SubFleetDictionary[subFleet.ParentSubFleetID];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1298);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1299);
        }
    }

    public void LoadFCTStandingOrdersFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_FleetStandingOrder WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                AuroraStandingOrder standingOrderType = (AuroraStandingOrder)Convert.ToInt32(row["StandingOrderID"]);
                if (this.StandingOrderDictionary.ContainsKey(standingOrderType))
                {
                    int int32_2 = Convert.ToInt32(row["FleetID"]);
                    if (this.FleetDictionary.ContainsKey(int32_2))
                    {
                        int priority = Convert.ToInt32(row["Priority"]);
                        this.FleetDictionary[int32_2].StandingOrdersDictionary.Add(priority, this.StandingOrderDictionary[standingOrderType]);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1298);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1299);
        }
    }

    public void LoadFCTConditionalOrdersFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_FleetConditionalOrder WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                AuroraStandingOrder standingOrderType = (AuroraStandingOrder)Convert.ToInt32(row["ConditionalOrderID"]);
                if (this.StandingOrderDictionary.ContainsKey(standingOrderType))
                {
                    AuroraFleetCondition conditionType = (AuroraFleetCondition)Convert.ToInt32(row["ConditionID"]);
                    if (this.FleetConditionDictionary.ContainsKey(conditionType))
                    {
                        int fleetId = Convert.ToInt32(row["FleetID"]);
                        if (this.FleetDictionary.ContainsKey(fleetId))
                        {
                            int priority = Convert.ToInt32(row["Priority"]);
                            int createFWP = Convert.ToInt32(row["CreateFWP"]);
                            this.FleetDictionary[fleetId].ConditionalOrdersDictionary.Add(priority, new FleetConditionalOrder()
                            {
                                Condition = conditionType,
                                StandingOrder = standingOrderType,
                                CreateFleetWaypoint = createFWP
                            });
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1298);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1299);
        }
    }

    public void LoadFCTFleetFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Fleet WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                try
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.LambdaScope86 lambdaScope86 = new GClass0.LambdaScope86();
                    // ISSUE: reference to a compiler-generated field
                    lambdaScope86.Fleet = new FleetData(this);
                    int raceID = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(raceID))
                    {
                        // ISSUE: reference to a compiler-generated field
                        lambdaScope86.Fleet.Race = this.FCTRaceRecordDic[raceID];
                        int systemID = Convert.ToInt32(row["SystemID"]);
                        if (this.SystemDataDictionary.ContainsKey(systemID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.System = lambdaScope86.Fleet.Race.RacialSystemDictionary[systemID];
                            int parentCommandID = Convert.ToInt32(row["ParentCommandID"]);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            lambdaScope86.Fleet.ParentNavalCommand = !this.NavalAdminCommands.ContainsKey(parentCommandID)
                                ? this.NavalAdminCommands.Values.FirstOrDefault(lambdaScope86.method_0)
                                : this.NavalAdminCommands[parentCommandID];
                            int int32_4 = Convert.ToInt32(row["OrbitBodyID"]);
                            if (this.SystemBodyRecordDic.ContainsKey(int32_4))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.OrbitingBody = this.SystemBodyRecordDic[int32_4];
                            }

                            int int32_5 = Convert.ToInt32(row["EntryJPID"]);
                            if (this.JumpPointDictionary.ContainsKey(int32_5))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.EntryJumpPoint = this.JumpPointDictionary[int32_5];
                            }

                            int int32_6 = Convert.ToInt32(row["ShippingLine"]);
                            if (this.ShippingLineDictionary.ContainsKey(int32_6))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.ShippingLine = this.ShippingLineDictionary[int32_6];
                            }

                            int int32_7 = Convert.ToInt32(row["AssignedPopulationID"]);
                            if (this.PopulationDataDictionary.ContainsKey(int32_7))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.AssignedPopulation = this.PopulationDataDictionary[int32_7];
                            }

                            OperationalGroupID int32_8 = (OperationalGroupID)Convert.ToInt32(row["NPROperationalGroupID"]);
                            if (this.OperationalGroupDictionary.ContainsKey(int32_8))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.NPROperationGroup = this.OperationalGroupDictionary[int32_8];
                            }

                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.CivilianFunction = (CivilanFunctionType)Convert.ToInt32(row["CivilianFunction"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.checkState_0 = (CheckState)Convert.ToInt32(row["CycleMoves"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.FleetID = Convert.ToInt32(row["FleetID"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.TradeLocation = Convert.ToInt32(row["TradeLocation"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.OrbitDistance = Convert.ToInt32(row["OrbitDistance"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.Speed = Convert.ToInt32(row["Speed"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.MaxNebulaSpeed = Convert.ToInt32(row["MaxNebulaSpeed"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.JustDivided = Convert.ToInt32(row["JustDivided"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.AnchorFleetID = Convert.ToInt32(row["AnchorFleetID"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.SpecificThreatID = Convert.ToInt32(row["SpecificThreatID"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.AnchorFleetBearingOffset = Convert.ToInt32(row["AnchorFleetBearingOffset"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.MaxStandingOrderDistance = Convert.ToInt64(row["MaxStandingOrderDistance"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.OrbitBearing = Convert.ToDouble(row["OrbitBearing"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.XCoord = Convert.ToDouble(row["Xcor"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.YCoord = Convert.ToDouble(row["Ycor"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.LastXCoord = Convert.ToDouble(row["LastXcor"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.LastYCoord = Convert.ToDouble(row["LastYcor"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.LastMoveTime = Convert.ToDecimal(row["LastMoveTime"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.LastTransitTime = Convert.ToDecimal(row["LastTransitTime"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.IncrementStartX = Convert.ToDouble(row["IncrementStartX"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.IncrementStartY = Convert.ToDouble(row["IncrementStartY"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.AnchorFleetDistance = Convert.ToDouble(row["AnchorFleetDistance"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.EscapeTimeRemaining = Convert.ToDouble(row["EscapeTimeRemaining"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.LastFleetDamageTime = Convert.ToDecimal(row["LastFleetDamageTime"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.IsNPRHomeguard = Convert.ToBoolean(row["NPRHomeGuard"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bAvoidDanger = Convert.ToBoolean(row["AvoidDanger"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bAvoidAlienSystem = Convert.ToBoolean(row["AvoidAlienSystems"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bDisplaySensors = Convert.ToBoolean(row["DisplaySensors"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bDisplayWeapons = Convert.ToBoolean(row["DisplayWeapons"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bUseMaximumSpeed = Convert.ToBoolean(row["UseMaximumSpeed"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bNoSurrender = Convert.ToBoolean(row["NoSurrender"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bGuardNearestHostileContact = Convert.ToBoolean(row["GuardNearestHostileContact"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bGuardNearestKnownWarship = Convert.ToBoolean(row["GuardNearestKnownWarship"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bUseAnchorDestination = Convert.ToBoolean(row["UseAnchorDestination"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bAssumeJumpCapable = Convert.ToBoolean(row["AssumeJumpCapable"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bDetachedStanding = Convert.ToBoolean(row["DetachedStanding"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bDetachedCondition = Convert.ToBoolean(row["DetachedConditional"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bIncludeSquadrons = Convert.ToBoolean(row["IncludeSquadrons"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bIgnoreConditional = Convert.ToBoolean(row["IgnoreConditional"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.bIgnoreStanding = Convert.ToBoolean(row["IgnoreStanding"]);
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.FleetName = row["FleetName"].ToString();
                            // ISSUE: reference to a compiler-generated field
                            if (lambdaScope86.Fleet.Race.NPR)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.NPRSomething = new UnknownNPRFleetRelatedClass(this, lambdaScope86.Fleet); // TODO: GClass4 something about NPR Fleet behaviour
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.NPRSomething.bRedeployOrderGiven = Convert.ToBoolean(row["RedeployOrderGiven"]);
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.FleetDictionary.Add(lambdaScope86.Fleet.FleetID, lambdaScope86.Fleet);
                        }
                    }
                }
                catch (Exception ex)
                {
                    AuroraUtils.ShowExceptionPopup(ex, 3248);
                    return;
                }
            }

            foreach (FleetData fleet in this.FleetDictionary.Values)
            {
                if (this.FleetDictionary.ContainsKey(fleet.AnchorFleetID))
                    fleet.AnchorFleet = this.FleetDictionary[fleet.AnchorFleetID];
            }

            foreach (PopulationData population in this.PopulationDataDictionary.Values
                         .Where(pop => pop.FighterDestFleetID > 0).ToList())
            {
                if (this.FleetDictionary.ContainsKey(population.FighterDestFleetID))
                    population.FighterDestFleet = this.FleetDictionary[population.FighterDestFleetID];
            }

            foreach (PopulationData population in this.PopulationDataDictionary.Values
                         .Where(pop => pop.SpaceStationDestFleetID > 0).ToList())
            {
                if (this.FleetDictionary.ContainsKey(population.SpaceStationDestFleetID))
                    population.SpaceStationDestFleet = this.FleetDictionary[population.SpaceStationDestFleetID];
            }

            foreach (PopulationData population in this.PopulationDataDictionary.Values
                         .Where(pop => pop.ParasiteSourceID > 0).ToList())
            {
                if (this.FleetDictionary.ContainsKey(population.ParasiteSourceID))
                    population.ParasiteSource = this.FleetDictionary[population.ParasiteSourceID];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1174);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1171);
        }
    }

    public void method_234()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PopulationInstallations WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass158 gclass158 = new GClass158();
                int int32_1 = Convert.ToInt32(row["PopID"]);
                if (this.PopulationDataDictionary.ContainsKey(int32_1))
                {
                    gclass158.gclass146_0 = this.PopulationDataDictionary[int32_1];
                    gclass158.gclass40_0 = null;
                    AuroraInstallationType int32_2 =
                        (AuroraInstallationType)Convert.ToInt32(row["PlanetaryInstallationID"]);
                    if (this.PlanetaryInstallationDictionary.ContainsKey(int32_2))
                    {
                        gclass158.gclass157_0 = this.PlanetaryInstallationDictionary[int32_2];
                        gclass158.decimal_0 = Convert.ToDecimal(row["Amount"]);
                        this.PopulationDataDictionary[int32_1].dictionary_0.Add(int32_2, gclass158);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1176);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1173);
        }
    }

    public void method_235()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipCargo WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["StartingPop"]);
                    switch (Convert.ToInt32(row["CargoTypeID"]))
                    {
                        case 1:
                            int int32_3 = Convert.ToInt32(row["SpeciesID"]);
                            if (this.SpeciesDictionary.ContainsKey(int32_3))
                            {
                                GClass181 gclass181 = new GClass181();
                                gclass181.gclass194_0 = this.SpeciesDictionary[int32_3];
                                gclass181.int_0 = Convert.ToInt32(row["Amount"]);
                                gclass181.bool_0 = Convert.ToBoolean(row["Neutral"]);
                                if (this.PopulationDataDictionary.ContainsKey(int32_2))
                                    gclass181.gclass146_0 = this.PopulationDataDictionary[int32_2];
                                this.FCTShipDataDictionary[int32_1].list_18.Add(gclass181);
                                continue;
                            }

                            continue;
                        case 2:
                            GClass158 gclass158 = new GClass158();
                            AuroraInstallationType int32_4 = (AuroraInstallationType)Convert.ToInt32(row["CargoID"]);
                            gclass158.gclass157_0 = this.PlanetaryInstallationDictionary[int32_4];
                            gclass158.decimal_0 = Convert.ToDecimal(row["Amount"]);
                            gclass158.gclass40_0 = this.FCTShipDataDictionary[int32_1];
                            gclass158.gclass146_0 = null;
                            if (this.PopulationDataDictionary.ContainsKey(int32_2))
                                gclass158.gclass146_1 = this.PopulationDataDictionary[int32_2];
                            this.FCTShipDataDictionary[int32_1].dictionary_2.Add(int32_4, gclass158);
                            continue;
                        case 3:
                            AuroraElement int32_5 = (AuroraElement)Convert.ToInt32(row["CargoID"]);
                            Decimal decimal_11 = Convert.ToDecimal(row["Amount"]);
                            this.FCTShipDataDictionary[int32_1].gclass123_0.method_33(int32_5, decimal_11);
                            continue;
                        case 6:
                            GClass73 gclass73 = new GClass73();
                            int int32_6 = Convert.ToInt32(row["CargoID"]);
                            if (this.ComponentDataDictionary.ContainsKey(int32_6))
                            {
                                gclass73.gclass230_0 = this.ComponentDataDictionary[int32_6];
                                gclass73.decimal_0 = Convert.ToDecimal(row["Amount"]);
                                if (this.PopulationDataDictionary.ContainsKey(int32_2))
                                    gclass73.gclass146_0 = this.PopulationDataDictionary[int32_2];
                                this.FCTShipDataDictionary[int32_1].list_17.Add(gclass73);
                                continue;
                            }

                            continue;
                        case 7:
                            GClass191 gclass191 = new GClass191();
                            int int32_7 = Convert.ToInt32(row["CargoID"]);
                            if (this.TradeGoodsDictionary.ContainsKey(int32_7))
                            {
                                gclass191.gclass189_0 = this.TradeGoodsDictionary[int32_7];
                                gclass191.decimal_0 = Convert.ToDecimal(row["Amount"]);
                                gclass191.gclass40_0 = this.FCTShipDataDictionary[int32_1];
                                if (this.PopulationDataDictionary.ContainsKey(int32_2))
                                    gclass191.gclass146_0 = this.PopulationDataDictionary[int32_2];
                                this.FCTShipDataDictionary[int32_1].dictionary_3.Add(int32_7, gclass191);
                                continue;
                            }

                            continue;
                        default:
                            continue;
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1177);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1178);
        }
    }

    public void method_236()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Population WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                PopulationData gclass146_1 = new PopulationData(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass146_1.RaceData = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (this.SpeciesDictionary.ContainsKey(int32_2))
                    {
                        gclass146_1.SpeciesData = this.SpeciesDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["GenModSpeciesID"]);
                        if (this.SpeciesDictionary.ContainsKey(int32_3))
                            gclass146_1.GenModSpeciesData = this.SpeciesDictionary[int32_3];
                        int int32_4 = Convert.ToInt32(row["SystemID"]);
                        if (gclass146_1.RaceData.RacialSystemDictionary.ContainsKey(int32_4))
                        {
                            gclass146_1.gclass202_0 = gclass146_1.RaceData.RacialSystemDictionary[int32_4];
                            int int32_5 = Convert.ToInt32(row["SystemBodyID"]);
                            if (this.SystemBodyRecordDic.ContainsKey(int32_5))
                            {
                                gclass146_1.SystemBodyData = this.SystemBodyRecordDic[int32_5];
                                int int32_6 = Convert.ToInt32(row["OriginalRaceID"]);
                                if (this.FCTRaceRecordDic.ContainsKey(int32_6))
                                    gclass146_1.gclass21_1 = this.FCTRaceRecordDic[int32_6];
                                gclass146_1.FighterDestFleetID = Convert.ToInt32(row["FighterDestFleetID"]);
                                gclass146_1.SpaceStationDestFleetID = Convert.ToInt32(row["SpaceStationDestFleetID"]);
                                gclass146_1.ParasiteSourceID = Convert.ToInt32(row["ParasiteSourceID"]);
                                AtmosphericGas int32_7 = (AtmosphericGas)Convert.ToInt32(row["TerraformingGasID"]);
                                if (this.AtmosphericGasDictionary.ContainsKey(int32_7))
                                    gclass146_1.TerraformingTargetGas = this.AtmosphericGasDictionary[int32_7];
                                PopPoliticalStatusType int32_8 = (PopPoliticalStatusType)Convert.ToInt32(row["PoliticalStatus"]);
                                if (this.PopulationPoliticalStatusDictionary.ContainsKey(int32_8))
                                    gclass146_1.PopulationPoliticalStatus = this.PopulationPoliticalStatusDictionary[int32_8];
                                gclass146_1.PopulationID = Convert.ToInt32(row["PopulationID"]);
                                gclass146_1.TerraformStatus = (TerraformStatus)Convert.ToInt32(row["TerraformStatus"]);
                                gclass146_1.NoStatusChange = Convert.ToInt32(row["NoStatusChange"]);
                                gclass146_1.ProvideColonists = Convert.ToInt32(row["ProvideColonists"]);
                                gclass146_1.ReqInf = Convert.ToInt32(row["ReqInf"]);
                                gclass146_1.TempMF = Convert.ToInt32(row["TempMF"]);
                                gclass146_1.MassDriverDestPopulationID = Convert.ToInt32(row["MassDriverDest"]);
                                gclass146_1.GroundAttackID = Convert.ToInt32(row["GroundAttackID"]);
                                gclass146_1.ColonistDestinationSetting = (PopColonistSetting)Convert.ToInt32(row["ColonistDestination"]);
                                gclass146_1.DestroyedInstallationSize = Convert.ToInt32(row["DestroyedInstallationSize"]);
                                gclass146_1.Importance = Convert.ToInt32(row["Importance"]);
                                gclass146_1.BonusOne = (CommanderBonusType)Convert.ToInt32(row["BonusOne"]);
                                gclass146_1.BonusTwo = (CommanderBonusType)Convert.ToInt32(row["BonusTwo"]);
                                gclass146_1.BonusThree = (CommanderBonusType)Convert.ToInt32(row["BonusThree"]);
                                gclass146_1.genum64_0 = (GEnum64)Convert.ToInt32(row["AutoAssign"]);
                                gclass146_1.WarningFuel = Convert.ToInt32(row["WarningFuel"]);
                                gclass146_1.WarningMSP = Convert.ToInt32(row["WarningMSP"]);
                                gclass146_1.WarningConstant = Convert.ToInt32(row["WarningConstant"]);
                                gclass146_1.AcademyOfficers = Convert.ToDecimal(row["AcademyOfficers"]);
                                gclass146_1.Efficiency = Convert.ToDecimal(row["Efficiency"]);
                                gclass146_1.FuelStockpile = Convert.ToDecimal(row["FuelStockpile"]);
                                gclass146_1.LastColonyCost = Convert.ToDecimal(row["LastColonyCost"]);
                                gclass146_1.MaintenanceStockpile = Convert.ToDecimal(row["MaintenanceStockpile"]);
                                gclass146_1.MaxAtm = Convert.ToDouble(row["MaxAtm"]);
                                gclass146_1.Population = Convert.ToDecimal(row["Population"]);
                                gclass146_1.PreviousUnrest = Convert.ToDecimal(row["PreviousUnrest"]);
                                gclass146_1.StatusPoints = Convert.ToDecimal(row["StatusPoints"]);
                                gclass146_1.UnrestPoints = Convert.ToDecimal(row["UnrestPoints"]);
                                gclass146_1.GroundGeoSurvey = Convert.ToDecimal(row["GroundGeoSurvey"]);
                                gclass146_1.AvailableColonists = Convert.ToDecimal(row["AvailableColonists"]);
                                gclass146_1.ColonizationPressure = Convert.ToDecimal(row["ColonizationPressure"]);
                                gclass146_1.bIsCapital = Convert.ToBoolean(row["Capital"]);
                                gclass146_1.bPurchaseCivilianMineral = Convert.ToBoolean(row["PurchaseCivilianMinerals"]);
                                gclass146_1.bFuelProdStatus = Convert.ToBoolean(row["FuelProdStatus"]);
                                gclass146_1.bMaintProdStatus = Convert.ToBoolean(row["MaintProdStatus"]);
                                gclass146_1.bGeneticProdStatus = Convert.ToBoolean(row["GeneticProdStatus"]);
                                gclass146_1.bIsInvasionStagingPoint = Convert.ToBoolean(row["InvasionStagingPoint"]);
                                gclass146_1.bDoNotDelete = Convert.ToBoolean(row["DoNotDelete"]);
                                gclass146_1.bMilitaryRestrictedColony = Convert.ToBoolean(row["MilitaryRestrictedColony"]);
                                gclass146_1.bAutoRefuel = Convert.ToBoolean(row["AutoRefuel"]);
                                gclass146_1.AcademyName = row["AcademyName"].ToString();
                                gclass146_1.PopName = row["PopName"].ToString();
                                if (gclass146_1.PopName == "")
                                    gclass146_1.PopName =
                                        gclass146_1.SystemBodyData.BodyTypeId == AuroraSystemBodyType.Asteroid ||
                                        gclass146_1.SystemBodyData.BodyTypeId == AuroraSystemBodyType.Comet
                                            ? $"{gclass146_1.gclass202_0.Name} {gclass146_1.SystemBodyData.method_78(gclass146_1.RaceData)}"
                                            : gclass146_1.SystemBodyData.method_78(gclass146_1.RaceData);
                                gclass146_1.CurrentMinerals = new AllMineralsValue(this);
                                gclass146_1.gclass123_3 = new AllMineralsValue(this);
                                gclass146_1.LastMinerals = new AllMineralsValue(this);
                                gclass146_1.ReserveMinerals = new AllMineralsValue(this);
                                gclass146_1.gclass123_4 = new AllMineralsValue(this);
                                gclass146_1.CurrentMinerals.Duranium = Convert.ToDecimal(row["Duranium"]);
                                gclass146_1.CurrentMinerals.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                                gclass146_1.CurrentMinerals.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                                gclass146_1.CurrentMinerals.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                                gclass146_1.CurrentMinerals.Boronide = Convert.ToDecimal(row["Boronide"]);
                                gclass146_1.CurrentMinerals.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                                gclass146_1.CurrentMinerals.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                                gclass146_1.CurrentMinerals.Sorium = Convert.ToDecimal(row["Sorium"]);
                                gclass146_1.CurrentMinerals.Uridium = Convert.ToDecimal(row["Uridium"]);
                                gclass146_1.CurrentMinerals.Corundium = Convert.ToDecimal(row["Corundium"]);
                                gclass146_1.CurrentMinerals.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                                gclass146_1.LastMinerals.Duranium = Convert.ToDecimal(row["LastDuranium"]);
                                gclass146_1.LastMinerals.Neutronium = Convert.ToDecimal(row["LastNeutronium"]);
                                gclass146_1.LastMinerals.Corbomite = Convert.ToDecimal(row["LastCorbomite"]);
                                gclass146_1.LastMinerals.Tritanium = Convert.ToDecimal(row["LastTritanium"]);
                                gclass146_1.LastMinerals.Boronide = Convert.ToDecimal(row["LastBoronide"]);
                                gclass146_1.LastMinerals.Mercassium = Convert.ToDecimal(row["LastMercassium"]);
                                gclass146_1.LastMinerals.Vendarite = Convert.ToDecimal(row["LastVendarite"]);
                                gclass146_1.LastMinerals.Sorium = Convert.ToDecimal(row["LastSorium"]);
                                gclass146_1.LastMinerals.Uridium = Convert.ToDecimal(row["LastUridium"]);
                                gclass146_1.LastMinerals.Corundium = Convert.ToDecimal(row["LastCorundium"]);
                                gclass146_1.LastMinerals.Gallicite = Convert.ToDecimal(row["LastGallicite"]);
                                gclass146_1.ReserveMinerals.Duranium = Convert.ToDecimal(row["ReserveDuranium"]);
                                gclass146_1.ReserveMinerals.Neutronium = Convert.ToDecimal(row["ReserveNeutronium"]);
                                gclass146_1.ReserveMinerals.Corbomite = Convert.ToDecimal(row["ReserveCorbomite"]);
                                gclass146_1.ReserveMinerals.Tritanium = Convert.ToDecimal(row["ReserveTritanium"]);
                                gclass146_1.ReserveMinerals.Boronide = Convert.ToDecimal(row["ReserveBoronide"]);
                                gclass146_1.ReserveMinerals.Mercassium = Convert.ToDecimal(row["ReserveMercassium"]);
                                gclass146_1.ReserveMinerals.Vendarite = Convert.ToDecimal(row["ReserveVendarite"]);
                                gclass146_1.ReserveMinerals.Sorium = Convert.ToDecimal(row["ReserveSorium"]);
                                gclass146_1.ReserveMinerals.Uridium = Convert.ToDecimal(row["ReserveUridium"]);
                                gclass146_1.ReserveMinerals.Corundium = Convert.ToDecimal(row["ReserveCorundium"]);
                                gclass146_1.ReserveMinerals.Gallicite = Convert.ToDecimal(row["ReserveGallicite"]);
                                gclass146_1.decimal_33 = 1M - gclass146_1.UnrestPoints / 100M;
                                gclass146_1.SystemBodyData.method_58(gclass146_1.RaceData, gclass146_1.SpeciesData, true);
                                gclass146_1.ColonyCost = gclass146_1.SystemBodyData.ColonyCost;
                                gclass146_1.MaxColonyCost = gclass146_1.SystemBodyData.MaxColonyCost;
                                this.PopulationDataDictionary.Add(gclass146_1.PopulationID, gclass146_1);
                                if (gclass146_1.RaceData.NPR)
                                {
                                    gclass146_1.gclass6_0 = new GClass6(this, gclass146_1);
                                    gclass146_1.gclass6_0.genum97_0 = (GEnum97)Convert.ToInt32(row["AIValue"]);
                                }
                            }
                        }
                    }
                }
            }

            foreach (PopulationData population in this.PopulationDataDictionary.Values)
            {
                if (this.PopulationDataDictionary.ContainsKey(population.MassDriverDestPopulationID))
                    population.MassDriverDestPopulation = this.PopulationDataDictionary[population.MassDriverDestPopulationID];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1179);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1180);
        }
    }

    public void method_237()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MineralDeposit WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass124 gclass124 = new GClass124();
                gclass124.int_0 = Convert.ToInt32(row["SystemBodyID"]);
                if (this.SystemBodyRecordDic.ContainsKey(gclass124.int_0))
                {
                    gclass124.auroraElement_0 = (AuroraElement)Convert.ToInt32(row["MaterialID"]);
                    gclass124.decimal_0 = Convert.ToDecimal(row["Amount"]);
                    gclass124.decimal_1 = Convert.ToDecimal(row["Accessibility"]);
                    gclass124.decimal_2 = Convert.ToDecimal(row["HalfOriginalAmount"]);
                    gclass124.decimal_3 = Convert.ToDecimal(row["OriginalAcc"]);
                    this.SystemBodyRecordDic[gclass124.int_0].dictionary_0.Add(gclass124.auroraElement_0, gclass124);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1181);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1182);
        }
    }

    public void method_238()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipClass WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass22 gclass22 = new GClass22(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass22.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["ClassShippingLineID"]);
                    if (this.ShippingLineDictionary.ContainsKey(int32_2))
                        gclass22.gclass187_0 = this.ShippingLineDictionary[int32_2];
                    int int32_3 = Convert.ToInt32(row["HullDescriptionID"]);
                    if (this.ShipHullDictionary.ContainsKey(int32_3))
                    {
                        gclass22.gclass76_0 = this.ShipHullDictionary[int32_3];
                        int int32_4 = Convert.ToInt32(row["NameThemeID"]);
                        gclass22.gclass140_0 = !this.ThemeDictionary.ContainsKey(int32_4)
                            ? this.ThemeDictionary[1]
                            : this.ThemeDictionary[int32_4];
                        AutomatedClassDesignType int32_5 = (AutomatedClassDesignType)Convert.ToInt32(row["AutomatedDesignID"]);
                        if (this.AutomatedClassDesignDictionary.ContainsKey(int32_5))
                            gclass22.gclass14_0 = this.AutomatedClassDesignDictionary[int32_5];
                        TechType int32_6 = (TechType)Convert.ToInt32(row["TroopTransportType"]);
                        gclass22.gclass163_0 =
                            this.TechTypeDataDictionary.ContainsKey(int32_6) ? this.TechTypeDataDictionary[int32_6] : null;
                        gclass22.int_18 = Convert.ToInt32(row["RankRequired"]);
                        if (gclass22.gclass21_0.SpecialNPRID == SpecialNPRIDs.const_0 ||
                            gclass22.gclass21_0.SpecialNPRID == SpecialNPRIDs.Eldar)
                        {
                            gclass22.gclass61_0 =
                                gclass22.gclass21_0.method_253((GEnum15)gclass22.int_18, AuroraCommanderType.Naval);
                            if (gclass22.gclass61_0 == null)
                                gclass22.gclass61_0 = gclass22.gclass21_0.method_252(AuroraCommanderType.Naval);
                        }

                        gclass22.int_0 = Convert.ToInt32(row["ShipClassID"]);
                        gclass22.int_1 = Convert.ToInt32(row["ActiveSensorStrength"]);
                        gclass22.int_2 = Convert.ToInt32(row["ArmourThickness"]);
                        gclass22.int_3 = Convert.ToInt32(row["ArmourWidth"]);
                        gclass22.int_5 = Convert.ToInt32(row["Collier"]);
                        gclass22.int_6 = Convert.ToInt32(row["SeniorCO"]);
                        gclass22.int_7 = Convert.ToInt32(row["ColonistCapacity"]);
                        gclass22.int_8 = Convert.ToInt32(row["CommanderPriority"]);
                        gclass22.int_14 = Convert.ToInt32(row["CommercialJumpDrive"]);
                        gclass22.int_9 = Convert.ToInt32(row["ControlRating"]);
                        gclass22.int_10 = Convert.ToInt32(row["ConscriptOnly"]);
                        gclass22.int_15 = Convert.ToInt32(row["NoOfficers"]);
                        gclass22.int_11 = Convert.ToInt32(row["Crew"]);
                        gclass22.int_17 = Convert.ToInt32(row["DCRating"]);
                        gclass22.int_21 = Convert.ToInt32(row["EMSensorStrength"]);
                        gclass22.decimal_0 = Convert.ToInt32(row["EnginePower"]);
                        gclass22.int_22 = Convert.ToInt32(row["ESMaxDACRoll"]);
                        gclass22.int_23 = Convert.ToInt32(row["FuelTanker"]);
                        gclass22.int_24 = Convert.ToInt32(row["GravSurvey"]);
                        gclass22.int_25 = Convert.ToInt32(row["Harvesters"]);
                        gclass22.int_27 = Convert.ToInt32(row["JGConstructionTime"]);
                        gclass22.int_28 = Convert.ToInt32(row["JumpDistance"]);
                        gclass22.int_29 = Convert.ToInt32(row["JumpRating"]);
                        gclass22.int_30 = Convert.ToInt32(row["MaxChance"]);
                        gclass22.int_31 = Convert.ToInt32(row["MaxDACRoll"]);
                        gclass22.int_32 = Convert.ToInt32(row["MaxSpeed"]);
                        gclass22.int_33 = Convert.ToInt32(row["MaintModules"]);
                        gclass22.int_36 = Convert.ToInt32(row["MiningModules"]);
                        gclass22.int_37 = Convert.ToInt32(row["NoArmour"]);
                        gclass22.auroraClassMainFunction_0 =
                            (AuroraClassMainFunction)Convert.ToInt32(row["MainFunction"]);
                        gclass22.int_38 = Convert.ToInt32(row["Obsolete"]);
                        gclass22.int_39 = Convert.ToInt32(row["OtherRaceClassID"]);
                        gclass22.int_40 = Convert.ToInt32(row["PassiveSensorStrength"]);
                        gclass22.decimal_15 = Convert.ToInt32(row["ReactorPower"]);
                        gclass22.decimal_16 = Convert.ToInt32(row["RequiredPower"]);
                        gclass22.int_41 = Convert.ToInt32(row["SalvageRate"]);
                        gclass22.int_42 = Convert.ToInt32(row["ShieldStrength"]);
                        gclass22.int_50 = Convert.ToInt32(row["MaintSupplies"]);
                        gclass22.int_51 = Convert.ToInt32(row["STSTractor"]);
                        gclass22.int_52 = Convert.ToInt32(row["SupplyShip"]);
                        gclass22.int_53 = Convert.ToInt32(row["Terraformers"]);
                        gclass22.int_55 = Convert.ToInt32(row["TotalNumber"]);
                        gclass22.int_56 = Convert.ToInt32(row["CargoShuttleStrength"]);
                        gclass22.int_57 = Convert.ToInt32(row["TroopCapacity"]);
                        gclass22.int_58 = Convert.ToInt32(row["WorkerCapacity"]);
                        gclass22.int_62 = Convert.ToInt32(row["CargoCapacity"]);
                        gclass22.int_63 = Convert.ToInt32(row["FuelCapacity"]);
                        gclass22.int_43 = Convert.ToInt32(row["RefuellingRate"]);
                        gclass22.int_44 = Convert.ToInt32(row["RefuelPriority"]);
                        gclass22.int_45 = Convert.ToInt32(row["ResupplyPriority"]);
                        gclass22.int_46 = Convert.ToInt32(row["MinimumFuel"]);
                        gclass22.int_47 = Convert.ToInt32(row["MinimumSupplies"]);
                        gclass22.int_34 = Convert.ToInt32(row["MaintPriority"]);
                        gclass22.int_48 = Convert.ToInt32(row["OrdnanceTransferRate"]);
                        gclass22.int_54 = Convert.ToInt32(row["OrdnanceTransferHub"]);
                        gclass22.int_12 = Convert.ToInt32(row["ELINTRating"]);
                        gclass22.int_13 = Convert.ToInt32(row["DiplomacyRating"]);
                        gclass22.int_64 = Convert.ToInt32(row["BioEnergyCapacity"]);
                        gclass22.int_35 = Convert.ToInt32(row["RandomShipNameFromTheme"]);
                        gclass22.int_65 = Convert.ToInt32(row["ClassHullNumbers"]);
                        gclass22.int_19 = Convert.ToInt32(row["RepairYardCapacity"]);
                        gclass22.int_16 = Convert.ToInt32(row["PDProtectionPriority"]);
                        gclass22.decimal_18 = Convert.ToDecimal(row["ActiveJammerStrength"]);
                        gclass22.decimal_19 = Convert.ToDecimal(row["FireControlJammerStrength"]);
                        gclass22.decimal_20 = Convert.ToDecimal(row["MissileJammerStrength"]);
                        gclass22.decimal_11 = Convert.ToDecimal(row["MagazineCapacity"]);
                        gclass22.decimal_12 = Convert.ToDecimal(row["DecoyCapacity"]);
                        gclass22.decimal_1 = Convert.ToDecimal(row["BaseFailureChance"]);
                        gclass22.decimal_2 = Convert.ToDecimal(row["ClassCrossSection"]);
                        gclass22.decimal_3 = Convert.ToDecimal(row["ClassThermal"]);
                        gclass22.decimal_4 = Convert.ToDecimal(row["Cost"]);
                        gclass22.decimal_5 = Convert.ToDecimal(row["CrewQuartersHS"]);
                        gclass22.decimal_6 = Convert.ToDecimal(row["FuelEfficiency"]);
                        gclass22.decimal_8 = Convert.ToDecimal(row["ParasiteCapacity"]);
                        gclass22.decimal_9 = Convert.ToDecimal(row["PlannedDeployment"]);
                        gclass22.decimal_10 = Convert.ToDecimal(row["ProtectionValue"]);
                        gclass22.decimal_13 = Convert.ToDecimal(row["SensorReduction"]);
                        gclass22.decimal_14 = Convert.ToDecimal(row["Size"]);
                        gclass22.decimal_17 = Convert.ToDecimal(row["GeoSurvey"]);
                        gclass22.decimal_21 = Convert.ToDecimal(row["CrewDesignEfficiency"]);
                        gclass22.bool_8 = Convert.ToBoolean(row["MilitaryEngines"]);
                        gclass22.bool_0 = Convert.ToBoolean(row["CommercialHangar"]);
                        gclass22.bool_1 = Convert.ToBoolean(row["FighterClass"]);
                        gclass22.bool_2 = Convert.ToBoolean(row["Commercial"]);
                        gclass22.bool_3 = Convert.ToBoolean(row["Locked"]);
                        gclass22.bool_4 = Convert.ToBoolean(row["PreTNT"]);
                        gclass22.bool_5 = Convert.ToBoolean(row["RecreationalModule"]);
                        gclass22.bool_7 = Convert.ToBoolean(row["MoraleCheckRequired"]);
                        gclass22.bool_9 = Convert.ToBoolean(row["ArkShip"]);
                        gclass22.bool_10 = Convert.ToBoolean(row["FlagBridge"]);
                        gclass22.ClassName = row["ClassName"].ToString();
                        gclass22.string_1 = row["Notes"].ToString();
                        gclass22.string_3 = row["PrefixName"].ToString();
                        gclass22.string_4 = row["SuffixName"].ToString();
                        gclass22.gclass123_0 = new AllMineralsValue(this);
                        this.dictionary_3.Add(gclass22.int_0, gclass22);
                    }
                }
            }

            foreach (GameRace gclass21 in this.FCTRaceRecordDic.Values)
            {
                if (gclass21.SelectedClassIcon > 0 && this.dictionary_3.ContainsKey(gclass21.SelectedClassIcon))
                    gclass21.SelectedClass = this.dictionary_3[gclass21.SelectedClassIcon];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1182);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1183);
        }
    }

    public void method_239()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ClassMaterials where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                int int32_1 = Convert.ToInt32(row["ClassID"]);
                if (this.dictionary_3.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["MaterialID"]);
                    Decimal decimal_11 = Convert.ToDecimal(row["Amount"]);
                    this.dictionary_3[int32_1].gclass123_0.method_33((AuroraElement)int32_2, decimal_11);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1184);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1185);
        }
    }

    

    public void method_241()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_SystemBodyName WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass218 gclass218 = new GClass218();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32))
                {
                    gclass218.int_0 = Convert.ToInt32(row["SystemBodyID"]);
                    if (this.SystemBodyRecordDic.ContainsKey(gclass218.int_0))
                    {
                        gclass218.gclass21_0 = this.FCTRaceRecordDic[int32];
                        gclass218.string_0 = row["Name"].ToString();
                        this.SystemBodyRecordDic[gclass218.int_0].dictionary_1.Add(int32, gclass218);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1187);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1188);
        }
    }

    public void method_242()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Survivors WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass180 gclass180 = new GClass180();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass180.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (this.SpeciesDictionary.ContainsKey(int32_2))
                    {
                        gclass180.gclass194_0 = this.SpeciesDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["ShipID"]);
                        if (this.FCTShipDataDictionary.ContainsKey(int32_3))
                        {
                            gclass180.gclass40_0 = this.FCTShipDataDictionary[int32_3];
                            gclass180.int_0 = Convert.ToInt32(row["Crew"]);
                            gclass180.gclass40_0.list_1.Add(gclass180);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1189);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1190);
        }
    }

    public void method_243()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select distinct * FROM FCT_SystemBodySurveys WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass215 gclass215 = new GClass215();
                int int32_1 = Convert.ToInt32(row["SystemBodyID"]);
                if (this.SystemBodyRecordDic.ContainsKey(int32_1))
                {
                    gclass215.gclass1_0 = this.SystemBodyRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        gclass215.gclass21_0 = this.FCTRaceRecordDic[int32_2];
                        gclass215.genum5_0 = Unknown_SystemBodyDataUpdateLevel.BasicUpdate;
                        this.list_9.Add(gclass215);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1191);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1192);
        }
    }

    public void method_244()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MissileGeoSurvey WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass216 gclass216 = new GClass216();
                gclass216.int_0 = Convert.ToInt32(row["SystemBodyID"]);
                if (this.SystemBodyRecordDic.ContainsKey(gclass216.int_0))
                {
                    gclass216.int_1 = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(gclass216.int_1))
                    {
                        gclass216.decimal_0 = Convert.ToDecimal(row["SurveyPoints"]);
                        this.list_10.Add(gclass216);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1193);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1194);
        }
    }

    public void method_245()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_RaceSurveyLocation where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                int int32_1 = Convert.ToInt32(row["LocationNumber"]);
                int int32_2 = Convert.ToInt32(row["SystemID"]);
                int int32_3 = Convert.ToInt32(row["RaceID"]);
                if (this.SystemDataDictionary.ContainsKey(int32_2) && this.SystemDataDictionary[int32_2]
                        .SurveyLocationDictionary.ContainsKey(int32_1))
                    this.SystemDataDictionary[int32_2].SurveyLocationDictionary[int32_1].list_0.Add(int32_3);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1195);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1196);
        }
    }

    public void method_246()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AncientConstruct WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass220 gclass220 = new GClass220(this);
                AuroraResearchField int32_1 = (AuroraResearchField)Convert.ToInt32(row["ResearchField"]);
                if (this.ResearchFieldDictionary.ContainsKey(int32_1))
                {
                    gclass220.gclass162_0 = this.ResearchFieldDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["SystemBodyID"]);
                    if (this.SystemBodyRecordDic.ContainsKey(int32_2))
                    {
                        gclass220.gclass1_0 = this.SystemBodyRecordDic[int32_2];
                        gclass220.int_0 = Convert.ToInt32(row["AncientConstructID"]);
                        gclass220.int_1 = Convert.ToInt32(row["AncientConstructTypeID"]);
                        gclass220.decimal_0 = Convert.ToDecimal(row["ResearchBonus"]);
                        gclass220.bool_0 = Convert.ToBoolean(row["Active"]);
                        gclass220.gclass1_0.gclass220_0 = gclass220;
                        this.dictionary_27.Add(gclass220.gclass1_0.SystemBodyID, gclass220);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1197);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1198);
        }
    }

    public void LoadRuinRaceDataFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_RuinRace WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                RuinRaceData gclass171 = new RuinRaceData(this);
                gclass171.RuinRaceID = Convert.ToInt32(row["RuinRaceID"]);
                gclass171.Level = Convert.ToInt32(row["Level"]);
                gclass171.Title = row["Title"].ToString();
                gclass171.Name = row["Name"].ToString();
                gclass171.RacePic = row["RacePic"].ToString();
                gclass171.FlagPic = row["FlagPic"].ToString();
                this.RuinRaceDictionary.Add(gclass171.RuinRaceID, gclass171);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1199);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1200);
        }
    }

    public void method_248()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Ship WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                FCTShipData40 gclass40_1 = new FCTShipData40(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass40_1.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (this.SpeciesDictionary.ContainsKey(int32_2))
                    {
                        gclass40_1.gclass194_0 = this.SpeciesDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["ShipClassID"]);
                        if (this.dictionary_3.ContainsKey(int32_3))
                        {
                            gclass40_1.gclass22_0 = this.dictionary_3[int32_3];
                            int int32_4 = Convert.ToInt32(row["FleetID"]);
                            if (this.FleetDictionary.ContainsKey(int32_4))
                            {
                                gclass40_1.gclass85_0 = this.FleetDictionary[int32_4];
                                gclass40_1.gclass85_0.list_3.Add(gclass40_1);
                                int int32_5 = Convert.ToInt32(row["SubFleetID"]);
                                if (this.SubFleetDictionary.ContainsKey(int32_5))
                                    gclass40_1.gclass84_0 = this.SubFleetDictionary[int32_5];
                                int int32_6 = Convert.ToInt32(row["ShippingLineID"]);
                                if (this.ShippingLineDictionary.ContainsKey(int32_6))
                                    gclass40_1.gclass187_0 = this.ShippingLineDictionary[int32_6];
                                gclass40_1.int_8 = Convert.ToInt32(row["ShipID"]);
                                gclass40_1.AssignedSquadronID = Convert.ToInt32(row["ParentSquadronID"]);
                                gclass40_1.int_26 = Convert.ToInt32(row["AssignedMSID"]);
                                gclass40_1.int_9 = Convert.ToInt32(row["Autofire"]);
                                gclass40_1.int_10 = Convert.ToInt32(row["BoardingCombatClock"]);
                                gclass40_1.int_11 = Convert.ToInt32(row["CurrentCrew"]);
                                gclass40_1.int_12 = Convert.ToInt32(row["DamageControlID"]);
                                gclass40_1.int_13 = Convert.ToInt32(row["FireDelay"]);
                                gclass40_1.int_14 = Convert.ToInt32(row["HoldTechData"]);
                                gclass40_1.genum29_0 = (GEnum29)Convert.ToInt32(row["MaintenanceState"]);
                                gclass40_1.int_27 = Convert.ToInt32(row["MothershipID"]);
                                gclass40_1.int_15 = Convert.ToInt32(row["SensorDelay"]);
                                gclass40_1.int_16 = Convert.ToInt32(row["SpeciesID"]);
                                gclass40_1.int_17 = Convert.ToInt32(row["SyncFire"]);
                                gclass40_1.int_28 = Convert.ToInt32(row["TractorTargetShipID"]);
                                gclass40_1.int_29 = Convert.ToInt32(row["TractorTargetShipyardID"]);
                                gclass40_1.int_30 = Convert.ToInt32(row["TractorParentShipID"]);
                                gclass40_1.int_18 = Convert.ToInt32(row["RefuelPriority"]);
                                gclass40_1.int_19 = Convert.ToInt32(row["ResupplyPriority"]);
                                gclass40_1.auroraResupplyStatus_0 =
                                    (AuroraResupplyStatus)Convert.ToInt32(row["ResupplyStatus"]);
                                gclass40_1.auroraRefuelStatus_0 =
                                    (AuroraRefuelStatus)Convert.ToInt32(row["RefuelStatus"]);
                                gclass40_1.auroraOrdnanceTransferStatus_0 =
                                    (AuroraOrdnanceTransferStatus)Convert.ToInt32(row["OrdnanceTransferStatus"]);
                                gclass40_1.genum43_0 = (GEnum43)Convert.ToInt32(row["HangarLoadType"]);
                                gclass40_1.int_31 = Convert.ToInt32(row["AssignedFormationID"]);
                                gclass40_1.genum78_0 = (GEnum78)Convert.ToInt32(row["TransponderActive"]);
                                gclass40_1.int_20 = Convert.ToInt32(row["HullNumber"]);
                                gclass40_1.LinkedSquadronID = Convert.ToInt32(row["AssignedSquadronID"]);
                                gclass40_1.int_23 = Convert.ToInt32(row["DecoyThreshold"]);
                                gclass40_1.int_24 = Convert.ToInt32(row["DesignateAsTarget"]);
                                gclass40_1.decimal_1 = Convert.ToDecimal(row["Constructed"]);
                                gclass40_1.decimal_2 = Convert.ToDecimal(row["CrewMorale"]);
                                gclass40_1.decimal_3 = Convert.ToDecimal(row["CurrentShieldStrength"]);
                                gclass40_1.decimal_4 = Convert.ToDecimal(row["CurrentMaintSupplies"]);
                                gclass40_1.decimal_14 = Convert.ToDecimal(row["Fuel"]);
                                gclass40_1.decimal_15 = Convert.ToDecimal(row["GradePoints"]);
                                gclass40_1.decimal_5 = Convert.ToDecimal(row["LastLaunchTime"]);
                                gclass40_1.decimal_6 = Convert.ToDecimal(row["LastOverhaul"]);
                                gclass40_1.decimal_7 = Convert.ToDecimal(row["LastShoreLeave"]);
                                gclass40_1.decimal_8 = Convert.ToDecimal(row["LaunchMorale"]);
                                gclass40_1.decimal_16 = Convert.ToDecimal(row["TFPoints"]);
                                gclass40_1.decimal_19 = Convert.ToDecimal(row["LastMissileHitTime"]);
                                gclass40_1.decimal_20 = Convert.ToDecimal(row["LastBeamHitTime"]);
                                gclass40_1.decimal_18 = Convert.ToDecimal(row["LastShipDamageTime"]);
                                gclass40_1.decimal_21 = Convert.ToDecimal(row["LastPenetratingDamageTime"]);
                                gclass40_1.decimal_9 = Convert.ToDecimal(row["OverhaulFactor"]);
                                gclass40_1.decimal_17 = Convert.ToDecimal(row["BioEnergy"]);
                                gclass40_1.decimal_10 = Convert.ToDecimal(row["DistanceTravelled"]);
                                gclass40_1.decimal_11 = Convert.ToDecimal(row["LoadDistance"]);
                                gclass40_1.decimal_13 = Convert.ToDecimal(row["LastFiringTime"]);
                                gclass40_1.decimal_12 = Convert.ToDecimal(row["LastTransitTime"]);
                                gclass40_1.bool_8 = Convert.ToBoolean(row["ActiveSensorsOn"]);
                                gclass40_1.bool_9 = Convert.ToBoolean(row["Destroyed"]);
                                gclass40_1.bool_10 = Convert.ToBoolean(row["ShieldsActive"]);
                                gclass40_1.bool_11 = Convert.ToBoolean(row["ScrapFlag"]);
                                gclass40_1.bool_14 = Convert.ToBoolean(row["AutomatedDamageControl"]);
                                gclass40_1.ShipName = row["ShipName"].ToString();
                                gclass40_1.string_0 = row["ShipNotes"].ToString();
                                gclass40_1.gclass123_0 = new AllMineralsValue(this);
                                if (gclass40_1.gclass21_0.NPR)
                                    gclass40_1.gclass5_0 = new GClass5(this, gclass40_1);
                                this.FCTShipDataDictionary.Add(gclass40_1.int_8, gclass40_1);
                            }
                        }
                    }
                }
            }

            foreach (FCTShipData40 gclass40 in this.FCTShipDataDictionary.Values)
            {
                if (this.FCTShipDataDictionary.ContainsKey(gclass40.int_27))
                    gclass40.gclass40_0 = this.FCTShipDataDictionary[gclass40.int_27];
                if (this.FCTShipDataDictionary.ContainsKey(gclass40.int_26))
                    gclass40.gclass40_1 = this.FCTShipDataDictionary[gclass40.int_26];
                if (this.FCTShipDataDictionary.ContainsKey(gclass40.int_28))
                    gclass40.gclass40_2 = this.FCTShipDataDictionary[gclass40.int_28];
                if (this.FCTShipDataDictionary.ContainsKey(gclass40.int_30))
                    gclass40.gclass40_3 = this.FCTShipDataDictionary[gclass40.int_30];
            }

            foreach (NavalAdminCommand gclass83 in this.NavalAdminCommands.Values)
            {
                if (gclass83.int_4 != 0 && this.FCTShipDataDictionary.ContainsKey(gclass83.int_4))
                    gclass83.gclass40_0 = this.FCTShipDataDictionary[gclass83.int_4];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1201);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1202);
        }
    }

    public void method_249()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_Contacts WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass65 gclass65 = new GClass65(this);
                int int32_1 = Convert.ToInt32(row["SystemID"]);
                if (this.SystemDataDictionary.ContainsKey(int32_1))
                {
                    gclass65.gclass200_0 = this.SystemDataDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["ContactRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        gclass65.gclass21_0 = this.FCTRaceRecordDic[int32_2];
                        int int32_3 = Convert.ToInt32(row["DetectRaceID"]);
                        if (this.FCTRaceRecordDic.ContainsKey(int32_3))
                        {
                            gclass65.gclass21_1 = this.FCTRaceRecordDic[int32_3];
                            gclass65.int_0 = Convert.ToInt32(row["UniqueID"]);
                            gclass65.int_1 = Convert.ToInt32(row["ContactID"]);
                            gclass65.int_2 = Convert.ToInt32(row["ContactNumber"]);
                            gclass65.int_3 = Convert.ToInt32(row["Resolution"]);
                            gclass65.int_4 = Convert.ToInt32(row["ContinualContactTime"]);
                            gclass65.int_5 = Convert.ToInt32(row["Speed"]);
                            gclass65.genum10_0 = (GEnum10)Convert.ToInt32(row["ContactMethod"]);
                            gclass65.auroraContactType_0 = (AuroraContactType)Convert.ToInt32(row["ContactType"]);
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
                                case AuroraContactType.GroundUnit:
                                case AuroraContactType.STOGroundUnit:
                                case AuroraContactType.Shipyard:
                                    if (this.PopulationDataDictionary.ContainsKey(gclass65.int_1))
                                    {
                                        gclass65.gclass146_0 = this.PopulationDataDictionary[gclass65.int_1];
                                        break;
                                    }

                                    break;
                            }

                            gclass65.decimal_0 = Convert.ToDecimal(row["ContactStrength"]);
                            gclass65.decimal_1 = Convert.ToDecimal(row["CreationTime"]);
                            gclass65.decimal_2 = Convert.ToDecimal(row["Reestablished"]);
                            gclass65.decimal_3 = Convert.ToDecimal(row["LastUpdate"]);
                            gclass65.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass65.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass65.double_2 = Convert.ToDouble(row["LastXcor"]);
                            gclass65.double_3 = Convert.ToDouble(row["LastYcor"]);
                            gclass65.double_4 = Convert.ToDouble(row["IncrementStartX"]);
                            gclass65.double_5 = Convert.ToDouble(row["IncrementStartY"]);
                            gclass65.bool_0 = Convert.ToBoolean(row["Msg"]);
                            gclass65.string_0 = row["ContactName"].ToString();
                            this.dictionary_28.Add(gclass65.int_0, gclass65);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1203);
        }
    }

    private void method_250()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_WreckTech WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass234 gclass234 = new GClass234();
                int int32_1 = Convert.ToInt32(row["WreckID"]);
                if (this.dictionary_29.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["TechID"]);
                    if (this.TechDataDictionary.ContainsKey(int32_2))
                    {
                        gclass234.gclass164_0 = this.TechDataDictionary[int32_2];
                        gclass234.decimal_0 = Convert.ToDecimal(row["Percentage"]);
                        this.dictionary_29[int32_1].list_0.Add(gclass234);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1204);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1205);
        }
    }

    private void method_251()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_DamageControlQueue WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass26 gclass26 = new GClass26();
                int int32_1 = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(int32_1))
                {
                    gclass26.gclass40_0 = this.FCTShipDataDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["ComponentID"]);
                    if (this.ComponentDataDictionary.ContainsKey(int32_2))
                    {
                        gclass26.gclass230_0 = this.ComponentDataDictionary[int32_2];
                        gclass26.int_0 = Convert.ToInt32(row["RepairOrder"]);
                        gclass26.gclass40_0.list_13.Add(gclass26);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1206);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1207);
        }
    }

    private void method_252()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_WreckComponents where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass235 gclass235 = new GClass235();
                int int32_1 = Convert.ToInt32(row["WreckID"]);
                if (this.dictionary_29.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["ComponentID"]);
                    if (this.ComponentDataDictionary.ContainsKey(int32_2))
                    {
                        gclass235.gclass230_0 = this.ComponentDataDictionary[int32_2];
                        gclass235.int_0 = Convert.ToInt32(row["Amount"]);
                        this.dictionary_29[int32_1].list_1.Add(gclass235);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1208);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1209);
        }
    }

    public void method_253()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Wrecks WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass233 gclass233 = new GClass233(this);
                int int32_1 = Convert.ToInt32(row["SystemID"]);
                if (this.SystemDataDictionary.ContainsKey(int32_1))
                {
                    gclass233.gclass200_0 = this.SystemDataDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        gclass233.gclass21_0 = this.FCTRaceRecordDic[int32_2];
                        int int32_3 = Convert.ToInt32(row["ClassID"]);
                        if (this.dictionary_3.ContainsKey(int32_3))
                        {
                            gclass233.gclass22_0 = this.dictionary_3[int32_3];
                            int int32_4 = Convert.ToInt32(row["OrbitBodyID"]);
                            if (this.SystemBodyRecordDic.ContainsKey(int32_4))
                                gclass233.gclass1_0 = this.SystemBodyRecordDic[int32_4];
                            gclass233.int_0 = Convert.ToInt32(row["WreckID"]);
                            gclass233.int_1 = Convert.ToInt32(row["ShipID"]);
                            gclass233.decimal_0 = Convert.ToDecimal(row["Size"]);
                            gclass233.int_2 = Convert.ToInt32(row["EffectiveSize"]);
                            gclass233.int_3 = Convert.ToInt32(row["StarSwarmHatching"]);
                            gclass233.int_4 = Convert.ToInt32(row["QueenStatus"]);
                            gclass233.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass233.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass233.gclass123_0 = new AllMineralsValue(this);
                            gclass233.gclass123_0.Duranium = Convert.ToDecimal(row["Duranium"]);
                            gclass233.gclass123_0.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                            gclass233.gclass123_0.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                            gclass233.gclass123_0.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                            gclass233.gclass123_0.Boronide = Convert.ToDecimal(row["Boronide"]);
                            gclass233.gclass123_0.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                            gclass233.gclass123_0.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                            gclass233.gclass123_0.Sorium = Convert.ToDecimal(row["Sorium"]);
                            gclass233.gclass123_0.Uridium = Convert.ToDecimal(row["Uridium"]);
                            gclass233.gclass123_0.Corundium = Convert.ToDecimal(row["Corundium"]);
                            gclass233.gclass123_0.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                            this.dictionary_29.Add(gclass233.int_0, gclass233);
                        }
                    }
                }
            }

            this.method_250();
            this.method_252();
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1210);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1211);
        }
    }

    public void method_254()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_IndustrialProjects WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass156 gclass156 = new GClass156(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass156.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                    {
                        gclass156.gclass146_0 = this.PopulationDataDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["SpeciesID"]);
                        if (this.SpeciesDictionary.ContainsKey(int32_3))
                        {
                            gclass156.gclass194_0 = this.SpeciesDictionary[int32_3];
                            WealthUsage int32_4 = (WealthUsage)Convert.ToInt32(row["WealthUse"]);
                            if (this.WealthUsageDictionary.ContainsKey(int32_4))
                            {
                                gclass156.gclass150_0 = this.WealthUsageDictionary[int32_4];
                                int int32_5 = Convert.ToInt32(row["RefitClassID"]);
                                if (this.dictionary_3.ContainsKey(int32_5))
                                    gclass156.gclass22_1 = this.dictionary_3[int32_5];
                                gclass156.int_0 = Convert.ToInt32(row["ProjectID"]);
                                gclass156.int_1 = Convert.ToInt32(row["FuelRequired"]);
                                gclass156.int_2 = Convert.ToInt32(row["Queue"]);
                                gclass156.auroraProductionType_0 =
                                    (AuroraProductionType)Convert.ToInt32(row["ProductionType"]);
                                gclass156.decimal_3 = Convert.ToDecimal(row["Percentage"]);
                                gclass156.decimal_0 = Convert.ToDecimal(row["Amount"]);
                                gclass156.decimal_1 = Convert.ToDecimal(row["PartialCompletion"]);
                                gclass156.decimal_2 = Convert.ToDecimal(row["ProdPerUnit"]);
                                gclass156.bool_0 = Convert.ToBoolean(row["Pause"]);
                                gclass156.string_0 = row["Description"].ToString();
                                switch (gclass156.auroraProductionType_0)
                                {
                                    case AuroraProductionType.Construction:
                                        AuroraInstallationType int32_6 =
                                            (AuroraInstallationType)Convert.ToInt32(row["ProductionID"]);
                                        if (this.PlanetaryInstallationDictionary.ContainsKey(int32_6))
                                            gclass156.gclass157_0 = this.PlanetaryInstallationDictionary[int32_6];
                                        gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Construction;
                                        break;
                                    case AuroraProductionType.Ordnance:
                                        int int32_7 = Convert.ToInt32(row["ProductionID"]);
                                        if (this.RaceMissileDictionary.ContainsKey(int32_7))
                                            gclass156.gclass129_0 = this.RaceMissileDictionary[int32_7];
                                        gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Ordnance;
                                        break;
                                    case AuroraProductionType.Fighter:
                                        int int32_8 = Convert.ToInt32(row["ProductionID"]);
                                        if (this.dictionary_3.ContainsKey(int32_8))
                                            gclass156.gclass22_0 = this.dictionary_3[int32_8];
                                        gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Fighter;
                                        break;
                                    case AuroraProductionType.Components:
                                        int int32_9 = Convert.ToInt32(row["ProductionID"]);
                                        if (this.ComponentDataDictionary.ContainsKey(int32_9))
                                            gclass156.gclass230_0 = this.ComponentDataDictionary[int32_9];
                                        gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Construction;
                                        break;
                                    case AuroraProductionType.SpaceStation:
                                        int int32_10 = Convert.ToInt32(row["ProductionID"]);
                                        if (this.dictionary_3.ContainsKey(int32_10))
                                            gclass156.gclass22_0 = this.dictionary_3[int32_10];
                                        gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Construction;
                                        break;
                                }

                                gclass156.gclass123_0 = new AllMineralsValue(this);
                                gclass156.gclass123_0.Duranium = Convert.ToDecimal(row["Duranium"]);
                                gclass156.gclass123_0.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                                gclass156.gclass123_0.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                                gclass156.gclass123_0.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                                gclass156.gclass123_0.Boronide = Convert.ToDecimal(row["Boronide"]);
                                gclass156.gclass123_0.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                                gclass156.gclass123_0.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                                gclass156.gclass123_0.Sorium = Convert.ToDecimal(row["Sorium"]);
                                gclass156.gclass123_0.Uridium = Convert.ToDecimal(row["Uridium"]);
                                gclass156.gclass123_0.Corundium = Convert.ToDecimal(row["Corundium"]);
                                gclass156.gclass123_0.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                                if (gclass156.gclass146_0 != null)
                                    gclass156.gclass146_0.dictionary_2.Add(gclass156.int_0, gclass156);
                            }
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1212);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1213);
        }
    }

    public void method_255()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MissileSalvo where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass132 gclass132 = new GClass132(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass132.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["MissileID"]);
                    if (this.RaceMissileDictionary.ContainsKey(int32_2))
                    {
                        gclass132.gclass129_0 = this.RaceMissileDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["SystemID"]);
                        if (this.SystemDataDictionary.ContainsKey(int32_3))
                        {
                            gclass132.gclass200_0 = this.SystemDataDictionary[int32_3];
                            int int32_4 = Convert.ToInt32(row["ShipID"]);
                            if (this.FCTShipDataDictionary.ContainsKey(int32_4))
                                gclass132.gclass40_0 = this.FCTShipDataDictionary[int32_4];
                            int int32_5 = Convert.ToInt32(row["OrbitBodyID"]);
                            if (this.SystemBodyRecordDic.ContainsKey(int32_5))
                                gclass132.gclass1_0 = this.SystemBodyRecordDic[int32_5];
                            int int32_6 = Convert.ToInt32(row["FireControlID"]);
                            if (this.ComponentDataDictionary.ContainsKey(int32_6))
                                gclass132.gclass230_0 = this.ComponentDataDictionary[int32_6];
                            gclass132.int_0 = Convert.ToInt32(row["TargetID"]);
                            gclass132.int_1 = Convert.ToInt32(row["MissileSalvoID"]);
                            gclass132.int_2 = Convert.ToInt32(row["FCNum"]);
                            gclass132.double_9 = Convert.ToInt32(row["MissileSpeed"]);
                            gclass132.genum58_0 = (GEnum58)Convert.ToInt32(row["HomingMethod"]);
                            gclass132.decimal_0 = Convert.ToDecimal(row["LaunchTime"]);
                            gclass132.decimal_2 = Convert.ToDecimal(row["CurrentDetonationRange"]);
                            gclass132.double_8 = Convert.ToDouble(row["ModifierToHit"]);
                            gclass132.decimal_1 = Convert.ToDecimal(row["Endurance"]);
                            gclass132.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass132.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass132.double_2 = Convert.ToDouble(row["LastXcor"]);
                            gclass132.double_3 = Convert.ToDouble(row["LastYcor"]);
                            gclass132.double_4 = Convert.ToDouble(row["LastTargetX"]);
                            gclass132.double_5 = Convert.ToDouble(row["LastTargetY"]);
                            gclass132.double_6 = Convert.ToDouble(row["IncrementStartX"]);
                            gclass132.double_7 = Convert.ToDouble(row["IncrementStartY"]);
                            this.dictionary_6.Add(gclass132.int_1, gclass132);
                            if (gclass132.int_0 > 0)
                            {
                                gclass132.auroraContactType_0 = (AuroraContactType)Convert.ToInt32(row["TargetType"]);
                                switch (gclass132.auroraContactType_0)
                                {
                                    case AuroraContactType.Ship:
                                        if (this.FCTShipDataDictionary.ContainsKey(gclass132.int_0))
                                        {
                                            gclass132.gclass40_1 = this.FCTShipDataDictionary[gclass132.int_0];
                                            continue;
                                        }

                                        continue;
                                    case AuroraContactType.Salvo:
                                        if (this.dictionary_6.ContainsKey(gclass132.int_0))
                                        {
                                            gclass132.gclass132_0 = this.dictionary_6[gclass132.int_0];
                                            continue;
                                        }

                                        continue;
                                    case AuroraContactType.Population:
                                    case AuroraContactType.GroundUnit:
                                    case AuroraContactType.STOGroundUnit:
                                    case AuroraContactType.Shipyard:
                                        if (this.PopulationDataDictionary.ContainsKey(gclass132.int_0))
                                        {
                                            gclass132.gclass146_0 = this.PopulationDataDictionary[gclass132.int_0];
                                            continue;
                                        }

                                        continue;
                                    case AuroraContactType.WayPoint:
                                        if (this.dictionary_13.ContainsKey(gclass132.int_0))
                                        {
                                            gclass132.gclass214_0 = this.dictionary_13[gclass132.int_0];
                                            continue;
                                        }

                                        continue;
                                    default:
                                        continue;
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1214);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1215);
        }
    }

    public void method_256()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Missile where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["SalvoID"]);
                if (this.dictionary_6.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["MissileNumber"]);
                    int int32_3 = Convert.ToInt32(row["RemainingDecoys"]);
                    this.dictionary_6[int32_1].dictionary_2.Add(int32_2, int32_3);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3663);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3664);
        }
    }

    public void method_257()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MissileType where GameID = {this.GameID.ToString()}").Rows)
            {
                RaceMissile gclass129 = new RaceMissile(this);
                int int32 = Convert.ToInt32(row["EngineID"]);
                if (this.ComponentDataDictionary.ContainsKey(int32))
                    gclass129.gclass230_0 = this.ComponentDataDictionary[int32];
                gclass129.Name = row["Name"].ToString();
                gclass129.int_0 = Convert.ToInt32(row["MissileID"]);
                if (this.TechDataDictionary.ContainsKey(gclass129.int_0))
                {
                    gclass129.gclass164_0 = this.TechDataDictionary[gclass129.int_0];
                    gclass129.int_1 = Convert.ToInt32(row["MissileSeriesID"]);
                    gclass129.int_9 = Convert.ToInt32(row["NumEngines"]);
                    gclass129.int_2 = Convert.ToInt32(row["MissilesRequired"]);
                    gclass129.int_3 = Convert.ToInt32(row["MissilesAvailable"]);
                    gclass129.int_4 = Convert.ToInt32(row["FuelRequired"]);
                    gclass129.int_5 = Convert.ToInt32(row["SensorResolution"]);
                    gclass129.int_6 = Convert.ToInt32(row["SensorRange"]);
                    gclass129.decimal_22 = Convert.ToDecimal(row["TotalFlightTime"]);
                    gclass129.int_8 = Convert.ToInt32(row["ECCM"]);
                    gclass129.int_15 = Convert.ToInt32(row["SecondStageID"]);
                    gclass129.int_16 = Convert.ToInt32(row["NumSS"]);
                    gclass129.int_17 = Convert.ToInt32(row["SeparationRange"]);
                    gclass129.decimal_26 = Convert.ToDecimal(row["ATG"]);
                    gclass129.int_10 = Convert.ToInt32(row["Retargeting"]);
                    gclass129.int_11 = Convert.ToInt32(row["LaserWarheadRangeModifier"]);
                    gclass129.int_7 = Convert.ToInt32(row["NumDecoys"]);
                    gclass129.int_12 = Convert.ToInt32(row["MissileECM"]);
                    gclass129.int_13 = Convert.ToInt32(row["MultipleWarheads"]);
                    gclass129.int_14 = Convert.ToInt32(row["ShipDecoy"]);
                    gclass129.decimal_1 = Convert.ToDecimal(row["LaserWarhead"]);
                    gclass129.decimal_24 = Convert.ToDecimal(row["MinDetonationRange"]);
                    gclass129.decimal_25 = Convert.ToDecimal(row["MaxDetonationRange"]);
                    gclass129.decimal_0 = Convert.ToDecimal(row["WarheadStrength"]);
                    gclass129.decimal_2 = Convert.ToDecimal(row["RadDamage"]);
                    gclass129.decimal_21 = Convert.ToDecimal(row["Endurance"]);
                    gclass129.decimal_3 = Convert.ToDecimal(row["Cost"]);
                    gclass129.decimal_4 = Convert.ToDecimal(row["Size"]);
                    gclass129.decimal_5 = Convert.ToDecimal(row["Speed"]);
                    gclass129.double_5 = Convert.ToDouble(row["MaxRange"]);
                    gclass129.double_4 = gclass129.double_5;
                    gclass129.double_0 = Convert.ToDouble(row["SensorStrength"]);
                    gclass129.double_1 = Convert.ToDouble(row["ThermalStrength"]);
                    gclass129.double_2 = Convert.ToDouble(row["EMStrength"]);
                    gclass129.double_3 = Convert.ToDouble(row["EMSensitivity"]);
                    gclass129.decimal_16 = Convert.ToDecimal(row["GeoStrength"]);
                    gclass129.decimal_6 = Convert.ToDecimal(row["MSPReactor"]);
                    gclass129.decimal_7 = Convert.ToDecimal(row["MSPWarhead"]);
                    gclass129.decimal_8 = Convert.ToDecimal(row["MSPEngine"]);
                    gclass129.decimal_9 = Convert.ToDecimal(row["MSPFuel"]);
                    gclass129.decimal_10 = Convert.ToDecimal(row["MSPActive"]);
                    gclass129.decimal_11 = Convert.ToDecimal(row["MSPThermal"]);
                    gclass129.decimal_12 = Convert.ToDecimal(row["MSPEM"]);
                    gclass129.decimal_13 = Convert.ToDecimal(row["MSPGeo"]);
                    gclass129.decimal_17 = Convert.ToDecimal(row["GroundAP"]);
                    gclass129.decimal_18 = Convert.ToDecimal(row["GroundDamage"]);
                    gclass129.decimal_20 = Convert.ToDecimal(row["GroundBaseDamage"]);
                    gclass129.decimal_19 = Convert.ToDecimal(row["GroundShots"]);
                    gclass129.decimal_23 = Convert.ToDecimal(row["PowerMod"]);
                    gclass129.decimal_14 = Convert.ToDecimal(row["MSPDecoys"]);
                    gclass129.decimal_15 = Convert.ToInt32(row["MSPMultipleWarheads"]);
                    gclass129.gclass123_0 = new AllMineralsValue(this);
                    gclass129.gclass123_0.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                    gclass129.gclass123_0.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                    gclass129.gclass123_0.Boronide = Convert.ToDecimal(row["Boronide"]);
                    gclass129.gclass123_0.Uridium = Convert.ToDecimal(row["Uridium"]);
                    gclass129.gclass123_0.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                    gclass129.bool_0 = Convert.ToBoolean(row["PrecursorMissile"]);
                    gclass129.bool_1 = Convert.ToBoolean(row["PreTNT"]);
                    this.RaceMissileDictionary.Add(gclass129.int_0, gclass129);
                }
                else
                {
                    int num = (int)MessageBox.Show(
                        $"Tech system does not exist for {gclass129.Name} so it cannot be loaded");
                }
            }

            foreach (RaceMissile gclass129 in this.RaceMissileDictionary.Values)
            {
                if (gclass129.int_15 > 0 && this.RaceMissileDictionary.ContainsKey(gclass129.int_15))
                {
                    gclass129.gclass129_0 = this.RaceMissileDictionary[gclass129.int_15];
                    gclass129.double_4 = gclass129.double_5 + gclass129.gclass129_0.double_4;
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1216);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1217);
        }
    }

    public void method_259()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AtmosphericGas where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass224 gclass224 = new GClass224();
                AtmosphericGas int32 = (AtmosphericGas)Convert.ToInt32(row["AtmosGasID"]);
                if (this.AtmosphericGasDictionary.ContainsKey(int32))
                {
                    gclass224.gclass223_0 = this.AtmosphericGasDictionary[int32];
                    gclass224.int_0 = Convert.ToInt32(row["SystemBodyID"]);
                    gclass224.double_0 = Convert.ToDouble(row["AtmosGasAmount"]);
                    gclass224.double_1 = Convert.ToDouble(row["GasAtm"]);
                    gclass224.bool_0 = Convert.ToBoolean(row["FrozenOut"]);
                    if (this.SystemBodyRecordDic.Keys.Contains(gclass224.int_0))
                        this.SystemBodyRecordDic[gclass224.int_0].list_0.Add(gclass224);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1220);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1221);
        }
    }

    public void method_260()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PopulationWeapon WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass130 gclass130 = new GClass130();
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (this.RaceMissileDictionary.ContainsKey(int32_1))
                {
                    gclass130.gclass129_0 = this.RaceMissileDictionary[int32_1];
                    gclass130.int_0 = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                        this.PopulationDataDictionary[int32_2].list_1.Add(gclass130);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1222);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1223);
        }
    }

    public void method_261()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipWeapon WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass130 gclass130 = new GClass130();
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (this.RaceMissileDictionary.ContainsKey(int32_1))
                {
                    gclass130.gclass129_0 = this.RaceMissileDictionary[int32_1];
                    gclass130.int_0 = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["ShipID"]);
                    if (this.FCTShipDataDictionary.Keys.Contains(int32_2))
                        this.FCTShipDataDictionary[int32_2].list_10.Add(gclass130);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1224);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1225);
        }
    }

    public void method_262()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ClassOrdnanceTemplate where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (this.RaceMissileDictionary.ContainsKey(int32_1))
                {
                    GClass130 gclass130 = new GClass130();
                    gclass130.gclass129_0 = this.RaceMissileDictionary[int32_1];
                    gclass130.int_0 = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["ShipClassID"]);
                    if (this.dictionary_3.Keys.Contains(int32_2))
                        this.dictionary_3[int32_2].list_0.Add(gclass130);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1226);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1227);
        }
    }

    public void method_263()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"SELECT * FROM FCT_ShipOrdnanceTemplate where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (this.RaceMissileDictionary.ContainsKey(int32_1))
                {
                    GClass130 gclass130 = new GClass130();
                    gclass130.gclass129_0 = this.RaceMissileDictionary[int32_1];
                    gclass130.int_0 = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["ShipID"]);
                    if (this.FCTShipDataDictionary.Keys.Contains(int32_2))
                        this.FCTShipDataDictionary[int32_2].list_9.Add(gclass130);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1228);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1229);
        }
    }

    public void method_264()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ClassComponent where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass228 gclass228 = new GClass228();
                gclass228.int_1 = Convert.ToInt32(row["ClassID"]);
                if (this.dictionary_3.ContainsKey(gclass228.int_1))
                {
                    gclass228.int_0 = Convert.ToInt32(row["ComponentID"]);
                    if (this.ComponentDataDictionary.ContainsKey(gclass228.int_0))
                    {
                        gclass228.decimal_0 = Convert.ToDecimal(row["NumComponent"]);
                        gclass228.int_2 = Convert.ToInt32(row["ChanceToHit"]);
                        gclass228.int_3 = Convert.ToInt32(row["ElectronicCTH"]);
                        gclass228.gclass230_0 = this.ComponentDataDictionary[gclass228.int_0];
                        this.dictionary_3[gclass228.int_1].dictionary_0.Add(gclass228.int_0, gclass228);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1230);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1231);
        }
    }

    public void method_265()
    {
        try
        {
            SQLiteDatabaseC1181 sqLiteDatabaseC1181 = new SQLiteDatabaseC1181();
            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery($"select * FROM FCT_DamagedComponent where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass178 gclass178 = new GClass178();
                int int32_1 = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["ComponentID"]);
                    if (this.ComponentDataDictionary.ContainsKey(int32_2))
                    {
                        gclass178.gclass230_0 = this.ComponentDataDictionary[int32_2];
                        gclass178.int_0 = Convert.ToInt32(row["Number"]);
                        this.FCTShipDataDictionary[int32_1].list_12.Add(gclass178);
                    }
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery($"select * FROM FCT_ArmourDamage").Rows)
            {
                int int32_3 = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(int32_3))
                {
                    int int32_4 = Convert.ToInt32(row["ArmourColumn"]);
                    int int32_5 = Convert.ToInt32(row["Damage"]);
                    this.FCTShipDataDictionary[int32_3].dictionary_5.Add(int32_4, int32_5);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1232);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1233);
        }
    }

    public void method_266()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ClassSC where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass74 gclass74 = new GClass74();
                int int32_1 = Convert.ToInt32(row["ShipClassID"]);
                int int32_2 = Convert.ToInt32(row["FighterClassID"]);
                if (this.dictionary_3.ContainsKey(int32_1) && this.dictionary_3.ContainsKey(int32_2))
                {
                    gclass74.gclass22_0 = this.dictionary_3[int32_2];
                    gclass74.int_0 = Convert.ToInt32(row["Number"]);
                    this.dictionary_3[int32_1].list_1.Add(gclass74);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1234);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1235);
        }
    }

    public void method_267()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"SELECT * FROM FCT_ClassGroundTemplates where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass75 gclass75 = new GClass75();
                int int32_1 = Convert.ToInt32(row["ShipClassID"]);
                int int32_2 = Convert.ToInt32(row["TemplateID"]);
                if (this.dictionary_3.ContainsKey(int32_1) && this.FormationTemplateRecordDic.ContainsKey(int32_2))
                {
                    gclass75.gclass102_0 = this.FormationTemplateRecordDic[int32_2];
                    gclass75.int_0 = Convert.ToInt32(row["Number"]);
                    this.dictionary_3[int32_1].list_2.Add(gclass75);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3630);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3631);
        }
    }

    public void method_268()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_HullDescription").Rows)
            {
                ShipHull gclass76 = new ShipHull()
                {
                    ShipHullDescriptionID = Convert.ToInt32(row["HullDescriptionID"]),
                    Description = row["Description"].ToString(),
                    Abbreviation = row["HullAbbr"].ToString()
                };
                gclass76.Combined = $"{gclass76.Description}  {gclass76.Abbreviation}";
                this.ShipHullDictionary.Add(gclass76.ShipHullDescriptionID, gclass76);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1236);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1237);
        }
    }

    public void method_269()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_FleetHistory where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass177 gclass177 = new GClass177();
                int int32 = Convert.ToInt32(row["FleetID"]);
                if (this.FleetDictionary.ContainsKey(int32))
                {
                    FleetData gclass85 = this.FleetDictionary[int32];
                    gclass177.decimal_0 = Convert.ToDecimal(row["GameTime"]);
                    gclass177.Description = row["Description"].ToString();
                    gclass177.bool_0 = true;
                    gclass85.list_0.Add(gclass177);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1238);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1239);
        }
    }

    public void method_270()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipHistory where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass177 gclass177 = new GClass177();
                int int32 = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(int32))
                {
                    FCTShipData40 gclass40 = this.FCTShipDataDictionary[int32];
                    gclass177.decimal_0 = Convert.ToDecimal(row["GameTime"]);
                    gclass177.Description = row["Description"].ToString();
                    gclass40.list_11.Add(gclass177);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1240);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1241);
        }
    }

    public void method_271()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_CommanderHistory where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass177 gclass177 = new GClass177();
                int int32 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (this.dictionary_42.ContainsKey(int32))
                    gclass55 = this.dictionary_42[int32];
                else if (this.dictionary_43.ContainsKey(int32))
                    gclass55 = this.dictionary_43[int32];
                else
                    continue;
                gclass177.decimal_0 = Convert.ToDecimal(row["GameTime"]);
                gclass177.Description = row["HistoryText"].ToString();
                gclass55.list_0.Add(gclass177);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1242);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1243);
        }
    }

    public void method_273()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"SELECT * FROM FCT_CommanderMeasurement where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass54 gclass54 = new GClass54();
                int int32 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (this.dictionary_42.ContainsKey(int32))
                    gclass55 = this.dictionary_42[int32];
                else if (this.dictionary_43.ContainsKey(int32))
                    gclass55 = this.dictionary_43[int32];
                else
                    continue;
                gclass54.auroraMeasurementType_0 = (AuroraMeasurementType)Convert.ToInt32(row["MeasurementType"]);
                gclass54.decimal_0 = Convert.ToDecimal(row["Amount"]);
                gclass55.dictionary_2.Add(gclass54.auroraMeasurementType_0, gclass54);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1246);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1247);
        }
    }

    public void method_274()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipMeasurement where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass54 gclass54 = new GClass54();
                int int32 = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(int32))
                {
                    gclass54.auroraMeasurementType_0 = (AuroraMeasurementType)Convert.ToInt32(row["MeasurementType"]);
                    gclass54.decimal_0 = Convert.ToDecimal(row["Amount"]);
                    gclass54.bool_0 = Convert.ToBoolean(row["StrikeGroup"]);
                    this.FCTShipDataDictionary[int32].list_0.Add(gclass54);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1248);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1249);
        }
    }

    public void method_275()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MedalConditionAssignment where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass44 gclass44 = new GClass44();
                int int32_1 = Convert.ToInt32(row["MedalID"]);
                if (this.RaceMedalDictionary.ContainsKey(int32_1))
                {
                    gclass44.gclass42_0 = this.RaceMedalDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["MedalConditionID"]);
                    if (this.MedalConditionDictionary.ContainsKey(int32_2))
                    {
                        gclass44.gclass43_0 = this.MedalConditionDictionary[int32_2];
                        this.list_1.Add(gclass44);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1250);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1251);
        }
    }

    public void method_276()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_CommanderMedal where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass53 gclass53 = new GClass53();
                int int32_1 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (this.dictionary_42.ContainsKey(int32_1))
                    gclass55 = this.dictionary_42[int32_1];
                else if (this.dictionary_43.ContainsKey(int32_1))
                    gclass55 = this.dictionary_43[int32_1];
                else
                    continue;
                int int32_2 = Convert.ToInt32(row["MedalID"]);
                if (this.RaceMedalDictionary.ContainsKey(int32_2))
                {
                    gclass53.gclass42_0 = this.RaceMedalDictionary[int32_2];
                    gclass53.int_0 = Convert.ToInt32(row["NumAwarded"]);
                    gclass53.string_0 = row["AwardReason"].ToString();
                    gclass55.dictionary_1.Add(int32_2, gclass53);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1252);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1253);
        }
    }

    public void method_277()
    {
        try
        {
            SQLiteDatabaseC1181 sqLiteDatabaseC1181 = new SQLiteDatabaseC1181();
            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery($"select * FROM FCT_StandingOrderTemplate where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass135 gclass135 = new GClass135();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32))
                {
                    gclass135.int_0 = Convert.ToInt32(row["TemplateID"]);
                    gclass135.string_0 = row["TemplateName"].ToString();
                    this.FCTRaceRecordDic[int32].dictionary_9.Add(gclass135.int_0, gclass135);
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery($"select * FROM FCT_StandingOrderTemplateOrder where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["TemplateID"]);
                    if (this.FCTRaceRecordDic[int32_1].dictionary_9.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["Priority"]);
                        int int32_4 = Convert.ToInt32(row["CreateFWP"]);
                        AuroraStandingOrder int32_5 = (AuroraStandingOrder)Convert.ToInt32(row["OrderID"]);
                        AuroraFleetCondition int32_6 = (AuroraFleetCondition)Convert.ToInt32(row["ConditionID"]);
                        if (int32_6 == AuroraFleetCondition.NoCondition)
                            this.FCTRaceRecordDic[int32_1].dictionary_9[int32_2].dictionary_0
                                .Add(int32_3, this.StandingOrderDictionary[int32_5]);
                        else
                            this.FCTRaceRecordDic[int32_1].dictionary_9[int32_2].dictionary_1.Add(int32_3,
                                new FleetConditionalOrder()
                                {
                                    Condition = int32_6,
                                    StandingOrder = int32_5,
                                    CreateFleetWaypoint = int32_4
                                });
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3911);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3912);
        }
    }

    public void method_280()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Shipyard WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass193 gclass193 = new GClass193(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass193.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                        gclass193.gclass146_0 = this.PopulationDataDictionary[int32_2];
                    int int32_3 = Convert.ToInt32(row["ParentShipID"]);
                    if (this.FCTShipDataDictionary.ContainsKey(int32_3))
                        gclass193.gclass40_1 = this.FCTShipDataDictionary[int32_3];
                    int int32_4 = Convert.ToInt32(row["TractorParentShipID"]);
                    if (this.FCTShipDataDictionary.ContainsKey(int32_4))
                        gclass193.gclass40_0 = this.FCTShipDataDictionary[int32_4];
                    int int32_5 = Convert.ToInt32(row["BuildClassID"]);
                    if (this.dictionary_3.ContainsKey(int32_5))
                        gclass193.gclass22_0 = this.dictionary_3[int32_5];
                    int int32_6 = Convert.ToInt32(row["RetoolClassID"]);
                    if (this.dictionary_3.ContainsKey(int32_6))
                        gclass193.gclass22_1 = this.dictionary_3[int32_6];
                    int int32_7 = Convert.ToInt32(row["DefaultFleetID"]);
                    if (this.FleetDictionary.ContainsKey(int32_7))
                        gclass193.gclass85_0 = this.FleetDictionary[int32_7];
                    int int32_8 = Convert.ToInt32(row["DefaultNavalAdminID"]);
                    if (this.NavalAdminCommands.ContainsKey(int32_8))
                        gclass193.gclass83_0 = this.NavalAdminCommands[int32_8];
                    gclass193.int_0 = Convert.ToInt32(row["ShipyardID"]);
                    gclass193.int_1 = Convert.ToInt32(row["Slipways"]);
                    gclass193.int_2 = Convert.ToInt32(row["CapacityTarget"]);
                    gclass193.int_3 = Convert.ToInt32(row["UseAdmin"]);
                    gclass193.auroraShipyardType_0 = (AuroraShipyardType)Convert.ToInt32(row["SYType"]);
                    gclass193.auroraShipyardUpgradeType_0 = (AuroraShipyardUpgradeType)Convert.ToInt32(row["TaskType"]);
                    gclass193.decimal_0 = Convert.ToDecimal(row["Capacity"]);
                    gclass193.decimal_1 = Convert.ToDecimal(row["RequiredBP"]);
                    gclass193.decimal_2 = Convert.ToDecimal(row["CompletedBP"]);
                    gclass193.double_0 = Convert.ToDouble(row["Xcor"]);
                    gclass193.double_1 = Convert.ToDouble(row["Ycor"]);
                    gclass193.bool_0 = Convert.ToBoolean(row["PauseActivity"]);
                    gclass193.string_0 = row["ShipyardName"].ToString();
                    this.dictionary_31.Add(gclass193.int_0, gclass193);
                }
            }

            foreach (FCTShipData40 gclass40 in this.FCTShipDataDictionary.Values
                         .Where(gclass40_0 => gclass40_0.int_29 > 0).ToList())
            {
                if (this.dictionary_31.ContainsKey(gclass40.int_29))
                    gclass40.gclass193_0 = this.dictionary_31[gclass40.int_29];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1258);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1259);
        }
    }

    public void method_281()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipyardTask WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass192 gclass192 = new GClass192();
                int int32_1 = Convert.ToInt32(row["ShipyardID"]);
                if (this.dictionary_31.ContainsKey(int32_1))
                {
                    gclass192.gclass193_0 = this.dictionary_31[int32_1];
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        gclass192.gclass21_0 = this.FCTRaceRecordDic[int32_2];
                        int int32_3 = Convert.ToInt32(row["PopulationID"]);
                        if (this.PopulationDataDictionary.ContainsKey(int32_3))
                        {
                            gclass192.gclass146_0 = this.PopulationDataDictionary[int32_3];
                            int int32_4 = Convert.ToInt32(row["ShipID"]);
                            if (this.FCTShipDataDictionary.ContainsKey(int32_4))
                                gclass192.gclass40_0 = this.FCTShipDataDictionary[int32_4];
                            int int32_5 = Convert.ToInt32(row["NavalAdminID"]);
                            if (this.NavalAdminCommands.ContainsKey(int32_5))
                                gclass192.gclass83_0 = this.NavalAdminCommands[int32_5];
                            int int32_6 = Convert.ToInt32(row["ClassID"]);
                            if (this.dictionary_3.ContainsKey(int32_6))
                                gclass192.gclass22_0 = this.dictionary_3[int32_6];
                            int int32_7 = Convert.ToInt32(row["RefitID"]);
                            if (this.dictionary_3.ContainsKey(int32_7))
                                gclass192.gclass22_1 = this.dictionary_3[int32_7];
                            int int32_8 = Convert.ToInt32(row["FleetID"]);
                            if (this.FleetDictionary.ContainsKey(int32_8))
                                gclass192.gclass85_0 = this.FleetDictionary[int32_8];
                            gclass192.int_0 = Convert.ToInt32(row["TaskID"]);
                            gclass192.auroraSYTaskType_0 = (AuroraSYTaskType)Convert.ToInt32(row["TaskTypeID"]);
                            gclass192.decimal_0 = Convert.ToDecimal(row["TotalBP"]);
                            gclass192.decimal_1 = Convert.ToDecimal(row["CompletedBP"]);
                            gclass192.bool_2 = Convert.ToBoolean(row["Paused"]);
                            gclass192.bool_0 = Convert.ToBoolean(row["Freighter"]);
                            gclass192.bool_1 = Convert.ToBoolean(row["NPRShip"]);
                            gclass192.bool_3 = Convert.ToBoolean(row["UseComponents"]);
                            gclass192.string_0 = row["UnitName"].ToString();
                            gclass192.gclass123_0 = new AllMineralsValue(this);
                            gclass192.gclass123_0.Duranium = Convert.ToDecimal(row["Duranium"]);
                            gclass192.gclass123_0.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                            gclass192.gclass123_0.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                            gclass192.gclass123_0.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                            gclass192.gclass123_0.Boronide = Convert.ToDecimal(row["Boronide"]);
                            gclass192.gclass123_0.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                            gclass192.gclass123_0.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                            gclass192.gclass123_0.Sorium = Convert.ToDecimal(row["Sorium"]);
                            gclass192.gclass123_0.Uridium = Convert.ToDecimal(row["Uridium"]);
                            gclass192.gclass123_0.Corundium = Convert.ToDecimal(row["Corundium"]);
                            gclass192.gclass123_0.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                            this.dictionary_32.Add(gclass192.int_0, gclass192);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1260);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1261);
        }
    }

    public void method_282()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PopComponent WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass73 gclass73 = new GClass73();
                int int32 = Convert.ToInt32(row["PopulationID"]);
                if (this.PopulationDataDictionary.ContainsKey(int32))
                {
                    gclass73.int_0 = Convert.ToInt32(row["ComponentID"]);
                    if (this.ComponentDataDictionary.ContainsKey(gclass73.int_0))
                    {
                        gclass73.gclass230_0 = this.ComponentDataDictionary[gclass73.int_0];
                        gclass73.decimal_0 = Convert.ToDecimal(row["Amount"]);
                        this.PopulationDataDictionary[int32].list_2.Add(gclass73);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1262);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1263);
        }
    }

    public void method_283()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PopMDChanges where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32 = Convert.ToInt32(row["PopulationID"]);
                if (this.PopulationDataDictionary.ContainsKey(int32))
                {
                    this.PopulationDataDictionary[int32].gclass123_3.Duranium = Convert.ToDecimal(row["Duranium"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Boronide = Convert.ToDecimal(row["Boronide"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Sorium = Convert.ToDecimal(row["Sorium"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Uridium = Convert.ToDecimal(row["Uridium"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Corundium = Convert.ToDecimal(row["Corundium"]);
                    this.PopulationDataDictionary[int32].gclass123_3.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1264);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1265);
        }
    }

    public void method_284()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Species WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass194 gclass194 = new GClass194(this);
                int int32_1 = Convert.ToInt32(row["HomeworldID"]);
                gclass194.gclass1_0 = !this.SystemBodyRecordDic.ContainsKey(int32_1)
                    ? null
                    : this.SystemBodyRecordDic[int32_1];
                AtmosphericGas int32_2 = (AtmosphericGas)Convert.ToInt32(row["BreatheID"]);
                if (this.AtmosphericGasDictionary.ContainsKey(int32_2))
                {
                    gclass194.gclass223_0 = this.AtmosphericGasDictionary[int32_2];
                    gclass194.int_9 = Convert.ToInt32(row["TechSystemID"]);
                    gclass194.int_0 = Convert.ToInt32(row["SpeciesID"]);
                    gclass194.int_1 = Convert.ToInt32(row["DerivedSpeciesID"]);
                    gclass194.int_2 = Convert.ToInt32(row["Xenophobia"]);
                    gclass194.int_3 = Convert.ToInt32(row["Diplomacy"]);
                    gclass194.int_4 = Convert.ToInt32(row["Translation"]);
                    gclass194.int_5 = Convert.ToInt32(row["Militancy"]);
                    gclass194.int_6 = Convert.ToInt32(row["Expansionism"]);
                    gclass194.int_7 = Convert.ToInt32(row["Determination"]);
                    gclass194.int_8 = Convert.ToInt32(row["Trade"]);
                    gclass194.genum6_0 = (SpecialNPRIDs)Convert.ToInt32(row["SpecialNPRID"]);
                    gclass194.int_11 = Convert.ToInt32(row["GraduationAge"]);
                    gclass194.decimal_0 = Convert.ToDecimal(row["PopulationDensityModifier"]);
                    gclass194.decimal_1 = Convert.ToDecimal(row["PopulationGrowthModifier"]);
                    gclass194.decimal_2 = Convert.ToDecimal(row["ResearchRateModifier"]);
                    gclass194.decimal_3 = Convert.ToDecimal(row["ProductionRateModifier"]);
                    gclass194.double_0 = Convert.ToDouble(row["Oxygen"]);
                    gclass194.double_1 = Convert.ToDouble(row["OxyDev"]);
                    gclass194.double_2 = Convert.ToDouble(row["PressMax"]);
                    gclass194.double_3 = Convert.ToDouble(row["Temperature"]);
                    gclass194.double_4 = Convert.ToDouble(row["TempDev"]);
                    gclass194.double_5 = Convert.ToDouble(row["Gravity"]);
                    gclass194.double_6 = Convert.ToDouble(row["GravDev"]);
                    gclass194.SpeciesName = row["SpeciesName"].ToString();
                    gclass194.string_0 = row["RacePic"].ToString();
                    gclass194.double_7 = gclass194.double_5 - gclass194.double_6;
                    gclass194.double_8 = gclass194.double_5 + gclass194.double_6;
                    gclass194.double_9 = gclass194.double_0 - gclass194.double_1;
                    gclass194.double_10 = gclass194.double_0 + gclass194.double_1;
                    gclass194.double_12 = gclass194.double_3 - gclass194.double_4;
                    gclass194.double_11 = gclass194.double_3 + gclass194.double_4;
                    gclass194.dictionary_0 = new Dictionary<int, GClass195>();
                    this.SpeciesDictionary.Add(gclass194.int_0, gclass194);
                }
            }

            foreach (GClass194 gclass194 in this.SpeciesDictionary.Values)
            {
                if (gclass194.int_1 > 0)
                    gclass194.gclass194_0 = !this.SpeciesDictionary.ContainsKey(gclass194.int_1)
                        ? null
                        : this.SpeciesDictionary[gclass194.int_1];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1266);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1267);
        }
    }

    public void method_285()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_KnownSpecies").Rows)
            {
                GClass195 gclass195 = new GClass195();
                int int32_1 = Convert.ToInt32(row["ViewRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (this.SpeciesDictionary.ContainsKey(int32_2))
                    {
                        gclass195.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                        gclass195.genum25_0 = (GEnum25)Convert.ToInt32(row["Status"]);
                        this.SpeciesDictionary[int32_2].dictionary_0.Add(int32_1, gclass195);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1268);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1269);
        }
    }

    public void method_290()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_WealthData where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass151 gclass151 = new GClass151();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass151.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    WealthUsage int32_2 = (WealthUsage)Convert.ToInt32(row["UseID"]);
                    if (this.WealthUsageDictionary.ContainsKey(int32_2))
                        gclass151.gclass150_0 = this.WealthUsageDictionary[int32_2];
                    gclass151.decimal_0 = Convert.ToDecimal(row["Amount"]);
                    gclass151.decimal_1 = Convert.ToDecimal(row["TimeUsed"]);
                    gclass151.gclass21_0.list_3.Add(gclass151);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1278);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1279 /*0x04FF*/);
        }
    }

    public void method_291()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_RaceMineralData where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass153 gclass153 = new GClass153();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass153.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                        gclass153.gclass146_0 = this.PopulationDataDictionary[int32_2];
                    gclass153.genum85_0 = (MineralUsage)Convert.ToInt32(row["MineralDataType"]);
                    gclass153.auroraElement_0 = (AuroraElement)Convert.ToInt32(row["MineralID"]);
                    gclass153.decimal_0 = Convert.ToDecimal(row["Amount"]);
                    gclass153.decimal_1 = Convert.ToDecimal(row["Time"]);
                    gclass153.gclass21_0.list_4.Add(gclass153);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3939);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3940);
        }
    }

    public void method_292()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ResearchQueue where GameID = {this.GameID.ToString()}").Rows)
            {
                ResearchQueue gclass166 = new ResearchQueue();
                int int32_1 = Convert.ToInt32(row["PopulationID"]);
                if (this.PopulationDataDictionary.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                    if (this.TechDataDictionary.ContainsKey(int32_2))
                    {
                        gclass166.Population = this.PopulationDataDictionary[int32_1];
                        gclass166.TechSystem = this.TechDataDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["CurrentProjectID"]);
                        if (gclass166.Population.dictionary_1.ContainsKey(int32_3))
                        {
                            gclass166.CurrentProject = gclass166.Population.dictionary_1[int32_3];
                            gclass166.ResearchOrder = Convert.ToInt32(row["ResearchOrder"]);
                            gclass166.Population.RaceData.ResearchQueues.Add(gclass166);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1280 /*0x0500*/);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1281);
        }
    }

    public void method_293()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PausedResearch where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                PausedResearch gclass167 = new PausedResearch();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                    if (this.TechDataDictionary.ContainsKey(int32_2))
                    {
                        gclass167.gclass164_0 = this.TechDataDictionary[int32_2];
                        gclass167.PointsAccumulated = Convert.ToInt32(row["PointsAccumulated"]);
                        this.FCTRaceRecordDic[int32_1].PausedResearches.Add(gclass167);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1282);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1283);
        }
    }

    public void method_294()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_SwarmResearch where GameID = {this.GameID.ToString()}").Rows)
            {
                SwarmResearch gclass168 = new SwarmResearch();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                    if (this.TechDataDictionary.ContainsKey(int32_2))
                    {
                        gclass168.Race = this.FCTRaceRecordDic[int32_1];
                        gclass168.TechSystem = this.TechDataDictionary[int32_2];
                        gclass168.ResearchPoints = Convert.ToInt32(row["ResearchPoints"]);
                        gclass168.Race.list_7.Add(gclass168);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1284);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1285);
        }
    }

    public void method_296()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_KnownRuinRace where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["RuinRaceID"]);
                int int32_2 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    this.FCTRaceRecordDic[int32_2].KnownRuinIDs.Add(int32_1);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1288);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1289);
        }
    }

    public void method_297()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShippingLines WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                ShippingLineData gclass187 = new ShippingLineData(this);
                int int32_1 = Convert.ToInt32(row["EmpireID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass187.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["CommEngineID"]);
                    if (this.ComponentDataDictionary.ContainsKey(int32_2))
                        gclass187.gclass230_0 = this.ComponentDataDictionary[int32_2];
                    gclass187.int_0 = Convert.ToInt32(row["ShippingLineID"]);
                    gclass187.int_1 = Convert.ToInt32(row["ShipNum"]);
                    gclass187.int_2 = Convert.ToInt32(row["CommercialEngines"]);
                    gclass187.decimal_0 = Convert.ToDecimal(row["WealthBalance"]);
                    gclass187.decimal_1 = Convert.ToDecimal(row["LastDividendPaid"]);
                    gclass187.decimal_2 = Convert.ToDecimal(row["LastDividendTime"]);
                    gclass187.bool_0 = Convert.ToBoolean(row["NPRace"]);
                    gclass187.string_0 = row["LineName"].ToString();
                    gclass187.string_1 = row["ShortName"].ToString();
                    this.ShippingLineDictionary.Add(gclass187.int_0, gclass187);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1290);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1291);
        }
    }

    public void method_301()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_NavalAdminCommand WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                NavalAdminCommand gclass83 = new NavalAdminCommand(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                        gclass83.gclass146_0 = this.PopulationDataDictionary[int32_2];
                    gclass83.int_4 = Convert.ToInt32(row["ShipID"]);
                    AdminCommandType int32_3 = (AdminCommandType)Convert.ToInt32(row["AdminCommandTypeID"]);
                    if (this.AdminCommandTypeDictionary.ContainsKey(int32_3))
                        gclass83.gclass79_0 = this.AdminCommandTypeDictionary[int32_3];
                    gclass83.Race = this.FCTRaceRecordDic[int32_1];
                    gclass83.int_0 = Convert.ToInt32(row["NavalAdminCommandID"]);
                    gclass83.int_1 = Convert.ToInt32(row["ParentAdminCommandID"]);
                    gclass83.int_2 = Convert.ToInt32(row["CommandPriority"]);
                    gclass83.int_3 = Convert.ToInt32(row["MinimumRankPriority"]);
                    gclass83.genum121_0 = (CommanderBonusType)Convert.ToInt32(row["BonusOne"]);
                    gclass83.genum121_1 = (CommanderBonusType)Convert.ToInt32(row["BonusTwo"]);
                    gclass83.genum121_2 = (CommanderBonusType)Convert.ToInt32(row["BonusThree"]);
                    gclass83.bool_1 = Convert.ToBoolean(row["AutoAssign"]);
                    gclass83.bool_0 = Convert.ToBoolean(row["FleetNodeExpanded"]);
                    gclass83.AdminCommandName = row["AdminCommandName"].ToString();
                    this.NavalAdminCommands.Add(gclass83.int_0, gclass83);
                }
            }

            foreach (NavalAdminCommand gclass83 in this.NavalAdminCommands.Values)
            {
                if (this.NavalAdminCommands.ContainsKey(gclass83.int_1))
                    gclass83.ParentAdminCommand = this.NavalAdminCommands[gclass83.int_1];
            }

            foreach (GameRace gclass21 in this.FCTRaceRecordDic.Values)
            {
                if (gclass21.SelectedAdminIcon > 0 && this.NavalAdminCommands.ContainsKey(gclass21.SelectedAdminIcon))
                    gclass21.SelectedAdmin = this.NavalAdminCommands[gclass21.SelectedAdminIcon];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1296);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1297);
        }
    }

    public void method_302()
    {
        try
        {
            SQLiteDatabaseC1181 sqLiteDatabaseC1181 = new SQLiteDatabaseC1181();
            DataTable dataTable =
                sqLiteDatabaseC1181.ExecuteQuery($"select * FROM FCT_Commander WHERE GameID = {this.GameID.ToString()}");
            Dictionary<int, ResearchProject> dictionary = this.PopulationDataDictionary.Values
                .SelectMany(popData => popData.dictionary_1)
                .ToDictionary(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                GClass55 gclass55 = new GClass55(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass55.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (this.SpeciesDictionary.ContainsKey(int32_2))
                    {
                        gclass55.gclass194_0 = this.SpeciesDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["POWRaceID"]);
                        if (this.FCTRaceRecordDic.ContainsKey(int32_3))
                            gclass55.gclass21_1 = this.FCTRaceRecordDic[int32_3];
                        int int32_4 = Convert.ToInt32(row["PopLocationID"]);
                        if (this.PopulationDataDictionary.ContainsKey(int32_4))
                            gclass55.gclass146_0 = this.PopulationDataDictionary[int32_4];
                        int int32_5 = Convert.ToInt32(row["EducationColony"]);
                        if (this.PopulationDataDictionary.ContainsKey(int32_5))
                            gclass55.gclass146_2 = this.PopulationDataDictionary[int32_5];
                        int int32_6 = Convert.ToInt32(row["HomeworldID"]);
                        if (this.SystemBodyRecordDic.ContainsKey(int32_6))
                            gclass55.gclass1_0 = this.SystemBodyRecordDic[int32_6];
                        int int32_7 = Convert.ToInt32(row["TransportShipID"]);
                        if (this.FCTShipDataDictionary.ContainsKey(int32_7))
                            gclass55.gclass40_0 = this.FCTShipDataDictionary[int32_7];
                        AuroraResearchField int32_8 = (AuroraResearchField)Convert.ToInt32(row["ResSpecID"]);
                        if (this.ResearchFieldDictionary.ContainsKey(int32_8))
                        {
                            gclass55.gclass162_0 = this.ResearchFieldDictionary[int32_8];
                            int int32_9 = Convert.ToInt32(row["LifepodID"]);
                            if (this.dictionary_30.ContainsKey(int32_9))
                                gclass55.gclass59_0 = this.dictionary_30[int32_9];
                            int int32_10 = Convert.ToInt32(row["RankID"]);
                            if (gclass55.gclass21_0.RacialRankDictionary.ContainsKey(int32_10))
                                gclass55.gclass61_0 = gclass55.gclass21_0.RacialRankDictionary[int32_10];
                            gclass55.auroraCommanderType_0 = (AuroraCommanderType)Convert.ToInt32(row["CommanderType"]);
                            gclass55.auroraCommandType_0 = (AuroraCommandType)Convert.ToInt32(row["CommandType"]);
                            int int32_11 = Convert.ToInt32(row["CommandID"]);
                            switch (gclass55.auroraCommandType_0)
                            {
                                case AuroraCommandType.Ship:
                                    if (this.FCTShipDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass40_1 = this.FCTShipDataDictionary[int32_11];
                                        gclass55.gclass40_1.dictionary_1.Add(AuroraCommandType.Ship, gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.Colony:
                                    if (this.PopulationDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass146_1 = this.PopulationDataDictionary[int32_11];
                                        gclass55.gclass146_1.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.Sector:
                                    if (gclass55.gclass21_0.dictionary_2.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass62_0 = gclass55.gclass21_0.dictionary_2[int32_11];
                                        gclass55.gclass62_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.GroundFormation:
                                    if (this.FormationDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass103_0 = this.FormationDictionary[int32_11];
                                        gclass55.gclass103_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ResearchProject:
                                    if (dictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass161_0 = dictionary[int32_11];
                                        gclass55.gclass161_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ExecutiveOfficer:
                                    if (this.FCTShipDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass40_2 = this.FCTShipDataDictionary[int32_11];
                                        gclass55.gclass40_2.dictionary_1.Add(AuroraCommandType.ExecutiveOfficer,
                                            gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ChiefEngineer:
                                    if (this.FCTShipDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass40_3 = this.FCTShipDataDictionary[int32_11];
                                        gclass55.gclass40_3.dictionary_1.Add(AuroraCommandType.ChiefEngineer, gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ScienceOfficer:
                                    if (this.FCTShipDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass40_4 = this.FCTShipDataDictionary[int32_11];
                                        gclass55.gclass40_4.dictionary_1.Add(AuroraCommandType.ScienceOfficer,
                                            gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.TacticalOfficer:
                                    if (this.FCTShipDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass40_5 = this.FCTShipDataDictionary[int32_11];
                                        gclass55.gclass40_5.dictionary_1.Add(AuroraCommandType.TacticalOfficer,
                                            gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.NavalAdminCommand:
                                    if (this.NavalAdminCommands.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass83_0 = this.NavalAdminCommands[int32_11];
                                        gclass55.gclass83_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.CAG:
                                    if (this.FCTShipDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass40_6 = this.FCTShipDataDictionary[int32_11];
                                        gclass55.gclass40_6.dictionary_1.Add(AuroraCommandType.CAG, gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.AcademyCommandant:
                                    if (this.PopulationDataDictionary.ContainsKey(int32_11))
                                    {
                                        gclass55.gclass146_3 = this.PopulationDataDictionary[int32_11];
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                            }

                            gclass55.int_0 = Convert.ToInt32(row["CommanderID"]);
                            gclass55.int_1 = Convert.ToInt32(row["PromotionScore"]);
                            gclass55.int_2 = Convert.ToInt32(row["PopPromotionScore"]);
                            gclass55.int_3 = Convert.ToInt32(row["DoNotRelieve"]);
                            gclass55.int_4 = Convert.ToInt32(row["Seniority"]);
                            gclass55.int_5 = Convert.ToInt32(row["Loyalty"]);
                            gclass55.int_6 = Convert.ToInt32(row["HealthRisk"]);
                            gclass55.int_7 = Convert.ToInt32(row["KillTonnageCommercial"]);
                            gclass55.int_8 = Convert.ToInt32(row["KillTonnageMilitary"]);
                            gclass55.auroraRetirementStatus_0 =
                                (AuroraRetirementStatus)Convert.ToInt32(row["RetireStatus"]);
                            gclass55.decimal_0 = Convert.ToDecimal(row["GameTimePromoted"]);
                            gclass55.decimal_1 = Convert.ToDecimal(row["GameTimeAssigned"]);
                            gclass55.decimal_2 = Convert.ToDecimal(row["CareerStart"]);
                            gclass55.bool_2 = Convert.ToBoolean(row["StoryCharacter"]);
                            gclass55.bool_0 = Convert.ToBoolean(row["DoNotPromote"]);
                            gclass55.bool_1 = Convert.ToBoolean(row["Female"]);
                            gclass55.bool_3 = Convert.ToBoolean(row["RetainRetired"]);
                            gclass55.bool_4 = Convert.ToBoolean(row["Prisoner"]);
                            gclass55.bool_5 = Convert.ToBoolean(row["Processed"]);
                            gclass55.string_0 = row["Name"].ToString();
                            gclass55.string_1 = row["Title"].ToString();
                            gclass55.string_2 = row["Orders"].ToString();
                            gclass55.string_3 = row["Notes"].ToString();
                            if (gclass55.auroraRetirementStatus_0 == AuroraRetirementStatus.Active)
                                this.dictionary_42.Add(gclass55.int_0, gclass55);
                            else
                                this.dictionary_43.Add(gclass55.int_0, gclass55);
                        }
                    }
                }
            }

            foreach (ResearchProject gclass161 in dictionary.Values)
            {
                if (gclass161.gclass55_0 == null)
                    gclass161.method_0();
            }

            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery($"select * FROM FCT_CommanderTraits").Rows)
            {
                int int32_12 = Convert.ToInt32(row["CmdrID"]);
                GClass55 gclass55;
                if (this.dictionary_42.ContainsKey(int32_12))
                    gclass55 = this.dictionary_42[int32_12];
                else if (this.dictionary_43.ContainsKey(int32_12))
                    gclass55 = this.dictionary_43[int32_12];
                else
                    continue;
                int int32_13 = Convert.ToInt32(row["TraitID"]);
                if (this.TraitNameDictionary.ContainsKey(int32_13))
                    gclass55.list_1.Add(int32_13);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1300);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1301);
        }
    }

    public void method_303()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Lifepods WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass59 gclass59 = new GClass59(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass59.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (this.SpeciesDictionary.ContainsKey(int32_2))
                    {
                        gclass59.gclass194_0 = this.SpeciesDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["SystemID"]);
                        if (this.SystemDataDictionary.ContainsKey(int32_3))
                        {
                            gclass59.gclass200_0 = this.SystemDataDictionary[int32_3];
                            int int32_4 = Convert.ToInt32(row["ClassID"]);
                            if (this.dictionary_3.ContainsKey(int32_4))
                                gclass59.gclass22_0 = this.dictionary_3[int32_4];
                            gclass59.int_0 = Convert.ToInt32(row["LifepodID"]);
                            gclass59.int_1 = Convert.ToInt32(row["Crew"]);
                            gclass59.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass59.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass59.decimal_0 = Convert.ToDecimal(row["CreationTime"]);
                            gclass59.decimal_1 = Convert.ToDecimal(row["GradePoints"]);
                            gclass59.string_0 = row["ShipName"].ToString();
                            this.dictionary_30.Add(gclass59.int_0, gclass59);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1302);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1303);
        }
    }

    public void method_306()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_CommanderBonuses WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass52 gclass52 = new GClass52();
                int int32_1 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (this.dictionary_42.ContainsKey(int32_1))
                    gclass55 = this.dictionary_42[int32_1];
                else if (this.dictionary_43.ContainsKey(int32_1))
                    gclass55 = this.dictionary_43[int32_1];
                else
                    continue;
                CommanderBonusType int32_2 = (CommanderBonusType)Convert.ToInt32(row["BonusID"]);
                if (this.CommanderBonusDictionary.ContainsKey(int32_2))
                {
                    gclass52.gclass50_0 = this.CommanderBonusDictionary[int32_2];
                    gclass52.decimal_0 = Math.Round(Convert.ToDecimal(row["BonusValue"]), 3);
                    gclass55.dictionary_0.Add(int32_2, gclass52);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1308);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1309);
        }
    }

    public void method_309()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_GroundUnitTraining where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass106 gclass106 = new GClass106(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass106.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                    {
                        gclass106.gclass146_0 = this.PopulationDataDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["FormationTemplateID"]);
                        if (this.FormationTemplateRecordDic.ContainsKey(int32_3))
                        {
                            gclass106.gclass102_0 = this.FormationTemplateRecordDic[int32_3];
                            gclass106.int_0 = Convert.ToInt32(row["TaskID"]);
                            gclass106.int_1 = Convert.ToInt32(row["OrganizationLinkID"]);
                            gclass106.int_2 = Convert.ToInt32(row["ParentLinkID"]);
                            gclass106.auroraGroundFormationFieldPosition_0 =
                                (AuroraGroundFormationFieldPosition)Convert.ToInt32(row["FieldPosition"]);
                            gclass106.decimal_0 = Convert.ToDecimal(row["TotalBP"]);
                            gclass106.decimal_1 = Convert.ToDecimal(row["CompletedBP"]);
                            gclass106.decimal_2 = Convert.ToDecimal(row["TaskPercentage"]);
                            gclass106.string_0 = row["FormationName"].ToString();
                            gclass106.gclass146_0.dictionary_3.Add(gclass106.int_0, gclass106);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1314);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1315);
        }
    }

    public void method_310()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_GroundUnitTrainingQueue where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass107 gclass107 = new GClass107(this);
                int int32_1 = Convert.ToInt32(row["PopulationID"]);
                if (this.PopulationDataDictionary.ContainsKey(int32_1))
                {
                    gclass107.gclass146_0 = this.PopulationDataDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["FormationTemplateID"]);
                    if (this.FormationTemplateRecordDic.ContainsKey(int32_2))
                    {
                        gclass107.gclass102_0 = this.FormationTemplateRecordDic[int32_2];
                        gclass107.int_0 = Convert.ToInt32(row["QueueID"]);
                        gclass107.int_1 = Convert.ToInt32(row["OrganizationLinkID"]);
                        gclass107.int_2 = Convert.ToInt32(row["ParentLinkID"]);
                        gclass107.auroraGroundFormationFieldPosition_0 =
                            (AuroraGroundFormationFieldPosition)Convert.ToInt32(row["FieldPosition"]);
                        gclass107.decimal_0 = Convert.ToDecimal(row["TaskPercentage"]);
                        gclass107.string_0 = row["FormationName"].ToString();
                        gclass107.gclass146_0.list_0.Add(gclass107);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1314);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1315);
        }
    }

    public void method_311()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ResearchProject WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                ResearchProject gclass161 = new ResearchProject(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass161.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                    {
                        gclass161.gclass146_0 = this.PopulationDataDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["TechID"]);
                        if (this.TechDataDictionary.ContainsKey(int32_3))
                        {
                            gclass161.gclass164_0 = this.TechDataDictionary[int32_3];
                            AuroraResearchField int32_4 = (AuroraResearchField)Convert.ToInt32(row["ResSpecID"]);
                            if (this.ResearchFieldDictionary.ContainsKey(int32_4))
                            {
                                gclass161.gclass162_0 = this.ResearchFieldDictionary[int32_4];
                                gclass161.ResearchProjectID = Convert.ToInt32(row["ProjectID"]);
                                gclass161.int_0 = Convert.ToInt32(row["Facilities"]);
                                gclass161.decimal_0 = Convert.ToDecimal(row["ResearchPointsRequired"]);
                                gclass161.bool_0 = Convert.ToBoolean(row["Pause"]);
                                gclass161.bool_1 = Convert.ToBoolean(row["AssignNew"]);
                                gclass161.gclass146_0.dictionary_1.Add(gclass161.ResearchProjectID, gclass161);
                            }
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1316);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1317);
        }
    }

    public void method_312()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_SectorCommand where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    GClass62 gclass62 = new GClass62(this);
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (this.PopulationDataDictionary.ContainsKey(int32_2))
                    {
                        gclass62.gclass146_0 = this.PopulationDataDictionary[int32_2];
                        gclass62.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                        gclass62.int_0 = Convert.ToInt32(row["SectorCommandID"]);
                        gclass62.SectorName = row["SectorName"].ToString();
                        int int32_3 = Convert.ToInt32(row["Colour"]);
                        gclass62.color_0 = Color.FromArgb(int32_3);
                        gclass62.gclass21_0.dictionary_2.Add(gclass62.int_0, gclass62);
                    }
                }
            }

            foreach (GameRace gclass21 in this.FCTRaceRecordDic.Values)
            {
                foreach (RacialSystemSurvey gclass202 in gclass21.RacialSystemDictionary.Values)
                {
                    if (gclass202.SectorID > 0 && gclass21.dictionary_2.ContainsKey(gclass202.SectorID))
                        gclass202.gclass62_0 = gclass21.dictionary_2[gclass202.SectorID];
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1318);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1319);
        }
    }

    public void method_317()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Ranks Where GameID = {this.GameID.ToString()}").Rows)
            {
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32))
                {
                    RankThemeEntry gclass61 = new RankThemeEntry();
                    gclass61.gclass21_0 = this.FCTRaceRecordDic[int32];
                    gclass61.CommanderType = (AuroraCommanderType)Convert.ToInt32(row["RankType"]);
                    gclass61.int_0 = Convert.ToInt32(row["RankID"]);
                    gclass61.RankNum = Convert.ToInt32(row["Priority"]);
                    gclass61.RankName = row["RankName"].ToString();
                    gclass61.RankAbbreviation = row["RankAbbrev"].ToString();
                    if (gclass61.RankAbbreviation == "")
                        gclass61.RankAbbreviation = "R" + gclass61.RankNum.ToString();
                    gclass61.gclass21_0.RacialRankDictionary.Add(gclass61.int_0, gclass61);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1328);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1329);
        }
    }

    public void method_319()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienRace WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                AlienRaceInfo alienRaceInfo = new AlienRaceInfo(this);
                int int32_1 = Convert.ToInt32(row["ViewRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    alienRaceInfo.ViewingRace = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["ClassThemeID"]);
                    if (int32_2 != 0)
                        alienRaceInfo.ClassTheme = this.ThemeDictionary[int32_2];
                    alienRaceInfo.ActualAlienRaceID = Convert.ToInt32(row["AlienRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(alienRaceInfo.ActualAlienRaceID))
                    {
                        alienRaceInfo.ActualAlienRace = this.FCTRaceRecordDic[alienRaceInfo.ActualAlienRaceID];
                        alienRaceInfo.FixedRelationShip = Convert.ToInt32(row["FixedRelationship"]);
                        alienRaceInfo.ContactStatus = (AuroraContactStatus)Convert.ToInt32(row["ContactStatus"]);
                        alienRaceInfo.CommStatus = (AuroraCommStatus)Convert.ToInt32(row["CommStatus"]);
                        alienRaceInfo.UseRealClassNames = Convert.ToInt32(row["RealClassNames"]);
                        alienRaceInfo.RandomNameOrder = Convert.ToInt32(row["RandomNameOrder"]);
                        alienRaceInfo.CommModifier = Convert.ToDecimal(row["CommModifier"]);
                        alienRaceInfo.FirstDetected = Convert.ToDecimal(row["FirstDetected"]);
                        alienRaceInfo.CommEstablished = Convert.ToDecimal(row["CommEstablished"]);
                        alienRaceInfo.DiplomaticPoints = Convert.ToDecimal(row["DiplomaticPoints"]);
                        alienRaceInfo.DamageCausedByAlienRace = Convert.ToDecimal(row["DamageCausedByAlienRace"]);
                        alienRaceInfo.AlienRaceIntelPoints = Convert.ToDouble(row["AlienRaceIntelligencePoints"]);
                        alienRaceInfo.bTradeTreaty = Convert.ToBoolean(row["TradeTreaty"]);
                        alienRaceInfo.bTechTreaty = Convert.ToBoolean(row["TechTreaty"]);
                        alienRaceInfo.bGeoTreaty = Convert.ToBoolean(row["GeoTreaty"]);
                        alienRaceInfo.bGravTreaty = Convert.ToBoolean(row["GravTreaty"]);
                        alienRaceInfo.bPortraitShown = Convert.ToBoolean(row["PortraitShown"]);
                        alienRaceInfo.AlienRaceName = row["AlienRaceName"].ToString();
                        alienRaceInfo.Abbreviation = row["Abbrev"].ToString();
                        this.FCTRaceRecordDic[int32_1].PerceivedAliens.Add(alienRaceInfo.ActualAlienRaceID, alienRaceInfo);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1332);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1333);
        }
    }

    public void method_320()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienPopulation WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass113 gclass113 = new GClass113(this);
                int int32_1 = Convert.ToInt32(row["ViewingRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass113.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["AlienRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2) &&
                        this.FCTRaceRecordDic[int32_1].PerceivedAliens.ContainsKey(int32_2))
                    {
                        gclass113.gclass110_0 = this.FCTRaceRecordDic[int32_1].PerceivedAliens[int32_2];
                        int int32_3 = Convert.ToInt32(row["PopulationID"]);
                        if (this.PopulationDataDictionary.ContainsKey(int32_3))
                        {
                            gclass113.gclass146_0 = this.PopulationDataDictionary[int32_3];
                            gclass113.int_0 = Convert.ToInt32(row["Installations"]);
                            gclass113.int_1 = Convert.ToInt32(row["Mines"]);
                            gclass113.int_2 = Convert.ToInt32(row["Factories"]);
                            gclass113.int_3 = Convert.ToInt32(row["Refineries"]);
                            gclass113.int_4 = Convert.ToInt32(row["ResearchFacilities"]);
                            gclass113.int_5 = Convert.ToInt32(row["MaintenanceFacilities"]);
                            gclass113.int_6 = Convert.ToInt32(row["GFTF"]);
                            gclass113.double_0 = Convert.ToDouble(row["AlienPopulationIntelligencePoints"]);
                            gclass113.double_1 = Convert.ToDouble(row["MaxIntelligence"]);
                            gclass113.double_2 = Convert.ToDouble(row["PreviousMaxIntelligence"]);
                            gclass113.decimal_1 = Convert.ToDecimal(row["PopulationAmount"]);
                            gclass113.decimal_2 = Convert.ToDecimal(row["EMSignature"]);
                            gclass113.decimal_3 = Convert.ToDecimal(row["ThermalSignature"]);
                            gclass113.bool_0 = Convert.ToBoolean(row["Spaceport"]);
                            gclass113.bool_1 = Convert.ToBoolean(row["NavalHeadquarters"]);
                            gclass113.bool_2 = Convert.ToBoolean(row["SectorCommand"]);
                            gclass113.bool_3 = Convert.ToBoolean(row["RefuellingStation"]);
                            gclass113.bool_4 = Convert.ToBoolean(row["OrdnanceTransfer"]);
                            gclass113.bool_5 = Convert.ToBoolean(row["CargoStation"]);
                            gclass113.string_0 = row["PopulationName"].ToString();
                            this.FCTRaceRecordDic[int32_1].dictionary_13.Add(int32_3, gclass113);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1334);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1335);
        }
    }

    public void method_321()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienRaceSpecies WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                int int32_1 = Convert.ToInt32(row["SpeciesID"]);
                if (this.SpeciesDictionary.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["DetectRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (this.FCTRaceRecordDic[int32_2].PerceivedAliens.ContainsKey(int32_3))
                            this.FCTRaceRecordDic[int32_2].PerceivedAliens[int32_3].dictionary_0
                                .Add(int32_1, this.SpeciesDictionary[int32_1]);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1336);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1337);
        }
    }

    public void method_322()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienSystem WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["SystemID"]);
                if (this.SystemDataDictionary.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["DetectRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (this.FCTRaceRecordDic[int32_2].PerceivedAliens.ContainsKey(int32_3))
                            this.FCTRaceRecordDic[int32_2].PerceivedAliens[int32_3].dictionary_1
                                .Add(int32_1, this.SystemDataDictionary[int32_1]);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1338);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1339);
        }
    }

    public void method_323()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienRaceSensor WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass118 gclass118 = new GClass118();
                int int32_1 = Convert.ToInt32(row["ViewingRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass118.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["AlienRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        gclass118.gclass21_1 = this.FCTRaceRecordDic[int32_2];
                        int int32_3 = Convert.ToInt32(row["ActualSensor"]);
                        if (this.ComponentDataDictionary.ContainsKey(int32_3))
                            gclass118.gclass230_0 = this.ComponentDataDictionary[int32_3];
                        int int32_4 = Convert.ToInt32(row["ActualMissile"]);
                        if (this.RaceMissileDictionary.ContainsKey(int32_4))
                            gclass118.gclass129_0 = this.RaceMissileDictionary[int32_4];
                        int int32_5 = Convert.ToInt32(row["ActualGroundUnitClass"]);
                        if (this.GroundUnitClassDictionary.ContainsKey(int32_5))
                            gclass118.gclass101_0 = this.GroundUnitClassDictionary[int32_5];
                        gclass118.int_0 = Convert.ToInt32(row["AlienSensorID"]);
                        gclass118.decimal_1 = Convert.ToInt32(row["Strength"]);
                        gclass118.int_1 = Convert.ToInt32(row["Resolution"]);
                        gclass118.double_0 = Convert.ToDouble(row["Range"]);
                        gclass118.double_1 = Convert.ToDouble(row["IntelligencePoints"]);
                        gclass118.string_0 = row["Name"].ToString();
                        this.FCTRaceRecordDic[int32_1].PerceivedAliens[int32_2].dictionary_2
                            .Add(gclass118.int_0, gclass118);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1340);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1341);
        }
    }

    public void method_324()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienClass where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass115 gclass115 = new GClass115(this);
                int int32_1 = Convert.ToInt32(row["ActualClassID"]);
                if (this.dictionary_3.ContainsKey(int32_1))
                {
                    gclass115.gclass22_0 = this.dictionary_3[int32_1];
                    int int32_2 = Convert.ToInt32(row["ViewRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        gclass115.gclass21_1 = this.FCTRaceRecordDic[int32_2];
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (this.FCTRaceRecordDic.ContainsKey(int32_3))
                        {
                            gclass115.gclass21_0 = this.FCTRaceRecordDic[int32_3];
                            gclass115.gclass110_0 = this.FCTRaceRecordDic[int32_2].PerceivedAliens[int32_3];
                            int int32_4 = Convert.ToInt32(row["HullID"]);
                            gclass115.gclass76_0 = !this.ShipHullDictionary.ContainsKey(int32_4)
                                ? this.ShipHullDictionary[5]
                                : this.ShipHullDictionary[int32_4];
                            gclass115.int_0 = Convert.ToInt32(row["AlienClassID"]);
                            gclass115.int_1 = Convert.ToInt32(row["ArmourStrength"]);
                            gclass115.int_2 = Convert.ToInt32(row["MaxSpeed"]);
                            gclass115.int_3 = Convert.ToInt32(row["JumpDistance"]);
                            gclass115.int_5 = Convert.ToInt32(row["MaxEnergyPDShots"]);
                            gclass115.int_6 = Convert.ToInt32(row["TotalEnergyPDShots"]);
                            gclass115.int_7 = Convert.ToInt32(row["TotalEnergyPDHits"]);
                            gclass115.genum57_0 = (GEnum57)Convert.ToInt32(row["AlienClassRole"]);
                            gclass115.genum70_0 = (EngineDesignType)Convert.ToInt32(row["EngineType"]);
                            gclass115.int_4 = Convert.ToInt32(row["ShipCount"]);
                            gclass115.decimal_5 = Convert.ToDecimal(row["ActiveJammerStrength"]);
                            gclass115.decimal_6 = Convert.ToDecimal(row["FireControlJammerStrength"]);
                            gclass115.decimal_7 = Convert.ToDecimal(row["MissileJammerStrength"]);
                            gclass115.decimal_3 = Convert.ToDecimal(row["TCS"]);
                            gclass115.decimal_4 = Convert.ToDecimal(row["ShieldStrength"]);
                            gclass115.decimal_0 = Convert.ToDecimal(row["ThermalSignature"]);
                            gclass115.decimal_1 = Convert.ToDecimal(row["ShieldRecharge"]);
                            gclass115.decimal_2 = Convert.ToDecimal(row["FirstDetected"]);
                            gclass115.bool_0 = Convert.ToBoolean(row["ObservedMissileDefence"]);
                            gclass115.bool_1 = Convert.ToBoolean(row["DiplomaticShip"]);
                            gclass115.ClassName = row["ClassName"].ToString();
                            gclass115.string_0 = row["Notes"].ToString();
                            gclass115.string_1 = row["Summary"].ToString();
                            this.FCTRaceRecordDic[int32_2].dictionary_11.Add(gclass115.int_0, gclass115);
                        }
                    }
                }
            }

            Dictionary<int, GClass115> dictionary1 = this.FCTRaceRecordDic.Values
                .SelectMany(gclass21_0 => gclass21_0.dictionary_11)
                .ToDictionary(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            Dictionary<int, GClass118> dictionary2 = this.FCTRaceRecordDic.Values
                .SelectMany(gclass21_0 => gclass21_0.PerceivedAliens.Values)
                .SelectMany(gclass110_0 => gclass110_0.dictionary_2)
                .Distinct()
                .ToDictionary(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienClassSensor where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                int int32_5 = Convert.ToInt32(row["AlienSensorID"]);
                if (dictionary2.ContainsKey(int32_5))
                {
                    int int32_6 = Convert.ToInt32(row["AlienClassID"]);
                    if (dictionary1.ContainsKey(int32_6))
                        dictionary1[int32_6].list_0.Add(dictionary2[int32_5]);
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienClassWeapon where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass119 gclass119 = new GClass119();
                int int32_7 = Convert.ToInt32(row["AlienClassID"]);
                if (dictionary1.ContainsKey(int32_7))
                {
                    int int32_8 = Convert.ToInt32(row["WeaponID"]);
                    if (this.ComponentDataDictionary.ContainsKey(int32_8))
                    {
                        gclass119.gclass230_0 = this.ComponentDataDictionary[int32_8];
                        gclass119.int_0 = Convert.ToInt32(row["ROF"]);
                        gclass119.double_0 = Convert.ToInt32(row["Range"]);
                        gclass119.int_1 = Convert.ToInt32(row["Amount"]);
                        gclass119.decimal_0 = Convert.ToDecimal(row["LastFired"]);
                        dictionary1[int32_7].list_1.Add(gclass119);
                    }
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienClassTech").Rows)
            {
                int int32_9 = Convert.ToInt32(row["AlienClassID"]);
                if (dictionary1.ContainsKey(int32_9))
                {
                    int int32_10 = Convert.ToInt32(row["TechID"]);
                    if (this.TechDataDictionary.ContainsKey(int32_10))
                        dictionary1[int32_9].list_2.Add(this.TechDataDictionary[int32_10]);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1342);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1343);
        }
    }

    public void method_325()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienShip where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass117 gclass117 = new GClass117(this);
                int int32_1 = Convert.ToInt32(row["ViewRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass117.gclass21_1 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["AlienClassID"]);
                    if (this.FCTRaceRecordDic[int32_1].dictionary_11.ContainsKey(int32_2))
                    {
                        gclass117.gclass115_0 = this.FCTRaceRecordDic[int32_1].method_322(int32_2);
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (this.FCTRaceRecordDic.ContainsKey(int32_3))
                        {
                            gclass117.gclass21_0 = this.FCTRaceRecordDic[int32_3];
                            gclass117.gclass110_0 = this.FCTRaceRecordDic[int32_1].PerceivedAliens[int32_3];
                            int int32_4 = Convert.ToInt32(row["LastSysID"]);
                            if (this.SystemDataDictionary.ContainsKey(int32_4))
                                gclass117.gclass200_0 = this.SystemDataDictionary[int32_4];
                            gclass117.int_0 = Convert.ToInt32(row["ShipID"]);
                            if (this.FCTShipDataDictionary.ContainsKey(gclass117.int_0))
                                gclass117.gclass40_0 = this.FCTShipDataDictionary[gclass117.int_0];
                            gclass117.int_1 = Convert.ToInt32(row["Speed"]);
                            gclass117.int_2 = Convert.ToInt32(row["ArmourDamage"]);
                            gclass117.int_3 = Convert.ToInt32(row["PenetratingDamage"]);
                            gclass117.decimal_6 = Convert.ToDecimal(row["DamageTaken"]);
                            gclass117.decimal_7 = Convert.ToDecimal(row["ShieldDamage"]);
                            gclass117.double_0 = Convert.ToDouble(row["LastX"]);
                            gclass117.double_1 = Convert.ToDouble(row["LastY"]);
                            gclass117.decimal_0 = Convert.ToDecimal(row["LastContactTime"]);
                            gclass117.decimal_1 = Convert.ToDecimal(row["FirstDetected"]);
                            gclass117.decimal_2 = Convert.ToDecimal(row["GameTimeDamaged"]);
                            gclass117.bool_0 = Convert.ToBoolean(row["Destroyed"]);
                            gclass117.bool_1 = Convert.ToBoolean(row["Salvaged"]);
                            gclass117.string_0 = row["Name"].ToString();
                            this.FCTRaceRecordDic[int32_1].dictionary_12.Add(gclass117.int_0, gclass117);
                        }
                    }
                }
            }

            foreach (FleetData gclass85 in this.FleetDictionary.Values)
            {
                if (gclass85.SpecificThreatID > 0 && this.FCTRaceRecordDic[gclass85.Race.RaceID].dictionary_12
                        .ContainsKey(gclass85.SpecificThreatID))
                    gclass85.gclass117_0 =
                        this.FCTRaceRecordDic[gclass85.Race.RaceID].dictionary_12[gclass85.SpecificThreatID];
            }

            foreach (SubFleet gclass84 in this.SubFleetDictionary.Values)
            {
                if (gclass84.SpecificThreatID > 0 && this.FCTRaceRecordDic[gclass84.Race.RaceID].dictionary_12
                        .ContainsKey(gclass84.SpecificThreatID))
                    gclass84.gclass117_0 =
                        this.FCTRaceRecordDic[gclass84.Race.RaceID].dictionary_12[gclass84.SpecificThreatID];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1344);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1345);
        }
    }

    public void method_326()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"SELECT * FROM FCT_AlienGroundUnitClass where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass114 gclass114 = new GClass114(this);
                int int32_1 = Convert.ToInt32(row["ViewRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    gclass114.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["ActualUnitClassID"]);
                    if (this.GroundUnitClassDictionary.ContainsKey(int32_2))
                    {
                        gclass114.gclass101_0 = this.GroundUnitClassDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (this.FCTRaceRecordDic.ContainsKey(int32_3))
                        {
                            gclass114.gclass21_1 = this.FCTRaceRecordDic[int32_3];
                            gclass114.gclass110_0 = this.FCTRaceRecordDic[int32_1].PerceivedAliens[int32_3];
                            gclass114.int_0 = Convert.ToInt32(row["AlienGroundUnitClassID"]);
                            gclass114.int_1 = Convert.ToInt32(row["Hits"]);
                            gclass114.int_2 = Convert.ToInt32(row["Penetrated"]);
                            gclass114.int_3 = Convert.ToInt32(row["Destroyed"]);
                            gclass114.bool_0 = Convert.ToBoolean(row["WeaponsKnown"]);
                            gclass114.string_0 = row["Name"].ToString();
                            this.FCTRaceRecordDic[int32_1].dictionary_14.Add(gclass114.int_0, gclass114);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1346);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1347);
        }
    }

    public void method_327()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_RaceTech where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass165 gclass165 = new GClass165();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                int int32_2 = Convert.ToInt32(row["TechID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1) && this.TechDataDictionary.ContainsKey(int32_2))
                {
                    gclass165.gclass164_0 = this.TechDataDictionary[int32_2];
                    gclass165.gclass21_0 = this.FCTRaceRecordDic[int32_1];
                    gclass165.bool_0 = Convert.ToBoolean(row["Obsolete"]);
                    this.TechDataDictionary[int32_2].dictionary_0.Add(int32_1, gclass165);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1348);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1349);
        }
    }

    public void method_328()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_EligibleProjects where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass165 gclass165 = new GClass165();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1) && this.TechDataDictionary.ContainsKey(int32_2))
                    this.FCTRaceRecordDic[int32_1].list_18.Add(this.TechDataDictionary[int32_2]);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3961);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3962);
        }
    }

    public void method_331()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AetherRift WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass211 gclass211 = new GClass211(this);
                int int32 = Convert.ToInt32(row["SystemID"]);
                if (this.SystemDataDictionary.ContainsKey(int32))
                {
                    gclass211.gclass200_0 = this.SystemDataDictionary[int32];
                    gclass211.double_0 = Convert.ToDouble(row["Xcor"]);
                    gclass211.double_1 = Convert.ToDouble(row["Ycor"]);
                    gclass211.double_2 = Convert.ToDouble(row["Diameter"]);
                    this.dictionary_15.Add(int32, gclass211);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3260);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3260);
        }
    }

    public void method_332()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AetherGates WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                GClass210 gclass210 = new GClass210(this);
                int int32 = Convert.ToInt32(row["SystemID"]);
                if (this.SystemDataDictionary.ContainsKey(int32))
                {
                    gclass210.gclass200_0 = this.SystemDataDictionary[int32];
                    gclass210.int_0 = Convert.ToInt32(row["AetherGateID"]);
                    gclass210.decimal_0 = Convert.ToDecimal(row["CreationTime"]);
                    gclass210.double_0 = Convert.ToDouble(row["Xcor"]);
                    gclass210.double_1 = Convert.ToDouble(row["Ycor"]);
                    gclass210.double_2 = Convert.ToDouble(row["CooldownTime"]);
                    this.dictionary_16.Add(gclass210.int_0, gclass210);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3404);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3404);
        }
    }

    public void method_333(bool bool_25)
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(bool_25
                             ? $"SELECT * FROM FCT_TechSystem where GameID = {this.GameID.ToString()}"
                             : "SELECT * FROM FCT_TechSystem where GameID = 0").Rows)
            {
                TechSystem gclass164 = new TechSystem();
                TechType int32 = (TechType)Convert.ToInt32(row["TechTypeID"]);
                if (this.TechTypeDataDictionary.ContainsKey(int32))
                    gclass164.gclass163_0 = this.TechTypeDataDictionary[int32];
                gclass164.TechSystemID = Convert.ToInt32(row["TechSystemID"]);
                gclass164.int_5 = Convert.ToInt32(row["GameID"]);
                gclass164.genum119_0 = (ResearchCategoryType)Convert.ToInt32(row["CategoryID"]);
                gclass164.int_1 = Convert.ToInt32(row["RaceID"]);
                gclass164.int_2 = Convert.ToInt32(row["Prerequisite1"]);
                gclass164.int_3 = Convert.ToInt32(row["Prerequisite2"]);
                gclass164.int_4 = Convert.ToInt32(row["DevelopCost"]);
                gclass164.decimal_0 = Convert.ToDecimal(row["AdditionalInfo"]);
                gclass164.decimal_1 = Convert.ToDecimal(row["AdditionalInfo2"]);
                gclass164.decimal_2 = Convert.ToDecimal(row["AdditionalInfo3"]);
                gclass164.decimal_3 = Convert.ToDecimal(row["AdditionalInfo4"]);
                gclass164.Name = row["Name"].ToString();
                gclass164.string_0 = row["ComponentName"].ToString();
                gclass164.string_1 = row["TechDescription"].ToString();
                gclass164.bool_0 = Convert.ToBoolean(row["NoTechScan"]);
                gclass164.bool_1 = Convert.ToBoolean(row["RuinOnly"]);
                gclass164.bool_2 = Convert.ToBoolean(row["StartingSystem"]);
                gclass164.bool_3 = Convert.ToBoolean(row["ConventionalSystem"]);
                gclass164.bool_4 = Convert.ToBoolean(row["AutomaticResearch"]);
                if (this.FCTRaceRecordDic.ContainsKey(gclass164.int_1))
                    gclass164.gclass21_0 = this.FCTRaceRecordDic[gclass164.int_1];
                this.TechDataDictionary.Add(gclass164.TechSystemID, gclass164);
            }

            foreach (TechSystem gclass164 in this.TechDataDictionary.Values)
            {
                if (this.TechDataDictionary.ContainsKey(gclass164.int_2))
                    gclass164.gclass164_0 = this.TechDataDictionary[gclass164.int_2];
                if (this.TechDataDictionary.ContainsKey(gclass164.int_3))
                    gclass164.gclass164_1 = this.TechDataDictionary[gclass164.int_3];
            }

            foreach (GClass194 gclass194 in this.SpeciesDictionary.Values
                         .Where(gclass194_0 => gclass194_0.int_9 > 0).ToList())
                gclass194.gclass164_0 = !this.TechDataDictionary.ContainsKey(gclass194.int_9)
                    ? null
                    : this.TechDataDictionary[gclass194.int_9];
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1354);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1355);
        }
    }

    public void method_336()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipComponentTemplate").Rows)
            {
                GClass185 gclass185 = new GClass185();
                gclass185.int_0 = Convert.ToInt32(row["ShipComponentTemplateID"]);
                gclass185.auroraComponentType_0 = (AuroraComponentType)Convert.ToInt32(row["ComponentTypeID"]);
                gclass185.int_9 = Convert.ToInt32(row["Resolution"]);
                gclass185.int_10 = Convert.ToInt32(row["NumberOfShots"]);
                gclass185.int_11 = Convert.ToInt32(row["ExtraHTK"]);
                gclass185.int_1 = Convert.ToInt32(row["TurretWeaponTemplateID"]);
                gclass185.int_12 = Convert.ToInt32(row["TrackingSpeed"]);
                gclass185.int_2 = Convert.ToInt32(row["BGTech1"]);
                gclass185.int_3 = Convert.ToInt32(row["BGTech2"]);
                gclass185.int_4 = Convert.ToInt32(row["BGTech3"]);
                gclass185.int_5 = Convert.ToInt32(row["BGTech4"]);
                gclass185.int_6 = Convert.ToInt32(row["BGTech5"]);
                gclass185.int_7 = Convert.ToInt32(row["BGTech6"]);
                gclass185.int_8 = Convert.ToInt32(row["BGTech7"]);
                gclass185.decimal_0 = Convert.ToDecimal(row["ComponentSize"]);
                gclass185.decimal_2 = Convert.ToDecimal(row["ComponentValue"]);
                gclass185.decimal_1 = Convert.ToDecimal(row["EnginePowerMod"]);
                gclass185.string_0 = row["ComponentName"].ToString();
                this.dictionary_76.Add(gclass185.int_0, gclass185);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1356);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1357);
        }
    }

    public void method_337(bool bool_25)
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(bool_25
                             ? $"SELECT * FROM FCT_ShipDesignComponents where GameID = {this.GameID.ToString()}"
                             : "SELECT * FROM FCT_ShipDesignComponents where GameID = 0").Rows)
            {
                ShipComponent gclass230 = new ShipComponent();
                gclass230.int_0 = Convert.ToInt32(row["SDComponentID"]);
                if (this.TechDataDictionary.ContainsKey(gclass230.int_0))
                {
                    int int32_1 = Convert.ToInt32(row["ShipComponentTemplateID"]);
                    if (this.dictionary_76.ContainsKey(int32_1))
                        gclass230.gclass185_0 = this.dictionary_76[int32_1];
                    gclass230.int_13 = Convert.ToInt32(row["GameID"]);
                    gclass230.int_1 = Convert.ToInt32(row["Crew"]);
                    gclass230.decimal_0 = Convert.ToDecimal(row["PowerRequirement"]);
                    gclass230.int_2 = Convert.ToInt32(row["ElectronicCTD"]);
                    gclass230.int_3 = Convert.ToInt32(row["TrackingSpeed"]);
                    gclass230.int_4 = Convert.ToInt32(row["HTK"]);
                    gclass230.int_5 = Convert.ToInt32(row["MaxExplosionSize"]);
                    gclass230.int_6 = Convert.ToInt32(row["DamageOutput"]);
                    gclass230.int_7 = Convert.ToInt32(row["NumberOfShots"]);
                    gclass230.int_8 = Convert.ToInt32(row["MaxWeaponRange"]);
                    gclass230.int_9 = Convert.ToInt32(row["JumpDistance"]);
                    gclass230.int_10 = Convert.ToInt32(row["JumpRating"]);
                    gclass230.int_11 = Convert.ToInt32(row["RateOfFire"]);
                    gclass230.int_12 = Convert.ToInt32(row["MaxPercentage"]);
                    gclass230.int_14 = Convert.ToInt32(row["TurretWeaponID"]);
                    gclass230.genum87_0 = (GEnum87)Convert.ToInt32(row["SpecialFunction"]);
                    gclass230.genum86_0 = (GEnum86)Convert.ToInt32(row["Prototype"]);
                    gclass230.int_15 = Convert.ToInt32(row["ExtraHTK"]);
                    gclass230.decimal_13 = Convert.ToDecimal(row["ECCM"]);
                    gclass230.decimal_1 = Convert.ToDecimal(row["Size"]);
                    gclass230.decimal_2 = Convert.ToDecimal(row["Cost"]);
                    gclass230.decimal_11 = Convert.ToDecimal(row["ExplosionChance"]);
                    gclass230.decimal_3 = Convert.ToDecimal(row["ComponentValue"]);
                    gclass230.decimal_4 = Convert.ToDecimal(row["RechargeRate"]);
                    gclass230.decimal_5 = Convert.ToDecimal(row["WeaponToHitModifier"]);
                    gclass230.double_0 = Convert.ToDouble(row["MaxSensorRange"]);
                    gclass230.decimal_6 = Convert.ToDecimal(row["Resolution"]);
                    gclass230.decimal_7 = Convert.ToDecimal(row["FuelUse"]);
                    gclass230.decimal_17 = Convert.ToDecimal(row["RangeModifier"]);
                    gclass230.decimal_8 = Convert.ToDecimal(row["FuelEfficiency"]);
                    gclass230.decimal_9 = Convert.ToDecimal(row["StealthRating"]);
                    gclass230.decimal_10 = Convert.ToDecimal(row["CloakRating"]);
                    gclass230.decimal_12 = Convert.ToDecimal(row["ArmourRetardation"]);
                    gclass230.decimal_14 = Convert.ToDecimal(row["EnginePowerMod"]);
                    gclass230.decimal_15 = Convert.ToDecimal(row["FCRangeModifier"]);
                    gclass230.decimal_16 = Convert.ToDecimal(row["FCSpeedModifier"]);
                    gclass230.bool_13 = Convert.ToBoolean(row["SpinalWeapon"]);
                    gclass230.bool_0 = Convert.ToBoolean(row["NoScrap"]);
                    gclass230.bool_1 = Convert.ToBoolean(row["MilitarySystem"]);
                    gclass230.bool_2 = Convert.ToBoolean(row["ShipyardRepairOnly"]);
                    gclass230.bool_3 = Convert.ToBoolean(row["ShippingLineSystem"]);
                    gclass230.bool_4 = Convert.ToBoolean(row["BeamWeapon"]);
                    gclass230.bool_5 = Convert.ToBoolean(row["ElectronicSystem"]);
                    gclass230.bool_6 = Convert.ToBoolean(row["NoMaintFailure"]);
                    gclass230.bool_7 = Convert.ToBoolean(row["HangarReloadOnly"]);
                    gclass230.bool_8 = Convert.ToBoolean(row["IgnoreArmour"]);
                    gclass230.bool_9 = Convert.ToBoolean(row["IgnoreShields"]);
                    gclass230.bool_10 = Convert.ToBoolean(row["ElectronicOnly"]);
                    gclass230.bool_11 = Convert.ToBoolean(row["Weapon"]);
                    gclass230.bool_12 = Convert.ToBoolean(row["SingleSystemOnly"]);
                    gclass230.Name = row["Name"].ToString();
                    gclass230.gclass164_0 = this.TechDataDictionary[gclass230.int_0];
                    AuroraComponentType int32_2 = (AuroraComponentType)Convert.ToInt32(row["ComponentTypeID"]);
                    if (this.ComponentTypeDictionary.ContainsKey(int32_2))
                    {
                        gclass230.gclass231_0 = this.ComponentTypeDictionary[int32_2];
                        gclass230.int_16 = Convert.ToInt32(row["BGTech1"]);
                        gclass230.int_17 = Convert.ToInt32(row["BGTech2"]);
                        gclass230.int_18 = Convert.ToInt32(row["BGTech3"]);
                        gclass230.int_19 = Convert.ToInt32(row["BGTech4"]);
                        gclass230.int_20 = Convert.ToInt32(row["BGTech5"]);
                        gclass230.int_21 = Convert.ToInt32(row["BGTech6"]);
                        gclass230.int_22 = Convert.ToInt32(row["BGTech7"]);
                        gclass230.method_1(this);
                        gclass230.gclass123_0 = new AllMineralsValue(this);
                        gclass230.gclass123_0.Duranium = Convert.ToDecimal(row["Duranium"]);
                        gclass230.gclass123_0.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                        gclass230.gclass123_0.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                        gclass230.gclass123_0.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                        gclass230.gclass123_0.Boronide = Convert.ToDecimal(row["Boronide"]);
                        gclass230.gclass123_0.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                        gclass230.gclass123_0.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                        gclass230.gclass123_0.Sorium = Convert.ToDecimal(row["Sorium"]);
                        gclass230.gclass123_0.Uridium = Convert.ToDecimal(row["Uridium"]);
                        gclass230.gclass123_0.Corundium = Convert.ToDecimal(row["Corundium"]);
                        gclass230.gclass123_0.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                        this.ComponentDataDictionary.Add(gclass230.int_0, gclass230);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1358);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1359);
        }
    }

    public void method_338()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Prisoners where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass147 gclass147 = new GClass147();
                int int32_1 = Convert.ToInt32(row["PopulationID"]);
                if (this.PopulationDataDictionary.ContainsKey(int32_1))
                {
                    gclass147.gclass146_0 = this.PopulationDataDictionary[int32_1];
                    int int32_2 = Convert.ToInt32(row["PrisonerRaceID"]);
                    if (this.FCTRaceRecordDic.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["PrisonerSpeciesID"]);
                        if (this.SpeciesDictionary.ContainsKey(int32_3))
                        {
                            gclass147.gclass21_0 = this.FCTRaceRecordDic[int32_2];
                            gclass147.gclass194_0 = this.SpeciesDictionary[int32_3];
                            gclass147.int_0 = Convert.ToInt32(row["NumPrisoners"]);
                            gclass147.int_1 = Convert.ToInt32(row["NumProcessed"]);
                            this.PopulationDataDictionary[int32_1].list_3.Add(gclass147);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1360);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1361);
        }
    }

    public void method_340()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Increments where GameID = {this.GameID.ToString()}").Rows)
            {
                GClass91 gclass91 = new GClass91();
                gclass91.int_0 = Convert.ToInt32(row["IncrementID"]);
                gclass91.int_1 = Convert.ToInt32(row["Length"]);
                gclass91.decimal_0 = Convert.ToDecimal(row["GameTime"]);
                this.gclass92_0.dictionary_0.Add(gclass91.int_0, gclass91);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1364);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1365);
        }
    }

    public void method_341()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"SELECT * FROM FCT_GameLog where GameID = {this.GameID.ToString()} ORDER BY IncrementID desc LIMIT 10000")
                         .Rows)
            {
                GClass87 gclass87 = new GClass87();
                int int32_1 = Convert.ToInt32(row["IncrementID"]);
                if (this.gclass92_0.dictionary_0.ContainsKey(int32_1))
                {
                    gclass87.gclass91_0 = this.gclass92_0.dictionary_0[int32_1];
                    EventType int32_2 = (EventType)Convert.ToInt32(row["EventType"]);
                    if (this.DIMEventTypeDictionary.ContainsKey(int32_2))
                    {
                        gclass87.gclass88_0 = this.DIMEventTypeDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["RaceID"]);
                        if (this.FCTRaceRecordDic.ContainsKey(int32_3))
                        {
                            gclass87.gclass21_0 = this.FCTRaceRecordDic[int32_3];
                            int int32_4 = Convert.ToInt32(row["SystemID"]);
                            if (this.SystemDataDictionary.ContainsKey(int32_4))
                                gclass87.gclass200_0 = this.SystemDataDictionary[int32_4];
                            int int32_5 = Convert.ToInt32(row["PopulationID"]);
                            if (this.PopulationDataDictionary.ContainsKey(int32_5))
                                gclass87.gclass146_0 = this.PopulationDataDictionary[int32_5];
                            gclass87.auroraEventCategory_0 = (AuroraEventCategory)Convert.ToInt32(row["IDType"]);
                            gclass87.decimal_0 = Convert.ToDecimal(row["Time"]);
                            gclass87.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass87.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass87.bool_0 = Convert.ToBoolean(row["SMOnly"]);
                            gclass87.string_0 = row["MessageText"].ToString();
                            gclass87.gclass91_0.list_0.Add(gclass87);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1366);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1367);
        }
    }

    public void method_342()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PrecursorTombGroup where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                GClass172 gclass172 = new GClass172();
                int int32_1 = Convert.ToInt32(row["SystemBodyID"]);
                if (this.SystemBodyRecordDic.ContainsKey(int32_1))
                {
                    gclass172.gclass1_0 = this.SystemBodyRecordDic[int32_1];
                    OperationalGroupID int32_2 = (OperationalGroupID)Convert.ToInt32(row["OperationalGroupID"]);
                    if (this.OperationalGroupDictionary.ContainsKey(int32_2))
                        gclass172.gclass9_0 = this.OperationalGroupDictionary[int32_2];
                    int int32_3 = Convert.ToInt32(row["FormationTemplateID"]);
                    if (this.FormationTemplateRecordDic.ContainsKey(int32_3))
                        gclass172.gclass102_0 = this.FormationTemplateRecordDic[int32_3];
                    gclass172.int_0 = Convert.ToInt32(row["NumGroups"]);
                    gclass172.decimal_0 = Convert.ToDecimal(row["EmergenceTime"]);
                    gclass172.decimal_1 = Convert.ToDecimal(row["LastTriggerEvent"]);
                    this.list_8.Add(gclass172);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3871);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3872);
        }
    }

    public void LoadEventColours()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_EventColour where GameID = {this.GameID.ToString()}").Rows)
            {
                EventColourSetting colourSetting = new EventColourSetting();
                colourSetting.RaceID = Convert.ToInt32(row["RaceID"]);
                EventType eventTypeID = (EventType)Convert.ToInt32(row["EventTypeID"]);
                if (this.DIMEventTypeDictionary.ContainsKey(eventTypeID))
                {
                    colourSetting.EventType = this.DIMEventTypeDictionary[eventTypeID];
                    int textColour = Convert.ToInt32(row["TextColour"]);
                    int alertColour = Convert.ToInt32(row["AlertColour"]);
                    colourSetting.TextColour = Color.FromArgb(byte.MaxValue, Color.FromArgb(alertColour));
                    colourSetting.AlertColour = Color.FromArgb(byte.MaxValue, Color.FromArgb(textColour));
                    if (this.FCTRaceRecordDic.ContainsKey(colourSetting.RaceID))
                        this.FCTRaceRecordDic[colourSetting.RaceID].EventColourSettings.Add(eventTypeID, colourSetting);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1368);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1369);
        }
    }

    public void LoadHideEvents()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_HideEvents").Rows)
            {
                HideEventData hideEventData = new HideEventData();
                hideEventData.RaceID = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(hideEventData.RaceID) || hideEventData.RaceID <= 0)
                {
                    hideEventData.EventType = (EventType)Convert.ToInt32(row["EventID"]);
                    if (this.DIMEventTypeDictionary.ContainsKey(hideEventData.EventType))
                        this.HideEventList.Add(hideEventData);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1370);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1371);
        }
    }

    public void LoadRaceSystemSurvey()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_RaceSysSurvey where GameID = {this.GameID.ToString()}").Rows)
            {
                RacialSystemSurvey raceSystemSurvey = new RacialSystemSurvey(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    raceSystemSurvey.Race = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["SystemID"]);
                    if (this.SystemDataDictionary.ContainsKey(int32_2))
                    {
                        raceSystemSurvey.ActualSystemData = this.SystemDataDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["NameThemeID"]);
                        if (this.ThemeDictionary.ContainsKey(int32_3))
                            raceSystemSurvey.NamingTheme = this.ThemeDictionary[int32_3];
                        int int32_4 = Convert.ToInt32(row["ControlRaceID"]);
                        if (raceSystemSurvey.Race.PerceivedAliens.ContainsKey(int32_4))
                            raceSystemSurvey.gclass110_0 = raceSystemSurvey.Race.PerceivedAliens[int32_4];
                        raceSystemSurvey.DangerRating = Convert.ToInt32(row["DangerRating"]);
                        raceSystemSurvey.ForeignFleetRaceID = Convert.ToInt32(row["ForeignFleetRaceID"]);
                        raceSystemSurvey.SectorID = Convert.ToInt32(row["SectorID"]);
                        raceSystemSurvey.XCoord = Convert.ToInt32(row["Xcor"]);
                        raceSystemSurvey.YCoord = Convert.ToInt32(row["Ycor"]);
                        raceSystemSurvey.ClosedWP = Convert.ToInt32(row["ClosedWP"]);
                        raceSystemSurvey.RaidRating = Convert.ToInt32(row["RaidRating"]);
                        raceSystemSurvey.DiscoveredTime = Convert.ToDecimal(row["DiscoveredTime"]);
                        raceSystemSurvey.AutoSystemProtectionStatus =
                            (AuroraSystemProtectionStatus)Convert.ToInt32(row["AutoProtectionStatus"]);
                        raceSystemSurvey.Name = row["Name"].ToString();
                        raceSystemSurvey.Discovered = row["Discovered"].ToString();
                        raceSystemSurvey.bSysTPStatus = Convert.ToBoolean(row["SysTPStatus"]);
                        raceSystemSurvey.bSurveyComplete = Convert.ToBoolean(row["SurveyDone"]);
                        raceSystemSurvey.bGeoSurveyDefaultDone = Convert.ToBoolean(row["GeoSurveyDefaultDone"]);
                        raceSystemSurvey.bNoAutoRoute = Convert.ToBoolean(row["NoAutoRoute"]);
                        raceSystemSurvey.bMilitaryRestrictedSystem = Convert.ToBoolean(row["MilitaryRestrictedSystem"]);
                        raceSystemSurvey.bMineralSearchFlag = Convert.ToBoolean(row["MineralSearchFlag"]);
                        raceSystemSurvey.SelectedBodyXCoord = Convert.ToDouble(row["SelectedBodyXcor"]);
                        raceSystemSurvey.SelectedBodyYCoord = Convert.ToDouble(row["SelectedBodyYcor"]);
                        raceSystemSurvey.KmPerPixel = Convert.ToDouble(row["KmPerPixel"]) * AuroraUtils.double_15;
                        raceSystemSurvey.SavedXCoord = raceSystemSurvey.XCoord;
                        raceSystemSurvey.SavedYCoord = raceSystemSurvey.YCoord;
                        if (raceSystemSurvey.KmPerPixel == 0.0)
                            raceSystemSurvey.KmPerPixel = raceSystemSurvey.ActualSystemData.method_39() * AuroraUtils.double_16;
                        raceSystemSurvey.Race.RacialSystemDictionary.Add(raceSystemSurvey.ActualSystemData.SystemID, raceSystemSurvey);
                        if (raceSystemSurvey.Race.NPR)
                        {
                            raceSystemSurvey.gclass3_0 = new GClass3(this, raceSystemSurvey);
                            raceSystemSurvey.gclass3_0.genum95_0 = (GEnum95)Convert.ToInt32(row["SystemValue"]);
                        }
                    }
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_RaceJumpPointSurvey where GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                RaceJumpPointSurvey RacialJPKnowledge = new RaceJumpPointSurvey();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32))
                {
                    RacialJPKnowledge.Race = this.FCTRaceRecordDic[int32];
                    RacialJPKnowledge.JumpPointID = Convert.ToInt32(row["WarpPointID"]);
                    if (this.JumpPointDictionary.ContainsKey(RacialJPKnowledge.JumpPointID))
                    {
                        RacialJPKnowledge.JumpPoint = this.JumpPointDictionary[RacialJPKnowledge.JumpPointID];
                        RacialJPKnowledge.Explored = Convert.ToInt32(row["Explored"]);
                        RacialJPKnowledge.Charted = Convert.ToInt32(row["Charted"]);
                        RacialJPKnowledge.Hide = Convert.ToInt32(row["Hide"]);
                        RacialJPKnowledge.MilitaryRestricted = Convert.ToInt32(row["MilitaryRestricted"]);
                        RacialJPKnowledge.IgnoreForDistance = Convert.ToInt32(row["IgnoreForDistance"]);
                        RacialJPKnowledge.bAlienUnits = Convert.ToBoolean(row["AlienUnits"]);
                        RacialJPKnowledge.JumpPoint.RacialJumpPointSurveys.Add(RacialJPKnowledge.Race.RaceID, RacialJPKnowledge);
                    }
                }
            }

            DataTable dataTable =
                new SQLiteDatabaseC1181().ExecuteQuery($"select * from FCT_AlienRaceSystemStatus where GameID = {this.GameID.ToString()}");
            
            /* ** Weird line : Result not used. Disabling.
            this.FCTRaceRecordDic.Values
                .SelectMany(raceRecord => raceRecord.RacialSystemDictionary.Values)
                .ToList();
            */
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                AlienRaceSystemStatus gclass111 = new AlienRaceSystemStatus();
                int int32_5 = Convert.ToInt32(row["ViewingRaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_5))
                {
                    GameRace viewingRace = this.FCTRaceRecordDic[int32_5];
                    int int32_6 = Convert.ToInt32(row["SystemID"]);
                    if (this.SystemDataDictionary.ContainsKey(int32_6))
                    {
                        SystemData200 systemData = this.SystemDataDictionary[int32_6];
                        int int32_7 = Convert.ToInt32(row["AlienRaceID"]);
                        if (this.FCTRaceRecordDic.ContainsKey(int32_7) &&
                            this.FCTRaceRecordDic[int32_5].PerceivedAliens.ContainsKey(int32_7) &&
                            this.FCTRaceRecordDic[int32_5].RacialSystemDictionary.ContainsKey(int32_6))
                        {
                            gclass111.gclass202_0 = this.FCTRaceRecordDic[int32_5].RacialSystemDictionary[int32_6];
                            gclass111.gclass110_0 = this.FCTRaceRecordDic[int32_5].PerceivedAliens[int32_7];
                            gclass111.auroraSystemProtectionStatus_0 =
                                (AuroraSystemProtectionStatus)Convert.ToInt32(row["ProtectionStatusID"]);
                            this.FCTRaceRecordDic[int32_5].RacialSystemDictionary[int32_6].dictionary_0
                                .Add(this.FCTRaceRecordDic[int32_5].PerceivedAliens[int32_7], gclass111);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1372);
        }
    }
    
    public void LoadFCTShipTechDataFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_ShipTechData where GameID = {this.GameID.ToString()}").Rows)
            {
                ShipTechData182 shipTechData = new ShipTechData182();
                int shipId = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(shipId))
                {
                    shipTechData.ShipData = this.FCTShipDataDictionary[shipId];
                    int techID = Convert.ToInt32(row["TechID"]);
                    if (this.TechDataDictionary.ContainsKey(techID))
                    {
                        shipTechData.TechData = this.TechDataDictionary[techID];
                        shipTechData.TechPoints = Convert.ToInt32(row["TechPoints"]);
                        this.FCTShipDataDictionary[shipId].ShipTechDataList.Add(shipTechData);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1143);
        }
    }

    public void LoadFCTStarsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_Star where GameID = {this.GameID.ToString()}").Rows)
            {
                Star197 star = new Star197(this);
                star.SystemID = Convert.ToInt32(row["SystemID"]);
                if (this.SystemDataDictionary.ContainsKey(star.SystemID))
                {
                    int starTypeID = Convert.ToInt32(row["StarTypeID"]);
                    if (this.StarTypeDictionary.ContainsKey(starTypeID))
                        star.StellarType = this.StarTypeDictionary[starTypeID];
                    star.StarID = Convert.ToInt32(row["StarID"]);
                    star.SystemID = Convert.ToInt32(row["SystemID"]);
                    star.ProtoStar = Convert.ToInt32(row["Protostar"]);
                    star.Component = Convert.ToInt32(row["Component"]);
                    star.OrbitingComponent = Convert.ToInt32(row["OrbitingComponent"]);
                    star.genum30_0 = (GEnum30)Convert.ToInt32(row["DisasterStatus"]);
                    star.XCoord = Convert.ToDouble(row["Xcor"]);
                    star.YCoord = Convert.ToDouble(row["Ycor"]);
                    star.OrbitalDistance = Convert.ToDouble(row["OrbitalDistance"]);
                    star.Bearing = Convert.ToDouble(row["Bearing"]);
                    star.Luminosity = Convert.ToDouble(row["Luminosity"]);
                    star.OrbitalPeriod = Convert.ToDouble(row["OrbitalPeriod"]);
                    star.Eccentricity = Convert.ToDouble(row["Eccentricity"]);
                    star.EccentricityDirection = Convert.ToDouble(row["EccentricityDirection"]);
                    star.MeanOrbitalSpeed = Convert.ToDouble(row["MeanOrbitalSpeed"]);
                    star.CurrentOrbitalSpeed = Convert.ToDouble(row["CurrentOrbitalSpeed"]);
                    star.DistanceToParent = Convert.ToDouble(row["DistanceToParent"]);
                    star.DistanceToOrbitCentre = Convert.ToDouble(row["DistanceToOrbitCentre"]);
                    star.Name = row["Name"].ToString();
                    if (star.MeanOrbitalSpeed == 0.0 && star.Component > 1)
                        star.MeanOrbitalSpeed = Math.Sqrt(2.0 / star.OrbitalDistance - 1.0 / star.OrbitalDistance);
                    if (star.CurrentOrbitalSpeed == 0.0 && star.Component > 1)
                        star.CurrentOrbitalSpeed = star.MeanOrbitalSpeed;
                    star.SystemData = this.SystemDataDictionary[star.SystemID];
                    if (star.Component == 1)
                        star.SystemData.double_6 = star.StellarType.Mass;
                    this.StarDictionary.Add(star.StarID, star);
                }
            }

            foreach (Star197 star in this.StarDictionary.Values)
            {
                if (star.OrbitingComponent > 0)
                {
                    Star197 orbitingStar = this.StarDictionary.Values
                        .Where(s => s.SystemData == star.SystemData && s.Component == star.OrbitingComponent)
                        .FirstOrDefault();
                    if (orbitingStar != null)
                    {
                        star.OrbitingStar = orbitingStar;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1144);
        }
    }

    public void LoadFCTJumpPointsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"select * from FCT_JumpPoint where GameID = {this.GameID.ToString()} order by distance")
                         .Rows)
            {
                JumpPoint120 jumpPoint = new JumpPoint120(this);
                int systemID = Convert.ToInt32(row["SystemID"]);
                jumpPoint.SystemData = this.SystemDataDictionary[systemID];
                jumpPoint.WarpPointID = Convert.ToInt32(row["WarpPointID"]);
                jumpPoint.LinkedWarpPointID = Convert.ToInt32(row["WPLink"]);
                jumpPoint.Bearing = Convert.ToInt32(row["Bearing"]);
                jumpPoint.JumpGateStrength = Convert.ToInt32(row["JumpGateStrength"]);
                jumpPoint.JumpGateRaceID = Convert.ToInt32(row["JumpGateRaceID"]);
                jumpPoint.XCoord = Convert.ToDouble(row["Xcor"]);
                jumpPoint.YCoord = Convert.ToDouble(row["Ycor"]);
                jumpPoint.Distance = Convert.ToDouble(row["Distance"]);
                this.JumpPointDictionary.Add(jumpPoint.WarpPointID, jumpPoint);
                jumpPoint.NumJumpPointsInSameSystem = this.SystemDataDictionary[systemID].GetNumberOfJumpPoints();
            }

            foreach (JumpPoint120 jumpPoint in this.JumpPointDictionary.Values)
            {
                if (jumpPoint.LinkedWarpPointID > 0)
                    jumpPoint.LinkedJumpPoint = this.JumpPointDictionary[jumpPoint.LinkedWarpPointID];
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1145);
        }
    }

    public void LoadWeaponRecharge()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_WeaponRecharge WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(shipID))
                {
                    int weaponID = Convert.ToInt32(row["WeaponID"]);
                    if (this.ComponentDataDictionary.ContainsKey(weaponID))
                    {
                        int weaponNum = Convert.ToInt32(row["WeaponNumber"]);
                        Decimal remainingRecharge = Convert.ToDecimal(row["RechargeRemaining"]);
                        WeaponComponentRechargeStatus gclass27 = new WeaponComponentRechargeStatus(this.ComponentDataDictionary[weaponID], weaponNum, remainingRecharge);
                        this.FCTShipDataDictionary[shipID].list_7.Add(gclass27);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1387);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1388);
        }
    }

    public void LoadWeaponFCAssignment()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_WeaponAssignment WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                WeaponFireControlAssignment weaponFCAssign = new WeaponFireControlAssignment();
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(shipID))
                {
                    weaponFCAssign.Ship = this.FCTShipDataDictionary[shipID];
                    int weaponID = Convert.ToInt32(row["WeaponID"]);
                    if (this.ComponentDataDictionary.ContainsKey(weaponID))
                    {
                        weaponFCAssign.WeaponComponent = this.ComponentDataDictionary[weaponID];
                        int fcTypeID = Convert.ToInt32(row["FCTypeID"]);
                        if (this.ComponentDataDictionary.ContainsKey(fcTypeID))
                        {
                            weaponFCAssign.FireControlComponent = this.ComponentDataDictionary[fcTypeID];
                            weaponFCAssign.WeaponNum = Convert.ToInt32(row["WeaponNum"]);
                            weaponFCAssign.FireControlNum = Convert.ToInt32(row["FCNum"]);
                            this.FCTShipDataDictionary[shipID].list_2.Add(weaponFCAssign);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1389);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1390);
        }
    }

    public void LoadFireControlAssignment()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_FireControlAssignment WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                FireControlAssignment fcsStatus = new FireControlAssignment(this);
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(shipID))
                {
                    fcsStatus.Ship = this.FCTShipDataDictionary[shipID];
                    int fcCompID = Convert.ToInt32(row["FCTypeID"]);
                    if (this.ComponentDataDictionary.ContainsKey(fcCompID))
                    {
                        fcsStatus.FCComponent = this.ComponentDataDictionary[fcCompID];
                        fcsStatus.FCNum = Convert.ToInt32(row["FCNum"]);
                        fcsStatus.PointDefenceConcentration =
                            (AuroraPointDefenceConcentration)Convert.ToInt32(row["PDFireConcentration"]);
                        fcsStatus.PointDefencePriority =
                            (AuroraPointDefencePriority)Convert.ToInt32(row["PointDefencePriority"]);
                        fcsStatus.TargetID = Convert.ToInt32(row["TargetID"]);
                        fcsStatus.TargetContactType = (AuroraContactType)Convert.ToInt32(row["TargetType"]);
                        fcsStatus.PointDefenceMode =
                            (AuroraPointDefenceMode)Convert.ToInt32(row["PointDefenceMode"]);
                        fcsStatus.MinimumAMMRange = Convert.ToDouble(row["MinimumAMMRange"]);
                        fcsStatus.IsOpeningFire = Convert.ToBoolean(row["OpenFire"]);
                        fcsStatus.NodeViewExpanded = Convert.ToBoolean(row["NodeExpand"]);
                        fcsStatus.HasFiredThisPhase = Convert.ToBoolean(row["FiredThisPhase"]);
                        this.FCTShipDataDictionary[shipID].list_4.Add(fcsStatus);
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1393);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1394);
        }
    }

    public void LoadMissileAssignments()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MissileAssignment WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                MissileAssignment gclass30 = new MissileAssignment();
                int int32_1 = Convert.ToInt32(row["ShipID"]);
                if (this.FCTShipDataDictionary.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["MissileID"]);
                    if (this.RaceMissileDictionary.ContainsKey(int32_2))
                    {
                        gclass30.Missile = this.RaceMissileDictionary[int32_2];
                        int int32_3 = Convert.ToInt32(row["WeaponID"]);
                        if (this.ComponentDataDictionary.ContainsKey(int32_3))
                        {
                            gclass30.FiringWeaponComponent = this.ComponentDataDictionary[int32_3];
                            gclass30.WeaponNum = Convert.ToInt32(row["WeaponNum"]);
                            this.FCTShipDataDictionary[int32_1].FiredMissiles.Add(gclass30);
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1395);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1396);
        }
    }

    public void LoadDesignDoctrineTechProgressionCategories()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_DesignPhilosophyTechProgressionCategories WHERE GameID = {this.GameID.ToString()}").Rows)
            {
                int race = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(race))
                {
                    TechProgressionCategoryType int32_2 = (TechProgressionCategoryType)Convert.ToInt32(row["TechProgressionCategoryID"]);
                    this.FCTRaceRecordDic[race].DesignDoctrine.list_2.Add(int32_2);
                }
            }

            foreach (GameRace gclass21 in this.FCTRaceRecordDic.Values)
            {
                if (gclass21.DesignDoctrine != null)
                    gclass21.DesignDoctrine.method_1();
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1395);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1396);
        }
    }

    public void LoadDesignDoctrines()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_DesignPhilosophy WHERE GameID = {this.GameID.ToString()}")
                         .Rows)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class87 class87 = new GClass0.Class87();
                // ISSUE: reference to a compiler-generated field
                class87.DesignDoctrine = new DesignDoctrine(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (this.FCTRaceRecordDic.ContainsKey(int32_1))
                {
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Race = this.FCTRaceRecordDic[int32_1];
                    int int32_2 = Convert.ToInt32(row["LauncherSizeModifier"]);
                    if (this.TechDataDictionary.ContainsKey(int32_2))
                    {
                        // ISSUE: reference to a compiler-generated field
                        class87.DesignDoctrine.gclass164_0 = this.TechDataDictionary[int32_2];
                    }

                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiMissile = this.method_361(Convert.ToInt32(row["ActiveAntiMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiMissileSmall = this.method_361(Convert.ToInt32(row["ActiveAntiMissileSmall"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiFAC = this.method_361(Convert.ToInt32(row["ActiveAntiFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiFighter = this.method_361(Convert.ToInt32(row["ActiveAntiFighter"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveNavigation = this.method_361(Convert.ToInt32(row["ActiveNavigation"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveStandard = this.method_361(Convert.ToInt32(row["ActiveStandard"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveLarge = this.method_361(Convert.ToInt32(row["ActiveLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveVeryLarge = this.method_361(Convert.ToInt32(row["ActiveVeryLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveSmall = this.method_361(Convert.ToInt32(row["ActiveSmall"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveFighterMissile = this.method_361(Convert.ToInt32(row["ActiveFighterMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveFighterBeam = this.method_361(Convert.ToInt32(row["ActiveFighterBeam"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSAntiMissile = this.method_361(Convert.ToInt32(row["FireControlAntiMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSAntiFAC = this.method_361(Convert.ToInt32(row["FireControlAntiFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSAntiFighter = this.method_361(Convert.ToInt32(row["FireControlAntiFighter"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSStandardMissile =
                        this.method_361(Convert.ToInt32(row["FireControlStandardMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSFastAttackCraftMissile = this.method_361(Convert.ToInt32(row["FireControlFACMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSRange = this.method_361(Convert.ToInt32(row["FireControlBeamRange"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSShortRange =
                        this.method_361(Convert.ToInt32(row["FireControlBeamShortRange"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSSpeed = this.method_361(Convert.ToInt32(row["FireControlBeamSpeed"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSFighterMissile =
                        this.method_361(Convert.ToInt32(row["FireControlFighterMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSFighter = this.method_361(Convert.ToInt32(row["FireControlFighterBeam"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveDreadnought = this.method_361(Convert.ToInt32(row["JumpDriveDreadnought"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveBattlecruiser = this.method_361(Convert.ToInt32(row["JumpDriveBattlecruiser"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveCruiser = this.method_361(Convert.ToInt32(row["JumpDriveCruiser"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveDestroyer = this.method_361(Convert.ToInt32(row["JumpDriveDestroyer"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveSurvey = this.method_361(Convert.ToInt32(row["JumpDriveSurvey"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveMediumHive = this.method_361(Convert.ToInt32(row["JumpDriveMediumHive"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveLargeHive = this.method_361(Convert.ToInt32(row["JumpDriveLargeHive"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveVeryLargeHive = this.method_361(Convert.ToInt32(row["JumpDriveVeryLargeHive"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.PointDefenceWeapon = this.method_361(Convert.ToInt32(row["PointDefenceWeapon"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Carronade = this.method_361(Convert.ToInt32(row["Carronade"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CIWS = this.method_361(Convert.ToInt32(row["CIWS"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Gauss = this.method_361(Convert.ToInt32(row["Gauss"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Meson = this.method_361(Convert.ToInt32(row["Meson"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MesonPointDefence = this.method_361(Convert.ToInt32(row["MesonPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.RailgunPointDefence = this.method_361(Convert.ToInt32(row["RailgunPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LaserLarge = this.method_361(Convert.ToInt32(row["LaserLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LaserPointDefence = this.method_361(Convert.ToInt32(row["LaserPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LaserSpinal = this.method_361(Convert.ToInt32(row["LaserSpinal"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ParticleBeam = this.method_361(Convert.ToInt32(row["ParticleBeam"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Railgun = this.method_361(Convert.ToInt32(row["Railgun"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.HighPowerMicrowaveLarge = this.method_361(Convert.ToInt32(row["HighPowerMicrowaveLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.HighPowerMicrowaveSmall = this.method_361(Convert.ToInt32(row["HighPowerMicrowaveSmall"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FighterBeamWeapon = this.method_361(Convert.ToInt32(row["FighterBeamWeapon"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherFAC = this.method_361(Convert.ToInt32(row["LauncherFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherStandard = this.method_361(Convert.ToInt32(row["LauncherStandard"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherMine = this.method_361(Convert.ToInt32(row["LauncherMine"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherPointDefence = this.method_361(Convert.ToInt32(row["LauncherPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherDecoy = this.method_361(Convert.ToInt32(row["LauncherDecoy"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineCommercial = this.method_361(Convert.ToInt32(row["EngineCommercial"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineMilitary = this.method_361(Convert.ToInt32(row["EngineMilitary"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineFAC = this.method_361(Convert.ToInt32(row["EngineFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineFighter = this.method_361(Convert.ToInt32(row["EngineFighter"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineSurvey = this.method_361(Convert.ToInt32(row["EngineSurvey"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CloakDD = this.method_361(Convert.ToInt32(row["CloakDD"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CloakCA = this.method_361(Convert.ToInt32(row["CloakCA"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CloakBC = this.method_361(Convert.ToInt32(row["CloakBC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ShieldProportion = Convert.ToDouble(row["ShieldProportion"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize1 = this.method_361(Convert.ToInt32(row["EMSensorSize1"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize2 = this.method_361(Convert.ToInt32(row["EMSensorSize2"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize3 = this.method_361(Convert.ToInt32(row["EMSensorSize3"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize6 = this.method_361(Convert.ToInt32(row["EMSensorSize6"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize1 = this.method_361(Convert.ToInt32(row["ThermalSensorSize1"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize2 = this.method_361(Convert.ToInt32(row["ThermalSensorSize2"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize3 = this.method_361(Convert.ToInt32(row["ThermalSensorSize3"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize6 = this.method_361(Convert.ToInt32(row["ThermalSensorSize6"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileFAC = this.method_362(Convert.ToInt32(row["MissileFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileCaptorMine = this.method_362(Convert.ToInt32(row["MissileCaptorMine"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileMineSecondStage = this.method_362(Convert.ToInt32(row["MissileMineSecondStage"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissilePointDefence = this.method_362(Convert.ToInt32(row["MissilePointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileStandard = this.method_362(Convert.ToInt32(row["MissileStandard"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.DecoyMissile = this.method_362(Convert.ToInt32(row["DecoyMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.NumCommercialEngines = Convert.ToInt32(row["NumCommercialEngines"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineSizeMilitary = Convert.ToInt32(row["EngineSizeMilitary"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineSizeCommercial = Convert.ToInt32(row["EngineSizeCommercial"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherSize = Convert.ToInt32(row["LauncherSize"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherDecoySize = Convert.ToInt32(row["LauncherDecoySize"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.NumSalvos = Convert.ToInt32(row["NumSalvos"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.NumSalvosAMM = Convert.ToInt32(row["NumSalvosAMM"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.WarshipArmour = Convert.ToInt32(row["WarshipArmour"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.WarshipEngineering = Convert.ToInt32(row["WarshipEngineering"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.WarshipEngineProportion = Convert.ToInt32(row["WarshipEngineProportion"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.NumWarshipEngines = Convert.ToInt32(row["NumWarshipEngines"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.WarshipHullSize = Convert.ToInt32(row["WarshipHullSize"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveResolution = Convert.ToInt32(row["ActiveResolution"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.SurveySensors = Convert.ToInt32(row["SurveySensors"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.TerraformModules = Convert.ToInt32(row["TerraformModules"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.HarvesterModule = Convert.ToInt32(row["HarvesterModules"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MiningModules = Convert.ToInt32(row["MiningModules"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.SurveyEngineBoost = Convert.ToDecimal(row["SurveyEngineBoost"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MilitaryEngineBoost = Convert.ToDecimal(row["MilitaryEngineBoost"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherAMMSize = Convert.ToDecimal(row["LauncherAMMSize"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FighterEngineSize = Convert.ToDecimal(row["FighterEngineSize"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.PrimaryBeamPreference = (BeamWeaponPreference)Convert.ToInt32(row["PrimaryBeamPreference"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.AlternativeBeamPreference = (BeamWeaponPreference)Convert.ToInt32(row["AlternativeBeamPreference"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.PointDefencePreference = (BeamWeaponPreference)Convert.ToInt32(row["PointDefencePreference"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.NPRMissileStrategy = (NPRMissileStrategy)Convert.ToInt32(row["NPRMissileStrategy"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MaxGeo = Convert.ToInt32(row["MaxGeo"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MaxGrav = Convert.ToInt32(row["MaxGrav"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MaxScout = Convert.ToInt32(row["MaxScout"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MaxDiplomatic = Convert.ToInt32(row["MaxDiplomatic"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MaxStabilisation = Convert.ToInt32(row["MaxStabilisation"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MaxSalvage = Convert.ToInt32(row["MaxSalvage"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MaxTanker = Convert.ToInt32(row["MaxTanker"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.GroundForceDeploymentThemeID = Convert.ToInt32(row["GroundForceDeploymentThemeID"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.OperationGroupProgressionType = (OperationGroupProgressionType)Convert.ToInt32(row["OpGroupProgressionType"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.bUseJumpDrive = Convert.ToBoolean(row["UseJumpDrives"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.bOrdnanceFactories = Convert.ToBoolean(row["OrdnanceFactories"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.bFighterFactories = Convert.ToBoolean(row["FighterFactories"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.bHybridCarriers = Convert.ToBoolean(row["HybridCarriers"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ArmourMultiplier = Convert.ToDouble(row["ArmourMultiplier"]);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class87.DesignDoctrine.NameList_0 = this.list_4.Where(class87.Class16WherePredicate).ToList();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class87.DesignDoctrine.NameList_3 = this.list_2.Where(class87.Class12WherePredicate)
                        .OrderBy(gclass12_0 => gclass12_0.int_0).ToList();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Race.DesignDoctrine = class87.DesignDoctrine;
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1397);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1398);
        }
    }
}