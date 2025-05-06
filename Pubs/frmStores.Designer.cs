namespace Pubs
{
    partial class frmStores
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvTienda = new System.Windows.Forms.DataGridView();
            this.contextMenuStripsStore = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).BeginInit();
            this.contextMenuStripsStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tienda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(69, 18);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(384, 26);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dgvTienda
            // 
            this.dgvTienda.AllowUserToAddRows = false;
            this.dgvTienda.AllowUserToDeleteRows = false;
            this.dgvTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienda.ContextMenuStrip = this.contextMenuStripsStore;
            this.dgvTienda.Location = new System.Drawing.Point(3, 67);
            this.dgvTienda.Name = "dgvTienda";
            this.dgvTienda.ReadOnly = true;
            this.dgvTienda.RowHeadersWidth = 62;
            this.dgvTienda.RowTemplate.Height = 28;
            this.dgvTienda.Size = new System.Drawing.Size(795, 371);
            this.dgvTienda.TabIndex = 2;
            // 
            // contextMenuStripsStore
            // 
            this.contextMenuStripsStore.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripsStore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuActualizar,
            this.toolStripMenuEliminar});
            this.contextMenuStripsStore.Name = "contextMenuStripsStore";
            this.contextMenuStripsStore.Size = new System.Drawing.Size(241, 101);
            // 
            // toolStripMenuActualizar
            // 
            this.toolStripMenuActualizar.Name = "toolStripMenuActualizar";
            this.toolStripMenuActualizar.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuActualizar.Text = "Actualizar";
            this.toolStripMenuActualizar.Click += new System.EventHandler(this.toolStripMenuActualizar_Click);
            // 
            // toolStripMenuEliminar
            // 
            this.toolStripMenuEliminar.Name = "toolStripMenuEliminar";
            this.toolStripMenuEliminar.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuEliminar.Text = "Eliminar";
            // 
            // frmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTienda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "frmStores";
            this.Text = "Tiendas";
            this.Load += new System.EventHandler(this.frmStores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).EndInit();
            this.contextMenuStripsStore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvTienda;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripsStore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuActualizar;
    }
}