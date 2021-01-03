
namespace ElesElas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pontosPessoa1 = new System.Windows.Forms.Label();
            this.labelPontos = new System.Windows.Forms.Label();
            this.experienciaPessoa1 = new System.Windows.Forms.Label();
            this.labelExperiencia1 = new System.Windows.Forms.Label();
            this.habilitacoesPessoa1 = new System.Windows.Forms.Label();
            this.labelHabilitacoes1 = new System.Windows.Forms.Label();
            this.idadePessoa1 = new System.Windows.Forms.Label();
            this.labelidade1 = new System.Windows.Forms.Label();
            this.generoPessoa1 = new System.Windows.Forms.Label();
            this.labelGenero1 = new System.Windows.Forms.Label();
            this.nomePessoa1 = new System.Windows.Forms.Label();
            this.labelNome1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pontosPessoa2 = new System.Windows.Forms.Label();
            this.experienciaPessoa2 = new System.Windows.Forms.Label();
            this.labelPontos2 = new System.Windows.Forms.Label();
            this.labelExperiencia2 = new System.Windows.Forms.Label();
            this.habilitacoesPessoa2 = new System.Windows.Forms.Label();
            this.labelHabilitacoes2 = new System.Windows.Forms.Label();
            this.idadePessoa2 = new System.Windows.Forms.Label();
            this.labelidade2 = new System.Windows.Forms.Label();
            this.generoPessoa2 = new System.Windows.Forms.Label();
            this.labelGenero2 = new System.Windows.Forms.Label();
            this.nomePessoa2 = new System.Windows.Forms.Label();
            this.labelNome2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemGestor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLerCartoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGuardarCartoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJogar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelProfissao = new System.Windows.Forms.Label();
            this.buttonEscolher = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(0, 170);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 101);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(854, 170);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 101);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pontosPessoa1);
            this.panel1.Controls.Add(this.labelPontos);
            this.panel1.Controls.Add(this.experienciaPessoa1);
            this.panel1.Controls.Add(this.labelExperiencia1);
            this.panel1.Controls.Add(this.habilitacoesPessoa1);
            this.panel1.Controls.Add(this.labelHabilitacoes1);
            this.panel1.Controls.Add(this.idadePessoa1);
            this.panel1.Controls.Add(this.labelidade1);
            this.panel1.Controls.Add(this.generoPessoa1);
            this.panel1.Controls.Add(this.labelGenero1);
            this.panel1.Controls.Add(this.nomePessoa1);
            this.panel1.Controls.Add(this.labelNome1);
            this.panel1.Location = new System.Drawing.Point(81, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 294);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pontosPessoa1
            // 
            this.pontosPessoa1.AutoSize = true;
            this.pontosPessoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosPessoa1.Location = new System.Drawing.Point(-2, 269);
            this.pontosPessoa1.Name = "pontosPessoa1";
            this.pontosPessoa1.Size = new System.Drawing.Size(134, 20);
            this.pontosPessoa1.TabIndex = 14;
            this.pontosPessoa1.Text = "PontosPessoa1";
            this.pontosPessoa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPontos
            // 
            this.labelPontos.AutoSize = true;
            this.labelPontos.Location = new System.Drawing.Point(0, 256);
            this.labelPontos.Name = "labelPontos";
            this.labelPontos.Size = new System.Drawing.Size(40, 13);
            this.labelPontos.TabIndex = 13;
            this.labelPontos.Text = "Pontos";
            this.labelPontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // experienciaPessoa1
            // 
            this.experienciaPessoa1.AutoSize = true;
            this.experienciaPessoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experienciaPessoa1.Location = new System.Drawing.Point(-1, 208);
            this.experienciaPessoa1.Name = "experienciaPessoa1";
            this.experienciaPessoa1.Size = new System.Drawing.Size(171, 20);
            this.experienciaPessoa1.TabIndex = 12;
            this.experienciaPessoa1.Text = "ExperiênciaPessoa1";
            this.experienciaPessoa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExperiencia1
            // 
            this.labelExperiencia1.AutoSize = true;
            this.labelExperiencia1.Location = new System.Drawing.Point(1, 195);
            this.labelExperiencia1.Name = "labelExperiencia1";
            this.labelExperiencia1.Size = new System.Drawing.Size(62, 13);
            this.labelExperiencia1.TabIndex = 11;
            this.labelExperiencia1.Text = "Experiência";
            this.labelExperiencia1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habilitacoesPessoa1
            // 
            this.habilitacoesPessoa1.AutoSize = true;
            this.habilitacoesPessoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilitacoesPessoa1.Location = new System.Drawing.Point(0, 158);
            this.habilitacoesPessoa1.Name = "habilitacoesPessoa1";
            this.habilitacoesPessoa1.Size = new System.Drawing.Size(177, 20);
            this.habilitacoesPessoa1.TabIndex = 10;
            this.habilitacoesPessoa1.Text = "HabilitaçõesPessoa1";
            this.habilitacoesPessoa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHabilitacoes1
            // 
            this.labelHabilitacoes1.AutoSize = true;
            this.labelHabilitacoes1.Location = new System.Drawing.Point(2, 145);
            this.labelHabilitacoes1.Name = "labelHabilitacoes1";
            this.labelHabilitacoes1.Size = new System.Drawing.Size(65, 13);
            this.labelHabilitacoes1.TabIndex = 9;
            this.labelHabilitacoes1.Text = "Habilitações";
            this.labelHabilitacoes1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idadePessoa1
            // 
            this.idadePessoa1.AutoSize = true;
            this.idadePessoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadePessoa1.Location = new System.Drawing.Point(1, 111);
            this.idadePessoa1.Name = "idadePessoa1";
            this.idadePessoa1.Size = new System.Drawing.Size(124, 20);
            this.idadePessoa1.TabIndex = 8;
            this.idadePessoa1.Text = "IdadePessoa1";
            this.idadePessoa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelidade1
            // 
            this.labelidade1.AutoSize = true;
            this.labelidade1.Location = new System.Drawing.Point(3, 98);
            this.labelidade1.Name = "labelidade1";
            this.labelidade1.Size = new System.Drawing.Size(34, 13);
            this.labelidade1.TabIndex = 7;
            this.labelidade1.Text = "Idade";
            this.labelidade1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generoPessoa1
            // 
            this.generoPessoa1.AutoSize = true;
            this.generoPessoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoPessoa1.Location = new System.Drawing.Point(1, 61);
            this.generoPessoa1.Name = "generoPessoa1";
            this.generoPessoa1.Size = new System.Drawing.Size(138, 20);
            this.generoPessoa1.TabIndex = 6;
            this.generoPessoa1.Text = "GéneroPessoa1";
            this.generoPessoa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGenero1
            // 
            this.labelGenero1.AutoSize = true;
            this.labelGenero1.Location = new System.Drawing.Point(3, 48);
            this.labelGenero1.Name = "labelGenero1";
            this.labelGenero1.Size = new System.Drawing.Size(42, 13);
            this.labelGenero1.TabIndex = 5;
            this.labelGenero1.Text = "Género";
            this.labelGenero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomePessoa1
            // 
            this.nomePessoa1.AutoSize = true;
            this.nomePessoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePessoa1.Location = new System.Drawing.Point(2, 13);
            this.nomePessoa1.Name = "nomePessoa1";
            this.nomePessoa1.Size = new System.Drawing.Size(124, 20);
            this.nomePessoa1.TabIndex = 4;
            this.nomePessoa1.Text = "NomePessoa1";
            this.nomePessoa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNome1
            // 
            this.labelNome1.AutoSize = true;
            this.labelNome1.Location = new System.Drawing.Point(3, 0);
            this.labelNome1.Name = "labelNome1";
            this.labelNome1.Size = new System.Drawing.Size(35, 13);
            this.labelNome1.TabIndex = 3;
            this.labelNome1.Text = "Nome";
            this.labelNome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pontosPessoa2);
            this.panel2.Controls.Add(this.experienciaPessoa2);
            this.panel2.Controls.Add(this.labelPontos2);
            this.panel2.Controls.Add(this.labelExperiencia2);
            this.panel2.Controls.Add(this.habilitacoesPessoa2);
            this.panel2.Controls.Add(this.labelHabilitacoes2);
            this.panel2.Controls.Add(this.idadePessoa2);
            this.panel2.Controls.Add(this.labelidade2);
            this.panel2.Controls.Add(this.generoPessoa2);
            this.panel2.Controls.Add(this.labelGenero2);
            this.panel2.Controls.Add(this.nomePessoa2);
            this.panel2.Controls.Add(this.labelNome2);
            this.panel2.Location = new System.Drawing.Point(446, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 294);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pontosPessoa2
            // 
            this.pontosPessoa2.AutoSize = true;
            this.pontosPessoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosPessoa2.Location = new System.Drawing.Point(-2, 269);
            this.pontosPessoa2.Name = "pontosPessoa2";
            this.pontosPessoa2.Size = new System.Drawing.Size(134, 20);
            this.pontosPessoa2.TabIndex = 16;
            this.pontosPessoa2.Text = "PontosPessoa1";
            this.pontosPessoa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // experienciaPessoa2
            // 
            this.experienciaPessoa2.AutoSize = true;
            this.experienciaPessoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experienciaPessoa2.Location = new System.Drawing.Point(-1, 208);
            this.experienciaPessoa2.Name = "experienciaPessoa2";
            this.experienciaPessoa2.Size = new System.Drawing.Size(171, 20);
            this.experienciaPessoa2.TabIndex = 12;
            this.experienciaPessoa2.Text = "ExperiênciaPessoa1";
            this.experienciaPessoa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPontos2
            // 
            this.labelPontos2.AutoSize = true;
            this.labelPontos2.Location = new System.Drawing.Point(0, 256);
            this.labelPontos2.Name = "labelPontos2";
            this.labelPontos2.Size = new System.Drawing.Size(40, 13);
            this.labelPontos2.TabIndex = 15;
            this.labelPontos2.Text = "Pontos";
            this.labelPontos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExperiencia2
            // 
            this.labelExperiencia2.AutoSize = true;
            this.labelExperiencia2.Location = new System.Drawing.Point(1, 195);
            this.labelExperiencia2.Name = "labelExperiencia2";
            this.labelExperiencia2.Size = new System.Drawing.Size(62, 13);
            this.labelExperiencia2.TabIndex = 11;
            this.labelExperiencia2.Text = "Experiência";
            this.labelExperiencia2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habilitacoesPessoa2
            // 
            this.habilitacoesPessoa2.AutoSize = true;
            this.habilitacoesPessoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilitacoesPessoa2.Location = new System.Drawing.Point(0, 158);
            this.habilitacoesPessoa2.Name = "habilitacoesPessoa2";
            this.habilitacoesPessoa2.Size = new System.Drawing.Size(177, 20);
            this.habilitacoesPessoa2.TabIndex = 10;
            this.habilitacoesPessoa2.Text = "HabilitaçõesPessoa1";
            this.habilitacoesPessoa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHabilitacoes2
            // 
            this.labelHabilitacoes2.AutoSize = true;
            this.labelHabilitacoes2.Location = new System.Drawing.Point(2, 145);
            this.labelHabilitacoes2.Name = "labelHabilitacoes2";
            this.labelHabilitacoes2.Size = new System.Drawing.Size(65, 13);
            this.labelHabilitacoes2.TabIndex = 9;
            this.labelHabilitacoes2.Text = "Habilitações";
            this.labelHabilitacoes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idadePessoa2
            // 
            this.idadePessoa2.AutoSize = true;
            this.idadePessoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadePessoa2.Location = new System.Drawing.Point(1, 111);
            this.idadePessoa2.Name = "idadePessoa2";
            this.idadePessoa2.Size = new System.Drawing.Size(124, 20);
            this.idadePessoa2.TabIndex = 8;
            this.idadePessoa2.Text = "IdadePessoa2";
            this.idadePessoa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelidade2
            // 
            this.labelidade2.AutoSize = true;
            this.labelidade2.Location = new System.Drawing.Point(3, 98);
            this.labelidade2.Name = "labelidade2";
            this.labelidade2.Size = new System.Drawing.Size(34, 13);
            this.labelidade2.TabIndex = 7;
            this.labelidade2.Text = "Idade";
            this.labelidade2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generoPessoa2
            // 
            this.generoPessoa2.AutoSize = true;
            this.generoPessoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoPessoa2.Location = new System.Drawing.Point(1, 61);
            this.generoPessoa2.Name = "generoPessoa2";
            this.generoPessoa2.Size = new System.Drawing.Size(138, 20);
            this.generoPessoa2.TabIndex = 6;
            this.generoPessoa2.Text = "GéneroPessoa2";
            this.generoPessoa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGenero2
            // 
            this.labelGenero2.AutoSize = true;
            this.labelGenero2.Location = new System.Drawing.Point(3, 48);
            this.labelGenero2.Name = "labelGenero2";
            this.labelGenero2.Size = new System.Drawing.Size(42, 13);
            this.labelGenero2.TabIndex = 5;
            this.labelGenero2.Text = "Género";
            this.labelGenero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomePessoa2
            // 
            this.nomePessoa2.AutoSize = true;
            this.nomePessoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePessoa2.Location = new System.Drawing.Point(2, 13);
            this.nomePessoa2.Name = "nomePessoa2";
            this.nomePessoa2.Size = new System.Drawing.Size(124, 20);
            this.nomePessoa2.TabIndex = 4;
            this.nomePessoa2.Text = "NomePessoa2";
            this.nomePessoa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNome2
            // 
            this.labelNome2.AutoSize = true;
            this.labelNome2.Location = new System.Drawing.Point(3, 0);
            this.labelNome2.Name = "labelNome2";
            this.labelNome2.Size = new System.Drawing.Size(35, 13);
            this.labelNome2.TabIndex = 3;
            this.labelNome2.Text = "Nome";
            this.labelNome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGestor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuItemGestor
            // 
            this.menuItemGestor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLerCartoes,
            this.menuItemGuardarCartoes,
            this.menuItemEliminar,
            this.menuItemAdicionar,
            this.menuJogar});
            this.menuItemGestor.Name = "menuItemGestor";
            this.menuItemGestor.Size = new System.Drawing.Size(53, 20);
            this.menuItemGestor.Text = "Gestor";
            // 
            // menuItemLerCartoes
            // 
            this.menuItemLerCartoes.Name = "menuItemLerCartoes";
            this.menuItemLerCartoes.Size = new System.Drawing.Size(163, 22);
            this.menuItemLerCartoes.Text = "Ler Cartoes";
            this.menuItemLerCartoes.Click += new System.EventHandler(this.menuItemLerCartoes_Click);
            // 
            // menuItemGuardarCartoes
            // 
            this.menuItemGuardarCartoes.Name = "menuItemGuardarCartoes";
            this.menuItemGuardarCartoes.Size = new System.Drawing.Size(163, 22);
            this.menuItemGuardarCartoes.Text = "Guardar Cartões";
            this.menuItemGuardarCartoes.Click += new System.EventHandler(this.menuItemGuardarCartoes_Click);
            // 
            // menuItemEliminar
            // 
            this.menuItemEliminar.Name = "menuItemEliminar";
            this.menuItemEliminar.Size = new System.Drawing.Size(163, 22);
            this.menuItemEliminar.Text = "Eliminar Cartão";
            this.menuItemEliminar.Click += new System.EventHandler(this.menuItemEliminar_Click);
            // 
            // menuItemAdicionar
            // 
            this.menuItemAdicionar.Name = "menuItemAdicionar";
            this.menuItemAdicionar.Size = new System.Drawing.Size(163, 22);
            this.menuItemAdicionar.Text = "Adicionar Cartão";
            this.menuItemAdicionar.Click += new System.EventHandler(this.menuItemAdicionar_Click);
            // 
            // menuJogar
            // 
            this.menuJogar.Name = "menuJogar";
            this.menuJogar.Size = new System.Drawing.Size(163, 22);
            this.menuJogar.Text = "Jogar";
            this.menuJogar.Click += new System.EventHandler(this.menuJogar_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
            // 
            // labelProfissao
            // 
            this.labelProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfissao.Location = new System.Drawing.Point(0, 24);
            this.labelProfissao.Name = "labelProfissao";
            this.labelProfissao.Size = new System.Drawing.Size(884, 33);
            this.labelProfissao.TabIndex = 0;
            this.labelProfissao.Text = "Profissão";
            this.labelProfissao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProfissao.Visible = false;
            // 
            // buttonEscolher
            // 
            this.buttonEscolher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEscolher.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonEscolher.Location = new System.Drawing.Point(80, 383);
            this.buttonEscolher.Name = "buttonEscolher";
            this.buttonEscolher.Size = new System.Drawing.Size(691, 46);
            this.buttonEscolher.TabIndex = 9;
            this.buttonEscolher.Text = "Escolher";
            this.buttonEscolher.UseVisualStyleBackColor = true;
            this.buttonEscolher.Visible = false;
            this.buttonEscolher.Click += new System.EventHandler(this.buttonEscolher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.buttonEscolher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelProfissao);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label experienciaPessoa1;
        private System.Windows.Forms.Label labelExperiencia1;
        private System.Windows.Forms.Label habilitacoesPessoa1;
        private System.Windows.Forms.Label labelHabilitacoes1;
        private System.Windows.Forms.Label idadePessoa1;
        private System.Windows.Forms.Label labelidade1;
        private System.Windows.Forms.Label generoPessoa1;
        private System.Windows.Forms.Label labelGenero1;
        private System.Windows.Forms.Label nomePessoa1;
        private System.Windows.Forms.Label labelNome1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label experienciaPessoa2;
        private System.Windows.Forms.Label labelExperiencia2;
        private System.Windows.Forms.Label habilitacoesPessoa2;
        private System.Windows.Forms.Label labelHabilitacoes2;
        private System.Windows.Forms.Label idadePessoa2;
        private System.Windows.Forms.Label labelidade2;
        private System.Windows.Forms.Label generoPessoa2;
        private System.Windows.Forms.Label labelGenero2;
        private System.Windows.Forms.Label nomePessoa2;
        private System.Windows.Forms.Label labelNome2;
        private System.Windows.Forms.Label pontosPessoa1;
        private System.Windows.Forms.Label labelPontos;
        private System.Windows.Forms.Label pontosPessoa2;
        private System.Windows.Forms.Label labelPontos2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuItemGestor;
        private System.Windows.Forms.ToolStripMenuItem menuItemLerCartoes;
        private System.Windows.Forms.ToolStripMenuItem menuItemGuardarCartoes;
        private System.Windows.Forms.ToolStripMenuItem menuItemEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdicionar;
        private System.Windows.Forms.ToolStripMenuItem menuJogar;
        private System.Windows.Forms.Label labelProfissao;
        private System.Windows.Forms.Button buttonEscolher;
    }
}

