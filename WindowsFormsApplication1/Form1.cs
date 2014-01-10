using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;
using ClassLibrary2;

namespace WindowsFormsApplication1
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
            BaseClass1 poo = new BaseClass1();
        }
    }
}
