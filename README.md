

# Project: Docler Homework C#

This project is about automated UI testing (with Selenium) of http://uitest.duodecadits.com based on the requirements using C# with SpecFlow and NUnit

## Getting Started

### Prerequisites

The following packages must be installed in Microsoft Visual Studio:
- Selenium.Webdriver
- Selenium.Chrome.Webdriver
- Specflow
- SpecRun.Runner
- SpecRun.SpecFlow
- NUnit
- NUnitTestAdapter

### Traceability Matrix

Please find the Requirements Traceability Matrix in the root folder beside README.MD: *Traceability_Matrix_Docler.xlsx*

## Technical structure of the tests:

### SpecFlow:

Location of the feature file:

```
\DocTest\Feature -> SpecFlowFeature1.feature
```

Location of step definitions:

```
\DocTest\StepDefinition -> StepDefinition1.cs
```

Location of the page objects:

```
\DocTest\Pages
```

CommonMethods can be found in 'Utilities' folder.

#### Running the test cases

You can run the test cases with SpecFlow Runner or with NUnit.


#### Author
**Bondár Tamás**

