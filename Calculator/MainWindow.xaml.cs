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

using Calculator.Services.Calculatrice;
using System.Diagnostics; 
namespace Calculator;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void buttonClick(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn)
        {
            string? buttonContent=btn.Content.ToString();
            DisplayTextBox.Text+= buttonContent;
        }
    }

    private void eraseClick(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(DisplayTextBox.Text))
        {
            DisplayTextBox.Text = DisplayTextBox.Text.Substring(0, DisplayTextBox.Text.Length-1);
        }
    }
    
    private void allEraseClick(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(DisplayTextBox.Text))
        {
            DisplayTextBox.Text = "";
        }
    }
    private void equalClick(object sender, RoutedEventArgs e)
    {
        try
        {
            string expression = DisplayTextBox.Text;
            Calculatrice calculatrice = new Calculatrice();
            var resultat = calculatrice.Calcul(expression);
            DisplayTextBox.Text = $"{resultat}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Erreur de calcul",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }

    // Gestion des caractères tapés
    private void WindowKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key >= Key.D0 && e.Key <= Key.D9 && Keyboard.Modifiers == ModifierKeys.Shift)
        {
            DisplayTextBox.Text += (e.Key - Key.D0).ToString();
            e.Handled = true;
        }
        else if (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
        {
            DisplayTextBox.Text += (e.Key - Key.NumPad0).ToString();
            e.Handled = true;
        }
        else if (e.Key == Key.Add || e.Key == Key.OemPlus)
        {
            DisplayTextBox.Text += "+";
            e.Handled = true;
        }
        else if (e.Key == Key.Subtract || e.Key == Key.OemMinus)
        {
            DisplayTextBox.Text += "-";
            e.Handled = true;
        }
        else if (e.Key == Key.Multiply)
        {
            DisplayTextBox.Text += "*";
            e.Handled = true;
        }
        else if (e.Key == Key.Divide)
        {
            DisplayTextBox.Text += "/";
            e.Handled = true;
        }
        else if (e.Key == Key.Return || e.Key == Key.Enter)
        {
            equalClick(sender, e);
            e.Handled = true;
        }
        else if (e.Key == Key.Back)
        {
            eraseClick(sender, e);
            e.Handled = true;
        }
        else if (e.Key == Key.Escape)
        {
            allEraseClick(sender, e);
            e.Handled = true;
        }
    }

    // Gestion des caractères tapés
    private void WindowTextInput(object sender, TextCompositionEventArgs e)
    {
        string input = e.Text; // Le caractère réellement tapé

        if ("0123456789".Contains(input))
        {
            // Chiffres
            DisplayTextBox.Text += input;
            e.Handled = true;
        }
        else if ("+-*/".Contains(input))
        {
            // Opérateurs
            DisplayTextBox.Text += input;
            e.Handled = true;
        }
        else if ("()".Contains(input))
        {
            // Parenthèses
            DisplayTextBox.Text += input;
            e.Handled = true;
        }
        else if (input.ToUpper() == "C") // C pour clear
        {
            DisplayTextBox.Text = "";
            e.Handled = true;
        }
    }


}