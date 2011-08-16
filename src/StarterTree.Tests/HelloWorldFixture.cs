using NUnit.Framework;
using StarterTree.Core;
using StructureMap;

namespace StarterTree.Tests
{
	[TestFixture]
	public class When_created_using_new_and_asked_to_speak
	{

		[Test]
		public void Should_say_hello_world()
		{
			var sut = new HelloWorld("Hello, World!");
			var results = sut.Speak();
			Assert.AreEqual("Hello, World!", results);
		}
	}

	[TestFixture]
	public class When_created_from_structuremap_and_asked_to_speak
	{
		private HelloWorld _sut;

		[TestFixtureSetUp]
		public void Setup()
		{
			Bootstrapper.Bootstrap();
			_sut = ObjectFactory.GetInstance<HelloWorld>();
		}

		[Test]
		public void Should_say_structuremap_says_hello()
		{
			var results = _sut.Speak();
			Assert.AreEqual("StructureMap says hello!", results);
		}
	}

}