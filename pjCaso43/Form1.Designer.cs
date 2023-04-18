namespace pjCaso43
{
    partial class frmRegistro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE1 = new System.Windows.Forms.TextBox();
            this.txtE2 = new System.Windows.Forms.TextBox();
            this.txtE3 = new System.Windows.Forms.TextBox();
            this.txtE4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE EVALUACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALUMNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eval. 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eval. 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eval. 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Eval. 4";
            // 
            // txtE1
            // 
            this.txtE1.Location = new System.Drawing.Point(18, 63);
            this.txtE1.Name = "txtE1";
            this.txtE1.Size = new System.Drawing.Size(56, 23);
            this.txtE1.TabIndex = 7;
            this.txtE1.TextChanged += new System.EventHandler(this.txtE1_TextChanged);
            // 
            // txtE2
            // 
            this.txtE2.Location = new System.Drawing.Point(95, 63);
            this.txtE2.Name = "txtE2";
            this.txtE2.Size = new System.Drawing.Size(56, 23);
            this.txtE2.TabIndex = 8;
            this.txtE2.TextChanged += new System.EventHandler(this.txtE2_TextChanged);
            // 
            // txtE3
            // 
            this.txtE3.Location = new System.Drawing.Point(188, 63);
            this.txtE3.Name = "txtE3";
            this.txtE3.Size = new System.Drawing.Size(56, 23);
            this.txtE3.TabIndex = 9;
            this.txtE3.TextChanged += new System.EventHandler(this.txtE3_TextChanged);
            // 
            // txtE4
            // 
            this.txtE4.Location = new System.Drawing.Point(269, 63);
            this.txtE4.Name = "txtE4";
            this.txtE4.Size = new System.Drawing.Size(56, 23);
            this.txtE4.TabIndex = 10;
            this.txtE4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtE1);
            this.groupBox1.Controls.Add(this.txtE4);
            this.groupBox1.Controls.Add(this.txtE2);
            this.groupBox1.Controls.Add(this.txtE3);
            this.groupBox1.Location = new System.Drawing.Point(315, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 115);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluaciones";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(93, 159);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 463);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.Location = new System.Drawing.Point(12, 218);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(652, 239);
            this.lvRegistro.TabIndex = 16;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(12, 129);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(247, 23);
            this.txtAlumno.TabIndex = 17;
            this.txtAlumno.TextChanged += new System.EventHandler(this.txtAlumno_TextChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ALUMNOS";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "E1";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E2";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E3";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E4";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MENOR";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PROMEDIO";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CONDICION";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 498);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistro";
            this.Text = "Control de registro de evaluaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtE1;
        private TextBox txtE2;
        private TextBox txtE3;
        private TextBox txtE4;
        private GroupBox groupBox1;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Button btnSalir;
        private ListView lvRegistro;
        private ErrorProvider epError;
        private TextBox txtAlumno;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}