using System;
using System.Collections.Generic;
using System.Linq;
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
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Core;

namespace BarSplitButtonItem {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        #region #1
        private void btnFontColor_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            PopupControlContainer pcc = (e.Item as DevExpress.Xpf.Bars.BarSplitButtonItem).PopupControl as PopupControlContainer;
            Color color = ((pcc.Content as ThemedUserControl).Content as ColorChooser).Color;
            MessageBox.Show("Color is applied: " + color.ToString());
        }
        #endregion #1
    }
}
