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

// Exception Handling
try
{
    Console.WriteLine("開始連線設備");
    int a = 10;
    int b = 0;
    // int result = a / b;   // 模擬送指令失敗
    Console.WriteLine("指令送出成功");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("送指令失敗: " + ex.Message);
}
finally
{
    Console.WriteLine("關閉設備連線");
}
Console.WriteLine("程式繼續往下執行");

// File/Log
File.AppendAllText("Equipment.log", "EQP01 Connected\n");
File.AppendAllText("Equipment.log", "EQP01 Start\n");
File.AppendAllText("Equipment.log", "EQP01 ERROR: Timeout\n");

string[] lines = File.ReadAllLines("Equipment.log");
foreach (var line in lines)
{
    if (line.Contains("ERROR"))
    {
        Console.WriteLine(line);
    }

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