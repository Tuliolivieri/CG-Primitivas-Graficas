namespace Primitivas_Graficas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPane = new System.Windows.Forms.TabControl();
            this.tabPrimitivas = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbElipse = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbCircPM = new System.Windows.Forms.CheckBox();
            this.cbCircTrig = new System.Windows.Forms.CheckBox();
            this.cbCircEqGeral = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPtMedio = new System.Windows.Forms.CheckBox();
            this.cbDeclive = new System.Windows.Forms.CheckBox();
            this.cbEqReal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPoligonos = new System.Windows.Forms.TabPage();
            this.pictureBoxPoligonos = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btCor = new System.Windows.Forms.Button();
            this.btFluidFill = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btEspX = new System.Windows.Forms.Button();
            this.btEspY = new System.Windows.Forms.Button();
            this.btCisalhar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCisY = new System.Windows.Forms.TextBox();
            this.tbCisX = new System.Windows.Forms.TextBox();
            this.btRotacionar = new System.Windows.Forms.Button();
            this.cbEixo = new System.Windows.Forms.CheckBox();
            this.cbOrigem = new System.Windows.Forms.CheckBox();
            this.tbAngulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btEscala = new System.Windows.Forms.Button();
            this.tbEscY = new System.Windows.Forms.TextBox();
            this.tbEscX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btTransladar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTransY = new System.Windows.Forms.TextBox();
            this.tbTransX = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVertices = new System.Windows.Forms.DataGridView();
            this.polX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPoligonos = new System.Windows.Forms.DataGridView();
            this.colPoligonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.tabPane.SuspendLayout();
            this.tabPrimitivas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPoligonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoligonos)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoligonos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.tabPrimitivas);
            this.tabPane.Controls.Add(this.tabPoligonos);
            this.tabPane.Location = new System.Drawing.Point(12, 12);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(1174, 784);
            this.tabPane.TabIndex = 2;
            // 
            // tabPrimitivas
            // 
            this.tabPrimitivas.Controls.Add(this.panel1);
            this.tabPrimitivas.Controls.Add(this.pictureBox1);
            this.tabPrimitivas.Location = new System.Drawing.Point(4, 22);
            this.tabPrimitivas.Name = "tabPrimitivas";
            this.tabPrimitivas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimitivas.Size = new System.Drawing.Size(1166, 758);
            this.tabPrimitivas.TabIndex = 0;
            this.tabPrimitivas.Text = "Primitivas";
            this.tabPrimitivas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(867, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 746);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.cbElipse);
            this.panel5.Location = new System.Drawing.Point(8, 250);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 84);
            this.panel5.TabIndex = 5;
            // 
            // cbElipse
            // 
            this.cbElipse.AutoSize = true;
            this.cbElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbElipse.Location = new System.Drawing.Point(3, 3);
            this.cbElipse.Name = "cbElipse";
            this.cbElipse.Size = new System.Drawing.Size(65, 21);
            this.cbElipse.TabIndex = 5;
            this.cbElipse.Text = "Elipse";
            this.cbElipse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Elipse";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbCircPM);
            this.panel3.Controls.Add(this.cbCircTrig);
            this.panel3.Controls.Add(this.cbCircEqGeral);
            this.panel3.Location = new System.Drawing.Point(8, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 84);
            this.panel3.TabIndex = 3;
            // 
            // cbCircPM
            // 
            this.cbCircPM.AutoSize = true;
            this.cbCircPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCircPM.Location = new System.Drawing.Point(3, 56);
            this.cbCircPM.Name = "cbCircPM";
            this.cbCircPM.Size = new System.Drawing.Size(106, 21);
            this.cbCircPM.TabIndex = 7;
            this.cbCircPM.Text = "Ponto Médio";
            this.cbCircPM.UseVisualStyleBackColor = true;
            // 
            // cbCircTrig
            // 
            this.cbCircTrig.AutoSize = true;
            this.cbCircTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCircTrig.Location = new System.Drawing.Point(3, 30);
            this.cbCircTrig.Name = "cbCircTrig";
            this.cbCircTrig.Size = new System.Drawing.Size(122, 21);
            this.cbCircTrig.TabIndex = 6;
            this.cbCircTrig.Text = "Trigonométrica";
            this.cbCircTrig.UseVisualStyleBackColor = true;
            // 
            // cbCircEqGeral
            // 
            this.cbCircEqGeral.AutoSize = true;
            this.cbCircEqGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCircEqGeral.Location = new System.Drawing.Point(3, 3);
            this.cbCircEqGeral.Name = "cbCircEqGeral";
            this.cbCircEqGeral.Size = new System.Drawing.Size(122, 21);
            this.cbCircEqGeral.TabIndex = 4;
            this.cbCircEqGeral.Text = "Equação Geral";
            this.cbCircEqGeral.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Circunferências";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbPtMedio);
            this.panel2.Controls.Add(this.cbDeclive);
            this.panel2.Controls.Add(this.cbEqReal);
            this.panel2.Location = new System.Drawing.Point(8, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 84);
            this.panel2.TabIndex = 1;
            // 
            // cbPtMedio
            // 
            this.cbPtMedio.AutoSize = true;
            this.cbPtMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPtMedio.Location = new System.Drawing.Point(4, 52);
            this.cbPtMedio.Name = "cbPtMedio";
            this.cbPtMedio.Size = new System.Drawing.Size(106, 21);
            this.cbPtMedio.TabIndex = 2;
            this.cbPtMedio.Text = "Ponto Médio";
            this.cbPtMedio.UseVisualStyleBackColor = true;
            // 
            // cbDeclive
            // 
            this.cbDeclive.AutoSize = true;
            this.cbDeclive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeclive.Location = new System.Drawing.Point(4, 28);
            this.cbDeclive.Name = "cbDeclive";
            this.cbDeclive.Size = new System.Drawing.Size(144, 21);
            this.cbDeclive.TabIndex = 1;
            this.cbDeclive.Text = "Método do Declive";
            this.cbDeclive.UseVisualStyleBackColor = true;
            // 
            // cbEqReal
            // 
            this.cbEqReal.AutoSize = true;
            this.cbEqReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEqReal.Location = new System.Drawing.Point(4, 4);
            this.cbEqReal.Name = "cbEqReal";
            this.cbEqReal.Size = new System.Drawing.Size(116, 21);
            this.cbEqReal.TabIndex = 0;
            this.cbEqReal.Text = "Equação Real";
            this.cbEqReal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 746);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClique);
            // 
            // tabPoligonos
            // 
            this.tabPoligonos.Controls.Add(this.pictureBoxPoligonos);
            this.tabPoligonos.Controls.Add(this.panel6);
            this.tabPoligonos.Location = new System.Drawing.Point(4, 22);
            this.tabPoligonos.Name = "tabPoligonos";
            this.tabPoligonos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoligonos.Size = new System.Drawing.Size(1166, 758);
            this.tabPoligonos.TabIndex = 1;
            this.tabPoligonos.Text = "Poligonos";
            this.tabPoligonos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPoligonos
            // 
            this.pictureBoxPoligonos.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPoligonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPoligonos.Location = new System.Drawing.Point(4, 6);
            this.pictureBoxPoligonos.Name = "pictureBoxPoligonos";
            this.pictureBoxPoligonos.Size = new System.Drawing.Size(855, 746);
            this.pictureBoxPoligonos.TabIndex = 9;
            this.pictureBoxPoligonos.TabStop = false;
            this.pictureBoxPoligonos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseCliquePoligono);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btCor);
            this.panel6.Controls.Add(this.btFluidFill);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(865, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 746);
            this.panel6.TabIndex = 8;
            // 
            // btCor
            // 
            this.btCor.BackgroundImage = global::Primitivas_Graficas.Properties.Resources.colors;
            this.btCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCor.Location = new System.Drawing.Point(104, 316);
            this.btCor.Name = "btCor";
            this.btCor.Size = new System.Drawing.Size(172, 74);
            this.btCor.TabIndex = 10;
            this.btCor.UseVisualStyleBackColor = true;
            this.btCor.Click += new System.EventHandler(this.BtCor_Click);
            // 
            // btFluidFill
            // 
            this.btFluidFill.BackgroundImage = global::Primitivas_Graficas.Properties.Resources.balde;
            this.btFluidFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btFluidFill.Location = new System.Drawing.Point(9, 316);
            this.btFluidFill.Name = "btFluidFill";
            this.btFluidFill.Size = new System.Drawing.Size(88, 74);
            this.btFluidFill.TabIndex = 3;
            this.btFluidFill.UseVisualStyleBackColor = true;
            this.btFluidFill.Click += new System.EventHandler(this.BtFluidFill_Click_1);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.btEspX);
            this.panel7.Controls.Add(this.btEspY);
            this.panel7.Controls.Add(this.btCisalhar);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.tbCisY);
            this.panel7.Controls.Add(this.tbCisX);
            this.panel7.Controls.Add(this.btRotacionar);
            this.panel7.Controls.Add(this.cbEixo);
            this.panel7.Controls.Add(this.cbOrigem);
            this.panel7.Controls.Add(this.tbAngulo);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.btEscala);
            this.panel7.Controls.Add(this.tbEscY);
            this.panel7.Controls.Add(this.tbEscX);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.btTransladar);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.tbTransY);
            this.panel7.Controls.Add(this.tbTransX);
            this.panel7.Location = new System.Drawing.Point(9, 396);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(272, 343);
            this.panel7.TabIndex = 9;
            // 
            // btEspX
            // 
            this.btEspX.Location = new System.Drawing.Point(4, 226);
            this.btEspX.Name = "btEspX";
            this.btEspX.Size = new System.Drawing.Size(129, 23);
            this.btEspX.TabIndex = 21;
            this.btEspX.Text = "Espelhar em X";
            this.btEspX.UseVisualStyleBackColor = true;
            this.btEspX.Click += new System.EventHandler(this.BtEspX_Click);
            // 
            // btEspY
            // 
            this.btEspY.Location = new System.Drawing.Point(136, 226);
            this.btEspY.Name = "btEspY";
            this.btEspY.Size = new System.Drawing.Size(128, 23);
            this.btEspY.TabIndex = 20;
            this.btEspY.Text = "Espelhar em Y";
            this.btEspY.UseVisualStyleBackColor = true;
            this.btEspY.Click += new System.EventHandler(this.BtEspY_Click);
            // 
            // btCisalhar
            // 
            this.btCisalhar.Location = new System.Drawing.Point(170, 182);
            this.btCisalhar.Name = "btCisalhar";
            this.btCisalhar.Size = new System.Drawing.Size(94, 23);
            this.btCisalhar.TabIndex = 16;
            this.btCisalhar.Text = "Cisalhar";
            this.btCisalhar.UseVisualStyleBackColor = true;
            this.btCisalhar.Click += new System.EventHandler(this.BtCisalhar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cisalhamento (Cis. X, Cis. Y)";
            // 
            // tbCisY
            // 
            this.tbCisY.Location = new System.Drawing.Point(88, 184);
            this.tbCisY.Name = "tbCisY";
            this.tbCisY.Size = new System.Drawing.Size(75, 20);
            this.tbCisY.TabIndex = 14;
            // 
            // tbCisX
            // 
            this.tbCisX.Location = new System.Drawing.Point(5, 184);
            this.tbCisX.Name = "tbCisX";
            this.tbCisX.Size = new System.Drawing.Size(76, 20);
            this.tbCisX.TabIndex = 13;
            // 
            // btRotacionar
            // 
            this.btRotacionar.Location = new System.Drawing.Point(170, 112);
            this.btRotacionar.Name = "btRotacionar";
            this.btRotacionar.Size = new System.Drawing.Size(95, 43);
            this.btRotacionar.TabIndex = 12;
            this.btRotacionar.Text = "Rotacionar";
            this.btRotacionar.UseVisualStyleBackColor = true;
            this.btRotacionar.Click += new System.EventHandler(this.BtRotacionar_Click);
            // 
            // cbEixo
            // 
            this.cbEixo.AutoSize = true;
            this.cbEixo.Location = new System.Drawing.Point(88, 138);
            this.cbEixo.Name = "cbEixo";
            this.cbEixo.Size = new System.Drawing.Size(82, 17);
            this.cbEixo.TabIndex = 11;
            this.cbEixo.Text = "Próprio Eixo";
            this.cbEixo.UseVisualStyleBackColor = true;
            // 
            // cbOrigem
            // 
            this.cbOrigem.AutoSize = true;
            this.cbOrigem.Location = new System.Drawing.Point(88, 114);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(59, 17);
            this.cbOrigem.TabIndex = 10;
            this.cbOrigem.Text = "Origem";
            this.cbOrigem.UseVisualStyleBackColor = true;
            // 
            // tbAngulo
            // 
            this.tbAngulo.Location = new System.Drawing.Point(5, 114);
            this.tbAngulo.Name = "tbAngulo";
            this.tbAngulo.Size = new System.Drawing.Size(76, 20);
            this.tbAngulo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rotação (Graus)";
            // 
            // btEscala
            // 
            this.btEscala.Location = new System.Drawing.Point(170, 67);
            this.btEscala.Name = "btEscala";
            this.btEscala.Size = new System.Drawing.Size(95, 23);
            this.btEscala.TabIndex = 7;
            this.btEscala.Text = "Escalar";
            this.btEscala.UseVisualStyleBackColor = true;
            this.btEscala.Click += new System.EventHandler(this.BtEscala_Click);
            // 
            // tbEscY
            // 
            this.tbEscY.Location = new System.Drawing.Point(88, 69);
            this.tbEscY.Name = "tbEscY";
            this.tbEscY.Size = new System.Drawing.Size(75, 20);
            this.tbEscY.TabIndex = 6;
            // 
            // tbEscX
            // 
            this.tbEscX.Location = new System.Drawing.Point(4, 70);
            this.tbEscX.Name = "tbEscX";
            this.tbEscX.Size = new System.Drawing.Size(77, 20);
            this.tbEscX.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Escala (Esc. X, Esc. Y)";
            // 
            // btTransladar
            // 
            this.btTransladar.Location = new System.Drawing.Point(170, 24);
            this.btTransladar.Name = "btTransladar";
            this.btTransladar.Size = new System.Drawing.Size(95, 23);
            this.btTransladar.TabIndex = 3;
            this.btTransladar.Text = "Transladar";
            this.btTransladar.UseVisualStyleBackColor = true;
            this.btTransladar.Click += new System.EventHandler(this.BtTransladar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Translação (Desl. X, Desl Y)";
            // 
            // tbTransY
            // 
            this.tbTransY.Location = new System.Drawing.Point(86, 26);
            this.tbTransY.Name = "tbTransY";
            this.tbTransY.Size = new System.Drawing.Size(77, 20);
            this.tbTransY.TabIndex = 1;
            // 
            // tbTransX
            // 
            this.tbTransX.Location = new System.Drawing.Point(4, 26);
            this.tbTransX.Name = "tbTransX";
            this.tbTransX.Size = new System.Drawing.Size(77, 20);
            this.tbTransX.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dgvVertices);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dgvPoligonos);
            this.panel4.Location = new System.Drawing.Point(9, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 307);
            this.panel4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lista de Vértices";
            // 
            // dgvVertices
            // 
            this.dgvVertices.AllowUserToAddRows = false;
            this.dgvVertices.AllowUserToDeleteRows = false;
            this.dgvVertices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVertices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polX,
            this.polY});
            this.dgvVertices.Location = new System.Drawing.Point(3, 165);
            this.dgvVertices.Name = "dgvVertices";
            this.dgvVertices.ReadOnly = true;
            this.dgvVertices.Size = new System.Drawing.Size(261, 131);
            this.dgvVertices.TabIndex = 6;
            // 
            // polX
            // 
            this.polX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.polX.HeaderText = "X";
            this.polX.Name = "polX";
            this.polX.ReadOnly = true;
            // 
            // polY
            // 
            this.polY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.polY.HeaderText = "Y";
            this.polY.Name = "polY";
            this.polY.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Polígonos";
            // 
            // dgvPoligonos
            // 
            this.dgvPoligonos.AllowUserToAddRows = false;
            this.dgvPoligonos.AllowUserToDeleteRows = false;
            this.dgvPoligonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoligonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPoligonos});
            this.dgvPoligonos.Location = new System.Drawing.Point(4, 26);
            this.dgvPoligonos.Name = "dgvPoligonos";
            this.dgvPoligonos.ReadOnly = true;
            this.dgvPoligonos.Size = new System.Drawing.Size(261, 103);
            this.dgvPoligonos.TabIndex = 0;
            this.dgvPoligonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPoligonos_CellClick);
            // 
            // colPoligonos
            // 
            this.colPoligonos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPoligonos.HeaderText = "Poligonos";
            this.colPoligonos.Name = "colPoligonos";
            this.colPoligonos.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1197, 808);
            this.Controls.Add(this.tabPane);
            this.Name = "Form1";
            this.Text = "Primitivas Graficas";
            this.tabPane.ResumeLayout(false);
            this.tabPrimitivas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPoligonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoligonos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoligonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPane;
        private System.Windows.Forms.TabPage tabPrimitivas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbCircEqGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbPtMedio;
        private System.Windows.Forms.CheckBox cbDeclive;
        private System.Windows.Forms.CheckBox cbEqReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPoligonos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVertices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPoligonos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox cbElipse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxPoligonos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbCircPM;
        private System.Windows.Forms.CheckBox cbCircTrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn polX;
        private System.Windows.Forms.DataGridViewTextBoxColumn polY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoligonos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTransY;
        private System.Windows.Forms.TextBox tbTransX;
        private System.Windows.Forms.Button btTransladar;
        private System.Windows.Forms.Button btEscala;
        private System.Windows.Forms.TextBox tbEscY;
        private System.Windows.Forms.TextBox tbEscX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRotacionar;
        private System.Windows.Forms.CheckBox cbEixo;
        private System.Windows.Forms.CheckBox cbOrigem;
        private System.Windows.Forms.TextBox tbAngulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btFluidFill;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button btCor;
        private System.Windows.Forms.Button btCisalhar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCisY;
        private System.Windows.Forms.TextBox tbCisX;
        private System.Windows.Forms.Button btEspX;
        private System.Windows.Forms.Button btEspY;
    }
}

