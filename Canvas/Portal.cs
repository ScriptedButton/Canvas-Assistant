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
                StreamWriter sw = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + "\\token.txt");

                //Write a line of text
                sw.Write(materialSingleLineTextField1.Text);

                //Close the file
                sw.Close();
                Main main = new Main();
                main.Show();
            }
            catch (Exception err)
            {
                Console.WriteLine("Exception: " + err.Message);
            }
        }
    }
}
