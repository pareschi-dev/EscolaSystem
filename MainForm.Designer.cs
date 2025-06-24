namespace EscolaSystem
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            escolasToolStripMenuItem = new ToolStripMenuItem();
            turmasToolStripMenuItem = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            matériasToolStripMenuItem = new ToolStripMenuItem();
            processosToolStripMenuItem = new ToolStripMenuItem();
            notasFrequênciaToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button5 = new Button();
            button8 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Honeydew;
            menuStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, cadastrosToolStripMenuItem, processosToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1924, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(52, 21);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(98, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { escolasToolStripMenuItem, turmasToolStripMenuItem, alunosToolStripMenuItem, matériasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(80, 21);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // escolasToolStripMenuItem
            // 
            escolasToolStripMenuItem.Name = "escolasToolStripMenuItem";
            escolasToolStripMenuItem.Size = new Size(128, 22);
            escolasToolStripMenuItem.Text = "Escolas";
            escolasToolStripMenuItem.Click += escolasToolStripMenuItem_Click;
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.Size = new Size(128, 22);
            turmasToolStripMenuItem.Text = "Turmas";
            turmasToolStripMenuItem.Click += turmasToolStripMenuItem_Click;
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(128, 22);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click;
            // 
            // matériasToolStripMenuItem
            // 
            matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            matériasToolStripMenuItem.Size = new Size(128, 22);
            matériasToolStripMenuItem.Text = "Matérias";
            matériasToolStripMenuItem.Click += matériasToolStripMenuItem_Click;
            // 
            // processosToolStripMenuItem
            // 
            processosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notasFrequênciaToolStripMenuItem });
            processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            processosToolStripMenuItem.Size = new Size(80, 21);
            processosToolStripMenuItem.Text = "Processos";
            // 
            // notasFrequênciaToolStripMenuItem
            // 
            notasFrequênciaToolStripMenuItem.Name = "notasFrequênciaToolStripMenuItem";
            notasFrequênciaToolStripMenuItem.Size = new Size(183, 22);
            notasFrequênciaToolStripMenuItem.Text = "Notas/Frequência";
            notasFrequênciaToolStripMenuItem.Click += notasFrequênciaToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(55, 21);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 35, 41);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1655, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 1078);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = mysqlsistema.Properties.Resources.code6x2;
            pictureBox1.Location = new Point(3, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(3, 239);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 10;
            label2.Text = "Usuário: Admin";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(34, 35, 41);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 942);
            button5.Name = "button5";
            button5.Size = new Size(259, 62);
            button5.TabIndex = 7;
            button5.Text = "↩️ Sair";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(34, 35, 41);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(-3, 685);
            button8.Name = "button8";
            button8.Size = new Size(268, 62);
            button8.TabIndex = 4;
            button8.Text = "👥 Turmas";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 35, 41);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-3, 617);
            button3.Name = "button3";
            button3.Size = new Size(268, 62);
            button3.TabIndex = 3;
            button3.Text = "📝 Notas/Frequências";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 35, 41);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(-2, 549);
            button4.Name = "button4";
            button4.Size = new Size(268, 62);
            button4.TabIndex = 2;
            button4.Text = "📖 Matérias";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 35, 41);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-3, 481);
            button2.Name = "button2";
            button2.Size = new Size(269, 62);
            button2.TabIndex = 1;
            button2.Text = "🏫 Escolas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 35, 41);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-2, 413);
            button1.Name = "button1";
            button1.Size = new Size(269, 62);
            button1.TabIndex = 0;
            button1.Text = "👤 Alunos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 999);
            panel2.Name = "panel2";
            panel2.Size = new Size(1674, 63);
            panel2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(586, 25);
            label3.TabIndex = 13;
            label3.Text = "Centro de Orientação e Desenvolvimento em Experiência Extensiva";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 87, 160);
            ClientSize = new Size(1924, 1061);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Sistema Escolar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasFrequênciaToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Panel panel1;
        private Button button5;
        private Button button8;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
    }
}