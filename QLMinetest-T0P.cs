using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
public class Proga:Form
{

Button button1;
Button button2;
Label label1;
TextBox textbox1;

public Proga()
{
this.Text="Лаунчер QLMinetest-T0P v0.9 (c) 2018 MineTest-T0P";
this.Size=new Size(450,250);
this.FormBorderStyle=FormBorderStyle.FixedSingle;
this.StartPosition=FormStartPosition.CenterScreen;
this.BackColor=Color.White;
label1=new Label();
label1.Text="Для начала игры, введите свой НИК и нажмите кнопку СТАРТ.";
label1.Location=new Point(30,25);
label1.Width=400;

button1=new Button();
button2=new Button();
button1.Text="&Старт!";
button1.Top=100;
button1.Left=100;
button1.Width=250;
button1.Cursor=Cursors.Hand;
button1.Click+=new System.EventHandler(MyStarter);
this.Controls.Add(label1);
this.Controls.Add(button1);

button2.Cursor=Cursors.Hand;
button2.Text="&Выход";
button2.Top=140;
button2.Left=100;
button2.Width=250;
button2.Click+=new System.EventHandler(MyExit);
this.Controls.Add(button2);

textbox1=new TextBox();
textbox1.Text="NoNameUser";
textbox1.Width=100;
textbox1.Location=new Point(175,60);
this.Controls.Add(textbox1);

}
public static void Main()
{
Application.Run(new Proga());
}
void MyStarter(object sender, EventArgs e)
{
if ((textbox1.Text!="") && ( textbox1.Text!="NoNameUser"))
{
Process.Start("minetest",
"--go --address minetesthosting.com --port 31665 --name "+textbox1.Text);
}
else
{
MessageBox.Show("Введите свой НИК!!!",
"Внимание!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
}
}
void MyExit(object sender, EventArgs ee)
{
//MessageBox.Show("Выход из программы");
Application.Exit();
}
}
