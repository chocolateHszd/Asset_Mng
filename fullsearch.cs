using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asset_Mng
{
    public partial class fullsearch : Form
    {
        public fullsearch()
        {
            InitializeComponent();
        }

        private void fullsearch_Load(object sender, EventArgs e)
        {

            SqlConnection connection = Main.connection;
            connection.Open();
            string id = Main.id;
            string com = "SELECT * From V2 WHERE [شناسه] like '%" + id + "%' or [نوع] like '%" + id +
                         "%' or [نام] like '%" + id + "%' or [واحد] like '%" + id +
                         "%' or [اتاق] like '%" + id + "%' or [مالکیت] like '%" + id + "%' or [وضعیت] like '%" + id + "%' or [مدل] like '%" + id + "%' or [تاریخ_خرید] like '%" + id + "%' or [اتمام_گارانتی] like '%" + id +
                         "%' or [نام ، نام خانوادگی] like '%" + id + "%' or [تلفن داخلی] like '%" + id + "%' or [ایمیل] like '%" + id + 
                         "%' or [سمت] like '%" + id + "%' or [نام_شرکت] like '%" + id + "%' or [رابط] like '%" + id + "%' or [تلفن] like '%" + id + "%' or [وب_سایت] like '%" + id + "%' or [آدرس] like '%" + id +  "%';";
            SqlCommand command = new SqlCommand(com, connection);
            SqlDataAdapter da = new SqlDataAdapter(command.CommandText.ToString(), connection);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
           
            da.Fill(dt);
            BindingSource bs = new BindingSource(dt, null);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
             
            connection.Close();
        }
    }
}