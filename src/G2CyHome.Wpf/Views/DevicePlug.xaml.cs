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

namespace G2CyHome.Wpf.Views
{
    /// <summary>
    /// DevicePlug.xaml 的交互逻辑
    /// </summary>
    public partial class DevicePlug
    {
        public DevicePlug()
        {
            InitializeComponent();
        }



        public string DeviceName
        {
            get { return (string)GetValue(DeviceNameProperty); }
            set { SetValue(DeviceNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DeviceName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DeviceNameProperty =
            DependencyProperty.Register("DeviceName", typeof(string), typeof(DevicePlug), new PropertyMetadata(default(string)));



        public string Descript
        {
            get { return (string)GetValue(DescriptProperty); }
            set { SetValue(DescriptProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Descript.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptProperty =
            DependencyProperty.Register("Descript", typeof(string), typeof(DevicePlug), new PropertyMetadata(default(string)));



        public Geometry Geometry
        {
            get { return (Geometry)GetValue(GeometryProperty); }
            set { SetValue(GeometryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Geometry.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GeometryProperty =
            DependencyProperty.Register("Geometry", typeof(Geometry), typeof(DevicePlug), new PropertyMetadata(default(Geometry)));


    }
}
