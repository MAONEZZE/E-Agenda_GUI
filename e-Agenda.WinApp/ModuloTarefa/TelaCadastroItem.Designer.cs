﻿namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItem
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
            txb_titulo = new TextBox();
            label2 = new Label();
            txb_id = new TextBox();
            label1 = new Label();
            btn_cancel = new Button();
            btn_gravar = new Button();
            listBox_itens = new ListBox();
            label3 = new Label();
            txb_descricao = new TextBox();
            btn_adicionar = new Button();
            SuspendLayout();
            // 
            // txb_titulo
            // 
            txb_titulo.Location = new Point(57, 52);
            txb_titulo.Name = "txb_titulo";
            txb_titulo.ReadOnly = true;
            txb_titulo.Size = new Size(269, 23);
            txb_titulo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 55);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Titulo:";
            // 
            // txb_id
            // 
            txb_id.Enabled = false;
            txb_id.Location = new Point(57, 12);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(68, 23);
            txb_id.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Location = new Point(251, 283);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Location = new Point(170, 283);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(75, 23);
            btn_gravar.TabIndex = 10;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // listBox_itens
            // 
            listBox_itens.FormattingEnabled = true;
            listBox_itens.ItemHeight = 15;
            listBox_itens.Location = new Point(12, 136);
            listBox_itens.Name = "listBox_itens";
            listBox_itens.Size = new Size(314, 124);
            listBox_itens.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 13;
            label3.Text = "Descrição*:";
            // 
            // txb_descricao
            // 
            txb_descricao.Location = new Point(83, 92);
            txb_descricao.Name = "txb_descricao";
            txb_descricao.Size = new Size(162, 23);
            txb_descricao.TabIndex = 14;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(251, 92);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(75, 23);
            btn_adicionar.TabIndex = 15;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // TelaCadastroItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 318);
            Controls.Add(btn_adicionar);
            Controls.Add(txb_descricao);
            Controls.Add(label3);
            Controls.Add(listBox_itens);
            Controls.Add(btn_cancel);
            Controls.Add(btn_gravar);
            Controls.Add(txb_titulo);
            Controls.Add(label2);
            Controls.Add(txb_id);
            Controls.Add(label1);
            Name = "TelaCadastroItem";
            Text = "TelaCadastroItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_titulo;
        private Label label2;
        private TextBox txb_id;
        private Label label1;
        private Button btn_cancel;
        private Button btn_gravar;
        private ListBox listBox_itens;
        private Label label3;
        private TextBox txb_descricao;
        private Button btn_adicionar;
    }
}