namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			string nameFirst = "tHomAs";
			string nameLast = "paYNe";
			string wanted = "Payne, Thomas";
			string current = FirstAssignmentNoMain.Classes.Methods.FullName(nameFirst, nameLast);
			
			Assert.Equal(wanted, current);
		}
	}
}