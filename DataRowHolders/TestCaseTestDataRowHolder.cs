// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.DataRowHolders;
public class TestCaseTestDataRowHolder<TTestData>
: NamedDataRowHolder<TestCaseTestData, TTestData>
where TTestData : notnull, ITestData
{
    public TestCaseTestDataRowHolder(
    TTestData testData,
    IDataStrategy dataStrategy)
    : base(testData, dataStrategy)
    {
    }

    public TestCaseTestDataRowHolder(
        TestCaseTestDataRowHolder<TTestData> other,
        IDataStrategy dataStrategy)
    : base(other, dataStrategy)
    {
    }

    public override ITestDataRow<TestCaseTestData, TTestData> CreateTestDataRow(
        TTestData testData)
    => new TestCaseTestDataRow<TTestData>(
        testData);

    public override IDataRowHolder<TestCaseTestData> GetDataRowHolder(
        IDataStrategy dataStrategy)
    => dataStrategy.ArgsCode == DataStrategy.ArgsCode ?
        this
        : new TestCaseTestDataRowHolder<TTestData>(
            this,
            dataStrategy);
}