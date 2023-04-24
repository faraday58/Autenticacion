using System;
using Usuarios_G2_2023_II;
using System.Windows.Forms;

namespace Autenticacion
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*Persona persona = new Persona("rafael","rafael123");
            
            if(txtbUsuario.Text == persona.Usuario && txtbPassword.Text== persona.Password )
            {
                MessageBox.Show("Autenticación exitosa");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }*/

            GeneraUsuario generaUsuario = new GeneraUsuario();
            generaUsuario.Generar();
            Persona persona = (Persona)generaUsuario.usuarios[0];


            if(txtbUsuario.Text == persona.Usuario && txtbPassword.Text == persona.Password    )
            {
                MessageBox.Show("Autenticación exitosa");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }


        }

        private void txtbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char)Keys.Enter  )
            {

                GeneraUsuario generaUsuario = new GeneraUsuario();
                generaUsuario.Generar();
                Persona persona = (Persona)generaUsuario.usuarios[0];


                if (txtbUsuario.Text == persona.Usuario && txtbPassword.Text == persona.Password)
                {
                    MessageBox.Show("Autenticación exitosa");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }

            }

        }
    }
}
