Equipment eq1 = new Equipment();
eq1.ID = "EQP01";
eq1.Start();

Console.WriteLine(eq1.ID);
Console.WriteLine(eq1.Status);
eq1.Stop();
Console.WriteLine(eq1.Status);

public class Equipment
{
    public string ID { get; set; }
    public string Status { get; set; }

    public void Start()
    {
        Status = "RUN";
    }
    public void Stop()
    {
        Status = "IDLE";
    }
}