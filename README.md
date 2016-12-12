# A test-driven C# assessment

This repo includes a set of tests that can be used to assess the skills of
a candidate for a C# position, or to evaluate and improve one's own
skills.

## I want to work on the tests; what do I do?
To use the tests, you will need to install [.NET Core](https://www.microsoft.com/net).

You can clone or download this repo. Once you have done so, from the root
directory of the repo, run:

    dotnet restore
    dotnet build

You can then run the tests in the Assessment.Tests folder with:

    dotnet test
    
When you first run the unit tests, all of the tests should be failing as inconclusive; your job is to
get the tests to pass. To do this, you'll need to refer to the tests in the
files in the `Assessment.Tests/` directory, and edit the files in the `Assessment/` directory.
Once you update a test, you can re-run `dotnet test` to see
whether it worked.

You can also run (most of) the tests on the command line:

    dotnet test

### Available dependencies

The repo includes `xUnit`, `xunit.runner.console`, `dotnet-test-xunit`, and `Newtonsoft.Json`. You can use these
libraries when writing your solutions!

Copyright &copy; 2016-2017 Chris Ballance with many thanks to everyone below
[contributors]
(https://github.com/ballance/csharp-assessment/graphs/contributors).

### Inspired by the javascript assesment by Rebecca Murphey, et al:
Copyright &copy; 2012-2016 Rebecca Murphey with many thanks to several
[contributors](https://github.com/rmurphey/js-assessment/graphs/contributors).

<a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-sa/4.0/88x31.png" /></a>

This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/">Creative Commons Attribution-ShareAlike 4.0 International License</a>.
