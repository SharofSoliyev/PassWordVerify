using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PassWordVerify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string t = txtbx.Text;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "#?!,-'/`_*$";
            string password = t;
            int score = 0;
            int daraja = t.Length;

            if (Contains(password, uppercase))
            {
                score += 26; 
            }

            if (Contains(password, lowercase))
            {
                score += 26;
            }

            if (Contains(password, digits))
            {
                score += 10;
            }

            if (Contains(password, specialChars))
            {
                score += 12;
            }

            BigInteger a = BigInteger.Pow(score, daraja);
            BigInteger p = a / 100000000;
            BigInteger big = p / 31536000;
            if (big == 0)
            {
                big = p / 86400;
                if (big == 0)
                {
                    big = p / 3600;
                    if (big == 0)
                    {
                        big = p / 60;
                        if (big == 0)
                        {
                            big = p ;

                            natija.Content = big.ToString() + " sekundda buza oladi !";

                        }
                        else
                            natija.Content = big.ToString() + " minutda buza oladi !";

                    }
                    else
                        natija.Content = big.ToString() + " soatda buza oladi !";
                }
                else
                    natija.Content = big.ToString() + " kunda buza oladi !";
            }
           else
            natija.Content = big.ToString() + " yilda buza oladi !";


        }
        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}
