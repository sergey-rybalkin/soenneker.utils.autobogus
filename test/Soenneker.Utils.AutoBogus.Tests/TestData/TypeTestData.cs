﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace Soenneker.Utils.AutoBogus.Tests.TestData
{
    public class TypeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // Nullable types
            yield return [typeof(string), typeof(string)];
            yield return [typeof(bool?), typeof(bool)];
            yield return [typeof(int?), typeof(int)];
            yield return [typeof(double?), typeof(double)];
            yield return [typeof(DateTime?), typeof(DateTime)];
            yield return [typeof(byte?), typeof(byte)];
            yield return [typeof(char?), typeof(char)];
            yield return [typeof(decimal?), typeof(decimal)];
            yield return [typeof(float?), typeof(float)];
            yield return [typeof(long?), typeof(long)];
            yield return [typeof(Guid?), typeof(Guid)];
            yield return [typeof(sbyte?), typeof(sbyte)];
            yield return [typeof(short?), typeof(short)];
            yield return [typeof(uint?), typeof(uint)];
            yield return [typeof(ulong?), typeof(ulong)];
            yield return [typeof(Uri), typeof(Uri)]; // Uri is a reference type

            // Non-nullable types
            yield return [typeof(string), typeof(string)];
            yield return [typeof(bool), typeof(bool)];
            yield return [typeof(int), typeof(int)];
            yield return [typeof(double), typeof(double)];
            yield return [typeof(DateTime), typeof(DateTime)];
            yield return [typeof(byte), typeof(byte)];
            yield return [typeof(char), typeof(char)];
            yield return [typeof(decimal), typeof(decimal)];
            yield return [typeof(float), typeof(float)];
            yield return [typeof(long), typeof(long)];
            yield return [typeof(Guid), typeof(Guid)];
            yield return [typeof(sbyte), typeof(sbyte)];
            yield return [typeof(short), typeof(short)];
            yield return [typeof(uint), typeof(uint)];
            yield return [typeof(ulong), typeof(ulong)];
            yield return [typeof(Uri), typeof(Uri)]; // Uri is a reference type

            // Enumerable types
            yield return [typeof(IEnumerable<string>), typeof(List<string>)];
            yield return [typeof(IEnumerable<bool>), typeof(List<bool>)];
            yield return [typeof(IEnumerable<int>), typeof(List<int>)];
            yield return [typeof(IEnumerable<double>), typeof(List<double>)];
            yield return [typeof(IEnumerable<DateTime>), typeof(List<DateTime>)];
            yield return [typeof(IEnumerable<byte>), typeof(List<byte>)];
            yield return [typeof(IEnumerable<char>), typeof(List<char>)];
            yield return [typeof(IEnumerable<decimal>), typeof(List<decimal>)];
            yield return [typeof(IEnumerable<float>), typeof(List<float>)];
            yield return [typeof(IEnumerable<long>), typeof(List<long>)];
            yield return [typeof(IEnumerable<Guid>), typeof(List<Guid>)];
            yield return [typeof(IEnumerable<sbyte>), typeof(List<sbyte>)];
            yield return [typeof(IEnumerable<short>), typeof(List<short>)];
            yield return [typeof(IEnumerable<uint>), typeof(List<uint>)];
            yield return [typeof(IEnumerable<ulong>), typeof(List<ulong>)];
            yield return [typeof(IEnumerable<Uri>), typeof(List<Uri>)];
            yield return [typeof(IEnumerable<ushort>), typeof(List<ushort>)];
            yield return [typeof(IEnumerable<DateTimeOffset>), typeof(List<DateTimeOffset>)];
            yield return [typeof(IEnumerable<IPAddress>), typeof(List<IPAddress>)];
            yield return [typeof(ICollection<string>), typeof(List<string>)];
            yield return [typeof(ICollection<bool>), typeof(List<bool>)];
            yield return [typeof(ICollection<int>), typeof(List<int>)];
            yield return [typeof(ICollection<double>), typeof(List<double>)];
            yield return [typeof(ICollection<DateTime>), typeof(List<DateTime>)];
            yield return [typeof(ICollection<byte>), typeof(List<byte>)];
            yield return [typeof(ICollection<char>), typeof(List<char>)];
            yield return [typeof(ICollection<decimal>), typeof(List<decimal>)];
            yield return [typeof(ICollection<float>), typeof(List<float>)];
            yield return [typeof(ICollection<long>), typeof(List<long>)];
            yield return [typeof(ICollection<Guid>), typeof(List<Guid>)];
            yield return [typeof(ICollection<sbyte>), typeof(List<sbyte>)];
            yield return [typeof(ICollection<short>), typeof(List<short>)];
            yield return [typeof(ICollection<uint>), typeof(List<uint>)];
            yield return [typeof(ICollection<ulong>), typeof(List<ulong>)];
            yield return [typeof(ICollection<Uri>), typeof(List<Uri>)];
            yield return [typeof(ICollection<ushort>), typeof(List<ushort>)];
            yield return [typeof(ICollection<DateTimeOffset>), typeof(List<DateTimeOffset>)];
            yield return [typeof(ICollection<IPAddress>), typeof(List<IPAddress>)];
            yield return [typeof(IList<string>), typeof(List<string>)];
            yield return [typeof(IList<bool>), typeof(List<bool>)];
            yield return [typeof(IList<int>), typeof(List<int>)];
            yield return [typeof(IList<double>), typeof(List<double>)];
            yield return [typeof(IList<DateTime>), typeof(List<DateTime>)];
            yield return [typeof(IList<byte>), typeof(List<byte>)];
            yield return [typeof(IList<char>), typeof(List<char>)];
            yield return [typeof(IList<decimal>), typeof(List<decimal>)];
            yield return [typeof(IList<float>), typeof(List<float>)];
            yield return [typeof(IList<long>), typeof(List<long>)];
            yield return [typeof(IList<Guid>), typeof(List<Guid>)];
            yield return [typeof(IList<sbyte>), typeof(List<sbyte>)];
            yield return [typeof(IList<short>), typeof(List<short>)];
            yield return [typeof(IList<uint>), typeof(List<uint>)];
            yield return [typeof(IList<ulong>), typeof(List<ulong>)];
            yield return [typeof(IList<Uri>), typeof(List<Uri>)];
            yield return [typeof(IList<ushort>), typeof(List<ushort>)];
            yield return [typeof(IList<DateTimeOffset>), typeof(List<DateTimeOffset>)];
            yield return [typeof(IList<IPAddress>), typeof(List<IPAddress>)];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}