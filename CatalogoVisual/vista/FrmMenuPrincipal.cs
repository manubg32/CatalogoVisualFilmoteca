using CatalogoVisual.modelo;
using CatalogoVisual.controlador;
using System.Windows.Forms.VisualStyles;
using CatalogoVisual.vista;

namespace CatalogoVisual
{

    public partial class FrmMenuPrincipal : Form
    {

        static GestionAv ga = new GestionAv(); //Instanciamos un GestorAv para que se encargue de lo necesario


        //Inicializamos las listas necesarias
        public static List<Audiovisual> avs = new List<Audiovisual>();
        public static List<Audiovisual> avsFiltrados = new List<Audiovisual>();
        public static List<Audiovisual> avsMostrados = new List<Audiovisual>();

        //Dos booleanos que nos serviran mas alante
        public static bool estaFiltrando;
        public static bool esElPrimero = true;

        private int pos = 0;//Para que inicie el primer elemento de la lista
        private static Audiovisual avMostrado;

        //Instanciamos todas las ventanas
        FrmAlta frmAlta = new FrmAlta();
        FrmFiltrar frmFiltrar = new FrmFiltrar();
        FrmEliminar frmEliminar = new FrmEliminar();
        FrmListar frmListar = new FrmListar();
        FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
        FrmDetalles frmDetalles;


        public FrmMenuPrincipal()
        {
            InitializeComponent();//Inicializamos los componentes
            ga.CargarLista(); //Cargamos la lista guardada en archivo
            this.FormClosing += FrmMenuPrincipal_FormClosing; //Le damos funcionalidad al boton de cerrar la aplicacion
            
            avs = UtilsStatic.avs; //Creamos una lista local copia de la lista que se ha cargado de memoria
            avsMostrados = avs; //Cuando se inicia la aplicacion esa será la que se muestre
            
            //Comprobamos si existen elementos en la lista y si no forzamos a crear el primero
            if (avsMostrados.Count > 0)
            {
                avMostrado = avsMostrados[pos];
                mostrarElemento(avMostrado);//Le mandamos el primer elemento de la lista
            }
            else
            {
                MessageBox.Show("Esto está un poco vacío...\n¡Da de alta tu primer elemento!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAlta.ShowDialog();
                actualizar();
                actualizarElementoMostrado();
            }


            actualizarElementoMostrado(); //Actualizamos el [1/10] (Ejemplo)
        }

        private void FrmMenuPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //Mostramos el mensaje de guardar antes de salir
            var opc = MessageBox.Show(
                "¿Deseas guardar antes de salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (opc == DialogResult.Yes)
            {
                GestionAv.GuardarEnArchivo(avs);
            }
        }

        private void mostrarElemento(Audiovisual avMostrado)
        {
            //Mostramos la foto
            try
            {
                String? ruta = $"Resources\\Carteles\\{avMostrado.IdFoto}.jpg";
                pctCartel.Image = Image.FromFile(ruta);
                pctCartel.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch (FileNotFoundException ignore) { }

            //Mostramos el titulo
            lblTituloMostrado.Text = avMostrado.Titulo;

            //Mostramos el director
            lblDirectorMostrado.Text = avMostrado.Director;

            //Mostramos el año
            lblYearMostrado.Text = avMostrado.Year.ToString();

        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            //Antes de enviarle a dar de alta un elemento, comprobamos si es el primero para que no pueda salir de esa pantalla
            if (esElPrimero)
            {
                FrmAlta.btnCancelar.Visible = false;
            }
            else
            {
                FrmAlta.btnCancelar.Visible = true;
            }
            frmAlta.ShowDialog();

            //Una vez creado el elemento mostramos el primero de la lista
            pos = 0;
            avMostrado = avsMostrados[pos];
            mostrarElemento(avMostrado);
            actualizarElementoMostrado();

        }

        //Si pinchas en el nombre se muestra el acerca de
        private void lblCopy_Click(object sender, EventArgs e)
        {
            frmAcercaDe.ShowDialog();
        }

        //Este es el boton de filtrar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Comprobamos los textos que se ponen en el mismo boton y realizamos acciones en base a ellos
            if (btnFiltrar.Text == ("Filtrar"))
            {
                frmFiltrar.ShowDialog();
            }
            else
            {
                estaFiltrando = false; 
            }

            //Ahora comprobamos si se estña filtrando o no para realizar acciones en base a ello
            if (estaFiltrando)
            {
                btnFiltrar.Text = "Quitar Filtro";
                actualizar();
                btnEliminar.Visible = false;
            }
            else
            {
                btnFiltrar.Text = "Filtrar";
                avsMostrados = avs;
                actualizar();
                btnEliminar.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Mandamos a eliminar el elemento, si el que se elimina es el ultimo se nos devolveria 1 o 2 depende de la opcion elegida en el AlertDialog
            int opc = ga.EliminarElemento(pos);


            //Si el usuario decide dar de alta uno nuevo cuando no queda ninguno se muestra el panel alta
            if (opc == 1)
            {
                esElPrimero = true;
                FrmAlta.btnCancelar.Visible = false;
                frmAlta.ShowDialog();

                actualizar();
            }
            else if (opc == 2) //Si no se cierra la aplicacion
            {
                this.Close();
            }
            else if (opc == 0)
            {
                if (pos - 1 >= 0)
                {
                    pos--;
                }
            }

            //Comprobamos que haya algun elemento en la lista y se muestra, si no se vacian los campos
            if (avsMostrados.Count > 0)
            {
                avMostrado = avsMostrados[pos];
                mostrarElemento(avMostrado);//Mostramos el elemento anterior de la lista o el de la posicion 0 si el que se ha borrado es ese
                actualizarElementoMostrado();
            }
            else
            {
                lblTituloMostrado.Text = "";
                lblDirectorMostrado.Text = "";
                lblYearMostrado.Text = "";
                lblElemento.Text = "[0/0]";
            }



        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Si la posicion es menor que los elementos-1 se muestra el siguiente
            if (pos < avsMostrados.Count - 1)
            {
                pos++;
                mostrarElemento(avsMostrados[pos]);

            }

            //Y se cambia el numero de elemento mostrado
            actualizarElementoMostrado();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //Si la posicion es mayor que 0 se muestra el anterior
            if (pos > 0)
            {
                pos--;
                mostrarElemento(avsMostrados[pos]);

            }

            //Y se cambia el numero del elemento mostrado
            actualizarElementoMostrado();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            //Se muestran los detalles del elemento indicado
            avMostrado = avsMostrados[pos];
            frmDetalles = new FrmDetalles(avMostrado);
            frmDetalles.ShowDialog();
        }

        //Ordenamos la lista por el elemento correspondiente
        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el elemento seleccionado
            string opcionSeleccionada = cmbOrdenar.SelectedItem.ToString();

            // Ejecutar acciones según la opción
            switch (opcionSeleccionada)
            {
                case "Titulo":
                    pos = 0;
                    avsFiltrados = avs.OrderBy(a => a.Titulo).ToList();
                    avsMostrados = avsFiltrados;
                    btnEliminar.Visible = true;
                    break;
                case "Director":
                    pos = 0;
                    avsFiltrados = avs.OrderBy(a => a.Director).ToList();
                    avsMostrados = avsFiltrados;
                    btnEliminar.Visible = false;
                    break;
                case "Año":
                    pos = 0;
                    avsFiltrados = avs.OrderByDescending(a => a.Year).ToList();
                    avsMostrados = avsFiltrados;
                    btnEliminar.Visible = false;
                    break;
            }

            avMostrado = avsMostrados[pos];
            mostrarElemento(avMostrado);//Le mandamos el primer elemento de la lista
            lblElemento.Text = $"[{pos + 1} / {avsMostrados.Count}]";
        }

        //Mostramos el primer elemento de la lista
        public void actualizar()
        {
            pos = 0;
            avMostrado = avsMostrados[pos];
            mostrarElemento(avMostrado);//Le mandamos el primer elemento de la lista
            actualizarElementoMostrado();
        }

        private void actualizarElementoMostrado() //Cambiamos el numero de elemento que se muestra [x/y]
        {
            lblElemento.Text = $"[{pos + 1} / {avsMostrados.Count}]";
        }

    }

}
