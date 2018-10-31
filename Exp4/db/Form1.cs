using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace db
{
    public partial class salary : Form
    {
        public  int da;
  

        
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\Eldhos369\Exp4\db\Database1.mdf;Integrated Security=True");
        
        public salary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet1.users);
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null)
            {
           
                da = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="INSERT INTO users VALUES('"+id.Text+"','"+name.Text+"','"+salaryInput.Text+"')";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Saved");
            reload();
            clr();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (id.Text== null)
            {
                da =int.Parse(id.Text);
            }
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM users WHERE id='" + da + "'";
     
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Deleted");
            reload();
            clr();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            clr();
            reload();

        }
        
        

        private void update_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE users SET name='"+name.Text+"' WHERE  id='"+id.Text+"' ";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated");
            reload();
            clr();
        }
        public void reload()
        {
            String strupdate = "Select * from users";
            SqlDataAdapter myAdapter = new SqlDataAdapter(strupdate, connection);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = myTable;
            dataGridView1.DataSource = bs1;
        }
        public void clr()
        {
            id.Clear();
            name.Clear();
            salaryInput.Clear();
        }
    }

 
       
    
}
