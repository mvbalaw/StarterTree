using StructureMap;

namespace StarterTree
{
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global
	public class Bootstrapper : IBootstrapper
// ReSharper restore ClassWithVirtualMembersNeverInherited.Global
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