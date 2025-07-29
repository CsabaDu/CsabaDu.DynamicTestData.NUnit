// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.DynamicDataSources;

public abstract class DynamicTestCaseDataRowSource(ArgsCode argsCode)
: DynamicNamedDataRowSource<TestCaseTestData>(argsCode, PropertyCode.Returns),
INamedRows<TestCaseTestData>
{
    protected override void InitDataHolder<TTestData>(
        TTestData testData)
    => DataHolder = new TestCaseDataRowHolder<TTestData>(
        testData,
        this);
}
