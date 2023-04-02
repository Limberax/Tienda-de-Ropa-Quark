
namespace Tienda_de_Ropa
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTienda = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.checkBoxMao = new System.Windows.Forms.CheckBox();
            this.checkBoxCorta = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelNombreVendedor = new System.Windows.Forms.Label();
            this.labelCodigoVendedor = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Expres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTienda
            // 
            this.labelTienda.AutoSize = true;
            this.labelTienda.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienda.Location = new System.Drawing.Point(12, 91);
            this.labelTienda.Name = "labelTienda";
            this.labelTienda.Size = new System.Drawing.Size(100, 25);
            this.labelTienda.TabIndex = 1;
            this.labelTienda.Text = "Gangaridia";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(564, 91);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(110, 25);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Sanzio 712";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 130);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(157, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Nombre completo de Vendedor:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(13, 152);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(92, 13);
            this.label55.TabIndex = 4;
            this.label55.Text = "Codigo Vendedor:";
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Checked = true;
            this.radioCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCamisa.Location = new System.Drawing.Point(21, 36);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(67, 19);
            this.radioCamisa.TabIndex = 9;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            this.radioCamisa.CheckedChanged += new System.EventHandler(this.radioCamisa_CheckedChanged);
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPantalon.Location = new System.Drawing.Point(21, 75);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(74, 19);
            this.radioPantalon.TabIndex = 12;
            this.radioPantalon.TabStop = true;
            this.radioPantalon.Text = "Pantalon";
            this.radioPantalon.UseVisualStyleBackColor = true;
            this.radioPantalon.CheckedChanged += new System.EventHandler(this.radioPantalon_CheckedChanged);
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPremium.Location = new System.Drawing.Point(15, 71);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(76, 19);
            this.radioPremium.TabIndex = 16;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            this.radioPremium.CheckedChanged += new System.EventHandler(this.radioPremium_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Unidades de Stock disponibles :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(184, 338);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(0, 13);
            this.labelStock.TabIndex = 18;
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(345, 360);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(93, 20);
            this.textBoxPrecioUnitario.TabIndex = 19;
            this.textBoxPrecioUnitario.TextChanged += new System.EventHandler(this.textBoxPrecioUnitario_TextChanged);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(515, 360);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(45, 20);
            this.textBoxCantidad.TabIndex = 20;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio Unitario y Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cantidad";
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCotizar.Location = new System.Drawing.Point(104, 446);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(133, 43);
            this.buttonCotizar.TabIndex = 24;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.UseVisualStyleBackColor = true;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "$";
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.AutoSize = true;
            this.labelPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioTotal.Location = new System.Drawing.Point(299, 459);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(0, 24);
            this.labelPrecioTotal.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxChupin);
            this.groupBox1.Controls.Add(this.checkBoxMao);
            this.groupBox1.Controls.Add(this.checkBoxCorta);
            this.groupBox1.Controls.Add(this.radioPantalon);
            this.groupBox1.Controls.Add(this.radioCamisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 114);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Enabled = false;
            this.checkBoxChupin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChupin.Location = new System.Drawing.Point(139, 74);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(59, 17);
            this.checkBoxChupin.TabIndex = 18;
            this.checkBoxChupin.Text = "Chupin";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            this.checkBoxChupin.CheckedChanged += new System.EventHandler(this.checkBoxChupin_CheckedChanged);
            // 
            // checkBoxMao
            // 
            this.checkBoxMao.AutoSize = true;
            this.checkBoxMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMao.Location = new System.Drawing.Point(235, 38);
            this.checkBoxMao.Name = "checkBoxMao";
            this.checkBoxMao.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMao.TabIndex = 17;
            this.checkBoxMao.Text = "Cuello Mao";
            this.checkBoxMao.UseVisualStyleBackColor = true;
            this.checkBoxMao.CheckedChanged += new System.EventHandler(this.checkBoxMao_CheckedChanged);
            // 
            // checkBoxCorta
            // 
            this.checkBoxCorta.AutoSize = true;
            this.checkBoxCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCorta.Location = new System.Drawing.Point(139, 38);
            this.checkBoxCorta.Name = "checkBoxCorta";
            this.checkBoxCorta.Size = new System.Drawing.Size(87, 17);
            this.checkBoxCorta.TabIndex = 16;
            this.checkBoxCorta.Text = "Manga Corta";
            this.checkBoxCorta.UseVisualStyleBackColor = true;
            this.checkBoxCorta.CheckedChanged += new System.EventHandler(this.checkBoxCorta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioPremium);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(448, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 114);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(15, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 19);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelNombreVendedor
            // 
            this.labelNombreVendedor.AutoSize = true;
            this.labelNombreVendedor.Location = new System.Drawing.Point(170, 130);
            this.labelNombreVendedor.Name = "labelNombreVendedor";
            this.labelNombreVendedor.Size = new System.Drawing.Size(49, 13);
            this.labelNombreVendedor.TabIndex = 29;
            this.labelNombreVendedor.Text = "Limberax";
            // 
            // labelCodigoVendedor
            // 
            this.labelCodigoVendedor.AutoSize = true;
            this.labelCodigoVendedor.Location = new System.Drawing.Point(111, 153);
            this.labelCodigoVendedor.Name = "labelCodigoVendedor";
            this.labelCodigoVendedor.Size = new System.Drawing.Size(19, 13);
            this.labelCodigoVendedor.TabIndex = 30;
            this.labelCodigoVendedor.Text = "24";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(218, 131);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(33, 13);
            this.labelApellido.TabIndex = 32;
            this.labelApellido.Text = "Nova";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 546);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelCodigoVendedor);
            this.Controls.Add(this.labelNombreVendedor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPrecioTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonCotizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTienda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTienda;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxPrecioUnitario;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCotizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPrecioTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxChupin;
        private System.Windows.Forms.CheckBox checkBoxMao;
        private System.Windows.Forms.CheckBox checkBoxCorta;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelNombreVendedor;
        private System.Windows.Forms.Label labelCodigoVendedor;
        private System.Windows.Forms.Label labelApellido;
    }
}

