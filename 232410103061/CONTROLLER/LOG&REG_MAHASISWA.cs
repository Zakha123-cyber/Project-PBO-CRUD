using _232410103061.CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232410103061
{
    public partial class LOG_REG_MAHASISWA : Form
    {
        Models.MAHASISWA.MhsContext MhsContext;
        public Models.MAHASISWA.Mhs GetMhs()
        {
            Models.MAHASISWA.Mhs mhs = new Models.MAHASISWA.Mhs();
            mhs.nama = tb_nama.Text;
            mhs.nim = tb_nim.Text;
            mhs.email = tb_email.Text;
            mhs.no_HP = int.Parse(tb_noHP.Text);
            mhs.password = TB_pass.Text;
            return mhs;
        }
        public LOG_REG_MAHASISWA()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LOG_REG_MAHASISWA regmhs = new LOG_REG_MAHASISWA();
            Models.MAHASISWA.Mhs newMhs = regmhs.GetMhs();
            MhsContext.Insert(newMhs);
            homepageMHS homepage = new homepageMHS();
            homepage.ShowDialog();
            /*MhsContext.Insert();
            homepageMHS homepageMHS = new homepageMHS();
            homepageMHS.Show();*/

/*            using (homepageMHS homepageMHS = new homepageMHS())
            {
                if (homepageMHS.ShowDialog() == DialogResult.OK)
                {
                    Models.MAHASISWA.Mhs newMhs = homepageMHS.GetMhs
                }
            }*/
        }
    }
}
