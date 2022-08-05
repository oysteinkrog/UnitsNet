//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The heat transfer coefficient or film coefficient, or film effectiveness, in thermodynamics and in mechanics is the proportionality constant between the heat flux and the thermodynamic driving force for the flow of heat (i.e., the temperature difference, ΔT)
    /// </summary>
    public struct  HeatTransferCoefficient
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly HeatTransferCoefficientUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public HeatTransferCoefficientUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public HeatTransferCoefficient(double value, HeatTransferCoefficientUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static HeatTransferCoefficientUnit BaseUnit { get; } = HeatTransferCoefficientUnit.WattPerSquareMeterKelvin;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static HeatTransferCoefficient MaxValue { get; } = new HeatTransferCoefficient(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static HeatTransferCoefficient MinValue { get; } = new HeatTransferCoefficient(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static HeatTransferCoefficient Zero { get; } = new HeatTransferCoefficient(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit"/>
        /// </summary>
        public double BtusPerSquareFootDegreeFahrenheit => As(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatTransferCoefficientUnit.WattPerSquareMeterCelsius"/>
        /// </summary>
        public double WattsPerSquareMeterCelsius => As(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="HeatTransferCoefficientUnit.WattPerSquareMeterKelvin"/>
        /// </summary>
        public double WattsPerSquareMeterKelvin => As(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="HeatTransferCoefficient"/> from <see cref="HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatTransferCoefficient FromBtusPerSquareFootDegreeFahrenheit(double btuspersquarefootdegreefahrenheit) => new HeatTransferCoefficient(btuspersquarefootdegreefahrenheit, HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit);

        /// <summary>
        ///     Creates a <see cref="HeatTransferCoefficient"/> from <see cref="HeatTransferCoefficientUnit.WattPerSquareMeterCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatTransferCoefficient FromWattsPerSquareMeterCelsius(double wattspersquaremetercelsius) => new HeatTransferCoefficient(wattspersquaremetercelsius, HeatTransferCoefficientUnit.WattPerSquareMeterCelsius);

        /// <summary>
        ///     Creates a <see cref="HeatTransferCoefficient"/> from <see cref="HeatTransferCoefficientUnit.WattPerSquareMeterKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static HeatTransferCoefficient FromWattsPerSquareMeterKelvin(double wattspersquaremeterkelvin) => new HeatTransferCoefficient(wattspersquaremeterkelvin, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="HeatTransferCoefficientUnit" /> to <see cref="HeatTransferCoefficient" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>HeatTransferCoefficient unit value.</returns>
        public static HeatTransferCoefficient From(double value, HeatTransferCoefficientUnit fromUnit)
        {
            return new HeatTransferCoefficient(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(HeatTransferCoefficientUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public HeatTransferCoefficient ToUnit(HeatTransferCoefficientUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new HeatTransferCoefficient(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit => _value * 5.6782633411134878,
                HeatTransferCoefficientUnit.WattPerSquareMeterCelsius => _value,
                HeatTransferCoefficientUnit.WattPerSquareMeterKelvin => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(HeatTransferCoefficientUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit => baseUnitValue / 5.6782633411134878,
                HeatTransferCoefficientUnit.WattPerSquareMeterCelsius => baseUnitValue,
                HeatTransferCoefficientUnit.WattPerSquareMeterKelvin => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

