namespace _232410103061
{
    public partial class WELCOMEPAGE : Form
    {
        public WELCOMEPAGE()
        {
            InitializeComponent();
        }


        private void BTNLanjut_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LOG_REG_MAHASISWA lOG_REG_MHS = new LOG_REG_MAHASISWA();
                lOG_REG_MHS.Show();
            }

            else if (radioButton2.Checked)
            {
                LOG_REG_DOSEN lOG_REG_DOSEN = new LOG_REG_DOSEN();
                lOG_REG_DOSEN.Show();
            }


        }
    }
}
