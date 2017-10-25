using System;
using System.Data.SqlClient;
using System.Windows.Forms;


public partial class home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\JULIAN\\DOCUMENTS\\CLIENTES.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        cmd.Connection = con;
    }

    protected void Button_insert_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd.CommandText = "insert into clientes(nombre,apellido,edad) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
        cmd.ExecuteNonQuery();
        cmd.Clone();
        MessageBox.Show("cliente agregado!!!", " Gracias");
    }
}