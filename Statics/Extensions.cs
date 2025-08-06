// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.Statics;

public static class Extensions
{
    public static bool IsReturns(
        this ITestData testData,
        [NotNullWhen(true)] out ITestDataReturns? testDataReturns)
    {
        testDataReturns = testData as ITestDataReturns;
        return testDataReturns is not null;
    }

    public static TestCaseData ToTestCaseData(
        this ITestData testData,
        ArgsCode argsCode,
        string? testMethodName = null)
    {
        bool isReturns = testData?.IsReturns(
            out ITestDataReturns? testDataReturns) 
            ?? throw new ArgumentNullException(
                nameof(testData));

        var parameters = TestDataToParams(
            testData,
            argsCode,
            PropsCode.Throws,
            out string testCaseName);

        var testCaseData = new TestCaseData(parameters)
            .SetDescription(testCaseName)
            .SetName(GetDisplayName(
                testMethodName,
                testCaseName));

        Type testDataType = testData.GetType();

        if (argsCode == ArgsCode.Properties)
        {
            Type[] genericTypes =
                testDataType.GetGenericArguments();

            testCaseData.TypeArgs = isReturns ?
                genericTypes[1..]
                : genericTypes;
        }
        else
        {
            testCaseData.TypeArgs = [testDataType];
        }

        return isReturns ?
            testCaseData.Returns(
                testDataReturns!.GetExpected())
            : testCaseData;
    }

    public static TestCaseTestData<TTestData> ToTestCaseTestData<TTestData>(
        this TTestData testData,
        ArgsCode argsCode,
        string? testMethodName = null)
    where TTestData : notnull, ITestData
    => new(
        testData,
        argsCode,
        testMethodName);
}
