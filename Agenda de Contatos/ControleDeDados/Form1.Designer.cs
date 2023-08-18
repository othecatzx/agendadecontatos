namespace ControleDeDados
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
            Nome = new Label();
            Telefone = new Label();
            Email = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            lst_contatos = new ListView();
            label1 = new Label();
            txtBuscar = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(12, 175);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            Nome.Click += label1_Click;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(12, 219);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 1;
            Telefone.Text = "Telefone";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(12, 263);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 2;
            Email.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 193);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(189, 23);
            txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 237);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(189, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(67, 310);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // lst_contatos
            // 
            lst_contatos.Location = new Point(207, 94);
            lst_contatos.MultiSelect = false;
            lst_contatos.Name = "lst_contatos";
            lst_contatos.Size = new Size(508, 371);
            lst_contatos.TabIndex = 7;
            lst_contatos.UseCompatibleStateImageBehavior = false;
            lst_contatos.ItemSelectionChanged += lst_contatos_ItemSelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 32);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 8;
            label1.Text = "Buscar Contato";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(207, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(427, 23);
            txtBuscar.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(640, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 485);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(lst_contatos);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(Email);
            Controls.Add(Telefone);
            Controls.Add(Nome);
            Name = "Form1";
            Text = "Agenda de Contatos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label Telefone;
        private Label Email;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button btnSalvar;
        private ListView lst_contatos;
        private Label label1;
        private TextBox txtBuscar;
        private Button button1;
    }
}