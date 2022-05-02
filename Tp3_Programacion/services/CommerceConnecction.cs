using domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace services
{
    public class CommerceConnecction
    {
        public List<Product> listarProducto()
        {
            List<Product> listaProducto = new List<Product>();
            DataAccess da = new DataAccess();

            try
            {

                da.setConsulta("Select A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.ImagenUrl, M.Descripcion as Marca From ARTICULOS A left join MARCAS M on M.Id = A.IdMarca");
                da.execute();

                while (da.dataReader.Read())
                {

                    Product showP = new Product();
                    showP.codArticulo = (string)da.dataReader["Codigo"];
                    showP.Nombre = (string)da.dataReader["Nombre"];
                    showP.Descripcion = (string)da.dataReader["Descripcion"];
                    showP.Precio = (decimal)da.dataReader["Precio"];
                    showP.Marca = new ComercialBrand();
                    showP.Marca.Description = (string)da.dataReader["Marca"];
                    showP.urlImagen = (string)da.dataReader["ImagenUrl"];

                    listaProducto.Add(showP);
                }
                return listaProducto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                da.closeConnection();
            }

        }

        public Product buscarPorCod(string e)
        {
            Product response = new Product();
            DataAccess da = new DataAccess();
            try
            {
                
                //string query = "Select A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.ImagenUrl, M.Descripcion as Marca "+
                  //  " From ARTICULOS A left join MARCAS M on M.Id = A.IdMarca where A.Codigo = @Codigo";
                //SqlCommand command = new SqlCommand(query);
                //command.Parameters.AddWithValue("@Codigo", e);
                da.setConsulta("Select A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.ImagenUrl, M.Descripcion as Marca From ARTICULOS A left join MARCAS M on M.Id = A.IdMarca where A.Codigo = '" + e + "'");
                //da.setConsultaWhitParameters(command);
                
                da.execute();
                if (da.dataReader.Read())
                {
                    response.codArticulo = (string)da.dataReader["Codigo"];
                    response.Nombre = (string)da.dataReader["Nombre"];
                    response.Descripcion = (string)da.dataReader["Descripcion"];
                    response.Precio = (decimal)da.dataReader["Precio"];
                    response.Marca = new ComercialBrand();
                    response.Marca.Description = (string)da.dataReader["Marca"];
                    response.urlImagen = (string)da.dataReader["ImagenUrl"];
                }
                else
                {
                    return null;
                }

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                da.closeConnection();
            }

        }

        public Product buscarPorNombre(string e)
        {
            Product elegido = new Product();
            DataAccess da = new DataAccess();


            try
            {
                da.setConsulta("Select A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.ImagenUrl, M.Descripcion as Marca From ARTICULOS A left join MARCAS M on M.Id = A.IdMarca where A.Nombre = '" + e + "'");
                da.execute();

                if (da.dataReader.Read())
                {
                    Console.WriteLine("response" + da.dataReader.Read());
                    elegido.Nombre = (string)da.dataReader["Nombre"];
                    elegido.codArticulo = (string)da.dataReader["Codigo"];
                    elegido.Descripcion = (string)da.dataReader["Descripcion"];
                    elegido.Precio = (decimal)da.dataReader["Precio"];
                    elegido.Marca = new ComercialBrand();
                    elegido.Marca.Description = (string)da.dataReader["Marca"];
                    elegido.urlImagen = (string)da.dataReader["ImagenUrl"];
                }
                else
                {
                    return null;
                }

                return elegido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                da.closeConnection();
            }

        }
        public void addProduct(Product adding)
        {
            DataAccess da = new DataAccess();
            try
            {
                da.setConsulta("Insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values('" + adding.codArticulo + "','" + adding.Nombre + "','" + adding.Descripcion + "'," + adding.Marca.IdComercialBrand + "," + adding.Categoria.IdCategory + ",'" + adding.urlImagen + "'," + adding.Precio + ")");
                da.executeAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                da.closeConnection();
            }

        }

      /*  public int deleteProduct(String delete)
        {
            DataAccess da = new DataAccess();
            try
            {
                string query = "delete articulos where codigo = @Codigo";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@Codigo", delete);
                da.setConsultaWhitParameters(command);
                da.executeAction();
                da.dataReader.Close();
                return da.getLineCantAfected();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                da.closeConnection();
            }

        }*/

        public DataTable getConfigFromDB(string info)
        {
            DataTable data = new DataTable();
            DataAccess response = new DataAccess();
            data.Columns.Add("id");
            data.Columns.Add("descripcion");

            try
            {
                response.setConsulta("Select id, descripcion from " + info);
                response.execute();

                while (response.dataReader.Read())
                {
                    DataRow row = data.NewRow();

                    row["id"] = (int)response.dataReader["id"];
                    row["descripcion"] = (string)response.dataReader["descripcion"];

                    data.Rows.Add(row);
                }
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                response.closeConnection();
            }
        }
    }
}
