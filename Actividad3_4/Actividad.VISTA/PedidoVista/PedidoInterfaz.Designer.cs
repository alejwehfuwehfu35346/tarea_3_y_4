namespace Actividad.VISTA.PedidoVista
{
    partial class PedidoInterfaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoInterfaz));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(631, 30);
            button3.Name = "button3";
            button3.Size = new Size(116, 48);
            button3.TabIndex = 27;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(451, 30);
            button2.Name = "button2";
            button2.Size = new Size(116, 48);
            button2.TabIndex = 26;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(816, 30);
            button1.Name = "button1";
            button1.Size = new Size(116, 48);
            button1.TabIndex = 25;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(7, 283);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 22;
            label3.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 481);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 21;
            label2.Text = "TOTAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 20;
            label1.Text = "IDCLIENTE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 481);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(619, 518);
            dataGridView1.TabIndex = 14;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(57, 283);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(133, 140);
            button4.Name = "button4";
            button4.Size = new Size(79, 32);
            button4.TabIndex = 29;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // PedidoInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(991, 618);
            Controls.Add(button4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "PedidoInterfaz";
            Text = "PedidoInterfaz";
            Load += PedidoInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button button4;
    }
}