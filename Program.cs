try
{
    WebApplication.Create();

    Console.WriteLine("Runtime validation success.");
}
catch
{
    Console.WriteLine("Runtime validation failure.");
    throw;
}