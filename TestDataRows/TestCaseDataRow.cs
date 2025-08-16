// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.TestDataRows;

public class TestCaseDataRow<TTestData>(
    TTestData testData)
: TestDataRow<TestCaseData, TTestData>(
    testData),
INamedTestDataRow<TestCaseData>
where TTestData : notnull, ITestData
{
    public TestCaseData Convert(IDataStrategy dataStrategy, string? testMethodName)
    => new TestCaseTestData<TTestData>(
        TestData,
        dataStrategy.ArgsCode,
        testMethodName);

    public override TestCaseData Convert(IDataStrategy dataStrategy)
    => Convert(dataStrategy, null);
}