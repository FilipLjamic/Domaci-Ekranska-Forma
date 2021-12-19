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

namespace EkranskaForma
{
    public partial class Form1 : Form
    {
        //ovde staviti ime sql servera
        static string DS = "DESKTOP-SFFGT62\\SQLEXPRESS";

        public int red = 0;
        DataTable song = new DataTable();
        string CS = "Data source=" + DS + "; Initial catalog=EkranskaFormaDomaci; Integrated security=true";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Osvezi()
        {
            if (song.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_naziv.Text = "";
                txt_izvodjac.Text = "";
                txt_trajanje.Text = "";
                txt_jezik.Text = "";

                btn_prev.Enabled = false;
                btn_next.Enabled = false;
                btn_frst.Enabled = false;
                btn_last.Enabled = false;
            }
            else
            {
                txt_id.Text = song.Rows[red]["id"].ToString();
                txt_naziv.Text = song.Rows[red]["naziv"].ToString();
                txt_izvodjac.Text = song.Rows[red]["izvodjac"].ToString();
                txt_trajanje.Text = song.Rows[red]["trajanje"].ToString();
                txt_jezik.Text = song.Rows[red]["jezik"].ToString();

                btn_next.Enabled = (red != song.Rows.Count - 1);
                btn_last.Enabled = (red != song.Rows.Count - 1);
                btn_prev.Enabled = (red != 0);
                btn_frst.Enabled = (red != 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv, izvodjac, trajanje, jezik from song order by id", veza);
            adapter.Fill(song);
            Osvezi();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            red++;
            Osvezi();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            red--;
            Osvezi();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            red = song.Rows.Count - 1;
            Osvezi();
        }

        private void btn_frst_Click(object sender, EventArgs e)
        {
            red = 0;
            Osvezi();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string pom = "insert into song(naziv, izvodjac, trajanje, jezik) values('" + txt_naziv.Text + "', '" + txt_izvodjac.Text + "', '" + txt_trajanje.Text + "', '" + txt_jezik.Text + "')";
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand(pom, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv, izvodjac, trajanje, jezik from song order by id", veza);
            song.Clear();
            adapter.Fill(song);
            red = song.Rows.Count - 1;
            Osvezi();
        }

        private void btn_edt_Click(object sender, EventArgs e)
        {
            string pom = "update song set naziv='" + txt_naziv.Text + "', izvodjac='" + txt_izvodjac.Text + "', trajanje='" + txt_trajanje.Text + "', jezik='" + txt_jezik.Text + "' WHERE id=" + txt_id.Text;
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand(pom, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv, izvodjac, trajanje, jezik from song order by id", veza);
            song.Clear();
            adapter.Fill(song);
            Osvezi();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string pom = "delete from song where id = " + txt_id.Text;
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand(pom, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv, izvodjac, trajanje, jezik from song order by id", veza);
            song.Clear();
            adapter.Fill(song);
            if (red > song.Rows.Count - 1)
                red = song.Rows.Count - 1;
            Osvezi();
        }
    }
}
