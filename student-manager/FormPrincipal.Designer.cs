﻿namespace student_manager
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eSTUDANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastratEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDANTEToolStripMenuItem,
            this.cURSOToolStripMenuItem,
            this.nOTAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eSTUDANTEToolStripMenuItem
            // 
            this.eSTUDANTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastratEstudanteToolStripMenuItem,
            this.listarEstudanteToolStripMenuItem,
            this.estatísticaToolStripMenuItem,
            this.editarRemoverToolStripMenuItem,
            this.gerenciarEstudanteToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.eSTUDANTEToolStripMenuItem.Name = "eSTUDANTEToolStripMenuItem";
            this.eSTUDANTEToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.eSTUDANTEToolStripMenuItem.Text = "ESTUDANTE";
            // 
            // cURSOToolStripMenuItem
            // 
            this.cURSOToolStripMenuItem.Name = "cURSOToolStripMenuItem";
            this.cURSOToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cURSOToolStripMenuItem.Text = "CURSO";
            // 
            // nOTAToolStripMenuItem
            // 
            this.nOTAToolStripMenuItem.Name = "nOTAToolStripMenuItem";
            this.nOTAToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.nOTAToolStripMenuItem.Text = "NOTA";
            // 
            // cadastratEstudanteToolStripMenuItem
            // 
            this.cadastratEstudanteToolStripMenuItem.Name = "cadastratEstudanteToolStripMenuItem";
            this.cadastratEstudanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastratEstudanteToolStripMenuItem.Text = "Cadastrat Estudante";
            this.cadastratEstudanteToolStripMenuItem.Click += new System.EventHandler(this.cadastratEstudanteToolStripMenuItem_Click);
            // 
            // listarEstudanteToolStripMenuItem
            // 
            this.listarEstudanteToolStripMenuItem.Name = "listarEstudanteToolStripMenuItem";
            this.listarEstudanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarEstudanteToolStripMenuItem.Text = "Listar Estudante";
            // 
            // estatísticaToolStripMenuItem
            // 
            this.estatísticaToolStripMenuItem.Name = "estatísticaToolStripMenuItem";
            this.estatísticaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estatísticaToolStripMenuItem.Text = "Estatística";
            // 
            // editarRemoverToolStripMenuItem
            // 
            this.editarRemoverToolStripMenuItem.Name = "editarRemoverToolStripMenuItem";
            this.editarRemoverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarRemoverToolStripMenuItem.Text = "Editar/Remover";
            // 
            // gerenciarEstudanteToolStripMenuItem
            // 
            this.gerenciarEstudanteToolStripMenuItem.Name = "gerenciarEstudanteToolStripMenuItem";
            this.gerenciarEstudanteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gerenciarEstudanteToolStripMenuItem.Text = "Gerenciar Estudantes";
            this.gerenciarEstudanteToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEstudanteToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eSTUDANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastratEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}