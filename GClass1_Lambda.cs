#nullable disable
public partial class SystemBodyData
{
    private sealed class Class308
    {
        public AtmosphericGasDefinition gclass223_0;

        internal bool method_0(GClass224 gclass224_0)
        {
            return gclass224_0.gclass223_0 == this.gclass223_0;
        }
    }


    private sealed class Class309
    {
        public SystemBodyData gclass1_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PlanetaryTerrainDefinition gclass99_0)
        {
            return this.double_0 >= gclass99_0.MinOxygen && this.double_1 >= gclass99_0.MinTemperature &&
                   this.double_1 <= gclass99_0.MaxTemperature && this.gclass1_0.HydroExtent >= gclass99_0.MinimumHydro &&
                   this.gclass1_0.HydroExtent <= gclass99_0.MaximumHydro &&
                   this.gclass1_0.TectonicActivity >= gclass99_0.MinTectonics &&
                   this.gclass1_0.TectonicActivity <= gclass99_0.MaximumTectonics &&
                   gclass99_0.DominantTerrainType != PlanetDominantTerrain.const_0 &&
                   gclass99_0.DominantTerrainType != PlanetDominantTerrain.const_2 &&
                   gclass99_0.DominantTerrainType != PlanetDominantTerrain.const_12;
        }

        internal bool method_1(PlanetaryTerrainDefinition gclass99_0)
        {
            return this.double_0 >= gclass99_0.MinOxygen && this.double_1 >= gclass99_0.MinTemperature &&
                   this.double_1 <= gclass99_0.MaxTemperature && this.gclass1_0.HydroExtent >= gclass99_0.MinimumHydro &&
                   this.gclass1_0.HydroExtent <= gclass99_0.MaximumHydro &&
                   this.gclass1_0.TectonicActivity >= gclass99_0.MinTectonics &&
                   this.gclass1_0.TectonicActivity <= gclass99_0.MaximumTectonics;
        }
    }


    private sealed class Class310
    {
        public SystemBodyData gclass1_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PlanetaryTerrainDefinition gclass99_0)
        {
            return this.double_0 >= gclass99_0.MinOxygen && this.double_1 >= gclass99_0.MinTemperature &&
                   this.double_1 <= gclass99_0.MaxTemperature && this.gclass1_0.HydroExtent >= gclass99_0.MinimumHydro &&
                   this.gclass1_0.HydroExtent <= gclass99_0.MaximumHydro;
        }
    }


    private sealed class Class311
    {
        public SystemBodyData gclass1_0;
        public double double_0;
        public double double_1;
        public double double_2;
        public double double_3;

        internal bool method_0(PlanetaryTerrainDefinition gclass99_0)
        {
            return this.double_0 >= gclass99_0.MinOxygen && this.double_1 >= gclass99_0.MinTemperature &&
                   this.double_2 <= gclass99_0.MaxTemperature && this.gclass1_0.HydroExtent >= gclass99_0.MinimumHydro &&
                   this.gclass1_0.HydroExtent <= gclass99_0.MaximumHydro &&
                   this.gclass1_0.TectonicActivity >= gclass99_0.MinTectonics &&
                   this.gclass1_0.TectonicActivity <= gclass99_0.MaximumTectonics && this.double_3 >= gclass99_0.MinTempRange;
        }
    }


    private sealed class Class312
    {
        public double double_0;
        public double double_1;
        public double double_2;
        public double double_3;
        public SystemBodyData gclass1_0;

        internal bool method_0(PlanetaryTerrainDefinition gclass99_0)
        {
            return this.double_0 >= gclass99_0.MinOxygen && this.double_1 >= gclass99_0.MinTemperature &&
                   this.double_2 <= gclass99_0.MaxTemperature && this.gclass1_0.HydroExtent >= gclass99_0.MinimumHydro &&
                   this.gclass1_0.HydroExtent <= gclass99_0.MaximumHydro &&
                   this.gclass1_0.TectonicActivity >= gclass99_0.MinTectonics &&
                   this.gclass1_0.TectonicActivity <= gclass99_0.MaximumTectonics &&
                   this.double_3 >= gclass99_0.MinTempRange && gclass99_0.BaseTerrainType == this.gclass1_0.DominantTerrain.BaseTerrainType &&
                   gclass99_0.DominantTerrainType != this.gclass1_0.DominantTerrain.DominantTerrainType;
        }

        internal bool method_1(PlanetaryTerrainDefinition gclass99_0)
        {
            return this.double_0 >= gclass99_0.MinOxygen && this.double_1 >= gclass99_0.MinTemperature &&
                   this.double_2 <= gclass99_0.MaxTemperature && this.gclass1_0.HydroExtent >= gclass99_0.MinimumHydro &&
                   this.gclass1_0.HydroExtent <= gclass99_0.MaximumHydro &&
                   this.gclass1_0.TectonicActivity >= gclass99_0.MinTectonics &&
                   this.gclass1_0.TectonicActivity <= gclass99_0.MaximumTectonics &&
                   this.double_3 >= gclass99_0.MinTempRange && gclass99_0.BaseTerrainType == this.gclass1_0.DominantTerrain.BaseTerrainType;
        }
    }


    private sealed class Class313
    {
        public GameRace gclass21_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(GClass215 gclass215_0)
        {
            return gclass215_0.gclass21_0 == this.gclass21_0 && gclass215_0.gclass1_0 == this.gclass1_0;
        }
    }


    private sealed class Class314
    {
        public GameRace gclass21_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(GClass215 gclass215_0)
        {
            return gclass215_0.gclass21_0 == this.gclass21_0 && gclass215_0.gclass1_0 == this.gclass1_0;
        }
    }


    private sealed class Class315
    {
        public GClass194 gclass194_0;

        internal bool method_0(GClass224 gclass224_0)
        {
            return gclass224_0.gclass223_0.Dangerous > 0 && gclass224_0.gclass223_0 != this.gclass194_0.gclass223_0;
        }
    }


    private sealed class Class316
    {
        public AtmosphericGasDefinition gclass223_0;

        internal bool method_0(GClass224 gclass224_0)
        {
            return gclass224_0.gclass223_0 == this.gclass223_0;
        }
    }


    private sealed class Class317
    {
        public GameRace gclass21_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0 && gclass146_0.SystemBodyData == this.gclass1_0;
        }
    }


    private sealed class Class318
    {
        public RacialSystemSurvey gclass202_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass202_0.Race && gclass146_0.SystemBodyData == this.gclass1_0;
        }
    }


    private sealed class Class319
    {
        public GameRace gclass21_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(GClass215 gclass215_0)
        {
            return gclass215_0.gclass21_0 == this.gclass21_0 && gclass215_0.gclass1_0 == this.gclass1_0;
        }
    }

    private sealed class Class320
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass218 gclass218_0)
        {
            return gclass218_0.gclass21_0 == this.gclass21_0;
        }
    }


    private sealed class Class321
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass218 gclass218_0)
        {
            return gclass218_0.gclass21_0 == this.gclass21_0;
        }
    }
}