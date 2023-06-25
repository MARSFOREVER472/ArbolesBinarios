namespace NodosYÁrbolesBinarios
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
            nodo = new Label();
            VistaDeArbol = new TreeView();
            textNODO = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            lblNodoSeleccionado = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            rdbDerecha = new RadioButton();
            rdbIzquierda = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // nodo
            // 
            nodo.AutoSize = true;
            nodo.Location = new Point(523, 9);
            nodo.Name = "nodo";
            nodo.Size = new Size(58, 25);
            nodo.TabIndex = 0;
            nodo.Text = "Nodo";
            nodo.Click += label1_Click;
            // 
            // VistaDeArbol
            // 
            VistaDeArbol.Location = new Point(12, 9);
            VistaDeArbol.Name = "VistaDeArbol";
            VistaDeArbol.Size = new Size(423, 593);
            VistaDeArbol.TabIndex = 1;
            // 
            // textNODO
            // 
            textNODO.Location = new Point(736, 60);
            textNODO.Name = "textNODO";
            textNODO.Size = new Size(174, 34);
            textNODO.TabIndex = 2;
            textNODO.Text = "Agregar NODO";
            textNODO.UseVisualStyleBackColor = true;
            textNODO.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblNodoSeleccionado);
            groupBox1.Location = new Point(596, 376);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 214);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 136);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Ancho:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 87);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Altura:";
            label2.Click += label2_Click;
            // 
            // lblNodoSeleccionado
            // 
            lblNodoSeleccionado.AutoSize = true;
            lblNodoSeleccionado.Location = new Point(10, 39);
            lblNodoSeleccionado.Name = "lblNodoSeleccionado";
            lblNodoSeleccionado.Size = new Size(169, 25);
            lblNodoSeleccionado.TabIndex = 0;
            lblNodoSeleccionado.Text = "Nodo seleccionado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(523, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbDerecha);
            groupBox2.Controls.Add(rdbIzquierda);
            groupBox2.Location = new Point(744, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 150);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rama";
            // 
            // rdbDerecha
            // 
            rdbDerecha.AutoSize = true;
            rdbDerecha.Location = new Point(25, 94);
            rdbDerecha.Name = "rdbDerecha";
            rdbDerecha.Size = new Size(101, 29);
            rdbDerecha.TabIndex = 1;
            rdbDerecha.TabStop = true;
            rdbDerecha.Text = "Derecha";
            rdbDerecha.UseVisualStyleBackColor = true;
            rdbDerecha.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbIzquierda
            // 
            rdbIzquierda.AutoSize = true;
            rdbIzquierda.Location = new Point(25, 45);
            rdbIzquierda.Name = "rdbIzquierda";
            rdbIzquierda.Size = new Size(110, 29);
            rdbIzquierda.TabIndex = 0;
            rdbIzquierda.TabStop = true;
            rdbIzquierda.Text = "Izquierda";
            rdbIzquierda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 614);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(textNODO);
            Controls.Add(VistaDeArbol);
            Controls.Add(nodo);
            Name = "Form1";
            Text = "Preferencias";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nodo;
        private TreeView VistaDeArbol;
        private Button textNODO;
        private GroupBox groupBox1;
        private Label label2;
        private Label lblNodoSeleccionado;
        private Label label3;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private RadioButton rdbDerecha;
        private RadioButton rdbIzquierda;
    }
}