namespace CsabaDu.DynamicTestData.NUnit.Statics;

public static class Extensions
{
    public static TestCaseData ToTestCaseData(this ITestData testData, ArgsCode argsCode, string? testMethodName = null)
    {
        string testCase = testData.ToString()!;
        TestCaseData testCaseData = argsCode == ArgsCode.Properties ?
            new(testData.ToArgs(argsCode)[1..])
            : new(testData);

        return string.IsNullOrEmpty(testMethodName) ?
            testCaseData.SetDescription(testCase)
            : testCaseData.SetDescription(testCase).SetName(DynamicDataSource.GetDisplayName(testMethodName, [testData.TestCase])); // TODO update when nuget refreshed
    }

    public static TestCaseData ToTestCaseData<TStruct>(this ITestDataReturns<TStruct> testData, ArgsCode argsCode, string? testMethodName = null) where TStruct : struct
    {
        return (testData as ITestData).ToTestCaseData(argsCode, testMethodName).Returns(testData.Expected);
    }
}
