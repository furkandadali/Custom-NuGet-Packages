![NuGet logo](https://raw.githubusercontent.com/NuGet/Home/dev/meta/resources/nuget.png)

-----

# NuGet Home

The Home repository is the starting point for people to learn about NuGet, the project. If you're new to NuGet, and want to add packages to your own projects, [check our docs](http://docs.nuget.org). This repo contains pointers to the various GitHub repositories used by NuGet and allows folks to learn more about what's coming in NuGet.

NuGet is being actively developed by the .NET Foundation. NuGet is the package manager for the Microsoft development platform including .NET. The [NuGet client tools](https://github.com/nuget/nuget.client) provide the ability to produce and consume packages. The [NuGet Gallery](https://github.com/NuGet/NuGetGallery) is the central package repository used by all package authors and consumers and has a live deployment at [www.nuget.org](https://www.nuget.org).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

# Security.Enigma project

The first step selects the project type. I want to create a Security package which is encryption and decryption classes. We can use that for the save password, DB connection parameters some credentials may be some confidential keys.
I added my classes which are Encryption and Decryption.
I use System.Security.Cryptography library for these operations. After published.Net6 obsoleted some types in this library(like SYSLIB0021). Please follow this link to catch the last updates.

## Documentation and Further Learning

### [NuGet Docs](http://docs.microsoft.com/en-us/nuget)

The NuGet Docs are the ideal place to start if you are new to NuGet. They are categorized in 3 broader topics:

* [Consume NuGet packages](https://docs.nuget.org/ndocs/consume-packages/overview-and-workflow) in your projects;
* [Create NuGet packages](https://docs.nuget.org/ndocs/create-packages/overview-and-workflow) to learn about packaging and publishing your own NuGet Packages;
* [Contribute to NuGet](https://github.com/NuGet/Home/wiki/Contribute-to-NuGet) gives an overview of how you can contribute to the various NuGet projects.


## Contributing

There are many ways in which you can participate in the project, for example:

* [Submit bugs and feature requests, and help us verify as they are checked in](https://github.com/NuGet/Home/wiki/Submitting-Bugs-and-Suggestions)
* [Review NuGet proposals](https://github.com/NuGet/Home/pulls)
* [Review the documentation and make pull requests for anything from typos to new content](https://github.com/NuGet/docs.microsoft.com-nuget)

If you are interested in fixing issues and contributing directly to the code base, please see the document [Contribute To NuGet](https://github.com/NuGet/Home/wiki/Contribute-to-NuGet), which covers the following:

* How to build and run from source
* The development workflow, including debugging and running tests
* Coding guidelines
* Submitting pull requests
* [Finding an issue to work on](https://github.com/NuGet/Home/issues?q=is%3Aopen+is%3Aissue+label%3A%22Up+for+Grabs%22)
* And much more!

**Note:** Not all of our repositories are open for contribution yet. Ping us if unsure.
