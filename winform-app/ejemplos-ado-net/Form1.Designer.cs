
namespace ejemplos_ado_net
{
    partial class frmPokemons
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPokemos = new System.Windows.Forms.DataGridView();
            this.pBoxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemos
            // 
            this.dgvPokemos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemos.Location = new System.Drawing.Point(12, 33);
            this.dgvPokemos.Name = "dgvPokemos";
            this.dgvPokemos.Size = new System.Drawing.Size(443, 189);
            this.dgvPokemos.TabIndex = 0;
            this.dgvPokemos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPokemos_CellContentClick);
            this.dgvPokemos.SelectionChanged += new System.EventHandler(this.dgvPokemos_SelectionChanged);
            // 
            // pBoxPokemon
            // 
            this.pBoxPokemon.Location = new System.Drawing.Point(462, 33);
            this.pBoxPokemon.Name = "pBoxPokemon";
            this.pBoxPokemon.Size = new System.Drawing.Size(229, 189);
            this.pBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPokemon.TabIndex = 1;
            this.pBoxPokemon.TabStop = false;
            // 
            // frmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxPokemon);
            this.Controls.Add(this.dgvPokemos);
            this.Name = "frmPokemons";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemos;
        private System.Windows.Forms.PictureBox pBoxPokemon;
    }
}

