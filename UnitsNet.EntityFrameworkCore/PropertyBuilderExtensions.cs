using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitsNet.Units;

namespace UnitsNet.EntityFrameworkCore
{
    public static class PropertyBuilderExtensions
    {
        public static void HasConversion(this PropertyBuilder<Acceleration> propertyBuilder, AccelerationUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Acceleration(v, unit));

        public static void HasConversion(this PropertyBuilder<AmountOfSubstance> propertyBuilder, AmountOfSubstanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new AmountOfSubstance(v, unit));

        public static void HasConversion(this PropertyBuilder<AmplitudeRatio> propertyBuilder, AmplitudeRatioUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new AmplitudeRatio(v, unit));

        public static void HasConversion(this PropertyBuilder<Angle> propertyBuilder, AngleUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Angle(v, unit));

        public static void HasConversion(this PropertyBuilder<ApparentEnergy> propertyBuilder, ApparentEnergyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ApparentEnergy(v, unit));

        public static void HasConversion(this PropertyBuilder<ApparentPower> propertyBuilder, ApparentPowerUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ApparentPower(v, unit));

        public static void HasConversion(this PropertyBuilder<Area> propertyBuilder, AreaUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Area(v, unit));

        public static void HasConversion(this PropertyBuilder<AreaDensity> propertyBuilder, AreaDensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new AreaDensity(v, unit));

        public static void HasConversion(this PropertyBuilder<AreaMomentOfInertia> propertyBuilder, AreaMomentOfInertiaUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new AreaMomentOfInertia(v, unit));

        public static void HasConversion(this PropertyBuilder<BitRate> propertyBuilder, BitRateUnit unit) =>
            propertyBuilder.HasConversion(v => (decimal)v.As(unit), v => new BitRate(v, unit));

        public static void HasConversion(this PropertyBuilder<BrakeSpecificFuelConsumption> propertyBuilder, BrakeSpecificFuelConsumptionUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new BrakeSpecificFuelConsumption(v, unit));

        public static void HasConversion(this PropertyBuilder<Capacitance> propertyBuilder, CapacitanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Capacitance(v, unit));

        public static void HasConversion(this PropertyBuilder<CoefficientOfThermalExpansion> propertyBuilder, CoefficientOfThermalExpansionUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new CoefficientOfThermalExpansion(v, unit));

        public static void HasConversion(this PropertyBuilder<Density> propertyBuilder, DensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Density(v, unit));

        public static void HasConversion(this PropertyBuilder<Duration> propertyBuilder, DurationUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Duration(v, unit));

        public static void HasConversion(this PropertyBuilder<DynamicViscosity> propertyBuilder, DynamicViscosityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new DynamicViscosity(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricAdmittance> propertyBuilder, ElectricAdmittanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricAdmittance(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricCharge> propertyBuilder, ElectricChargeUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricCharge(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricChargeDensity> propertyBuilder, ElectricChargeDensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricChargeDensity(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricConductance> propertyBuilder, ElectricConductanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricConductance(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricConductivity> propertyBuilder, ElectricConductivityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricConductivity(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricCurrent> propertyBuilder, ElectricCurrentUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricCurrent(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricCurrentDensity> propertyBuilder, ElectricCurrentDensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricCurrentDensity(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricCurrentGradient> propertyBuilder, ElectricCurrentGradientUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricCurrentGradient(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricField> propertyBuilder, ElectricFieldUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricField(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricInductance> propertyBuilder, ElectricInductanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricInductance(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricPotential> propertyBuilder, ElectricPotentialUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricPotential(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricPotentialAc> propertyBuilder, ElectricPotentialAcUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricPotentialAc(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricPotentialDc> propertyBuilder, ElectricPotentialDcUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricPotentialDc(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricResistance> propertyBuilder, ElectricResistanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricResistance(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricResistivity> propertyBuilder, ElectricResistivityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricResistivity(v, unit));

        public static void HasConversion(this PropertyBuilder<ElectricSurfaceChargeDensity> propertyBuilder, ElectricSurfaceChargeDensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ElectricSurfaceChargeDensity(v, unit));

        public static void HasConversion(this PropertyBuilder<Energy> propertyBuilder, EnergyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Energy(v, unit));

        public static void HasConversion(this PropertyBuilder<Entropy> propertyBuilder, EntropyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Entropy(v, unit));

        public static void HasConversion(this PropertyBuilder<Force> propertyBuilder, ForceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Force(v, unit));

        public static void HasConversion(this PropertyBuilder<ForceChangeRate> propertyBuilder, ForceChangeRateUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ForceChangeRate(v, unit));

        public static void HasConversion(this PropertyBuilder<ForcePerLength> propertyBuilder, ForcePerLengthUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ForcePerLength(v, unit));

        public static void HasConversion(this PropertyBuilder<Frequency> propertyBuilder, FrequencyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Frequency(v, unit));

        public static void HasConversion(this PropertyBuilder<HeatFlux> propertyBuilder, HeatFluxUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new HeatFlux(v, unit));

        public static void HasConversion(this PropertyBuilder<HeatTransferCoefficient> propertyBuilder, HeatTransferCoefficientUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new HeatTransferCoefficient(v, unit));

        public static void HasConversion(this PropertyBuilder<Illuminance> propertyBuilder, IlluminanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Illuminance(v, unit));

        public static void HasConversion(this PropertyBuilder<Information> propertyBuilder, InformationUnit unit) =>
            propertyBuilder.HasConversion(v => (decimal)v.As(unit), v => new Information(v, unit));

        public static void HasConversion(this PropertyBuilder<Irradiance> propertyBuilder, IrradianceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Irradiance(v, unit));

        public static void HasConversion(this PropertyBuilder<Irradiation> propertyBuilder, IrradiationUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Irradiation(v, unit));

        public static void HasConversion(this PropertyBuilder<KinematicViscosity> propertyBuilder, KinematicViscosityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new KinematicViscosity(v, unit));

        public static void HasConversion(this PropertyBuilder<LapseRate> propertyBuilder, LapseRateUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new LapseRate(v, unit));

        public static void HasConversion(this PropertyBuilder<Length> propertyBuilder, LengthUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Length(v, unit));

        public static void HasConversion(this PropertyBuilder<Level> propertyBuilder, LevelUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Level(v, unit));

        public static void HasConversion(this PropertyBuilder<LinearDensity> propertyBuilder, LinearDensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new LinearDensity(v, unit));

        public static void HasConversion(this PropertyBuilder<LuminousFlux> propertyBuilder, LuminousFluxUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new LuminousFlux(v, unit));

        public static void HasConversion(this PropertyBuilder<LuminousIntensity> propertyBuilder, LuminousIntensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new LuminousIntensity(v, unit));

        public static void HasConversion(this PropertyBuilder<MagneticField> propertyBuilder, MagneticFieldUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MagneticField(v, unit));

        public static void HasConversion(this PropertyBuilder<MagneticFlux> propertyBuilder, MagneticFluxUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MagneticFlux(v, unit));

        public static void HasConversion(this PropertyBuilder<Magnetization> propertyBuilder, MagnetizationUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Magnetization(v, unit));

        public static void HasConversion(this PropertyBuilder<Mass> propertyBuilder, MassUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Mass(v, unit));

        public static void HasConversion(this PropertyBuilder<MassConcentration> propertyBuilder, MassConcentrationUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MassConcentration(v, unit));

        public static void HasConversion(this PropertyBuilder<MassFlow> propertyBuilder, MassFlowUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MassFlow(v, unit));

        public static void HasConversion(this PropertyBuilder<MassFlux> propertyBuilder, MassFluxUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MassFlux(v, unit));

        public static void HasConversion(this PropertyBuilder<MassFraction> propertyBuilder, MassFractionUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MassFraction(v, unit));

        public static void HasConversion(this PropertyBuilder<MassMomentOfInertia> propertyBuilder, MassMomentOfInertiaUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MassMomentOfInertia(v, unit));

        public static void HasConversion(this PropertyBuilder<MolarEnergy> propertyBuilder, MolarEnergyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MolarEnergy(v, unit));

        public static void HasConversion(this PropertyBuilder<MolarEntropy> propertyBuilder, MolarEntropyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MolarEntropy(v, unit));

        public static void HasConversion(this PropertyBuilder<MolarMass> propertyBuilder, MolarMassUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new MolarMass(v, unit));

        public static void HasConversion(this PropertyBuilder<Molarity> propertyBuilder, MolarityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Molarity(v, unit));

        public static void HasConversion(this PropertyBuilder<Permeability> propertyBuilder, PermeabilityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Permeability(v, unit));

        public static void HasConversion(this PropertyBuilder<Permittivity> propertyBuilder, PermittivityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Permittivity(v, unit));

        public static void HasConversion(this PropertyBuilder<Power> propertyBuilder, PowerUnit unit) =>
            propertyBuilder.HasConversion(v => (decimal)v.As(unit), v => new Power(v, unit));

        public static void HasConversion(this PropertyBuilder<PowerDensity> propertyBuilder, PowerDensityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new PowerDensity(v, unit));

        public static void HasConversion(this PropertyBuilder<PowerRatio> propertyBuilder, PowerRatioUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new PowerRatio(v, unit));

        public static void HasConversion(this PropertyBuilder<Pressure> propertyBuilder, PressureUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Pressure(v, unit));

        public static void HasConversion(this PropertyBuilder<PressureChangeRate> propertyBuilder, PressureChangeRateUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new PressureChangeRate(v, unit));

        public static void HasConversion(this PropertyBuilder<Ratio> propertyBuilder, RatioUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Ratio(v, unit));

        public static void HasConversion(this PropertyBuilder<ReactiveEnergy> propertyBuilder, ReactiveEnergyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ReactiveEnergy(v, unit));

        public static void HasConversion(this PropertyBuilder<ReactivePower> propertyBuilder, ReactivePowerUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ReactivePower(v, unit));

        public static void HasConversion(this PropertyBuilder<RotationalAcceleration> propertyBuilder, RotationalAccelerationUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new RotationalAcceleration(v, unit));

        public static void HasConversion(this PropertyBuilder<RotationalSpeed> propertyBuilder, RotationalSpeedUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new RotationalSpeed(v, unit));

        public static void HasConversion(this PropertyBuilder<RotationalStiffness> propertyBuilder, RotationalStiffnessUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new RotationalStiffness(v, unit));

        public static void HasConversion(this PropertyBuilder<RotationalStiffnessPerLength> propertyBuilder, RotationalStiffnessPerLengthUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new RotationalStiffnessPerLength(v, unit));

        public static void HasConversion(this PropertyBuilder<SolidAngle> propertyBuilder, SolidAngleUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new SolidAngle(v, unit));

        public static void HasConversion(this PropertyBuilder<SpecificEnergy> propertyBuilder, SpecificEnergyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new SpecificEnergy(v, unit));

        public static void HasConversion(this PropertyBuilder<SpecificEntropy> propertyBuilder, SpecificEntropyUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new SpecificEntropy(v, unit));

        public static void HasConversion(this PropertyBuilder<SpecificVolume> propertyBuilder, SpecificVolumeUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new SpecificVolume(v, unit));

        public static void HasConversion(this PropertyBuilder<SpecificWeight> propertyBuilder, SpecificWeightUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new SpecificWeight(v, unit));

        public static void HasConversion(this PropertyBuilder<Speed> propertyBuilder, SpeedUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Speed(v, unit));

        public static void HasConversion(this PropertyBuilder<Temperature> propertyBuilder, TemperatureUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Temperature(v, unit));

        public static void HasConversion(this PropertyBuilder<TemperatureChangeRate> propertyBuilder, TemperatureChangeRateUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new TemperatureChangeRate(v, unit));

        public static void HasConversion(this PropertyBuilder<TemperatureDelta> propertyBuilder, TemperatureDeltaUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new TemperatureDelta(v, unit));

        public static void HasConversion(this PropertyBuilder<ThermalConductivity> propertyBuilder, ThermalConductivityUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ThermalConductivity(v, unit));

        public static void HasConversion(this PropertyBuilder<ThermalResistance> propertyBuilder, ThermalResistanceUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new ThermalResistance(v, unit));

        public static void HasConversion(this PropertyBuilder<Torque> propertyBuilder, TorqueUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Torque(v, unit));

        public static void HasConversion(this PropertyBuilder<VitaminA> propertyBuilder, VitaminAUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new VitaminA(v, unit));

        public static void HasConversion(this PropertyBuilder<Volume> propertyBuilder, VolumeUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new Volume(v, unit));

        public static void HasConversion(this PropertyBuilder<VolumeConcentration> propertyBuilder, VolumeConcentrationUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new VolumeConcentration(v, unit));

        public static void HasConversion(this PropertyBuilder<VolumeFlow> propertyBuilder, VolumeFlowUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new VolumeFlow(v, unit));

        public static void HasConversion(this PropertyBuilder<VolumePerLength> propertyBuilder, VolumePerLengthUnit unit) =>
            propertyBuilder.HasConversion(v => v.As(unit), v => new VolumePerLength(v, unit));
    }
}