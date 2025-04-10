namespace Form3_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TLPVuelto = new System.Windows.Forms.TableLayoutPanel();
            this.LvListaCambio = new System.Windows.Forms.ListView();
            this.Billete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblTotalCambio = new System.Windows.Forms.Label();
            this.TLPForm = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCalcularVuelto = new System.Windows.Forms.Button();
            this.TbValorProducto = new System.Windows.Forms.TextBox();
            this.TbPagacon = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.Img = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TLPVuelto.SuspendLayout();
            this.TLPForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.TLPVuelto);
            this.groupBox1.Controls.Add(this.TLPForm);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 469);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    Cálculo de vuelto    ";
            // 
            // TLPVuelto
            // 
            this.TLPVuelto.ColumnCount = 3;
            this.TLPVuelto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPVuelto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TLPVuelto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPVuelto.Controls.Add(this.LvListaCambio, 1, 0);
            this.TLPVuelto.Controls.Add(this.LblTotalCambio, 1, 2);
            this.TLPVuelto.Controls.Add(this.Img, 1, 1);
            this.TLPVuelto.Controls.Add(this.button1, 2, 2);
            this.TLPVuelto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPVuelto.Location = new System.Drawing.Point(3, 190);
            this.TLPVuelto.Name = "TLPVuelto";
            this.TLPVuelto.RowCount = 4;
            this.TLPVuelto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPVuelto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.30961F));
            this.TLPVuelto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.72598F));
            this.TLPVuelto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPVuelto.Size = new System.Drawing.Size(436, 276);
            this.TLPVuelto.TabIndex = 1;
            // 
            // LvListaCambio
            // 
            this.LvListaCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.LvListaCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvListaCambio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Billete,
            this.Valor,
            this.Cantidad});
            this.LvListaCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvListaCambio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvListaCambio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LvListaCambio.Location = new System.Drawing.Point(46, 3);
            this.LvListaCambio.Name = "LvListaCambio";
            this.LvListaCambio.Size = new System.Drawing.Size(342, 19);
            this.LvListaCambio.TabIndex = 3;
            this.LvListaCambio.UseCompatibleStateImageBehavior = false;
            this.LvListaCambio.Visible = false;
            // 
            // Billete
            // 
            this.Billete.Text = "Billete/Moneda";
            this.Billete.Width = 120;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // LblTotalCambio
            // 
            this.LblTotalCambio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTotalCambio.AutoSize = true;
            this.LblTotalCambio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCambio.Location = new System.Drawing.Point(152, 224);
            this.LblTotalCambio.Name = "LblTotalCambio";
            this.LblTotalCambio.Size = new System.Drawing.Size(129, 18);
            this.LblTotalCambio.TabIndex = 5;
            this.LblTotalCambio.Text = "Cambio Total:";
            this.LblTotalCambio.Visible = false;
            // 
            // TLPForm
            // 
            this.TLPForm.ColumnCount = 4;
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.20478F));
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.79522F));
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPForm.Controls.Add(this.BtnCalcularVuelto, 2, 3);
            this.TLPForm.Controls.Add(this.TbValorProducto, 2, 1);
            this.TLPForm.Controls.Add(this.TbPagacon, 2, 2);
            this.TLPForm.Controls.Add(this.LblValor, 1, 1);
            this.TLPForm.Controls.Add(this.LblMonto, 1, 2);
            this.TLPForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPForm.Location = new System.Drawing.Point(3, 19);
            this.TLPForm.Name = "TLPForm";
            this.TLPForm.RowCount = 5;
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882355F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882355F));
            this.TLPForm.Size = new System.Drawing.Size(436, 171);
            this.TLPForm.TabIndex = 0;
            // 
            // BtnCalcularVuelto
            // 
            this.BtnCalcularVuelto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCalcularVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnCalcularVuelto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcularVuelto.Enabled = false;
            this.BtnCalcularVuelto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCalcularVuelto.FlatAppearance.BorderSize = 2;
            this.BtnCalcularVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcularVuelto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularVuelto.Location = new System.Drawing.Point(156, 119);
            this.BtnCalcularVuelto.Name = "BtnCalcularVuelto";
            this.BtnCalcularVuelto.Size = new System.Drawing.Size(229, 31);
            this.BtnCalcularVuelto.TabIndex = 2;
            this.BtnCalcularVuelto.Text = "Calcular Vuelto";
            this.BtnCalcularVuelto.UseVisualStyleBackColor = false;
            this.BtnCalcularVuelto.EnabledChanged += new System.EventHandler(this.BtnCalcularVuelto_EnabledChanged);
            this.BtnCalcularVuelto.Click += new System.EventHandler(this.BtnCalcularVuelto_Click);
            // 
            // TbValorProducto
            // 
            this.TbValorProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbValorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.TbValorProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbValorProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbValorProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.TbValorProducto.Location = new System.Drawing.Point(147, 21);
            this.TbValorProducto.MaxLength = 12;
            this.TbValorProducto.Name = "TbValorProducto";
            this.TbValorProducto.Size = new System.Drawing.Size(248, 27);
            this.TbValorProducto.TabIndex = 0;
            this.TbValorProducto.TextChanged += new System.EventHandler(this.TbValorProducto__TextChanged);
            this.TbValorProducto.Enter += new System.EventHandler(this.TbValorProducto_Enter);
            this.TbValorProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorProducto_KeyPress);
            this.TbValorProducto.Leave += new System.EventHandler(this.TbValorProducto_Leave);
            // 
            // TbPagacon
            // 
            this.TbPagacon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPagacon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.TbPagacon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPagacon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPagacon.ForeColor = System.Drawing.SystemColors.Info;
            this.TbPagacon.Location = new System.Drawing.Point(147, 71);
            this.TbPagacon.MaxLength = 9;
            this.TbPagacon.Name = "TbPagacon";
            this.TbPagacon.Size = new System.Drawing.Size(248, 27);
            this.TbPagacon.TabIndex = 1;
            this.TbPagacon.TextChanged += new System.EventHandler(this.TbMontoIngresado__TextChanged);
            this.TbPagacon.Enter += new System.EventHandler(this.TbMontoIngresado_Enter);
            this.TbPagacon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMontoIngresado_KeyPress);
            this.TbPagacon.Leave += new System.EventHandler(this.TbMontoIngresado_Leave);
            // 
            // LblValor
            // 
            this.LblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(51, 19);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(73, 32);
            this.LblValor.TabIndex = 1;
            this.LblValor.Text = "Valor Producto:";
            // 
            // LblMonto
            // 
            this.LblMonto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(49, 77);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(75, 16);
            this.LblMonto.TabIndex = 0;
            this.LblMonto.Text = "Paga con:";
            // 
            // Img
            // 
            this.Img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Img.Image = global::Form3_1.Properties.Resources.billete;
            this.Img.Location = new System.Drawing.Point(46, 28);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(342, 181);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img.TabIndex = 6;
            this.Img.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(394, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(480, 507);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guia 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.TLPVuelto.ResumeLayout(false);
            this.TLPVuelto.PerformLayout();
            this.TLPForm.ResumeLayout(false);
            this.TLPForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel TLPForm;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Button BtnCalcularVuelto;
        private System.Windows.Forms.TableLayoutPanel TLPVuelto;
        private System.Windows.Forms.ListView LvListaCambio;
        private System.Windows.Forms.ColumnHeader Billete;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.TextBox TbValorProducto;
        private System.Windows.Forms.TextBox TbPagacon;
        private System.Windows.Forms.Label LblTotalCambio;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button button1;
    }
}

