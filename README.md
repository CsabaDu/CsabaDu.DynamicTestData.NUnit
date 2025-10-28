# CsabaDu.DynamicTestData.NUnit

🎯 An extension of CsabaDu.DynamicTestData framework to facilitate dynamic data-driven testing in NUnit.  

- ⚙️ Test data **conversion, management and provisioning**
- ⛑️ **Type-safe and thread-safe** support for *NUnit*
- 🧩 **Modular design**, abstractions and ready-to-use integrations
- 💼 **Portable** data sources
- 📋 Traceable **descriptive display names**
- 💵 **Now seeking sponsors** to complete v2.0 – comprehensive testing, documentation, examples, and new features!

---

[![Sponsor this project](https://img.shields.io/badge/Sponsor_on_GitHub-💖-ff69b4?style=flat-square)](https://github.com/sponsors/CsabaDu) 
[![Buy me a coffee](https://raw.githubusercontent.com/CsabaDu/CsabaDu.DynamicTestData/refs/heads/master/_Images/white-button_15.png)](https://buymeacoffee.com/csabadu) 
[![Support Me a Ko-fi](https://raw.githubusercontent.com/CsabaDu/CsabaDu.DynamicTestData/refs/heads/master/_Images/SupportMeOnKofi_20.png)](https://ko-fi.com/csabadu) 
[![OpenCollective](https://opencollective.com/static/images/opencollectivelogo-footer-n.svg)](https://opencollective.com/csabadudynamictestdata)  

---

## Documentation

This README and the [dedicated Wiki](https://github.com/CsabaDu/CsabaDu.DynamicTestData.NUnit/wiki) for the **CsabaDu.DynamicTestData.NUnit** extension are currently under development. While full documentation is in progress, you can already find essential information and usage guidance.

To learn more about the core framework, visit the [CsabaDu.DynamicTestData package on NuGet](https://www.nuget.org/packages/CsabaDu.DynamicTestData/2.0.6-beta) and explore its [main Wiki](https://github.com/CsabaDu/CsabaDu.DynamicTestData/wiki).

For an overview of this NUnit-specific extension—including its purpose, integration points, and sample usage—see the [Extensibility & Ready-to-Use Implementations](https://github.com/CsabaDu/CsabaDu.DynamicTestData/wiki/02.08-%F0%9F%93%90-Extensibility-&-Ready-to-Use-Implementations#-nunit) section.

---

## Version 2.0.0-beta Foreword

The `CsabaDu.DynamicTestData.NUnit` framework has undergone a major transformation in version **2.0.0-beta**, introducing a wide range of enhancements while preserving its original foundation.

This release introduces powerful new capabilities:
- **Test data conversion** to any type of test data row
- **Data row management** for structured and reusable test inputs
- **Flexible data provisioning** to test methods across frameworks

These features make the framework easier to use, more adaptable to diverse testing needs, and better suited for integration with MSTest, NUnit, xUnit, and beyond. The newly introduced interfaces and abstract classes are designed for **extensibility**, allowing developers to support custom types and framework-specific features while staying aligned with the `CsabaDu.DynamicTestData` ecosystem.

The architecture is **clean**, the codebase is **modular**, and many features have been **partially tested**. The documentation provides detailed insights into the design, types, and usage patterns. However, this version is still considered **beta** due to:
- Incomplete test coverage
- Missing documentation sections (e.g., migration guide from v1.x.x)

**Final Notes**  

This version is beta, meaning:
  - Features are **stable but may change**  
  - Some features are only **partially tested**  
  - Documentation is detailed, but **incomplete**  
  - Feedback and support is **highly appreciated**  

---

## Changelog  

### **Version 2.0.0-beta** (2025-09-01)

> This is a **beta release** introducing **breaking changes**, new features, and architectural enhancements to the `CsabaDu.DynamicTestData.NUnit` library. These updates improve usability, flexibility, and extensibility.

- **Cancelled**:
  - **DynamicDataSources** namespace:
    - `DynamicTestCaseDataSource` abstract class
- **Changed**:
  - **Statics** namespace:
    - `*Extensions*` static class
- **Added**:
  - **TestDataTypes** namespace:
    - `TestCaseTestData` abstract class
    - `TestCaseTestData<TTestData>` sealed class
  - **TestDataRows** namespace:
    - `TestCaseDataRow<TTestData>` class
    - `TestCaseTestDataRow<TTestData>` class
  - **DataRowHolders** namespace:
    - `TestCaseDataRowHolder<TTestData>` class
    - `TestCaseTestDataRowHolder<TTestData>` class
  - **DynamicDataSources** namespace:
    - `DynamicTestCaseDataRowSource` abstract class
    - `DynamicTestCaseTestDataRowSource` abstract class

---

#### **Version 2.0.1-beta** (2025-09-20)

- **Changed**:
  - **`*TestDataRows.TestCaseDataRow<TTestData>`**
   - Inheritance updated to `NamedTestDataRow<TestCaseData, TTestData>`.
   - `TestCaseData Convert(IDataStrategy, string?)` method made `override`.

### **Version 1.0.0** (2025-03-13)  
- Initial release of the *CsabaDu.DynamicTestData.NUnit* framework, which is a child of **CsabaDu.DynamicTestData** framework.  
- Includes the `DynamicTestCaseDataSource` base class.  
- Provides support for dynamic data-driven tests with TestCaseData arguments having different data, expected struct results, and exceptions, on top of the inherited *CsabaDu.DynamicTestData* features.  

---
### **Version 1.1.0** (2025-03-30)  
- **Added**: `OptionalToTestCaseData` method added to the `DynamicTestCaseDataSource` class.  
- **Note**: This update is backward-compatible with previous versions.  

---
#### **Version 1.1.1** (2025-03-31)  
- **Updated**: README.md Sample codes corrected.  

---
#### **Version 1.1.2** (2025-04-02)  
- **Updated**:  
  - README.md Sample Test Classes with `TestCaseData` Lists' section Sample codes corrected.
  - Small README.md corrections and visual refactorings.

---

## Contributing

Contributions are welcome! Please submit a pull request or open an issue if you have any suggestions or bug reports.

---
## License

This project is licensed under the MIT License. See the [License](LICENSE.txt) file for details.

---
## Contact

For any questions or inquiries, please contact [CsabaDu](https://github.com/CsabaDu).

---
## FAQ

---
## Troubleshooting
