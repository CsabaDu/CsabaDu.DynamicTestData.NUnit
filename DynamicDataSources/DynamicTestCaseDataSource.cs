// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.DynamicDataSources;

public abstract class DynamicTestCaseDataSource(ArgsCode argsCode)
: DynamicNamedDataSource<TestCaseTestData>(argsCode, typeof(ITestDataReturns)),
INamedRows<TestCaseTestData>
{
    protected override ITestDataRow<TestCaseTestData, TTestData> CreateTestDataRow<TTestData>(
        TTestData testData)
    => new TestCaseDataRow<TTestData>(
        testData);

    protected override void InitDataRowHolder<TTestData>(
        TTestData testData)
    => DataRowHolder = new TestCaseDataRowHolder<TTestData>(
        testData,
        this);
}
