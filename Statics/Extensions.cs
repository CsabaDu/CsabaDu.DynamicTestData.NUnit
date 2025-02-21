using static CsabaDu.DynamicTestData.DynamicDataSources.DynamicDataSource;

namespace CsabaDu.DynamicTestData.NUnit.Statics;

public static class Extensions
{
    public static TestCaseData ToTestCaseData(this ITestData testData, ArgsCode argsCode, string? testMethodName = null)
    {
        TestCaseData testCaseData = argsCode.Defined(nameof(argsCode)) == ArgsCode.Properties ?
            new(testData.ToArgs(argsCode)[1..])
            : new(testData);
        string testCase = testData.ToString()!;

        return string.IsNullOrEmpty(testMethodName) ?
            testCaseData.SetDescription(testCase)
            : testCaseData.SetDescription(testCase).SetName(GetDisplayName(testMethodName, testData.TestCase));
    }

    public static TestCaseData ToTestCaseData<TStruct>(this ITestDataReturns<TStruct> testData, ArgsCode argsCode, string? testMethodName = null) where TStruct : struct
    {
        return (testData as ITestData).ToTestCaseData(argsCode, testMethodName).Returns(testData.Expected);
    }
}
