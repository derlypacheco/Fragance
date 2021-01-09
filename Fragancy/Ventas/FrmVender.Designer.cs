
namespace Fragancy.Ventas
{
    partial class FrmVender
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.flowLayoutPanelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelListado = new System.Windows.Forms.Panel();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.checkPicExistencias = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMarcas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCostumers = new System.Windows.Forms.ComboBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnCollasp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBtnClose = new System.Windows.Forms.PictureBox();
            this.panelContent.SuspendLayout();
            this.panelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPicExistencias)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollasp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.flowLayoutPanelItems);
            this.panelContent.Controls.Add(this.panelListado);
            this.panelContent.Controls.Add(this.panelFooter);
            this.panelContent.Controls.Add(this.panelheader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1432, 844);
            this.panelContent.TabIndex = 0;
            // 
            // flowLayoutPanelItems
            // 
            this.flowLayoutPanelItems.AutoScroll = true;
            this.flowLayoutPanelItems.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelItems.Location = new System.Drawing.Point(250, 73);
            this.flowLayoutPanelItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelItems.Name = "flowLayoutPanelItems";
            this.flowLayoutPanelItems.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelItems.Size = new System.Drawing.Size(1180, 669);
            this.flowLayoutPanelItems.TabIndex = 4;
            // 
            // panelListado
            // 
            this.panelListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(232)))), ((int)(((byte)(205)))));
            this.panelListado.Controls.Add(this.lblExistencias);
            this.panelListado.Controls.Add(this.checkPicExistencias);
            this.panelListado.Controls.Add(this.label1);
            this.panelListado.Controls.Add(this.comboMarcas);
            this.panelListado.Controls.Add(this.label2);
            this.panelListado.Controls.Add(this.comboCostumers);
            this.panelListado.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListado.Location = new System.Drawing.Point(0, 73);
            this.panelListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelListado.Name = "panelListado";
            this.panelListado.Size = new System.Drawing.Size(250, 669);
            this.panelListado.TabIndex = 3;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(45, 227);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(123, 20);
            this.lblExistencias.TabIndex = 6;
            this.lblExistencias.Text = "Solo existencias";
            this.lblExistencias.Click += new System.EventHandler(this.lblExistencias_Click);
            // 
            // checkPicExistencias
            // 
            this.checkPicExistencias.Image = global::Fragancy.Properties.Resources.checkbox_empty_35_32x;
            this.checkPicExistencias.Location = new System.Drawing.Point(14, 225);
            this.checkPicExistencias.Name = "checkPicExistencias";
            this.checkPicExistencias.Size = new System.Drawing.Size(25, 25);
            this.checkPicExistencias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkPicExistencias.TabIndex = 5;
            this.checkPicExistencias.TabStop = false;
            this.checkPicExistencias.Click += new System.EventHandler(this.checkPicExistencias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // comboMarcas
            // 
            this.comboMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMarcas.FormattingEnabled = true;
            this.comboMarcas.Location = new System.Drawing.Point(14, 174);
            this.comboMarcas.Name = "comboMarcas";
            this.comboMarcas.Size = new System.Drawing.Size(226, 28);
            this.comboMarcas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // comboCostumers
            // 
            this.comboCostumers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCostumers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCostumers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCostumers.FormattingEnabled = true;
            this.comboCostumers.Location = new System.Drawing.Point(14, 51);
            this.comboCostumers.Name = "comboCostumers";
            this.comboCostumers.Size = new System.Drawing.Size(226, 28);
            this.comboCostumers.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.panelFooter.Controls.Add(this.btnVender);
            this.panelFooter.Controls.Add(this.lblTotal);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 742);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1430, 100);
            this.panelFooter.TabIndex = 2;
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(105)))));
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(80)))), ((int)(((byte)(58)))));
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(1240, 18);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(175, 66);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Procesar";
            this.btnVender.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(775, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(450, 100);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "$ 1 ,687.50";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(76)))), ((int)(((byte)(105)))));
            this.panelheader.Controls.Add(this.btnCollasp);
            this.panelheader.Controls.Add(this.pictureBox1);
            this.panelheader.Controls.Add(this.picBtnClose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1430, 73);
            this.panelheader.TabIndex = 1;
            // 
            // btnCollasp
            // 
            this.btnCollasp.Image = global::Fragancy.Properties.Resources.list_255_128x;
            this.btnCollasp.Location = new System.Drawing.Point(93, 10);
            this.btnCollasp.Name = "btnCollasp";
            this.btnCollasp.Size = new System.Drawing.Size(32, 53);
            this.btnCollasp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCollasp.TabIndex = 7;
            this.btnCollasp.TabStop = false;
            this.btnCollasp.Click += new System.EventHandler(this.btnCollasp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fragancy.Properties.Resources.perfume;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // picBtnClose
            // 
            this.picBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBtnClose.Image = global::Fragancy.Properties.Resources.cancel_255_128x;
            this.picBtnClose.Location = new System.Drawing.Point(1374, 10);
            this.picBtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBtnClose.Name = "picBtnClose";
            this.picBtnClose.Size = new System.Drawing.Size(40, 53);
            this.picBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBtnClose.TabIndex = 4;
            this.picBtnClose.TabStop = false;
            this.picBtnClose.Click += new System.EventHandler(this.picBtnClose_Click);
            // 
            // FrmVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 844);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVender";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVender_Load);
            this.panelContent.ResumeLayout(false);
            this.panelListado.ResumeLayout(false);
            this.panelListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPicExistencias)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCollasp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.PictureBox picBtnClose;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelListado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCostumers;
        private System.Windows.Forms.PictureBox btnCollasp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMarcas;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.PictureBox checkPicExistencias;
    }
}