// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.DynamicDataRowSources;

public abstract class DynamicTestCaseDataRowSource(ArgsCode argsCode)
: DynamicNamedDataRowSource<TestCaseData>(argsCode, default)
{
    protected override void InitDataHolder<TTestData>(
        TTestData testData)
    => DataHolder = new TestCaseDataRowHolder<TTestData>(
        testData,
        this);
}
