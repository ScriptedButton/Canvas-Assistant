using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.IO;
using System.Net;
using static Canvas.Main;

namespace Canvas
{
    public partial class Portal : MaterialSkin.Controls.MaterialForm
    {
        public static bool success = false;
        public Portal()
        {        
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void Portal_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor


                string filename = System.IO.Directory.GetCurrentDirectory() + "\\token.txt";
                using (StreamWriter writeFile = new StreamWriter(filename, true))
                {
                    writeFile.Write(token.Text);
                }
                

                this.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Exception: " + err.Message);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            WebClient Wc = new WebClient();
            string request = Wc.DownloadString("http://boundcraft.pw/newuser.php?username=" + username.Text + "&password=" + password.Text + "&token=" + token.Text);
            if (request.Contains("exists"))
            {
                MessageBox.Show("That user already exists!");
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            WebClient Wc = new WebClient();
            string request = Wc.DownloadString("http://boundcraft.pw/login.php?username=" + username.Text + "&password=" + password.Text);
            if (request != "")
            {
                Main.updateToken(request);
                try
                {

                    //Pass the filepath and filename to the StreamWriter Constructor


                    string filename = System.IO.Directory.GetCurrentDirectory() + "\\token.txt";
                    using (StreamWriter writeFile = new StreamWriter(filename, true))
                    {
                        writeFile.Write(request);
                    }


                    this.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine("Exception: " + err.Message);
                }
                MessageBox.Show("Login successful!");
                success = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login!");
            }
        }

        private void Portal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!success)
            {
                e.Cancel = true;
            }
        }
    }
}
