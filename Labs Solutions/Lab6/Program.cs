namespace LabsSolutions.Lab6;

public class Program
{
    public static void Start()
    {
        Account acc = new Account(111, "Bob", 100);
		try
		{
			Console.WriteLine(acc.GetDetails());
			acc.Withdraw(1000);
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			acc.Close();
		}

		for (int i = 0; i < 100; i++)
		{
			try
			{
                RegistrationPlateFactory.GetNextRegistrationPlate();
            }
            catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

    }
}
