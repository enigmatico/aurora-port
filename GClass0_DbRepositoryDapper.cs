using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Dapper;
using Dapper.ColumnMapper;
    

public static class GClass0_DbRepositoryDapper
{
    public static void UpsertTableFCT_Game(SQLiteConnection dbCon, GClass0 game)
    {
        // delete first
        dbCon.Execute($"DELETE FROM FCT_Game WHERE GameID = {game.GameID.ToString()}");
        dbCon.Execute("UPDATE FCT_Game SET LastViewed = 0");
        
        const string sql =
            "INSERT INTO FCT_Game (GameID, AutoJumpGates, CivilianShippingLinesActive, AllowCivilianHarvesters, TechFromConquest, DefaultRaceID, DifficultyModifier, ResearchSpeed, TerraformingSpeed, SurveySpeed, GameName, GameTime, GenerateNonTNOnly, GenerateNPRs, HumanNPRs, InexpFleets, Invaders, LastGrowthTime, LastGroundCombatTime, LastViewed, LocalSystemChance, LocalSystemSpread, LimitPlanetaryDistance,\r\n                    MinComets, NewRuinCreationChance, NoOverhauls, NonPlayerSystemDetection, SolDisaster, NPRsGeneratePrecursors, NPRsGenerateSwarm, NPRsGenerateRifts, NPRsEncounterRaiders, NumberOfSystems, ConstellationNames, EldarOpGroupProgression, SwarmSystems, RaiderSystems, InvaderSystems, HostilityModifier, StarEccentricity, GasGiantEffects, LimitedLabs, OneSecondSubPulse, MinorRaceChance, PreIndustrialChance, ParallelUniverse,\r\n                    OrbitalMotion, OrbitalMotionAst, PlayerExplorationTime, PoliticalAdmirals, Precursors, Rakhas, Eldar, MinConstructionPeriod, MinGroundCombatPeriod, RaceChance,  RaceChanceNPR, RealisticPromotions, SMPassword, StarSwarm, StartYear, SubPulseLength, TruceCountdown, UseKnownStars, CurrentGroundCombat, MaxEventDays, MaxEventCount, StartTimeEldar, StartTimeSwarm, StartTimeInvaders, UseThemeInKnownStars, \r\n                    NPRBaseTransits, NPRRandomTransits, NPRMaxSystems, EnhancedInvaders, EnhancedPrecursors, EnhancedSwarm, SwarmInvasion, MinimumSwarmRP, ConventionalChance, chkOrders, chkOverhauls, chkShowJD) \r\n                    VALUES ( @GameID, @AutoJumpGates, @CivilianShippingLinesActive, @AllowCivilianHarvesters, @TechFromConquest, @DefaultRaceID, @DifficultyModifier, @ResearchSpeed, @TerraformingSpeed, @SurveySpeed, @GameName, @GameTime, @GenerateNonTNOnly, @GenerateNPRs, @HumanNPRs, @InexpFleets, @Invaders, @LastGrowthTime, @LastGroundCombatTime, @LastViewed, @LocalSystemChance, @LocalSystemSpread, @LimitPlanetaryDistance, \r\n                    @MinComets, @NewRuinCreationChance, @NoOverhauls, @NonPlayerSystemDetection, @SolDisaster, @NPRsGeneratePrecursors, @NPRsGenerateSwarm, @NPRsGenerateRifts, @NPRsEncounterRaiders, @NumberOfSystems, @ConstellationNames, @EldarOpGroupProgression,@SwarmSystems, @RaiderSystems, @InvaderSystems, @HostilityModifier, @StarEccentricity, @GasGiantEffects, @LimitedLabs, @OneSecondSubPulse, @MinorRaceChance, @PreIndustrialChance, @ParallelUniverse,\r\n                    @OrbitalMotion, @OrbitalMotionAst, @PlayerExplorationTime, @PoliticalAdmirals, @Precursors, @Rakhas, @Eldar, @MinConstructionPeriod, @MinGroundCombatPeriod, @RaceChance, @RaceChanceNPR, @RealisticPromotions, @SMPassword, @StarSwarm, @StartYear, @SubPulseLength, @TruceCountdown, @UseKnownStars, @CurrentGroundCombat, @MaxEventDays, @MaxEventCount, @StartTimeEldar, @StartTimeSwarm, @StartTimeInvaders, @UseThemeInKnownStars,\r\n                    @NPRBaseTransits, @NPRRandomTransits, @NPRMaxSystems, @EnhancedInvaders, @EnhancedPrecursors, @EnhancedSwarm, @SwarmInvasion, @MinimumSwarmRP, @ConventionalChance, @chkOrders, @chkOverhauls, @chkShowJD)";
        dbCon.Execute(sql, game);
    }

    // TODO: WIP
    public static void InsertTableFCT_Race(SQLiteConnection con, GameRace race)
    {
        const string sql = "INSERT INTO FCT_Race (RaceID, GameID, NPR, SpecialNPRID, RaceStartingLevel, RaceGridSize, RaceName, RaceTitle, WealthPoints, StartingWealth, AnnualWealth, GovTypeID, UnreadMessages, FlagPic, HullPic, SpaceStationPic, Contacts, Colour, Red, Green, Blue, Password, ThemeID, ClassThemeID, MissileThemeID, GroundThemeID, SystemThemeID, ColonyDensity, BioShips,\r\n                        DisplayGrade, ShowHighlight, MapRed, MapGreen, MapBlue, FleetViewOption, SelectRace, FleetsVisible, LastMapSystemViewed, chkAllowAny, chkAutoAssign, chkTons, StandardTour, LastAssignment, CurrentXenophobia, AcademyCrewmen, MaintenanceCapacity, OrdnanceCapacity, FighterCapacity, ShipBuilding, FuelProduction, ConstructionProduction, MaximumOrbitalMiningDiameter, ShippingLineTax,\r\n                        OrdnanceProduction, FighterProduction, MineProduction, GeneticConversionRate, Research, PlanetarySensorStrength, TrainingLevel, GUStrength, TerraformingRate, ColonizationSkill, StartTechPoints, StartBuildPoints, WealthCreationRate, EconomicProdModifier, ShipyardOperations, MSPProduction, MaxRefuellingRate, MaxOrdnanceTransferRate, UnderwayReplenishmentRate, Hostile, Neutral, Friendly, chkUseHullNumbers, chkHullCategory,\r\n                        Allied, Civilian, HideCMCPop, PopByFunction, chkPlanets, chkDwarf, chkMoons, chkAst, chkWP, chkStarOrbits, chkPlanetOrbits, chkDwarfOrbits, chkMoonOrbits, chkAsteroidOrbits, chkSelectedOrbit, chkStarNames, chkPlanetNames, chkDwarfNames, chkMoonNames, chkAstNames, chkFleets, chkMoveTail, chkColonies, chkCentre, chkSL, chkWaypoint, chkOrder, chkNoOverlap, chkActiveSensors, chkML, chkGroundSurveyLocations, chkAetherRift, chkNumWrecks,\r\n                        chkTracking, chkActiveOnly, chkShowDist, chkSBSurvey, chkMinerals, chkCometPath, chkAstColOnly, chkAstMinOnly, chkTAD, chkFiringRanges, chkAllRace, chkDisplayAllForms, chkSalvoOrigin, chkSalvoTarget, chkEscorts, chkFireControlRange, PassiveSensor, ActiveSensor, DetRange, chkHideIDs, chkHideWreckIDs, chkHideSL, chkEvents, chkEventsAllRaces, chkPackets, chkMPC, chkLifepods, chkWrecks, chkHostileSensors, chkGeoPoints, chkBearing, \r\n                        chkCoordinates, chkLostContacts, chkLostContactsOneYear, chkLostContactsOneDay, chkSystemOnly, chkShowCivilianOOB, chkHostile, chkFriendly, chkAllied, chkNeutral, chkCivilian, chkContactsCurrentSystem, chkPassive10, chkPassive100, chkPassive1000, chkPassive10000,  chkUnexJP, chkJPSurveyStatus, chkSurveyLocationPoints, chkSurveyedSystemBodies, chkHabRangeWorlds, chkHabRangeWorldsLowG, chkLowCCNormalG, chkMediumCCNormalG, chkLowCCLowG, chkNumCometsPlanetlessSystem,\r\n                        chkMediumCCLowG, chkUseMaxCCDisplay, chkDistanceFromSelected, chkDistanceFromSelectedMR, chkDistanceRealSpace, chkWarshipLocation, chkAllFleetLocations, chkKnownAlienForces, chkAlienControlledSystems, chkPopulatedSystem, chkBlocked, chkShipyardComplexes, chkNavalHeadquarters, chkSectors, chkPossibleDormantJP, chkSecurityStatus, chkDiscoveryDate, RankScientist, RankAdministrator, CargoShuttleLoadModifier, GroundFormationConstructionRate, \r\n                        ResearchTargetCost, CurrentResearchTotal, NeutralRace, chkMilitaryRestricted, chkMilitaryRestrictedJP, chkDisplayMineralSearch, ShowPopStar, ShowPopSystemBody, TonnageSent, LastProgressionOrder, chkHideOrbitFleets, chkSupernovaImpactTime, UseRoman, MaxOrganizationLinkID, chkClassIcon, chkAdminIcon, SelectedClassIcon, SelectedAdminIcon, ZoomSetting, chkSystemIconOnly, MinMapFontSize, CrewDesignEfficiency) \r\n                        VALUES(@RaceID, @GameID, @NPR, @SpecialNPRID, @RaceStartingLevel, @RaceGridSize, @RaceName, @RaceTitle, @WealthPoints, @StartingWealth, @AnnualWealth, @GovTypeID, @UnreadMessages, @FlagPic, @HullPic, @SpaceStationPic, @Contacts, @Colour, @Red, @Green, @Blue, @Password, @ThemeID, @ClassThemeID, @MissileThemeID, @GroundThemeID, @SystemThemeID, @ColonyDensity, @BioShips,\r\n                        @DisplayGrade, @ShowHighlight, @MapRed, @MapGreen, @MapBlue, @FleetViewOption, @SelectRace, @FleetsVisible, @LastMapSystemViewed, @chkAllowAny, @chkAutoAssign, @chkTons, @StandardTour, @LastAssignment, @CurrentXenophobia, @AcademyCrewmen, @MaintenanceCapacity, @OrdnanceCapacity, @FighterCapacity, @ShipBuilding, @FuelProduction, @ConstructionProduction, @MaximumOrbitalMiningDiameter, @ShippingLineTax,\r\n                        @OrdnanceProduction, @FighterProduction, @MineProduction, @GeneticConversionRate, @Research, @PlanetarySensorStrength, @TrainingLevel, @GUStrength, @TerraformingRate, @ColonizationSkill, @StartTechPoints, @StartBuildPoints, @WealthCreationRate, @EconomicProdModifier, @ShipyardOperations, @MSPProduction, @MaxRefuellingRate, @MaxOrdnanceTransferRate, @UnderwayReplenishmentRate, @Hostile, @Neutral, @Friendly, @chkUseHullNumbers, @chkHullCategory,\r\n                        @Allied, @Civilian, @HideCMCPop, @PopByFunction, @chkPlanets, @chkDwarf, @chkMoons, @chkAst, @chkWP, @chkStarOrbits, @chkPlanetOrbits, @chkDwarfOrbits, @chkMoonOrbits, @chkAsteroidOrbits, @chkSelectedOrbit, @chkStarNames, @chkPlanetNames, @chkDwarfNames, @chkMoonNames, @chkAstNames, @chkFleets, @chkMoveTail, @chkColonies, @chkCentre, @chkSL, @chkWaypoint, @chkOrder, @chkNoOverlap, @chkActiveSensors, @chkML, @chkGroundSurveyLocations, @chkAetherRift, @chkNumWrecks,\r\n                        @chkTracking, @chkActiveOnly, @chkShowDist, @chkSBSurvey, @chkMinerals, @chkCometPath, @chkAstColOnly, @chkAstMinOnly, @chkTAD, @chkFiringRanges, @chkAllRace, @chkDisplayAllForms, @chkSalvoOrigin, @chkSalvoTarget, @chkEscorts, @chkFireControlRange, @PassiveSensor, @ActiveSensor, @DetRange, @chkHideIDs, @chkHideWreckIDs, @chkHideSL, @chkEvents, @chkEventsAllRaces, @chkPackets, @chkMPC, @chkLifepods, @chkWrecks, @chkHostileSensors, @chkGeoPoints, @chkBearing,\r\n                        @chkCoordinates, @chkLostContacts, @chkLostContactsOneYear, @chkLostContactsOneDay, @chkSystemOnly, @chkShowCivilianOOB, @chkHostile, @chkFriendly, @chkAllied, @chkNeutral, @chkCivilian, @chkContactsCurrentSystem, @chkPassive10, @chkPassive100, @chkPassive1000, @chkPassive10000, @chkUnexJP, @chkJPSurveyStatus, @chkSurveyLocationPoints, @chkSurveyedSystemBodies, @chkHabRangeWorlds, @chkHabRangeWorldsLowG, @chkLowCCNormalG, @chkMediumCCNormalG, @chkLowCCLowG, @chkNumCometsPlanetlessSystem,\r\n                        @chkMediumCCLowG, @chkUseMaxCCDisplay, @chkDistanceFromSelected, @chkDistanceFromSelectedMR, @chkDistanceRealSpace, @chkWarshipLocation, @chkAllFleetLocations, @chkKnownAlienForces, @chkAlienControlledSystems, @chkPopulatedSystem, @chkBlocked, @chkShipyardComplexes, @chkNavalHeadquarters, @chkSectors, @chkPossibleDormantJP, @chkSecurityStatus, @chkDiscoveryDate, @RankScientist, @RankAdministrator, @CargoShuttleLoadModifier, @GroundFormationConstructionRate, \r\n                        @ResearchTargetCost, @CurrentResearchTotal, @NeutralRace, @chkMilitaryRestricted, @chkMilitaryRestrictedJP, @chkDisplayMineralSearch, @ShowPopStar, @ShowPopSystemBody, @TonnageSent, @LastProgressionOrder, @chkHideOrbitFleets, @chkSupernovaImpactTime, @UseRoman, @MaxOrganizationLinkID, @chkClassIcon, @chkAdminIcon, @SelectedClassIcon, @SelectedAdminIcon, @ZoomSetting, @chkSystemIconOnly, @MinMapFontSize, @CrewDesignEfficiency)";
        // few pitfalls
        con.Execute(sql, race);
    }
}

public partial class GClass0
{
    public void UpsertGClass0(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            GClass0_DbRepositoryDapper.UpsertTableFCT_Game(sqliteConnection_0, this);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1428);
        }
    }
    
    
    public void UpsertRacialTables(SQLiteConnection sqliteConnection_0)
    {
        try
        {
            new SQLiteCommand("DELETE FROM FCT_Race WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_ResearchQueue WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_PausedResearch WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_SwarmResearch WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_KnownRuinRace WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_RaceNameThemes WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_BannedBodies WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_WindowPosition WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_RaceGroundCombat WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_GroundUnitSeries WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_GroundUnitSeriesClass WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_RaceOperationalGroupElements WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_HullNumber WHERE GameID = " + this.GameID.ToString(), sqliteConnection_0)
                .ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM FCT_WealthHistory WHERE GameID = " + this.GameID.ToString(),
                sqliteConnection_0).ExecuteNonQuery();
            using (SQLiteCommand sqLiteCommand = new SQLiteCommand(sqliteConnection_0))
            {
                foreach (GameRace race in this.GameRaces.Values)
                {
                    try
                    {
                        GClass0_DbRepositoryDapper.InsertTableFCT_Race(sqliteConnection_0, race);
                    }
                    catch (Exception ex)
                    {
                        int raceId = race.RaceID;
                        AuroraUtils.ShowExceptionPopupForItem(ex, 3235, raceId);
                    }

                    // TODO: ContinueFromHere: researchQueue가 Dapper에 먹을 수 있도록 readable한 동명의 프로퍼티를 추가할 것. 아래쪽으로도 마찬가지.
                    foreach (ResearchQueue researchQueue in race.ResearchQueues)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_ResearchQueue (GameID, PopulationID, TechSystemID, CurrentProjectID, ResearchOrder ) VALUES ( @GameID, @PopulationID, @TechSystemID, @CurrentProjectID, @ResearchOrder )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@PopulationID", researchQueue.Population.PopulationID);
                        sqLiteCommand.Parameters.AddWithValue("@TechSystemID", researchQueue.TechSystem.TechSystemID);
                        sqLiteCommand.Parameters.AddWithValue("@CurrentProjectID", researchQueue.CurrentProject.ResearchProjectID);
                        sqLiteCommand.Parameters.AddWithValue("@ResearchOrder", researchQueue.ResearchOrder);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (PausedResearch pausedResearch in race.PausedResearches)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_PausedResearch (TechSystemID, RaceID, GameID, PointsAccumulated ) VALUES ( @TechSystemID, @RaceID, @GameID, @PointsAccumulated )";
                        sqLiteCommand.Parameters.AddWithValue("@TechSystemID", pausedResearch.gclass164_0.TechSystemID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@PointsAccumulated", pausedResearch.PointsAccumulated);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (SwarmResearch swarmResearch in race.list_7)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_SwarmResearch (GameID, RaceID, ResearchPoints, TechSystemID ) VALUES ( @GameID, @RaceID, @ResearchPoints, @TechSystemID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", swarmResearch.Race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@ResearchPoints", swarmResearch.ResearchPoints);
                        sqLiteCommand.Parameters.AddWithValue("@TechSystemID", swarmResearch.TechSystem.TechSystemID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (int num in race.KnownRuinIDs)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_KnownRuinRace (RuinRaceID, RaceID, GameID ) VALUES ( @RuinRaceID, @RaceID, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@RuinRaceID", num);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GroundUnitSeriesData groundUnitSeries in race.GroundUnitSeriesDictionary.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_GroundUnitSeries (GroundUnitSeriesID, Description, RaceID, GameID ) VALUES ( @GroundUnitSeriesID, @Description, @RaceID, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@GroundUnitSeriesID", groundUnitSeries.GroundUnitSeriesID);
                        sqLiteCommand.Parameters.AddWithValue("@Description", groundUnitSeries.Description);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (GroundUnitSeriesClassData groundUnitSeriesClassData in race.GroundUnitSeriesClassList)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_GroundUnitSeriesClass (GroundUnitSeriesID, GroundUnitClassID, Priority, RaceID, GameID ) VALUES ( @GroundUnitSeriesID, @GroundUnitClassID, @Priority, @RaceID, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@GroundUnitSeriesID", groundUnitSeriesClassData.UnitSeriesData.GroundUnitSeriesID);
                        sqLiteCommand.Parameters.AddWithValue("@GroundUnitClassID", groundUnitSeriesClassData.UnitClass.ClassID);
                        sqLiteCommand.Parameters.AddWithValue("@Priority", groundUnitSeriesClassData.Priority);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    if (!race.NPR)
                    {
                        foreach (SystemBodyData gclass1 in race.BannedSystemBodies)
                        {
                            sqLiteCommand.CommandText =
                                "INSERT INTO FCT_BannedBodies (SystemBodyID, RaceID, GameID ) VALUES ( @SystemBodyID, @RaceID, @GameID )";
                            sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", gclass1.SystemBodyID);
                            sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                            sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                            sqLiteCommand.ExecuteNonQuery();
                        }
                    }

                    foreach (RaceNameTheme raceNameTheme in race.RaceNameThemeList)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_RaceNameThemes (GameID, RaceID, NameThemeID, Chance ) VALUES ( @GameID, @RaceID, @NameThemeID, @Chance )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@NameThemeID", raceNameTheme.CommanderNameThemeData.NameThemeID);
                        sqLiteCommand.Parameters.AddWithValue("@Chance", raceNameTheme.Chance);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (RaceGroundCombat raceGroundCombat in race.raceGroundCombatRecord.Values)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_RaceGroundCombat (RaceID, SystemBodyID, ConsecutiveCombatRounds, GameID ) VALUES ( @RaceID, @SystemBodyID, @ConsecutiveCombatRounds, @GameID )";
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@SystemBodyID", raceGroundCombat.SystemBody.SystemBodyID);
                        sqLiteCommand.Parameters.AddWithValue("@ConsecutiveCombatRounds",
                            raceGroundCombat.ConsecutiveCombatRounds);
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (RaceOperationalGroupElement opGroupElement in race.OperationalGroupElements)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_RaceOperationalGroupElements (GameID, RaceID, OperationalGroupID, NumShips, AutomatedDesignID, KeyElement ) VALUES (@GameID, @RaceID, @OperationalGroupID, @NumShips, @AutomatedDesignID, @KeyElement )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@OperationalGroupID", opGroupElement.Element.OperationalGroupId);
                        sqLiteCommand.Parameters.AddWithValue("@NumShips", opGroupElement.NumShips);
                        sqLiteCommand.Parameters.AddWithValue("@AutomatedDesignID", opGroupElement.AutomatedClassDesign.AutomatedClassDesignTypeID);
                        sqLiteCommand.Parameters.AddWithValue("@KeyElement", opGroupElement.KeyElement);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (KeyValuePair<ShipHull, int> keyValuePair in race.ShipHullCountDictionary)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_HullNumber (GameID, HullCount, HullTypeID, RaceID ) VALUES ( @GameID, @HullCount, @HullTypeID, @RaceID )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@HullCount", keyValuePair.Value);
                        sqLiteCommand.Parameters.AddWithValue("@HullTypeID", keyValuePair.Key.ShipHullDescriptionID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.ExecuteNonQuery();
                    }

                    foreach (WealthHistory wealthHistory in race.list_12)
                    {
                        sqLiteCommand.CommandText =
                            "INSERT INTO FCT_WealthHistory (GameID, RaceID, IncrementTime, WealthAmount ) VALUES ( @GameID, @RaceID, @IncrementTime, @WealthAmount )";
                        sqLiteCommand.Parameters.AddWithValue("@GameID", this.GameID);
                        sqLiteCommand.Parameters.AddWithValue("@RaceID", race.RaceID);
                        sqLiteCommand.Parameters.AddWithValue("@WealthAmount", wealthHistory.WealthAmount);
                        sqLiteCommand.Parameters.AddWithValue("@IncrementTime", wealthHistory.IncrementTime);
                        sqLiteCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1429);
        }
    }
}