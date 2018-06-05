﻿using Loja1._0.Control;
using Loja1._0.Model;
using Loja1._0.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja1._0
{
    public partial class TrocaUser : Form
    {
        Controle controle = new Controle();
        Model.Usuarios user;
        private PDV pdv;

        Email email = new Email();
        public string erro;

        public TrocaUser(Model.Usuarios user, PDV pdv)
        {
            InitializeComponent();
            this.pdv = pdv;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text.Equals(""))
                {
                    MessageBox.Show("Digite um valor válido para Login e Senha", "Usuário/Senha inválido");
                }
                else
                {
                    user = controle.PesquisaUserLogin(txtLogin.Text.Trim().ToUpper());
                    if (user == null)
                    {
                        MessageBox.Show("Digite um valor válido para Login e Senha", "Usuário/Senha inválido");
                    }
                    else
                    {
                        if (txtSenha.Text == user.senha && user.status != 0)
                        {
                            this.Hide();
                            txtLogin.Text = "";
                            txtSenha.Text = "";
                            pdv.Show();
                            pdv.user = user;
                            pdv.lblUser.Text = user.login;
                        }

                        else
                        {
                            MessageBox.Show("Digite um valor válido para Login e Senha", "Usuário/Senha inválido");
                        }
                    }
                }
            }
            catch
            {
                //havendo erro na execução das instruções envia email ao desenvolvedor e mensagem de erro desconhecido ao usuário
                erro = "TrocaUser.cs, na instrução \"btnEntrar_Click\"";
                email.EnviaEmail(erro);
                MessageBox.Show("Erro não identificado em " + erro + ", por favor, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
