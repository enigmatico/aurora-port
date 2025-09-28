using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aurora;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public partial class GClass0
{
    public void ReadMaxRecordIDForEachTableFromDB()
    {
        try
        {
            SQLiteDatabaseC1181 sqLiteDatabaseC1181 = new SQLiteDatabaseC1181();
            MaxGameID = sqLiteDatabaseC1181.method_1("FCT_Game", "GameID");
            MaxIncrementID = sqLiteDatabaseC1181.method_1("FCT_Increments", "IncrementID");
            MaxRuinRaceID = sqLiteDatabaseC1181.method_1("FCT_RuinRace", "RuinRaceID");
            MaxSystemID = sqLiteDatabaseC1181.method_1("FCT_System", "SystemID");
            MaxOrderTemplateID = sqLiteDatabaseC1181.method_1("FCT_OrderTemplate", "OrderTemplateID");
            MaxSystemBodyID = sqLiteDatabaseC1181.method_1("FCT_SystemBody", "SystemBodyID");
            MaxStarID = sqLiteDatabaseC1181.method_1("FCT_Star", "StarID");
            MaxWarpPointID = sqLiteDatabaseC1181.method_1("FCT_JumpPoint", "WarpPointID");
            int_7 = sqLiteDatabaseC1181.method_1("FCT_LagrangePoint", "LaGrangePointID");
            int_8 = sqLiteDatabaseC1181.method_1("FCT_AncientConstruct", "AncientConstructID");
            int_9 = sqLiteDatabaseC1181.method_1("FCT_SurveyLocation", "SurveyLocationID");
            int_10 = sqLiteDatabaseC1181.method_1("FCT_Species", "SpeciesID");
            int_11 = sqLiteDatabaseC1181.method_1("FCT_Race", "RaceID");
            int_12 = sqLiteDatabaseC1181.method_1("FCT_Ranks", "RankID");
            int_13 = sqLiteDatabaseC1181.method_1("FCT_WayPoint", "WayPointID");
            int_56 = sqLiteDatabaseC1181.method_1("FCT_TechSystem", "TechSystemID");
            int_14 = sqLiteDatabaseC1181.method_1("FCT_ShipDesignComponents", "SDComponentID");
            int_15 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitClass", "GroundUnitClassID");
            int_16 = sqLiteDatabaseC1181.method_1("FCT_MissileType", "MissileID");
            int_17 = sqLiteDatabaseC1181.method_1("FCT_ShipClass", "ShipClassID");
            int_18 = sqLiteDatabaseC1181.method_1("FCT_Population", "PopulationID");
            int_19 = sqLiteDatabaseC1181.method_1("FCT_NavalAdminCommand", "NavalAdminCommandID");
            int_20 = sqLiteDatabaseC1181.method_1("FCT_Fleet", "FleetID");
            int_21 = sqLiteDatabaseC1181.method_1("FCT_SubFleets", "SubFleetID");
            int_22 = sqLiteDatabaseC1181.method_1("FCT_ShippingLines", "ShippingLineID");
            int_23 = sqLiteDatabaseC1181.method_1("FCT_Ship", "ShipID");
            int_24 = sqLiteDatabaseC1181.method_1("FCT_Shipyard", "ShipyardID");
            int_25 = sqLiteDatabaseC1181.method_1("FCT_ShipyardTask", "TaskID");
            int_26 = sqLiteDatabaseC1181.method_1("FCT_IndustrialProjects", "ProjectID");
            int_27 = sqLiteDatabaseC1181.method_1("FCT_MassDriverPackets", "PacketID");
            int_28 = sqLiteDatabaseC1181.method_1("FCT_Lifepods", "LifepodID");
            int_30 = sqLiteDatabaseC1181.method_1("FCT_SectorCommand", "SectorCommandID");
            int_31 = sqLiteDatabaseC1181.method_1("FCT_ResearchProject", "ProjectID");
            int_32 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitFormation", "FormationID");
            int_33 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitFormationTemplate", "TemplateID");
            int_34 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitTraining", "TaskID");
            int_35 = sqLiteDatabaseC1181.method_1("FCT_Commander", "CommanderID");
            int_36 = sqLiteDatabaseC1181.method_1("FCT_Contacts", "UniqueID");
            int_37 = sqLiteDatabaseC1181.method_1("FCT_MoveOrders", "MoveOrderID");
            int_38 = sqLiteDatabaseC1181.method_1("FCT_MissileSalvo", "MissileSalvoID");
            int_39 = sqLiteDatabaseC1181.method_1("FCT_AlienClass", "AlienClassID");
            int_40 = sqLiteDatabaseC1181.method_1("FCT_Wrecks", "WreckID");
            int_42 = sqLiteDatabaseC1181.method_1("FCT_HullDescription", "HullDescriptionID");
            int_43 = sqLiteDatabaseC1181.method_1("FCT_AlienRaceSensor", "AlienSensorID");
            int_44 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitFormationElement", "ElementID");
            int_47 = sqLiteDatabaseC1181.method_1("FCT_RaceMedals", "MedalID");
            int_48 = sqLiteDatabaseC1181.method_1("DIM_NamingThemeTypes", "ThemeID");
            int_49 = sqLiteDatabaseC1181.method_1("DIM_CommanderNameTheme", "NameThemeID");
            int_45 = sqLiteDatabaseC1181.method_1("FCT_AlienGroundUnitClass", "AlienGroundUnitClassID");
            int_50 = sqLiteDatabaseC1181.method_1("FCT_GroundUnitSeries", "GroundUnitSeriesID");
            int_29 = sqLiteDatabaseC1181.method_1("FCT_AetherGates", "AetherGateID");
            int_53 = sqLiteDatabaseC1181.method_1("FCT_ShipClassTemplate", "ShipClassTemplateID");
            int_54 = sqLiteDatabaseC1181.method_1("FCT_ShipComponentTemplate", "ShipComponentTemplateID");
            int_51 = sqLiteDatabaseC1181.method_1("FCT_Squadron", "SquadronID");
            int_52 = sqLiteDatabaseC1181.method_1("FCT_OrganizationNode", "OrganizationID");
            int_55 = sqLiteDatabaseC1181.method_1("FCT_StandingOrderTemplate", "TemplateID");
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
                         .ExecuteQuery($"select * from FCT_RaceNameThemes where GameID = {GameID.ToString()}")
                         .Rows)
            {
                RaceNameTheme RaceNameTheme = new RaceNameTheme();
                int nameThemeID = Convert.ToInt32(row["NameThemeID"]);
                if (NameThemeDictionary.TryGetValue(nameThemeID, out var value))
                {
                    RaceNameTheme.CommanderNameThemeData = value;
                    int raceID = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.ContainsKey(raceID))
                    {
                        RaceNameTheme.Chance = Convert.ToInt32(row["Chance"]);
                        GameRaces[raceID].RaceNameThemeList.Add(RaceNameTheme);
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
                         .ExecuteQuery($"select * from FCT_Squadron where GameID = {GameID.ToString()}").Rows)
            {
                FCTSquadronData70 squadronData = new FCTSquadronData70(this);
                int parentShipId = Convert.ToInt32(row["ParentShipID"]);
                if (Ships.TryGetValue(parentShipId, out var ship))
                {
                    squadronData.ParentShipData = ship;
                    squadronData.SquadronID = Convert.ToInt32(row["SquadronID"]);
                    squadronData.SquadronName = row["SquadronName"].ToString();
                    squadronData.ParentShipData.ChildSquadronDictionary.Add(squadronData.SquadronID, squadronData);
                }
            }

            // 연관지울수 있는 SquadronData가 확인되어야만 LinkedSquadronID를 할당한다 AssignedSquadronID는 DB에서 꺼낸 날것의 값으로 존재를 보장하지 못함
            List<ShipData> list = Ships.Values
                .Where(shipData => shipData.AssignedSquadronID > 0).ToList();
            Dictionary<int, FCTSquadronData70> existingShipsChildSquadronDic = Ships.Values
                .SelectMany(
                    ship => ship.ChildSquadronDictionary)
                .ToDictionary(kvPair => kvPair.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (ShipData shipDataInList in list)
            {
                if (existingShipsChildSquadronDic.TryGetValue(shipDataInList.AssignedSquadronID, out var value))
                {
                    shipDataInList.SquadronData = value;
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
                         .ExecuteQuery($"select * from FCT_BannedBodies where GameID = {GameID.ToString()}").Rows)
            {
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(raceID))
                {
                    int systemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                    if (SystemBodyRecordDic.TryGetValue(systemBodyID, out var value))
                        GameRaces[raceID].BannedSystemBodies.Add(value);
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
                if (ShipHullDictionary.ContainsKey(shipClassTemplate.HullID))
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
                    ShipClassTemplateDictionary.Add(shipClassTemplate.ShipClassTemplateID, shipClassTemplate);
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
                if (ShipClassTemplateDictionary.ContainsKey(classComponentTemplate.ShipClassTemplateID))
                {
                    classComponentTemplate.ShipComponentTemplateID = Convert.ToInt32(row["ShipComponentTemplateID"]);
                    classComponentTemplate.StandardComponentID = Convert.ToInt32(row["StandardComponentID"]);
                    classComponentTemplate.NumComponent = Convert.ToInt32(row["NumComponent"]);
                    ShipClassTemplateDictionary[classComponentTemplate.ShipClassTemplateID].ComponentTemplateList
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
                         .ExecuteQuery($"select * from FCT_WindowPosition where GameID = {GameID.ToString()}")
                         .Rows)
            {
                WindowPosition207 winPosition = new WindowPosition207();
                winPosition.Left = Convert.ToInt32(row["Left"]);
                winPosition.Top = Convert.ToInt32(row["Top"]);
                winPosition.WindowName = row["WindowName"].ToString();
                WindowPositionDictionary.Add(winPosition.WindowName, winPosition);
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
                         .ExecuteQuery($"select * from FCT_System where GameID = {GameID.ToString()}").Rows)
            {
                StarSystem systemData = new StarSystem(this);
                systemData.SystemNumber = Convert.ToInt32(row["SystemNumber"]);
                if (UseKnownStars == 1 && KnownSystemDataDictionary.TryGetValue(systemData.SystemNumber, out var value))
                    systemData.KnownSystemData = value;
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
                StarSystemDictionary.Add(systemData.SystemID, systemData);
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
                         .ExecuteQuery($"select * from FCT_MapLabel where GameID = {GameID.ToString()}").Rows)
            {
                MapLabelData122 mapLabel = new MapLabelData122(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(raceID, out var race))
                {
                    mapLabel.Race = race;
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
                         .ExecuteQuery($"select * from FCT_SurveyLocation where GameID = {GameID.ToString()}")
                         .Rows)
            {
                SurveyLocation surveyLocation = new SurveyLocation();
                int systemId = Convert.ToInt32(row["SystemID"]);
                if (StarSystemDictionary.ContainsKey(systemId))
                {
                    surveyLocation.SurveyLocationID = Convert.ToInt32(row["SurveyLocationID"]);
                    surveyLocation.SystemID = Convert.ToInt32(row["SystemID"]);
                    surveyLocation.LocationNumber = Convert.ToInt32(row["LocationNumber"]);
                    surveyLocation.XCoord = Convert.ToDouble(row["Xcor"]);
                    surveyLocation.YCoord = Convert.ToDouble(row["Ycor"]);
                    StarSystemDictionary[systemId].SurveyLocationDictionary
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
                if (Ships.TryGetValue(targetShipID, out var ship))
                {
                    gclass25.TargetShip = ship;
                    gclass25.ArmourColumn = Convert.ToInt32(row["ArmourColumn"]);
                    gclass25.RemainingDamage = Convert.ToInt32(row["RemainingDamage"]);
                    gclass25.PointOfDamageTime = Convert.ToInt32(row["PointOfDamageTime"]);
                    gclass25.LastDamageTime = Convert.ToDecimal(row["LastDamageTime"]);
                    AcidAttackList.Add(gclass25);
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
                         .ExecuteQuery($"select * from FCT_MassDriverPackets where GameID = {GameID.ToString()}")
                         .Rows)
            {
                FCTMassDriverPacket126 gclass126 = new FCTMassDriverPacket126();
                int destID = Convert.ToInt32(row["DestID"]);
                if (Populations.TryGetValue(destID, out var population))
                {
                    gclass126.gclass146_0 = population;
                    int raceID = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.TryGetValue(raceID, out var race))
                    {
                        gclass126.Race = race;
                        int systemID = Convert.ToInt32(row["SysID"]);
                        if (StarSystemDictionary.TryGetValue(systemID, out var value))
                        {
                            gclass126.System = value;
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
                            MassDriverPacketsDictionary.Add(gclass126.PacketID, gclass126);
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
                         .ExecuteQuery($"select * from FCT_RaceOperationalGroupElements WHERE GameID = {GameID.ToString()}").Rows)
            {
                RaceOperationalGroupElement gclass11 = new RaceOperationalGroupElement();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    OperationalGroupID int32_2 = (OperationalGroupID)Convert.ToInt32(row["OperationalGroupID"]);
                    if (OperationalGroupDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass11.Element = value;
                        AutomatedClassDesignType int32_3 = (AutomatedClassDesignType)Convert.ToInt32(row["AutomatedDesignID"]);
                        if (AutomatedClassDesignDictionary.TryGetValue(int32_3, out var value1))
                        {
                            gclass11.AutomatedClassDesign = value1;
                            gclass11.NumShips = Convert.ToInt32(row["NumShips"]);
                            gclass11.KeyElement = Convert.ToBoolean(row["KeyElement"]);
                            GameRaces[int32_1].OperationalGroupElements.Add(gclass11);
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
                         .ExecuteQuery($"select * from FCT_TechProgressionRace where GameID = {GameID.ToString()}")
                         .Rows)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Class83 class83 = new Class83();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32, out var race))
                {
                    // ISSUE: reference to a compiler-generated field
                    class83.int_0 = Convert.ToInt32(row["ProgressionOrder"]);
                    // ISSUE: reference to a compiler-generated method
                    DesignPhilosophyTechProgressionsDictionary.FirstOrDefault(class83.method_0)?.list_0
                        .Add(race);
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
                         .ExecuteQuery($"select * from FCT_WayPoint where GameID = {GameID.ToString()}").Rows)
            {
                Waypoint gclass214 = new Waypoint(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass214.Race = race;
                    int int32_2 = Convert.ToInt32(row["SystemID"]);
                    if (StarSystemDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass214.System = value;
                        gclass214.OrbitBodyID = Convert.ToInt32(row["OrbitBodyID"]);
                        if (SystemBodyRecordDic.TryGetValue(gclass214.OrbitBodyID, out var value1))
                            gclass214.OrbitBody = value1;
                        gclass214.FleetID = Convert.ToInt32(row["FleetID"]);
                        if (FleetDictionary.ContainsKey(gclass214.FleetID) || gclass214.FleetID <= 0)
                        {
                            int int32_3 = Convert.ToInt32(row["JumpPointID"]);
                            if (JumpPointDictionary.TryGetValue(int32_3, out var value2))
                                gclass214.JumpPoint = value2;
                            gclass214.WaypointID = Convert.ToInt32(row["WaypointID"]);
                            gclass214.Number = Convert.ToInt32(row["Number"]);
                            gclass214.WaypointType = (WayPointType)Convert.ToInt32(row["WaypointType"]);
                            gclass214.Xcor = Convert.ToDouble(row["Xcor"]);
                            gclass214.Ycor = Convert.ToDouble(row["Ycor"]);
                            gclass214.CreationTime = Convert.ToDecimal(row["CreationTime"]);
                            gclass214.Name = row["Name"].ToString();
                            Waypoints.Add(gclass214.WaypointID, gclass214);
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
                         .ExecuteQuery($"select * from FCT_WealthHistory where GameID = {GameID.ToString()}").Rows)
            {
                WealthHistory wealthHistory = new WealthHistory();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32))
                {
                    wealthHistory.IncrementTime = Convert.ToDecimal(row["IncrementTime"]);
                    wealthHistory.WealthAmount = Convert.ToDecimal(row["WealthAmount"]);
                    GameRaces[int32].list_12.Add(wealthHistory);
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
                         .ExecuteQuery($"select * from FCT_OrganizationNode where GameID = {GameID.ToString()}")
                         .Rows)
            {
                OrganizationNodeC93 gclass93 = new OrganizationNodeC93();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    gclass93.Race = GameRaces[int32_1];
                    int formationTemplateID = Convert.ToInt32(row["FormationTemplateID"]);
                    if (FormationTemplateRecordDic.TryGetValue(formationTemplateID, out var value))
                        gclass93.FormationTemplate = value;
                    gclass93.ParentOrganizationID = Convert.ToInt32(row["ParentOrganizationID"]);
                    gclass93.OrganizationID = Convert.ToInt32(row["OrganizationID"]);
                    gclass93.FieldPosition = (AuroraGroundFormationFieldPosition)Convert.ToInt32(row["FieldPosition"]);
                    gclass93.OrganizationName = row["OrganizationName"].ToString();
                    gclass93.NodeExpanded = Convert.ToBoolean(row["NodeExpanded"]);
                    GameRaces[int32_1].OrganizationNodeDictionary.Add(gclass93.OrganizationID, gclass93);
                }
            }

            List<OrganizationNodeC93> list = GameRaces.Values
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
                         .ExecuteQuery($"select * from FCT_RaceMedals where GameID = {GameID.ToString()}").Rows)
            {
                FCTRaceMedalRecord raceMedal = new FCTRaceMedalRecord(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(raceID, out var race))
                {
                    raceMedal.Race = race;
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
                        MessageBox.Show($"No Image found for Medal: {raceMedal.MedalName}");
                    }

                    RaceMedalDictionary.Add(raceMedal.MedalID, raceMedal);
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
                         .ExecuteQuery($"select * from FCT_RaceGroundCombat where GameID = {GameID.ToString()}")
                         .Rows)
            {
                RaceGroundCombat raceGroundCombat = new RaceGroundCombat();
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(raceID))
                {
                    int systemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                    if (SystemBodyRecordDic.TryGetValue(systemBodyID, out var value))
                        raceGroundCombat.SystemBody = value;
                    raceGroundCombat.ConsecutiveCombatRounds = Convert.ToInt32(row["ConsecutiveCombatRounds"]);
                    GameRaces[raceID].raceGroundCombatRecord
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
                         .ExecuteQuery($"select * FROM FCT_DecoyAssignment WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                FCTDecoyAssignmentData32 decoyAssignment = new FCTDecoyAssignmentData32();
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(shipID))
                {
                    decoyAssignment.ShipData = Ships[shipID];
                    int launcherID = Convert.ToInt32(row["LauncherID"]);
                    if (ComponentDataDictionary.TryGetValue(launcherID, out var value))
                    {
                        decoyAssignment.LauncherData = value;
                        decoyAssignment.LauncherNum = Convert.ToInt32(row["LauncherNum"]);
                        Ships[shipID].DecoyAssignmentList.Add(decoyAssignment);
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
                         .ExecuteQuery($"select * FROM FCT_Race where GameID = {GameID.ToString()}").Rows)
            {
                GameRace raceRecord = new GameRace(this);
                int int32_1 = Convert.ToInt32(row["SystemThemeID"]);
                if (ThemeDictionary.TryGetValue(int32_1, out var value))
                    raceRecord.SystemTheme = value;
                int int32_2 = Convert.ToInt32(row["ClassThemeID"]);
                if (ThemeDictionary.TryGetValue(int32_2, out var value1))
                    raceRecord.ClassTheme = value1;
                int int32_3 = Convert.ToInt32(row["MissileThemeID"]);
                if (ThemeDictionary.TryGetValue(int32_3, out var value2))
                    raceRecord.MissileTheme = value2;
                int int32_4 = Convert.ToInt32(row["GroundThemeID"]);
                if (ThemeDictionary.TryGetValue(int32_4, out var value3))
                    raceRecord.GroundTheme = value3;
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

                Color color1 = Color.FromArgb(255, Color.FromArgb(raceRecord.Allied));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Allied, color1);
                Color color2 = Color.FromArgb(255, Color.FromArgb(raceRecord.Friendly));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Friendly, color2);
                Color color3 = Color.FromArgb(255, Color.FromArgb(raceRecord.Neutral));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Neutral, color3);
                Color color4 = Color.FromArgb(255, Color.FromArgb(raceRecord.Hostile));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Hostile, color4);
                Color color5 = Color.FromArgb(255, Color.FromArgb(raceRecord.Civilian));
                raceRecord.ContactStatusColorDic.Add(AuroraContactStatus.Civilian, color5);
                RaceTitleList.Add(raceRecord.RaceTitle);
                GameRaces.Add(raceRecord.RaceID, raceRecord);
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
                         .ExecuteQuery($"select * from FCT_LagrangePoint where GameID = {GameID.ToString()}").Rows)
            {
                LagrangePoint lp = new LagrangePoint(this);
                int int32_1 = Convert.ToInt32(row["PlanetID"]);
                if (SystemBodyRecordDic.TryGetValue(int32_1, out var value))
                {
                    lp.Planet = value;
                    int int32_2 = Convert.ToInt32(row["StarID"]);
                    if (StarDictionary.TryGetValue(int32_2, out var value1))
                    {
                        lp.Star = value1;
                        int int32_3 = Convert.ToInt32(row["SystemID"]);
                        if (StarSystemDictionary.TryGetValue(int32_3, out var value2))
                        {
                            lp.System = value2;
                            lp.LaGrangePointID = Convert.ToInt32(row["LaGrangePointID"]);
                            lp.XCor = Convert.ToDouble(row["Xcor"]);
                            lp.Ycor = Convert.ToDouble(row["Ycor"]);
                            lp.Distance = Convert.ToDouble(row["Distance"]);
                            lp.Bearing = Convert.ToDouble(row["Bearing"]);
                            LagrangePoints.Add(lp.LaGrangePointID, lp);
                        }
                    }
                }
            }

            foreach (StarSystem gclass200 in StarSystemDictionary.Values)
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
                         .ExecuteQuery($"select * from FCT_PopInstallationDemand where GameID = {GameID.ToString()}").Rows)
            {
                PopInstallationDemand installationDemand = new PopInstallationDemand();
                AuroraInstallationType installationType = (AuroraInstallationType)Convert.ToInt32(row["InstallationID"]);
                if (InstallationTypes.TryGetValue(installationType, out var type))
                {
                    installationDemand.InstallationType = type;
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                    {
                        installationDemand.Population = population;
                        installationDemand.Amount = Convert.ToDecimal(row["Amount"]);
                        installationDemand.Export = Convert.ToBoolean(row["Export"]);
                        installationDemand.NonEssential = Convert.ToBoolean(row["NonEssential"]);
                        installationDemand.Population.InstallationDemands.Add(installationType, installationDemand);
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
                         .ExecuteQuery($"select * from FCT_PopTradeBalance where GameID = {GameID.ToString()}")
                         .Rows)
            {
                PopTradeBalance tradeBalance = new PopTradeBalance();
                int int32_1 = Convert.ToInt32(row["TradeGoodID"]);
                if (TradeGoodsDictionary.TryGetValue(int32_1, out var value))
                {
                    tradeBalance.TradeGood = value;
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.ContainsKey(int32_2))
                    {
                        tradeBalance.Population = Populations[int32_2];
                        tradeBalance.ProductionRate = Convert.ToDecimal(row["ProductionRate"]);
                        tradeBalance.TradeBalance = Convert.ToDecimal(row["TradeBalance"]);
                        tradeBalance.LastTradeBalance = Convert.ToDecimal(row["LastTradeBalance"]);
                        Populations[int32_2].TradeBalances.Add(tradeBalance.TradeGood.TradeGoodID, tradeBalance);
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
                         .ExecuteQuery($"select * from FCT_HullNumber where GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["HullTypeID"]);
                if (ShipHullDictionary.TryGetValue(int32_1, out var value))
                {
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["HullCount"]);
                        GameRaces[int32_2].ShipHullCountDictionary.Add(value, int32_3);
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
                         .ExecuteQuery($"select * from FCT_GroundUnitClass WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                GroundUnitClass101 gclass101 = new GroundUnitClass101(this);
                int int32_1 = Convert.ToInt32(row["TechSystemID"]);
                if (TechDataDictionary.TryGetValue(int32_1, out var value))
                {
                    gclass101.TechData = value;
                    GroundUnitBaseType int32_2 = (GroundUnitBaseType)Convert.ToInt32(row["BaseType"]);
                    if (GroundUnitBaseTypeDictionary.TryGetValue(int32_2, out var value1))
                    {
                        gclass101.GroundUnitBaseTypeData = value1;
                        int int32_3 = Convert.ToInt32(row["ArmourType"]);
                        if (ArmourTypeDictionary.TryGetValue(int32_3, out var value2))
                        {
                            gclass101.ArmourType = value2;
                            GroundUnitComponent int32_4 = (GroundUnitComponent)Convert.ToInt32(row["ComponentA"]);
                            if (GroundUnitComponentDataDictionary.TryGetValue(int32_4, out var value3))
                                gclass101.GroundUnitComponentList.Add(value3);
                            GroundUnitComponent int32_5 = (GroundUnitComponent)Convert.ToInt32(row["ComponentB"]);
                            if (GroundUnitComponentDataDictionary.TryGetValue(int32_5, out var value4))
                                gclass101.GroundUnitComponentList.Add(value4);
                            GroundUnitComponent int32_6 = (GroundUnitComponent)Convert.ToInt32(row["ComponentC"]);
                            if (GroundUnitComponentDataDictionary.TryGetValue(int32_6, out var value5))
                                gclass101.GroundUnitComponentList.Add(value5);
                            GroundUnitComponent int32_7 = (GroundUnitComponent)Convert.ToInt32(row["ComponentD"]);
                            if (GroundUnitComponentDataDictionary.TryGetValue(int32_7, out var value6))
                                gclass101.GroundUnitComponentList.Add(value6);
                            int int32_8 = Convert.ToInt32(row["STOWeapon"]);
                            if (ComponentDataDictionary.TryGetValue(int32_8, out var value7))
                                gclass101.gclass230_0 = value7;
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
                            GroundUnitClassDictionary.Add(gclass101.ClassID, gclass101);
                        }
                    }
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery(
                             $"select * from FCT_GroundUnitCapability WHERE GameID = {GameID.ToString()}").Rows)
            {
                GroundUnitCapability int32_9 = (GroundUnitCapability)Convert.ToInt32(row["CapabilityID"]);
                if (GroundUnitCapabilityDictionary.TryGetValue(int32_9, out var value))
                {
                    int int32_10 = Convert.ToInt32(row["GroundUnitClassID"]);
                    if (GroundUnitClassDictionary.ContainsKey(int32_10))
                        GroundUnitClassDictionary[int32_10].dictionary_0.Add(int32_9, value);
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
                         .ExecuteQuery($"select * from FCT_GroundUnitFormation where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GroundUnitFormationData gclass103 = new GroundUnitFormationData(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass103.RaceData = race;
                    int int32_2 = Convert.ToInt32(row["RequiredRank"]);
                    if (gclass103.RaceData.RacialRankDictionary.TryGetValue(int32_2, out var value))
                        gclass103.RequiredRankData = value;
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
                    if (FormationTemplateRecordDic.TryGetValue(int32_3, out var value1))
                        gclass103.OriginalTemplateData = value1;
                    int int32_4 = Convert.ToInt32(row["ReplacementTemplateID"]);
                    if (FormationTemplateRecordDic.TryGetValue(int32_4, out var value2))
                        gclass103.ReplacementTemplateData = value2;
                    int int32_5 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_5, out var population))
                        gclass103.PopulationData = population;
                    int int32_6 = Convert.ToInt32(row["ShipID"]);
                    if (Ships.TryGetValue(int32_6, out var ship))
                        gclass103.ShipData = ship;
                    if (int32_6 != 0 || int32_5 != 0)
                        FormationDictionary.Add(gclass103.FormationID, gclass103);
                }
            }

            foreach (GroundUnitFormationData gclass103 in FormationDictionary.Values)
            {
                if (gclass103.ParentFormationID > 0 && FormationDictionary.TryGetValue(gclass103.ParentFormationID, out var value))
                    gclass103.ParentFormationData = value;
                if (gclass103.AssignedFormationID > 0 && FormationDictionary.TryGetValue(gclass103.AssignedFormationID, out var value1))
                    gclass103.AssignedFormationData = value1;
            }

            foreach (ShipData gclass40 in Ships.Values
                         .Where(gclass40_0 => gclass40_0.int_31 > 0).ToList())
            {
                if (FormationDictionary.TryGetValue(gclass40.int_31, out var value))
                    gclass40.gclass103_0 = value;
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
                         .ExecuteQuery($"select * from FCT_GroundUnitFormationTemplate where GameID = {GameID.ToString()}").Rows)
            {
                GroundUnitFormationTemplateData gclass102 = new GroundUnitFormationTemplateData(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass102.RaceData = race;
                    int int32_2 = Convert.ToInt32(row["RequiredRank"]);
                    if (gclass102.RaceData.RacialRankDictionary.TryGetValue(int32_2, out var value))
                        gclass102.RequiredRankData = value;
                    gclass102.AutomatedTemplateType = (AutomatedGroundTemplateDesignType)Convert.ToInt32(row["AutomatedTemplateID"]);
                    gclass102.TemplateID = Convert.ToInt32(row["TemplateID"]);
                    gclass102.FormationTrained = Convert.ToInt32(row["FormationsTrained"]);
                    gclass102.Obsolete = Convert.ToInt32(row["Obsolete"]);
                    gclass102.Name = row["Name"].ToString();
                    gclass102.Abbreviation = row["Abbreviation"].ToString();
                    FormationTemplateRecordDic.Add(gclass102.TemplateID, gclass102);
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
                         .ExecuteQuery($"select * from FCT_GroundUnitFormationElement where GameID = {GameID.ToString()}").Rows)
            {
                GroundUnitFormationElement GUElement = new GroundUnitFormationElement(this);
                int int32_1 = Convert.ToInt32(row["FormationID"]);
                if (FormationDictionary.TryGetValue(int32_1, out var value))
                {
                    GUElement.Formation = value;
                    int int32_2 = Convert.ToInt32(row["ClassID"]);
                    if (GroundUnitClassDictionary.TryGetValue(int32_2, out var value1))
                    {
                        GUElement.GroundUnitClass = value1;
                        int int32_3 = Convert.ToInt32(row["SpeciesID"]);
                        if (SpeciesDictionary.TryGetValue(int32_3, out var value2))
                        {
                            GUElement.RaceData = value2;
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
                new SQLiteDatabaseC1181().ExecuteQuery($"select * from FCT_ElementRecharge where GameID = {GameID.ToString()}");
            if (dataTable.Rows.Count == 0)
                return;
            Dictionary<int, GroundUnitFormationElement> dictionary = FormationDictionary.Values
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
                new SQLiteDatabaseC1181().ExecuteQuery($"select * from FCT_STODetected where GameID = {GameID.ToString()}");
            if (dataTable.Rows.Count == 0)
                return;
            Dictionary<int, GroundUnitFormationElement> dictionary = FormationDictionary.Values
                .SelectMany(formationData => formationData.ElementList)
                .ToDictionary(formationElement => formationElement.ElementID, formationElement => formationElement);
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                int detectingRaceID = Convert.ToInt32(row["DetectingRaceID"]);
                if (GameRaces.TryGetValue(detectingRaceID, out var race))
                {
                    int targeElementId = Convert.ToInt32(row["ElementID"]);
                    if (dictionary.ContainsKey(targeElementId))
                        dictionary[targeElementId].DetectingRaceList.Add(race);
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
                if (FormationTemplateRecordDic.TryGetValue(groundFormationTemplateID, out var value))
                {
                    formationElement.FormationTemplate = value;
                    int int32_2 = Convert.ToInt32(row["ClassID"]);
                    if (GroundUnitClassDictionary.TryGetValue(int32_2, out var value1))
                    {
                        formationElement.GroundUnitClass = value1;
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
                         .ExecuteQuery($"select * from FCT_GroundUnitSeries where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GroundUnitSeriesData unitSeries = new GroundUnitSeriesData();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32))
                {
                    unitSeries.GroundUnitSeriesID = Convert.ToInt32(row["GroundUnitSeriesID"]);
                    unitSeries.Description = row["Description"].ToString();
                    GameRaces[int32].GroundUnitSeriesDictionary.Add(unitSeries.GroundUnitSeriesID, unitSeries);
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
                         .ExecuteQuery($"select * from FCT_GroundUnitSeriesClass where GameID = {GameID.ToString()}").Rows)
            {
                GroundUnitSeriesClassData groundUnitSeriesClassData = new GroundUnitSeriesClassData();
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(raceID))
                {
                    int unitClassId = Convert.ToInt32(row["GroundUnitClassID"]);
                    if (GroundUnitClassDictionary.TryGetValue(unitClassId, out var value))
                    {
                        groundUnitSeriesClassData.UnitClass = value;
                        int seriesID = Convert.ToInt32(row["GroundUnitSeriesID"]);
                        if (GameRaces[raceID].GroundUnitSeriesDictionary.ContainsKey(seriesID))
                        {
                            groundUnitSeriesClassData.UnitSeriesData = GameRaces[raceID].GroundUnitSeriesDictionary[seriesID];
                            groundUnitSeriesClassData.Priority = Convert.ToInt32(row["Priority"]);
                            GameRaces[raceID].GroundUnitSeriesClassList.Add(groundUnitSeriesClassData);
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
                         .ExecuteQuery($"select * from FCT_OrderTemplate where GameID = {GameID.ToString()}").Rows)
            {
                OrderTemplateData orderTemplate = new OrderTemplateData(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(raceID, out var race))
                {
                    orderTemplate.RaceData = race;
                    int int32_2 = Convert.ToInt32(row["StartSystemID"]);
                    if (orderTemplate.RaceData.RacialSystemDictionary.TryGetValue(int32_2, out var value))
                    {
                        orderTemplate.RaceSystem = value;
                        orderTemplate.OrderTemplateID = Convert.ToInt32(row["OrderTemplateID"]);
                        orderTemplate.TemplateName = row["TemplateName"].ToString();
                        MoveOrderTemplateDictionary.Add(orderTemplate.OrderTemplateID, orderTemplate);
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
                         .ExecuteQuery($"select * from FCT_ShippingWealthData where GameID = {GameID.ToString()}")
                         .Rows)
            {
                ShippingWealthData shippingLineWealthData = new ShippingWealthData();
                int shippingLineID = Convert.ToInt32(row["ShippingLineID"]);
                if (ShippingLineDictionary.TryGetValue(shippingLineID, out var value))
                {
                    shippingLineWealthData.ShippingLine = value;
                    int int32_2 = Convert.ToInt32(row["OriginPop"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                    {
                        shippingLineWealthData.OriginPop = population;
                        int int32_3 = Convert.ToInt32(row["DestinationPop"]);
                        if (Populations.TryGetValue(int32_3, out var population1))
                        {
                            shippingLineWealthData.DestinationPop = population1;
                            int int32_4 = Convert.ToInt32(row["TradeGood"]);
                            if (TradeGoodsDictionary.TryGetValue(int32_4, out var value1))
                                shippingLineWealthData.TradeGood = value1;
                            int int32_5 = Convert.ToInt32(row["ShipID"]);
                            if (Ships.TryGetValue(int32_5, out var ship))
                                shippingLineWealthData.Ship = ship;
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
                             $"SELECT * FROM FCT_MoveOrders WHERE GameID = {GameID.ToString()} ORDER BY MoveOrder")
                         .Rows)
            {
                MoveOrder MoveOrder = new MoveOrder();
                int raceId = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(raceId, out var race))
                {
                    MoveOrder.Race = race;
                    int int32_2 = Convert.ToInt32(row["FleetID"]);
                    if (FleetDictionary.TryGetValue(int32_2, out var value))
                    {
                        MoveOrder.Fleet = value;
                        int startSystemID = Convert.ToInt32(row["StartSystemID"]);
                        if (MoveOrder.Race.RacialSystemDictionary.TryGetValue(startSystemID, out var value1))
                        {
                            MoveOrder.StartSystem = value1;
                            //Convert.ToInt32(row["MoveActionID"]); //Garbage, I disabled it. probably just not cleaned up by original author
                            MoveOrder.MoveActionType = MoveActionDictionary[(MoveActionType)Convert.ToInt32(row["MoveActionID"])];
                            int int32_4 = Convert.ToInt32(row["NewSystemID"]);
                            if (int32_4 > 0)
                            {
                                if (MoveOrder.Race.RacialSystemDictionary.TryGetValue(int32_4, out var value2))
                                    MoveOrder.NewSystem = value2;
                                else
                                    continue;
                            }

                            int int32_5 = Convert.ToInt32(row["NewWarpPointID"]);
                            if (int32_5 > 0)
                            {
                                if (JumpPointDictionary.TryGetValue(int32_5, out var value2))
                                    MoveOrder.NewJumpPoint = value2;
                                else
                                    continue;
                            }

                            int int32_6 = Convert.ToInt32(row["PopulationID"]);
                            if (int32_6 > 0)
                            {
                                if (Populations.TryGetValue(int32_6, out var population))
                                    MoveOrder.Population = population;
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
                         .ExecuteQuery($"select * FROM FCT_MoveOrderTemplate WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                TMoveOrder moveOrder = new TMoveOrder(this);
                int orderTemplateID = Convert.ToInt32(row["OrderTemplateID"]);
                if (MoveOrderTemplateDictionary.TryGetValue(orderTemplateID, out var value))
                {
                    moveOrder.OrderTemplate = value;
                    int startSystemID = Convert.ToInt32(row["StartSystemID"]);
                    if (moveOrder.OrderTemplate.RaceData.RacialSystemDictionary.TryGetValue(startSystemID, out var value1))
                    {
                        moveOrder.StartSystem = value1;
                        Convert.ToInt32(row["MoveActionID"]);
                        moveOrder.MoveAction = MoveActionDictionary[(MoveActionType)Convert.ToInt32(row["MoveActionID"])];
                        int int32_3 = Convert.ToInt32(row["NewSystemID"]);
                        if (moveOrder.OrderTemplate.RaceData.RacialSystemDictionary.TryGetValue(int32_3, out var value2))
                            moveOrder.NewSystem = value2;
                        int int32_4 = Convert.ToInt32(row["NewJumpPointID"]);
                        if (JumpPointDictionary.TryGetValue(int32_4, out var value3))
                            moveOrder.NewJumpPoint = value3;
                        int int32_5 = Convert.ToInt32(row["PopulationID"]);
                        if (Populations.TryGetValue(int32_5, out var population))
                            moveOrder.Population = population;
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
                         .ExecuteQuery($"select * from FCT_SystemBody where GameID = {GameID.ToString()}").Rows)
            {
                SystemBodyData systemBody = new SystemBodyData(this);
                PlanetDominantTerrain int32 = (PlanetDominantTerrain)Convert.ToInt32(row["DominantTerrain"]);
                systemBody.DominantTerrain = !DominantTerrainTypeDictionary.TryGetValue(int32, out var value)
                    ? DominantTerrainTypeDictionary[PlanetDominantTerrain.const_0]
                    : value;
                systemBody.SystemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                systemBody.SystemID = Convert.ToInt32(row["SystemID"]);
                systemBody.StarID = Convert.ToInt32(row["StarID"]);
                if (StarSystemDictionary.TryGetValue(systemBody.SystemID, out var value1))
                {
                    systemBody.SystemData = value1;
                    if (StarDictionary.TryGetValue(systemBody.StarID, out var value2))
                    {
                        systemBody.StarData = value2;
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
                                systemBody.RuinRaceData = RuinRaceDictionary[systemBody.RuinRaceID];
                                systemBody.RuinData = RuinDefinitionDictionary[systemBody.RuinID];
                            }
                            else
                            {
                                systemBody.AbandonedFactories = 0;
                                systemBody.RuinRaceID = 0;
                                systemBody.RuinID = 0;
                            }
                        }

                        systemBody.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.BasicUpdate;
                        SystemBodyRecordDic.Add(systemBody.SystemBodyID, systemBody);
                    }
                }
            }

            method_573();
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
                         .ExecuteQuery($"select * FROM FCT_SubFleets WHERE GameID = {GameID.ToString()}").Rows)
            {
                SubFleet subFleet = new SubFleet(this);
                int raceID = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(raceID, out var race))
                {
                    int parentFleetID = Convert.ToInt32(row["ParentFleetID"]);
                    if (FleetDictionary.TryGetValue(parentFleetID, out var value))
                    {
                        subFleet.AnchorFleetID = Convert.ToInt32(row["AnchorFleetID"]);
                        if (FleetDictionary.TryGetValue(subFleet.AnchorFleetID, out var value1))
                            subFleet.AnchorFleet = value1;
                        subFleet.Race = race;
                        subFleet.ParentFleet = value;
                        subFleet.SubFleetID = Convert.ToInt32(row["SubFleetID"]);
                        subFleet.ParentSubFleetID = Convert.ToInt32(row["ParentSubFleetID"]);
                        subFleet.SubFleetName = row["SubFleetName"].ToString();
                        subFleet.SpecificThreatID = Convert.ToInt32(row["SpecificThreatID"]);
                        subFleet.AnchorFleetBearingOffset = Convert.ToInt32(row["AnchorFleetBearingOffset"]);
                        subFleet.AnchorFleetDistance = Convert.ToDouble(row["AnchorFleetDistance"]);
                        subFleet.bGuardNearestHostileContact = Convert.ToBoolean(row["GuardNearestHostileContact"]);
                        subFleet.bGuardNearestKnownWarship = Convert.ToBoolean(row["GuardNearestKnownWarship"]);
                        subFleet.bUseAnchorDestination = Convert.ToBoolean(row["UseAnchorDestination"]);
                        SubFleetDictionary.Add(subFleet.SubFleetID, subFleet);
                    }
                }
            }

            foreach (SubFleet subFleet in SubFleetDictionary.Values)
            {
                if (SubFleetDictionary.TryGetValue(subFleet.ParentSubFleetID, out var value))
                    subFleet.ParentSubFleet = value;
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
                         .ExecuteQuery($"select * FROM FCT_FleetStandingOrder WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                AuroraStandingOrder standingOrderType = (AuroraStandingOrder)Convert.ToInt32(row["StandingOrderID"]);
                if (StandingOrderDictionary.TryGetValue(standingOrderType, out var value))
                {
                    int int32_2 = Convert.ToInt32(row["FleetID"]);
                    if (FleetDictionary.ContainsKey(int32_2))
                    {
                        int priority = Convert.ToInt32(row["Priority"]);
                        FleetDictionary[int32_2].StandingOrdersDictionary.Add(priority, value);
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
                         .ExecuteQuery($"select * FROM FCT_FleetConditionalOrder WHERE GameID = {GameID.ToString()}").Rows)
            {
                AuroraStandingOrder standingOrderType = (AuroraStandingOrder)Convert.ToInt32(row["ConditionalOrderID"]);
                if (StandingOrderDictionary.ContainsKey(standingOrderType))
                {
                    AuroraFleetCondition conditionType = (AuroraFleetCondition)Convert.ToInt32(row["ConditionID"]);
                    if (FleetConditionDictionary.ContainsKey(conditionType))
                    {
                        int fleetId = Convert.ToInt32(row["FleetID"]);
                        if (FleetDictionary.ContainsKey(fleetId))
                        {
                            int priority = Convert.ToInt32(row["Priority"]);
                            int createFWP = Convert.ToInt32(row["CreateFWP"]);
                            FleetDictionary[fleetId].ConditionalOrdersDictionary.Add(priority, new FleetConditionalOrder()
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
                         .ExecuteQuery($"select * FROM FCT_Fleet WHERE GameID = {GameID.ToString()}").Rows)
            {
                try
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    LambdaScope86 lambdaScope86 = new LambdaScope86();
                    // ISSUE: reference to a compiler-generated field
                    lambdaScope86.Fleet = new FleetData(this);
                    int raceID = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.TryGetValue(raceID, out var race))
                    {
                        // ISSUE: reference to a compiler-generated field
                        lambdaScope86.Fleet.Race = race;
                        int systemID = Convert.ToInt32(row["SystemID"]);
                        if (StarSystemDictionary.ContainsKey(systemID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            lambdaScope86.Fleet.System = lambdaScope86.Fleet.Race.RacialSystemDictionary[systemID];
                            int parentCommandID = Convert.ToInt32(row["ParentCommandID"]);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            lambdaScope86.Fleet.ParentNavalCommand = !NavalAdminCommands.TryGetValue(parentCommandID, out var command)
                                ? NavalAdminCommands.Values.FirstOrDefault(lambdaScope86.method_0)
                                : command;
                            int int32_4 = Convert.ToInt32(row["OrbitBodyID"]);
                            if (SystemBodyRecordDic.TryGetValue(int32_4, out var value))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.OrbitingBody = value;
                            }

                            int int32_5 = Convert.ToInt32(row["EntryJPID"]);
                            if (JumpPointDictionary.TryGetValue(int32_5, out var value1))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.EntryJumpPoint = value1;
                            }

                            int int32_6 = Convert.ToInt32(row["ShippingLine"]);
                            if (ShippingLineDictionary.TryGetValue(int32_6, out var value2))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.ShippingLine = value2;
                            }

                            int int32_7 = Convert.ToInt32(row["AssignedPopulationID"]);
                            if (Populations.TryGetValue(int32_7, out var population))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.AssignedPopulation = population;
                            }

                            OperationalGroupID int32_8 = (OperationalGroupID)Convert.ToInt32(row["NPROperationalGroupID"]);
                            if (OperationalGroupDictionary.TryGetValue(int32_8, out var value3))
                            {
                                // ISSUE: reference to a compiler-generated field
                                lambdaScope86.Fleet.NPROperationGroup = value3;
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
                            FleetDictionary.Add(lambdaScope86.Fleet.FleetID, lambdaScope86.Fleet);
                        }
                    }
                }
                catch (Exception ex)
                {
                    AuroraUtils.ShowExceptionPopup(ex, 3248);
                    return;
                }
            }

            foreach (FleetData fleet in FleetDictionary.Values)
            {
                if (FleetDictionary.TryGetValue(fleet.AnchorFleetID, out var value))
                    fleet.AnchorFleet = value;
            }

            foreach (PopulationData population in Populations.Values
                         .Where(pop => pop.FighterDestFleetID > 0).ToList())
            {
                if (FleetDictionary.TryGetValue(population.FighterDestFleetID, out var value))
                    population.FighterDestFleet = value;
            }

            foreach (PopulationData population in Populations.Values
                         .Where(pop => pop.SpaceStationDestFleetID > 0).ToList())
            {
                if (FleetDictionary.TryGetValue(population.SpaceStationDestFleetID, out var value))
                    population.SpaceStationDestFleet = value;
            }

            foreach (PopulationData population in Populations.Values
                         .Where(pop => pop.ParasiteSourceID > 0).ToList())
            {
                if (FleetDictionary.TryGetValue(population.ParasiteSourceID, out var value))
                    population.ParasiteSource = value;
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

    public void LoadPopulationInstallations()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PopulationInstallations WHERE GameID = {GameID.ToString()}").Rows)
            {
                PopulationInstallation popInstallation = new PopulationInstallation();
                int int32_1 = Convert.ToInt32(row["PopID"]);
                if (Populations.ContainsKey(int32_1))
                {
                    popInstallation.Population = Populations[int32_1];
                    popInstallation.Ship = null;
                    AuroraInstallationType installationType =
                        (AuroraInstallationType)Convert.ToInt32(row["PlanetaryInstallationID"]);
                    if (InstallationTypes.TryGetValue(installationType, out var type))
                    {
                        popInstallation.InstallationType = type;
                        popInstallation.Amount = Convert.ToDecimal(row["Amount"]);
                        Populations[int32_1].dictionary_0.Add(installationType, popInstallation);
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

    public void LoadShipCargo()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipCargo WHERE GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(int32_1))
                {
                    int startingPopID = Convert.ToInt32(row["StartingPop"]);
                    PopulationData originPopulation;
                    switch (Convert.ToInt32(row["CargoTypeID"]))
                    {
                        case 1:
                            int int32_3 = Convert.ToInt32(row["SpeciesID"]);
                            if (SpeciesDictionary.TryGetValue(int32_3, out var value))
                            {
                                TransportedColonist tColonist = new TransportedColonist();
                                tColonist.Species = value;
                                tColonist.Amount = Convert.ToInt32(row["Amount"]);
                                tColonist.Neutral = Convert.ToBoolean(row["Neutral"]);
                                if (Populations.TryGetValue(startingPopID, out originPopulation))
                                {
                                    tColonist.PopOrigin = originPopulation;
                                }
                                Ships[int32_1].TransportedColonists.Add(tColonist);
                                continue;
                            }

                            continue;
                        case 2:
                            PopulationInstallation installation = new PopulationInstallation();
                            AuroraInstallationType installationID = (AuroraInstallationType)Convert.ToInt32(row["CargoID"]);
                            installation.InstallationType = InstallationTypes[installationID];
                            installation.Amount = Convert.ToDecimal(row["Amount"]);
                            installation.Ship = Ships[int32_1];
                            installation.Population = null;
                            if (Populations.TryGetValue(startingPopID, out originPopulation))
                            {
                                installation.PopOrigin = originPopulation;
                            }
                            Ships[int32_1].TransportedInstallations.Add(installationID, installation);
                            continue;
                        case 3:
                            AuroraElement mineralElement = (AuroraElement)Convert.ToInt32(row["CargoID"]);
                            Decimal amount = Convert.ToDecimal(row["Amount"]);
                            Ships[int32_1].TransportedMineral.AddSpecific(mineralElement, amount);
                            continue;
                        case 6:
                            TransportedComponent tComponent = new TransportedComponent();
                            int int32_6 = Convert.ToInt32(row["CargoID"]);
                            if (ComponentDataDictionary.TryGetValue(int32_6, out var value1))
                            {
                                tComponent.Component = value1;
                                tComponent.Amount = Convert.ToDecimal(row["Amount"]);
                                if (Populations.TryGetValue(startingPopID, out var population1))
                                    tComponent.PopOrigin = population1;
                                Ships[int32_1].TransportedComponents.Add(tComponent);
                            }
                            continue;
                        case 7:
                            TransportedTradeGood tGood = new TransportedTradeGood();
                            int goodsID = Convert.ToInt32(row["CargoID"]);
                            if (TradeGoodsDictionary.TryGetValue(goodsID, out var value2))
                            {
                                tGood.TradeGood = value2;
                                tGood.Amount = Convert.ToDecimal(row["Amount"]);
                                tGood.Ship = Ships[int32_1];
                                if (Populations.TryGetValue(startingPopID, out var population1))
                                    tGood.PopOrigin = population1;
                                Ships[int32_1].TransportedTradeGoods.Add(goodsID, tGood);
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

    public void LoadPopulations()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Population WHERE GameID = {GameID.ToString()}").Rows)
            {
                PopulationData popData = new PopulationData(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    popData.Race = race;
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (SpeciesDictionary.TryGetValue(int32_2, out var value))
                    {
                        popData.Species = value;
                        int int32_3 = Convert.ToInt32(row["GenModSpeciesID"]);
                        if (SpeciesDictionary.TryGetValue(int32_3, out var value1))
                            popData.GenModSpeciesData = value1;
                        int int32_4 = Convert.ToInt32(row["SystemID"]);
                        if (popData.Race.RacialSystemDictionary.TryGetValue(int32_4, out var value2))
                        {
                            popData.gclass202_0 = value2;
                            int int32_5 = Convert.ToInt32(row["SystemBodyID"]);
                            if (SystemBodyRecordDic.TryGetValue(int32_5, out var value3))
                            {
                                popData.SystemBodyData = value3;
                                int int32_6 = Convert.ToInt32(row["OriginalRaceID"]);
                                if (GameRaces.TryGetValue(int32_6, out var gameRace))
                                    popData.gclass21_1 = gameRace;
                                popData.FighterDestFleetID = Convert.ToInt32(row["FighterDestFleetID"]);
                                popData.SpaceStationDestFleetID = Convert.ToInt32(row["SpaceStationDestFleetID"]);
                                popData.ParasiteSourceID = Convert.ToInt32(row["ParasiteSourceID"]);
                                GasType int32_7 = (GasType)Convert.ToInt32(row["TerraformingGasID"]);
                                if (AtmosphericGasDictionary.TryGetValue(int32_7, out var value4))
                                    popData.TerraformingTargetGas = value4;
                                PopPoliticalStatusType int32_8 = (PopPoliticalStatusType)Convert.ToInt32(row["PoliticalStatus"]);
                                if (PopulationPoliticalStatusDictionary.TryGetValue(int32_8, out var value5))
                                    popData.PopulationPoliticalStatus = value5;
                                popData.PopulationID = Convert.ToInt32(row["PopulationID"]);
                                popData.TerraformStatus = (TerraformStatus)Convert.ToInt32(row["TerraformStatus"]);
                                popData.NoStatusChange = Convert.ToInt32(row["NoStatusChange"]);
                                popData.ProvideColonists = Convert.ToInt32(row["ProvideColonists"]);
                                popData.ReqInf = Convert.ToInt32(row["ReqInf"]);
                                popData.TempMF = Convert.ToInt32(row["TempMF"]);
                                popData.MassDriverDestPopulationID = Convert.ToInt32(row["MassDriverDest"]);
                                popData.GroundAttackID = Convert.ToInt32(row["GroundAttackID"]);
                                popData.ColonistDestinationSetting = (PopColonistSetting)Convert.ToInt32(row["ColonistDestination"]);
                                popData.DestroyedInstallationSize = Convert.ToInt32(row["DestroyedInstallationSize"]);
                                popData.Importance = Convert.ToInt32(row["Importance"]);
                                popData.BonusOne = (CommanderBonusType)Convert.ToInt32(row["BonusOne"]);
                                popData.BonusTwo = (CommanderBonusType)Convert.ToInt32(row["BonusTwo"]);
                                popData.BonusThree = (CommanderBonusType)Convert.ToInt32(row["BonusThree"]);
                                popData.genum64_0 = (GEnum64)Convert.ToInt32(row["AutoAssign"]);
                                popData.WarningFuel = Convert.ToInt32(row["WarningFuel"]);
                                popData.WarningMSP = Convert.ToInt32(row["WarningMSP"]);
                                popData.WarningConstant = Convert.ToInt32(row["WarningConstant"]);
                                popData.AcademyOfficers = Convert.ToDecimal(row["AcademyOfficers"]);
                                popData.Efficiency = Convert.ToDecimal(row["Efficiency"]);
                                popData.FuelStockpile = Convert.ToDecimal(row["FuelStockpile"]);
                                popData.LastColonyCost = Convert.ToDecimal(row["LastColonyCost"]);
                                popData.MaintenanceStockpile = Convert.ToDecimal(row["MaintenanceStockpile"]);
                                popData.MaxAtm = Convert.ToDouble(row["MaxAtm"]);
                                popData.Population = Convert.ToDecimal(row["Population"]);
                                popData.PreviousUnrest = Convert.ToDecimal(row["PreviousUnrest"]);
                                popData.StatusPoints = Convert.ToDecimal(row["StatusPoints"]);
                                popData.UnrestPoints = Convert.ToDecimal(row["UnrestPoints"]);
                                popData.GroundGeoSurvey = Convert.ToDecimal(row["GroundGeoSurvey"]);
                                popData.AvailableColonists = Convert.ToDecimal(row["AvailableColonists"]);
                                popData.ColonizationPressure = Convert.ToDecimal(row["ColonizationPressure"]);
                                popData.bIsCapital = Convert.ToBoolean(row["Capital"]);
                                popData.bPurchaseCivilianMineral = Convert.ToBoolean(row["PurchaseCivilianMinerals"]);
                                popData.bFuelProdStatus = Convert.ToBoolean(row["FuelProdStatus"]);
                                popData.bMaintProdStatus = Convert.ToBoolean(row["MaintProdStatus"]);
                                popData.bGeneticProdStatus = Convert.ToBoolean(row["GeneticProdStatus"]);
                                popData.bIsInvasionStagingPoint = Convert.ToBoolean(row["InvasionStagingPoint"]);
                                popData.bDoNotDelete = Convert.ToBoolean(row["DoNotDelete"]);
                                popData.bMilitaryRestrictedColony = Convert.ToBoolean(row["MilitaryRestrictedColony"]);
                                popData.bAutoRefuel = Convert.ToBoolean(row["AutoRefuel"]);
                                popData.AcademyName = row["AcademyName"].ToString();
                                popData.PopName = row["PopName"].ToString();
                                if (popData.PopName == "")
                                    popData.PopName =
                                        popData.SystemBodyData.BodyTypeId == AuroraSystemBodyType.Asteroid ||
                                        popData.SystemBodyData.BodyTypeId == AuroraSystemBodyType.Comet
                                            ? $"{popData.gclass202_0.Name} {popData.SystemBodyData.method_78(popData.Race)}"
                                            : popData.SystemBodyData.method_78(popData.Race);
                                popData.CurrentMinerals = new AllMineralsValue(this);
                                popData.gclass123_3 = new AllMineralsValue(this);
                                popData.LastMinerals = new AllMineralsValue(this);
                                popData.ReserveMinerals = new AllMineralsValue(this);
                                popData.gclass123_4 = new AllMineralsValue(this);
                                popData.CurrentMinerals.Duranium = Convert.ToDecimal(row["Duranium"]);
                                popData.CurrentMinerals.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                                popData.CurrentMinerals.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                                popData.CurrentMinerals.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                                popData.CurrentMinerals.Boronide = Convert.ToDecimal(row["Boronide"]);
                                popData.CurrentMinerals.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                                popData.CurrentMinerals.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                                popData.CurrentMinerals.Sorium = Convert.ToDecimal(row["Sorium"]);
                                popData.CurrentMinerals.Uridium = Convert.ToDecimal(row["Uridium"]);
                                popData.CurrentMinerals.Corundium = Convert.ToDecimal(row["Corundium"]);
                                popData.CurrentMinerals.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                                popData.LastMinerals.Duranium = Convert.ToDecimal(row["LastDuranium"]);
                                popData.LastMinerals.Neutronium = Convert.ToDecimal(row["LastNeutronium"]);
                                popData.LastMinerals.Corbomite = Convert.ToDecimal(row["LastCorbomite"]);
                                popData.LastMinerals.Tritanium = Convert.ToDecimal(row["LastTritanium"]);
                                popData.LastMinerals.Boronide = Convert.ToDecimal(row["LastBoronide"]);
                                popData.LastMinerals.Mercassium = Convert.ToDecimal(row["LastMercassium"]);
                                popData.LastMinerals.Vendarite = Convert.ToDecimal(row["LastVendarite"]);
                                popData.LastMinerals.Sorium = Convert.ToDecimal(row["LastSorium"]);
                                popData.LastMinerals.Uridium = Convert.ToDecimal(row["LastUridium"]);
                                popData.LastMinerals.Corundium = Convert.ToDecimal(row["LastCorundium"]);
                                popData.LastMinerals.Gallicite = Convert.ToDecimal(row["LastGallicite"]);
                                popData.ReserveMinerals.Duranium = Convert.ToDecimal(row["ReserveDuranium"]);
                                popData.ReserveMinerals.Neutronium = Convert.ToDecimal(row["ReserveNeutronium"]);
                                popData.ReserveMinerals.Corbomite = Convert.ToDecimal(row["ReserveCorbomite"]);
                                popData.ReserveMinerals.Tritanium = Convert.ToDecimal(row["ReserveTritanium"]);
                                popData.ReserveMinerals.Boronide = Convert.ToDecimal(row["ReserveBoronide"]);
                                popData.ReserveMinerals.Mercassium = Convert.ToDecimal(row["ReserveMercassium"]);
                                popData.ReserveMinerals.Vendarite = Convert.ToDecimal(row["ReserveVendarite"]);
                                popData.ReserveMinerals.Sorium = Convert.ToDecimal(row["ReserveSorium"]);
                                popData.ReserveMinerals.Uridium = Convert.ToDecimal(row["ReserveUridium"]);
                                popData.ReserveMinerals.Corundium = Convert.ToDecimal(row["ReserveCorundium"]);
                                popData.ReserveMinerals.Gallicite = Convert.ToDecimal(row["ReserveGallicite"]);
                                popData.decimal_33 = 1M - popData.UnrestPoints / 100M;
                                popData.SystemBodyData.method_58(popData.Race, popData.Species, true);
                                popData.ColonyCost = popData.SystemBodyData.ColonyCost;
                                popData.MaxColonyCost = popData.SystemBodyData.MaxColonyCost;
                                Populations.Add(popData.PopulationID, popData);
                                if (popData.Race.NPR)
                                {
                                    popData.gclass6_0 = new GClass6(this, popData);
                                    popData.gclass6_0.genum97_0 = (GEnum97)Convert.ToInt32(row["AIValue"]);
                                }
                            }
                        }
                    }
                }
            }

            foreach (PopulationData population in Populations.Values)
            {
                if (Populations.TryGetValue(population.MassDriverDestPopulationID, out var population1))
                    population.MassDriverDestPopulation = population1;
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

    public void LoadMineralDeposits()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MineralDeposit WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                MineralDeposit deposit = new MineralDeposit();
                deposit.SystemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                if (SystemBodyRecordDic.ContainsKey(deposit.SystemBodyID))
                {
                    deposit.MaterialID = (AuroraElement)Convert.ToInt32(row["MaterialID"]);
                    deposit.Amount = Convert.ToDecimal(row["Amount"]);
                    deposit.Accessibility = Convert.ToDecimal(row["Accessibility"]);
                    deposit.HalfOriginalAmount = Convert.ToDecimal(row["HalfOriginalAmount"]);
                    deposit.OriginalAcc = Convert.ToDecimal(row["OriginalAcc"]);
                    SystemBodyRecordDic[deposit.SystemBodyID].MineralDeposits.Add(deposit.MaterialID, deposit);
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

    public void LoadShipClasses()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ShipClass WHERE GameID = {GameID.ToString()}").Rows)
            {
                ShipClass shipClass = new ShipClass(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    shipClass.Race = race;
                    int int32_2 = Convert.ToInt32(row["ClassShippingLineID"]);
                    if (ShippingLineDictionary.TryGetValue(int32_2, out var value))
                        shipClass.gclass187_0 = value;
                    int int32_3 = Convert.ToInt32(row["HullDescriptionID"]);
                    if (ShipHullDictionary.TryGetValue(int32_3, out var value1))
                    {
                        shipClass.ShipHull = value1;
                        int nameThemeID = Convert.ToInt32(row["NameThemeID"]);
                        shipClass.NameTheme = !ThemeDictionary.TryGetValue(nameThemeID, out var value2)
                            ? ThemeDictionary[1]
                            : value2;
                        AutomatedClassDesignType int32_5 = (AutomatedClassDesignType)Convert.ToInt32(row["AutomatedDesignID"]);
                        if (AutomatedClassDesignDictionary.TryGetValue(int32_5, out var value3))
                            shipClass.AutomatedClassDesign = value3;
                        TechType troopTransportTechType = (TechType)Convert.ToInt32(row["TroopTransportType"]);
                        shipClass.gclass163_0 =
                            TechTypeDataDictionary.TryGetValue(troopTransportTechType, out var value4) ? value4 : null;
                        shipClass.RankRequired = Convert.ToInt32(row["RankRequired"]);
                        if (shipClass.Race.SpecialNPRID == SpecialNPRIDs.const_0 ||
                            shipClass.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                        {
                            shipClass.RankTheme =
                                shipClass.Race.GetRankThemeForCommanderLevel((CommanderLevel)shipClass.RankRequired, AuroraCommanderType.Naval);
                            if (shipClass.RankTheme == null)
                                shipClass.RankTheme = shipClass.Race.GetHighestRankThemeForCommanderType(AuroraCommanderType.Naval);
                        }

                        shipClass.ShipClassID = Convert.ToInt32(row["ShipClassID"]);
                        shipClass.ActiveSensorStrength = Convert.ToInt32(row["ActiveSensorStrength"]);
                        shipClass.ArmourThickness = Convert.ToInt32(row["ArmourThickness"]);
                        shipClass.ArmourWidth = Convert.ToInt32(row["ArmourWidth"]);
                        shipClass.Collier = Convert.ToInt32(row["Collier"]);
                        shipClass.SeniorCO = Convert.ToInt32(row["SeniorCO"]);
                        shipClass.ColonistCapacity = Convert.ToInt32(row["ColonistCapacity"]);
                        shipClass.CommanderPriority = Convert.ToInt32(row["CommanderPriority"]);
                        shipClass.CommercialJumpDrive = Convert.ToInt32(row["CommercialJumpDrive"]);
                        shipClass.ControlRating = Convert.ToInt32(row["ControlRating"]);
                        shipClass.ConscriptOnly = Convert.ToInt32(row["ConscriptOnly"]);
                        shipClass.NoOfficers = Convert.ToInt32(row["NoOfficers"]);
                        shipClass.Crew = Convert.ToInt32(row["Crew"]);
                        shipClass.DCRating = Convert.ToInt32(row["DCRating"]);
                        shipClass.EMSensorStrength = Convert.ToInt32(row["EMSensorStrength"]);
                        shipClass.EnginePower = Convert.ToInt32(row["EnginePower"]);
                        shipClass.ESMaxDACRoll = Convert.ToInt32(row["ESMaxDACRoll"]);
                        shipClass.FuelTanker = Convert.ToInt32(row["FuelTanker"]);
                        shipClass.GravSurvey = Convert.ToInt32(row["GravSurvey"]);
                        shipClass.Harvesters = Convert.ToInt32(row["Harvesters"]);
                        shipClass.JGConstructionTime = Convert.ToInt32(row["JGConstructionTime"]);
                        shipClass.JumpDistance = Convert.ToInt32(row["JumpDistance"]);
                        shipClass.JumpRating = Convert.ToInt32(row["JumpRating"]);
                        shipClass.MaxChance = Convert.ToInt32(row["MaxChance"]);
                        shipClass.MaxDACRoll = Convert.ToInt32(row["MaxDACRoll"]);
                        shipClass.MaxSpeed = Convert.ToInt32(row["MaxSpeed"]);
                        shipClass.MaintModules = Convert.ToInt32(row["MaintModules"]);
                        shipClass.MiningModules = Convert.ToInt32(row["MiningModules"]);
                        shipClass.NoArmour = Convert.ToInt32(row["NoArmour"]);
                        shipClass.MainFunction =
                            (AuroraClassMainFunction)Convert.ToInt32(row["MainFunction"]);
                        shipClass.Obsolete = Convert.ToInt32(row["Obsolete"]);
                        shipClass.OtherRaceClassID = Convert.ToInt32(row["OtherRaceClassID"]);
                        shipClass.PassiveSensorStrength = Convert.ToInt32(row["PassiveSensorStrength"]);
                        shipClass.ReactorPower = Convert.ToInt32(row["ReactorPower"]);
                        shipClass.RequiredPower = Convert.ToInt32(row["RequiredPower"]);
                        shipClass.SalvageRate = Convert.ToInt32(row["SalvageRate"]);
                        shipClass.ShieldStrength = Convert.ToInt32(row["ShieldStrength"]);
                        shipClass.MaintSupplies = Convert.ToInt32(row["MaintSupplies"]);
                        shipClass.STSTractor = Convert.ToInt32(row["STSTractor"]);
                        shipClass.SupplyShip = Convert.ToInt32(row["SupplyShip"]);
                        shipClass.Terraformers = Convert.ToInt32(row["Terraformers"]);
                        shipClass.TotalNumber = Convert.ToInt32(row["TotalNumber"]);
                        shipClass.CargoShuttleStrength = Convert.ToInt32(row["CargoShuttleStrength"]);
                        shipClass.TroopCapacity = Convert.ToInt32(row["TroopCapacity"]);
                        shipClass.WorkerCapacity = Convert.ToInt32(row["WorkerCapacity"]);
                        shipClass.CargoCapacity = Convert.ToInt32(row["CargoCapacity"]);
                        shipClass.FuelCapacity = Convert.ToInt32(row["FuelCapacity"]);
                        shipClass.RefuellingRate = Convert.ToInt32(row["RefuellingRate"]);
                        shipClass.RefuelPriority = Convert.ToInt32(row["RefuelPriority"]);
                        shipClass.ResupplyPriority = Convert.ToInt32(row["ResupplyPriority"]);
                        shipClass.MinimumFuel = Convert.ToInt32(row["MinimumFuel"]);
                        shipClass.MinimumSupplies = Convert.ToInt32(row["MinimumSupplies"]);
                        shipClass.MaintPriority = Convert.ToInt32(row["MaintPriority"]);
                        shipClass.OrdnanceTransferRate = Convert.ToInt32(row["OrdnanceTransferRate"]);
                        shipClass.OrdnanceTransferHub = Convert.ToInt32(row["OrdnanceTransferHub"]);
                        shipClass.ELINTRating = Convert.ToInt32(row["ELINTRating"]);
                        shipClass.DiplomacyRating = Convert.ToInt32(row["DiplomacyRating"]);
                        shipClass.BioEnergyCapacity = Convert.ToInt32(row["BioEnergyCapacity"]);
                        shipClass.RandomShipNameFromTheme = Convert.ToInt32(row["RandomShipNameFromTheme"]);
                        shipClass.ClassHullNumbers = Convert.ToInt32(row["ClassHullNumbers"]);
                        shipClass.RepairYardCapacity = Convert.ToInt32(row["RepairYardCapacity"]);
                        shipClass.PDProtectionPriority = Convert.ToInt32(row["PDProtectionPriority"]);
                        shipClass.ActiveJammerStrength = Convert.ToDecimal(row["ActiveJammerStrength"]);
                        shipClass.FireControlJammerStrength = Convert.ToDecimal(row["FireControlJammerStrength"]);
                        shipClass.MissileJammerStrength = Convert.ToDecimal(row["MissileJammerStrength"]);
                        shipClass.MagazineCapacity = Convert.ToDecimal(row["MagazineCapacity"]);
                        shipClass.DecoyCapacity = Convert.ToDecimal(row["DecoyCapacity"]);
                        shipClass.BaseFailureChance = Convert.ToDecimal(row["BaseFailureChance"]);
                        shipClass.ClassCrossSection = Convert.ToDecimal(row["ClassCrossSection"]);
                        shipClass.ClassThermal = Convert.ToDecimal(row["ClassThermal"]);
                        shipClass.Cost = Convert.ToDecimal(row["Cost"]);
                        shipClass.CrewQuartersHS = Convert.ToDecimal(row["CrewQuartersHS"]);
                        shipClass.FuelEfficiency = Convert.ToDecimal(row["FuelEfficiency"]);
                        shipClass.ParasiteCapacity = Convert.ToDecimal(row["ParasiteCapacity"]);
                        shipClass.PlannedDeployment = Convert.ToDecimal(row["PlannedDeployment"]);
                        shipClass.ProtectionValue = Convert.ToDecimal(row["ProtectionValue"]);
                        shipClass.SensorReduction = Convert.ToDecimal(row["SensorReduction"]);
                        shipClass.Size = Convert.ToDecimal(row["Size"]);
                        shipClass.GeoSurvey = Convert.ToDecimal(row["GeoSurvey"]);
                        shipClass.CrewDesignEfficiency = Convert.ToDecimal(row["CrewDesignEfficiency"]);
                        shipClass.MilitaryEngines = Convert.ToBoolean(row["MilitaryEngines"]);
                        shipClass.CommercialHangar = Convert.ToBoolean(row["CommercialHangar"]);
                        shipClass.FighterClass = Convert.ToBoolean(row["FighterClass"]);
                        shipClass.Commercial = Convert.ToBoolean(row["Commercial"]);
                        shipClass.Locked = Convert.ToBoolean(row["Locked"]);
                        shipClass.PreTNT = Convert.ToBoolean(row["PreTNT"]);
                        shipClass.RecreationalModule = Convert.ToBoolean(row["RecreationalModule"]);
                        shipClass.MoraleCheckRequired = Convert.ToBoolean(row["MoraleCheckRequired"]);
                        shipClass.ArkShip = Convert.ToBoolean(row["ArkShip"]);
                        shipClass.FlagBridge = Convert.ToBoolean(row["FlagBridge"]);
                        shipClass.ClassName = row["ClassName"].ToString();
                        shipClass.Notes = row["Notes"].ToString();
                        shipClass.PrefixName = row["PrefixName"].ToString();
                        shipClass.SuffixName = row["SuffixName"].ToString();
                        shipClass.ClassMaterials = new AllMineralsValue(this);
                        ShipClasses.Add(shipClass.ShipClassID, shipClass);
                    }
                }
            }

            foreach (GameRace race in GameRaces.Values)
            {
                if (race.SelectedClassIcon > 0 && ShipClasses.TryGetValue(race.SelectedClassIcon, out var @class))
                    race.SelectedClass = @class;
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

    public void LoadClassMaterials()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_ClassMaterials where GameID = {GameID.ToString()}")
                         .Rows)
            {
                int int32_1 = Convert.ToInt32(row["ClassID"]);
                if (ShipClasses.ContainsKey(int32_1))
                {
                    int materialId = Convert.ToInt32(row["MaterialID"]);
                    Decimal amount = Convert.ToDecimal(row["Amount"]);
                    ShipClasses[int32_1].ClassMaterials.AddSpecific((AuroraElement)materialId, amount);
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

    

    public void LoadSystemBodyNames()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_SystemBodyName WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                RaceSystemBodyName gclass218 = new RaceSystemBodyName();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32, out var race))
                {
                    gclass218.SystemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                    if (SystemBodyRecordDic.ContainsKey(gclass218.SystemBodyID))
                    {
                        gclass218.Race = race;
                        gclass218.Name = row["Name"].ToString();
                        SystemBodyRecordDic[gclass218.SystemBodyID].dictionary_1.Add(int32, gclass218);
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

    public void LoadSurvivors()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Survivors WHERE GameID = {GameID.ToString()}").Rows)
            {
                Survivors survivors = new Survivors();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    survivors.Race = race;
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (SpeciesDictionary.TryGetValue(int32_2, out var value))
                    {
                        survivors.Species = value;
                        int int32_3 = Convert.ToInt32(row["ShipID"]);
                        if (Ships.TryGetValue(int32_3, out var ship))
                        {
                            survivors.Ship = ship;
                            survivors.Crew = Convert.ToInt32(row["Crew"]);
                            survivors.Ship.SurvivorsList.Add(survivors);
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

    public void LoadSystemBodySurveys()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select distinct * FROM FCT_SystemBodySurveys WHERE GameID = {GameID.ToString()}").Rows)
            {
                RacialSystemBodySurvey raceSurvey = new RacialSystemBodySurvey();
                int int32_1 = Convert.ToInt32(row["SystemBodyID"]);
                if (SystemBodyRecordDic.TryGetValue(int32_1, out var value))
                {
                    raceSurvey.SystemBody = value;
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.TryGetValue(int32_2, out var race))
                    {
                        raceSurvey.Race = race;
                        raceSurvey.UnknownEnumFlag = Unknown_SystemBodyDataUpdateLevel.BasicUpdate;
                        SystemBodySurveys.Add(raceSurvey);
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

    public void LoadMissileGeoSurveys()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MissileGeoSurvey WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                MissileGeoSurvey mGeosurvey = new MissileGeoSurvey();
                mGeosurvey.SystemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                if (SystemBodyRecordDic.ContainsKey(mGeosurvey.SystemBodyID))
                {
                    mGeosurvey.RaceID = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.ContainsKey(mGeosurvey.RaceID))
                    {
                        mGeosurvey.SurveyPoints = Convert.ToDecimal(row["SurveyPoints"]);
                        MissileGeoSurveys.Add(mGeosurvey);
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

    public void LoadRaceSurveyLocation()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_RaceSurveyLocation where GameID = {GameID.ToString()}")
                         .Rows)
            {
                int locNumber = Convert.ToInt32(row["LocationNumber"]);
                int systemID = Convert.ToInt32(row["SystemID"]);
                int raceId = Convert.ToInt32(row["RaceID"]);
                if (StarSystemDictionary.ContainsKey(systemID) && StarSystemDictionary[systemID]
                        .SurveyLocationDictionary.ContainsKey(locNumber))
                    StarSystemDictionary[systemID].SurveyLocationDictionary[locNumber].RaceIDs.Add(raceId);
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

    public void LoadAncientConstructs()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AncientConstruct WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                AncientConstruct ancientConstruct = new AncientConstruct(this);
                AuroraResearchField researchField = (AuroraResearchField)Convert.ToInt32(row["ResearchField"]);
                if (ResearchFieldDictionary.TryGetValue(researchField, out var value))
                {
                    ancientConstruct.ResearchField = value;
                    int int32_2 = Convert.ToInt32(row["SystemBodyID"]);
                    if (SystemBodyRecordDic.TryGetValue(int32_2, out var value1))
                    {
                        ancientConstruct.SystemBody = value1;
                        ancientConstruct.AncientConstructID = Convert.ToInt32(row["AncientConstructID"]);
                        ancientConstruct.AncientConstructTypeID = Convert.ToInt32(row["AncientConstructTypeID"]);
                        ancientConstruct.ResearchBonus = Convert.ToDecimal(row["ResearchBonus"]);
                        ancientConstruct.Active = Convert.ToBoolean(row["Active"]);
                        ancientConstruct.SystemBody.AncientConstruct = ancientConstruct;
                        AncientConstructsOnSystemBodies.Add(ancientConstruct.SystemBody.SystemBodyID, ancientConstruct);
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
                         .ExecuteQuery($"select * FROM FCT_RuinRace WHERE GameID = {GameID.ToString()}").Rows)
            {
                RuinRaceData gclass171 = new RuinRaceData(this);
                gclass171.RuinRaceID = Convert.ToInt32(row["RuinRaceID"]);
                gclass171.Level = Convert.ToInt32(row["Level"]);
                gclass171.Title = row["Title"].ToString();
                gclass171.Name = row["Name"].ToString();
                gclass171.RacePic = row["RacePic"].ToString();
                gclass171.FlagPic = row["FlagPic"].ToString();
                RuinRaceDictionary.Add(gclass171.RuinRaceID, gclass171);
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
                         .ExecuteQuery($"select * FROM FCT_Ship WHERE GameID = {GameID.ToString()}").Rows)
            {
                ShipData gclass40_1 = new ShipData(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass40_1.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (SpeciesDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass40_1.gclass194_0 = value;
                        int int32_3 = Convert.ToInt32(row["ShipClassID"]);
                        if (ShipClasses.TryGetValue(int32_3, out var @class))
                        {
                            gclass40_1.gclass22_0 = @class;
                            int int32_4 = Convert.ToInt32(row["FleetID"]);
                            if (FleetDictionary.TryGetValue(int32_4, out var value1))
                            {
                                gclass40_1.gclass85_0 = value1;
                                gclass40_1.gclass85_0.list_3.Add(gclass40_1);
                                int int32_5 = Convert.ToInt32(row["SubFleetID"]);
                                if (SubFleetDictionary.TryGetValue(int32_5, out var value2))
                                    gclass40_1.gclass84_0 = value2;
                                int int32_6 = Convert.ToInt32(row["ShippingLineID"]);
                                if (ShippingLineDictionary.TryGetValue(int32_6, out var value3))
                                    gclass40_1.gclass187_0 = value3;
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
                                gclass40_1.TransportedMineral = new AllMineralsValue(this);
                                if (gclass40_1.gclass21_0.NPR)
                                    gclass40_1.gclass5_0 = new GClass5(this, gclass40_1);
                                Ships.Add(gclass40_1.int_8, gclass40_1);
                            }
                        }
                    }
                }
            }

            foreach (ShipData gclass40 in Ships.Values)
            {
                if (Ships.TryGetValue(gclass40.int_27, out var ship))
                    gclass40.gclass40_0 = ship;
                if (Ships.TryGetValue(gclass40.int_26, out var ship1))
                    gclass40.gclass40_1 = ship1;
                if (Ships.TryGetValue(gclass40.int_28, out var ship2))
                    gclass40.gclass40_2 = ship2;
                if (Ships.TryGetValue(gclass40.int_30, out var ship3))
                    gclass40.gclass40_3 = ship3;
            }

            foreach (NavalAdminCommand gclass83 in NavalAdminCommands.Values)
            {
                if (gclass83.int_4 != 0 && Ships.TryGetValue(gclass83.int_4, out var ship))
                    gclass83.gclass40_0 = ship;
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

    public void LoadContacts()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_Contacts WHERE GameID = {GameID.ToString()}").Rows)
            {
                Contact gclass65 = new Contact(this);
                int int32_1 = Convert.ToInt32(row["SystemID"]);
                if (StarSystemDictionary.TryGetValue(int32_1, out var value))
                {
                    gclass65.System = value;
                    int int32_2 = Convert.ToInt32(row["ContactRaceID"]);
                    if (GameRaces.TryGetValue(int32_2, out var race))
                    {
                        gclass65.ContactRace = race;
                        int int32_3 = Convert.ToInt32(row["DetectRaceID"]);
                        if (GameRaces.TryGetValue(int32_3, out var gameRace))
                        {
                            gclass65.DetectRace = gameRace;
                            gclass65.UniqueID = Convert.ToInt32(row["UniqueID"]);
                            gclass65.ContactID = Convert.ToInt32(row["ContactID"]);
                            gclass65.ContactNumber = Convert.ToInt32(row["ContactNumber"]);
                            gclass65.Resolution = Convert.ToInt32(row["Resolution"]);
                            gclass65.ContinualContactTime = Convert.ToInt32(row["ContinualContactTime"]);
                            gclass65.Speed = Convert.ToInt32(row["Speed"]);
                            gclass65.ContactMethod = (ContactDetectMethod)Convert.ToInt32(row["ContactMethod"]);
                            gclass65.ContactType = (AuroraContactType)Convert.ToInt32(row["ContactType"]);
                            switch (gclass65.ContactType)
                            {
                                case AuroraContactType.Ship:
                                    if (Ships.TryGetValue(gclass65.ContactID, out var ship))
                                    {
                                        gclass65.TargetShip = ship;
                                        break;
                                    }

                                    break;
                                case AuroraContactType.Salvo:
                                    if (MissileSalvoes.TryGetValue(gclass65.ContactID, out var salvo))
                                    {
                                        gclass65.TargetSalvo = salvo;
                                        break;
                                    }

                                    break;
                                case AuroraContactType.Population:
                                case AuroraContactType.GroundUnit:
                                case AuroraContactType.STOGroundUnit:
                                case AuroraContactType.Shipyard:
                                    if (Populations.TryGetValue(gclass65.ContactID, out var population))
                                    {
                                        gclass65.TargetPopulation = population;
                                        break;
                                    }

                                    break;
                            }

                            gclass65.ContactStrength = Convert.ToDecimal(row["ContactStrength"]);
                            gclass65.CreationTime = Convert.ToDecimal(row["CreationTime"]);
                            gclass65.Reestablished = Convert.ToDecimal(row["Reestablished"]);
                            gclass65.LastUpdate = Convert.ToDecimal(row["LastUpdate"]);
                            gclass65.Xcor = Convert.ToDouble(row["Xcor"]);
                            gclass65.Ycor = Convert.ToDouble(row["Ycor"]);
                            gclass65.LastXcor = Convert.ToDouble(row["LastXcor"]);
                            gclass65.LastYcor = Convert.ToDouble(row["LastYcor"]);
                            gclass65.IncrementStartX = Convert.ToDouble(row["IncrementStartX"]);
                            gclass65.IncrementStartY = Convert.ToDouble(row["IncrementStartY"]);
                            gclass65.Msg = Convert.ToBoolean(row["Msg"]);
                            gclass65.ContactName = row["ContactName"].ToString();
                            Contacts.Add(gclass65.UniqueID, gclass65);
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

    private void LoadWreckTechs()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_WreckTech WHERE GameID = {GameID.ToString()}").Rows)
            {
                WreckTech wreckTech = new WreckTech();
                int id = Convert.ToInt32(row["WreckID"]);
                if (Wrecks.ContainsKey(id))
                {
                    int techId = Convert.ToInt32(row["TechID"]);
                    if (TechDataDictionary.TryGetValue(techId, out var value))
                    {
                        wreckTech.TechData = value;
                        wreckTech.Percentage = Convert.ToDecimal(row["Percentage"]);
                        Wrecks[id].ContainingTechs.Add(wreckTech);
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

    private void LoadDamageControlQueue()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_DamageControlQueue WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                DamageControlQueue dcqueue = new DamageControlQueue();
                int shipId = Convert.ToInt32(row["ShipID"]);
                if (Ships.TryGetValue(shipId, out var ship))
                {
                    dcqueue.Ship = ship;
                    int int32_2 = Convert.ToInt32(row["ComponentID"]);
                    if (ComponentDataDictionary.TryGetValue(int32_2, out var value))
                    {
                        dcqueue.Component = value;
                        dcqueue.RepairOrder = Convert.ToInt32(row["RepairOrder"]);
                        dcqueue.Ship.DamageControlQueue.Add(dcqueue);
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
                         .ExecuteQuery($"select * FROM FCT_WreckComponents where GameID = {GameID.ToString()}")
                         .Rows)
            {
                WreckComponents wreckComp = new WreckComponents();
                int int32_1 = Convert.ToInt32(row["WreckID"]);
                if (Wrecks.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["ComponentID"]);
                    if (ComponentDataDictionary.TryGetValue(int32_2, out var value))
                    {
                        wreckComp.Component = value;
                        wreckComp.Amount = Convert.ToInt32(row["Amount"]);
                        Wrecks[int32_1].ContainingComponents.Add(wreckComp);
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

    public void LoadWrecks()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Wrecks WHERE GameID = {GameID.ToString()}").Rows)
            {
                Wreck wreck = new Wreck(this);
                int int32_1 = Convert.ToInt32(row["SystemID"]);
                if (StarSystemDictionary.TryGetValue(int32_1, out var value))
                {
                    wreck.System = value;
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.TryGetValue(int32_2, out var race))
                    {
                        wreck.Race = race;
                        int int32_3 = Convert.ToInt32(row["ClassID"]);
                        if (ShipClasses.TryGetValue(int32_3, out var @class))
                        {
                            wreck.ShipClass = @class;
                            int int32_4 = Convert.ToInt32(row["OrbitBodyID"]);
                            if (SystemBodyRecordDic.TryGetValue(int32_4, out var value1))
                                wreck.OrbitingBody = value1;
                            wreck.WreckID = Convert.ToInt32(row["WreckID"]);
                            wreck.ShipID = Convert.ToInt32(row["ShipID"]);
                            wreck.Size = Convert.ToDecimal(row["Size"]);
                            wreck.EffectiveSize = Convert.ToInt32(row["EffectiveSize"]);
                            wreck.StarSwarmHatching = Convert.ToInt32(row["StarSwarmHatching"]);
                            wreck.QueenStatus = Convert.ToInt32(row["QueenStatus"]);
                            wreck.Xcor = Convert.ToDouble(row["Xcor"]);
                            wreck.Ycor = Convert.ToDouble(row["Ycor"]);
                            wreck.ContainingMineral = new AllMineralsValue(this);
                            wreck.ContainingMineral.Duranium = Convert.ToDecimal(row["Duranium"]);
                            wreck.ContainingMineral.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                            wreck.ContainingMineral.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                            wreck.ContainingMineral.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                            wreck.ContainingMineral.Boronide = Convert.ToDecimal(row["Boronide"]);
                            wreck.ContainingMineral.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                            wreck.ContainingMineral.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                            wreck.ContainingMineral.Sorium = Convert.ToDecimal(row["Sorium"]);
                            wreck.ContainingMineral.Uridium = Convert.ToDecimal(row["Uridium"]);
                            wreck.ContainingMineral.Corundium = Convert.ToDecimal(row["Corundium"]);
                            wreck.ContainingMineral.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                            Wrecks.Add(wreck.WreckID, wreck);
                        }
                    }
                }
            }

            LoadWreckTechs();
            method_252();
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

    public void LoadIndustrialProjects()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_IndustrialProjects WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                IndustrialProjects indProject = new IndustrialProjects(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    indProject.Race = race;
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                    {
                        indProject.Population = population;
                        int int32_3 = Convert.ToInt32(row["SpeciesID"]);
                        if (SpeciesDictionary.TryGetValue(int32_3, out var value))
                        {
                            indProject.Species = value;
                            WealthUsage wealthUsage = (WealthUsage)Convert.ToInt32(row["WealthUse"]);
                            if (WealthUsageDictionary.TryGetValue(wealthUsage, out var value1))
                            {
                                indProject.WealthUsage = value1;
                                int int32_5 = Convert.ToInt32(row["RefitClassID"]);
                                if (ShipClasses.TryGetValue(int32_5, out var @class))
                                    indProject.RefitClass = @class;
                                indProject.ProjectID = Convert.ToInt32(row["ProjectID"]);
                                indProject.FuelRequired = Convert.ToInt32(row["FuelRequired"]);
                                indProject.Queue = Convert.ToInt32(row["Queue"]);
                                indProject.ProductionType =
                                    (AuroraProductionType)Convert.ToInt32(row["ProductionType"]);
                                indProject.Percentage = Convert.ToDecimal(row["Percentage"]);
                                indProject.Amount = Convert.ToDecimal(row["Amount"]);
                                indProject.PartialCompletion = Convert.ToDecimal(row["PartialCompletion"]);
                                indProject.ProdPerUnit = Convert.ToDecimal(row["ProdPerUnit"]);
                                indProject.Pause = Convert.ToBoolean(row["Pause"]);
                                indProject.Description = row["Description"].ToString();
                                switch (indProject.ProductionType)
                                {
                                    case AuroraProductionType.Construction:
                                        AuroraInstallationType int32_6 =
                                            (AuroraInstallationType)Convert.ToInt32(row["ProductionID"]);
                                        if (InstallationTypes.TryGetValue(int32_6, out var type))
                                            indProject.InstallationType = type;
                                        indProject.ProductionCategory = AuroraProductionCategory.Construction;
                                        break;
                                    case AuroraProductionType.Ordnance:
                                        int int32_7 = Convert.ToInt32(row["ProductionID"]);
                                        if (RaceMissileDictionary.TryGetValue(int32_7, out var value2))
                                            indProject.RaceMissile = value2;
                                        indProject.ProductionCategory = AuroraProductionCategory.Ordnance;
                                        break;
                                    case AuroraProductionType.Fighter:
                                        int int32_8 = Convert.ToInt32(row["ProductionID"]);
                                        if (ShipClasses.TryGetValue(int32_8, out var shipClass))
                                            indProject.ShipClass = shipClass;
                                        indProject.ProductionCategory = AuroraProductionCategory.Fighter;
                                        break;
                                    case AuroraProductionType.Components:
                                        int int32_9 = Convert.ToInt32(row["ProductionID"]);
                                        if (ComponentDataDictionary.TryGetValue(int32_9, out var value3))
                                            indProject.Component = value3;
                                        indProject.ProductionCategory = AuroraProductionCategory.Construction;
                                        break;
                                    case AuroraProductionType.SpaceStation:
                                        int int32_10 = Convert.ToInt32(row["ProductionID"]);
                                        if (ShipClasses.TryGetValue(int32_10, out var class1))
                                            indProject.ShipClass = class1;
                                        indProject.ProductionCategory = AuroraProductionCategory.Construction;
                                        break;
                                }

                                indProject.MineralCost = new AllMineralsValue(this);
                                indProject.MineralCost.Duranium = Convert.ToDecimal(row["Duranium"]);
                                indProject.MineralCost.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                                indProject.MineralCost.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                                indProject.MineralCost.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                                indProject.MineralCost.Boronide = Convert.ToDecimal(row["Boronide"]);
                                indProject.MineralCost.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                                indProject.MineralCost.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                                indProject.MineralCost.Sorium = Convert.ToDecimal(row["Sorium"]);
                                indProject.MineralCost.Uridium = Convert.ToDecimal(row["Uridium"]);
                                indProject.MineralCost.Corundium = Convert.ToDecimal(row["Corundium"]);
                                indProject.MineralCost.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                                if (indProject.Population != null)
                                    indProject.Population.IndustrialProjects.Add(indProject.ProjectID, indProject);
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

    public void LoadMissileSalvo()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MissileSalvo where GameID = {GameID.ToString()}").Rows)
            {
                MissileSalvo gclass132 = new MissileSalvo(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass132.Race = race;
                    int int32_2 = Convert.ToInt32(row["MissileID"]);
                    if (RaceMissileDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass132.RaceMissile = value;
                        int int32_3 = Convert.ToInt32(row["SystemID"]);
                        if (StarSystemDictionary.TryGetValue(int32_3, out var value1))
                        {
                            gclass132.System = value1;
                            int int32_4 = Convert.ToInt32(row["ShipID"]);
                            if (Ships.TryGetValue(int32_4, out var ship))
                                gclass132.Ship = ship;
                            int int32_5 = Convert.ToInt32(row["OrbitBodyID"]);
                            if (SystemBodyRecordDic.TryGetValue(int32_5, out var value2))
                                gclass132.gclass1_0 = value2;
                            int int32_6 = Convert.ToInt32(row["FireControlID"]);
                            if (ComponentDataDictionary.TryGetValue(int32_6, out var value3))
                                gclass132.gclass230_0 = value3;
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
                            MissileSalvoes.Add(gclass132.int_1, gclass132);
                            if (gclass132.int_0 > 0)
                            {
                                gclass132.auroraContactType_0 = (AuroraContactType)Convert.ToInt32(row["TargetType"]);
                                switch (gclass132.auroraContactType_0)
                                {
                                    case AuroraContactType.Ship:
                                        if (Ships.TryGetValue(gclass132.int_0, out var ship1))
                                        {
                                            gclass132.gclass40_1 = ship1;
                                            continue;
                                        }

                                        continue;
                                    case AuroraContactType.Salvo:
                                        if (MissileSalvoes.TryGetValue(gclass132.int_0, out var salvo))
                                        {
                                            gclass132.gclass132_0 = salvo;
                                            continue;
                                        }

                                        continue;
                                    case AuroraContactType.Population:
                                    case AuroraContactType.GroundUnit:
                                    case AuroraContactType.STOGroundUnit:
                                    case AuroraContactType.Shipyard:
                                        if (Populations.TryGetValue(gclass132.int_0, out var population))
                                        {
                                            gclass132.gclass146_0 = population;
                                            continue;
                                        }

                                        continue;
                                    case AuroraContactType.WayPoint:
                                        if (Waypoints.TryGetValue(gclass132.int_0, out var waypoint))
                                        {
                                            gclass132.gclass214_0 = waypoint;
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

    public void LoadLaunchedMissiles()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_Missile where GameID = {GameID.ToString()}").Rows)
            {
                int salvoID = Convert.ToInt32(row["SalvoID"]);
                if (MissileSalvoes.ContainsKey(salvoID))
                {
                    int mslNum = Convert.ToInt32(row["MissileNumber"]);
                    int RemainingDecoy = Convert.ToInt32(row["RemainingDecoys"]);
                    MissileSalvoes[salvoID].RemainingDecoys.Add(mslNum, RemainingDecoy);
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

    public void LoadRaceMissiles()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_MissileType where GameID = {GameID.ToString()}").Rows)
            {
                RaceMissile rdMissileDesign = new RaceMissile(this);
                int engineID = Convert.ToInt32(row["EngineID"]);
                if (ComponentDataDictionary.TryGetValue(engineID, out var value))
                    rdMissileDesign.EngineComponent = value;
                rdMissileDesign.Name = row["Name"].ToString();
                rdMissileDesign.MissileID = Convert.ToInt32(row["MissileID"]);
                if (TechDataDictionary.TryGetValue(rdMissileDesign.MissileID, out var value1))
                {
                    rdMissileDesign.TechSystem = value1;
                    rdMissileDesign.MissileSeriesID = Convert.ToInt32(row["MissileSeriesID"]);
                    rdMissileDesign.NumEngines = Convert.ToInt32(row["NumEngines"]);
                    rdMissileDesign.MissilesRequired = Convert.ToInt32(row["MissilesRequired"]);
                    rdMissileDesign.MissilesAvailable = Convert.ToInt32(row["MissilesAvailable"]);
                    rdMissileDesign.FuelRequired = Convert.ToInt32(row["FuelRequired"]);
                    rdMissileDesign.SensorResolution = Convert.ToInt32(row["SensorResolution"]);
                    rdMissileDesign.SensorRange = Convert.ToInt32(row["SensorRange"]);
                    rdMissileDesign.TotalFlightTime = Convert.ToDecimal(row["TotalFlightTime"]);
                    rdMissileDesign.ECCM = Convert.ToInt32(row["ECCM"]);
                    rdMissileDesign.SecondStageID = Convert.ToInt32(row["SecondStageID"]);
                    rdMissileDesign.NumSS = Convert.ToInt32(row["NumSS"]);
                    rdMissileDesign.SeparationRange = Convert.ToInt32(row["SeparationRange"]);
                    rdMissileDesign.ATG = Convert.ToDecimal(row["ATG"]);
                    rdMissileDesign.Retargeting = Convert.ToInt32(row["Retargeting"]);
                    rdMissileDesign.LaserWarheadRangeModifier = Convert.ToInt32(row["LaserWarheadRangeModifier"]);
                    rdMissileDesign.NumDecoys = Convert.ToInt32(row["NumDecoys"]);
                    rdMissileDesign.MissileECM = Convert.ToInt32(row["MissileECM"]);
                    rdMissileDesign.MultipleWarheads = Convert.ToInt32(row["MultipleWarheads"]);
                    rdMissileDesign.ShipDecoy = Convert.ToInt32(row["ShipDecoy"]);
                    rdMissileDesign.LaserWarhead = Convert.ToDecimal(row["LaserWarhead"]);
                    rdMissileDesign.MinDetonationRange = Convert.ToDecimal(row["MinDetonationRange"]);
                    rdMissileDesign.MaxDetonationRange = Convert.ToDecimal(row["MaxDetonationRange"]);
                    rdMissileDesign.WarheadStrength = Convert.ToDecimal(row["WarheadStrength"]);
                    rdMissileDesign.RadDamage = Convert.ToDecimal(row["RadDamage"]);
                    rdMissileDesign.Endurance = Convert.ToDecimal(row["Endurance"]);
                    rdMissileDesign.Cost = Convert.ToDecimal(row["Cost"]);
                    rdMissileDesign.Size = Convert.ToDecimal(row["Size"]);
                    rdMissileDesign.Speed = Convert.ToDecimal(row["Speed"]);
                    rdMissileDesign.MaxRange = Convert.ToDouble(row["MaxRange"]);
                    rdMissileDesign.CombinatedMaxRange = rdMissileDesign.MaxRange;
                    rdMissileDesign.SensorStrength = Convert.ToDouble(row["SensorStrength"]);
                    rdMissileDesign.ThermalStrength = Convert.ToDouble(row["ThermalStrength"]);
                    rdMissileDesign.EMStrength = Convert.ToDouble(row["EMStrength"]);
                    rdMissileDesign.EMSensitivity = Convert.ToDouble(row["EMSensitivity"]);
                    rdMissileDesign.GeoStrength = Convert.ToDecimal(row["GeoStrength"]);
                    rdMissileDesign.MSPReactor = Convert.ToDecimal(row["MSPReactor"]);
                    rdMissileDesign.MSPWarhead = Convert.ToDecimal(row["MSPWarhead"]);
                    rdMissileDesign.MSPEngine = Convert.ToDecimal(row["MSPEngine"]);
                    rdMissileDesign.MSPFuel = Convert.ToDecimal(row["MSPFuel"]);
                    rdMissileDesign.MSPActive = Convert.ToDecimal(row["MSPActive"]);
                    rdMissileDesign.MSPThermal = Convert.ToDecimal(row["MSPThermal"]);
                    rdMissileDesign.MSPEM = Convert.ToDecimal(row["MSPEM"]);
                    rdMissileDesign.MSPGeo = Convert.ToDecimal(row["MSPGeo"]);
                    rdMissileDesign.GroundAP = Convert.ToDecimal(row["GroundAP"]);
                    rdMissileDesign.GroundDamage = Convert.ToDecimal(row["GroundDamage"]);
                    rdMissileDesign.GroundBaseDamage = Convert.ToDecimal(row["GroundBaseDamage"]);
                    rdMissileDesign.GroundShots = Convert.ToDecimal(row["GroundShots"]);
                    rdMissileDesign.PowerMod = Convert.ToDecimal(row["PowerMod"]);
                    rdMissileDesign.MSPDecoys = Convert.ToDecimal(row["MSPDecoys"]);
                    rdMissileDesign.MSPMultipleWarheads = Convert.ToInt32(row["MSPMultipleWarheads"]);
                    rdMissileDesign.ProductionMineralCost = new AllMineralsValue(this);
                    rdMissileDesign.ProductionMineralCost.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                    rdMissileDesign.ProductionMineralCost.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                    rdMissileDesign.ProductionMineralCost.Boronide = Convert.ToDecimal(row["Boronide"]);
                    rdMissileDesign.ProductionMineralCost.Uridium = Convert.ToDecimal(row["Uridium"]);
                    rdMissileDesign.ProductionMineralCost.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                    rdMissileDesign.PrecursorMissile = Convert.ToBoolean(row["PrecursorMissile"]);
                    rdMissileDesign.PreTNT = Convert.ToBoolean(row["PreTNT"]);
                    RaceMissileDictionary.Add(rdMissileDesign.MissileID, rdMissileDesign);
                }
                else
                {
                    int num = (int)MessageBox.Show(
                        $"Tech system does not exist for {rdMissileDesign.Name} so it cannot be loaded");
                }
            }

            foreach (RaceMissile gclass129 in RaceMissileDictionary.Values)
            {
                if (gclass129.SecondStageID > 0 && RaceMissileDictionary.TryGetValue(gclass129.SecondStageID, out var value))
                {
                    gclass129.SecondStageMissile = value;
                    gclass129.CombinatedMaxRange = gclass129.MaxRange + gclass129.SecondStageMissile.CombinatedMaxRange;
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

    public void LoadAtmosphericGases()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AtmosphericGas where GameID = {GameID.ToString()}")
                         .Rows)
            {
                SystemBodyAtmosphericGas gasState = new SystemBodyAtmosphericGas();
                GasType int32 = (GasType)Convert.ToInt32(row["AtmosGasID"]);
                if (AtmosphericGasDictionary.TryGetValue(int32, out var value))
                {
                    gasState.Gas = value;
                    gasState.SystemBodyID = Convert.ToInt32(row["SystemBodyID"]);
                    gasState.AtmoGasAmount = Convert.ToDouble(row["AtmosGasAmount"]);
                    gasState.GasAtm = Convert.ToDouble(row["GasAtm"]);
                    gasState.FrozenOut = Convert.ToBoolean(row["FrozenOut"]);
                    if (SystemBodyRecordDic.Keys.Contains(gasState.SystemBodyID))
                        SystemBodyRecordDic[gasState.SystemBodyID].AtmosphericGasList.Add(gasState);
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

    public void LoadPopulationWeapon()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_PopulationWeapon WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                PopOrdnanceStock ordnanceStock = new PopOrdnanceStock();
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (RaceMissileDictionary.TryGetValue(int32_1, out var value))
                {
                    ordnanceStock.RaceMissile = value;
                    ordnanceStock.Amount = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.ContainsKey(int32_2))
                        Populations[int32_2].OrdnanceStocks.Add(ordnanceStock);
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
                         .ExecuteQuery($"select * FROM FCT_ShipWeapon WHERE GameID = {GameID.ToString()}").Rows)
            {
                PopOrdnanceStock gclass130 = new PopOrdnanceStock();
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (RaceMissileDictionary.TryGetValue(int32_1, out var value))
                {
                    gclass130.RaceMissile = value;
                    gclass130.Amount = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["ShipID"]);
                    if (Ships.Keys.Contains(int32_2))
                        Ships[int32_2].list_10.Add(gclass130);
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
                         .ExecuteQuery($"select * FROM FCT_ClassOrdnanceTemplate where GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (RaceMissileDictionary.TryGetValue(int32_1, out var value))
                {
                    PopOrdnanceStock gclass130 = new PopOrdnanceStock();
                    gclass130.RaceMissile = value;
                    gclass130.Amount = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["ShipClassID"]);
                    if (ShipClasses.Keys.Contains(int32_2))
                        ShipClasses[int32_2].list_0.Add(gclass130);
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
                             $"SELECT * FROM FCT_ShipOrdnanceTemplate where GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["MissileID"]);
                if (RaceMissileDictionary.TryGetValue(int32_1, out var value))
                {
                    PopOrdnanceStock gclass130 = new PopOrdnanceStock();
                    gclass130.RaceMissile = value;
                    gclass130.Amount = Convert.ToInt32(row["Amount"]);
                    int int32_2 = Convert.ToInt32(row["ShipID"]);
                    if (Ships.Keys.Contains(int32_2))
                        Ships[int32_2].list_9.Add(gclass130);
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
                         .ExecuteQuery($"select * FROM FCT_ClassComponent where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass228 gclass228 = new GClass228();
                gclass228.int_1 = Convert.ToInt32(row["ClassID"]);
                if (ShipClasses.ContainsKey(gclass228.int_1))
                {
                    gclass228.int_0 = Convert.ToInt32(row["ComponentID"]);
                    if (ComponentDataDictionary.TryGetValue(gclass228.int_0, out var value))
                    {
                        gclass228.decimal_0 = Convert.ToDecimal(row["NumComponent"]);
                        gclass228.int_2 = Convert.ToInt32(row["ChanceToHit"]);
                        gclass228.int_3 = Convert.ToInt32(row["ElectronicCTH"]);
                        gclass228.gclass230_0 = value;
                        ShipClasses[gclass228.int_1].dictionary_0.Add(gclass228.int_0, gclass228);
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
                         .ExecuteQuery($"select * FROM FCT_DamagedComponent where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass178 gclass178 = new GClass178();
                int int32_1 = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["ComponentID"]);
                    if (ComponentDataDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass178.gclass230_0 = value;
                        gclass178.int_0 = Convert.ToInt32(row["Number"]);
                        Ships[int32_1].list_12.Add(gclass178);
                    }
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery($"select * FROM FCT_ArmourDamage").Rows)
            {
                int int32_3 = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(int32_3))
                {
                    int int32_4 = Convert.ToInt32(row["ArmourColumn"]);
                    int int32_5 = Convert.ToInt32(row["Damage"]);
                    Ships[int32_3].dictionary_5.Add(int32_4, int32_5);
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
                         .ExecuteQuery($"select * FROM FCT_ClassSC where GameID = {GameID.ToString()}").Rows)
            {
                GClass74 gclass74 = new GClass74();
                int int32_1 = Convert.ToInt32(row["ShipClassID"]);
                int int32_2 = Convert.ToInt32(row["FighterClassID"]);
                if (ShipClasses.ContainsKey(int32_1) && ShipClasses.TryGetValue(int32_2, out var @class))
                {
                    gclass74.gclass22_0 = @class;
                    gclass74.int_0 = Convert.ToInt32(row["Number"]);
                    ShipClasses[int32_1].list_1.Add(gclass74);
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
                             $"SELECT * FROM FCT_ClassGroundTemplates where GameID = {GameID.ToString()}").Rows)
            {
                GClass75 gclass75 = new GClass75();
                int int32_1 = Convert.ToInt32(row["ShipClassID"]);
                int int32_2 = Convert.ToInt32(row["TemplateID"]);
                if (ShipClasses.ContainsKey(int32_1) && FormationTemplateRecordDic.TryGetValue(int32_2, out var value))
                {
                    gclass75.gclass102_0 = value;
                    gclass75.int_0 = Convert.ToInt32(row["Number"]);
                    ShipClasses[int32_1].list_2.Add(gclass75);
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
                ShipHullDictionary.Add(gclass76.ShipHullDescriptionID, gclass76);
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
                         .ExecuteQuery($"select * FROM FCT_FleetHistory where GameID = {GameID.ToString()}").Rows)
            {
                GClass177 gclass177 = new GClass177();
                int int32 = Convert.ToInt32(row["FleetID"]);
                if (FleetDictionary.TryGetValue(int32, out var gclass85))
                {
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
                         .ExecuteQuery($"select * FROM FCT_ShipHistory where GameID = {GameID.ToString()}").Rows)
            {
                GClass177 gclass177 = new GClass177();
                int int32 = Convert.ToInt32(row["ShipID"]);
                if (Ships.TryGetValue(int32, out var gclass40))
                {
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
                         .ExecuteQuery($"select * FROM FCT_CommanderHistory where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass177 gclass177 = new GClass177();
                int int32 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (dictionary_42.TryGetValue(int32, out var value))
                    gclass55 = value;
                else if (dictionary_43.TryGetValue(int32, out var value1))
                    gclass55 = value1;
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
                             $"SELECT * FROM FCT_CommanderMeasurement where GameID = {GameID.ToString()}").Rows)
            {
                GClass54 gclass54 = new GClass54();
                int int32 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (dictionary_42.TryGetValue(int32, out var value))
                    gclass55 = value;
                else if (dictionary_43.TryGetValue(int32, out var value1))
                    gclass55 = value1;
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
                         .ExecuteQuery($"select * FROM FCT_ShipMeasurement where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass54 gclass54 = new GClass54();
                int int32 = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(int32))
                {
                    gclass54.auroraMeasurementType_0 = (AuroraMeasurementType)Convert.ToInt32(row["MeasurementType"]);
                    gclass54.decimal_0 = Convert.ToDecimal(row["Amount"]);
                    gclass54.bool_0 = Convert.ToBoolean(row["StrikeGroup"]);
                    Ships[int32].list_0.Add(gclass54);
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
                         .ExecuteQuery($"select * FROM FCT_MedalConditionAssignment where GameID = {GameID.ToString()}").Rows)
            {
                GClass44 gclass44 = new GClass44();
                int int32_1 = Convert.ToInt32(row["MedalID"]);
                if (RaceMedalDictionary.TryGetValue(int32_1, out var value))
                {
                    gclass44.gclass42_0 = value;
                    int int32_2 = Convert.ToInt32(row["MedalConditionID"]);
                    if (MedalConditionDictionary.TryGetValue(int32_2, out var value1))
                    {
                        gclass44.gclass43_0 = value1;
                        list_1.Add(gclass44);
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
                         .ExecuteQuery($"select * FROM FCT_CommanderMedal where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass53 gclass53 = new GClass53();
                int int32_1 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (dictionary_42.TryGetValue(int32_1, out var value))
                    gclass55 = value;
                else if (dictionary_43.TryGetValue(int32_1, out var value1))
                    gclass55 = value1;
                else
                    continue;
                int int32_2 = Convert.ToInt32(row["MedalID"]);
                if (RaceMedalDictionary.TryGetValue(int32_2, out var value2))
                {
                    gclass53.gclass42_0 = value2;
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
                         .ExecuteQuery($"select * FROM FCT_StandingOrderTemplate where GameID = {GameID.ToString()}").Rows)
            {
                GClass135 gclass135 = new GClass135();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32))
                {
                    gclass135.int_0 = Convert.ToInt32(row["TemplateID"]);
                    gclass135.string_0 = row["TemplateName"].ToString();
                    GameRaces[int32].dictionary_9.Add(gclass135.int_0, gclass135);
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery($"select * FROM FCT_StandingOrderTemplateOrder where GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["TemplateID"]);
                    if (GameRaces[int32_1].dictionary_9.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["Priority"]);
                        int int32_4 = Convert.ToInt32(row["CreateFWP"]);
                        AuroraStandingOrder int32_5 = (AuroraStandingOrder)Convert.ToInt32(row["OrderID"]);
                        AuroraFleetCondition int32_6 = (AuroraFleetCondition)Convert.ToInt32(row["ConditionID"]);
                        if (int32_6 == AuroraFleetCondition.NoCondition)
                            GameRaces[int32_1].dictionary_9[int32_2].dictionary_0
                                .Add(int32_3, StandingOrderDictionary[int32_5]);
                        else
                            GameRaces[int32_1].dictionary_9[int32_2].dictionary_1.Add(int32_3,
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
                         .ExecuteQuery($"select * FROM FCT_Shipyard WHERE GameID = {GameID.ToString()}").Rows)
            {
                GClass193 gclass193 = new GClass193(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass193.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                        gclass193.gclass146_0 = population;
                    int int32_3 = Convert.ToInt32(row["ParentShipID"]);
                    if (Ships.TryGetValue(int32_3, out var ship))
                        gclass193.gclass40_1 = ship;
                    int int32_4 = Convert.ToInt32(row["TractorParentShipID"]);
                    if (Ships.TryGetValue(int32_4, out var ship1))
                        gclass193.gclass40_0 = ship1;
                    int int32_5 = Convert.ToInt32(row["BuildClassID"]);
                    if (ShipClasses.TryGetValue(int32_5, out var @class))
                        gclass193.gclass22_0 = @class;
                    int int32_6 = Convert.ToInt32(row["RetoolClassID"]);
                    if (ShipClasses.TryGetValue(int32_6, out var shipClass))
                        gclass193.gclass22_1 = shipClass;
                    int int32_7 = Convert.ToInt32(row["DefaultFleetID"]);
                    if (FleetDictionary.TryGetValue(int32_7, out var value))
                        gclass193.gclass85_0 = value;
                    int int32_8 = Convert.ToInt32(row["DefaultNavalAdminID"]);
                    if (NavalAdminCommands.TryGetValue(int32_8, out var command))
                        gclass193.gclass83_0 = command;
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
                    dictionary_31.Add(gclass193.int_0, gclass193);
                }
            }

            foreach (ShipData gclass40 in Ships.Values
                         .Where(gclass40_0 => gclass40_0.int_29 > 0).ToList())
            {
                if (dictionary_31.TryGetValue(gclass40.int_29, out var value))
                    gclass40.gclass193_0 = value;
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
                         .ExecuteQuery($"select * FROM FCT_ShipyardTask WHERE GameID = {GameID.ToString()}").Rows)
            {
                GClass192 gclass192 = new GClass192();
                int int32_1 = Convert.ToInt32(row["ShipyardID"]);
                if (dictionary_31.TryGetValue(int32_1, out var value))
                {
                    gclass192.gclass193_0 = value;
                    int int32_2 = Convert.ToInt32(row["RaceID"]);
                    if (GameRaces.TryGetValue(int32_2, out var race))
                    {
                        gclass192.gclass21_0 = race;
                        int int32_3 = Convert.ToInt32(row["PopulationID"]);
                        if (Populations.TryGetValue(int32_3, out var population))
                        {
                            gclass192.gclass146_0 = population;
                            int int32_4 = Convert.ToInt32(row["ShipID"]);
                            if (Ships.TryGetValue(int32_4, out var ship))
                                gclass192.gclass40_0 = ship;
                            int int32_5 = Convert.ToInt32(row["NavalAdminID"]);
                            if (NavalAdminCommands.TryGetValue(int32_5, out var command))
                                gclass192.gclass83_0 = command;
                            int int32_6 = Convert.ToInt32(row["ClassID"]);
                            if (ShipClasses.TryGetValue(int32_6, out var @class))
                                gclass192.gclass22_0 = @class;
                            int int32_7 = Convert.ToInt32(row["RefitID"]);
                            if (ShipClasses.TryGetValue(int32_7, out var shipClass))
                                gclass192.gclass22_1 = shipClass;
                            int int32_8 = Convert.ToInt32(row["FleetID"]);
                            if (FleetDictionary.TryGetValue(int32_8, out var value1))
                                gclass192.gclass85_0 = value1;
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
                            dictionary_32.Add(gclass192.int_0, gclass192);
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
                         .ExecuteQuery($"select * FROM FCT_PopComponent WHERE GameID = {GameID.ToString()}").Rows)
            {
                TransportedComponent gclass73 = new TransportedComponent();
                int int32 = Convert.ToInt32(row["PopulationID"]);
                if (Populations.ContainsKey(int32))
                {
                    gclass73.int_0 = Convert.ToInt32(row["ComponentID"]);
                    if (ComponentDataDictionary.TryGetValue(gclass73.int_0, out var value))
                    {
                        gclass73.Component = value;
                        gclass73.Amount = Convert.ToDecimal(row["Amount"]);
                        Populations[int32].list_2.Add(gclass73);
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
                         .ExecuteQuery($"select * FROM FCT_PopMDChanges where GameID = {GameID.ToString()}").Rows)
            {
                int int32 = Convert.ToInt32(row["PopulationID"]);
                if (Populations.ContainsKey(int32))
                {
                    Populations[int32].gclass123_3.Duranium = Convert.ToDecimal(row["Duranium"]);
                    Populations[int32].gclass123_3.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                    Populations[int32].gclass123_3.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                    Populations[int32].gclass123_3.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                    Populations[int32].gclass123_3.Boronide = Convert.ToDecimal(row["Boronide"]);
                    Populations[int32].gclass123_3.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                    Populations[int32].gclass123_3.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                    Populations[int32].gclass123_3.Sorium = Convert.ToDecimal(row["Sorium"]);
                    Populations[int32].gclass123_3.Uridium = Convert.ToDecimal(row["Uridium"]);
                    Populations[int32].gclass123_3.Corundium = Convert.ToDecimal(row["Corundium"]);
                    Populations[int32].gclass123_3.Gallicite = Convert.ToDecimal(row["Gallicite"]);
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
                         .ExecuteQuery($"select * FROM FCT_Species WHERE GameID = {GameID.ToString()}").Rows)
            {
                Species gclass194 = new Species(this);
                int int32_1 = Convert.ToInt32(row["HomeworldID"]);
                gclass194.gclass1_0 = !SystemBodyRecordDic.TryGetValue(int32_1, out var value)
                    ? null
                    : value;
                GasType int32_2 = (GasType)Convert.ToInt32(row["BreatheID"]);
                if (AtmosphericGasDictionary.TryGetValue(int32_2, out var value1))
                {
                    gclass194.gclass223_0 = value1;
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
                    gclass194.RaceImageFileName = row["RacePic"].ToString();
                    gclass194.double_7 = gclass194.double_5 - gclass194.double_6;
                    gclass194.double_8 = gclass194.double_5 + gclass194.double_6;
                    gclass194.double_9 = gclass194.double_0 - gclass194.double_1;
                    gclass194.double_10 = gclass194.double_0 + gclass194.double_1;
                    gclass194.double_12 = gclass194.double_3 - gclass194.double_4;
                    gclass194.double_11 = gclass194.double_3 + gclass194.double_4;
                    gclass194.dictionary_0 = new Dictionary<int, GClass195>();
                    SpeciesDictionary.Add(gclass194.int_0, gclass194);
                }
            }

            foreach (Species gclass194 in SpeciesDictionary.Values)
            {
                if (gclass194.int_1 > 0)
                    gclass194.gclass194_0 = !SpeciesDictionary.TryGetValue(gclass194.int_1, out var value)
                        ? null
                        : value;
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
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (SpeciesDictionary.ContainsKey(int32_2))
                    {
                        gclass195.gclass21_0 = race;
                        gclass195.genum25_0 = (GEnum25)Convert.ToInt32(row["Status"]);
                        SpeciesDictionary[int32_2].dictionary_0.Add(int32_1, gclass195);
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
                         .ExecuteQuery($"select * FROM FCT_WealthData where GameID = {GameID.ToString()}").Rows)
            {
                GClass151 gclass151 = new GClass151();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass151.gclass21_0 = race;
                    WealthUsage int32_2 = (WealthUsage)Convert.ToInt32(row["UseID"]);
                    if (WealthUsageDictionary.TryGetValue(int32_2, out var value))
                        gclass151.gclass150_0 = value;
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
                         .ExecuteQuery($"select * FROM FCT_RaceMineralData where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass153 gclass153 = new GClass153();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass153.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                        gclass153.gclass146_0 = population;
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
                         .ExecuteQuery($"select * FROM FCT_ResearchQueue where GameID = {GameID.ToString()}").Rows)
            {
                ResearchQueue gclass166 = new ResearchQueue();
                int int32_1 = Convert.ToInt32(row["PopulationID"]);
                if (Populations.TryGetValue(int32_1, out var population))
                {
                    int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                    if (TechDataDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass166.Population = population;
                        gclass166.TechSystem = value;
                        int int32_3 = Convert.ToInt32(row["CurrentProjectID"]);
                        if (gclass166.Population.dictionary_1.TryGetValue(int32_3, out var value1))
                        {
                            gclass166.CurrentProject = value1;
                            gclass166.ResearchOrder = Convert.ToInt32(row["ResearchOrder"]);
                            gclass166.Population.Race.ResearchQueues.Add(gclass166);
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
                         .ExecuteQuery($"select * FROM FCT_PausedResearch where GameID = {GameID.ToString()}")
                         .Rows)
            {
                PausedResearch gclass167 = new PausedResearch();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                    if (TechDataDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass167.gclass164_0 = value;
                        gclass167.PointsAccumulated = Convert.ToInt32(row["PointsAccumulated"]);
                        GameRaces[int32_1].PausedResearches.Add(gclass167);
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
                         .ExecuteQuery($"select * FROM FCT_SwarmResearch where GameID = {GameID.ToString()}").Rows)
            {
                SwarmResearch gclass168 = new SwarmResearch();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                    if (TechDataDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass168.Race = race;
                        gclass168.TechSystem = value;
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
                         .ExecuteQuery($"select * from FCT_KnownRuinRace where GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["RuinRaceID"]);
                int int32_2 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(int32_2))
                    GameRaces[int32_2].KnownRuinIDs.Add(int32_1);
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
                         .ExecuteQuery($"select * FROM FCT_ShippingLines WHERE GameID = {GameID.ToString()}").Rows)
            {
                ShippingLineData gclass187 = new ShippingLineData(this);
                int int32_1 = Convert.ToInt32(row["EmpireID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass187.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["CommEngineID"]);
                    if (ComponentDataDictionary.TryGetValue(int32_2, out var value))
                        gclass187.gclass230_0 = value;
                    gclass187.int_0 = Convert.ToInt32(row["ShippingLineID"]);
                    gclass187.int_1 = Convert.ToInt32(row["ShipNum"]);
                    gclass187.int_2 = Convert.ToInt32(row["CommercialEngines"]);
                    gclass187.decimal_0 = Convert.ToDecimal(row["WealthBalance"]);
                    gclass187.decimal_1 = Convert.ToDecimal(row["LastDividendPaid"]);
                    gclass187.decimal_2 = Convert.ToDecimal(row["LastDividendTime"]);
                    gclass187.bool_0 = Convert.ToBoolean(row["NPRace"]);
                    gclass187.string_0 = row["LineName"].ToString();
                    gclass187.string_1 = row["ShortName"].ToString();
                    ShippingLineDictionary.Add(gclass187.int_0, gclass187);
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
                         .ExecuteQuery($"select * FROM FCT_NavalAdminCommand WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                NavalAdminCommand gclass83 = new NavalAdminCommand(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                        gclass83.gclass146_0 = population;
                    gclass83.int_4 = Convert.ToInt32(row["ShipID"]);
                    AdminCommandType int32_3 = (AdminCommandType)Convert.ToInt32(row["AdminCommandTypeID"]);
                    if (AdminCommandTypeDictionary.TryGetValue(int32_3, out var value))
                        gclass83.gclass79_0 = value;
                    gclass83.Race = race;
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
                    NavalAdminCommands.Add(gclass83.int_0, gclass83);
                }
            }

            foreach (NavalAdminCommand gclass83 in NavalAdminCommands.Values)
            {
                if (NavalAdminCommands.TryGetValue(gclass83.int_1, out var command))
                    gclass83.ParentAdminCommand = command;
            }

            foreach (GameRace gclass21 in GameRaces.Values)
            {
                if (gclass21.SelectedAdminIcon > 0 && NavalAdminCommands.TryGetValue(gclass21.SelectedAdminIcon, out var command))
                    gclass21.SelectedAdmin = command;
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
                sqLiteDatabaseC1181.ExecuteQuery($"select * FROM FCT_Commander WHERE GameID = {GameID.ToString()}");
            Dictionary<int, ResearchProject> dictionary = Populations.Values
                .SelectMany(popData => popData.dictionary_1)
                .ToDictionary(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                GClass55 gclass55 = new GClass55(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass55.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (SpeciesDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass55.gclass194_0 = value;
                        int int32_3 = Convert.ToInt32(row["POWRaceID"]);
                        if (GameRaces.TryGetValue(int32_3, out var gameRace))
                            gclass55.gclass21_1 = gameRace;
                        int int32_4 = Convert.ToInt32(row["PopLocationID"]);
                        if (Populations.TryGetValue(int32_4, out var population))
                            gclass55.gclass146_0 = population;
                        int int32_5 = Convert.ToInt32(row["EducationColony"]);
                        if (Populations.TryGetValue(int32_5, out var population1))
                            gclass55.gclass146_2 = population1;
                        int int32_6 = Convert.ToInt32(row["HomeworldID"]);
                        if (SystemBodyRecordDic.TryGetValue(int32_6, out var value1))
                            gclass55.gclass1_0 = value1;
                        int int32_7 = Convert.ToInt32(row["TransportShipID"]);
                        if (Ships.TryGetValue(int32_7, out var ship))
                            gclass55.gclass40_0 = ship;
                        AuroraResearchField int32_8 = (AuroraResearchField)Convert.ToInt32(row["ResSpecID"]);
                        if (ResearchFieldDictionary.TryGetValue(int32_8, out var value2))
                        {
                            gclass55.gclass162_0 = value2;
                            int int32_9 = Convert.ToInt32(row["LifepodID"]);
                            if (dictionary_30.TryGetValue(int32_9, out var value3))
                                gclass55.gclass59_0 = value3;
                            int int32_10 = Convert.ToInt32(row["RankID"]);
                            if (gclass55.gclass21_0.RacialRankDictionary.TryGetValue(int32_10, out var value4))
                                gclass55.gclass61_0 = value4;
                            gclass55.auroraCommanderType_0 = (AuroraCommanderType)Convert.ToInt32(row["CommanderType"]);
                            gclass55.auroraCommandType_0 = (AuroraCommandType)Convert.ToInt32(row["CommandType"]);
                            int int32_11 = Convert.ToInt32(row["CommandID"]);
                            switch (gclass55.auroraCommandType_0)
                            {
                                case AuroraCommandType.Ship:
                                    if (Ships.TryGetValue(int32_11, out var ship1))
                                    {
                                        gclass55.gclass40_1 = ship1;
                                        gclass55.gclass40_1.dictionary_1.Add(AuroraCommandType.Ship, gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.Colony:
                                    if (Populations.TryGetValue(int32_11, out var population2))
                                    {
                                        gclass55.gclass146_1 = population2;
                                        gclass55.gclass146_1.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.Sector:
                                    if (gclass55.gclass21_0.dictionary_2.TryGetValue(int32_11, out var value5))
                                    {
                                        gclass55.gclass62_0 = value5;
                                        gclass55.gclass62_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.GroundFormation:
                                    if (FormationDictionary.TryGetValue(int32_11, out var value6))
                                    {
                                        gclass55.gclass103_0 = value6;
                                        gclass55.gclass103_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ResearchProject:
                                    if (dictionary.TryGetValue(int32_11, out var value7))
                                    {
                                        gclass55.gclass161_0 = value7;
                                        gclass55.gclass161_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ExecutiveOfficer:
                                    if (Ships.TryGetValue(int32_11, out var ship2))
                                    {
                                        gclass55.gclass40_2 = ship2;
                                        gclass55.gclass40_2.dictionary_1.Add(AuroraCommandType.ExecutiveOfficer,
                                            gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ChiefEngineer:
                                    if (Ships.TryGetValue(int32_11, out var ship3))
                                    {
                                        gclass55.gclass40_3 = ship3;
                                        gclass55.gclass40_3.dictionary_1.Add(AuroraCommandType.ChiefEngineer, gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.ScienceOfficer:
                                    if (Ships.TryGetValue(int32_11, out var ship4))
                                    {
                                        gclass55.gclass40_4 = ship4;
                                        gclass55.gclass40_4.dictionary_1.Add(AuroraCommandType.ScienceOfficer,
                                            gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.TacticalOfficer:
                                    if (Ships.TryGetValue(int32_11, out var ship5))
                                    {
                                        gclass55.gclass40_5 = ship5;
                                        gclass55.gclass40_5.dictionary_1.Add(AuroraCommandType.TacticalOfficer,
                                            gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.NavalAdminCommand:
                                    if (NavalAdminCommands.TryGetValue(int32_11, out var command))
                                    {
                                        gclass55.gclass83_0 = command;
                                        gclass55.gclass83_0.gclass55_0 = gclass55;
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.CAG:
                                    if (Ships.TryGetValue(int32_11, out var ship6))
                                    {
                                        gclass55.gclass40_6 = ship6;
                                        gclass55.gclass40_6.dictionary_1.Add(AuroraCommandType.CAG, gclass55);
                                        break;
                                    }

                                    gclass55.auroraCommandType_0 = AuroraCommandType.None;
                                    break;
                                case AuroraCommandType.AcademyCommandant:
                                    if (Populations.TryGetValue(int32_11, out var population3))
                                    {
                                        gclass55.gclass146_3 = population3;
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
                                dictionary_42.Add(gclass55.int_0, gclass55);
                            else
                                dictionary_43.Add(gclass55.int_0, gclass55);
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
                if (dictionary_42.TryGetValue(int32_12, out var value))
                    gclass55 = value;
                else if (dictionary_43.TryGetValue(int32_12, out var value1))
                    gclass55 = value1;
                else
                    continue;
                int int32_13 = Convert.ToInt32(row["TraitID"]);
                if (TraitNameDictionary.ContainsKey(int32_13))
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
                         .ExecuteQuery($"select * FROM FCT_Lifepods WHERE GameID = {GameID.ToString()}").Rows)
            {
                GClass59 gclass59 = new GClass59(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass59.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["SpeciesID"]);
                    if (SpeciesDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass59.gclass194_0 = value;
                        int int32_3 = Convert.ToInt32(row["SystemID"]);
                        if (StarSystemDictionary.TryGetValue(int32_3, out var value1))
                        {
                            gclass59.gclass200_0 = value1;
                            int int32_4 = Convert.ToInt32(row["ClassID"]);
                            if (ShipClasses.TryGetValue(int32_4, out var @class))
                                gclass59.gclass22_0 = @class;
                            gclass59.int_0 = Convert.ToInt32(row["LifepodID"]);
                            gclass59.int_1 = Convert.ToInt32(row["Crew"]);
                            gclass59.double_0 = Convert.ToDouble(row["Xcor"]);
                            gclass59.double_1 = Convert.ToDouble(row["Ycor"]);
                            gclass59.decimal_0 = Convert.ToDecimal(row["CreationTime"]);
                            gclass59.decimal_1 = Convert.ToDecimal(row["GradePoints"]);
                            gclass59.string_0 = row["ShipName"].ToString();
                            dictionary_30.Add(gclass59.int_0, gclass59);
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
                         .ExecuteQuery($"select * FROM FCT_CommanderBonuses WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass52 gclass52 = new GClass52();
                int int32_1 = Convert.ToInt32(row["CommanderID"]);
                GClass55 gclass55;
                if (dictionary_42.TryGetValue(int32_1, out var value))
                    gclass55 = value;
                else if (dictionary_43.TryGetValue(int32_1, out var value1))
                    gclass55 = value1;
                else
                    continue;
                CommanderBonusType int32_2 = (CommanderBonusType)Convert.ToInt32(row["BonusID"]);
                if (CommanderBonusDictionary.TryGetValue(int32_2, out var value2))
                {
                    gclass52.gclass50_0 = value2;
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
                         .ExecuteQuery($"select * FROM FCT_GroundUnitTraining where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass106 gclass106 = new GClass106(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass106.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                    {
                        gclass106.gclass146_0 = population;
                        int int32_3 = Convert.ToInt32(row["FormationTemplateID"]);
                        if (FormationTemplateRecordDic.TryGetValue(int32_3, out var value))
                        {
                            gclass106.gclass102_0 = value;
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
                         .ExecuteQuery($"select * FROM FCT_GroundUnitTrainingQueue where GameID = {GameID.ToString()}").Rows)
            {
                GClass107 gclass107 = new GClass107(this);
                int int32_1 = Convert.ToInt32(row["PopulationID"]);
                if (Populations.TryGetValue(int32_1, out var population))
                {
                    gclass107.gclass146_0 = population;
                    int int32_2 = Convert.ToInt32(row["FormationTemplateID"]);
                    if (FormationTemplateRecordDic.TryGetValue(int32_2, out var value))
                    {
                        gclass107.gclass102_0 = value;
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
                         .ExecuteQuery($"select * FROM FCT_ResearchProject WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                ResearchProject gclass161 = new ResearchProject(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    gclass161.gclass21_0 = race;
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                    {
                        gclass161.gclass146_0 = population;
                        int int32_3 = Convert.ToInt32(row["TechID"]);
                        if (TechDataDictionary.TryGetValue(int32_3, out var value))
                        {
                            gclass161.gclass164_0 = value;
                            AuroraResearchField int32_4 = (AuroraResearchField)Convert.ToInt32(row["ResSpecID"]);
                            if (ResearchFieldDictionary.TryGetValue(int32_4, out var value1))
                            {
                                gclass161.gclass162_0 = value1;
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
                         .ExecuteQuery($"select * FROM FCT_SectorCommand where GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    GClass62 gclass62 = new GClass62(this);
                    int int32_2 = Convert.ToInt32(row["PopulationID"]);
                    if (Populations.TryGetValue(int32_2, out var population))
                    {
                        gclass62.gclass146_0 = population;
                        gclass62.gclass21_0 = race;
                        gclass62.int_0 = Convert.ToInt32(row["SectorCommandID"]);
                        gclass62.SectorName = row["SectorName"].ToString();
                        int int32_3 = Convert.ToInt32(row["Colour"]);
                        gclass62.color_0 = Color.FromArgb(int32_3);
                        gclass62.gclass21_0.dictionary_2.Add(gclass62.int_0, gclass62);
                    }
                }
            }

            foreach (GameRace gclass21 in GameRaces.Values)
            {
                foreach (RacialSystemSurvey gclass202 in gclass21.RacialSystemDictionary.Values)
                {
                    if (gclass202.SectorID > 0 && gclass21.dictionary_2.TryGetValue(gclass202.SectorID, out var value))
                        gclass202.gclass62_0 = value;
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
                         .ExecuteQuery($"select * FROM FCT_Ranks Where GameID = {GameID.ToString()}").Rows)
            {
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32, out var race))
                {
                    RankThemeEntry gclass61 = new RankThemeEntry();
                    gclass61.gclass21_0 = race;
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
                         .ExecuteQuery($"select * FROM FCT_AlienRace WHERE GameID = {GameID.ToString()}").Rows)
            {
                AlienRaceInfo alienRaceInfo = new AlienRaceInfo(this);
                int int32_1 = Convert.ToInt32(row["ViewRaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    alienRaceInfo.ViewingRace = GameRaces[int32_1];
                    int int32_2 = Convert.ToInt32(row["ClassThemeID"]);
                    if (int32_2 != 0)
                        alienRaceInfo.ClassTheme = ThemeDictionary[int32_2];
                    alienRaceInfo.ActualAlienRaceID = Convert.ToInt32(row["AlienRaceID"]);
                    if (GameRaces.TryGetValue(alienRaceInfo.ActualAlienRaceID, out var race))
                    {
                        alienRaceInfo.ActualAlienRace = race;
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
                        GameRaces[int32_1].PerceivedAliens.Add(alienRaceInfo.ActualAlienRaceID, alienRaceInfo);
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
                         .ExecuteQuery($"select * FROM FCT_AlienPopulation WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass113 gclass113 = new GClass113(this);
                int int32_1 = Convert.ToInt32(row["ViewingRaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    gclass113.gclass21_0 = GameRaces[int32_1];
                    int int32_2 = Convert.ToInt32(row["AlienRaceID"]);
                    if (GameRaces.ContainsKey(int32_2) &&
                        GameRaces[int32_1].PerceivedAliens.ContainsKey(int32_2))
                    {
                        gclass113.gclass110_0 = GameRaces[int32_1].PerceivedAliens[int32_2];
                        int int32_3 = Convert.ToInt32(row["PopulationID"]);
                        if (Populations.TryGetValue(int32_3, out var population))
                        {
                            gclass113.gclass146_0 = population;
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
                            GameRaces[int32_1].dictionary_13.Add(int32_3, gclass113);
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
                         .ExecuteQuery($"select * FROM FCT_AlienRaceSpecies WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                int int32_1 = Convert.ToInt32(row["SpeciesID"]);
                if (SpeciesDictionary.TryGetValue(int32_1, out var value))
                {
                    int int32_2 = Convert.ToInt32(row["DetectRaceID"]);
                    if (GameRaces.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (GameRaces[int32_2].PerceivedAliens.ContainsKey(int32_3))
                            GameRaces[int32_2].PerceivedAliens[int32_3].dictionary_0
                                .Add(int32_1, value);
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
                         .ExecuteQuery($"select * FROM FCT_AlienSystem WHERE GameID = {GameID.ToString()}").Rows)
            {
                int int32_1 = Convert.ToInt32(row["SystemID"]);
                if (StarSystemDictionary.TryGetValue(int32_1, out var value))
                {
                    int int32_2 = Convert.ToInt32(row["DetectRaceID"]);
                    if (GameRaces.ContainsKey(int32_2))
                    {
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (GameRaces[int32_2].PerceivedAliens.ContainsKey(int32_3))
                            GameRaces[int32_2].PerceivedAliens[int32_3].dictionary_1
                                .Add(int32_1, value);
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
                         .ExecuteQuery($"select * FROM FCT_AlienRaceSensor WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass118 gclass118 = new GClass118();
                int int32_1 = Convert.ToInt32(row["ViewingRaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    gclass118.gclass21_0 = GameRaces[int32_1];
                    int int32_2 = Convert.ToInt32(row["AlienRaceID"]);
                    if (GameRaces.TryGetValue(int32_2, out var race))
                    {
                        gclass118.gclass21_1 = race;
                        int int32_3 = Convert.ToInt32(row["ActualSensor"]);
                        if (ComponentDataDictionary.TryGetValue(int32_3, out var value))
                            gclass118.gclass230_0 = value;
                        int int32_4 = Convert.ToInt32(row["ActualMissile"]);
                        if (RaceMissileDictionary.TryGetValue(int32_4, out var value1))
                            gclass118.gclass129_0 = value1;
                        int int32_5 = Convert.ToInt32(row["ActualGroundUnitClass"]);
                        if (GroundUnitClassDictionary.TryGetValue(int32_5, out var value2))
                            gclass118.gclass101_0 = value2;
                        gclass118.int_0 = Convert.ToInt32(row["AlienSensorID"]);
                        gclass118.decimal_1 = Convert.ToInt32(row["Strength"]);
                        gclass118.int_1 = Convert.ToInt32(row["Resolution"]);
                        gclass118.double_0 = Convert.ToDouble(row["Range"]);
                        gclass118.double_1 = Convert.ToDouble(row["IntelligencePoints"]);
                        gclass118.string_0 = row["Name"].ToString();
                        GameRaces[int32_1].PerceivedAliens[int32_2].dictionary_2
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
                         .ExecuteQuery($"select * FROM FCT_AlienClass where GameID = {GameID.ToString()}").Rows)
            {
                GClass115 gclass115 = new GClass115(this);
                int int32_1 = Convert.ToInt32(row["ActualClassID"]);
                if (ShipClasses.TryGetValue(int32_1, out var @class))
                {
                    gclass115.gclass22_0 = @class;
                    int int32_2 = Convert.ToInt32(row["ViewRaceID"]);
                    if (GameRaces.ContainsKey(int32_2))
                    {
                        gclass115.gclass21_1 = GameRaces[int32_2];
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (GameRaces.TryGetValue(int32_3, out var race))
                        {
                            gclass115.gclass21_0 = race;
                            gclass115.gclass110_0 = GameRaces[int32_2].PerceivedAliens[int32_3];
                            int int32_4 = Convert.ToInt32(row["HullID"]);
                            gclass115.gclass76_0 = !ShipHullDictionary.TryGetValue(int32_4, out var value)
                                ? ShipHullDictionary[5]
                                : value;
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
                            GameRaces[int32_2].dictionary_11.Add(gclass115.int_0, gclass115);
                        }
                    }
                }
            }

            Dictionary<int, GClass115> dictionary1 = GameRaces.Values
                .SelectMany(gclass21_0 => gclass21_0.dictionary_11)
                .ToDictionary(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            Dictionary<int, GClass118> dictionary2 = GameRaces.Values
                .SelectMany(gclass21_0 => gclass21_0.PerceivedAliens.Values)
                .SelectMany(gclass110_0 => gclass110_0.dictionary_2)
                .Distinct()
                .ToDictionary(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienClassSensor where GameID = {GameID.ToString()}")
                         .Rows)
            {
                int int32_5 = Convert.ToInt32(row["AlienSensorID"]);
                if (dictionary2.TryGetValue(int32_5, out var value))
                {
                    int int32_6 = Convert.ToInt32(row["AlienClassID"]);
                    if (dictionary1.ContainsKey(int32_6))
                        dictionary1[int32_6].list_0.Add(value);
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * FROM FCT_AlienClassWeapon where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass119 gclass119 = new GClass119();
                int int32_7 = Convert.ToInt32(row["AlienClassID"]);
                if (dictionary1.ContainsKey(int32_7))
                {
                    int int32_8 = Convert.ToInt32(row["WeaponID"]);
                    if (ComponentDataDictionary.TryGetValue(int32_8, out var value))
                    {
                        gclass119.gclass230_0 = value;
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
                    if (TechDataDictionary.TryGetValue(int32_10, out var value))
                        dictionary1[int32_9].list_2.Add(value);
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
                         .ExecuteQuery($"select * FROM FCT_AlienShip where GameID = {GameID.ToString()}").Rows)
            {
                GClass117 gclass117 = new GClass117(this);
                int int32_1 = Convert.ToInt32(row["ViewRaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    gclass117.gclass21_1 = GameRaces[int32_1];
                    int int32_2 = Convert.ToInt32(row["AlienClassID"]);
                    if (GameRaces[int32_1].dictionary_11.ContainsKey(int32_2))
                    {
                        gclass117.gclass115_0 = GameRaces[int32_1].method_322(int32_2);
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (GameRaces.TryGetValue(int32_3, out var race))
                        {
                            gclass117.gclass21_0 = race;
                            gclass117.gclass110_0 = GameRaces[int32_1].PerceivedAliens[int32_3];
                            int int32_4 = Convert.ToInt32(row["LastSysID"]);
                            if (StarSystemDictionary.TryGetValue(int32_4, out var value))
                                gclass117.gclass200_0 = value;
                            gclass117.int_0 = Convert.ToInt32(row["ShipID"]);
                            if (Ships.TryGetValue(gclass117.int_0, out var ship))
                                gclass117.gclass40_0 = ship;
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
                            GameRaces[int32_1].dictionary_12.Add(gclass117.int_0, gclass117);
                        }
                    }
                }
            }

            foreach (FleetData gclass85 in FleetDictionary.Values)
            {
                if (gclass85.SpecificThreatID > 0 && GameRaces[gclass85.Race.RaceID].dictionary_12
                        .ContainsKey(gclass85.SpecificThreatID))
                    gclass85.gclass117_0 =
                        GameRaces[gclass85.Race.RaceID].dictionary_12[gclass85.SpecificThreatID];
            }

            foreach (SubFleet gclass84 in SubFleetDictionary.Values)
            {
                if (gclass84.SpecificThreatID > 0 && GameRaces[gclass84.Race.RaceID].dictionary_12
                        .ContainsKey(gclass84.SpecificThreatID))
                    gclass84.gclass117_0 =
                        GameRaces[gclass84.Race.RaceID].dictionary_12[gclass84.SpecificThreatID];
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
                             $"SELECT * FROM FCT_AlienGroundUnitClass where GameID = {GameID.ToString()}").Rows)
            {
                GClass114 gclass114 = new GClass114(this);
                int int32_1 = Convert.ToInt32(row["ViewRaceID"]);
                if (GameRaces.ContainsKey(int32_1))
                {
                    gclass114.gclass21_0 = GameRaces[int32_1];
                    int int32_2 = Convert.ToInt32(row["ActualUnitClassID"]);
                    if (GroundUnitClassDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass114.gclass101_0 = value;
                        int int32_3 = Convert.ToInt32(row["AlienRaceID"]);
                        if (GameRaces.TryGetValue(int32_3, out var race))
                        {
                            gclass114.gclass21_1 = race;
                            gclass114.gclass110_0 = GameRaces[int32_1].PerceivedAliens[int32_3];
                            gclass114.int_0 = Convert.ToInt32(row["AlienGroundUnitClassID"]);
                            gclass114.int_1 = Convert.ToInt32(row["Hits"]);
                            gclass114.int_2 = Convert.ToInt32(row["Penetrated"]);
                            gclass114.int_3 = Convert.ToInt32(row["Destroyed"]);
                            gclass114.bool_0 = Convert.ToBoolean(row["WeaponsKnown"]);
                            gclass114.string_0 = row["Name"].ToString();
                            GameRaces[int32_1].dictionary_14.Add(gclass114.int_0, gclass114);
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
                         .ExecuteQuery($"select * FROM FCT_RaceTech where GameID = {GameID.ToString()}").Rows)
            {
                GClass165 gclass165 = new GClass165();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                int int32_2 = Convert.ToInt32(row["TechID"]);
                if (GameRaces.ContainsKey(int32_1) && TechDataDictionary.ContainsKey(int32_2))
                {
                    gclass165.gclass164_0 = TechDataDictionary[int32_2];
                    gclass165.gclass21_0 = GameRaces[int32_1];
                    gclass165.bool_0 = Convert.ToBoolean(row["Obsolete"]);
                    TechDataDictionary[int32_2].dictionary_0.Add(int32_1, gclass165);
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
                         .ExecuteQuery($"select * FROM FCT_EligibleProjects where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass165 gclass165 = new GClass165();
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                int int32_2 = Convert.ToInt32(row["TechSystemID"]);
                if (GameRaces.ContainsKey(int32_1) && TechDataDictionary.TryGetValue(int32_2, out var value))
                    GameRaces[int32_1].list_18.Add(value);
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
                         .ExecuteQuery($"select * FROM FCT_AetherRift WHERE GameID = {GameID.ToString()}").Rows)
            {
                GClass211 gclass211 = new GClass211(this);
                int int32 = Convert.ToInt32(row["SystemID"]);
                if (StarSystemDictionary.TryGetValue(int32, out var value))
                {
                    gclass211.gclass200_0 = value;
                    gclass211.double_0 = Convert.ToDouble(row["Xcor"]);
                    gclass211.double_1 = Convert.ToDouble(row["Ycor"]);
                    gclass211.double_2 = Convert.ToDouble(row["Diameter"]);
                    dictionary_15.Add(int32, gclass211);
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
                         .ExecuteQuery($"select * FROM FCT_AetherGates WHERE GameID = {GameID.ToString()}").Rows)
            {
                GClass210 gclass210 = new GClass210(this);
                int int32 = Convert.ToInt32(row["SystemID"]);
                if (StarSystemDictionary.TryGetValue(int32, out var value))
                {
                    gclass210.gclass200_0 = value;
                    gclass210.int_0 = Convert.ToInt32(row["AetherGateID"]);
                    gclass210.decimal_0 = Convert.ToDecimal(row["CreationTime"]);
                    gclass210.double_0 = Convert.ToDouble(row["Xcor"]);
                    gclass210.double_1 = Convert.ToDouble(row["Ycor"]);
                    gclass210.double_2 = Convert.ToDouble(row["CooldownTime"]);
                    dictionary_16.Add(gclass210.int_0, gclass210);
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
                             ? $"SELECT * FROM FCT_TechSystem where GameID = {GameID.ToString()}"
                             : "SELECT * FROM FCT_TechSystem where GameID = 0").Rows)
            {
                TechSystem gclass164 = new TechSystem();
                TechType int32 = (TechType)Convert.ToInt32(row["TechTypeID"]);
                if (TechTypeDataDictionary.TryGetValue(int32, out var value))
                    gclass164.gclass163_0 = value;
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
                if (GameRaces.TryGetValue(gclass164.int_1, out var race))
                    gclass164.gclass21_0 = race;
                TechDataDictionary.Add(gclass164.TechSystemID, gclass164);
            }

            foreach (TechSystem gclass164 in TechDataDictionary.Values)
            {
                if (TechDataDictionary.TryGetValue(gclass164.int_2, out var value))
                    gclass164.gclass164_0 = value;
                if (TechDataDictionary.TryGetValue(gclass164.int_3, out var value1))
                    gclass164.gclass164_1 = value1;
            }

            foreach (Species gclass194 in SpeciesDictionary.Values
                         .Where(gclass194_0 => gclass194_0.int_9 > 0).ToList())
                gclass194.gclass164_0 = !TechDataDictionary.TryGetValue(gclass194.int_9, out var value)
                    ? null
                    : value;
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
                dictionary_76.Add(gclass185.int_0, gclass185);
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
                             ? $"SELECT * FROM FCT_ShipDesignComponents where GameID = {GameID.ToString()}"
                             : "SELECT * FROM FCT_ShipDesignComponents where GameID = 0").Rows)
            {
                ShipComponent gclass230 = new ShipComponent();
                gclass230.int_0 = Convert.ToInt32(row["SDComponentID"]);
                if (TechDataDictionary.TryGetValue(gclass230.int_0, out var value))
                {
                    int int32_1 = Convert.ToInt32(row["ShipComponentTemplateID"]);
                    if (dictionary_76.TryGetValue(int32_1, out var value1))
                        gclass230.gclass185_0 = value1;
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
                    gclass230.gclass164_0 = value;
                    AuroraComponentType int32_2 = (AuroraComponentType)Convert.ToInt32(row["ComponentTypeID"]);
                    if (ComponentTypeDictionary.TryGetValue(int32_2, out var value2))
                    {
                        gclass230.gclass231_0 = value2;
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
                        ComponentDataDictionary.Add(gclass230.int_0, gclass230);
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
                         .ExecuteQuery($"select * FROM FCT_Prisoners where GameID = {GameID.ToString()}").Rows)
            {
                GClass147 gclass147 = new GClass147();
                int int32_1 = Convert.ToInt32(row["PopulationID"]);
                if (Populations.ContainsKey(int32_1))
                {
                    gclass147.gclass146_0 = Populations[int32_1];
                    int int32_2 = Convert.ToInt32(row["PrisonerRaceID"]);
                    if (GameRaces.TryGetValue(int32_2, out var race))
                    {
                        int int32_3 = Convert.ToInt32(row["PrisonerSpeciesID"]);
                        if (SpeciesDictionary.TryGetValue(int32_3, out var value))
                        {
                            gclass147.gclass21_0 = race;
                            gclass147.gclass194_0 = value;
                            gclass147.int_0 = Convert.ToInt32(row["NumPrisoners"]);
                            gclass147.int_1 = Convert.ToInt32(row["NumProcessed"]);
                            Populations[int32_1].list_3.Add(gclass147);
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
                         .ExecuteQuery($"select * FROM FCT_Increments where GameID = {GameID.ToString()}").Rows)
            {
                GClass91 gclass91 = new GClass91();
                gclass91.int_0 = Convert.ToInt32(row["IncrementID"]);
                gclass91.int_1 = Convert.ToInt32(row["Length"]);
                gclass91.decimal_0 = Convert.ToDecimal(row["GameTime"]);
                gclass92_0.dictionary_0.Add(gclass91.int_0, gclass91);
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
                             $"SELECT * FROM FCT_GameLog where GameID = {GameID.ToString()} ORDER BY IncrementID desc LIMIT 10000")
                         .Rows)
            {
                GClass87 gclass87 = new GClass87();
                int int32_1 = Convert.ToInt32(row["IncrementID"]);
                if (gclass92_0.dictionary_0.TryGetValue(int32_1, out var value))
                {
                    gclass87.gclass91_0 = value;
                    EventType int32_2 = (EventType)Convert.ToInt32(row["EventType"]);
                    if (DIMEventTypeDictionary.TryGetValue(int32_2, out var value1))
                    {
                        gclass87.gclass88_0 = value1;
                        int int32_3 = Convert.ToInt32(row["RaceID"]);
                        if (GameRaces.TryGetValue(int32_3, out var race))
                        {
                            gclass87.gclass21_0 = race;
                            int int32_4 = Convert.ToInt32(row["SystemID"]);
                            if (StarSystemDictionary.TryGetValue(int32_4, out var value2))
                                gclass87.gclass200_0 = value2;
                            int int32_5 = Convert.ToInt32(row["PopulationID"]);
                            if (Populations.TryGetValue(int32_5, out var population))
                                gclass87.gclass146_0 = population;
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
                         .ExecuteQuery($"select * FROM FCT_PrecursorTombGroup where GameID = {GameID.ToString()}")
                         .Rows)
            {
                GClass172 gclass172 = new GClass172();
                int int32_1 = Convert.ToInt32(row["SystemBodyID"]);
                if (SystemBodyRecordDic.TryGetValue(int32_1, out var value))
                {
                    gclass172.gclass1_0 = value;
                    OperationalGroupID int32_2 = (OperationalGroupID)Convert.ToInt32(row["OperationalGroupID"]);
                    if (OperationalGroupDictionary.TryGetValue(int32_2, out var value1))
                        gclass172.gclass9_0 = value1;
                    int int32_3 = Convert.ToInt32(row["FormationTemplateID"]);
                    if (FormationTemplateRecordDic.TryGetValue(int32_3, out var value2))
                        gclass172.gclass102_0 = value2;
                    gclass172.int_0 = Convert.ToInt32(row["NumGroups"]);
                    gclass172.decimal_0 = Convert.ToDecimal(row["EmergenceTime"]);
                    gclass172.decimal_1 = Convert.ToDecimal(row["LastTriggerEvent"]);
                    list_8.Add(gclass172);
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
                         .ExecuteQuery($"select * FROM FCT_EventColour where GameID = {GameID.ToString()}").Rows)
            {
                EventColourSetting colourSetting = new EventColourSetting();
                colourSetting.RaceID = Convert.ToInt32(row["RaceID"]);
                EventType eventTypeID = (EventType)Convert.ToInt32(row["EventTypeID"]);
                if (DIMEventTypeDictionary.TryGetValue(eventTypeID, out var value))
                {
                    colourSetting.EventType = value;
                    int textColour = Convert.ToInt32(row["TextColour"]);
                    int alertColour = Convert.ToInt32(row["AlertColour"]);
                    colourSetting.TextColour = Color.FromArgb(255, Color.FromArgb(alertColour));
                    colourSetting.AlertColour = Color.FromArgb(255, Color.FromArgb(textColour));
                    if (GameRaces.ContainsKey(colourSetting.RaceID))
                        GameRaces[colourSetting.RaceID].EventColourSettings.Add(eventTypeID, colourSetting);
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
                if (GameRaces.ContainsKey(hideEventData.RaceID) || hideEventData.RaceID <= 0)
                {
                    hideEventData.EventType = (EventType)Convert.ToInt32(row["EventID"]);
                    if (DIMEventTypeDictionary.ContainsKey(hideEventData.EventType))
                        HideEventList.Add(hideEventData);
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
                         .ExecuteQuery($"select * from FCT_RaceSysSurvey where GameID = {GameID.ToString()}").Rows)
            {
                RacialSystemSurvey raceSystemSurvey = new RacialSystemSurvey(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    raceSystemSurvey.Race = race;
                    int int32_2 = Convert.ToInt32(row["SystemID"]);
                    if (StarSystemDictionary.TryGetValue(int32_2, out var value))
                    {
                        raceSystemSurvey.ActualSystem = value;
                        int int32_3 = Convert.ToInt32(row["NameThemeID"]);
                        if (ThemeDictionary.TryGetValue(int32_3, out var value1))
                            raceSystemSurvey.NamingTheme = value1;
                        int int32_4 = Convert.ToInt32(row["ControlRaceID"]);
                        if (raceSystemSurvey.Race.PerceivedAliens.TryGetValue(int32_4, out var alien))
                            raceSystemSurvey.gclass110_0 = alien;
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
                            raceSystemSurvey.KmPerPixel = raceSystemSurvey.ActualSystem.method_39() * AuroraUtils.double_16;
                        raceSystemSurvey.Race.RacialSystemDictionary.Add(raceSystemSurvey.ActualSystem.SystemID, raceSystemSurvey);
                        if (raceSystemSurvey.Race.NPR)
                        {
                            raceSystemSurvey.gclass3_0 = new GClass3(this, raceSystemSurvey);
                            raceSystemSurvey.gclass3_0.genum95_0 = (GEnum95)Convert.ToInt32(row["SystemValue"]);
                        }
                    }
                }
            }

            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"select * from FCT_RaceJumpPointSurvey where GameID = {GameID.ToString()}")
                         .Rows)
            {
                RaceJumpPointSurvey RacialJPKnowledge = new RaceJumpPointSurvey();
                int int32 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32, out var race))
                {
                    RacialJPKnowledge.Race = race;
                    RacialJPKnowledge.JumpPointID = Convert.ToInt32(row["WarpPointID"]);
                    if (JumpPointDictionary.TryGetValue(RacialJPKnowledge.JumpPointID, out var value))
                    {
                        RacialJPKnowledge.JumpPoint = value;
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
                new SQLiteDatabaseC1181().ExecuteQuery($"select * from FCT_AlienRaceSystemStatus where GameID = {GameID.ToString()}");
            
            /* ** Weird line : Result not used. Disabling.
            this.FCTRaceRecordDic.Values
                .SelectMany(raceRecord => raceRecord.RacialSystemDictionary.Values)
                .ToList();
            */
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                AlienRaceSystemStatus gclass111 = new AlienRaceSystemStatus();
                int int32_5 = Convert.ToInt32(row["ViewingRaceID"]);
                if (GameRaces.ContainsKey(int32_5))
                {
                    GameRace viewingRace = GameRaces[int32_5];
                    int int32_6 = Convert.ToInt32(row["SystemID"]);
                    if (StarSystemDictionary.TryGetValue(int32_6, out var systemData))
                    {
                        int int32_7 = Convert.ToInt32(row["AlienRaceID"]);
                        if (GameRaces.ContainsKey(int32_7) &&
                            GameRaces[int32_5].PerceivedAliens.ContainsKey(int32_7) &&
                            GameRaces[int32_5].RacialSystemDictionary.ContainsKey(int32_6))
                        {
                            gclass111.gclass202_0 = GameRaces[int32_5].RacialSystemDictionary[int32_6];
                            gclass111.gclass110_0 = GameRaces[int32_5].PerceivedAliens[int32_7];
                            gclass111.auroraSystemProtectionStatus_0 =
                                (AuroraSystemProtectionStatus)Convert.ToInt32(row["ProtectionStatusID"]);
                            GameRaces[int32_5].RacialSystemDictionary[int32_6].dictionary_0
                                .Add(GameRaces[int32_5].PerceivedAliens[int32_7], gclass111);
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
                         .ExecuteQuery($"select * from FCT_ShipTechData where GameID = {GameID.ToString()}").Rows)
            {
                ShipTechData182 shipTechData = new ShipTechData182();
                int shipId = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(shipId))
                {
                    shipTechData.ShipData = Ships[shipId];
                    int techID = Convert.ToInt32(row["TechID"]);
                    if (TechDataDictionary.TryGetValue(techID, out var value))
                    {
                        shipTechData.TechData = value;
                        shipTechData.TechPoints = Convert.ToInt32(row["TechPoints"]);
                        Ships[shipId].ShipTechDataList.Add(shipTechData);
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
                         .ExecuteQuery($"select * from FCT_Star where GameID = {GameID.ToString()}").Rows)
            {
                Star197 star = new Star197(this);
                star.SystemID = Convert.ToInt32(row["SystemID"]);
                if (StarSystemDictionary.ContainsKey(star.SystemID))
                {
                    int starTypeID = Convert.ToInt32(row["StarTypeID"]);
                    if (StarTypeDictionary.TryGetValue(starTypeID, out var value))
                        star.StellarType = value;
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
                    star.SystemData = StarSystemDictionary[star.SystemID];
                    if (star.Component == 1)
                        star.SystemData.double_6 = star.StellarType.Mass;
                    StarDictionary.Add(star.StarID, star);
                }
            }

            foreach (Star197 star in StarDictionary.Values)
            {
                if (star.OrbitingComponent > 0)
                {
                    Star197 orbitingStar = StarDictionary.Values
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
                             $"select * from FCT_JumpPoint where GameID = {GameID.ToString()} order by distance")
                         .Rows)
            {
                JumpPoint jumpPoint = new JumpPoint(this);
                int systemID = Convert.ToInt32(row["SystemID"]);
                jumpPoint.SystemData = StarSystemDictionary[systemID];
                jumpPoint.WarpPointID = Convert.ToInt32(row["WarpPointID"]);
                jumpPoint.LinkedWarpPointID = Convert.ToInt32(row["WPLink"]);
                jumpPoint.Bearing = Convert.ToInt32(row["Bearing"]);
                jumpPoint.JumpGateStrength = Convert.ToInt32(row["JumpGateStrength"]);
                jumpPoint.JumpGateRaceID = Convert.ToInt32(row["JumpGateRaceID"]);
                jumpPoint.XCoord = Convert.ToDouble(row["Xcor"]);
                jumpPoint.YCoord = Convert.ToDouble(row["Ycor"]);
                jumpPoint.Distance = Convert.ToDouble(row["Distance"]);
                JumpPointDictionary.Add(jumpPoint.WarpPointID, jumpPoint);
                jumpPoint.NumJumpPointsInSameSystem = StarSystemDictionary[systemID].GetNumberOfJumpPoints();
            }

            foreach (JumpPoint jumpPoint in JumpPointDictionary.Values)
            {
                if (jumpPoint.LinkedWarpPointID > 0)
                    jumpPoint.LinkedJumpPoint = JumpPointDictionary[jumpPoint.LinkedWarpPointID];
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
                         .ExecuteQuery($"select * FROM FCT_WeaponRecharge WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(shipID))
                {
                    int weaponID = Convert.ToInt32(row["WeaponID"]);
                    if (ComponentDataDictionary.TryGetValue(weaponID, out var value))
                    {
                        int weaponNum = Convert.ToInt32(row["WeaponNumber"]);
                        Decimal remainingRecharge = Convert.ToDecimal(row["RechargeRemaining"]);
                        WeaponComponentRechargeStatus gclass27 = new WeaponComponentRechargeStatus(value, weaponNum, remainingRecharge);
                        Ships[shipID].list_7.Add(gclass27);
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
                         .ExecuteQuery($"select * FROM FCT_WeaponAssignment WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                WeaponFireControlAssignment weaponFCAssign = new WeaponFireControlAssignment();
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(shipID))
                {
                    weaponFCAssign.Ship = Ships[shipID];
                    int weaponID = Convert.ToInt32(row["WeaponID"]);
                    if (ComponentDataDictionary.TryGetValue(weaponID, out var value))
                    {
                        weaponFCAssign.WeaponComponent = value;
                        int fcTypeID = Convert.ToInt32(row["FCTypeID"]);
                        if (ComponentDataDictionary.TryGetValue(fcTypeID, out var value1))
                        {
                            weaponFCAssign.FireControlComponent = value1;
                            weaponFCAssign.WeaponNum = Convert.ToInt32(row["WeaponNum"]);
                            weaponFCAssign.FireControlNum = Convert.ToInt32(row["FCNum"]);
                            Ships[shipID].list_2.Add(weaponFCAssign);
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
                         .ExecuteQuery($"select * FROM FCT_FireControlAssignment WHERE GameID = {GameID.ToString()}").Rows)
            {
                FireControlAssignment fcsStatus = new FireControlAssignment(this);
                int shipID = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(shipID))
                {
                    fcsStatus.Ship = Ships[shipID];
                    int fcCompID = Convert.ToInt32(row["FCTypeID"]);
                    if (ComponentDataDictionary.TryGetValue(fcCompID, out var value))
                    {
                        fcsStatus.FCComponent = value;
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
                        Ships[shipID].list_4.Add(fcsStatus);
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
                         .ExecuteQuery($"select * FROM FCT_MissileAssignment WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                MissileAssignment gclass30 = new MissileAssignment();
                int int32_1 = Convert.ToInt32(row["ShipID"]);
                if (Ships.ContainsKey(int32_1))
                {
                    int int32_2 = Convert.ToInt32(row["MissileID"]);
                    if (RaceMissileDictionary.TryGetValue(int32_2, out var value))
                    {
                        gclass30.Missile = value;
                        int int32_3 = Convert.ToInt32(row["WeaponID"]);
                        if (ComponentDataDictionary.TryGetValue(int32_3, out var value1))
                        {
                            gclass30.FiringWeaponComponent = value1;
                            gclass30.WeaponNum = Convert.ToInt32(row["WeaponNum"]);
                            Ships[int32_1].FiredMissiles.Add(gclass30);
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
                         .ExecuteQuery($"select * FROM FCT_DesignPhilosophyTechProgressionCategories WHERE GameID = {GameID.ToString()}").Rows)
            {
                int race = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.ContainsKey(race))
                {
                    TechProgressionCategoryType int32_2 = (TechProgressionCategoryType)Convert.ToInt32(row["TechProgressionCategoryID"]);
                    GameRaces[race].DesignDoctrine.list_2.Add(int32_2);
                }
            }

            foreach (GameRace gclass21 in GameRaces.Values)
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
                         .ExecuteQuery($"select * FROM FCT_DesignPhilosophy WHERE GameID = {GameID.ToString()}")
                         .Rows)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Class87 class87 = new Class87();
                // ISSUE: reference to a compiler-generated field
                class87.DesignDoctrine = new DesignDoctrine(this);
                int int32_1 = Convert.ToInt32(row["RaceID"]);
                if (GameRaces.TryGetValue(int32_1, out var race))
                {
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Race = race;
                    int int32_2 = Convert.ToInt32(row["LauncherSizeModifier"]);
                    if (TechDataDictionary.TryGetValue(int32_2, out var value))
                    {
                        // ISSUE: reference to a compiler-generated field
                        class87.DesignDoctrine.gclass164_0 = value;
                    }

                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiMissile = method_361(Convert.ToInt32(row["ActiveAntiMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiMissileSmall = method_361(Convert.ToInt32(row["ActiveAntiMissileSmall"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiFAC = method_361(Convert.ToInt32(row["ActiveAntiFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveAntiFighter = method_361(Convert.ToInt32(row["ActiveAntiFighter"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveNavigation = method_361(Convert.ToInt32(row["ActiveNavigation"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveStandard = method_361(Convert.ToInt32(row["ActiveStandard"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveLarge = method_361(Convert.ToInt32(row["ActiveLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveVeryLarge = method_361(Convert.ToInt32(row["ActiveVeryLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveSmall = method_361(Convert.ToInt32(row["ActiveSmall"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveFighterMissile = method_361(Convert.ToInt32(row["ActiveFighterMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ActiveFighterBeam = method_361(Convert.ToInt32(row["ActiveFighterBeam"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSAntiMissile = method_361(Convert.ToInt32(row["FireControlAntiMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSAntiFAC = method_361(Convert.ToInt32(row["FireControlAntiFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSAntiFighter = method_361(Convert.ToInt32(row["FireControlAntiFighter"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSStandardMissile =
                        method_361(Convert.ToInt32(row["FireControlStandardMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSFastAttackCraftMissile = method_361(Convert.ToInt32(row["FireControlFACMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSRange = method_361(Convert.ToInt32(row["FireControlBeamRange"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSShortRange =
                        method_361(Convert.ToInt32(row["FireControlBeamShortRange"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSSpeed = method_361(Convert.ToInt32(row["FireControlBeamSpeed"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FCSFighterMissile =
                        method_361(Convert.ToInt32(row["FireControlFighterMissile"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.BeamFCSFighter = method_361(Convert.ToInt32(row["FireControlFighterBeam"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveDreadnought = method_361(Convert.ToInt32(row["JumpDriveDreadnought"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveBattlecruiser = method_361(Convert.ToInt32(row["JumpDriveBattlecruiser"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveCruiser = method_361(Convert.ToInt32(row["JumpDriveCruiser"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveDestroyer = method_361(Convert.ToInt32(row["JumpDriveDestroyer"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveSurvey = method_361(Convert.ToInt32(row["JumpDriveSurvey"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveMediumHive = method_361(Convert.ToInt32(row["JumpDriveMediumHive"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveLargeHive = method_361(Convert.ToInt32(row["JumpDriveLargeHive"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.JumpDriveVeryLargeHive = method_361(Convert.ToInt32(row["JumpDriveVeryLargeHive"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.PointDefenceWeapon = method_361(Convert.ToInt32(row["PointDefenceWeapon"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Carronade = method_361(Convert.ToInt32(row["Carronade"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CIWS = method_361(Convert.ToInt32(row["CIWS"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Gauss = method_361(Convert.ToInt32(row["Gauss"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Meson = method_361(Convert.ToInt32(row["Meson"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MesonPointDefence = method_361(Convert.ToInt32(row["MesonPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.RailgunPointDefence = method_361(Convert.ToInt32(row["RailgunPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LaserLarge = method_361(Convert.ToInt32(row["LaserLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LaserPointDefence = method_361(Convert.ToInt32(row["LaserPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LaserSpinal = method_361(Convert.ToInt32(row["LaserSpinal"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ParticleBeam = method_361(Convert.ToInt32(row["ParticleBeam"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.Railgun = method_361(Convert.ToInt32(row["Railgun"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.HighPowerMicrowaveLarge = method_361(Convert.ToInt32(row["HighPowerMicrowaveLarge"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.HighPowerMicrowaveSmall = method_361(Convert.ToInt32(row["HighPowerMicrowaveSmall"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.FighterBeamWeapon = method_361(Convert.ToInt32(row["FighterBeamWeapon"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherFAC = method_361(Convert.ToInt32(row["LauncherFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherStandard = method_361(Convert.ToInt32(row["LauncherStandard"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherMine = method_361(Convert.ToInt32(row["LauncherMine"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherPointDefence = method_361(Convert.ToInt32(row["LauncherPointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.LauncherDecoy = method_361(Convert.ToInt32(row["LauncherDecoy"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineCommercial = method_361(Convert.ToInt32(row["EngineCommercial"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineMilitary = method_361(Convert.ToInt32(row["EngineMilitary"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineFAC = method_361(Convert.ToInt32(row["EngineFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineFighter = method_361(Convert.ToInt32(row["EngineFighter"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EngineSurvey = method_361(Convert.ToInt32(row["EngineSurvey"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CloakDD = method_361(Convert.ToInt32(row["CloakDD"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CloakCA = method_361(Convert.ToInt32(row["CloakCA"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.CloakBC = method_361(Convert.ToInt32(row["CloakBC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ShieldProportion = Convert.ToDouble(row["ShieldProportion"]);
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize1 = method_361(Convert.ToInt32(row["EMSensorSize1"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize2 = method_361(Convert.ToInt32(row["EMSensorSize2"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize3 = method_361(Convert.ToInt32(row["EMSensorSize3"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.EMSensorSize6 = method_361(Convert.ToInt32(row["EMSensorSize6"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize1 = method_361(Convert.ToInt32(row["ThermalSensorSize1"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize2 = method_361(Convert.ToInt32(row["ThermalSensorSize2"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize3 = method_361(Convert.ToInt32(row["ThermalSensorSize3"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.ThermalSensorSize6 = method_361(Convert.ToInt32(row["ThermalSensorSize6"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileFAC = method_362(Convert.ToInt32(row["MissileFAC"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileCaptorMine = method_362(Convert.ToInt32(row["MissileCaptorMine"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileMineSecondStage = method_362(Convert.ToInt32(row["MissileMineSecondStage"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissilePointDefence = method_362(Convert.ToInt32(row["MissilePointDefence"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.MissileStandard = method_362(Convert.ToInt32(row["MissileStandard"]));
                    // ISSUE: reference to a compiler-generated field
                    class87.DesignDoctrine.DecoyMissile = method_362(Convert.ToInt32(row["DecoyMissile"]));
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
                    class87.DesignDoctrine.NameList_0 = list_4.Where(class87.Class16WherePredicate).ToList();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class87.DesignDoctrine.NameList_3 = list_2.Where(class87.Class12WherePredicate)
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