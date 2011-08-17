StarterTree ReadMe
===

## DESCRIPTION

StarterTree is a simple Hello, World! application used as a starting place for creating new projects. 

It has the following features:

* Default project structure (src, lib, tools folders)
* Simple rake script using albacore with tasks to create CommonAssemblyInfo.cs, build the Visual Studio 10 based solution, and run the NUnit test runner.
* The sample application, StarterTree, configure StructureMap, our Inversion of Control container to provide a HelloWorld class as a Singleton. It contains a test fixture, HelloWorld, that exercises the StarterTree.Core class library.
* Includes provenance.txt files in the lib and tools folders to show the source of the dependencies. See lib/Provenance.txt.template for an example.


## HOW TO BUILD

The build script requires Ruby with rake installed.

1. Run `InstallGems.bat` to get the ruby dependencies (only needs to be run once per computer)
1. open a command prompt to the root folder and type `rake` to execute rakefile.rb

If you do not have ruby:

1. You need to create a src\CommonAssemblyInfo.cs file. Go.bat will copy src\ 
  * go.bat will copy src\CommonAssemblyInfo.cs.default to src\CommonAssemblyInfo.cs
1. open src\FubuMVC.sln with Visual Studio and Build the solution

## License		

[MIT License][mitlicense]

This project is part of [MVBA Law Commons][mvbalawcommons].

[mvbalawcommons]: http://code.google.com/p/mvbalaw-commons/
[mitlicense]: http://www.opensource.org/licenses/mit-license.php
