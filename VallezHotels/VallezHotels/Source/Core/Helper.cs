﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VallezHotels.Source.Core
{


    /*
        Classe de apoio destinada a controlar os formulários que serão ativados dentro do painel principal do FrmPrincipal.     
     */
    public class Helper
    {

        // Ativa o formulario enviado por parametro no MDI pai
        public static void StartForm(Form form, Form mdiParent, FormWindowState? state)
        {
            // Verifica se o parente é null, se for null impede o usuário de usar outras telas sem antes finalizar a form.
            if (mdiParent == null)
            {
                form.ShowDialog();
                return;

            }

            bool formAlreadyOpen = false;

            foreach (Form f in Application.OpenForms)
            {

                if (f.Name == form.Name)
                {
                    formAlreadyOpen = true;
                    f.WindowState = FormWindowState.Normal;
                    f.BringToFront();
                    break;
                }
            }

            if (!formAlreadyOpen)
            {
                if (state != null)
                {
                    form.WindowState = state.Value;
                } else
                {
                    form.WindowState = FormWindowState.Minimized;
                }
                form.MdiParent = mdiParent;
                form.Top = 0;
                form.Left = 0;
                form.Show();

            }

        }

        public static void StartForm(Form form, Form mdiParent)
        {
            StartForm(form, mdiParent, 0);
        }

        public static void StartForm(Form form)
        {
            StartForm(form, null, 0);
        }

        public static void StartForm(Form form, FormWindowState state)
        {
            StartForm(form, null, state);
        }

    }


}
