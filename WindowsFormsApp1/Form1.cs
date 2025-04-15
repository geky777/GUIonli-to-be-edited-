using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Label welcomeLabel;

        public Form1()
        {
            InitializeComponent();
            InitializeWelcomeLabel();
        }

        private void InitializeWelcomeLabel()
        {
            this.welcomeLabel = new Label();
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new Point(50, 50);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new Size(300, 31);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to my Dental Clinic";
            this.Controls.Add(this.welcomeLabel);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
