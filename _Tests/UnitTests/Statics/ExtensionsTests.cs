
namespace CsabaDu.DynamicTestData.NUnit.Tests.UnitTests.Statics;

public sealed class ExtensionsTests
{
    [Fact]
    public void ToTestCaseData_validArg_ArgsCode_returnsExpected()
    {

    }

    [Fact]
    public void ToTestCaseData_invalidArg_ArgsCode_throwsInvalidEnumArgumentException()
    {
        string expectedParamName = "argsCode";

        // Act
        //void attempt() => _ = _sut.Add(InvalidArgsCode, Parameter);

        // Assert
        var actual = Assert.Throws<InvalidEnumArgumentException>(attempt);
        Assert.Equal(expectedParamName, actual.ParamName);
    }

    [Fact]
    public void ToTestCaseData_arg_testMethodName_returnsExpected()
    {
    }
}
