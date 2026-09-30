using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _0923_WpfApp1
{
    public partial class MainWindow : Window
    {
       
        private string dineInOrTakeOut = "未選擇";

        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                dineInOrTakeOut = radioButton.Content.ToString();
            }
        }

       
        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = $"【用餐方式】：{dineInOrTakeOut}\n\n";
            int totalPrice = 0;

            
            foreach (StackPanel sp in DrinkMenuStackPanel.Children)
            {
                
                CheckBox chkBox = sp.Children[0] as CheckBox;
                Label priceLabel = sp.Children[1] as Label;
                Slider slider = sp.Children[2] as Slider;

                
                if (chkBox.IsChecked == true && slider.Value > 0)
                {
                    string drinkName = chkBox.Content.ToString();
               
                    int price = Convert.ToInt32(priceLabel.Content.ToString().Replace("元", ""));
                    int amount = Convert.ToInt32(slider.Value);

                    int subTotal = price * amount;
                    totalPrice += subTotal;

                    ResultTextBlock.Text += $"您選擇了 {drinkName}，數量為 {amount}，小計：{subTotal} 元\n";
                }
            }

            ResultTextBlock.Text += $"\n【總價】：{totalPrice} 元";
        }
    }
}