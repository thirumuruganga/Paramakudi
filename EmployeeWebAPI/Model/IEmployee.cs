namespace EmployeeWebAPI.Model
{
	public interface IEmployee
	{
		string Address { get; set; }
		string City { get; set; }
		string FirstName { get; set; }
		int Id { get; set; }
		bool? IsWorking { get; set; }
		string LastName { get; set; }
	}
}