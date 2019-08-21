using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form1 : Form
  {
    private Form form2;

    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      Hide();
      form2 = new Form2();
      form2.Show();
      form2.FormClosed += Form2_FormClosed;

    }

    private void Form2_FormClosed(object sender, FormClosedEventArgs e)
    {
      Show();
    }
  }
}
