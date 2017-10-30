using System;
using System.Data.SqlClient;   //se agregan para la conexion a bd
using System.Windows.Forms;   //se agrega para la ventana emergente


public partial class home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\JULIAN\\DOCUMENTS\\CLIENTES.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    SqlCommand cmd = new SqlCommand();

    //para las listas
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
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";

        //desde aqui empezamos a llamar metos
        cargarLista();
    }

    //metodos
    public void cargarLista() {

        con.Open();
        cmd.CommandText = "select * from clientes";
        //data reader
        dr = cmd.ExecuteReader();

        if (dr.HasRows) {
            while (dr.Read()) {
                ListBox1.Items.Add(dr[0].ToString());
                ListBox2.Items.Add(dr[1].ToString());
            }
        }
        con.Close();
    }    
}