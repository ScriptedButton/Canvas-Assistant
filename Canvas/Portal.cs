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

namespace Canvas
{
    public partial class Portal : MaterialSkin.Controls.MaterialForm
    {
        public Portal()
        {
            InitializeComponent();
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
                    writeFile.Write(materialSingleLineTextField1.Text);
                }

                Main main = new Main();
                main.updateToken(materialSingleLineTextField1.Text);

                this.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Exception: " + err.Message);
            }
        }
    }
}
