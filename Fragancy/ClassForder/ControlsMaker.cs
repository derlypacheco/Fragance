using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragancy.ClassForder
{
    public class ControlsMaker
    {

        private void AddtoCar(object sender, EventArgs e, string id)
        {
            MessageBox.Show("Pasando el ID: " + id);
        }

        public Panel CreateItemShop(string IDCart)
        {
            Panel conterPanel = new Panel();
            conterPanel.Width = 150;
            conterPanel.Height = 210;
            PictureBox box = CreatePictureBox(Properties.Resources.perfume);
            conterPanel.BackColor = Color.White;
            conterPanel.Controls.Add(box);
            conterPanel.Controls.Add(CreatelblPrecio("$1,890.88"));
            conterPanel.Controls.Add(CreateLabelName("Carolina Herrera 212"));
            conterPanel.Controls.Add(BtnAddCart(IDCart));
            return conterPanel;
        }

        private PictureBox CreatePictureBox(Image src)
        {
            PictureBox Box = new PictureBox();
            Box.Width = 110;
            Box.Height = 100;
            Box.Location = new Point(3, 6);
            Box.Margin = new Padding(5);
            Box.Image = src;
            Box.SizeMode = PictureBoxSizeMode.Zoom;
            return Box;
        }

        private Label CreatelblPrecio(string costo)
        {
            Label lblPrecio = new Label();
            lblPrecio.Width = 141;
            lblPrecio.Text = costo;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(239, 76, 105);
            lblPrecio.Location = new Point(3, 109);
            lblPrecio.TextAlign = ContentAlignment.MiddleLeft;
            return lblPrecio;
        }

        private Label CreateLabelName(string txtLabel)
        {
            Label lbl = new Label();
            lbl.Text = txtLabel;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.FromArgb(35, 35, 35);
            lbl.Location = new Point(6,139);
            lbl.Font = new Font("Microsoft Sans Serif", 10);
            lbl.Width = 141;
            lbl.Height = 17;
            return lbl;
        }

        private Button BtnAddCart(string ID)
        {
            Button btnCart = new Button();
            btnCart.Width = 140;
            btnCart.Height = 28;
            btnCart.Location = new Point(5, 169);
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.BackColor = Color.FromArgb(33,185,152);
            btnCart.Image = Properties.Resources.mas_255_16x;
            btnCart.Click += delegate (object sender, EventArgs e) { AddtoCar(sender, e, ID); };
            return btnCart;
        }

        private Label CreateLabelEtiqueta(string value, PictureBox pic)
        {
            Label lblEti = new Label();
            lblEti.Text = value;
            lblEti.Location = new Point(5, 5);
            lblEti.AutoSize = true;
            //lblEti.BackColor = Color.FromArgb(250, 201, 62);
            lblEti.BackColor = Color.Transparent;
            lblEti.FlatStyle = FlatStyle.Flat;
            lblEti.Parent = pic;
            lblEti.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            lblEti.ForeColor = Color.FromArgb(239, 76, 105);
            return lblEti;
        }

    }
}
