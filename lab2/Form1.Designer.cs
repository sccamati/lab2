﻿
namespace lab2
{
    partial class NBox
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ObliczButton = new System.Windows.Forms.Button();
            this.ABox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.DBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BitCountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TableView = new System.Windows.Forms.DataGridView();
            this.pkBox = new System.Windows.Forms.TextBox();
            this.pmBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.individualBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.individualBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xbit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildXbin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ppk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newXreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // ObliczButton
            // 
            this.ObliczButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ObliczButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObliczButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ObliczButton.Location = new System.Drawing.Point(526, 42);
            this.ObliczButton.Name = "ObliczButton";
            this.ObliczButton.Size = new System.Drawing.Size(75, 23);
            this.ObliczButton.TabIndex = 0;
            this.ObliczButton.Text = "Oblicz";
            this.ObliczButton.UseVisualStyleBackColor = false;
            this.ObliczButton.Click += new System.EventHandler(this.ObliczButton_Click);
            // 
            // ABox
            // 
            this.ABox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ABox.Location = new System.Drawing.Point(162, 41);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(21, 20);
            this.ABox.TabIndex = 1;
            this.ABox.Text = "1";
            this.ABox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABox_KeyPress);
            // 
            // BBox
            // 
            this.BBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBox.Location = new System.Drawing.Point(189, 41);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(24, 20);
            this.BBox.TabIndex = 2;
            this.BBox.Text = "5";
            this.BBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BBox_KeyPress);
            // 
            // CountBox
            // 
            this.CountBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountBox.Location = new System.Drawing.Point(267, 42);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 20);
            this.CountBox.TabIndex = 3;
            this.CountBox.Text = "10";
            this.CountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountBox_KeyPress);
            // 
            // DBox
            // 
            this.DBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DBox.ForeColor = System.Drawing.Color.Black;
            this.DBox.Location = new System.Drawing.Point(404, 42);
            this.DBox.Name = "DBox";
            this.DBox.Size = new System.Drawing.Size(100, 20);
            this.DBox.TabIndex = 4;
            this.DBox.Text = "10";
            this.DBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(141, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "[";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(219, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(258, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ilość osobników";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(412, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "dokładność";
            // 
            // BitCountBox
            // 
            this.BitCountBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BitCountBox.Location = new System.Drawing.Point(691, 45);
            this.BitCountBox.Name = "BitCountBox";
            this.BitCountBox.ReadOnly = true;
            this.BitCountBox.Size = new System.Drawing.Size(60, 20);
            this.BitCountBox.TabIndex = 10;
            this.BitCountBox.TextChanged += new System.EventHandler(this.BitCountBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(679, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "liczba bitów";
            // 
            // TableView
            // 
            this.TableView.AllowUserToAddRows = false;
            this.TableView.AllowUserToDeleteRows = false;
            this.TableView.AutoGenerateColumns = false;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Xreal,
            this.Xbit,
            this.Parent,
            this.Pc,
            this.ChildXbin,
            this.Ppk,
            this.Zg,
            this.Pm,
            this.newXreal,
            this.newFx});
            this.TableView.DataSource = this.individualBindingSource7;
            this.TableView.Location = new System.Drawing.Point(12, 113);
            this.TableView.Name = "TableView";
            this.TableView.ReadOnly = true;
            this.TableView.Size = new System.Drawing.Size(1246, 386);
            this.TableView.TabIndex = 12;
            // 
            // pkBox
            // 
            this.pkBox.Location = new System.Drawing.Point(145, 87);
            this.pkBox.Name = "pkBox";
            this.pkBox.Size = new System.Drawing.Size(100, 20);
            this.pkBox.TabIndex = 13;
            // 
            // pmBox
            // 
            this.pmBox.Location = new System.Drawing.Point(311, 87);
            this.pmBox.Name = "pmBox";
            this.pmBox.Size = new System.Drawing.Size(100, 20);
            this.pmBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(109, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "prawdopodobieństwo kryżowania";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(279, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "prawdopodobieństwo mutacji";
            // 
            // individualBindingSource7
            // 
            this.individualBindingSource7.DataSource = typeof(lab2.classes.Individual);
            // 
            // individualBindingSource5
            // 
            this.individualBindingSource5.DataSource = typeof(lab2.classes.Individual);
            // 
            // individualBindingSource4
            // 
            this.individualBindingSource4.DataSource = typeof(lab2.classes.Individual);
            // 
            // individualBindingSource2
            // 
            this.individualBindingSource2.DataSource = typeof(lab2.classes.Individual);
            // 
            // individualBindingSource
            // 
            this.individualBindingSource.DataSource = typeof(lab2.classes.Individual);
            // 
            // individualBindingSource1
            // 
            this.individualBindingSource1.DataSource = typeof(lab2.classes.Individual);
            // 
            // individualBindingSource3
            // 
            this.individualBindingSource3.DataSource = typeof(lab2.classes.Individual);
            // 
            // individualBindingSource6
            // 
            this.individualBindingSource6.DataSource = typeof(lab2.classes.Individual);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Xreal
            // 
            this.Xreal.DataPropertyName = "Xreal";
            this.Xreal.HeaderText = "Xreal";
            this.Xreal.Name = "Xreal";
            this.Xreal.ReadOnly = true;
            // 
            // Xbit
            // 
            this.Xbit.DataPropertyName = "Xbit";
            this.Xbit.HeaderText = "Xbit";
            this.Xbit.Name = "Xbit";
            this.Xbit.ReadOnly = true;
            // 
            // Parent
            // 
            this.Parent.DataPropertyName = "Parent";
            this.Parent.HeaderText = "Parent";
            this.Parent.Name = "Parent";
            this.Parent.ReadOnly = true;
            // 
            // Pc
            // 
            this.Pc.DataPropertyName = "Pc";
            this.Pc.HeaderText = "Pc";
            this.Pc.Name = "Pc";
            this.Pc.ReadOnly = true;
            // 
            // ChildXbin
            // 
            this.ChildXbin.DataPropertyName = "ChildXbin";
            this.ChildXbin.HeaderText = "ChildXbin";
            this.ChildXbin.Name = "ChildXbin";
            this.ChildXbin.ReadOnly = true;
            // 
            // Ppk
            // 
            this.Ppk.DataPropertyName = "Ppk";
            this.Ppk.HeaderText = "Ppk";
            this.Ppk.Name = "Ppk";
            this.Ppk.ReadOnly = true;
            // 
            // Zg
            // 
            this.Zg.DataPropertyName = "Zg";
            this.Zg.HeaderText = "Zg";
            this.Zg.Name = "Zg";
            this.Zg.ReadOnly = true;
            // 
            // Pm
            // 
            this.Pm.DataPropertyName = "Pm";
            this.Pm.HeaderText = "Pm";
            this.Pm.Name = "Pm";
            this.Pm.ReadOnly = true;
            // 
            // newXreal
            // 
            this.newXreal.DataPropertyName = "newXreal";
            this.newXreal.HeaderText = "newXreal";
            this.newXreal.Name = "newXreal";
            this.newXreal.ReadOnly = true;
            // 
            // newFx
            // 
            this.newFx.DataPropertyName = "newFx";
            this.newFx.HeaderText = "newFx";
            this.newFx.Name = "newFx";
            this.newFx.ReadOnly = true;
            // 
            // NBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1284, 519);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pmBox);
            this.Controls.Add(this.pkBox);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BitCountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBox);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.ObliczButton);
            this.Name = "NBox";
            this.Text = "Inteligentne Systemy Agentowe";
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ObliczButton;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.TextBox DBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource individualBindingSource;
        private System.Windows.Forms.BindingSource individualBindingSource1;
        private System.Windows.Forms.BindingSource individualBindingSource2;
        private System.Windows.Forms.BindingSource individualBindingSource3;
        private System.Windows.Forms.BindingSource individualBindingSource4;
        private System.Windows.Forms.TextBox BitCountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource individualBindingSource5;
        private System.Windows.Forms.BindingSource individualBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource individualBindingSource7;
        private System.Windows.Forms.DataGridView TableView;
        private System.Windows.Forms.TextBox pkBox;
        private System.Windows.Forms.TextBox pmBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xreal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xbit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildXbin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ppk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn newXreal;
        private System.Windows.Forms.DataGridViewTextBoxColumn newFx;
    }
}

