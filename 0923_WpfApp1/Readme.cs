# WPF視窗飲料訂購系統ver 1
2026/9/23

## 本週進度：

### WPF佈局元件：Grid

- Grid.RowDefinitions, Grid.ColumnDefinitions
- Grid.RowSpan, Grid.ColumnSpan

### WPF佈局元件：StackPanel

- Stack.Orientation：Vertical(垂直排列), Horizontal(水平排列)

### C#選擇結構：if-else, switch case, 三元運算子

### TextBox.TextChanged事件

### 透過事件來取得呼叫的元件：

```csharp
var targetTextBox = sender as TextBox;
var targetStackPanel = targetTextBox.Parent as StackPanel;
var targetNameLabel = targetStackPanel.Children[0] as Label;
```

### 將字串轉換成整數
```csharp
int.TryParse()
Convert.ToInt32()
```