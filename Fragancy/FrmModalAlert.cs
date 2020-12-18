using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragancy
{
    public partial class FrmModalAlert : Form
    {
        public string TitleLabel, TypeAlertConst, MessageLabel;
        public FrmModalAlert(string Title, string Message, string TypeAlert)
        {
            InitializeComponent();
            lblTitle.Text = Title;
            TypeAlertConst = TypeAlert;
            labelMessage.Text = Message;
            LoadIcon(TypeAlert);
        }

        public FrmModalAlert(string Message)
        {
            InitializeComponent();
            labelMessage.Text = Message;
            lblTitle.Text = "Aviso";
            LoadIcon("warning");
        }

        private void FrmModalAlert_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_MouseDown_1(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoadIcon(string StrIcon)
        {
            switch (StrIcon)
            {
                case "warning":
                    picImagen.Image = Properties.Resources.warning_240_128x;
                    panelHeader.BackColor = Color.FromArgb(250, 201, 62);
                    break;
                case "success":
                    picImagen.Image = Properties.Resources.success_128x;
                    panelHeader.BackColor = Color.FromArgb(33, 185, 152);
                    break;
                case "error":
                    picImagen.Image = Properties.Resources.cancel_red_128x;
                    panelHeader.BackColor = Color.FromArgb(235, 80, 5);
                    break;
                default:
                    picImagen.Image = Properties.Resources.warning_240_128x;
                    panelHeader.BackColor = Color.FromArgb(250, 201, 62);
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
