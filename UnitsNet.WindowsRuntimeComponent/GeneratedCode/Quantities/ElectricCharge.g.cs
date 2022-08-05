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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Electric charge is the physical property of matter that causes it to experience a force when placed in an electromagnetic field.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electric_charge
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class ElectricCharge : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricChargeUnit? _unit;

        static ElectricCharge()
        {
            BaseDimensions = new BaseDimensions(0, 0, 1, 1, 0, 0, 0);
            BaseUnit = ElectricChargeUnit.Coulomb;
            MaxValue = new ElectricCharge(double.MaxValue, BaseUnit);
            MinValue = new ElectricCharge(double.MinValue, BaseUnit);
            QuantityType = QuantityType.ElectricCharge;
            Units = Enum.GetValues(typeof(ElectricChargeUnit)).Cast<ElectricChargeUnit>().Except(new ElectricChargeUnit[]{ ElectricChargeUnit.Undefined }).ToArray();
            Zero = new ElectricCharge(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.ElectricCharge, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit Coulomb.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public ElectricCharge()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private ElectricCharge(double value, ElectricChargeUnit unit)
        {
            if (unit == ElectricChargeUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of ElectricCharge, which is Coulomb. All conversions go via this value.
        /// </summary>
        public static ElectricChargeUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of ElectricCharge
        /// </summary>
        public static ElectricCharge MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of ElectricCharge
        /// </summary>
        public static ElectricCharge MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the ElectricCharge quantity.
        /// </summary>
        public static ElectricChargeUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Coulomb.
        /// </summary>
        public static ElectricCharge Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public ElectricChargeUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => ElectricCharge.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ElectricCharge.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.AmpereHour"/>
        /// </summary>
        public double AmpereHours => As(ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Coulomb"/>
        /// </summary>
        public double Coulombs => As(ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.KiloampereHour"/>
        /// </summary>
        public double KiloampereHours => As(ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.MegaampereHour"/>
        /// </summary>
        public double MegaampereHours => As(ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.MilliampereHour"/>
        /// </summary>
        public double MilliampereHours => As(ElectricChargeUnit.MilliampereHour);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(ElectricChargeUnit.AmpereHour, new CultureInfo("en-US"), false, true, new string[]{"A-h", "Ah"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ElectricChargeUnit.Coulomb, new CultureInfo("en-US"), false, true, new string[]{"C"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ElectricChargeUnit.KiloampereHour, new CultureInfo("en-US"), false, true, new string[]{"kA-h", "kAh"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ElectricChargeUnit.MegaampereHour, new CultureInfo("en-US"), false, true, new string[]{"MA-h", "MAh"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ElectricChargeUnit.MilliampereHour, new CultureInfo("en-US"), false, true, new string[]{"mA-h", "mAh"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ElectricChargeUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(ElectricChargeUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.AmpereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCharge FromAmpereHours(double amperehours)
        {
            double value = (double) amperehours;
            return new ElectricCharge(value, ElectricChargeUnit.AmpereHour);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Coulomb"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCharge FromCoulombs(double coulombs)
        {
            double value = (double) coulombs;
            return new ElectricCharge(value, ElectricChargeUnit.Coulomb);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.KiloampereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCharge FromKiloampereHours(double kiloamperehours)
        {
            double value = (double) kiloamperehours;
            return new ElectricCharge(value, ElectricChargeUnit.KiloampereHour);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.MegaampereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCharge FromMegaampereHours(double megaamperehours)
        {
            double value = (double) megaamperehours;
            return new ElectricCharge(value, ElectricChargeUnit.MegaampereHour);
        }

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.MilliampereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCharge FromMilliampereHours(double milliamperehours)
        {
            double value = (double) milliamperehours;
            return new ElectricCharge(value, ElectricChargeUnit.MilliampereHour);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricChargeUnit" /> to <see cref="ElectricCharge" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCharge unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static ElectricCharge From(double value, ElectricChargeUnit fromUnit)
        {
            return new ElectricCharge((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ElectricCharge Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static ElectricCharge Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<ElectricCharge, ElectricChargeUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ElectricCharge result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out ElectricCharge result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<ElectricCharge, ElectricChargeUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ElectricChargeUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static ElectricChargeUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<ElectricChargeUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out ElectricChargeUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out ElectricChargeUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<ElectricChargeUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is ElectricCharge objElectricCharge)) throw new ArgumentException("Expected type ElectricCharge.", nameof(obj));

            return CompareTo(objElectricCharge);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(ElectricCharge other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is ElectricCharge objElectricCharge))
                return false;

            return Equals(objElectricCharge);
        }

        public bool Equals(ElectricCharge other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another ElectricCharge within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(ElectricCharge other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current ElectricCharge.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((ElectricChargeUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricChargeUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this ElectricCharge to another ElectricCharge with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A ElectricCharge with the specified unit.</returns>
        public ElectricCharge ToUnit(ElectricChargeUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new ElectricCharge(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case ElectricChargeUnit.AmpereHour: return _value / 2.77777777777e-4;
                case ElectricChargeUnit.Coulomb: return _value;
                case ElectricChargeUnit.KiloampereHour: return (_value / 2.77777777777e-4) * 1e3d;
                case ElectricChargeUnit.MegaampereHour: return (_value / 2.77777777777e-4) * 1e6d;
                case ElectricChargeUnit.MilliampereHour: return (_value / 2.77777777777e-4) * 1e-3d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(ElectricChargeUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case ElectricChargeUnit.AmpereHour: return baseUnitValue * 2.77777777777e-4;
                case ElectricChargeUnit.Coulomb: return baseUnitValue;
                case ElectricChargeUnit.KiloampereHour: return (baseUnitValue * 2.77777777777e-4) / 1e3d;
                case ElectricChargeUnit.MegaampereHour: return (baseUnitValue * 2.77777777777e-4) / 1e6d;
                case ElectricChargeUnit.MilliampereHour: return (baseUnitValue * 2.77777777777e-4) / 1e-3d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
