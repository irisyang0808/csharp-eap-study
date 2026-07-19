# C# EAP/RMS 學習筆記

紀錄我從零開始學習 C#,目標是為了未來 EAP/RMS 相關工作做準備。
使用 Socratic 教學法(問答引導),搭配實際手寫程式碼練習。

## 學習進度

### Day 1: Class / Object
- 理解 class(設計圖) vs object(實體)
- Property 與 Method 的差異
- 範例:Equipment 設備物件

### Day 2: Interface
- 理解 interface 如何讓不同種類的物件共用同一套操作規格
- 搭配 List<T> + foreach 練習多型(polymorphism)
- 範例:IEquipment、SimulatorEquipment、PlcEquipment

### Day 3: Exception Handling
- try / catch / finally 的執行順序與用途
- 多個 catch 依錯誤型別處理,順序要「具體 → 籠統」
- finally 用於確保資源釋放(例如關閉設備連線)

### Day 4: File / Log
- WriteAllText(覆蓋) vs AppendAllText(累加)
- ReadAllText vs ReadAllLines
- 練習寫入並篩選設備 log

## 環境
- .NET 8.0 SDK
- VS Code + C# Dev Kit