using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasoPracticoS1
{
    public partial class FormMain : Form
    {
        private Lista listaPrincipal;

        public FormMain()
        {
            InitializeComponent();
            listaPrincipal = new Lista();
            ActualizarUI();
            Log("App iniciada.");
        }

        private void ActualizarUI()
        {
            lblEstadoLista.Text = "Estado: " + listaPrincipal.Imprimir();
            lblCantidad.Text = "Nodos: " + listaPrincipal.Tamaño.ToString();

            listBoxNodos.Items.Clear();
            int[] montos = listaPrincipal.ObtenerMontos();
            for (int i = 0; i < montos.Length; i++)
            {
                listBoxNodos.Items.Add($"Posición {i} : Monto {montos[i]}");
            }
        }

        private void Log(string mensaje)
        {
            txtBitacora.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}] {mensaje}{Environment.NewLine}");
        }

        private int? GetMonto()
        {
            if (int.TryParse(txtMonto.Text, out int m)) return m;
            MessageBox.Show("Ingrese un monto válido (entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private int? GetPosicion()
        {
            if (int.TryParse(txtPosicion.Text, out int p)) return p;
            MessageBox.Show("Ingrese una posición válida (entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private void btnAnexarInicio_Click(object sender, EventArgs e)
        {
            int? m = GetMonto();
            if (m.HasValue)
            {
                listaPrincipal.AnexarInicio(m.Value);
                Log($"AnexarInicio({m.Value}) -> Éxito.");
                ActualizarUI();
            }
        }

        private void btnAnexarFinal_Click(object sender, EventArgs e)
        {
            int? m = GetMonto();
            if (m.HasValue)
            {
                listaPrincipal.AnexarFinal(m.Value);
                Log($"AnexarFinal({m.Value}) -> Éxito.");
                ActualizarUI();
            }
        }

        private void btnAnexarPosicion_Click(object sender, EventArgs e)
        {
            int? m = GetMonto();
            int? p = GetPosicion();
            if (m.HasValue && p.HasValue)
            {
                bool res = listaPrincipal.AnexarPosicion(m.Value, p.Value);
                if (res)
                {
                    Log($"AnexarPosicion({m.Value}, pos={p.Value}) -> Éxito.");
                }
                else
                {
                    Log($"AnexarPosicion({m.Value}, pos={p.Value}) -> Falló. Posición inválida.");
                    MessageBox.Show("Posición inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ActualizarUI();
            }
        }

        private void btnBorrarInicio_Click(object sender, EventArgs e)
        {
            bool res = listaPrincipal.BorrarInicio();
            if (res)
            {
                Log("BorrarInicio() -> Éxito.");
            }
            else
            {
                Log("BorrarInicio() -> Falló. Lista vacía.");
                MessageBox.Show("Lista vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ActualizarUI();
        }

        private void btnBorrarFinal_Click(object sender, EventArgs e)
        {
            bool res = listaPrincipal.BorrarFinal();
            if (res)
            {
                Log("BorrarFinal() -> Éxito.");
            }
            else
            {
                Log("BorrarFinal() -> Falló. Lista vacía.");
                MessageBox.Show("Lista vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ActualizarUI();
        }

        private void btnBorrarDato_Click(object sender, EventArgs e)
        {
            int? m = GetMonto();
            if (m.HasValue)
            {
                bool res = listaPrincipal.BorrarDato(m.Value);
                if (res)
                {
                    Log($"BorrarDato({m.Value}) -> Éxito.");
                }
                else
                {
                    Log($"BorrarDato({m.Value}) -> Falló. Dato no encontrado.");
                    MessageBox.Show("Dato no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarUI();
            }
        }

        private void btnBuscarNodo_Click(object sender, EventArgs e)
        {
            int? m = GetMonto();
            if (m.HasValue)
            {
                Nodo n = listaPrincipal.BuscarNodo(m.Value);
                if (n != null)
                {
                    Log($"BuscarNodo({m.Value}) -> Verdadero.");
                    int pos = listaPrincipal.BuscarPosicion(m.Value);
                    if (pos != -1 && pos < listBoxNodos.Items.Count)
                    {
                        listBoxNodos.SelectedIndex = pos;
                        // Habilitar dibujo personalizado para resaltar (si fuera DataGridView sería más facil, pero usaremos SelectedIndex)
                    }
                }
                else
                {
                    Log($"BuscarNodo({m.Value}) -> Falso.");
                    MessageBox.Show("Dato no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscarPosicion_Click(object sender, EventArgs e)
        {
            int? m = GetMonto();
            if (m.HasValue)
            {
                int pos = listaPrincipal.BuscarPosicion(m.Value);
                if (pos != -1)
                {
                    Log($"BuscarPosicion({m.Value}) -> Encontrado en pos={pos}.");
                    if (pos < listBoxNodos.Items.Count) listBoxNodos.SelectedIndex = pos;
                }
                else
                {
                    Log($"BuscarPosicion({m.Value}) -> No encontrado (-1).");
                    MessageBox.Show("Dato no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaPrincipal.Ordenar();
            Log("Ordenar() -> Lista ordenada ascendentemente.");
            ActualizarUI();
        }

        private void btnMezclar_Click(object sender, EventArgs e)
        {
            Lista otra = new Lista();
            otra.CargarArreglo(new int[] { 3, 5, 20 }); 
            // Ej. random para UI. El test real tiene su propio mix
            otra.Ordenar();
            listaPrincipal.Ordenar();
            listaPrincipal = listaPrincipal.Mezclar(otra);
            Log("Mezclar() -> Se mezcló con lista de prueba [3, 5, 20].");
            ActualizarUI();
        }

        private void btnEjecutarPruebas_Click(object sender, EventArgs e)
        {
            Log("--- INICIANDO CASOS DE PRUEBA ---");
            listaPrincipal.Vaciar();
            ActualizarUI();

            // 1
            listaPrincipal.AnexarInicio(50);
            listaPrincipal.AnexarInicio(120);
            listaPrincipal.AnexarInicio(18);
            VerificarPrueba("1", "[ 18->120->50 ]");

            // 2
            listaPrincipal.AnexarFinal(200);
            VerificarPrueba("2", "[ 18->120->50->200 ]");

            // 3
            listaPrincipal.AnexarPosicion(99, 2);
            VerificarPrueba("3", "[ 18->120->99->50->200 ]");

            // 4
            listaPrincipal.BorrarInicio();
            VerificarPrueba("4", "[ 120->99->50->200 ]");

            // 5
            listaPrincipal.BorrarFinal();
            VerificarPrueba("5", "[ 120->99->50 ]");

            // 6
            listaPrincipal.BorrarDato(99);
            VerificarPrueba("6", "[ 120->50 ]");

            // 7
            bool b7 = listaPrincipal.BuscarNodo(50) != null;
            Log($"Test 7: BuscarNodo(50). Esperado: true. Real: {b7}. {(b7 ? "PASA" : "FALLA")}");

            // 8
            bool b8 = listaPrincipal.BuscarNodo(999) == null;
            Log($"Test 8: BuscarNodo(999). Esperado: false (es decir null). Real: {!b8}. {(b8 ? "PASA" : "FALLA")}");

            // 9
            listaPrincipal.Vaciar();
            int[] arr9 = { 42, 7, 23, 4, 16, 8, 15 };
            listaPrincipal.CargarArreglo(arr9);
            listaPrincipal.Ordenar();
            VerificarPrueba("9", "[ 4->7->8->15->16->23->42 ]");

            // 10
            Lista listaA = new Lista();
            listaA.CargarArreglo(new int[] { 2, 6, 9, 12 });
            Lista listaB = new Lista();
            listaB.CargarArreglo(new int[] { 1, 4, 8, 10, 15 });
            Lista mezclada = listaA.Mezclar(listaB);
            listaPrincipal = mezclada; // Solo para q se vea en la UI
            VerificarPrueba("10", "[ 1->2->4->6->8->9->10->12->15 ]");

            // 11
            Lista vacia = new Lista();
            bool b11 = vacia.BorrarInicio();
            Log($"Test 11: BorrarInicio() en vacía. Esperado: false. Real: {b11}. {(!b11 ? "PASA" : "FALLA")}");

            // 12
            Lista lista12 = new Lista();
            lista12.CargarArreglo(new int[] { 5, 8 });
            bool b12 = lista12.AnexarPosicion(10, 99);
            Log($"Test 12: AnexarPosicion(10, 99) en [5->8]. Esperado: false. Real: {b12}. {(!b12 ? "PASA" : "FALLA")}");

            Log("--- FIN CASOS DE PRUEBA ---");
            ActualizarUI();

            MessageBox.Show("Casos de prueba completados. Revisa la bitácora.");
        }

        private void VerificarPrueba(string id, string esperado)
        {
            string real = listaPrincipal.Imprimir();
            bool pasa = real == esperado;
            Log($"Test {id}: Esperado {esperado}. Real: {real}. {(pasa ? "PASA" : "FALLA")}");
        }

        private void listBoxNodos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            SolidBrush b = new SolidBrush(isSelected ? Color.Orange : e.BackColor);

            e.Graphics.FillRectangle(b, e.Bounds);
            e.Graphics.DrawString(listBoxNodos.Items[e.Index].ToString(), e.Font, 
                new SolidBrush(isSelected ? Color.Black : e.ForeColor), e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }
    }
}