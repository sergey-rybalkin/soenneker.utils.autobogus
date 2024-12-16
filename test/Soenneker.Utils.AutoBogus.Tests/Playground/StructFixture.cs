using System;
using Soenneker.Utils.AutoBogus.Abstract;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Generators;
using Xunit;

namespace Soenneker.Utils.AutoBogus.Tests.Playground;

public class StructFixture
{
    private readonly ITestOutputHelper _outputHelper;

    public StructFixture(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void Generate_ExampleStruct()
    {
        IAutoFaker faker = new AutoFaker(builder =>
        {
            builder.WithOverride(new ExampleStructOverride());
        });

        var exampleStruct = faker.Generate<ExampleStruct>();

        _outputHelper.WriteLine(exampleStruct.Month.ToString());

        Assert.True(exampleStruct.Month > 0 && exampleStruct.Month <= 12);
    }
}

class ExampleStructOverride : AutoFakerGeneratorOverride
{
    public override bool Preinitialize => false;

    public override bool CanOverride(AutoFakerContext context)
    {
        return context.CachedType == context.CacheService.Cache.GetCachedType(typeof(ExampleStruct));
    }

    public override void Generate(AutoFakerOverrideContext context)
    {
        context.Instance = new ExampleStruct(5);
    }
}

public struct ExampleStruct
{
    public ExampleStruct(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new ArgumentOutOfRangeException(
                nameof(month),
                $"Value should be in range [1-12]\nActual value was {month}."
            );
        }

        Month = month;
    }

    public int Month { get; }
}