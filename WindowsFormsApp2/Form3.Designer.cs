namespace WindowsFormsApp2
{
  partial class Form3
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.metroButton1 = new MetroFramework.Controls.MetroButton();
      this.SuspendLayout();
      // 
      // metroButton1
      // 
      this.metroButton1.Location = new System.Drawing.Point(208, 241);
      this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.metroButton1.Name = "metroButton1";
      this.metroButton1.Size = new System.Drawing.Size(228, 28);
      this.metroButton1.TabIndex = 0;
      this.metroButton1.Text = "metroButton1";
      this.metroButton1.UseSelectable = true;
      this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 554);
      this.Controls.Add(this.metroButton1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form3";
      this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
      this.Text = "Form3";
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroButton metroButton1;
  }
}