# RhinoNUnitTestRunner
This is an example project demonstrating embedding the nunitlite test runner inside rhino

One issue that arises developing rhino plugins is the need to run tests that call into functionality
available only in a running Rhino process. To solve this, we demonstrate how to execute nunit tests from
inside rhino, reporting via the rhino console.

In this example, our nunit tests are packaged in a distinct dll from the rhino tests. You could of course
embed them directly in the plugin assembly, which would allow the command to instantiate the test runner
without passing it an assembly.

To see it in action:
1. Build and install the plugin
2. Run the 'RhinoNUnitTestRunnerCommand'. 
3. Note that nunit reports one passing and one failing test. This is expected. Note that if you install the nunit 3 test runner (https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.NUnit3TestAdapter),
and run all project tests through visual studio, both tests fail because some symbols in this test body cannot resolve outside of the rhino
process.

Hooray, tests.
