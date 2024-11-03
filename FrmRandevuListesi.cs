using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Hastahane_Yönetim_ve_Randevu_Paneli
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public int secilen;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           secilen = dataGridView1.SelectedCells[0].RowIndex;
        }
    }
}
