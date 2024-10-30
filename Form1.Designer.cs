namespace AppGrafos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreNodo = new TextBox();
            txtCoordenadaX = new TextBox();
            txtCoordenadaY = new TextBox();
            AgregarNodo = new Button();
            AgregarArista = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            Peso = new Label();
            btnDibujarGrafo = new Button();
            txtNodo1 = new TextBox();
            label4 = new Label();
            txtNodo2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNombreNodo
            // 
            txtNombreNodo.Location = new Point(694, 14);
            txtNombreNodo.Name = "txtNombreNodo";
            txtNombreNodo.Size = new Size(150, 31);
            txtNombreNodo.TabIndex = 0;
            // 
            // txtCoordenadaX
            // 
            txtCoordenadaX.Location = new Point(694, 61);
            txtCoordenadaX.Name = "txtCoordenadaX";
            txtCoordenadaX.Size = new Size(150, 31);
            txtCoordenadaX.TabIndex = 1;
            // 
            // txtCoordenadaY
            // 
            txtCoordenadaY.Location = new Point(694, 110);
            txtCoordenadaY.Name = "txtCoordenadaY";
            txtCoordenadaY.Size = new Size(150, 31);
            txtCoordenadaY.TabIndex = 2;
            // 
            // AgregarNodo
            // 
            AgregarNodo.Location = new Point(878, 14);
            AgregarNodo.Name = "AgregarNodo";
            AgregarNodo.Size = new Size(179, 34);
            AgregarNodo.TabIndex = 3;
            AgregarNodo.Text = "Agregar Nodo";
            AgregarNodo.UseVisualStyleBackColor = true;
            AgregarNodo.Click += AgregarNodo_Click;
            // 
            // AgregarArista
            // 
            AgregarArista.Location = new Point(878, 341);
            AgregarArista.Name = "AgregarArista";
            AgregarArista.Size = new Size(179, 34);
            AgregarArista.TabIndex = 4;
            AgregarArista.Text = "Agregar Arista";
            AgregarArista.UseVisualStyleBackColor = true;
            AgregarArista.Click += AgregarArista_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(589, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 116);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 6;
            label2.Text = "Coordenada en Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 67);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 7;
            label3.Text = "Coordenda en X";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(694, 169);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(150, 31);
            txtPeso.TabIndex = 8;
            // 
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Location = new Point(639, 175);
            Peso.Name = "Peso";
            Peso.Size = new Size(49, 25);
            Peso.TabIndex = 9;
            Peso.Text = "Peso";
            // 
            // btnDibujarGrafo
            // 
            btnDibujarGrafo.Location = new Point(878, 119);
            btnDibujarGrafo.Name = "btnDibujarGrafo";
            btnDibujarGrafo.Size = new Size(179, 34);
            btnDibujarGrafo.TabIndex = 10;
            btnDibujarGrafo.Text = "Dibujar Grafo";
            btnDibujarGrafo.UseVisualStyleBackColor = true;
            btnDibujarGrafo.Click += btnDibujarGrafo_Click;
            // 
            // txtNodo1
            // 
            txtNodo1.Location = new Point(694, 281);
            txtNodo1.Name = "txtNodo1";
            txtNodo1.Size = new Size(150, 31);
            txtNodo1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 287);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 12;
            label4.Text = "Nombre Nodo 1";
            // 
            // txtNodo2
            // 
            txtNodo2.Location = new Point(694, 341);
            txtNodo2.Name = "txtNodo2";
            txtNodo2.Size = new Size(150, 31);
            txtNodo2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 347);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 14;
            label5.Text = "Nombre Nodo 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 530);
            Controls.Add(label5);
            Controls.Add(txtNodo2);
            Controls.Add(label4);
            Controls.Add(txtNodo1);
            Controls.Add(btnDibujarGrafo);
            Controls.Add(Peso);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AgregarArista);
            Controls.Add(AgregarNodo);
            Controls.Add(txtCoordenadaY);
            Controls.Add(txtCoordenadaX);
            Controls.Add(txtNombreNodo);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreNodo;
        private TextBox txtCoordenadaX;
        private TextBox txtCoordenadaY;
        private Button AgregarNodo;
        private Button AgregarArista;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private Label Peso;
        private Button btnDibujarGrafo;
        private TextBox txtNodo1;
        private Label label4;
        private TextBox txtNodo2;
        private Label label5;
    }
}
