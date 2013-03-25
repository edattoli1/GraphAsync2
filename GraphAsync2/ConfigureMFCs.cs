using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAsync1
{
    public partial class ConfigureMFCs : Form
    {
        public ConfigureMFCs()
        {
            InitializeComponent();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings1.Default.MFC1Gas = mfcTypeBox1.Text;
            Settings1.Default.MFC1maxRange = mfcMaxFlowBox1.Text;
            Settings1.Default.MFC2Gas = mfcTypeBox2.Text;
            Settings1.Default.MFC2maxRange = mfcMaxFlowBox2.Text;
            Settings1.Default.MFC3Gas = mfcTypeBox3.Text;
            Settings1.Default.MFC3maxRange = mfcMaxFlowBox3.Text;
            Settings1.Default.MFC4Gas = mfcTypeBox4.Text;
            Settings1.Default.MFC4maxRange = mfcMaxFlowBox4.Text;
            Settings1.Default.Save();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigureMFCs_Load(object sender, EventArgs e)
        {
            mfcTypeBox1.Text = Settings1.Default.MFC1Gas;
            mfcMaxFlowBox1.Text = Settings1.Default.MFC1maxRange;
            mfcTypeBox2.Text = Settings1.Default.MFC2Gas;
            mfcMaxFlowBox2.Text = Settings1.Default.MFC2maxRange;
            mfcTypeBox3.Text = Settings1.Default.MFC3Gas;
            mfcMaxFlowBox3.Text = Settings1.Default.MFC3maxRange;
            mfcTypeBox4.Text = Settings1.Default.MFC4Gas;
            mfcMaxFlowBox4.Text = Settings1.Default.MFC4maxRange;
            
        }
    }
}
