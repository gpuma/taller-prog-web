using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MatrixView
{
    //Necesitamos crear necesariamente un nuevo Template con el control
    //que deseamos empotrar en el Gridview
    class TextColumn : ITemplate
    {
        //necesitamos especificar la columna cuando creamos este control
        //para poder encontrarlo posteriormente
        int columna;
        public TextColumn(int col)
        {
            columna = col;
        }
        void ITemplate.InstantiateIn(Control container)
        {
            //txtBox = new TextBox() { ID = ("txtcol" + columna), Width = 50 };
            container.Controls.Add(new TextBox() { ID = ("txtcol" + columna), Width = 50 });
        }
    }
    
    public partial class Default : System.Web.UI.Page
    {
        void PrepararGridNxN(GridView grd, int n)
        {
            var dt = new DataTable();
            //agregamos columnas
            for (int i = 0; i < n; i++)
            {
                grd.Columns.Add(new TemplateField() {ItemTemplate = new TextColumn(i) });
                //como el datatable no sabe que va a ser enlazad también tenemos que agregar
                //columnas aquí antes de agregar filas
                dt.Columns.Add();
            }
            //agregamos filas
            for (int i = 0; i < n; i++)
            {
                //arreglo de nx1 de puro zero
                dt.Rows.Add(Enumerable.Repeat(0, n).ToArray());
            }

            grd.DataSource = dt;
            grd.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: falta n por interfaz
            int n = 2;
            PrepararGridNxN(grdMatriz, n);
        }

        public void btnCalc_Click(object sender, EventArgs e)
        {
            ObtenerMatrizDeGrid(grdMatriz, 2);
        }

        private double[][] ObtenerMatrizDeGrid(GridView grd, int n)
        {
            //jagged array
            var matriz = new double[n][];

            //n indica el número máximo de elementos
            var tmpFila = new List<string>(n);

            for (int fil = 0; fil < n; fil++)
            {
                //borra todos los elementos para poder usarlo de nuevo
                tmpFila.Clear();
                for (int col = 0; col < n; col++)
                {
                    //obtenemos el texto de cada control y lo metemos a una lista
                    tmpFila.Add(((TextBox)grd.Rows[fil].FindControl("txtcol" + col)).Text);
                }
                //convertimos nuestra lista de cadenas a un arreglo de doubles
                var filaDoubles = tmpFila.ConvertAll(x => Convert.ToDouble(x)).ToArray();

                //asignamos la fila entera, c# no es muy bueno para manipulación de arreglos y vectores
                matriz[fil] = filaDoubles;
            }
            //TODO: falta cambiar de jagged array a multidimensional
            return matriz;
        }
    }
}