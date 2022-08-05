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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Permittivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PermittivityTestsBase : QuantityTestsBase
    {
        protected abstract double FaradsPerMeterInOneFaradPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double FaradsPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(PermittivityUnit unit)
        {
            return unit switch
            {
                PermittivityUnit.FaradPerMeter => (FaradsPerMeterInOneFaradPerMeter, FaradsPerMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { PermittivityUnit.FaradPerMeter },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permittivity((double)0.0, PermittivityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Permittivity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(PermittivityUnit.FaradPerMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permittivity(double.PositiveInfinity, PermittivityUnit.FaradPerMeter));
            Assert.Throws<ArgumentException>(() => new Permittivity(double.NegativeInfinity, PermittivityUnit.FaradPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permittivity(double.NaN, PermittivityUnit.FaradPerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Permittivity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Permittivity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Permittivity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Permittivity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Permittivity(1, PermittivityUnit.FaradPerMeter);

            QuantityInfo<PermittivityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Permittivity.Zero, quantityInfo.Zero);
            Assert.Equal("Permittivity", quantityInfo.Name);
            Assert.Equal(QuantityType.Permittivity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<PermittivityUnit>().Except(new[] {PermittivityUnit.Undefined}).OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void FaradPerMeterToPermittivityUnits()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(FaradsPerMeterInOneFaradPerMeter, faradpermeter.FaradsPerMeter, FaradsPerMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Permittivity.From(1, PermittivityUnit.FaradPerMeter);
            AssertEx.EqualTolerance(1, quantity00.FaradsPerMeter, FaradsPerMeterTolerance);
            Assert.Equal(PermittivityUnit.FaradPerMeter, quantity00.Unit);

        }

        [Fact]
        public void FromFaradsPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Permittivity.FromFaradsPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Permittivity.FromFaradsPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromFaradsPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Permittivity.FromFaradsPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var faradpermeter = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(FaradsPerMeterInOneFaradPerMeter, faradpermeter.As(PermittivityUnit.FaradPerMeter), FaradsPerMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Permittivity(value: 1, unit: Permittivity.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = Permittivity.Parse("1 F/m", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.FaradsPerMeter, FaradsPerMeterTolerance);
                Assert.Equal(PermittivityUnit.FaradPerMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(Permittivity.TryParse("1 F/m", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.FaradsPerMeter, FaradsPerMeterTolerance);
                Assert.Equal(PermittivityUnit.FaradPerMeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = Permittivity.ParseUnit("F/m", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(PermittivityUnit.FaradPerMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(Permittivity.TryParseUnit("F/m", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(PermittivityUnit.FaradPerMeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(PermittivityUnit unit)
        {
            var inBaseUnits = Permittivity.From(1.0, Permittivity.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(PermittivityUnit unit)
        {
            var quantity = Permittivity.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(PermittivityUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = Permittivity.Units.FirstOrDefault(u => u != Permittivity.BaseUnit && u != PermittivityUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == PermittivityUnit.Undefined)
                fromUnit = Permittivity.BaseUnit;

            var quantity = Permittivity.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(1, Permittivity.FromFaradsPerMeter(faradpermeter.FaradsPerMeter).FaradsPerMeter, FaradsPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Permittivity v = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Permittivity.FromFaradsPerMeter(3)-v).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Permittivity.FromFaradsPerMeter(10)/5).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, Permittivity.FromFaradsPerMeter(10)/Permittivity.FromFaradsPerMeter(5), FaradsPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Permittivity oneFaradPerMeter = Permittivity.FromFaradsPerMeter(1);
            Permittivity twoFaradsPerMeter = Permittivity.FromFaradsPerMeter(2);

            Assert.True(oneFaradPerMeter < twoFaradsPerMeter);
            Assert.True(oneFaradPerMeter <= twoFaradsPerMeter);
            Assert.True(twoFaradsPerMeter > oneFaradPerMeter);
            Assert.True(twoFaradsPerMeter >= oneFaradPerMeter);

            Assert.False(oneFaradPerMeter > twoFaradsPerMeter);
            Assert.False(oneFaradPerMeter >= twoFaradsPerMeter);
            Assert.False(twoFaradsPerMeter < oneFaradPerMeter);
            Assert.False(twoFaradsPerMeter <= oneFaradPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.Equal(0, faradpermeter.CompareTo(faradpermeter));
            Assert.True(faradpermeter.CompareTo(Permittivity.Zero) > 0);
            Assert.True(Permittivity.Zero.CompareTo(faradpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.Throws<ArgumentException>(() => faradpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => faradpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Permittivity.FromFaradsPerMeter(1);
            var b = Permittivity.FromFaradsPerMeter(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = Permittivity.FromFaradsPerMeter(1);
            var b = Permittivity.FromFaradsPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Permittivity.FromFaradsPerMeter(1);
            object b = Permittivity.FromFaradsPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Permittivity.FromFaradsPerMeter(1);
            Assert.True(v.Equals(Permittivity.FromFaradsPerMeter(1), FaradsPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Permittivity.Zero, FaradsPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Permittivity.FromFaradsPerMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Permittivity.FromFaradsPerMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.False(faradpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.False(faradpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(PermittivityUnit.Undefined, Permittivity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(PermittivityUnit)).Cast<PermittivityUnit>();
            foreach(var unit in units)
            {
                if (unit == PermittivityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Permittivity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 F/m", new Permittivity(1, PermittivityUnit.FaradPerMeter).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 F/m", new Permittivity(1, PermittivityUnit.FaradPerMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s1"));
                Assert.Equal("0.12 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s2"));
                Assert.Equal("0.123 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s3"));
                Assert.Equal("0.1235 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s1", culture));
            Assert.Equal("0.12 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s2", culture));
            Assert.Equal("0.123 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 F/m", new Permittivity(0.123456, PermittivityUnit.FaradPerMeter).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Permittivity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(PermittivityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(QuantityType.Permittivity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(Permittivity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(Permittivity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Permittivity.FromFaradsPerMeter(1.0);
            Assert.Equal(new {Permittivity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Permittivity.FromFaradsPerMeter(value);
            Assert.Equal(Permittivity.FromFaradsPerMeter(-value), -quantity);
        }
    }
}
