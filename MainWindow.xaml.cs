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


/*  This program tests how two windows can be use to pass information.  MainWindow will pass info to SecondWindow for display in the latter's textblock.
 * 
 * 
 * */

namespace MultiWindowTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string testMsg;
        bool msgLoaded=false;

        SecondWindow newWin;

        public MainWindow()
        {
            InitializeComponent();
            newWin = new SecondWindow();
            testTxt.KeyDown += testTxt_KeyDown;
        }

        void testTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)       // done with editing of test msg by pressing Enter key
            {
                testMsg = ((TextBox)sender).Text;
                msgLoaded = true;
                if (newWin.IsVisible)
                {
                    newWin.testMsgDisplay.Text = "(msg updated)";
                    newWin.SetTestMsg(testMsg);
                }
            }
            
        }

        

        private void showNewWin_Click(object sender, RoutedEventArgs e)
        {
            if (!newWin.IsVisible && msgLoaded)
            {
                ((Button)sender).Content = "Hide New Win";
                
                newWin.SetTestMsg(testMsg);
                newWin.Show();

            }
            else
            {
                newWin.Hide();
                ((Button)sender).Content = "Show New Win";
            }
        }


        
    }
}
