using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232410103061.CONTROLLER
{
    public partial class homepageMHS : Form
    {
        Models.MAHASISWA.MhsContext mhsContext;
        public homepageMHS()
        {
            using (LOG_REG_MAHASISWA formdatabaru = new LOG_REG_MAHASISWA())
            {
                if (formdatabaru.ShowDialog() == DialogResult.OK)
                {
                    Models.MAHASISWA.Mhs newRole = formdatabaru.GetMhs();
                    mhsContext.Insert(newRole);
                }
            }
            InitializeComponent();
            mhsContext = new Models.MAHASISWA.MhsContext();

            mhsContext.Read();
            dataGridView1 = new DataGridView();
            dataGridView1.DataSource = mhsContext.ListMahasiswa;
        }
    }
}
