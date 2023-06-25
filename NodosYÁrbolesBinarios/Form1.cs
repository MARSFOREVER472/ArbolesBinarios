namespace NodosYÁrbolesBinarios
{
    public partial class Form1 : Form
    {
        // Declaramos algunas variables a los nodos.

        Nodo raiz;
        Nodo seleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        // Función Crear NODO

        Nodo crearNodo()
        {
            string nombre = textNODO.Text;
            return new Nodo(nombre);
        }

        // Cambiar la selección del Nodo.

        void CambiarSeleccion(Nodo n)
        {
            seleccionado = n;
            this.lblNodoSeleccionado.Text = "Nodo seleccionado: " + n.Nombre;
        }

        // Listar árbol.

        public void ListarArbol()
        {
            VistaDeArbol.Nodes.Clear();
            MostrarNodo(raiz, null, string.Empty);
            VistaDeArbol.ExpandAll();
            // EvaluarArbol();
        }

        void MostrarNodo(Nodo n, TreeNode tnPadre, string lado)
        {
            if (n == null) return;

            TreeNode nuevo = new TreeNode(); // Nodo que muestra en pantalla.
            if (tnPadre == null && lado == String.Empty)
            {
                // Crearemos un NODO raíz.
                tnPadre = new TreeNode();
                nuevo.Text = n.Nombre;
                nuevo.Tag = n; // Guarda el nodo que se quiere vincular.
                VistaDeArbol.Nodes.Add(nuevo);
            }

            else
            {
                nuevo.Text = $"{lado} - {n.Nombre}";
                nuevo.Tag = n;

                tnPadre.Nodes.Add(nuevo);
            }

            if (n.Izquierda != null) MostrarNodo(n.Izquierda, nuevo, "I");
            if (n.Derecha != null) MostrarNodo(n.Derecha, nuevo, "D");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNODO.Text != "")
            {
                if (raiz != null)
                {
                    raiz = crearNodo();
                    this.textNODO.Text = "";
                    this.textNODO.Focus();
                }

                else
                {
                    if (rdbIzquierda.Checked == true || rdbDerecha.Checked == true)
                    {
                        if (seleccionado != null)
                        {
                            if (rdbIzquierda.Checked == true) seleccionado.Izquierda = crearNodo();
                            if (rdbDerecha.Checked == true) seleccionado.Derecha = crearNodo();
                            this.textNODO.Text = "";
                            this.textNODO.Focus();
                            ListarArbol();
                        }
                        else MessageBox.Show("DEBE SELECCIONAR UN NODO");
                    }
                    else
                    {
                        MessageBox.Show("DEBE SELECCIONAR IZQUIERDA O DERECHA");
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}