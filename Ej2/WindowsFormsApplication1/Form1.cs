using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class theMainForm : Form
    {
        public theMainForm()
        {
            InitializeComponent();
            this.Text = "Main Window";
        }

        private void on_theButtonOne_clicked( object sender, EventArgs e )
        {
            setTextFieldButtonText(sender as Button);
        }

        private void on_theButtonTwo_clicked( object sender, EventArgs e )
        {
            setTextFieldButtonText( sender as Button );
        }

        private void setTextFieldButtonText( Button aButton )
        {
            theTextBox.Text = aButton.Text;
        }
    }
}
