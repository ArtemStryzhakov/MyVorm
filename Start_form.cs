using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVorm
{
    class Start_form:System.Windows.Forms.Form
    {
        public Start_form()
        {
            Button Start_btn = new Button
            {
                Text = "Minu aken",
                Location = new System.Drawing.Point(10, 10)
            };

            Start_btn.Click += Start_btn_Click;
            this.Controls.Add(Start_btn);

            Button Start_btn_2 = new Button
            {
                Text = "Veel aken",
                Location = new System.Drawing.Point(10, 60)
            };

            Start_btn_2.Click += Start_btn_2_Click;
            this.Controls.Add(Start_btn_2);
        }

        private void Start_btn_2_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm(5,8);
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm("Mina olen paha aken", "Vali midagi", "Üks", "Kaks", "Kolm", "Neli");
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
    }
}
