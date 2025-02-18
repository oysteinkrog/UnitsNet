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
    ///     In geometry, an angle is the figure formed by two rays, called the sides of the angle, sharing a common endpoint, called the vertex of the angle.
    /// </summary>
    public struct  Angle
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AngleUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AngleUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Angle(double value, AngleUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AngleUnit BaseUnit { get; } = AngleUnit.Degree;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Angle MaxValue { get; } = new Angle(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Angle MinValue { get; } = new Angle(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Angle Zero { get; } = new Angle(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Arcminute"/>
        /// </summary>
        public double Arcminutes => As(AngleUnit.Arcminute);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Arcsecond"/>
        /// </summary>
        public double Arcseconds => As(AngleUnit.Arcsecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Centiradian"/>
        /// </summary>
        public double Centiradians => As(AngleUnit.Centiradian);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Deciradian"/>
        /// </summary>
        public double Deciradians => As(AngleUnit.Deciradian);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Degree"/>
        /// </summary>
        public double Degrees => As(AngleUnit.Degree);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Gradian"/>
        /// </summary>
        public double Gradians => As(AngleUnit.Gradian);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Microdegree"/>
        /// </summary>
        public double Microdegrees => As(AngleUnit.Microdegree);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Microradian"/>
        /// </summary>
        public double Microradians => As(AngleUnit.Microradian);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Millidegree"/>
        /// </summary>
        public double Millidegrees => As(AngleUnit.Millidegree);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Milliradian"/>
        /// </summary>
        public double Milliradians => As(AngleUnit.Milliradian);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Nanodegree"/>
        /// </summary>
        public double Nanodegrees => As(AngleUnit.Nanodegree);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Nanoradian"/>
        /// </summary>
        public double Nanoradians => As(AngleUnit.Nanoradian);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.NatoMil"/>
        /// </summary>
        public double NatoMils => As(AngleUnit.NatoMil);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Radian"/>
        /// </summary>
        public double Radians => As(AngleUnit.Radian);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Revolution"/>
        /// </summary>
        public double Revolutions => As(AngleUnit.Revolution);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AngleUnit.Tilt"/>
        /// </summary>
        public double Tilt => As(AngleUnit.Tilt);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Arcminute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcminutes(double arcminutes) => new Angle(arcminutes, AngleUnit.Arcminute);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Arcsecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcseconds(double arcseconds) => new Angle(arcseconds, AngleUnit.Arcsecond);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Centiradian"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromCentiradians(double centiradians) => new Angle(centiradians, AngleUnit.Centiradian);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Deciradian"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDeciradians(double deciradians) => new Angle(deciradians, AngleUnit.Deciradian);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Degree"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDegrees(double degrees) => new Angle(degrees, AngleUnit.Degree);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Gradian"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromGradians(double gradians) => new Angle(gradians, AngleUnit.Gradian);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Microdegree"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicrodegrees(double microdegrees) => new Angle(microdegrees, AngleUnit.Microdegree);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Microradian"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicroradians(double microradians) => new Angle(microradians, AngleUnit.Microradian);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Millidegree"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMillidegrees(double millidegrees) => new Angle(millidegrees, AngleUnit.Millidegree);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Milliradian"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMilliradians(double milliradians) => new Angle(milliradians, AngleUnit.Milliradian);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Nanodegree"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanodegrees(double nanodegrees) => new Angle(nanodegrees, AngleUnit.Nanodegree);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Nanoradian"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanoradians(double nanoradians) => new Angle(nanoradians, AngleUnit.Nanoradian);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.NatoMil"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNatoMils(double natomils) => new Angle(natomils, AngleUnit.NatoMil);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Radian"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRadians(double radians) => new Angle(radians, AngleUnit.Radian);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Revolution"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRevolutions(double revolutions) => new Angle(revolutions, AngleUnit.Revolution);

        /// <summary>
        ///     Creates a <see cref="Angle"/> from <see cref="AngleUnit.Tilt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromTilt(double tilt) => new Angle(tilt, AngleUnit.Tilt);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AngleUnit" /> to <see cref="Angle" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Angle unit value.</returns>
        public static Angle From(double value, AngleUnit fromUnit)
        {
            return new Angle(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(AngleUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public Angle ToUnit(AngleUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Angle(convertedValue, unit);
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
                        AngleUnit.Arcminute => _value / 60,
                        AngleUnit.Arcsecond => _value / 3600,
                        AngleUnit.Centiradian => (_value * 180 / 3.1415926535897931) * 1e-2d,
                        AngleUnit.Deciradian => (_value * 180 / 3.1415926535897931) * 1e-1d,
                        AngleUnit.Degree => _value,
                        AngleUnit.Gradian => _value * 0.9,
                        AngleUnit.Microdegree => (_value) * 1e-6d,
                        AngleUnit.Microradian => (_value * 180 / 3.1415926535897931) * 1e-6d,
                        AngleUnit.Millidegree => (_value) * 1e-3d,
                        AngleUnit.Milliradian => (_value * 180 / 3.1415926535897931) * 1e-3d,
                        AngleUnit.Nanodegree => (_value) * 1e-9d,
                        AngleUnit.Nanoradian => (_value * 180 / 3.1415926535897931) * 1e-9d,
                        AngleUnit.NatoMil => _value * 9 / 160,
                        AngleUnit.Radian => _value * 180 / 3.1415926535897931,
                        AngleUnit.Revolution => _value * 360,
                        AngleUnit.Tilt => Math.Asin(_value) * 180 / 3.1415926535897931,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(AngleUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        AngleUnit.Arcminute => baseUnitValue * 60,
                        AngleUnit.Arcsecond => baseUnitValue * 3600,
                        AngleUnit.Centiradian => (baseUnitValue / 180 * 3.1415926535897931) / 1e-2d,
                        AngleUnit.Deciradian => (baseUnitValue / 180 * 3.1415926535897931) / 1e-1d,
                        AngleUnit.Degree => baseUnitValue,
                        AngleUnit.Gradian => baseUnitValue / 0.9,
                        AngleUnit.Microdegree => (baseUnitValue) / 1e-6d,
                        AngleUnit.Microradian => (baseUnitValue / 180 * 3.1415926535897931) / 1e-6d,
                        AngleUnit.Millidegree => (baseUnitValue) / 1e-3d,
                        AngleUnit.Milliradian => (baseUnitValue / 180 * 3.1415926535897931) / 1e-3d,
                        AngleUnit.Nanodegree => (baseUnitValue) / 1e-9d,
                        AngleUnit.Nanoradian => (baseUnitValue / 180 * 3.1415926535897931) / 1e-9d,
                        AngleUnit.NatoMil => baseUnitValue * 160 / 9,
                        AngleUnit.Radian => baseUnitValue / 180 * 3.1415926535897931,
                        AngleUnit.Revolution => baseUnitValue / 360,
                        AngleUnit.Tilt => Math.Sin(baseUnitValue / 180 * 3.1415926535897931),
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

