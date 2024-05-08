using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyGeGe
{
    public partial class MonitorListSetting : Form
    {
        public MonitorListSetting()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_mdata.Text.Length > 0)
            {
                list_monitor.Items.Add(txt_mdata.Text);
                txt_mdata.Text = "";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_monitor.SelectedItem != null)
            {
                list_monitor.Items.Remove(list_monitor.SelectedItem);
            }
        }

        private void MonitorListSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
