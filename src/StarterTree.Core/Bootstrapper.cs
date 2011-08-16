using StructureMap;

namespace StarterTree.Core
{
	public class Bootstrapper : IBootstrapper
	{
		private static bool _hasStarted;

		public virtual void BootstrapStructureMap()
		{
			ObjectFactory.Initialize(x => x.AddRegistry(new StructureMapRegistry()));
		}

		public static void Restart()
		{
			if (_hasStarted)
			{
				ObjectFactory.ResetDefaults();
			}
			else
			{
				Bootstrap();
				_hasStarted = true;
			}
		}

		public static void Bootstrap()
		{
			new Bootstrapper().BootstrapStructureMap();
		}
	}
}