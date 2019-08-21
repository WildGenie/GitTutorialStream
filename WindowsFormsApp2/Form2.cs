using System;

namespace WindowsFormsApp2
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      var form3 = new Form3();
      form3.ShowDialog();
    }
  }
}
