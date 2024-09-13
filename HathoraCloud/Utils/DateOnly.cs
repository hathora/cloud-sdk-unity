
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud.Utils
{    
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    ///<summary>
    /// This class is a polyfill for a class in .NET 6
    /// The data only class is not available in the .NET framework.  The .NET framework is what Unity uses.
    ///</summary>
    public readonly struct DateOnly
        : IComparable,
          IComparable<DateOnly>,
          IEquatable<DateOnly>
    {
        private readonly int _dayNumber;

        // Maps to Jan 1st year 1
        private const int MinDayNumber = 0;

        // Maps to December 31 year 9999. The value calculated from "new DateTime(9999, 12, 31).Ticks / TimeSpan.TicksPerDay"
        private const int MaxDayNumber = 3_652_058;

        private static int DayNumberFromDateTime(DateTime dt) => (int)((ulong)dt.Ticks / TimeSpan.TicksPerDay);

        private DateTime GetEquivalentDateTime() => new DateTime(_dayNumber * TimeSpan.TicksPerDay);

        private DateOnly(int dayNumber)
        {
            Debug.Assert((uint)dayNumber <= MaxDayNumber);
            _dayNumber = dayNumber;
        }

        /// <summary>
        /// Gets the earliest possible date that can be created.
        /// </summary>
        public static DateOnly MinValue => new DateOnly(MinDayNumber);

        /// <summary>
        /// Gets the latest possible date that can be created.
        /// </summary>
        public static DateOnly MaxValue => new DateOnly(MaxDayNumber);

        /// <summary>
        /// Creates a new instance of the <see cref="DateOnly"/> structure to the specified year, month, and day.
        /// </summary>
        /// <param name="year">The year (1 through 9999).</param>
        /// <param name="month">The month (1 through 12).</param>
        /// <param name="day">The day (1 through the number of days in <paramref name="month"/>).</param>
        public DateOnly(int year, int month, int day) => _dayNumber = DayNumberFromDateTime(new DateTime(year, month, day));

        /// <summary>
        /// Creates a new instance of the <see cref="DateOnly"/> structure to the specified year, month, and day for the specified calendar.
        /// </summary>
        /// <param name="year">The year (1 through the number of years in calendar).</param>
        /// <param name="month">The month (1 through the number of months in calendar).</param>
        /// <param name="day">The day (1 through the number of days in <paramref name="month"/>).</param>
        /// <param name="calendar">The calendar that is used to interpret <paramref name="year"/>, <paramref name="month"/>, and <paramref name="day"/>.</param>
        public DateOnly(int year, int month, int day, Calendar calendar) => _dayNumber = DayNumberFromDateTime(new DateTime(year, month, day, calendar));

        /// <summary>
        /// Creates a new instance of the <see cref="DateOnly"/> structure to the specified number of days.
        /// </summary>
        /// <param name="dayNumber">The number of days since January 1, 0001 in the Proleptic Gregorian calendar.</param>
        public static DateOnly FromDayNumber(int dayNumber)
        {
            if ((uint)dayNumber > MaxDayNumber)
            {
                ThrowArgumentOutOfRange_DayNumber();
            }

            return new DateOnly(dayNumber);

            static void ThrowArgumentOutOfRange_DayNumber()
                => throw new ArgumentOutOfRangeException(nameof(dayNumber), "Day number must be between 0 and DateOnly.MaxValue.DayNumber.");
        }

        /// <summary>
        /// Gets the year component of the date represented by this instance.
        /// </summary>
        public int Year => GetEquivalentDateTime().Year;

        /// <summary>
        /// Gets the month component of the date represented by this instance.
        /// </summary>
        public int Month  => GetEquivalentDateTime().Month;

        /// <summary>
        /// Gets the day component of the date represented by this instance.
        /// </summary>
        public int Day => GetEquivalentDateTime().Day;

        /// <summary>
        /// Gets the day of the week represented by this instance.
        /// </summary>
        public DayOfWeek DayOfWeek => (DayOfWeek)(((uint)_dayNumber + 1) % 7);

        /// <summary>
        /// Gets the day of the year represented by this instance.
        /// </summary>
        public int DayOfYear => GetEquivalentDateTime().DayOfYear;

        /// <summary>
        /// Gets the number of days since January 1, 0001 in the Proleptic Gregorian calendar represented by this instance.
        /// </summary>
        public int DayNumber => _dayNumber;

        /// <summary>
        /// Adds the specified number of days to the value of this instance.
        /// </summary>
        /// <param name="value">The number of days to add. To subtract days, specify a negative number.</param>
        /// <returns>An instance whose value is the sum of the date represented by this instance
        /// and the number of days represented by <paramref name="value"/>.</returns>
        public DateOnly AddDays(int value)
        {
            int newDayNumber = _dayNumber + value;
            if ((uint)newDayNumber > MaxDayNumber)
            {
                ThrowOutOfRange();
            }

            return new DateOnly(newDayNumber);

            static void ThrowOutOfRange() => throw new ArgumentOutOfRangeException(nameof(value), "Value to add was out of range.");
        }

        /// <summary>
        /// Adds the specified number of months to the value of this instance.
        /// </summary>
        /// <param name="value">A number of months. The months parameter can be negative or positive.</param>
        /// <returns>An object whose value is the sum of the date represented by this instance
        /// and the number of months represented by <paramref name="value"/>.</returns>
        public DateOnly AddMonths(int value) => new DateOnly(DayNumberFromDateTime(GetEquivalentDateTime().AddMonths(value)));

        /// <summary>
        /// Adds the specified number of years to the value of this instance.
        /// </summary>
        /// <param name="value">A number of years. The value parameter can be negative or positive.</param>
        /// <returns>An object whose value is the sum of the date represented by this instance
        /// and the number of years represented by <paramref name="value"/>.</returns>
        public DateOnly AddYears(int value) => new DateOnly(DayNumberFromDateTime(GetEquivalentDateTime().AddYears(value)));

        /// <summary>
        /// Determines whether two specified instances of <see cref="DateOnly"/> are equal.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> and <paramref name="right"/> represent the same date;
        /// otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(DateOnly left, DateOnly right) => left._dayNumber == right._dayNumber;

        /// <summary>
        /// Determines whether two specified instances of <see cref="DateOnly"/> are not equal.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> and <paramref name="right"/> do not represent the same date;
        /// otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(DateOnly left, DateOnly right) => left._dayNumber != right._dayNumber;

        /// <summary>
        /// Determines whether one specified <see cref="DateOnly"/> is later than another specified <see cref="DateOnly"/>.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> is later than <paramref name="right"/>;
        /// otherwise, <see langword="false"/>.</returns>
        public static bool operator >(DateOnly left, DateOnly right) => left._dayNumber > right._dayNumber;

        /// <summary>
        /// Determines whether one specified <see cref="DateOnly"/> represents a date that is the same as or later than another specified <see cref="DateOnly"/>.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> is the same as or later than <paramref name="right"/>;
        /// otherwise, <see langword="false"/>.</returns>
        public static bool operator >=(DateOnly left, DateOnly right) => left._dayNumber >= right._dayNumber;

        /// <summary>
        /// Determines whether one specified <see cref="DateOnly"/> is earlier than another specified <see cref="DateOnly"/> .
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> is earlier than <paramref name="right"/>;
        /// otherwise, <see langword="false"/>.</returns>
        public static bool operator <(DateOnly left, DateOnly right) => left._dayNumber < right._dayNumber;

        /// <summary>
        /// Determines whether one specified <see cref="DateOnly"/> represents a date that is the same as or earlier than another specified <see cref="DateOnly"/>.
        /// </summary>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        /// <returns><see langword="true"/> if <paramref name="left"/> is the same as or earlier than <paramref name="right"/>;
        /// otherwise, <see langword="false"/>.</returns>
        public static bool operator <=(DateOnly left, DateOnly right) => left._dayNumber <= right._dayNumber;

        /// <summary>
        /// Returns a <see cref="DateOnly"/> instance that is set to the date part of the specified <see cref="DateTime"/>.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> instance.</param>
        /// <returns>The <see cref="DateOnly"/> instance composed of the date part of <paramref name="dateTime"/>.</returns>
        public static DateOnly FromDateTime(DateTime dateTime) => new DateOnly(DayNumberFromDateTime(dateTime));

        /// <summary>
        /// Compares the value of this instance to a specified <see cref="DateOnly"/> value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified value.
        /// </summary>
        /// <param name="value">The object to compare to the current instance.</param>
        /// <returns>Less than zero if this instance is earlier than <paramref name="value"/>.
        /// Greater than zero if this instance is later than <paramref name="value"/>.
        /// Zero if this instance is the same as <paramref name="value"/>.</returns>
        public int CompareTo(DateOnly value) => _dayNumber.CompareTo(value._dayNumber);

        /// <summary>
        /// Compares the value of this instance to a specified object that contains a specified <see cref="DateOnly"/> value, and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified value.
        /// </summary>
        /// <param name="value">A boxed object to compare, or <see langword="null"/>.</param>
        /// <returns>Less than zero if this instance is earlier than <paramref name="value"/>.
        /// Greater than zero if this instance is later than <paramref name="value"/>.
        /// Zero if this instance is the same as <paramref name="value"/>.</returns>
        /// <exception cref="ArgumentException"><paramref name="value"/> is neither <see langword="null"/> nor an instance of <see cref="DateOnly"/>.</exception>
        public int CompareTo(object? value)
        {
            if (value == null) return 1;
            if (value.GetType() != typeof(DateOnly))
            {
                throw new ArgumentException("Object must be of type DateOnly.");
            }

            return CompareTo((DateOnly)value);
        }

        /// <summary>
        /// Returns a value indicating whether the value of this instance is equal to the value of the specified <see cref="DateOnly"/> instance.
        /// </summary>
        /// <param name="value">The object to compare to this instance.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> equals the value of this instance;
        /// otherwise, <see langword="false"/>.</returns>
        public bool Equals(DateOnly value) => _dayNumber == value._dayNumber;

        /// <summary>
        /// Returns a value indicating whether this instance is equal to a specified object.
        /// </summary>
        /// <param name="value">The object to compare to this instance.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is an instance of <see cref="DateOnly"/> and equals the value of this instance;
        /// otherwise, <see langword="false"/>.</returns>
        public override bool Equals([NotNullWhen(true)] object? value) => value is DateOnly dateOnly && _dayNumber == dateOnly._dayNumber;

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode() => _dayNumber;

        public override string ToString() => GetEquivalentDateTime().ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

        public static DateOnly Parse(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            if (s.Length != 10)
            {
                throw new FormatException("String was not recognized as a valid DateOnly.");
            }

            int year = Int32.Parse(s.Substring(0, 4));
            if (s[4] != '-')
            {
                throw new FormatException("String was not recognized as a valid DateOnly.");
            }

            int month = Int32.Parse(s.Substring(5, 2));
            if (s[7] != '-')
            {
                throw new FormatException("String was not recognized as a valid DateOnly.");
            }

            int day = Int32.Parse(s.Substring(8, 2));
            return new DateOnly(year, month, day);
        }
    }
}