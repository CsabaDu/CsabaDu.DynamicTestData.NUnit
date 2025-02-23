namespace CsabaDu.DynamicTestData.NUnit.Tests.TheoryDataSources;

public sealed class ExtensionsTheoryData
{
    public static TheoryData<TestData, ArgsCode, TestCaseData> ToTestCaseDataTheoryData => new()
    {
        { TestDataArgs1, ArgsCode.Instance, new(TestDataArgs1) },
        { TestDataArgs2, ArgsCode.Instance, new(TestDataArgs2) },
        { TestDataArgs3, ArgsCode.Instance, new(TestDataArgs3) },
        { TestDataArgs4, ArgsCode.Instance, new(TestDataArgs4) },
        { TestDataArgs5, ArgsCode.Instance, new(TestDataArgs5) },
        { TestDataArgs6, ArgsCode.Instance, new(TestDataArgs6) },
        { TestDataArgs7, ArgsCode.Instance, new(TestDataArgs7) },
        { TestDataArgs8, ArgsCode.Instance, new(TestDataArgs8) },
        { TestDataArgs9, ArgsCode.Instance, new(TestDataArgs9) },
        { TestDataArgs1, ArgsCode.Properties, new(Args1) },
        { TestDataArgs2, ArgsCode.Properties, new(Args2) },
        { TestDataArgs3, ArgsCode.Properties, new(Args3) },
        { TestDataArgs4, ArgsCode.Properties, new(Args4) },
        { TestDataArgs5, ArgsCode.Properties, new(Args5) },
        { TestDataArgs6, ArgsCode.Properties, new(Args6) },
        { TestDataArgs7, ArgsCode.Properties, new(Args7) },
        { TestDataArgs8, ArgsCode.Properties, new(Args8) },
        { TestDataArgs9, ArgsCode.Properties, new(Args9) },
    };

    public static TheoryData<string, bool> ToTestCaseDataSetNameTheoryData => new()
    {
        { null, false },
        { string.Empty, false },
        { TestMethodName, true },
    };
}
