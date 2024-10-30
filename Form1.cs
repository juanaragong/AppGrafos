using System.Net.Http.Headers;

namespace AppGrafos
{
    public partial class Form1 : Form
    {

        private Grafo grafo;
        private int contadoridNodo = 1;
        public Form1()
        {
            InitializeComponent();
            grafo = new Grafo();
        }

        private void AgregarNodo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreNodo.Text;
            Point posicion = new Point(int.Parse(txtCoordenadaX.Text),
                int.Parse(txtCoordenadaY.Text));

            Nodo nodo = new Nodo(contadoridNodo, nombre, posicion);
            grafo.AgregarNodo(nodo);


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            foreach (var arista in grafo.Aristas)
            {
                g.DrawLine(Pens.Black, arista.Nodo1.Posicion, arista.Nodo2.Posicion);
                var pesosPos = new Point((arista.Nodo1.Posicion.X + arista.Nodo2.Posicion.X) / 2,
                    (arista.Nodo2.Posicion.Y + arista.Nodo2.Posicion.Y / 2));
                g.DrawString(arista.Peso.ToString(), new Font("Arial", 12), Brushes.Black, pesosPos);
            }

            foreach (var nodo in grafo.Nodos)
            {
                g.FillEllipse(Brushes.Blue, nodo.Posicion.X - 5, nodo.Posicion.Y - 5, 10, 10);
                g.DrawString(nodo.Nombre, new Font("Arial", 12), Brushes.Black, nodo.Posicion);

            }
        }

        private void AgregarArista_Click(object sender, EventArgs e)
        {
            Nodo nodo1 = grafo.Nodos.Find(n => n.Nombre == txtNodo1.Text);
            Nodo nodo2 = grafo.Nodos.Find(n => n.Nombre == txtNodo2.Text);
            int peso = int.Parse(txtPeso.Text);
            if (nodo1 != null && nodo2 != null)
            {
                grafo.AgregarArista(new Arista(nodo1, nodo2, peso));

            }
        }

        private void btnDibujarGrafo_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
