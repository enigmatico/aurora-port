using System;
using System.Runtime.CompilerServices;
using Aurora;

namespace aurora;

public enum LocalizedText
{
    StarTypeRangeIDNotFoundErrMsg,
    LuminosityKeyCountErrMsg,
    Asteroids,
    Comets,
    GravityTooLowForHomeworld,
    SurfaceTemperatureTooLowForHomeworld,
    SurfaceTemperatureTooHighForHomeworld,
    InsufficientWaterForHomeworld,
    DangerousAtmosphereForHomeworld,
    InsufficientOxygenForHomeworld,
    TooMuchOxygenForHomeworld,
    CanRetainAtmoSphereNo,
    CanRetainAtmoSphereYes,
    TimeSpanWeek,
    TimeSpanMonth,
    TimeSpanQuarter,
    TimeSpanYear,
    TimeSpan5Y,
    TimeSpan25Y,
    TimeSpan100Y,
    SystemBodyPeriod,
    SpeciesNameHuman,
    SpeciesNamePrecursor,
    SpeciesNameStarSwarm,
    SpeciesNameRakhas,
    SpeciesNameEldar,
    ClimateChangeEventMsg,
    IceSheetMeltEventMsg,
    IceSheetFrozenEventMsg,
    VenusianAtmosphere,
    VaporFormWater, // used on special occasion
    GasNone,
    GasHydrogen,
    GasHelium,
    GasMethane,
    GasAmmonia,
    GasWaterVapor,
    GasNeon,
    GasNitrogen,
    GasCarbonMonoxide,
    GasNitrogenOxide,
    GasOxygen,
    GasHydrogenSulfide,
    GasArgon,
    GasCarbonDioxide,
    GasNitrogenDioxide,
    GasSulfurDioxide,
    GasChlorine,
    GasFluorine,
    GasBromine,
    GasIodine,
    GasAestusium,
    GasFrigusium,
    TidalLockYes,
    TidalLockYesMoon,
    NameLiteral,
    ColonyCost,
    OrbitalDistance,
    Temperature,
    MaxColonyCost,
    BodyType,
    Diameter,
    CurrentDistance,
    Perihelion,
    Aphelion,
    Eccentricity,
    Inclination,
    Gravity,
    Atmosphere,
    AtmosphericPressure,
    Hydrosphere,
    HydroExtent,
    Year,
    Day,
    SurfaceTemperature,
    Tectonics,
    Mass,
    Density,
    TidalLockLiteral,
    GreenhouseFactor,
    AntiGHFactor, // 여기까지 했음
    Albedo,
    __tons,
    __Acc,
    NoSurvey,
    SurveyReportFormat,
    GasLiteral,
    GreenHouseGasPressure,
    AntiGreenHouseGasPressure,
    DustEffectiveAtm,
    AlbedoFactor,
}

public static class UITextHelper
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetText(this LocalizedText key)
    {
        return GetLocalizedStringFor(nameof(key));
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetLocalizedStringFor(LocalizedText key)
    {
        var stringKey = nameof(key);
        return GetLocalizedStringFor(stringKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetLocalizedStringFor(string key)
    {
        var result = UIText.ResourceManager.GetString(key);
        return string.IsNullOrEmpty(result) ? key : result;
    }

    public static string ToLocalizedString(this GasType gas)
    {
        string value = gas switch
        {
            GasType.None => GetLocalizedStringFor(LocalizedText.GasNone),
            GasType.WaterVapor => GetLocalizedStringFor(LocalizedText.GasWaterVapor),
            GasType.Hydrogen => GetLocalizedStringFor(LocalizedText.GasHydrogen),
            GasType.Helium => GetLocalizedStringFor(LocalizedText.GasHelium),
            GasType.Methane => GetLocalizedStringFor(LocalizedText.GasMethane),
            GasType.Ammonia => GetLocalizedStringFor(LocalizedText.GasAmmonia),
            GasType.Neon => GetLocalizedStringFor(LocalizedText.GasNeon),
            GasType.Nitrogen => GetLocalizedStringFor(LocalizedText.GasNitrogen),
            GasType.CarbonMonoxide => GetLocalizedStringFor(LocalizedText.GasCarbonMonoxide),
            GasType.NitrogenOxide => GetLocalizedStringFor(LocalizedText.GasNitrogenOxide),
            GasType.Oxygen => GetLocalizedStringFor(LocalizedText.GasOxygen),
            GasType.HydrogenSulfide => GetLocalizedStringFor(LocalizedText.GasHydrogenSulfide),
            GasType.Argon => GetLocalizedStringFor(LocalizedText.GasArgon),
            GasType.CarbonDioxide => GetLocalizedStringFor(LocalizedText.GasCarbonDioxide),
            GasType.NitrogenDioxide => GetLocalizedStringFor(LocalizedText.GasNitrogenDioxide),
            GasType.SulfurDioxide => GetLocalizedStringFor(LocalizedText.GasSulfurDioxide),
            GasType.Chlorine => GetLocalizedStringFor(LocalizedText.GasChlorine),
            GasType.Fluorine => GetLocalizedStringFor(LocalizedText.GasFluorine),
            GasType.Bromine => GetLocalizedStringFor(LocalizedText.GasBromine),
            GasType.Iodine => GetLocalizedStringFor(LocalizedText.GasIodine),
            GasType.Aestusium => GetLocalizedStringFor(LocalizedText.GasAestusium),
            GasType.Frigusium => GetLocalizedStringFor(LocalizedText.GasFrigusium),
            _ => "?"
        };
        return value;
    }
}