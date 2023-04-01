using login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demopractica
{
    public partial class main : Form
    {
        Class1 dataBase = new Class1();
        DataTable tovar = new DataTable();
        int counter;

        public main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void main_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("select * from products_b_import", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        public void GetData(int counter)
        {
            label21.Text = tovar.Rows[counter][0].ToString(); // наименование
            label1.Text = tovar.Rows[counter][4].ToString(); // тип продукта 
            label41.Text = tovar.Rows[counter][1].ToString(); // артикул 
            label81.Text = tovar.Rows[counter][2].ToString(); // стоимость
            label61.Text = "Материалы " + tovar.Rows[counter][4].ToString(); // материалы
            pictureBox1.Image = Image.FromFile(tovar.Rows[counter][3].ToString());

            label22.Text = tovar.Rows[counter+1][0].ToString(); // наименование
            label2.Text = tovar.Rows[counter+1][4].ToString(); // тип продукта 
            label42.Text = tovar.Rows[counter+1][1].ToString(); // артикул 
            label82.Text = tovar.Rows[counter+1][2].ToString(); // стоимость
            label62.Text = "Материалы " + tovar.Rows[counter + 1][4].ToString(); // материалы
            pictureBox2.Image = Image.FromFile(tovar.Rows[counter + 1][3].ToString());

            label23.Text = tovar.Rows[counter + 2][0].ToString(); // наименование
            label3.Text = tovar.Rows[counter + 2][4].ToString(); // тип продукта 
            label43.Text = tovar.Rows[counter + 2][1].ToString(); // артикул 
            label83.Text = tovar.Rows[counter + 2][2].ToString(); // стоимость
            label63.Text = "Материалы " + tovar.Rows[counter + 2][4].ToString(); // материалы
            pictureBox3.Image = Image.FromFile(tovar.Rows[counter+2][3].ToString());

            label24.Text = tovar.Rows[counter + 3][0].ToString(); // наименование
            label4.Text = tovar.Rows[counter + 3][4].ToString(); // тип продукта 
            label44.Text = tovar.Rows[counter + 3][1].ToString(); // артикул 
            label84.Text = tovar.Rows[counter + 3][2].ToString(); // стоимость
            label64.Text = "Материалы " + tovar.Rows[counter + 3][4].ToString(); // материалы
            pictureBox4.Image = Image.FromFile(tovar.Rows[counter+3][3].ToString());

            label25.Text = tovar.Rows[counter + 4][0].ToString(); // наименование
            label5.Text = tovar.Rows[counter + 4][4].ToString(); // тип продукта 
            label45.Text = tovar.Rows[counter + 4][1].ToString(); // артикул 
            label85.Text = tovar.Rows[counter + 4][2].ToString(); // стоимость
            label65.Text = "Материалы " + tovar.Rows[counter + 4][4].ToString(); // материалы
            pictureBox5.Image = Image.FromFile(tovar.Rows[counter+4][3].ToString());

            label26.Text = tovar.Rows[counter + 5][0].ToString(); // наименование
            label6.Text = tovar.Rows[counter + 5][4].ToString(); // тип продукта 
            label46.Text = tovar.Rows[counter + 5][1].ToString(); // артикул 
            label86.Text = tovar.Rows[counter + 5][2].ToString(); // стоимость
            label66.Text = "Материалы " + tovar.Rows[counter + 5][4].ToString(); // материалы
            pictureBox6.Image = Image.FromFile(tovar.Rows[counter+5][3].ToString());

            label27.Text = tovar.Rows[counter + 6][0].ToString(); // наименование
            label7.Text = tovar.Rows[counter + 6][4].ToString(); // тип продукта 
            label47.Text = tovar.Rows[counter + 6][1].ToString(); // артикул 
            label87.Text = tovar.Rows[counter + 6][2].ToString(); // стоимость
            label67.Text = "Материалы " + tovar.Rows[counter + 6][4].ToString(); // материалы
            pictureBox7.Image = Image.FromFile(tovar.Rows[counter+6][3].ToString());

            label28.Text = tovar.Rows[counter + 7][0].ToString(); // наименование
            label8.Text = tovar.Rows[counter + 7][4].ToString(); // тип продукта 
            label48.Text = tovar.Rows[counter + 7][1].ToString(); // артикул 
            label88.Text = tovar.Rows[counter + 7][2].ToString(); // стоимость
            label68.Text = "Материалы " + tovar.Rows[counter + 7][4].ToString(); // материалы
            pictureBox8.Image = Image.FromFile(tovar.Rows[counter+7][3].ToString());

            label29.Text = tovar.Rows[counter + 8][0].ToString(); // наименование
            label9.Text = tovar.Rows[counter + 8][4].ToString(); // тип продукта 
            label49.Text = tovar.Rows[counter + 8][1].ToString(); // артикул 
            label89.Text = tovar.Rows[counter + 8][2].ToString(); // стоимость
            label69.Text = "Материалы " + tovar.Rows[counter + 8][4].ToString(); // материалы
            pictureBox9.Image = Image.FromFile(tovar.Rows[counter+8][3].ToString());

            label30.Text = tovar.Rows[counter + 9][0].ToString(); // наименование
            label10.Text = tovar.Rows[counter + 9][4].ToString(); // тип продукта 
            label50.Text = tovar.Rows[counter + 9][1].ToString(); // артикул 
            label90.Text = tovar.Rows[counter + 9][2].ToString(); // стоимость
            label70.Text = "Материалы " + tovar.Rows[counter + 9][4].ToString(); // материалы
            pictureBox10.Image = Image.FromFile(tovar.Rows[counter+9][3].ToString());

            label31.Text = tovar.Rows[counter + 10][0].ToString(); // наименование
            label11.Text = tovar.Rows[counter + 10][4].ToString(); // тип продукта 
            label51.Text = tovar.Rows[counter + 10][1].ToString(); // артикул 
            label91.Text = tovar.Rows[counter + 10][2].ToString(); // стоимость
            label71.Text = "Материалы " + tovar.Rows[counter + 10][4].ToString(); // материалы
            pictureBox11.Image = Image.FromFile(tovar.Rows[counter+10][3].ToString());

            label32.Text = tovar.Rows[counter + 11][0].ToString(); // наименование
            label12.Text = tovar.Rows[counter + 11][4].ToString(); // тип продукта 
            label52.Text = tovar.Rows[counter + 11][1].ToString(); // артикул 
            label92.Text = tovar.Rows[counter + 11][2].ToString(); // стоимость
            label72.Text = "Материалы " + tovar.Rows[counter + 11][4].ToString(); // материалы
            pictureBox12.Image = Image.FromFile(tovar.Rows[counter+11][3].ToString());

            label33.Text = tovar.Rows[counter + 12][0].ToString(); // наименование
            label13.Text = tovar.Rows[counter + 12][4].ToString(); // тип продукта 
            label53.Text = tovar.Rows[counter + 12][1].ToString(); // артикул 
            label93.Text = tovar.Rows[counter + 12][2].ToString(); // стоимость
            label73.Text = "Материалы " + tovar.Rows[counter + 12][4].ToString(); // материалы
            pictureBox13.Image = Image.FromFile(tovar.Rows[counter+12][3].ToString());

            label34.Text = tovar.Rows[counter + 13][0].ToString(); // наименование
            label14.Text = tovar.Rows[counter + 13][4].ToString(); // тип продукта 
            label54.Text = tovar.Rows[counter + 13][1].ToString(); // артикул 
            label94.Text = tovar.Rows[counter + 13][2].ToString(); // стоимость
            label74.Text = "Материалы " + tovar.Rows[counter + 13][4].ToString(); // материалы
            pictureBox14.Image = Image.FromFile(tovar.Rows[counter+13][3].ToString());

            label35.Text = tovar.Rows[counter + 14][0].ToString(); // наименование
            label15.Text = tovar.Rows[counter + 14][4].ToString(); // тип продукта 
            label55.Text = tovar.Rows[counter + 14][1].ToString(); // артикул 
            label95.Text = tovar.Rows[counter + 14][2].ToString(); // стоимость
            label75.Text = "Материалы " + tovar.Rows[counter + 14][4].ToString(); // материалы
            pictureBox15.Image = Image.FromFile(tovar.Rows[counter+14][3].ToString());

            label36.Text = tovar.Rows[counter + 15][0].ToString(); // наименование
            label16.Text = tovar.Rows[counter + 15][4].ToString(); // тип продукта 
            label56.Text = tovar.Rows[counter + 15][1].ToString(); // артикул 
            label96.Text = tovar.Rows[counter + 15][2].ToString(); // стоимость
            label76.Text = "Материалы " + tovar.Rows[counter + 15][4].ToString(); // материалы
            pictureBox16.Image = Image.FromFile(tovar.Rows[counter+15][3].ToString());

            label37.Text = tovar.Rows[counter + 16][0].ToString(); // наименование
            label17.Text = tovar.Rows[counter + 16][4].ToString(); // тип продукта 
            label57.Text = tovar.Rows[counter + 16][1].ToString(); // артикул 
            label97.Text = tovar.Rows[counter + 16][2].ToString(); // стоимость
            label77.Text = "Материалы " + tovar.Rows[counter + 16][4].ToString(); // материалы
            pictureBox17.Image = Image.FromFile(tovar.Rows[counter+16][3].ToString());

            label38.Text = tovar.Rows[counter + 17][0].ToString(); // наименование
            label18.Text = tovar.Rows[counter + 17][4].ToString(); // тип продукта 
            label58.Text = tovar.Rows[counter + 17][1].ToString(); // артикул 
            label98.Text = tovar.Rows[counter + 17][2].ToString(); // стоимость
            label78.Text = "Материалы " + tovar.Rows[counter + 17][4].ToString(); // материалы
            pictureBox18.Image = Image.FromFile(tovar.Rows[counter+17][3].ToString());

            label39.Text = tovar.Rows[counter + 18][0].ToString(); // наименование
            label19.Text = tovar.Rows[counter + 18][4].ToString(); // тип продукта 
            label59.Text = tovar.Rows[counter + 18][1].ToString(); // артикул 
            label99.Text = tovar.Rows[counter + 18][2].ToString(); // стоимость
            label79.Text = "Материалы " + tovar.Rows[counter + 18][4].ToString(); // материалы
            pictureBox19.Image = Image.FromFile(tovar.Rows[counter+18][3].ToString());

            label40.Text = tovar.Rows[counter + 19][0].ToString(); // наименование
            label20.Text = tovar.Rows[counter + 19][4].ToString(); // тип продукта 
            label60.Text = tovar.Rows[counter + 19][1].ToString(); // артикул 
            label100.Text = tovar.Rows[counter + 19][2].ToString(); // стоимость
            label80.Text = "Материалы " + tovar.Rows[counter + 19][4].ToString(); // материалы
            pictureBox20.Image = Image.FromFile(tovar.Rows[counter+19][3].ToString());
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("select * from products_b_import ORDER BY Наименование_продукции ASC", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("select * from products_b_import ORDER BY Наименование_продукции DESC", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void одинСлойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


        }

        private void дваСлояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


        }

        private void триСлояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


        }

        private void детскаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


        }

        private void суперМягкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();


        }
    }
}
