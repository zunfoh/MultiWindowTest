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
using System.Windows.Shapes;

namespace MultiWindowTest
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        string testMsg;

        public SecondWindow()
        {
            InitializeComponent();
        }


        public void SetTestMsg(string s)
        {
            testMsg = s;
        }


        private void showTestMsg_Click(object sender, RoutedEventArgs e)
        {
            testMsgDisplay.Text = testMsg;
        }
    }
}
