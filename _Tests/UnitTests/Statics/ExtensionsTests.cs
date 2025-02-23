using CsabaDu.DynamicTestData.NUnit.Tests.TheoryDataSources;
using CsabaDu.DynamicTestData.TestDataTypes;
using static CsabaDu.DynamicTestData.NUnit.Tests.TheoryDataSources.ExtensionsTheoryData;

namespace CsabaDu.DynamicTestData.NUnit.Tests.UnitTests.Statics;

public sealed class ExtensionsTests
{
    private const string ParamName = "argsCode";

    #region ToTestCaseData Tests
    [Fact]
    public void ToTestCaseData_invalidArg_ArgsCode_throwsInvalidEnumArgumentException()
    {
        // Arrange
        TestData sut = TestDataChildInstance;

        // Act
        void attempt() => _ = sut.ToTestCaseData(InvalidArgsCode);

        // Assert
        var actual = Xunit.Assert.Throws<InvalidEnumArgumentException>(attempt);
        Xunit.Assert.Equal(ParamName, actual.ParamName);
    }

    [Xunit.Theory, MemberData(nameof(ToTestCaseDataTheoryData), MemberType = typeof(ExtensionsTheoryData))]
    public void ToTestCaseData_validArg_ArgsCode_returnsExpected(TestData sut, ArgsCode argsCode, TestCaseData testCaseData)
    {
        // Arrange
        TestCaseData expected = testCaseData.SetDescription(sut.TestCase);

        // Act
        var actual = sut.ToTestCaseData(argsCode);

        // Assert
        Xunit.Assert.Equal(expected.Arguments, actual.Arguments);
    }

    [Xunit.Theory, MemberData(nameof(ToTestCaseDataSetNameTheoryData), MemberType = typeof(ExtensionsTheoryData))]
    public void ToTestCaseData_arg_testMethodName_returnsExpected(string testMethodName, bool expected)
    {
        // Arrange
        TestData sut = TestDataChildInstance;
        string displayName = DynamicDataSource.GetDisplayName(testMethodName, sut.TestCase);

        // Act
        TestCaseData testCaseData = sut.ToTestCaseData(default, testMethodName);
        var actual = testCaseData.TestName == displayName;

        // Assert
        Xunit.Assert.Equal(expected, actual);
    }
    #endregion

    #region ToTestCaseData<TStruct> Tests
    [Fact]
    public void ToTestCaseDataTStruct__returnsExpected()
    {
        // Arrange
        TestDataReturns<DummyEnum> sut = TestDataReturnsChildInstance;

        // Act
        var actual = sut.ToTestCaseData(default);

        // Assert
        Xunit.Assert.Equal(sut.Expected, actual.ExpectedResult);
    }
    #endregion
}
