using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace page
{
static class Program{
    [STAThread]
    static void Main(){
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormPrincipal());
    }
}
public class FormPrincipal : Form{
    public FormPrincipal(){
        this.Text = "hi im a gay gay gay really gay person";
        this.Size = new System.Drawing.Size(1200, 1000);
        this.BackColor = ColorTranslator.FromHtml("#4419b0");
        Label myHi = new Label();
        Hi.Text -"rsghjknrgjrsdugjhijkhrfihjr";
        
    }
}
}