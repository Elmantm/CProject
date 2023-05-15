namespace Code.DataAcces.Business.Helpers;

public static class Helper
{
    public static Dictionary<string, string> Errors = new Dictionary<string, string>()
    {
        {"AllreadyExistException","This object alredy exists" }, 
        {"SizeException","Length dosen't match" }
    };
}
