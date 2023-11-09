using project_65030018;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProjectMembersCount()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
        }
        [TestMethod]
        public void TestProjectMemberIds()
        {
            Assert.IsTrue((int)Project.Members.Pear == 1);
            Assert.IsTrue((int)Project.Members.Ming == 2);
            Assert.IsTrue((int)Project.Members.Mark == 3);
            Assert.IsTrue((int)Project.Members.Bob == 4);
        }
    }
}
