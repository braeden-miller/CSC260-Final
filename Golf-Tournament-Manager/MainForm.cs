using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf_Tournament_Manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tblLeaderboard.Sort(tblLeaderboard.Columns["NetScore"], ListSortDirection.Descending);
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                tblLeaderboard.Rows.Add("Test", random.Next(-5,15));
            }
        }
    }
}
