using HandyControl.Controls;
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

namespace G2CyHome.Wpf.Views
{
    /// <summary>
    /// DeviceSearch.xaml 的交互逻辑
    /// </summary>
    public partial class DeviceSearch
    {
        public DeviceSearch()
        {
            InitializeComponent();
        }

        private void btn_addbind_Click(object sender, RoutedEventArgs e)
        {
            Dialog.Show(new DeviceBind());
        }
    }
}
