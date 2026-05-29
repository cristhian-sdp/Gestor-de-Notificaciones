namespace CasoPracticoS1
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAnexarInicio = new System.Windows.Forms.Button();
            this.btnAnexarFinal = new System.Windows.Forms.Button();
            this.btnAnexarPosicion = new System.Windows.Forms.Button();
            this.btnBorrarInicio = new System.Windows.Forms.Button();
            this.btnBorrarFinal = new System.Windows.Forms.Button();
            this.btnBorrarDato = new System.Windows.Forms.Button();
            this.btnBuscarNodo = new System.Windows.Forms.Button();
            this.btnBuscarPosicion = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMezclar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.listBoxNodos = new System.Windows.Forms.ListBox();
            this.lblEstadoLista = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.btnEjecutarPruebas = new System.Windows.Forms.Button();

            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestor de Notificaciones - Equipo X";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnMezclar);
            this.pnlBotones.Controls.Add(this.btnOrdenar);
            this.pnlBotones.Controls.Add(this.btnBuscarPosicion);
            this.pnlBotones.Controls.Add(this.btnBuscarNodo);
            this.pnlBotones.Controls.Add(this.btnBorrarDato);
            this.pnlBotones.Controls.Add(this.btnBorrarFinal);
            this.pnlBotones.Controls.Add(this.btnBorrarInicio);
            this.pnlBotones.Controls.Add(this.btnAnexarPosicion);
            this.pnlBotones.Controls.Add(this.btnAnexarFinal);
            this.pnlBotones.Controls.Add(this.btnAnexarInicio);
            this.pnlBotones.Location = new System.Drawing.Point(16, 99);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(200, 319);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnAnexarInicio
            // 
            this.btnAnexarInicio.Location = new System.Drawing.Point(3, 3);
            this.btnAnexarInicio.Name = "btnAnexarInicio";
            this.btnAnexarInicio.Size = new System.Drawing.Size(194, 23);
            this.btnAnexarInicio.TabIndex = 0;
            this.btnAnexarInicio.Text = "Anexar Inicio";
            this.btnAnexarInicio.UseVisualStyleBackColor = true;
            this.btnAnexarInicio.Click += new System.EventHandler(this.btnAnexarInicio_Click);
            // 
            // btnAnexarFinal
            // 
            this.btnAnexarFinal.Location = new System.Drawing.Point(3, 32);
            this.btnAnexarFinal.Name = "btnAnexarFinal";
            this.btnAnexarFinal.Size = new System.Drawing.Size(194, 23);
            this.btnAnexarFinal.TabIndex = 1;
            this.btnAnexarFinal.Text = "Anexar Final";
            this.btnAnexarFinal.UseVisualStyleBackColor = true;
            this.btnAnexarFinal.Click += new System.EventHandler(this.btnAnexarFinal_Click);
            // 
            // btnAnexarPosicion
            // 
            this.btnAnexarPosicion.Location = new System.Drawing.Point(3, 61);
            this.btnAnexarPosicion.Name = "btnAnexarPosicion";
            this.btnAnexarPosicion.Size = new System.Drawing.Size(194, 23);
            this.btnAnexarPosicion.TabIndex = 2;
            this.btnAnexarPosicion.Text = "Anexar en Posición";
            this.btnAnexarPosicion.UseVisualStyleBackColor = true;
            this.btnAnexarPosicion.Click += new System.EventHandler(this.btnAnexarPosicion_Click);
            // 
            // btnBorrarInicio
            // 
            this.btnBorrarInicio.Location = new System.Drawing.Point(3, 90);
            this.btnBorrarInicio.Name = "btnBorrarInicio";
            this.btnBorrarInicio.Size = new System.Drawing.Size(194, 23);
            this.btnBorrarInicio.TabIndex = 3;
            this.btnBorrarInicio.Text = "Borrar Inicio";
            this.btnBorrarInicio.UseVisualStyleBackColor = true;
            this.btnBorrarInicio.Click += new System.EventHandler(this.btnBorrarInicio_Click);
            // 
            // btnBorrarFinal
            // 
            this.btnBorrarFinal.Location = new System.Drawing.Point(3, 119);
            this.btnBorrarFinal.Name = "btnBorrarFinal";
            this.btnBorrarFinal.Size = new System.Drawing.Size(194, 23);
            this.btnBorrarFinal.TabIndex = 4;
            this.btnBorrarFinal.Text = "Borrar Final";
            this.btnBorrarFinal.UseVisualStyleBackColor = true;
            this.btnBorrarFinal.Click += new System.EventHandler(this.btnBorrarFinal_Click);
            // 
            // btnBorrarDato
            // 
            this.btnBorrarDato.Location = new System.Drawing.Point(3, 148);
            this.btnBorrarDato.Name = "btnBorrarDato";
            this.btnBorrarDato.Size = new System.Drawing.Size(194, 23);
            this.btnBorrarDato.TabIndex = 5;
            this.btnBorrarDato.Text = "Borrar Dato";
            this.btnBorrarDato.UseVisualStyleBackColor = true;
            this.btnBorrarDato.Click += new System.EventHandler(this.btnBorrarDato_Click);
            // 
            // btnBuscarNodo
            // 
            this.btnBuscarNodo.Location = new System.Drawing.Point(3, 177);
            this.btnBuscarNodo.Name = "btnBuscarNodo";
            this.btnBuscarNodo.Size = new System.Drawing.Size(194, 23);
            this.btnBuscarNodo.TabIndex = 6;
            this.btnBuscarNodo.Text = "Buscar Nodo";
            this.btnBuscarNodo.UseVisualStyleBackColor = true;
            this.btnBuscarNodo.Click += new System.EventHandler(this.btnBuscarNodo_Click);
            // 
            // btnBuscarPosicion
            // 
            this.btnBuscarPosicion.Location = new System.Drawing.Point(3, 206);
            this.btnBuscarPosicion.Name = "btnBuscarPosicion";
            this.btnBuscarPosicion.Size = new System.Drawing.Size(194, 23);
            this.btnBuscarPosicion.TabIndex = 7;
            this.btnBuscarPosicion.Text = "Buscar Posición";
            this.btnBuscarPosicion.UseVisualStyleBackColor = true;
            this.btnBuscarPosicion.Click += new System.EventHandler(this.btnBuscarPosicion_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(3, 235);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(194, 23);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar Lista";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMezclar
            // 
            this.btnMezclar.Location = new System.Drawing.Point(3, 264);
            this.btnMezclar.Name = "btnMezclar";
            this.btnMezclar.Size = new System.Drawing.Size(194, 23);
            this.btnMezclar.TabIndex = 9;
            this.btnMezclar.Text = "Mezclar con Dummy";
            this.btnMezclar.UseVisualStyleBackColor = true;
            this.btnMezclar.Click += new System.EventHandler(this.btnMezclar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(16, 42);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(19, 58);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(90, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(123, 42);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(95, 13);
            this.lblPosicion.TabIndex = 4;
            this.lblPosicion.Text = "Posición (opcional):";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(126, 58);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(90, 20);
            this.txtPosicion.TabIndex = 5;
            // 
            // listBoxNodos
            // 
            this.listBoxNodos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxNodos.FormattingEnabled = true;
            this.listBoxNodos.Location = new System.Drawing.Point(232, 99);
            this.listBoxNodos.Name = "listBoxNodos";
            this.listBoxNodos.Size = new System.Drawing.Size(200, 316);
            this.listBoxNodos.TabIndex = 6;
            this.listBoxNodos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxNodos_DrawItem);
            // 
            // lblEstadoLista
            // 
            this.lblEstadoLista.AutoSize = true;
            this.lblEstadoLista.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLista.Location = new System.Drawing.Point(232, 42);
            this.lblEstadoLista.Name = "lblEstadoLista";
            this.lblEstadoLista.Size = new System.Drawing.Size(84, 15);
            this.lblEstadoLista.TabIndex = 7;
            this.lblEstadoLista.Text = "Estado: [ ]";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(232, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(50, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Nodos: 0";
            // 
            // txtBitacora
            // 
            this.txtBitacora.Location = new System.Drawing.Point(448, 99);
            this.txtBitacora.Multiline = true;
            this.txtBitacora.Name = "txtBitacora";
            this.txtBitacora.ReadOnly = true;
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBitacora.Size = new System.Drawing.Size(340, 316);
            this.txtBitacora.TabIndex = 9;
            // 
            // btnEjecutarPruebas
            // 
            this.btnEjecutarPruebas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEjecutarPruebas.Location = new System.Drawing.Point(448, 70);
            this.btnEjecutarPruebas.Name = "btnEjecutarPruebas";
            this.btnEjecutarPruebas.Size = new System.Drawing.Size(150, 23);
            this.btnEjecutarPruebas.TabIndex = 10;
            this.btnEjecutarPruebas.Text = "Ejecutar Casos de Prueba";
            this.btnEjecutarPruebas.UseVisualStyleBackColor = false;
            this.btnEjecutarPruebas.Click += new System.EventHandler(this.btnEjecutarPruebas_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEjecutarPruebas);
            this.Controls.Add(this.txtBitacora);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblEstadoLista);
            this.Controls.Add(this.listBoxNodos);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormMain";
            this.Text = "Gestor de Notificaciones";
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnAnexarInicio;
        private System.Windows.Forms.Button btnAnexarFinal;
        private System.Windows.Forms.Button btnAnexarPosicion;
        private System.Windows.Forms.Button btnBorrarInicio;
        private System.Windows.Forms.Button btnBorrarFinal;
        private System.Windows.Forms.Button btnBorrarDato;
        private System.Windows.Forms.Button btnBuscarNodo;
        private System.Windows.Forms.Button btnBuscarPosicion;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMezclar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.ListBox listBoxNodos;
        private System.Windows.Forms.Label lblEstadoLista;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Button btnEjecutarPruebas;
    }
}
