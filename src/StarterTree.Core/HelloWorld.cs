namespace StarterTree.Core
{
	public class HelloWorld
	{
		private readonly string _whatToSay;

		public HelloWorld(string whatToSay)
		{
			_whatToSay = whatToSay;
		}

		public string Speak()
		{
			return _whatToSay;
		}
	}
}