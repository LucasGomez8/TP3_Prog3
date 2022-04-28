using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TpProgramacion;

namespace TpProgramacion.services
{
    class CommerceConnecction
    {
        public List<Product> listarProducto()
        {
            List<Product> listaProducto = new List<Product>();
            SqlConnection conexionBase = new SqlConnection();
            SqlCommand comandoBase = new SqlCommand();
            SqlDataReader dbReader;

            try {
                conexionBase.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true;";
                comandoBase.CommandType = System.Data.CommandType.Text;
                comandoBase.CommandText = "Select A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion as Marca From ARTICULOS A left join MARCAS M on M.Id = A.IdMarca";
                comandoBase.Connection = conexionBase;

                conexionBase.Open();
                dbReader = comandoBase.ExecuteReader();

                while (dbReader.Read())
                {

                    Product showP = new Product();
                    showP.codArticulo =(string)dbReader["Codigo"];
                    showP.Nombre = (string)dbReader["Nombre"];
                    showP.Descripcion = (string)dbReader["Descripcion"];
                    showP.Precio = (decimal)dbReader["Precio"];
                    showP.Marca = (string)dbReader["Marca"];

                    listaProducto.Add(showP);
                }

                conexionBase.Close();
                return listaProducto;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Product buscarPorCodigo(string e)
        {
            Product elegido = new Product();
            SqlConnection conexionBase = new SqlConnection();
            SqlCommand comandoBase = new SqlCommand();
            SqlDataReader dbReader;
            

            try
            {
                conexionBase.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true;";
                comandoBase.CommandType = System.Data.CommandType.Text;
                comandoBase.CommandText = "Select Codigo, Nombre, Precio, Descripcion FROM ARTICULOS";
                comandoBase.Connection = conexionBase;

                conexionBase.Open();
                dbReader = comandoBase.ExecuteReader();

                while (dbReader.Read() && e == (string)dbReader["Codigo"])
                {
                    elegido.Nombre = (string)dbReader["Nombre"];
                    elegido.codArticulo = (string)dbReader["Codigo"];
                    elegido.Descripcion = (string)dbReader["Descripcion"];
                    elegido.Precio = (decimal)dbReader["Precio"];
                }

                conexionBase.Close();
                return elegido;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Product buscarPorNombre(string e)
        {
            Product elegido = new Product();
            SqlConnection conexionBase = new SqlConnection();
            SqlCommand comandoBase = new SqlCommand();
            SqlDataReader dbReader;


            try
            {
                conexionBase.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true;";
                comandoBase.CommandType = System.Data.CommandType.Text;
                comandoBase.CommandText = "Select Codigo, Nombre, Precio, Descripcion FROM ARTICULOS";
                comandoBase.Connection = conexionBase;

                conexionBase.Open();
                dbReader = comandoBase.ExecuteReader();

                while (dbReader.Read() && e == (string)dbReader["Nombre"])
                {
                    elegido.Nombre = (string)dbReader["Nombre"];
                    elegido.codArticulo = (string)dbReader["Codigo"];
                    elegido.Descripcion = (string)dbReader["Descripcion"];
                    elegido.Precio = (decimal)dbReader["Precio"];
                }

                conexionBase.Close();
                return elegido;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
