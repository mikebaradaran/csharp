using LabsSolutions.Lab3;

namespace LabsSolutions.Lab6;
public class RegistrationPlateFactory
{
    private static int count = 0;

    private static string[] regPlates = { "MRB1G", "RU16", "TOYS4US", "HNZ57", "PUT3", "JB007" };

    private RegistrationPlateFactory()
    {
    }

    public static RegistrationPlate GetNextRegistrationPlate()
    {
        if (count < regPlates.Length)
            return new RegistrationPlate(regPlates[count++]);
        else
            throw new ArgumentException("No reg plates left to issue!");
    }
}
