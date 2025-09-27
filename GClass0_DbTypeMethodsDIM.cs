using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aurora;

public partial class GClass0
{
    public void LoadKnownSystemsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery($"SELECT * FROM DIM_KnownSystems where GameID = 0 OR GameID = {this.GameID.ToString()}").Rows)
            {
                DIMKnownSystemsData198 knownSystemData = new DIMKnownSystemsData198();
                int int32_1 = Convert.ToInt32(row["Component1ID"]);
                if (int32_1 <= 0 || this.StarTypeDictionary.ContainsKey(int32_1))
                {
                    if (int32_1 > 0)
                    {
                        knownSystemData.dictionary_0.Add(1, this.StarTypeDictionary[int32_1].method_0());
                        ++knownSystemData.int_1;
                    }

                    int int32_2 = Convert.ToInt32(row["Component2ID"]);
                    if (int32_2 <= 0 || this.StarTypeDictionary.ContainsKey(int32_2))
                    {
                        if (int32_2 > 0)
                        {
                            knownSystemData.dictionary_0.Add(2, this.StarTypeDictionary[int32_2].method_0());
                            ++knownSystemData.int_1;
                        }

                        int int32_3 = Convert.ToInt32(row["Component3ID"]);
                        if (int32_3 <= 0 || this.StarTypeDictionary.ContainsKey(int32_3))
                        {
                            if (int32_3 > 0)
                            {
                                knownSystemData.dictionary_0.Add(3, this.StarTypeDictionary[int32_3].method_0());
                                ++knownSystemData.int_1;
                            }

                            int int32_4 = Convert.ToInt32(row["Component4ID"]);
                            if (int32_4 <= 0 || this.StarTypeDictionary.ContainsKey(int32_4))
                            {
                                if (int32_4 > 0)
                                {
                                    knownSystemData.dictionary_0.Add(4, this.StarTypeDictionary[int32_4].method_0());
                                    ++knownSystemData.int_1;
                                }

                                knownSystemData.KnownSystemID = Convert.ToInt32(row["KnownSystemID"]);
                                knownSystemData.C3OrbitType = Convert.ToInt32(row["C3OrbitType"]);
                                knownSystemData.C4OrbitType = Convert.ToInt32(row["C4OrbitType"]);
                                knownSystemData.C2Orbit = Convert.ToDouble(row["C2Orbit"]);
                                knownSystemData.C3Orbit = Convert.ToDouble(row["C3Orbit"]);
                                knownSystemData.C4Orbit = Convert.ToDouble(row["C4Orbit"]);
                                knownSystemData.X = Convert.ToDouble(row["X"]);
                                knownSystemData.Y = Convert.ToDouble(row["Y"]);
                                knownSystemData.Z = Convert.ToDouble(row["Z"]);
                                knownSystemData.Distance = Convert.ToDouble(row["Distance"]);
                                knownSystemData.Name = row["Name"].ToString();
                                knownSystemData.ConstellationName = row["ConstellationName"].ToString();
                                this.KnownSystemDataDictionary.Add(knownSystemData.KnownSystemID, knownSystemData);
                            }
                        }
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1373);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1374);
        }
    }

    public void LoadEventTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_EventType").Rows)
            {
                DIMEventTypeData88 gclass88 = new DIMEventTypeData88();
                gclass88.EventTypeId = (EventType)Convert.ToInt32(row["EventTypeID"]);
                gclass88.CombatDisplay = Convert.ToInt32(row["CombatDisplay"]);
                gclass88.DamageDisplay = Convert.ToInt32(row["DamageDisplay"]);
                gclass88.AttackEvent = Convert.ToBoolean(row["AttackEvent"]);
                gclass88.PlayerInterrupt = Convert.ToBoolean(row["PlayerInterrupt"]);
                gclass88.AIInterrupt = Convert.ToBoolean(row["AIInterrupt"]);
                gclass88.Description = row["Description"].ToString();
                this.DIMEventTypeDictionary.Add(gclass88.EventTypeId, gclass88);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1362);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1363);
        }
    }
    
    // Guess: LoadPlanetaryTerrainFromDB; creates GClass99 (PlanetTerrainDefinition)
    public void LoadPlanetaryTerrainFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_PlanetaryTerrain").Rows)
            {
                PlanetaryTerrainDefinition gclass99 = new PlanetaryTerrainDefinition();
                gclass99.DominantTerrainType = (PlanetDominantTerrain)Convert.ToInt32(row["TerrainID"]);
                gclass99.BaseTerrainType = (PlanetDominantTerrain)Convert.ToInt32(row["BaseTerrainType"]);
                gclass99.MinTectonics = (AuroraTectonics)Convert.ToInt32(row["MinimumTectonics"]);
                gclass99.MaximumTectonics = (AuroraTectonics)Convert.ToInt32(row["MaximumTectonics"]);
                gclass99.MinTempRange = Convert.ToInt32(row["MinTempRange"]);
                gclass99.ToHitModifier = Convert.ToDecimal(row["ToHitModifier"]);
                gclass99.FortificationModifier = Convert.ToDecimal(row["FortificationModifier"]);
                gclass99.MinimumHydro = Convert.ToDouble(row["MinimumHydro"]);
                gclass99.MaximumHydro = Convert.ToDouble(row["MaximumHydro"]);
                gclass99.MinTemperature = Convert.ToDouble(row["MinimumTemperature"]);
                gclass99.MaxTemperature = Convert.ToDouble(row["MaximumTemperature"]);
                gclass99.MinOxygen = Convert.ToDouble(row["MinimumOxygen"]);
                gclass99.IsDesertTerrain = Convert.ToBoolean(row["DesertTerrain"]);
                gclass99.IsJungleTerrain = Convert.ToBoolean(row["JungleTerrain"]);
                gclass99.Name = row["Name"].ToString();
                gclass99.Abbreviation = row["Abbreviation"].ToString();
                this.DominantTerrainTypeDictionary.Add(gclass99.DominantTerrainType, gclass99);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1154);
        }
    }
    
    // Guess: LoadGroundUnitCapabilitiesFromDB; creates GClass98 (GroundUnitCapabilityDefinition)
    public void LoadGroundUnitCapabilitiesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_GroundUnitCapability").Rows)
            {
                GroundUnitCapabilityDefinition gclass98 = new GroundUnitCapabilityDefinition();
                int int32 = Convert.ToInt32(row["TechSystemID"]);
                if (this.TechDataDictionary.ContainsKey(int32))
                {
                    gclass98.TechData = this.TechDataDictionary[int32];
                    gclass98.GroundUnitCapability = (GroundUnitCapability)Convert.ToInt32(row["CapabilityID"]);
                    gclass98.CostMultiplier = Convert.ToDecimal(row["CostMultiplier"]);
                    gclass98.HPEnhancement = Convert.ToDecimal(row["HPEnhancement"]);
                    gclass98.bIsForInfantryOnly = Convert.ToBoolean(row["InfantryOnly"]);
                    gclass98.CapabilityName = row["CapabilityName"].ToString();
                    this.GroundUnitCapabilityDictionary.Add(gclass98.GroundUnitCapability, gclass98);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1155);
        }
    }
    
    // Guess: LoadGroundComponentTypesFromDB; creates GClass100 (GroundComponentTypeDefinition)
    public void LoadGroundComponentTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_GroundComponentType").Rows)
            {
                GroundComponentTypeDefinition gclass100 = new GroundComponentTypeDefinition();
                int int32 = Convert.ToInt32(row["TechSystemID"]);
                if (this.TechDataDictionary.ContainsKey(int32))
                {
                    gclass100.TechData = this.TechDataDictionary[int32];
                    gclass100.GroundUnitComponentType = (GroundUnitComponent)Convert.ToInt32(row["ComponentTypeID"]);
                    gclass100.Shots = Convert.ToInt32(row["Shots"]);
                    gclass100.STO = Convert.ToInt32(row["STO"]);
                    gclass100.HQMaxSize = Convert.ToInt32(row["HQMaxSize"]);
                    gclass100.FireDirection = Convert.ToInt32(row["FireDirection"]);
                    gclass100.LogisticsPoint = Convert.ToInt32(row["LogisticsPoints"]);
                    gclass100.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                    gclass100.BombardmentWeaponClass = (BombardmentWeaponClass)Convert.ToInt32(row["BombardmentWeapon"]);
                    gclass100.AAWeaponClass = (AntiAirWeaponClass)Convert.ToInt32(row["AAWeapon"]);
                    gclass100.Size = Convert.ToDecimal(row["Size"]);
                    gclass100.Penetration = Convert.ToDecimal(row["Penetration"]);
                    gclass100.Damage = Convert.ToDecimal(row["Damage"]);
                    gclass100.Construction = Convert.ToDecimal(row["Construction"]);
                    gclass100.GeoSurvey = Convert.ToDecimal(row["GeoSurvey"]);
                    gclass100.SupplyUse = Convert.ToDecimal(row["SupplyUse"]);
                    gclass100.Xenoarchaeology = Convert.ToDecimal(row["Xenoarchaeology"]);
                    gclass100.Decontamination = Convert.ToDecimal(row["Decontamination"]);
                    gclass100.Static = Convert.ToBoolean(row["Static"]);
                    gclass100.Infantry = Convert.ToBoolean(row["Infantry"]);
                    gclass100.LightVehicle = Convert.ToBoolean(row["LightVehicle"]);
                    gclass100.MediumVehicle = Convert.ToBoolean(row["Vehicle"]);
                    gclass100.HeavyVehicle = Convert.ToBoolean(row["HeavyVehicle"]);
                    gclass100.SuperHeavyVehicle = Convert.ToBoolean(row["SuperHeavyVehicle"]);
                    gclass100.UltraHeavyVehicle = Convert.ToBoolean(row["UltraHeavyVehicle"]);
                    gclass100.GroundWeapon = Convert.ToBoolean(row["GroundWeapon"]);
                    gclass100.GroundUnitComponentName = row["ComponentName"].ToString();
                    gclass100.Abbreviation = row["Abbreviation"].ToString();
                    this.GroundUnitComponentDataDictionary.Add(gclass100.GroundUnitComponentType, gclass100);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1156);
        }
    }
    
    // Guess: LoadMiningNamesFromDB; creates string entries for list_16
    public void LoadMiningNamesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_MiningNames").Rows)
                this.MiningNameList.Add(row["MiningName"].ToString());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1165);
        }
    }
    
    // Guess: LoadMoveActionsFromDB; creates GClass133 (MoveActionDefinition)
    public void LoadMoveActionsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_MoveAction").Rows)
            {
                MoveActionDefinition gclass133 = new MoveActionDefinition();
                gclass133.MoveActionType = (MoveActionType)Convert.ToInt32(row["MoveActionID"]);
                gclass133.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass133.MoveRequirementID = (GEnum124)Convert.ToInt32(row["MoveRequirementID"]);
                gclass133.DestinationItemType = (DestinationItemType)Convert.ToInt32(row["DestinationItemType"]);
                gclass133.TransitOrder = Convert.ToBoolean(row["TransitOrder"]);
                gclass133.NoOrderChange = Convert.ToBoolean(row["NoOrderChange"]);
                gclass133.DesignModeOnly = Convert.ToBoolean(row["DesignModeOnly"]);
                gclass133.MinQuantity = Convert.ToBoolean(row["MinQuantity"]);
                gclass133.NoGasGiants = Convert.ToBoolean(row["NoGasGiants"]);
                gclass133.ReserveLevel = Convert.ToBoolean(row["ReserveLevel"]);
                gclass133.WarpPoint = Convert.ToBoolean(row["WarpPoint"]);
                gclass133.SystemBody = Convert.ToBoolean(row["SystemBody"]);
                gclass133.DeepSpaceLocation = Convert.ToBoolean(row["DeepSpaceLocation"]);
                gclass133.SurveyLocation = Convert.ToBoolean(row["SurveyLocation"]);
                gclass133.Fleet = Convert.ToBoolean(row["Fleet"]);
                gclass133.Waypoint = Convert.ToBoolean(row["Waypoint"]);
                gclass133.Contact = Convert.ToBoolean(row["Contact"]);
                gclass133.Lifepod = Convert.ToBoolean(row["Lifepod"]);
                gclass133.Wreck = Convert.ToBoolean(row["Wreck"]);
                gclass133.LagrangePoint = Convert.ToBoolean(row["LagrangePoint"]);
                gclass133.Wormhole = Convert.ToBoolean(row["Wormhole"]);
                gclass133.LoadGroundUnit = Convert.ToBoolean(row["LoadGroundUnit"]);
                gclass133.SpecifyQuanitity = Convert.ToBoolean(row["SpecifyQuanitity"]);
                gclass133.MinDistanceOption = Convert.ToBoolean(row["MinDistanceOption"]);
                gclass133.StationaryAction = Convert.ToBoolean(row["StationaryAction"]);
                gclass133.Description = row["Description"].ToString();
                this.MoveActionDictionary.Add(gclass133.MoveActionType, gclass133);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1175);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1172);
        }
    }
    
    // Guess: LoadAtmosphericGasesFromDB; creates GClass223 (AtmosphericGasDefinition)
    public void LoadAtmosphericGasesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_Gases").Rows)
            {
                AtmosphericGasDefinition gclass223 = new AtmosphericGasDefinition();
                gclass223.AtmosphericGas = (AtmosphericGas)Convert.ToInt32(row["GasID"]);
                gclass223.Dangerous = Convert.ToInt32(row["Dangerous"]);
                gclass223.DangerousLevel = Convert.ToInt32(row["DangerousLevel"]);
                gclass223.BoilingPoint = Convert.ToInt32(row["BoilingPoint"]);
                gclass223.GHGas = Convert.ToBoolean(row["GHGas"]);
                gclass223.AntiGHGas = Convert.ToBoolean(row["AntiGHGas"]);
                gclass223.Name = row["Name"].ToString();
                gclass223.Symbol = row["Symbol"].ToString();
                this.AtmosphericGasDictionary.Add(gclass223.AtmosphericGas, gclass223);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1218);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1219);
        }
    }
    
    // Guess: LoadStandingOrdersFromDB; creates GClass136 (StandingOrderDefinition)
    public void LoadStandingOrdersFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_StandingOrders").Rows)
            {
                StandingOrderDefinition gclass136 = new StandingOrderDefinition();
                gclass136.auroraStandingOrder_0 = (AuroraStandingOrder)Convert.ToInt32(row["OrderID"]);
                gclass136.auroraStandingOrderGroup_0 = (AuroraStandingOrderGroup)Convert.ToInt32(row["OrderGroupID"]);
                gclass136.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass136.ForNPROnly = Convert.ToBoolean(row["NPROnly"]);
                gclass136.Standing = Convert.ToBoolean(row["Standing"]);
                gclass136.Conditional = Convert.ToBoolean(row["Conditional"]);
                gclass136.Description = row["Description"].ToString();
                gclass136.SystemCheck = row["SystemCheck"].ToString();
                this.StandingOrderDictionary.Add(gclass136.auroraStandingOrder_0, gclass136);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1254);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1255);
        }
    }
    
    // Guess: LoadFleetConditionsFromDB; creates GClass137 (FleetConditionDefinition)
    public void LoadFleetConditionsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_Condition").Rows)
            {
                FleetConditionDefinition gclass137 = new FleetConditionDefinition();
                gclass137.FleetCondition = (AuroraFleetCondition)Convert.ToInt32(row["ConditionID"]);
                gclass137.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass137.Description = row["Description"].ToString();
                this.FleetConditionDictionary.Add(gclass137.FleetCondition, gclass137);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1256);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1257);
        }
    }
    
    
    // Guess: LoadNamingThemeTypesFromDB; creates NamingTheme
    public void LoadNamingThemeTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_NamingThemeTypes").Rows)
            {
                NamingTheme gclass140 = new NamingTheme();
                gclass140.ThemeID = Convert.ToInt32(row["ThemeID"]);
                gclass140.RaceNameEligible = Convert.ToBoolean(row["RaceNameEligible"]);
                gclass140.Description = row["Description"].ToString();
                this.ThemeDictionary.Add(gclass140.ThemeID, gclass140);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1272);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1273);
        }
    }

    // Guess: LoadNamingThemeNamesFromDB; populates NamingTheme.NameList
    public void LoadNamingThemeNamesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_NamingTheme").Rows)
            {
                int int32 = Convert.ToInt32(row["NameThemeID"]);
                string str = row["Name"].ToString();
                if (this.ThemeDictionary.ContainsKey(int32))
                    this.ThemeDictionary[int32].NameList.Add(str);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1274);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1275);
        }
    }
    
    // Guess: LoadPlanetaryInstallationsFromDB; creates GClass157 (PlanetaryInstallationType)
    public void LoadPlanetaryInstallationsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_PlanetaryInstallation").Rows)
            {
                PlanetaryInstallationType gclass157 = new PlanetaryInstallationType();
                int int32 = Convert.ToInt32(row["RequiredTechID"]);
                if (this.TechDataDictionary.ContainsKey(int32))
                    gclass157.TechData = this.TechDataDictionary[int32];
                gclass157.InstallationType =
                    (AuroraInstallationType)Convert.ToInt32(row["PlanetaryInstallationID"]);
                gclass157.CargoPoints = Convert.ToInt32(row["CargoPoints"]);
                gclass157.TargetSize = Convert.ToInt32(row["TargetSize"]);
                gclass157.ConversionTo = (AuroraInstallationType)Convert.ToInt32(row["ConversionTo"]);
                gclass157.ConversionFrom = (AuroraInstallationType)Convert.ToInt32(row["ConversionFrom"]);
                gclass157.DisplayOrder = Convert.ToDecimal(row["DisplayOrder"]);
                gclass157.Cost = Convert.ToDecimal(row["Cost"]);
                gclass157.Workers = Convert.ToDecimal(row["Workers"]);
                gclass157.ThermalSignature = Convert.ToDecimal(row["ThermalSignature"]);
                gclass157.EMsignature = Convert.ToDecimal(row["EMsignature"]);
                gclass157.ConstructionValue = Convert.ToDecimal(row["ConstructionValue"]);
                gclass157.OrdnanceProductionValue = Convert.ToDecimal(row["OrdnanceProductionValue"]);
                gclass157.FighterProductionValue = Convert.ToDecimal(row["FighterProductionValue"]);
                gclass157.RefineryProductionValue = Convert.ToDecimal(row["RefineryProductionValue"]);
                gclass157.ResearchValue = Convert.ToDecimal(row["ResearchValue"]);
                gclass157.TerraformValue = Convert.ToDecimal(row["TerraformValue"]);
                gclass157.MaintenanceValue = Convert.ToDecimal(row["MaintenanceValue"]);
                gclass157.MiningProductionValue = Convert.ToDecimal(row["MiningProductionValue"]);
                gclass157.InfrastructureValue = Convert.ToDecimal(row["InfrastructureValue"]);
                gclass157.SensorValue = Convert.ToDecimal(row["SensorValue"]);
                gclass157.GroundTrainingValue = Convert.ToDecimal(row["GroundTrainingValue"]);
                gclass157.AcademyValue = Convert.ToDecimal(row["AcademyValue"]);
                gclass157.SectorCommandValue = Convert.ToDecimal(row["SectorCommandValue"]);
                gclass157.NavalHeadquartersValue = Convert.ToDecimal(row["NavalHeadquartersValue"]);
                gclass157.MassDriverValue = Convert.ToDecimal(row["MassDriverValue"]);
                gclass157.FinancialProductionValue = Convert.ToDecimal(row["FinancialProductionValue"]);
                gclass157.CargoShuttleValue = Convert.ToDecimal(row["CargoShuttleValue"]);
                gclass157.GeneticModificationValue = Convert.ToDecimal(row["GeneticModificationValue"]);
                gclass157.MassRefuelling = Convert.ToDecimal(row["MassRefuelling"]);
                gclass157.MassOrdnanceTransfer = Convert.ToDecimal(row["MassOrdnanceTransfer"]);
                gclass157.SwarmUse = Convert.ToBoolean(row["SwarmUse"]);
                gclass157.NoBuild = Convert.ToBoolean(row["NoBuild"]);
                gclass157.CivMove = Convert.ToBoolean(row["CivMove"]);
                gclass157.CivilianInstallation = Convert.ToBoolean(row["CivilianInstallation"]);
                gclass157.MakesTaxableWorkers = Convert.ToBoolean(row["TaxableWorkers"]);
                gclass157.WorkerDesciption = row["WorkerDesciption"].ToString();
                gclass157.Name = row["Name"].ToString();
                gclass157.Abbreviation = row["Abbreviation"].ToString();
                gclass157.MineralCost = new AllMineralsValue(this);
                gclass157.MineralCost.Duranium = Convert.ToDecimal(row["Duranium"]);
                gclass157.MineralCost.Neutronium = Convert.ToDecimal(row["Neutronium"]);
                gclass157.MineralCost.Corbomite = Convert.ToDecimal(row["Corbomite"]);
                gclass157.MineralCost.Tritanium = Convert.ToDecimal(row["Tritanium"]);
                gclass157.MineralCost.Boronide = Convert.ToDecimal(row["Boronide"]);
                gclass157.MineralCost.Mercassium = Convert.ToDecimal(row["Mercassium"]);
                gclass157.MineralCost.Vendarite = Convert.ToDecimal(row["Vendarite"]);
                gclass157.MineralCost.Sorium = Convert.ToDecimal(row["Sorium"]);
                gclass157.MineralCost.Uridium = Convert.ToDecimal(row["Uridium"]);
                gclass157.MineralCost.Corundium = Convert.ToDecimal(row["Corundium"]);
                gclass157.MineralCost.Gallicite = Convert.ToDecimal(row["Gallicite"]);
                this.PlanetaryInstallationDictionary.Add(gclass157.InstallationType, gclass157);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1286);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1287);
        }
    }
    
    // Guess: LoadWealthUseTypesFromDB; creates GClass150 (WealthUseDefinition)
    public void LoadWealthUseTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_WealthUse").Rows)
            {
                WealthUsageData gclass150 = new WealthUsageData();
                gclass150.WealthUsage = (WealthUsage)Convert.ToInt32(row["WealthUseID"]);
                gclass150.DisplayOrder = Convert.ToDecimal(row["DisplayOrder"]);
                gclass150.Income = Convert.ToBoolean(row["Income"]);
                gclass150.Description = row["Description"].ToString();
                this.WealthUsageDictionary.Add(gclass150.WealthUsage, gclass150);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1292);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1293);
        }
    }

    // Guess: LoadMineralDataTypesFromDB; creates GClass154 (MineralDataTypeDefinition)
    public void LoadMineralDataTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_MineralDataType").Rows)
            {
                MineralUsageData gclass154 = new MineralUsageData();
                gclass154.MineralUsage = (MineralUsage)Convert.ToInt32(row["MineralDataType"]);
                gclass154.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass154.Income = Convert.ToBoolean(row["Income"]);
                gclass154.string_0 = row["Description"].ToString();
                this.MineralUsageDataDictionary.Add(gclass154.MineralUsage, gclass154);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3943);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3944);
        }
    }

    // Guess: LoadNavalAdminCommandTypesFromDB; creates GClass79 (NavalAdminCommandType)
    public void LoadNavalAdminCommandTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_NavalAdminCommandType").Rows)
            {
                NavalAdminCommandType gclass79 = new NavalAdminCommandType();
                gclass79.AdminCommandType = (AdminCommandType)Convert.ToInt32(row["CommandTypeID"]);
                gclass79.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass79.Radius = Convert.ToDecimal(row["Radius"]);
                gclass79.Survey = Convert.ToDecimal(row["Survey"]);
                gclass79.Logistics = Convert.ToDecimal(row["Logistics"]);
                gclass79.FleetTraining = Convert.ToDecimal(row["FleetTraining"]);
                gclass79.Industrial = Convert.ToDecimal(row["Industrial"]);
                gclass79.CrewTraining = Convert.ToDecimal(row["CrewTraining"]);
                gclass79.Engineering = Convert.ToDecimal(row["Engineering"]);
                gclass79.Reaction = Convert.ToDecimal(row["Reaction"]);
                gclass79.Tactical = Convert.ToDecimal(row["Tactical"]);
                gclass79.Description = row["Description"].ToString();
                gclass79.Abbrev = row["Abbrev"].ToString();
                this.AdminCommandTypeDictionary.Add(gclass79.AdminCommandType, gclass79);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1294);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1295);
        }
    }
    
    
    // Guess: LoadAssignmentTypeFiltersFromDB; creates GClass49 (AssignmentTypeFilter)
    public void LoadAssignmentTypeFiltersFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_AssignmentTypeFilter").Rows)
            {
                AssignmentTypeFilter gclass49 = new AssignmentTypeFilter();
                gclass49.AssignmentTypeID = Convert.ToInt32(row["AssignmentTypeID"]);
                gclass49.RankPriorityModifier = Convert.ToInt32(row["RankPriorityModifier"]);
                gclass49.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass49.LeaderType = (AuroraCommanderType)Convert.ToInt32(row["LeaderType"]);
                gclass49.ShipboardPosition = (AuroraCommandType)Convert.ToInt32(row["ShipCommandType"]);
                gclass49.IsForShip = Convert.ToBoolean(row["Ship"]);
                gclass49.IsForTeam = Convert.ToBoolean(row["Team"]);
                gclass49.IsForPopulation = Convert.ToBoolean(row["Population"]);
                gclass49.IsForSector = Convert.ToBoolean(row["Sector"]);
                gclass49.IsForGround = Convert.ToBoolean(row["Ground"]);
                gclass49.IsForFighter = Convert.ToBoolean(row["Fighter"]);
                gclass49.IsForArmedShip = Convert.ToBoolean(row["Armed"]);
                gclass49.IsForFreighters = Convert.ToBoolean(row["Freighters"]);
                gclass49.IsForNavalAdmin = Convert.ToBoolean(row["NavalAdmin"]);
                gclass49.IsForSurvey = Convert.ToBoolean(row["Survey"]);
                gclass49.IsForAcademy = Convert.ToBoolean(row["Academy"]);
                gclass49.Description = row["Description"].ToString();
                this.AssignmentTypeFilterDictionary.Add(gclass49.AssignmentTypeID, gclass49);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1304);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1305);
        }
    }

    // Guess: LoadCommanderBonusTypesFromDB; creates GClass50 (CommanderBonusType)
    public void LoadCommanderBonusTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_CommanderBonusType").Rows)
            {
                CommanderBonus gclass50 = new CommanderBonus();
                gclass50.CommanderBonusType = (CommanderBonusType)Convert.ToInt32(row["BonusID"]);
                gclass50.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass50.MaximumBonus = Convert.ToDecimal(row["MaximumBonus"]);
                gclass50.Percentage = Convert.ToBoolean(row["Percentage"]);
                gclass50.Naval = Convert.ToBoolean(row["Naval"]);
                gclass50.Ground = Convert.ToBoolean(row["Ground"]);
                gclass50.Civilian = Convert.ToBoolean(row["Civilian"]);
                gclass50.Scientist = Convert.ToBoolean(row["Scientist"]);
                gclass50.Description = row["Description"].ToString();
                gclass50.BonusAbbrev = row["BonusAbbrev"].ToString();
                this.CommanderBonusDictionary.Add(gclass50.CommanderBonusType, gclass50);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1306);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1307);
        }
    }

    // Guess: LoadAutomatedGroundTemplateDesignsFromDB; creates GClass23 (AutomatedGroundTemplateDesign)
    public void LoadAutomatedGroundTemplateDesignsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_AutomatedGroundTemplateDesign").Rows)
            {
                AutomatedGroundTemplateDesign gclass23 = new AutomatedGroundTemplateDesign();
                int int32 = Convert.ToInt32(row["RequiredTechID"]);
                if (this.TechDataDictionary.ContainsKey(int32))
                    gclass23.RequiredTechData = this.TechDataDictionary[int32];
                gclass23.GroundTemplateDesignType = (AutomatedGroundTemplateDesignType)Convert.ToInt32(row["AutomatedTemplateID"]);
                gclass23.GroundFormationFieldPosition =
                    (AuroraGroundFormationFieldPosition)Convert.ToInt32(row["FieldPosition"]);
                gclass23.PrimaryFunction = (GUAutoTemplatePrimaryFunction)Convert.ToInt32(row["PrimaryFunction"]);
                gclass23.SpecialNPR = (SpecialNPRIDs)Convert.ToInt32(row["SpecialNPR"]);
                gclass23.StandardProportion = Convert.ToInt32(row["StandardProportion"]);
                gclass23.Priority = Convert.ToInt32(row["Priority"]);
                gclass23.Name = row["Name"].ToString();
                gclass23.Abbreviation = row["Abbreviation"].ToString();
                this.AutoGroundTemplateDesignsDictionary.Add(gclass23.GroundTemplateDesignType, gclass23);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1310);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1311);
        }
    }

    // Guess: LoadAutomatedGroundTemplateElementsFromDB; creates GClass24 (AutomatedGroundTemplateElement)
    public void LoadAutomatedGroundTemplateElementsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_AutomatedGroundTemplateElements").Rows)
            {
                AutomatedGroundTemplateElement gclass24 = new AutomatedGroundTemplateElement();
                AutomatedGroundTemplateDesignType int32 = (AutomatedGroundTemplateDesignType)Convert.ToInt32(row["AutomatedTemplateID"]);
                if (this.AutoGroundTemplateDesignsDictionary.ContainsKey(int32))
                {
                    gclass24.TemplateDesign = this.AutoGroundTemplateDesignsDictionary[int32];
                    gclass24.GroundUnitClass = (GroundUnitClassType)Convert.ToInt32(row["GUClassType"]);
                    gclass24.BaseAmount = Convert.ToInt32(row["BaseAmount"]);
                    gclass24.DiceSize = Convert.ToInt32(row["DiceSize"]);
                    gclass24.DiceAmount = Convert.ToInt32(row["DiceAmount"]);
                    gclass24.Multiple = Convert.ToInt32(row["Multiple"]);
                    gclass24.PrimaryClass = Convert.ToBoolean(row["PrimaryClass"]);
                    gclass24.HQ = Convert.ToBoolean(row["HQ"]);
                    gclass24.Logistics = Convert.ToBoolean(row["Logistics"]);
                    gclass24.Construction = Convert.ToBoolean(row["Construction"]);
                    gclass24.string_0 = row["ClassName"].ToString();
                    this.AutoGroundTemplateDesignsDictionary[int32].list_0.Add(gclass24);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1312);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1313);
        }
    }
    
    // Guess: LoadPopulationPoliticalStatusesFromDB; creates GClass160 (PopulationPoliticalStatus)
    public void LoadPopulationPoliticalStatusesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_PopPoliticalStatus").Rows)
            {
                PopulationPoliticalStatus gclass160 = new PopulationPoliticalStatus();
                gclass160.PoliticalStatusType = (PopPoliticalStatusType)Convert.ToInt32(row["StatusID"]);
                gclass160.SPRequired = Convert.ToInt32(row["SPRequired"]);
                gclass160.NextStatusType = (PopPoliticalStatusType)Convert.ToInt32(row["NextStatusID"]);
                gclass160.ProductionModifier = Convert.ToDecimal(row["ProductionMod"]);
                gclass160.WealthModifier = Convert.ToDecimal(row["WealthMod"]);
                gclass160.OccupationForceModifier = Convert.ToDecimal(row["OccupationForceMod"]);
                gclass160.ProtectionRequired = Convert.ToDecimal(row["ProtectionRequired"]);
                gclass160.ServiceSector = Convert.ToDecimal(row["ServiceSector"]);
                gclass160.StatusName = row["StatusName"].ToString();
                this.PopulationPoliticalStatusDictionary.Add(gclass160.PoliticalStatusType, gclass160);
            }

            foreach (PopulationPoliticalStatus gclass160 in this.PopulationPoliticalStatusDictionary.Values)
            {
                if (this.PopulationPoliticalStatusDictionary.ContainsKey(gclass160.NextStatusType))
                    gclass160.NextStatus = this.PopulationPoliticalStatusDictionary[gclass160.NextStatusType];
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1276);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1277);
        }
    }
    
    // Guess: LoadRuinDefinitionsFromDB; creates GClass174 (RuinDefinition)
    public void LoadRuinDefinitionsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_Ruin").Rows)
            {
                RuinDefinition gclass174 = new RuinDefinition(this);
                gclass174.RuinID = Convert.ToInt32(row["RuinID"]);
                gclass174.MaxChance = Convert.ToInt32(row["MaxChance"]);
                gclass174.NoDefenders = Convert.ToInt32(row["NoDefenders"]);
                gclass174.FactoriesBase = Convert.ToInt32(row["FactoriesBase"]);
                gclass174.FactoriesRandom = Convert.ToInt32(row["FactoriesRandom"]);
                gclass174.DefenceBases = Convert.ToInt32(row["DefenceBases"]);
                gclass174.OffenceBases = Convert.ToInt32(row["OffenceBases"]);
                gclass174.Fleet = Convert.ToInt32(row["Fleet"]);
                gclass174.Squadron = Convert.ToInt32(row["Squadron"]);
                gclass174.Patrol = Convert.ToInt32(row["Patrol"]);
                gclass174.STO = Convert.ToInt32(row["STO"]);
                gclass174.Regiment = Convert.ToInt32(row["Regiment"]);
                gclass174.FixedDSTS = Convert.ToInt32(row["FixedDSTS"]);
                gclass174.RandomDSTS = Convert.ToInt32(row["RandomDSTS"]);
                gclass174.EmergenceModifier = Convert.ToDecimal(row["EmergenceModifier"]);
                gclass174.Description = row["Description"].ToString();
                this.RuinDefinitionDictionary.Add(gclass174.RuinID, gclass174);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1270);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1271);
        }
    }
    
        // Guess: LoadCommanderNameThemesFromDB; creates NameThemeData
        public void LoadCommanderNameThemesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_CommanderNameTheme").Rows)
            {
                CommanderNameThemeData gclass58 = new CommanderNameThemeData();
                gclass58.NameThemeID = Convert.ToInt32(row["NameThemeID"]);
                gclass58.NameOne = Convert.ToInt32(row["NameOne"]);
                gclass58.NameTwo = Convert.ToInt32(row["NameTwo"]);
                gclass58.NameThree = Convert.ToInt32(row["NameThree"]);
                gclass58.SpecialRule = Convert.ToInt32(row["SpecialRule"]);
                gclass58.NameOneAdditionChance = Convert.ToInt32(row["NameOneAdditionChance"]);
                gclass58.Description = row["Description"].ToString();
                gclass58.NameOneAddition = row["NameOneAddition"].ToString();
                this.NameThemeDictionary.Add(gclass58.NameThemeID, gclass58);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1320);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1321);
        }
    }

    // Guess: LoadTraitGroupsAndTraitsFromDB; creates GClass48 (TraitGroup) and populates dictionary_60 (Trait names)
    public void LoadTraitGroupsAndTraitsFromDB()
    {
        try
        {
            SQLiteDatabaseC1181 sqLiteDatabaseC1181 = new SQLiteDatabaseC1181();
            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery("SELECT * FROM DIM_TraitGroup").Rows)
            {
                TraitGroup gclass48 = new TraitGroup();
                gclass48.TraitGroupID = Convert.ToInt32(row["TraitGroupID"]);
                gclass48.Opposite1ID = Convert.ToInt32(row["Opposite1"]);
                gclass48.OppositeID2 = Convert.ToInt32(row["Opposite2"]);
                gclass48.Description = row["Description"].ToString();
                this.TraitGroupDictionary.Add(gclass48.TraitGroupID, gclass48);
            }

            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery("SELECT * FROM DIM_TraitsList").Rows)
            {
                int traitId = Convert.ToInt32(row["TraitID"]);
                int groupId = Convert.ToInt32(row["GroupID"]);
                if (this.TraitGroupDictionary.ContainsKey(groupId))
                {
                    string str = row["Name"].ToString();
                    this.TraitGroupDictionary[groupId].TraitList.Add(traitId);
                    this.TraitNameDictionary.Add(traitId, str);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1322);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1323);
        }
    }

    // Guess: LoadShipyardCompanySuffixesFromDB; populates list_17 with suffix strings
    public void LoadShipyardCompanySuffixesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_ShipyardCompanies").Rows)
                this.ShipyardCompanySuffixList.Add(row["Suffix"].ToString());
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1324);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1325);
        }
    }

    // Guess: LoadCommanderNamesFromDB; creates GClass57 entries with name and gender flags
    public void LoadCommanderNamesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_CommanderNames").Rows)
            {
                CommanderNameDefinition gclass57 = new CommanderNameDefinition();
                int int32 = Convert.ToInt32(row["NameThemeID"]);
                if (this.NameThemeDictionary.ContainsKey(int32))
                {
                    gclass57.CommanderNameTheme = this.NameThemeDictionary[int32];
                    gclass57.AllowedForFirstName = Convert.ToBoolean(row["FirstName"]);
                    gclass57.AllowedForLastName = Convert.ToBoolean(row["FamilyName"]);
                    gclass57.AllowedForThirdName = Convert.ToBoolean(row["ThirdName"]);
                    gclass57.AllowedForFemale = Convert.ToBoolean(row["Female"]);
                    gclass57.Name = row["Name"].ToString().Trim();
                    this.CommanderNameList.Add(gclass57);
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1326);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1327);
        }
    }
    
    // Guess: LoadRankThemesFromDB; creates GClass60 (Rank theme) and GClass61 (rank entries)
    public void LoadRankThemesFromDB()
    {
        try
        {
            SQLiteDatabaseC1181 sqLiteDatabaseC1181 = new SQLiteDatabaseC1181();
            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery("SELECT * FROM DIM_RankThemeTypes").Rows)
            {
                RankTheme gclass60 = new RankTheme();
                gclass60.ThemeID = Convert.ToInt32(row["ThemeID"]);
                gclass60.ThemeName = row["ThemeName"].ToString();
                gclass60.RankThemeEntries = new List<RankThemeEntry>();
                this.RankThemeDictionary.Add(gclass60.ThemeID, gclass60);
            }

            int num1 = 1;
            int num2 = 1;
            int num3 = 0;
            foreach (DataRow row in (InternalDataCollectionBase)sqLiteDatabaseC1181
                         .ExecuteQuery("SELECT * FROM DIM_RankThemes ORDER BY ThemeID, ThemeRankID").Rows)
            {
                int int32 = Convert.ToInt32(row["ThemeID"]);
                if (this.RankThemeDictionary.ContainsKey(int32))
                {
                    if (int32 != num3)
                    {
                        num1 = 1;
                        num2 = 1;
                        num3 = int32;
                    }

                    string str1 = row["RankName"].ToString();
                    if (str1 != "")
                    {
                        RankThemeEntry gclass61 = new RankThemeEntry()
                        {
                            CommanderType = AuroraCommanderType.Naval,
                            RankName = str1,
                            RankNum = num1
                        };
                        gclass61.CommanderType = AuroraCommanderType.Naval;
                        gclass61.RankAbbreviation = row["NavalRankAbbrev"].ToString();
                        if (gclass61.RankAbbreviation == "")
                            gclass61.RankAbbreviation = "R" + num1.ToString();
                        this.RankThemeDictionary[int32].RankThemeEntries.Add(gclass61);
                        ++num1;
                    }

                    string str2 = row["GFRankName"].ToString();
                    if (str2 != "")
                    {
                        RankThemeEntry gclass61 = new RankThemeEntry()
                        {
                            CommanderType = AuroraCommanderType.GroundForce,
                            RankName = str2,
                            RankNum = num2
                        };
                        gclass61.CommanderType = AuroraCommanderType.GroundForce;
                        gclass61.RankAbbreviation = row["GroundRankAbbrev"].ToString();
                        if (gclass61.RankAbbreviation == "")
                            gclass61.RankAbbreviation = "R" + num2.ToString();
                        this.RankThemeDictionary[int32].RankThemeEntries.Add(gclass61);
                        ++num2;
                    }
                }
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1330);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1331);
        }
    }
    
    // Guess: LoadComponentTypesFromDB; creates GClass231 (ComponentTypeDefinition)
    public void LoadComponentTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_ComponentType").Rows)
            {
                ComponentTypeData componentType = new ComponentTypeData();
                ClassSummaryTypeID int32 = (ClassSummaryTypeID)Convert.ToInt32(row["ClassSummaryTypeID"]);
                if (this.ClassSummaryTypeDictionary.ContainsKey(int32))
                    componentType.ClassSummaryType = this.ClassSummaryTypeDictionary[int32];
                componentType.ComponentTypeID = (AuroraComponentType)Convert.ToInt32(row["ComponentTypeID"]);
                componentType.ClassDisplayOrder = Convert.ToInt32(row["ClassDisplayOrder"]);
                componentType.RepairPriority = Convert.ToInt32(row["RepairPriority"]);
                componentType.EmptySpaceModifier = Convert.ToDecimal(row["EmptySpaceModifier"]);
                componentType.bShowInClassDisplay = Convert.ToBoolean(row["ShowInClassDisplay"]);
                componentType.bSingleSystem = Convert.ToBoolean(row["SingleSystem"]);
                componentType.bObsoleteAllowed = Convert.ToBoolean(row["ObsoleteAllowed"]);
                componentType.TypeDescription = row["TypeDescription"].ToString();
                componentType.RatingDescription = row["RatingDescription"].ToString();
                this.ComponentTypeDictionary.Add(componentType.ComponentTypeID, componentType);
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

    // Guess: LoadClassSummaryTypesFromDB; creates GClass232 (ClassSummaryType)
    public void LoadClassSummaryTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_ClassSummaryType").Rows)
            {
                ClassSummaryType gclass232 = new ClassSummaryType();
                gclass232.genum83_0 = (ClassSummaryTypeID)Convert.ToInt32(row["ClassSummaryTypeID"]);
                gclass232.string_0 = row["Description"].ToString();
                this.ClassSummaryTypeDictionary.Add(gclass232.genum83_0, gclass232);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 3895);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3896);
        }
    }
    
    // Guess: LoadMedalConditionsFromDB; creates GClass43 (MedalCondition)
    public void LoadMedalConditionsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_MedalCondition").Rows)
            {
                MedalCondition gclass43 = new MedalCondition();
                gclass43.MedalConditionID = Convert.ToInt32(row["MedalConditionID"]);
                gclass43.AmountRequired = Convert.ToInt32(row["AmountRequired"]);
                gclass43.DisplayOrder = Convert.ToInt32(row["DisplayOrder"]);
                gclass43.MeasurementType = (AuroraMeasurementType)Convert.ToInt32(row["MeasurementType"]);
                gclass43.Description = row["Description"].ToString();
                this.MedalConditionDictionary.Add(gclass43.MedalConditionID, gclass43);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1244);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1245);
        }
    }
    
    // Guess: LoadSystemAgesFromDB; creates GClass196 (SystemAge)
    public void LoadSystemAgesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_SystemAge").Rows)
            {
                SystemAge gclass196 = new SystemAge();
                gclass196.SystemAgeID = (SystemAgeID)Convert.ToInt32(row["AgeID"]);
                gclass196.TotalLife = Convert.ToDouble(row["TotalLife"]);
                gclass196.SpectralClass = row["SpectralClass"].ToString();
                double num1 = Convert.ToDouble(row["Lum1"]);
                gclass196.LuminosityDic.Add(1, num1);
                double num2 = Convert.ToDouble(row["Lum2"]);
                gclass196.LuminosityDic.Add(2, num2);
                double num3 = Convert.ToDouble(row["Lum3"]);
                gclass196.LuminosityDic.Add(3, num3);
                double num4 = Convert.ToDouble(row["Lum4"]);
                gclass196.LuminosityDic.Add(4, num4);
                double num5 = Convert.ToDouble(row["Lum5"]);
                gclass196.LuminosityDic.Add(5, num5);
                double num6 = Convert.ToDouble(row["Lum6"]);
                gclass196.LuminosityDic.Add(6, num6);
                double num7 = Convert.ToDouble(row["Lum7"]);
                gclass196.LuminosityDic.Add(7, num7);
                double num8 = Convert.ToDouble(row["Lum8"]);
                gclass196.LuminosityDic.Add(8, num8);
                double num9 = Convert.ToDouble(row["Lum9"]);
                gclass196.LuminosityDic.Add(9, num9);
                double num10 = Convert.ToDouble(row["Lum10"]);
                gclass196.LuminosityDic.Add(10, num10);
                double num11 = Convert.ToDouble(row["Age1"]);
                gclass196.AgeDic.Add(1, num11);
                double num12 = Convert.ToDouble(row["Age2"]);
                gclass196.AgeDic.Add(2, num12);
                double num13 = Convert.ToDouble(row["Age3"]);
                gclass196.AgeDic.Add(3, num13);
                double num14 = Convert.ToDouble(row["Age4"]);
                gclass196.AgeDic.Add(4, num14);
                double num15 = Convert.ToDouble(row["Age5"]);
                gclass196.AgeDic.Add(5, num15);
                double num16 = Convert.ToDouble(row["Age6"]);
                gclass196.AgeDic.Add(6, num16);
                double num17 = Convert.ToDouble(row["Age7"]);
                gclass196.AgeDic.Add(7, num17);
                double num18 = Convert.ToDouble(row["Age8"]);
                gclass196.AgeDic.Add(8, num18);
                double num19 = Convert.ToDouble(row["Age9"]);
                gclass196.AgeDic.Add(9, num19);
                double num20 = Convert.ToDouble(row["Age10"]);
                gclass196.AgeDic.Add(10, num20);
                this.SystemAgeDictionary.Add(gclass196.SystemAgeID, gclass196);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1375);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1376);
        }
    }

    // Guess: LoadSystemAbundancesFromDB; creates GClass199 (SystemAbundance)
    public void LoadSystemAbundancesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_SystemAbundance").Rows)
            {
                SystemAbundance gclass199 = new SystemAbundance();
                gclass199.AbundanceID = Convert.ToInt32(row["AbundanceID"]);
                gclass199.MaxChance = Convert.ToInt32(row["MaxChance"]);
                gclass199.Modifier = Convert.ToInt32(row["Modifier"]);
                gclass199.Description = row["Description"].ToString();
                this.SystemAbundanceDictionary.Add(gclass199.AbundanceID, gclass199);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1377);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1378);
        }
    }

    // Guess: LoadPresetAtmospheresFromDB; creates GClass225 entries in list_18
    public void LoadPresetAtmospheresFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_SetAtmosphere").Rows)
                this.AtmosphericPresetList.Add(new AtmosphericPreset()
                {
                    TemperatureBand = Convert.ToInt32(row["TempBand"]),
                    MaxChance = Convert.ToInt32(row["MaxChance"]),
                    Gas1 = (AtmosphericGas)Convert.ToInt32(row["Gas1"]),
                    Gas2 = (AtmosphericGas)Convert.ToInt32(row["Gas2"]),
                    Gas3 = (AtmosphericGas)Convert.ToInt32(row["Gas3"]),
                    Description = row["Description"].ToString()
                });
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1379);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1380);
        }
    }

    // Guess: LoadEmpireTitlesFromDB; creates GClass141 entries in list_19
    public void LoadEmpireTitlesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_EmpireTitles").Rows)
                this.EmpireTitleNameList.Add(new GClass141()
                {
                    MaxChance = Convert.ToInt32(row["MaxChance"]),
                    IsPrefix = Convert.ToInt32(row["Prefix"]),
                    IsSuffix = Convert.ToInt32(row["Suffix"]),
                    Title = row["Title"].ToString()
                });
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1381);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1382);
        }
    }

    // Guess: LoadLineNamesFromDB; populates list_13 with line names
    public void LoadLineNamesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_LineNames").Rows)
                this.LineNameList.Add(row["LineNames"].ToString());
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1383);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1384);
        }
    }

    // Guess: LoadAutomatedClassDesignsFromDB; creates GClass14 (AutomatedClassDesign)
    public void LoadAutomatedClassDesignsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_AutomatedClassDesign").Rows)
            {
                AutomatedClassDesign gclass14 = new AutomatedClassDesign(this);
                int int32_1 = Convert.ToInt32(row["KeyTechA"]);
                if (int32_1 > 0 && this.TechDataDictionary.ContainsKey(int32_1))
                    gclass14.KeyTechDataA = this.TechDataDictionary[int32_1];
                int int32_2 = Convert.ToInt32(row["KeyTechB"]);
                if (int32_2 > 0 && this.TechDataDictionary.ContainsKey(int32_2))
                    gclass14.KeyTechDataB = this.TechDataDictionary[int32_2];
                int int32_3 = Convert.ToInt32(row["HullID"]);
                if (int32_3 > 0 && this.ShipHullDictionary.ContainsKey(int32_3))
                    gclass14.ShipHull = this.ShipHullDictionary[int32_3];
                gclass14.AutomatedClassDesignTypeID = (AutomatedClassDesignType)Convert.ToInt32(row["AutomatedClassID"]);
                gclass14.JumpDriveDesignType = (JumpDriveDesignType)Convert.ToInt32(row["JumpDriveType"]);
                gclass14.StealthDesign = (StealthDesignType)Convert.ToInt32(row["StealthDesign"]);
                gclass14.RoleDesignType = (RoleDesignType)Convert.ToInt32(row["RoleType"]);
                gclass14.WeaponDesignType = (WeaponDesignType)Convert.ToInt32(row["WeaponType"]);
                gclass14.MissileDesignType = (MissileDesignType)Convert.ToInt32(row["MissileType"]);
                gclass14.HullClassDesignType = (HullClassDesignType)Convert.ToInt32(row["HullClass"]);
                gclass14.EngineType = (EngineDesignType)Convert.ToInt32(row["EngineType"]);
                gclass14.EngineNumberType = (NumberOfEngineDesignType)Convert.ToInt32(row["EngineNumberType"]);
                gclass14.EngineeringType = (EngineeringDesignType)Convert.ToInt32(row["EngineeringType"]);
                gclass14.PrimaryActive = (ActiveSensorDesignType)Convert.ToInt32(row["PrimaryActive"]);
                gclass14.SecondaryActive = (ActiveSensorDesignType)Convert.ToInt32(row["SecondaryActive"]);
                gclass14.MissileFireControl = (ActiveSensorDesignType)Convert.ToInt32(row["MissileFireControl"]);
                gclass14.BeamFireControl = (BFCDesignType)Convert.ToInt32(row["BeamFireControl"]);
                gclass14.SpinalLaser = (SpinalLaserDesignType)Convert.ToInt32(row["SpinalLaser"]);
                gclass14.HullSizeType = (HullSizeDesignType)Convert.ToInt32(row["HullSizeType"]);
                gclass14.SurrenderStatus = (SurrenderStatusDesignType)Convert.ToInt32(row["SurrenderStatus"]);
                gclass14.HullSize = Convert.ToInt32(row["HullSize"]);
                gclass14.EngineNumber = Convert.ToInt32(row["EngineNumber"]);
                gclass14.RandomEngineElement = Convert.ToInt32(row["RandomEngineElement"]);
                gclass14.Engineering = Convert.ToInt32(row["Engineering"]);
                gclass14.ArmourAdjustment = Convert.ToInt32(row["ArmourAdjustment"]);
                gclass14.Hangar = Convert.ToInt32(row["Hangar"]);
                gclass14.Shields = Convert.ToInt32(row["Shields"]);
                gclass14.NumFireControls = Convert.ToInt32(row["NumFireControls"]);
                gclass14.ThermalFixed = Convert.ToInt32(row["ThermalFixed"]);
                gclass14.ThermalRandom = Convert.ToInt32(row["ThermalRandom"]);
                gclass14.EMFixed = Convert.ToInt32(row["EMFixed"]);
                gclass14.EMRandom = Convert.ToInt32(row["EMRandom"]);
                gclass14.CargoHolds = Convert.ToInt32(row["CargoHolds"]);
                gclass14.CargoHandling = Convert.ToInt32(row["CargoHandling"]);
                gclass14.CryogenicModules = Convert.ToInt32(row["CryogenicModules"]);
                gclass14.LuxuryAccomodation = Convert.ToInt32(row["LuxuryAccomodation"]);
                gclass14.TroopTransportBase = Convert.ToInt32(row["TroopTransportBase"]);
                gclass14.TroopTransportRandom = Convert.ToInt32(row["TroopTransportRandom"]);
                gclass14.SalvageModules = Convert.ToInt32(row["SalvageModules"]);
                gclass14.JGCS = Convert.ToInt32(row["JGCS"]);
                gclass14.CIWSFixed = Convert.ToInt32(row["CIWSFixed"]);
                gclass14.CIWSRandom = Convert.ToInt32(row["CIWSRandom"]);
                gclass14.GeoSurvey = Convert.ToInt32(row["GeoSurvey"]);
                gclass14.GravSurvey = Convert.ToInt32(row["GravSurvey"]);
                gclass14.AuxiliaryControl = Convert.ToInt32(row["AuxiliaryControl"]);
                gclass14.ScienceDepartment = Convert.ToInt32(row["ScienceDepartment"]);
                gclass14.MainEngineering = Convert.ToInt32(row["MainEngineering"]);
                gclass14.CIC = Convert.ToInt32(row["CIC"]);
                gclass14.PrimaryFlightControl = Convert.ToInt32(row["PrimaryFlightControl"]);
                gclass14.FuelTransferSystem = Convert.ToInt32(row["FuelTransferSystem"]);
                gclass14.AssignAsCollier = Convert.ToInt32(row["AssignAsCollier"]);
                gclass14.AssignAsTanker = Convert.ToInt32(row["AssignAsTanker"]);
                gclass14.BioEnergyStorage = Convert.ToInt32(row["BioEnergyStorage"]);
                gclass14.HiveShipSizeClass = Convert.ToInt32(row["HiveShipSizeClass"]);
                gclass14.EnergyEscort = Convert.ToInt32(row["EnergyEscort"]);
                gclass14.DecoyLaunchers = Convert.ToInt32(row["DecoyLaunchers"]);
                gclass14.DeploymentDuration = Convert.ToDecimal(row["DeploymentDuration"]);
                gclass14.FuelDuration = Convert.ToDecimal(row["FuelDuration"]);
                gclass14.MaxFuelHullPercentage = Convert.ToDecimal(row["MaxFuelHullPercentage"]);
                gclass14.SecondaryWeaponProportion = Convert.ToDecimal(row["SecondaryWeaponProportion"]);
                gclass14.bool_0 = Convert.ToBoolean(row["AdditionalArmour"]);
                gclass14.bool_1 = Convert.ToBoolean(row["AlternativeWeapon"]);
                gclass14.bool_2 = Convert.ToBoolean(row["FillSpace"]);
                gclass14.bool_3 = Convert.ToBoolean(row["SwarmDesign"]);
                gclass14.string_0 = row["DesignID"].ToString();
                gclass14.string_1 = row["DefaultClassName"].ToString();
                gclass14.string_2 = row["ShippingLineName"].ToString();
                this.AutomatedClassDesignDictionary.Add(gclass14.AutomatedClassDesignTypeID, gclass14);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1385);
        }
    }

    // Guess: LoadResearchCategoriesFromDB; creates GClass169 (ResearchCategory)
    public void LoadResearchCategoriesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_ResearchCategories").Rows)
            {
                ResearchCategoryData gclass169 = new ResearchCategoryData();
                gclass169.ResearchCategoryType = (ResearchCategoryType)Convert.ToInt32(row["CategoryID"]);
                gclass169.CompanyNameType = Convert.ToInt32(row["CompanyNameType"]);
                gclass169.SourceTechType0 = (TechType)Convert.ToInt32(row["SourceTechType0"]);
                gclass169.SourceTechType1 = (TechType)Convert.ToInt32(row["SourceTechType1"]);
                gclass169.SourceTechType2 = (TechType)Convert.ToInt32(row["SourceTechType2"]);
                gclass169.SourceTechType3 = (TechType)Convert.ToInt32(row["SourceTechType3"]);
                gclass169.SourceTechType4 = (TechType)Convert.ToInt32(row["SourceTechType4"]);
                gclass169.SourceTechType5 = (TechType)Convert.ToInt32(row["SourceTechType5"]);
                gclass169.SourceTechType6 = (TechType)Convert.ToInt32(row["SourceTechType6"]);
                gclass169.SourceTechType7 = (TechType)Convert.ToInt32(row["SourceTechType7"]);
                gclass169.Sort0 = Convert.ToInt32(row["Sort0"]);
                gclass169.Sort1 = Convert.ToInt32(row["Sort1"]);
                gclass169.Sort2 = Convert.ToInt32(row["Sort2"]);
                gclass169.Sort3 = Convert.ToInt32(row["Sort3"]);
                gclass169.Sort4 = Convert.ToInt32(row["Sort4"]);
                gclass169.Sort5 = Convert.ToInt32(row["Sort5"]);
                gclass169.Sort6 = Convert.ToInt32(row["Sort6"]);
                gclass169.Sort7 = Convert.ToInt32(row["Sort7"]);
                gclass169.RadioNumber = Convert.ToInt32(row["RadioNumber"]);
                gclass169.bPlayerDefined = Convert.ToBoolean(row["PlayerDefined"]);
                gclass169.bComponents = Convert.ToBoolean(row["Components"]);
                gclass169.CategoryName = row["Name"].ToString();
                gclass169.NoteField = row["NoteField"].ToString();
                gclass169.RadioText = row["RadioText"].ToString();
                this.ResearchCategoryDictionary.Add(gclass169.ResearchCategoryType, gclass169);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1386);
        }
    }
    
    // Guess: LoadStellarTypesFromDB; creates StarType entries (StarType)
    public void LoadStellarTypesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_StellarType").Rows)
            {
                StellarType gclass217 = new StellarType(this)
                {
                    StellarTypeID = Convert.ToInt32(row["StellarTypeID"]),
                    SpectralNumber = Convert.ToInt32(row["SpectralNumber"]),
                    MaxChance = Convert.ToInt32(row["MaxChance"]),
                    BDMaxChance = Convert.ToInt32(row["BDMaxChance"]),
                    SizeID = Convert.ToInt32(row["SizeID"]),
                    Temperature = Convert.ToInt32(row["Temperature"]),
                    AgeRangeID = (SystemAgeID)Convert.ToInt32(row["AgeRangeID"]),
                    Red = Convert.ToInt32(row["Red"]),
                    Green = Convert.ToInt32(row["Green"]),
                    Blue = Convert.ToInt32(row["Blue"]),
                    ExtraJP = Convert.ToInt32(row["ExtraJP"]),
                    Luminosity = Convert.ToDouble(row["Luminosity"]),
                    Mass = Convert.ToDouble(row["Mass"]),
                    Radius = Convert.ToDouble(row["Radius"]),
                    bNotPS = Convert.ToBoolean(row["NotPS"]),
                    SizeText = row["SizeText"].ToString(),
                    SpectralClass = row["SpectralClass"].ToString()
                };
                gclass217.StellarDescription = $"{gclass217.SpectralClass}{gclass217.SpectralNumber.ToString()}-{gclass217.SizeText}";
                this.StarTypeDictionary.Add(gclass217.StellarTypeID, gclass217);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1186);
        }
    }
    
    // Guess: LoadCompanyNamesFromDB; creates GClass47 entries (company suffixes by type)
    public void LoadCompanyNamesFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_CompanyNames").Rows)
                this.CompanyNameList.Add(new CompanyNameData()
                {
                    ID = Convert.ToInt32(row["ID"]),
                    CompanyType = Convert.ToInt32(row["CompanyType"]),
                    CompanySuffix = row["CompanySuffix"].ToString()
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1164);
        }
    }
        
    // Guess: LoadResearchFieldsFromDB; creates GClass162 (ResearchField)
    public void LoadResearchFieldsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_ResearchField").Rows)
            {
                ResearchFieldData gclass162 = new ResearchFieldData();
                gclass162.ResearchFieldID = (AuroraResearchField)Convert.ToInt32(row["ResearchFieldID"]);
                gclass162.FieldName = row["FieldName"].ToString();
                gclass162.ShortName = row["ShortName"].ToString();
                gclass162.Abbreviation = row["Abbreviation"].ToString();
                gclass162.bDoNotDisplay = Convert.ToBoolean(row["DoNotDisplay"]);
                this.ResearchFieldDictionary.Add(gclass162.ResearchFieldID, gclass162);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1350);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1351);
        }
    }
    
    public void LoadDIMTechTypeFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("SELECT * FROM DIM_TechType").Rows)
            {
                TechTypeData gclass163 = new TechTypeData();
                AuroraResearchField researchFieldID = (AuroraResearchField)Convert.ToInt32(row["FieldID"]);
                if (this.ResearchFieldDictionary.ContainsKey(researchFieldID))
                    gclass163.ResearchField = this.ResearchFieldDictionary[researchFieldID];
                gclass163.TechType = (TechType)Convert.ToInt32(row["TechTypeID"]);
                gclass163.DistributeLowerTech = Convert.ToBoolean(row["DistributeLowerTech"]);
                gclass163.RuinTechType = Convert.ToBoolean(row["RuinTechType"]);
                gclass163.Description = row["Description"].ToString();
                this.TechTypeDataDictionary.Add(gclass163.TechType, gclass163);
            }
        }
        catch (DbException ex)
        {
            AuroraUtils.ShowExceptionPopupForDb(ex, 1352);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1353);
        }
    }
    
    public void LoadDIMDesignPhilosophyTechProgressionFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_DesignPhilosophyTechProgression").Rows)
            {
                DIMDesignPhilosophyTechProgression designPhilosophyTechProgression = new DIMDesignPhilosophyTechProgression();
                TechType int32 = (TechType)Convert.ToInt32(row["TechTypeID"]);
                if (this.TechTypeDataDictionary.ContainsKey(int32))
                    designPhilosophyTechProgression.gclass163_0 = this.TechTypeDataDictionary[int32];
                AuroraResearchField key = (AuroraResearchField)Convert.ToInt32(row["ResearchField"]);
                if (!this.ResearchFieldDictionary.ContainsKey(key))
                    key = AuroraResearchField.ConstructionProduction;
                designPhilosophyTechProgression.ResearchField = this.ResearchFieldDictionary[key];
                designPhilosophyTechProgression.TechProgressionCategoryID = (TechProgressionCategoryType)Convert.ToInt32(row["TechProgressionCategoryID"]);
                designPhilosophyTechProgression.ProgressionOrder = Convert.ToInt32(row["ProgressionOrder"]);
                designPhilosophyTechProgression.TechGroupID = (TechGroupType)Convert.ToInt32(row["TechGroupID"]);
                designPhilosophyTechProgression.bMandatory = Convert.ToBoolean(row["Mandatory"]);
                this.DesignPhilosophyTechProgressionsDictionary.Add(designPhilosophyTechProgression);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1137);
        }
    }

    public void LoadSolSystemBodiesFromDB(
        SystemData200 paramSystemData,
        Star197 paramStar,
        Decimal paramDecimalValue,
        bool paramBool)
    {
        try
        {
            int num1 = 0;
            double num2 = 0.0;
            DataTable dataTable =
                new SQLiteDatabaseC1181().ExecuteQuery(
                    "select * from DIM_SolSystemBodies order by ParentBodyType, BodyClass");
            List<SystemBodyData> source = new List<SystemBodyData>();
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class285 class285 = new GClass0.Class285();
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0 = new SystemBodyData(this);
                PlanetDominantTerrain int32 = (PlanetDominantTerrain)Convert.ToInt32(row["DominantTerrain"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.DominantTerrain = !this.DominantTerrainTypeDictionary.ContainsKey(int32)
                    ? this.DominantTerrainTypeDictionary[PlanetDominantTerrain.const_0]
                    : this.DominantTerrainTypeDictionary[int32];
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.SystemBodyID = this.method_26(GEnum0.const_4);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.SystemID = paramSystemData.SystemID;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.StarID = paramStar.StarID;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.PlanetNumber = Convert.ToInt32(row["PlanetNumber"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.OrbitalDistance = Convert.ToDouble(row["OrbitalDistance"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.OrbitNumber = Convert.ToInt32(row["OrbitNumber"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.BodyClass = (PlanetBodyClass)Convert.ToInt32(row["BodyClass"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Radius = Convert.ToInt32(row["Radius"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.BodyTypeId = (AuroraSystemBodyType)Convert.ToInt32(row["BodyTypeID"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Tilt = Convert.ToInt32(row["Tilt"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.TectonicActivity = (AuroraTectonics)Convert.ToInt32(row["TectonicActivity"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.HydrosphereTypeId = (AuroraHydrosphereType)Convert.ToInt32(row["HydroID"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.ParentBodyType = (ParentBodyType)Convert.ToInt32(row["ParentBodyType"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Year = Convert.ToDouble(row["Year"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Bearing = (AuroraUtils.GetRandomInteger(3600) - 1) / 10.0;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.SystemData = paramSystemData;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.StarData = paramStar;
                // ISSUE: reference to a compiler-generated field
                if (class285.gclass1_0.BodyClass == PlanetBodyClass.Planet)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class285.gclass1_0.PlanetNumber > num1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        num1 = class285.gclass1_0.PlanetNumber;
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class285.gclass1_0.OrbitalDistance > num2)
                    {
                        // ISSUE: reference to a compiler-generated field
                        num2 = class285.gclass1_0.OrbitalDistance;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                if (class285.gclass1_0.ParentBodyType == ParentBodyType.EnumVal1)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class285.gclass1_0.ParentBodyData = source.FirstOrDefault<SystemBodyData>(class285.method_0);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.ParentBodyID = class285.gclass1_0.ParentBodyData.SystemBodyID;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.ParentBodyID = 0;
                }

                // ISSUE: reference to a compiler-generated field
                class285.int_0 = Convert.ToInt32(row["TrojanPlanet"]);
                // ISSUE: reference to a compiler-generated field
                if (class285.int_0 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.TrojanOffset = Convert.ToDouble(row["TrojanOffset"]);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class285.gclass1_0.ParentBodyData = source.FirstOrDefault<SystemBodyData>(class285.method_1);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.ParentBodyID = class285.gclass1_0.ParentBodyData.SystemBodyID;
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.PlanetNumber = 101;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.Year = class285.gclass1_0.ParentBodyData.Year;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.Eccentricity = class285.gclass1_0.ParentBodyData.Eccentricity;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.EccentricityDirection = class285.gclass1_0.ParentBodyData.EccentricityDirection;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.Bearing = class285.gclass1_0.ParentBodyData.Bearing + class285.gclass1_0.TrojanOffset;
                    // ISSUE: reference to a compiler-generated field
                    if (class285.gclass1_0.Bearing < 0.0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class285.gclass1_0.Bearing += 360.0;
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class285.gclass1_0.Bearing >= 360.0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class285.gclass1_0.Bearing -= 360.0;
                    }
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.TrojanOffset = 0.0;
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.Eccentricity = Convert.ToDouble(row["Eccentricity"]);
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.EccentricityDirection = (AuroraUtils.GetRandomInteger(3600) - 1) / 10.0;
                }

                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.HydroExtent = Convert.ToDouble(row["HydroExt"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Density = Convert.ToDouble(row["Density"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Mass = Convert.ToDouble(row["Mass"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Gravity = Convert.ToDouble(row["Gravity"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Escape = Convert.ToDouble(row["Escape"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.TidalForce = Convert.ToDouble(row["TidalForce"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Day = Convert.ToDouble(row["Day"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Roche = Convert.ToDouble(row["Roche"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.MagneticField = Convert.ToDouble(row["MagneticField"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.BaseTemp = Convert.ToDouble(row["BaseTemp"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.SurfaceTemp = Convert.ToDouble(row["SurfaceTemp"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.AtmospherePressure = Convert.ToDouble(row["AtmosPress"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Albedo = Convert.ToDouble(row["Albedo"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.GreenhouseFactor = Convert.ToDouble(row["GHFactor"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.AntiGreenhouseFactor = 1.0;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.XCoordinate = Convert.ToDouble(row["Xcor"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.YCoordinate = Convert.ToDouble(row["Ycor"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.RadiationLevel = 0M;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.DustLevel = 0M;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.double_27 =
                    class285.gclass1_0.OrbitalDistance * (1.0 - class285.gclass1_0.Eccentricity);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.double_28 =
                    class285.gclass1_0.OrbitalDistance * (1.0 + class285.gclass1_0.Eccentricity);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.double_26 = class285.gclass1_0.OrbitalDistance *
                                               Math.Sqrt(1.0 - class285.gclass1_0.Eccentricity *
                                                   class285.gclass1_0.Eccentricity);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.method_5();
                // ISSUE: reference to a compiler-generated field
                if (this.LimitPlanetaryDistance == 1 && class285.gclass1_0.double_28 > 80.0)
                {
                    while (true)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class285.gclass1_0.method_41(class285.gclass1_0.Bearing);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class285.gclass1_0.DistanceToParent = this.GetDistanceBetween(class285.gclass1_0.XCoordinate,
                            class285.gclass1_0.YCoordinate, class285.gclass1_0.StarData.XCoord,
                            class285.gclass1_0.StarData.YCoord) / AuroraUtils.double_14;
                        // ISSUE: reference to a compiler-generated field
                        if (class285.gclass1_0.DistanceToParent >= 80.0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class285.gclass1_0.Bearing = (AuroraUtils.GetRandomInteger(3600) - 1) / 10.0;
                        }
                        else
                            break;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                if (class285.gclass1_0.Mass == 0.0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    double num3 = Math.Pow(class285.gclass1_0.Radius / 6380.0, 3.0) * class285.gclass1_0.Density;
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.Mass = num3;
                }

                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.TidalLock = Convert.ToBoolean(row["TidalLock"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Ring = Convert.ToBoolean(row["Ring"]);
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.GroundMineralSurveyState = AuroraGroundMineralSurvey.Completed;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.Name = row["Name"].ToString();
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.PlanetIcon = row["PlanetIcon"].ToString();
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.RuinID = 0;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.RuinRaceID = 0;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.AbandonedFactories = 0;
                // ISSUE: reference to a compiler-generated field
                class285.gclass1_0.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.FullUpdate;
                // ISSUE: reference to a compiler-generated field
                source.Add(class285.gclass1_0);
                // ISSUE: reference to a compiler-generated field
                if (class285.gclass1_0.Name == "Jupiter")
                {
                    // ISSUE: reference to a compiler-generated field
                    this.ModifyForJupiter(class285.gclass1_0, false);
                }

                // ISSUE: reference to a compiler-generated field
                if (class285.gclass1_0.Name == "Earth")
                {
                    // ISSUE: reference to a compiler-generated field
                    GClass224 gclass224_1 = new GClass224(class285.gclass1_0,
                        this.AtmosphericGasDictionary[AtmosphericGas.Nitrogen], 0.79, 79.0);
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.list_0.Add(gclass224_1);
                    // ISSUE: reference to a compiler-generated field
                    GClass224 gclass224_2 = new GClass224(class285.gclass1_0,
                        this.AtmosphericGasDictionary[AtmosphericGas.Oxygen], 0.2, 20.0);
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.list_0.Add(gclass224_2);
                    // ISSUE: reference to a compiler-generated field
                    GClass224 gclass224_3 = new GClass224(class285.gclass1_0,
                        this.AtmosphericGasDictionary[AtmosphericGas.Argon], 0.01, 1.0);
                    // ISSUE: reference to a compiler-generated field
                    class285.gclass1_0.list_0.Add(gclass224_3);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class285.gclass1_0.Name == "Venus")
                    {
                        // ISSUE: reference to a compiler-generated field
                        GClass224 gclass224_4 = new GClass224(class285.gclass1_0,
                            this.AtmosphericGasDictionary[AtmosphericGas.CarbonDioxide], 89.745, 96.5);
                        // ISSUE: reference to a compiler-generated field
                        class285.gclass1_0.list_0.Add(gclass224_4);
                        // ISSUE: reference to a compiler-generated field
                        GClass224 gclass224_5 = new GClass224(class285.gclass1_0,
                            this.AtmosphericGasDictionary[AtmosphericGas.Nitrogen], 3.255, 3.5);
                        // ISSUE: reference to a compiler-generated field
                        class285.gclass1_0.list_0.Add(gclass224_5);
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class285.gclass1_0.Name == "Mars")
                        {
                            // ISSUE: reference to a compiler-generated field
                            GClass224 gclass224_6 = new GClass224(class285.gclass1_0,
                                this.AtmosphericGasDictionary[AtmosphericGas.CarbonDioxide], 0.005742, 95.7);
                            // ISSUE: reference to a compiler-generated field
                            class285.gclass1_0.list_0.Add(gclass224_6);
                            // ISSUE: reference to a compiler-generated field
                            GClass224 gclass224_7 = new GClass224(class285.gclass1_0,
                                this.AtmosphericGasDictionary[AtmosphericGas.Nitrogen], 0.000162, 2.7);
                            // ISSUE: reference to a compiler-generated field
                            class285.gclass1_0.list_0.Add(gclass224_7);
                            // ISSUE: reference to a compiler-generated field
                            GClass224 gclass224_8 = new GClass224(class285.gclass1_0,
                                this.AtmosphericGasDictionary[AtmosphericGas.Argon], 9.6E-05, 1.6);
                            // ISSUE: reference to a compiler-generated field
                            class285.gclass1_0.list_0.Add(gclass224_8);
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class285.gclass1_0.Name == "Titan")
                            {
                                // ISSUE: reference to a compiler-generated field
                                GClass224 gclass224_9 = new GClass224(class285.gclass1_0,
                                    this.AtmosphericGasDictionary[AtmosphericGas.Nitrogen], 1.4268, 98.4);
                                // ISSUE: reference to a compiler-generated field
                                class285.gclass1_0.list_0.Add(gclass224_9);
                                // ISSUE: reference to a compiler-generated field
                                GClass224 gclass224_10 = new GClass224(class285.gclass1_0,
                                    this.AtmosphericGasDictionary[AtmosphericGas.Methane], 0.0203, 1.4);
                                // ISSUE: reference to a compiler-generated field
                                class285.gclass1_0.list_0.Add(gclass224_10);
                                // ISSUE: reference to a compiler-generated field
                                GClass224 gclass224_11 = new GClass224(class285.gclass1_0,
                                    this.AtmosphericGasDictionary[AtmosphericGas.Hydrogen], 0.0029, 0.2);
                                // ISSUE: reference to a compiler-generated field
                                class285.gclass1_0.list_0.Add(gclass224_11);
                            }
                        }
                    }
                }

                // ISSUE: reference to a compiler-generated field
                this.method_648(class285.gclass1_0);
                // ISSUE: reference to a compiler-generated field
                if (class285.gclass1_0.Name == "Earth")
                {
                    // ISSUE: reference to a compiler-generated field
                    this.method_673(null, class285.gclass1_0, paramDecimalValue);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class285.gclass1_0.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                        class285.gclass1_0.BodyTypeId != AuroraSystemBodyType.Superjovian)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class285.gclass1_0.BodyTypeId == AuroraSystemBodyType.Comet)
                        {
                            // ISSUE: reference to a compiler-generated field
                            this.method_670(class285.gclass1_0);
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            this.method_672(class285.gclass1_0, null);
                        }
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        this.method_669(class285.gclass1_0, false);
                    }
                }
            }

            foreach (SystemBodyData gclass1 in source)
                this.SystemBodyRecordDic.Add(gclass1.SystemBodyID, gclass1);
            if (!paramBool)
                return;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass0.Class286 class286 = new GClass0.Class286()
            {
                gclass1_0 = new SystemBodyData(this)
            };
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.SystemBodyID = this.method_26(GEnum0.const_4);
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.ParentBodyType = ParentBodyType.EnumVal0;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.ParentBodyID = paramStar.StarID;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.StarData = paramStar;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.StarID = paramStar.StarID;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.SystemData = paramSystemData;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.SystemID = paramSystemData.SystemID;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.OrbitalDistance = num2 * 1.25 + num2 * (AuroraUtils.GetRandomInteger(100) / 100.0);
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.PlanetNumber = num1 + 1;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.BodyClass = PlanetBodyClass.Planet;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.Name = "Minerva";
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.double_38 = AuroraUtils.double_14 * ((class286.gclass1_0.OrbitalDistance - num2) / 3.0);
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.double_39 = 0.0;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.genum4_0 = GEnum4.const_3;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.bool_4 = true;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.Eccentricity = 0.0;
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.EccentricityDirection = 0.0;
            // ISSUE: reference to a compiler-generated field
            this.method_688(class286.gclass1_0);
            // ISSUE: reference to a compiler-generated field
            class286.gclass1_0.method_3(PlanetBodyClass.Planet);
            // ISSUE: reference to a compiler-generated field
            this.method_667(class286.gclass1_0, false);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class286.gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian ||
                class286.gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant && class286.gclass1_0.Mass > 150.0)
            {
                // ISSUE: reference to a compiler-generated field
                this.ModifyForJupiter(class286.gclass1_0, false);
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.SystemBodyRecordDic.Add(class286.gclass1_0.SystemBodyID, class286.gclass1_0);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class286.gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian ||
                class286.gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_665(class286.gclass1_0, 0);
            }

            // ISSUE: reference to a compiler-generated field
            this.method_660(class286.gclass1_0);
            // ISSUE: reference to a compiler-generated field
            for (int index = 1; index <= class286.gclass1_0.int_12; ++index)
            {
                SystemBodyData gclass1_1 = new SystemBodyData(this);
                // ISSUE: reference to a compiler-generated field
                gclass1_1.ParentBodyData = class286.gclass1_0;
                this.method_659(gclass1_1);
                if (gclass1_1.OrbitalDistance != 0.0)
                {
                    gclass1_1.SystemBodyID = this.method_26(GEnum0.const_4);
                    gclass1_1.ParentBodyType = ParentBodyType.EnumVal1;
                    // ISSUE: reference to a compiler-generated field
                    gclass1_1.ParentBodyID = class286.gclass1_0.SystemBodyID;
                    gclass1_1.StarData = paramStar;
                    gclass1_1.StarID = paramStar.StarID;
                    gclass1_1.SystemData = paramSystemData;
                    gclass1_1.SystemID = paramSystemData.SystemID;
                    // ISSUE: reference to a compiler-generated field
                    gclass1_1.PlanetNumber = class286.gclass1_0.PlanetNumber;
                    gclass1_1.genum4_0 = GEnum4.const_3;
                    gclass1_1.BodyClass = PlanetBodyClass.Moon;
                    this.method_658(gclass1_1);
                    this.method_668(gclass1_1, false);
                    this.SystemBodyRecordDic.Add(gclass1_1.SystemBodyID, gclass1_1);
                }
            }

            int num4 = 1;
            // ISSUE: reference to a compiler-generated method
            foreach (SystemBodyData gclass1 in this.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(class286.method_0)
                         .OrderBy<SystemBodyData, double>(gclass1_0 => gclass1_0.OrbitalDistance)
                         .ToList<SystemBodyData>())
            {
                gclass1.OrbitNumber = num4;
                gclass1.Name = "Minerva - Moon #" + num4.ToString();
                ++num4;
            }

            int num5 = 1;
            // ISSUE: reference to a compiler-generated method
            foreach (SystemBodyData gclass1 in this.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(class286.method_1)
                         .OrderBy<SystemBodyData, double>(gclass1_0 => gclass1_0.OrbitalDistance)
                         .ToList<SystemBodyData>())
            {
                gclass1.OrbitNumber = num5;
                gclass1.Name = "Minerva - Trojan #" + num5.ToString();
                ++num5;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1565);
        }
    }
    
    public void LoadDIMOperationGroupElementFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_OperationalGroupElement").Rows)
            {
                OperationalGroupElement opGroupElement = new OperationalGroupElement();
                opGroupElement.OperationalGroupId = (OperationalGroupID)Convert.ToInt32(row["OperationalGroupID"]);
                if (this.OperationalGroupDictionary.ContainsKey(opGroupElement.OperationalGroupId))
                {
                    AutomatedClassDesignType int32 = (AutomatedClassDesignType)Convert.ToInt32(row["AutomatedDesignID"]);
                    if (this.AutomatedClassDesignDictionary.ContainsKey(int32))
                    {
                        opGroupElement.AutomatedClassDesign = this.AutomatedClassDesignDictionary[int32];
                        opGroupElement.NumShips = Convert.ToInt32(row["NumShips"]);
                        opGroupElement.RandomNumShips = Convert.ToInt32(row["RandomNumShips"]);
                        opGroupElement.ChanceOfElement = Convert.ToInt32(row["ChanceOfElement"]);
                        opGroupElement.KeyElement = Convert.ToBoolean(row["KeyElement"]);
                        this.OperationalGroupDictionary[opGroupElement.OperationalGroupId].OperationalGroupElementList.Add(opGroupElement);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1134);
        }
    }
    
    public void LoadDIMOperationalGroupProgressionFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_OperationalGroupProgression").Rows)
            {
                GClass12 gclass12 = new GClass12();
                OperationalGroupID int32 = (OperationalGroupID)Convert.ToInt32(row["OperationalGroupID"]);
                if (this.OperationalGroupDictionary.ContainsKey(int32))
                {
                    gclass12.gclass9_0 = this.OperationalGroupDictionary[int32];
                    gclass12.genum90_0 = (OperationGroupProgressionType)Convert.ToInt32(row["OpGroupProgressionType"]);
                    gclass12.int_0 = Convert.ToInt32(row["ProgressionOrder"]);
                    gclass12.int_1 = Convert.ToInt32(row["NumGroups"]);
                    gclass12.int_2 = Convert.ToInt32(row["CountGroupType"]);
                    gclass12.bool_0 = Convert.ToBoolean(row["Mandatory"]);
                    this.list_2.Add(gclass12);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1136);
        }
    }
    
    public void LoadDIMOperationalGroupFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_OperationalGroup").Rows)
            {
                OperationalGroup gclass9 = new OperationalGroup();
                gclass9.OperationalGroupId = (OperationalGroupID)Convert.ToInt32(row["OperationalGroupID"]);
                gclass9.genum104_0 = (GEnum104)Convert.ToInt32(row["MainFunction"]);
                gclass9.int_0 = Convert.ToInt32(row["MainFunctionPriority"]);
                gclass9.int_1 = Convert.ToInt32(row["MobileMilitary"]);
                gclass9.bool_1 = Convert.ToBoolean(row["AvoidDanger"]);
                gclass9.bool_2 = Convert.ToBoolean(row["OffensiveForce"]);
                gclass9.bool_3 = Convert.ToBoolean(row["StaticForce"]);
                gclass9.bool_0 = Convert.ToBoolean(row["ChangeStandingToFuel"]);
                gclass9.string_0 = row["Description"].ToString();
                AuroraStandingOrder int32_1 = (AuroraStandingOrder)Convert.ToInt32(row["PrimaryStandingOrder"]);
                AuroraStandingOrder int32_2 = (AuroraStandingOrder)Convert.ToInt32(row["SecondaryStandingOrder"]);
                gclass9.gclass136_0 = !this.StandingOrderDictionary.ContainsKey(int32_1)
                    ? this.StandingOrderDictionary[AuroraStandingOrder.NoOrder]
                    : this.StandingOrderDictionary[int32_1];
                gclass9.gclass136_1 = !this.StandingOrderDictionary.ContainsKey(int32_2)
                    ? this.StandingOrderDictionary[AuroraStandingOrder.NoOrder]
                    : this.StandingOrderDictionary[int32_2];
                int int32_3 = Convert.ToInt32(row["TechRequirementA"]);
                if (this.TechDataDictionary.ContainsKey(int32_3))
                    gclass9.gclass164_0 = this.TechDataDictionary[int32_3];
                this.OperationalGroupDictionary.Add(gclass9.OperationalGroupId, gclass9);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1135);
        }
    }
    
    public void LoadDIMDesignPhilosophyGroundForceDeployementsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_DesignPhilosophyGroundForceDeployments").Rows)
                this.list_4.Add(new GClass16()
                {
                    genum116_0 = (AutomatedGroundTemplateDesignType)Convert.ToInt32(row["AutomatedTemplateID"]),
                    int_1 = Convert.ToInt32(row["GroundForceDeploymentThemeID"]),
                    int_0 = Convert.ToInt32(row["NumberRequired"]),
                    int_2 = Convert.ToInt32(row["Priority"]),
                    genum97_0 = (GEnum97)Convert.ToInt32(row["PopulationValue"])
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1138);
        }
    }
    
        // Guess: LoadTradeGoodsFromDB; creates GClass189 (TradeGood definition)
        public void LoadTradeGoodsFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_TradeGoods").Rows)
            {
                TradeGoodsDefinition gclass189 = new TradeGoodsDefinition();
                gclass189.int_0 = Convert.ToInt32(row["TradeGoodID"]);
                gclass189.genum49_0 = (GEnum49)Convert.ToInt32(row["Category"]);
                gclass189.decimal_0 = Convert.ToDecimal(row["PopRequired"]);
                gclass189.bool_0 = Convert.ToBoolean(row["RareGood"]);
                gclass189.string_0 = row["Description"].ToString();
                this.TradeGoodsDictionary.Add(gclass189.int_0, gclass189);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1151);
        }
    }

    public void LoadDIMGroundUnitBaseTypeFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_GroundUnitBaseType").Rows)
            {
                GroundUnitBaseTypeData gclass96 = new GroundUnitBaseTypeData();
                int int32 = Convert.ToInt32(row["TechSystemID"]);
                if (this.TechDataDictionary.ContainsKey(int32))
                {
                    gclass96.gclass164_0 = this.TechDataDictionary[int32];
                    gclass96.genum112_0 = (GroundUnitBaseType)Convert.ToInt32(row["UnitBaseTypeID"]);
                    gclass96.int_0 = Convert.ToInt32(row["HitPoints"]);
                    gclass96.int_1 = Convert.ToInt32(row["DisplayOrder"]);
                    gclass96.int_2 = Convert.ToInt32(row["ComponentSlots"]);
                    gclass96.decimal_0 = Convert.ToDecimal(row["Size"]);
                    gclass96.decimal_1 = Convert.ToDecimal(row["MaxSelfFortification"]);
                    gclass96.decimal_2 = Convert.ToDecimal(row["MaxFortification"]);
                    gclass96.decimal_3 = Convert.ToDecimal(row["ToHitModifier"]);
                    gclass96.Name = row["Name"].ToString();
                    gclass96.string_0 = row["Abbreviation"].ToString();
                    this.GroundUnitBaseTypeDictionary.Add(gclass96.genum112_0, gclass96);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1152);
        }
    }

    public void LoadDIMGroundUnitArmourFromDB()
    {
        try
        {
            foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                         .ExecuteQuery("select * from DIM_GroundUnitArmour").Rows)
            {
                ArmourTypeData gclass97 = new ArmourTypeData();
                int int32 = Convert.ToInt32(row["TechSystemID"]);
                if (this.TechDataDictionary.ContainsKey(int32))
                {
                    gclass97.gclass164_0 = this.TechDataDictionary[int32];
                    gclass97.int_0 = Convert.ToInt32(row["ArmourTypeID"]);
                    gclass97.genum112_0 = (GroundUnitBaseType)Convert.ToInt32(row["BaseUnitType"]);
                    gclass97.decimal_0 = Convert.ToDecimal(row["ArmourStrength"]);
                    gclass97.Name = row["Name"].ToString();
                    this.ArmourTypeDictionary.Add(gclass97.int_0, gclass97);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1153);
        }
    }
    
    // Guess: InsertRandomBlackHoleKnownSystemsIntoDB; creates DIMKnownSystemsData198 and writes to DIM_KnownSystems
    public void AddRandomBlackHoleSystemsToDB()
    {
        try
        {
            List<DIMKnownSystemsData198> gclass198List = new List<DIMKnownSystemsData198>();
            for (int index = 1; index < 51; ++index)
            {
                int key = AuroraUtils.GetRandomInteger(15) + 452;
                if (this.StarTypeDictionary.ContainsKey(key))
                {
                    DIMKnownSystemsData198 gclass198 = new DIMKnownSystemsData198();
                    gclass198.KnownSystemID = this.GameID * 10000 + index;
                    gclass198.Name = "Black Hole";
                    gclass198.dictionary_0.Add(1, this.StarTypeDictionary[key].method_0());
                    gclass198.int_1 = 1;
                    gclass198.C3OrbitType = 0;
                    gclass198.C4OrbitType = 0;
                    gclass198.C2Orbit = 0.0;
                    gclass198.C3Orbit = 0.0;
                    gclass198.C4Orbit = 0.0;
                    do
                    {
                        gclass198.X = AuroraUtils.smethod_17() * 300.0 - 150.0;
                        gclass198.Y = AuroraUtils.smethod_17() * 300.0 - 150.0;
                        gclass198.Z = AuroraUtils.smethod_17() * 300.0 - 150.0;
                        gclass198.Distance = Math.Sqrt(gclass198.X * gclass198.X + gclass198.Y * gclass198.Y +
                                                       gclass198.Z * gclass198.Z);
                    } while (gclass198.Distance <= 25.0 && gclass198.Distance >= 25.0);

                    this.KnownSystemDataDictionary.Add(gclass198.KnownSystemID, gclass198);
                    gclass198List.Add(gclass198);
                }
                else
                    break;
            }

            using (SQLiteConnection connection = new SQLiteConnection(AuroraUtils.string_1))
            {
                connection.Open();
                using (SQLiteCommand sqLiteCommand = new SQLiteCommand(connection))
                {
                    using (SQLiteTransaction sqLiteTransaction = connection.BeginTransaction())
                    {
                        foreach (DIMKnownSystemsData198 gclass198 in gclass198List)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO DIM_KnownSystems (KnownSystemID, Name, PrimaryName, Component1ID, Component2ID, C2Orbit, Component3ID, C3Orbit, C3OrbitType, Component4ID, C4Orbit, C4OrbitType, X, Y, Z, Distance, ConstellationName, GameID ) \r\n                                                VALUES ( @KnownSystemID, @Name, @PrimaryName, @Component1ID, @Component2ID, @C2Orbit, @Component3ID, @C3Orbit, @C3OrbitType, @Component4ID, @C4Orbit, @C4OrbitType, @X, @Y, @Z, @Distance, @ConstellationName, @GameID)";
                            sqLiteCommand.Parameters.AddWithValue("@KnownSystemID", gclass198.KnownSystemID);
                            sqLiteCommand.Parameters.AddWithValue("@Name", gclass198.Name);
                            sqLiteCommand.Parameters.AddWithValue("@PrimaryName", "BH");
                            sqLiteCommand.Parameters.AddWithValue("@Component1ID", gclass198.dictionary_0[1].StellarTypeID);
                            sqLiteCommand.Parameters.AddWithValue("@Component2ID", 0);
                            sqLiteCommand.Parameters.AddWithValue("@C2Orbit", 0);
                            sqLiteCommand.Parameters.AddWithValue("@Component3ID", 0);
                            sqLiteCommand.Parameters.AddWithValue("@C3Orbit", 0);
                            sqLiteCommand.Parameters.AddWithValue("@C3OrbitType", 0);
                            sqLiteCommand.Parameters.AddWithValue("@Component4ID", 0);
                            sqLiteCommand.Parameters.AddWithValue("@C4Orbit", 0);
                            sqLiteCommand.Parameters.AddWithValue("@C4OrbitType", 0);
                            sqLiteCommand.Parameters.AddWithValue("@X", gclass198.X);
                            sqLiteCommand.Parameters.AddWithValue("@Y", gclass198.Y);
                            sqLiteCommand.Parameters.AddWithValue("@Z", gclass198.Z);
                            sqLiteCommand.Parameters.AddWithValue("@Distance", gclass198.Distance);
                            sqLiteCommand.Parameters.AddWithValue("@ConstellationName", " ");
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.ExecuteNonQuery();
                        }

                        sqLiteTransaction.Commit();
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3572);
        }
    }
    
    public void AddCommanderNameThemeToDB(CommanderNameThemeData gclass58_0)
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
                        sqLiteCommand.CommandText =
                            "INSERT INTO DIM_CommanderNameTheme (NameThemeID, Description, NameOne, NameTwo, NameThree, SpecialRule, NameOneAddition, NameOneAdditionChance ) VALUES ( @NameThemeID, @Description, @NameOne, @NameTwo, @NameThree, @SpecialRule, @NameOneAddition, @NameOneAdditionChance)";
                        sqLiteCommand.Parameters.AddWithValue("@NameThemeID", gclass58_0.NameThemeID);
                        sqLiteCommand.Parameters.AddWithValue("@Description", gclass58_0.Description);
                        sqLiteCommand.Parameters.AddWithValue("@NameOne", gclass58_0.NameOne);
                        sqLiteCommand.Parameters.AddWithValue("@NameTwo", gclass58_0.NameTwo);
                        sqLiteCommand.Parameters.AddWithValue("@NameThree", gclass58_0.NameThree);
                        sqLiteCommand.Parameters.AddWithValue("@SpecialRule", gclass58_0.SpecialRule);
                        sqLiteCommand.Parameters.AddWithValue("@NameOneAddition", gclass58_0.NameOneAddition);
                        sqLiteCommand.Parameters.AddWithValue("@NameOneAdditionChance", gclass58_0.NameOneAdditionChance);
                        sqLiteCommand.ExecuteNonQuery();
                        sqLiteTransaction.Commit();
                    }
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1436);
        }
    }

    public void AddNamingThemeToDB(NamingTheme gclass140_1)
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
                        sqLiteCommand.CommandText =
                            "INSERT INTO DIM_NamingThemeTypes (ThemeID, Description, RaceNameEligible ) VALUES ( @ThemeID, @Description, @RaceNameEligible)";
                        sqLiteCommand.Parameters.AddWithValue("@ThemeID", gclass140_1.ThemeID);
                        sqLiteCommand.Parameters.AddWithValue("@Description", gclass140_1.Description);
                        sqLiteCommand.Parameters.AddWithValue("@RaceNameEligible", gclass140_1.RaceNameEligible);
                        sqLiteCommand.ExecuteNonQuery();
                        foreach (string str in gclass140_1.NameList)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO DIM_NamingTheme (NameThemeID, Name ) VALUES ( @NameThemeID, @Name)";
                            sqLiteCommand.Parameters.AddWithValue("@NameThemeID", gclass140_1.ThemeID);
                            sqLiteCommand.Parameters.AddWithValue("@Name", str);
                            sqLiteCommand.ExecuteNonQuery();
                        }

                        sqLiteTransaction.Commit();
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1435);
        }
    }

    public void AddCommanderNamesToDB(List<CommanderNameDefinition> list_33)
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
                        foreach (CommanderNameDefinition gclass57 in list_33)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO DIM_CommanderNames (NameThemeID, FirstName, Name, Female, ThirdName, FamilyName ) VALUES ( @NameThemeID, @FirstName, @Name, @Female, @ThirdName, @FamilyName)";
                            sqLiteCommand.Parameters.AddWithValue("@NameThemeID", gclass57.CommanderNameTheme.NameThemeID);
                            sqLiteCommand.Parameters.AddWithValue("@FirstName", gclass57.AllowedForFirstName);
                            sqLiteCommand.Parameters.AddWithValue("@Name", gclass57.Name);
                            sqLiteCommand.Parameters.AddWithValue("@Female", gclass57.AllowedForFemale);
                            sqLiteCommand.Parameters.AddWithValue("@ThirdName", gclass57.AllowedForThirdName);
                            sqLiteCommand.Parameters.AddWithValue("@FamilyName", gclass57.AllowedForLastName);
                            sqLiteCommand.ExecuteNonQuery();
                        }

                        sqLiteTransaction.Commit();
                    }
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1437);
        }
    }
}