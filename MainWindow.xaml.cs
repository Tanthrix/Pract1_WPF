using System;
using System.Collections.Generic;
using System.Linq;
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

namespace X0
{
    
    public partial class MainWindow : Window
    {

        public void proverka()
        {
            if (nul <= 9)
            {
                if (btn1.Content == "X" && btn2.Content == "X" && btn3.Content == "X") MessageBox.Show("крестики победили");
                if (btn4.Content == "X" && btn5.Content == "X" && btn6.Content == "X") MessageBox.Show("крестики победили");
                if (btn7.Content == "X" && btn8.Content == "X" && btn9.Content == "X") MessageBox.Show("крестики победили");
                if (btn1.Content == "X" && btn4.Content == "X" && btn7.Content == "X") MessageBox.Show("крестики победили");
                if (btn2.Content == "X" && btn5.Content == "X" && btn8.Content == "X") MessageBox.Show("крестики победили");
                if (btn3.Content == "X" && btn6.Content == "X" && btn9.Content == "X") MessageBox.Show("крестики победили");
                if (btn1.Content == "X" && btn5.Content == "X" && btn9.Content == "X") MessageBox.Show("крестики победили");
                if (btn3.Content == "X" && btn5.Content == "X" && btn7.Content == "X") MessageBox.Show("крестики победили");
                if (btn1.Content == "O" && btn2.Content == "O" && btn3.Content == "O") MessageBox.Show("нолики победили");
                if (btn4.Content == "O" && btn5.Content == "O" && btn6.Content == "O") MessageBox.Show("нолики победили");
                if (btn7.Content == "O" && btn8.Content == "O" && btn9.Content == "O") MessageBox.Show("нолики победили");
                if (btn1.Content == "O" && btn4.Content == "O" && btn7.Content == "O") MessageBox.Show("нолики победили");
                if (btn2.Content == "O" && btn5.Content == "O" && btn8.Content == "O") MessageBox.Show("нолики победили");
                if (btn3.Content == "O" && btn6.Content == "O" && btn9.Content == "O") MessageBox.Show("нолики победили");
                if (btn1.Content == "O" && btn5.Content == "O" && btn9.Content == "O") MessageBox.Show("нолики победили");
                if (btn3.Content == "O" && btn5.Content == "O" && btn7.Content == "O") MessageBox.Show("нолики победили");
            }
            else if (nul == 9)
            {
                MessageBox.Show("ничья)");
            }
        }
        void bot()
        {
        m:

            try
            {

                if (krest == 1)
                {
                    Random ran = new Random();
                    int hod = ran.Next(1, 9);
                    if (hod == 1)
                    {
                        if (btn5.Content == "")
                        {
                            btn5.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 2)
                    {
                        if (btn7.Content == "")
                        {
                            btn7.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 3)
                    {
                        if (btn9.Content == "")
                        {
                            btn9.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 4)
                    {
                        if (btn3.Content == "")
                        {
                            btn3.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 5)
                    {
                        if (btn6.Content == "")
                        {
                            btn6.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 6)
                    {
                        if (btn8.Content == "")
                        {
                            btn8.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    if (hod == 7)
                    {
                        if (btn1.Content == "")
                        {
                            btn8.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    if (hod == 8)
                    {
                        if (btn2.Content == "")
                        {
                            btn8.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    if (hod == 9)
                    {
                        if (btn4.Content == "")
                        {
                            btn8.Content = "X"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                }
                else
                    if (krest == 0)
                {
                    Random ran = new Random();
                    int hod = ran.Next(1, 6);
                    if (hod == 1)
                    {
                        if (btn5.Content == "")
                        {
                            btn5.Content = "O"; krest = 1;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 2)
                    {
                        if (btn7.Content == "")
                        {
                            btn7.Content = "O"; krest = 1;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 3)
                    {
                        if (btn9.Content == "")
                        {
                            btn9.Content = "O"; krest = 1;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 4)
                    {
                        if (btn3.Content == "")
                        {
                            btn3.Content = "O"; krest = 1;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 5)
                    {
                        if (btn6.Content == "")
                        {
                            btn6.Content = "O"; krest = 1;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    else
                    if (hod == 6)
                    {
                        if (btn8.Content == "")
                        {
                            btn8.Content = "O"; krest = 1;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    if (hod == 7)
                    {
                        if (btn1.Content == "")
                        {
                            btn8.Content = "О"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    if (hod == 8)
                    {
                        if (btn2.Content == "")
                        {
                            btn8.Content = "О"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                    if (hod == 9)
                    {
                        if (btn4.Content == "")
                        {
                            btn8.Content = "О"; krest = 0;
                        }
                        else
                        {
                            goto m;
                        }
                    }
                }
            }
            catch
            {
                goto m;
            }

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        static int krest = 0;
        static int nul = 0;
        bool ok = true;
        private void btn_Click(object sender, RoutedEventArgs e)
        {

            Button btn = (Button)sender;

            if (ok == true)
            {

                if (btn.Content == "")
                {
                    if (krest == 0)
                    {
                        btn.Content = "O";
                        krest = 1;
                        nul++;
                    }

                    else

                    if (krest == 1)
                    {
                        btn.Content = "X";  
                        krest = 0;
                        nul++;
                    }

                }
                else
                    if (btn.Content == "O" || btn.Content == "X")
                {
                    MessageBox.Show("error");

                }

                proverka();



            }

            else
            if (ok == false)
            {
                if (btn.Content == "")
                {
                    if (krest == 0)
                    {
                        btn.Content = "O";
                        krest = 1;
                        nul++;
                        bot();
                    }

                    else

                    if (krest == 1)
                    {
                        btn.Content = "X";  
                        krest = 0;
                        nul++;
                        bot();
                    }

                }
                else
                   if (btn.Content == "O" || btn.Content == "X")
                {
                    MessageBox.Show("error");

                }

                proverka();

            }


        }

        bool gg = true;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            krest = 1;


        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            krest = 0;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = ""; btn2.Content = ""; btn3.Content = ""; btn4.Content = ""; btn5.Content = ""; btn6.Content = ""; btn7.Content = ""; btn8.Content = ""; btn9.Content = "";
            nul = 0;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            ok = true;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            ok = false;
        }
    }


}

