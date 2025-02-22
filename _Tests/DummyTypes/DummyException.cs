namespace CsabaDu.DynamicTestData.NUnit.Tests.DummyTypes;

[Serializable]
public class DummyException(string message) : Exception(message);
