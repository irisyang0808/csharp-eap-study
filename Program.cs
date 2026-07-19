// === top-level statements(執行程式碼)===
Equipment eq1 = new Equipment();
eq1.ID = "EQP01";

eq1.Start();
Console.WriteLine(eq1.ID);
Console.WriteLine(eq1.Status);

eq1.Stop();
Console.WriteLine(eq1.Status);

// 這裡加上你這次要寫的執行程式碼
SimulatorEquipment eq2 = new SimulatorEquipment();
eq2.Connect();
Console.WriteLine(eq2.Status);
eq2.Disconnect();
Console.WriteLine(eq2.Status);


List<IEquipment> allEquipment = new List<IEquipment>();
allEquipment.Add(new SimulatorEquipment());
allEquipment.Add(new PlcEquipment());

foreach (var eq in allEquipment)
{
    eq.Connect();   
}



// === 下面是 class / interface 定義 ===
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

// 這裡加上你這次要寫的 interface 跟 class
public interface IEquipment
{
    void Connect();
    void Disconnect();
}

public class SimulatorEquipment: IEquipment
{
    public string Status { get; set; }
    public void Connect()
    {
        Status = "Simulator Connected";
        Console.WriteLine("Simulator Connected");
    }
    public void Disconnect()
    {
        Status = "Simulator Disconnected";
    }
}

public class PlcEquipment: IEquipment
{
    public void Connect()
    {
        Console.WriteLine("PLC Connected");
    }
    public void Disconnect()
    {
        Console.WriteLine("PLC Disconnected"); 
    }
}