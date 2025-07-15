// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.DynamicDataSources;

public abstract class DynamicTestCaseDataSource(ArgsCode argsCode)
: DynamicNamedDataSource<TestCaseTestData>(argsCode, typeof(ITestDataThrows)),
INamedRows<TestCaseTestData>
{
    protected override void InitDataRowHolder<TTestData>(
        TTestData testData)
    => DataRowHolder = new TestCaseDataRowHolder<TTestData>(
        testData,
        this);
}
