using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace UserControlDEMO
{
    public partial class UC : UserControl
    {
        public UC()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }
        public string TB1
        {
            get
            {
                return this.tb1.Text;
            }
            set
            {
                this.tb1.Text = value;
            }
        }

        public string TB2
        {
            get { return this.tb2.Text; }
            set { this.tb2.Text = value; }
        }
        public string TB3
        {
            get { return this.tb3.Text; }
            set { this.tb3.Text=value; }
        }
        public ImageSource IMG
        {
            get { return this.img.Source; }
            set { this.img.Source=value; }

        }
    }
}
