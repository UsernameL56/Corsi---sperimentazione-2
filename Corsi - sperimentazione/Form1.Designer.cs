namespace Corsi___sperimentazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.PulsanteAggiunta = new System.Windows.Forms.Button();
            this.PulsanteStampa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PulsanteCancellazione = new System.Windows.Forms.Button();
            this.PulsanteModifica = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(637, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(424, 621);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PulsanteAggiunta
            // 
            this.PulsanteAggiunta.Location = new System.Drawing.Point(66, 496);
            this.PulsanteAggiunta.Name = "PulsanteAggiunta";
            this.PulsanteAggiunta.Size = new System.Drawing.Size(109, 43);
            this.PulsanteAggiunta.TabIndex = 1;
            this.PulsanteAggiunta.Text = "Aggiungi";
            this.PulsanteAggiunta.UseVisualStyleBackColor = true;
            this.PulsanteAggiunta.Click += new System.EventHandler(this.PulsanteAggiunta_Click);
            // 
            // PulsanteStampa
            // 
            this.PulsanteStampa.Location = new System.Drawing.Point(190, 496);
            this.PulsanteStampa.Name = "PulsanteStampa";
            this.PulsanteStampa.Size = new System.Drawing.Size(109, 43);
            this.PulsanteStampa.TabIndex = 2;
            this.PulsanteStampa.Text = "Stampa";
            this.PulsanteStampa.UseVisualStyleBackColor = true;
            this.PulsanteStampa.Click += new System.EventHandler(this.PulsanteStampa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 42);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PulsanteCancellazione
            // 
            this.PulsanteCancellazione.Location = new System.Drawing.Point(315, 496);
            this.PulsanteCancellazione.Name = "PulsanteCancellazione";
            this.PulsanteCancellazione.Size = new System.Drawing.Size(109, 43);
            this.PulsanteCancellazione.TabIndex = 6;
            this.PulsanteCancellazione.Text = "Cancella";
            this.PulsanteCancellazione.UseVisualStyleBackColor = true;
            this.PulsanteCancellazione.Click += new System.EventHandler(this.PulsanteCancellazione_Click);
            // 
            // PulsanteModifica
            // 
            this.PulsanteModifica.Location = new System.Drawing.Point(439, 496);
            this.PulsanteModifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PulsanteModifica.Name = "PulsanteModifica";
            this.PulsanteModifica.Size = new System.Drawing.Size(109, 43);
            this.PulsanteModifica.TabIndex = 7;
            this.PulsanteModifica.Text = "Modifica";
            this.PulsanteModifica.UseVisualStyleBackColor = true;
            this.PulsanteModifica.Click += new System.EventHandler(this.PulsanteModifica_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 146);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 42);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MODIFICA";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 664);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PulsanteModifica);
            this.Controls.Add(this.PulsanteCancellazione);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PulsanteStampa);
            this.Controls.Add(this.PulsanteAggiunta);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button PulsanteAggiunta;
        private System.Windows.Forms.Button PulsanteStampa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PulsanteCancellazione;
        private System.Windows.Forms.Button PulsanteModifica;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

