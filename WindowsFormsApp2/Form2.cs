namespace WindowsFormsApp2
{
  using System;
  using System.Windows.Forms;

  public partial class Form2 : Form
  {
    public Form2()
    {
      this.InitializeComponent();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      var form3 = new Form3();
      form3.ShowDialog();
    }
  }
}