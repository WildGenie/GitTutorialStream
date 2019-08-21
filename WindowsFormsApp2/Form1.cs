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
    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      var form2 = new Form2();
      form2.Show();
      form2.FormClosed += Form2_FormClosed;
      
    }

    private void Form2_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.Show();
    }
  }
}
