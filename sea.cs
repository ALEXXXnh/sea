using System;
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
        this.Size = new System.Drawing.Size(400, 300);
        
    }
}
}