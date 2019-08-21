using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form1 : MetroFramework.Forms.MetroForm
  {
    private Form form2;
    
    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (this.form2 != null && this.form2.IsDisposed)
      {
       this.form2 = new Form2();
      }
      
      this.form2.Show();
      
    }
  }
}
