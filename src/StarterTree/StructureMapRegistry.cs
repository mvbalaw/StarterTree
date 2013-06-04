using StructureMap.Configuration.DSL;

namespace StarterTree
{
	public class StructureMapRegistry : Registry
	{
		public StructureMapRegistry()
		{
			var helloWorld = new HelloWorld("StructureMap says hello!");

			For<HelloWorld>().Singleton().Use(helloWorld);

		}

	}
}