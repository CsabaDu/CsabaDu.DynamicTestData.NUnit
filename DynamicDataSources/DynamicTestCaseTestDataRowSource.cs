// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.DynamicDataSources;

public abstract class DynamicTestCaseTestDataRowSource(ArgsCode argsCode)
: DynamicNamedDataRowSource<TestCaseTestData>(argsCode, PropsCode.Returns)
{
    protected override void InitDataHolder<TTestData>(
        TTestData testData)
    => DataHolder = new TestCaseTestDataRowHolder<TTestData>(
        testData,
        this);
}
