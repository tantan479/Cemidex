using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Cemidex.Models;

namespace Cemidex
{
    public partial class crudCemidex : Form
    {
        public crudCemidex()
        {
            InitializeComponent();
            using (var db = new CemidexContext())
            {
                AtualizarCbRequerente(db);
            }
        }

        private void AtualizarCbRequerente(CemidexContext db)
        {
            cbRequerente.DataSource = db.Requerentes.ToList();
            cbRequerente.DisplayMember = "Nome";
            cbRequerente.ValueMember = "IdRequerente";
        }

        private void btReqAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FrmRequerente())
            {
                form.Text = "Incluir Requerente";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using(var db = new CemidexContext())
                    {
                        Requerente requerente = new Requerente();
                        requerente.Nome = form.txtNome.Text;
                        requerente.Cpf = form.txtCpf.Text;
                        requerente.Telefone = form.txtTelefone.Text;
                        requerente.Endereco = form.txtEndereco.Text;
                        db.Requerentes.Add(requerente);
                        db.SaveChanges();
                        AtualizarCbRequerente(db);
                        MessageBox.Show("Requerente incluído com sucesso", "Informação");

                    }
                }
            }
        }

        private void btReqEd_Click(object sender, EventArgs e)
        {
            using (var form = new FrmRequerente())
            {
                int id = Convert.ToInt32(cbRequerente.SelectedValue);
                form.txtNome.Text = cbRequerente.Text;
                using var db = new CemidexContext();
                Requerente requerente = new Requerente();
                List<Requerente> lengths = db.Requerentes.Where(x => x.IdRequerente == id).ToList();
                form.txtEndereco.Text = lengths[0].Endereco;
                form.txtCpf.Text = lengths[0].Cpf;
                form.txtTelefone.Text = lengths[0].Telefone;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    
                        Requerente req = cbRequerente.SelectedItem as Requerente;
                        req.Nome = form.txtNome.Text;
                        req.Cpf = form.txtCpf.Text;
                        req.Endereco = form.txtEndereco.Text;
                        req.Telefone = form.txtTelefone.Text;
                        db.Requerentes.Attach(req);
                        db.Entry(req).State = EntityState.Modified;
                        db.SaveChanges();
                        AtualizarCbRequerente(db);
                        cbRequerente.SelectedItem = req;
                        MessageBox.Show("Requerente alterado com sucesso", "Informação");

                    
                }
            }
        }

        private void btReqRem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do requerente", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new CemidexContext())
                {
                    Requerente requerente = cbRequerente.SelectedItem as Requerente;
                    int qtdFalecidos = db.Falecidos.Where(x => x.IdRequerente == requerente.IdRequerente).Count();

                    if (qtdFalecidos == 0)
                    {
                        db.Attach(requerente);
                        db.Entry(requerente).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarCbRequerente(db);
                        MessageBox.Show("Requerente excluído com sucesso", "Informação");
                    }
                    else
                        MessageBox.Show("Requerente comtém falecidos", "Informação");
                }
            }
        }

        private void btFalAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FrmFalecido())
            {
                form.Text = "Inclusão";
                int id = Convert.ToInt32(cbRequerente.SelectedValue);
                form.numericRequerente.Value = id;
                if(form.ShowDialog() == DialogResult.OK)
                {
                    using var db = new CemidexContext();
                    Falecido falecido = new Falecido();
                    falecido.Nome = form.txtNome.Text;
                    falecido.Cpf = form.textCpf.Text;
                    falecido.IdCova = Convert.ToInt32(form.numericCova.Text);
                    falecido.NomeMae = form.txtMae.Text;
                    falecido.NomePai = form.txtPai.Text;
                    falecido.IdRequerente = Convert.ToInt32(form.numericRequerente.Value);
                    falecido.Idade = Convert.ToInt32(form.numericIdade.Value);
                    falecido.Sexo = form.cbSexo.Text;
                    falecido.EstadoCivil = form.cbEstadoCivil.Text;
                    falecido.DataObito = Convert.ToDateTime(form.dateObito.Text);
                    db.Falecidos.Add(falecido);
                    db.SaveChanges();
                    AtualizarFalecidos(db);
                    MessageBox.Show("Falecido Adicionado com Sucesso");


                }
            }
        }



        private void AtualizarFalecidos(CemidexContext db)
        {
            if (cbRequerente.Items.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                int idRequerente = (cbRequerente.SelectedItem as Requerente).IdRequerente;
     
                List<Falecido> lengths = db.Falecidos.Where(x => x.IdRequerente == idRequerente).ToList();
                int tam = lengths.Count();

                dgvFalecidos.DataSource = lengths;

                this.Cursor = Cursors.Default;
            }
        }

        private void cbRequerente_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new CemidexContext())
            {
                AtualizarFalecidos(db);
            }
        }

        private void btFalEd_Click(object sender, EventArgs e)
        {
            if (dgvFalecidos.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = null;
                linha = dgvFalecidos.SelectedRows[0];
                Falecido falecido = linha.DataBoundItem as Falecido;

                using (var form = new FrmFalecido())
                {
                    form.Text = "Alteração";
                    form.txtNome.Text = falecido.Nome;
                    form.textCpf.Text = falecido.Cpf;
                    form.numericCova.Value = falecido.IdCova;
                    form.txtMae.Text = falecido.NomeMae;
                    form.txtPai.Text = falecido.NomePai;
                    form.numericRequerente.Value = falecido.IdRequerente;
                    form.numericIdade.Value = falecido.Idade;
                    form.cbSexo.Text = falecido.Sexo;
                    form.cbEstadoCivil.Text = falecido.EstadoCivil;
                    form.dateObito.Value = falecido.DataObito;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new CemidexContext())
                        {
                            falecido.Nome = form.txtNome.Text;
                            falecido.Cpf = form.textCpf.Text;
                            falecido.IdCova = Convert.ToInt32(form.numericCova.Text);
                            falecido.NomeMae = form.txtMae.Text;
                            falecido.NomePai = form.txtPai.Text;
                            falecido.IdRequerente = Convert.ToInt32(form.numericRequerente.Value);
                            falecido.Idade = Convert.ToInt32(form.numericIdade.Value);
                            falecido.Sexo = form.cbSexo.Text;
                            falecido.EstadoCivil = form.cbEstadoCivil.Text;
                            falecido.DataObito = Convert.ToDateTime(form.dateObito.Text);
                            db.Falecidos.Attach(falecido);
                            db.Entry(falecido).State = EntityState.Modified;
                            db.SaveChanges();
                            AtualizarFalecidos(db);
                            MessageBox.Show("Falecido Alterado");
                        }
                    }
                }
            }
        }

        private void btFalRem_Click(object sender, EventArgs e)
        {
            if(dgvFalecidos.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = null;
                linha = dgvFalecidos.SelectedRows[0];
                Falecido falecido = linha.DataBoundItem as Falecido;

                if (MessageBox.Show("Confirma a exclusão de Falecido",
                    "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new CemidexContext())
                    {
                        db.Falecidos.Attach(falecido);
                        db.Entry(falecido).State= EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarFalecidos(db);
                        MessageBox.Show("Falecido Excluído");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
