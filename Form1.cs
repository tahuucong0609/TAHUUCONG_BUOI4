namespace TAHUUCONG_BUOI4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sinhvien sv=new sinhvien(txt_mssv.Text,txt_hoten.Text,txt_gioitinh.Text,dt_ngaySinh.Value,txt_diachi.Text);

            MessageBox.Show(sv.getHoTen());
            sinhvien sv1= new sinhvien();
            sv1.setMSSV(txt_mssv.Text);
            sv1.setHoTen(txt_hoten.Text);
        }
    }
}
