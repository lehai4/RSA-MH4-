using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA__team_MH4_
{
    public partial class FormRSA : Form
    {
        int RSA_soP, RSA_soQ, RSA_soN, RSA_soE, RSA_soD, RSA_soPhi_n;
        public int RSA_d_dau = 0;
       
        public FormRSA()
        {
            InitializeComponent();
        }

        private int RSA_ChonSoNgauNhien()
        {
            Random rd = new Random();
            return rd.Next(11, 101);
        }
        private  bool RSA_kiemTraSoNGT(int sngt)
        {
            bool check = true;
            if(sngt==2 || sngt == 3)
            {
                return check;
            }
            else
            {
                if(sngt==1 || sngt % 2 == 0 || sngt % 3 == 0)
                {
                    check = false;
                }
                else
                {
                    for(int i = 5; i <= Math.Sqrt(sngt); i+=6)
                    {
                        if(sngt % i  ==0 || sngt %(i+6) == 0)
                        {
                            check = false;
                            break;
                        }

                    }
                }
                return check;
            }
        }

       

        //kiem tra 2 songto cung nhau
        private bool RSA_nguyenToCungNhau (int a, int b)
        {
            bool ktx_;
            //giair thuat Euclid
            int temp;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;

            }
            if (a == 1) { ktx_ = true; }
            else ktx_ = false;
            return ktx_;
        }

        //ham lay mod
        public int RSA_mod (int mx, int ex, int nx)
        {
            //su dung thuat toan "binh phuong nhan"
            //chuyen e sang he nhi phan
            int[] a = new int[100];
            int k = 0;
            do
            {
                a[k] = ex % 2;
                k++;
                ex /= 2;
            } while (ex != 0);
            //qua trinh lay du
            int kq = 1;
            for(int i = k - 1; i >= 0; i--)
            {
                kq = (kq * kq) % nx;
                if (a[i] == 1)
                {
                    kq = (kq * mx) % nx;

                }
            }
            return kq;

        }

        private void btnKyVanBan_Click(object sender, EventArgs e)
        {

            if(txtPlaintext.Text == "")
            {
                MessageBox.Show("Nội dụng văn bản không để trống!!");
            }
            else if(txtPlaintext.Text != "")
            {
                RSA_MaHoa(txtPlaintext.Text);
                MessageBox.Show("Tiến hành ký văn bản");
            }
            
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
           
            if (txtPlainText2.Text == "")
            {
                MessageBox.Show("Nội dụng văn bản không để trống!!");
            }
            else if (txtPlainText2.Text != "")
            {
                RSA_GiaiMa(txtPlainText2.Text);
                MessageBox.Show("Tiến hành xác thực văn bản");
            }

        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                txtPlaintext.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open2 = new OpenFileDialog();
            open2.Filter = "|*.txt";
            if (open2.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open2.FileName);
                txtPlainText2.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtKeyPrivate.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                txtKeyPrivate.PasswordChar = '*';
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RSA_soP = RSA_ChonSoNgauNhien();
            RSA_soQ = RSA_ChonSoNgauNhien();
            RSA_taoKhoa();
            RSA_soP = RSA_soQ = 0;
            do
            {
                RSA_soP = RSA_ChonSoNgauNhien();
                RSA_soQ = RSA_ChonSoNgauNhien();
            } while (RSA_soP == RSA_soQ || !RSA_kiemTraSoNGT(RSA_soP) || !RSA_kiemTraSoNGT(RSA_soQ));
            txtP.Text = (RSA_soP.ToString());
            txtQ.Text = (RSA_soQ.ToString());
        }

        private void btnSinhKhoa_Click(object sender, EventArgs e)
        {
            RSA_taoKhoa();
            txtKeyPrivate.Text = (RSA_soE.ToString());
            txtPublicKey.Text = (RSA_soD.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtKeyPrivate.PasswordChar == '*')
            {
                pictureBox1.BringToFront();
                txtKeyPrivate.PasswordChar = '\0';
            }
        }

        private void btnXuatKQ2_Click(object sender, EventArgs e)
        {
            if (txtPlainText2.Text == "")
            {
                MessageBox.Show("Không có thông tin để xác thực kết quả");
            }
            else if (txtPlainText2.Text != "")
            {
                txtResult2.Text = Encoding.Unicode.GetString(data2);//in ra ne`
                if (txtResult2.Text == txtPlaintext.Text) MessageBox.Show("Xác thực đúng văn bản");
                else MessageBox.Show("Văn bản đã bị thay đổi");
                SaveFileDialog saveFileDialog2 = new SaveFileDialog();
                saveFileDialog2.InitialDirectory = @"D:\";
                saveFileDialog2.RestoreDirectory = true;
                saveFileDialog2.FileName = "*.txt";
                saveFileDialog2.DefaultExt = "txt";
                saveFileDialog2.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog2.Title = "Chọn tên file";
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = saveFileDialog2.OpenFile();
                    StreamWriter sw = new StreamWriter(fileStream);
                    sw.Write(txtResult2.Text);
                    sw.Close();
                    fileStream.Close();
                }
                //this.Close();
            }
        }

        private void btnXuatKq1_Click(object sender, EventArgs e)
        {
            if (txtPlaintext.Text == "")
            {
                MessageBox.Show("Không có thông tin để xuất kết quả");
            }
            else if(txtPlaintext.Text != "")
            {
                txtResult1.Text = Convert.ToBase64String(data);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"D:\";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "*.txt";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.Title = "Chọn tên file";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = saveFileDialog1.OpenFile();
                    StreamWriter sw = new StreamWriter(fileStream);
                    sw.Write(txtResult1.Text);
                    sw.Close();
                    fileStream.Close();
                }
            }
           
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            txtPlaintext.Clear();
            txtResult1.Clear();

        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtPlainText2.Clear();
            txtResult2.Clear();
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            txtP.Clear();
            txtQ.Clear();
            txtKeyPrivate.Clear();
            txtPublicKey.Clear();

        }

        private void FormRSA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void RSA_taoKhoa()
        {
            //tinh n = p*q;
            RSA_soN = RSA_soP * RSA_soQ;
            //tinh Phi(n) = (p-1)*(q-1)
            RSA_soPhi_n = (RSA_soP - 1) * (RSA_soQ - 1);
            //tinh e la mot so ngau nhien co gia tri 0 < e < phi(n) va la so nguye to cung nhau voi Phi(n)
            do
            {
                Random RSA_rd = new Random();
                RSA_soE = RSA_rd.Next(2, RSA_soPhi_n);
            } while (!RSA_nguyenToCungNhau(RSA_soE, RSA_soPhi_n));

            //Tinh d la nghich dao modular cua e
            RSA_soD = 0;
            int i = 2;
            while(((1+i * RSA_soPhi_n) % RSA_soE)!=0|| RSA_soD <= 0)
            {
                i++;
                RSA_soD = (1 + i * RSA_soPhi_n) / RSA_soE;
            }
        }
        byte[] data;
        public void RSA_MaHoa(string Chuoivao)
        {
            //taokhoa();
            //chuyen xau thanh ma Unicode
            byte[] mh_temp1 = Encoding.Unicode.GetBytes(Chuoivao);
            string base64 = Convert.ToBase64String(mh_temp1);

            //chuyen xau thanh ma Unicode
            int[] mh_temp2 = new int[base64.Length];
            for(int i = 0; i < base64.Length; i++)
            {
                mh_temp2[i] = (int)base64[i];
            }

            //mang a chua cac ky tu da ma hoa
            int[] mh_temp3 = new int[mh_temp2.Length];
            for(int i = 0; i < mh_temp2.Length; i++)
            {
                mh_temp3[i] = RSA_mod(mh_temp2[i], RSA_soE, RSA_soN);//ma hoa
            }

            //chuyen sang kieu ky tu trong bang ma unicode
            string str = "";
            for(int i = 0; i < mh_temp3.Length; i++)
            {
                str = str + (char)mh_temp3[i];
            }
            data = Encoding.Unicode.GetBytes(str);
            //textBox5.Text = Convert.ToBase64String(data);
            ////textBox5.Text = Convert.ToBase64String(data);
        }
        byte[] data2;
        public void RSA_GiaiMa(string ChuoiVao)
        {
            byte[] temp2 = Convert.FromBase64String(ChuoiVao);
            string giaima = Encoding.Unicode.GetString(temp2);

            int[] b = new int[giaima.Length];
            for(int i = 0; i < giaima.Length; i++)
            {
                b[i] = (int)giaima[i];
            }
            //giai ma
            int[] c = new int[b.Length];
            for(int i = 0; i < c.Length; i++)
            {
                c[i] = RSA_mod(b[i], RSA_soD, RSA_soN);//giai ma

            }

            string str = "";
            for(int i = 0; i < c.Length; i++)
            {
                str = str + (char)c[i];
            }
              data2 = Convert.FromBase64String(str);
        }

    }
}
