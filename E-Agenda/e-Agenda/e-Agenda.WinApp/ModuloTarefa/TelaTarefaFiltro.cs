﻿namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaFiltro : Form
    {
        public TelaTarefaFiltro()
        {
            InitializeComponent();

            txb_dataFim.Enabled = false;
            txb_dataInicio.Enabled = false;

            this.ConfigurarTelas();
        }

        private void rdb_pendentes_CheckedChanged(object sender, EventArgs e)
        {
            txb_dataFim.Enabled = false;
            txb_dataInicio.Enabled = false;
        }

        private void rdb_concluidos_CheckedChanged(object sender, EventArgs e)
        {
            txb_dataFim.Enabled = false;
            txb_dataInicio.Enabled = false;
        }

        private void rdb_dataCriacao_CheckedChanged(object sender, EventArgs e)
        {
            txb_dataFim.Enabled = true;
            txb_dataInicio.Enabled = true;
        }

        public ControladorTarefa.TipoOpcaoFiltragem OpcaoEscolhida()
        {
            if (rdb_concluidos.Checked)
            {
                return ControladorTarefa.TipoOpcaoFiltragem.Concluidas;
            }
            else if (rdb_dataCriacao.Checked)
            {
                return ControladorTarefa.TipoOpcaoFiltragem.DataCriacao;
            }
            else if (rdb_pendentes.Checked)
            {
                return ControladorTarefa.TipoOpcaoFiltragem.Pendentes;
            }
            else
            {
                return ControladorTarefa.TipoOpcaoFiltragem.Todas;
            }
        }
    }
}
