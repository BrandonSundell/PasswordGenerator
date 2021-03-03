using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PasswordGenerator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void GeneratePassword(object sender, RoutedEventArgs e)
        {
            if ((bool)_15CharButton.IsChecked)
            {
                resultDisplay.Text = Generate15();
            }
            else if ((bool)_20CharButton.IsChecked)
            {
                resultDisplay.Text = Generate20();
            }
            else if ((bool)_25CharButton.IsChecked)
            {
                resultDisplay.Text = Generate25();
            }
            else
            {
                string errorString = "Error: Plese select the character length!";
                resultDisplay.Text = errorString;
            }
        }

        public static string Generate25()
        {
            string newPassword = "";
            string validChars = "!@$#%!@$#%ABCDEFGHIJKLMNOPQRSTUVWXYZ!@$#%!@$#%0123456789876543210!@$#%!@$#%abcdefghijklmnopqrstuvwxyz!@$#%!@$#%";

            //loop that pull random characters from a string of valid characters and adds 
            //it to the newPassword string with 25 characters
            for (int i = 0; i < 25; i++)
            {
                Random rand = new Random();
                int randChar = rand.Next(0, validChars.Length - 1);
                newPassword += validChars[randChar];
            }
            return newPassword;
        }

        public static string Generate20()
        {
            string newPassword = "";
            string validChars = "!@$#%!@$#%ABCDEFGHIJKLMNOPQRSTUVWXYZ!@$#%!@$#%0123456789876543210!@$#%!@$#%abcdefghijklmnopqrstuvwxyz!@$#%!@$#%";

            //loop that pull random characters from a string of valid characters and adds 
            //it to the newPassword string with 20 characters
            for (int i = 0; i < 20; i++)
            {
                Random rand = new Random();
                int randChar = rand.Next(0, validChars.Length - 1);
                newPassword += validChars[randChar];
            }
            return newPassword;
        }

        public static string Generate15()
        {
            string newPassword = "";
            string validChars = "!@$#%!@$#%ABCDEFGHIJKLMNOPQRSTUVWXYZ!@$#%!@$#%0123456789876543210!@$#%!@$#%abcdefghijklmnopqrstuvwxyz!@$#%!@$#%";

            //loop that pull random characters from a string of valid characters and adds 
            //it to the newPassword string with 15 characters
            for (int i = 0; i < 15; i++)
            {
                Random rand = new Random();
                int randChar = rand.Next(0, validChars.Length - 1);
                newPassword += validChars[randChar];
            }
            return newPassword;
        }

        private void _15CharButton_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void _20CharButton_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void _25CharButton_Checked(object sender, RoutedEventArgs e)
        {
        }

    }
}
