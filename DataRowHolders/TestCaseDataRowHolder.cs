// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.NUnit.DataRowHolders;
public class TestCaseDataRowHolder<TTestData>
: DataRowHolder<TestCaseTestData, TTestData>,
INamedDataRowHolder<TestCaseTestData>
where TTestData : notnull, ITestData
{
    public TestCaseDataRowHolder(
    TTestData testData,
    IDataStrategy dataStrategy)
    : base(testData, dataStrategy)
    {
    }

    public TestCaseDataRowHolder(
        TestCaseDataRowHolder<TTestData> other,
        IDataStrategy dataStrategy)
    : base(other, dataStrategy)
    {
    }

    public override ITestDataRow<TestCaseTestData, TTestData> CreateTestDataRow(
        TTestData testData)
    => new TestCaseDataRow<TTestData>(
        testData);

    public override IDataRowHolder<TestCaseTestData> GetDataRowHolder(
        IDataStrategy dataStrategy)
    => dataStrategy.ArgsCode == DataStrategy.ArgsCode ?
        this
        : new TestCaseDataRowHolder<TTestData>(
            this,
            dataStrategy);

    public IEnumerable<TestCaseTestData>? GetRows(
        string? testMethodName,
        ArgsCode? argsCode)
    {
        var testDataRows = GetTestDataRows(argsCode);
        var dataStrategy = GetDataStrategy(argsCode);

        return testDataRows?.Select(
            tdr => (tdr as INamedTestDataRow<TestCaseTestData>)
            !.Convert(dataStrategy, testMethodName));
    }
}