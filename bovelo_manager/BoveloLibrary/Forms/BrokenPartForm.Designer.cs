﻿
namespace Bovelo
{
    partial class BrokenPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrokenPart));
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validation_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedPart_label = new System.Windows.Forms.Label();
            this.stock_dataGridView = new System.Windows.Forms.DataGridView();
            this.information_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stock_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(131, 37);
            this.search_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(144, 26);
            this.search_textbox.TabIndex = 1;
            this.search_textbox.Text = "Search Reference";
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Part:";
            // 
            // validation_button
            // 
            this.validation_button.AutoSize = true;
            this.validation_button.Location = new System.Drawing.Point(533, 421);
            this.validation_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.validation_button.Name = "validation_button";
            this.validation_button.Size = new System.Drawing.Size(84, 34);
            this.validation_button.TabIndex = 4;
            this.validation_button.Text = "Report";
            this.validation_button.UseVisualStyleBackColor = true;
            this.validation_button.Click += new System.EventHandler(this.validation_button_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(131, 421);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedPart_label
            // 
            this.selectedPart_label.AutoSize = true;
            this.selectedPart_label.Location = new System.Drawing.Point(247, 337);
            this.selectedPart_label.Name = "selectedPart_label";
            this.selectedPart_label.Size = new System.Drawing.Size(51, 20);
            this.selectedPart_label.TabIndex = 6;
            this.selectedPart_label.Text = "label3";
            this.selectedPart_label.Visible = false;
            // 
            // stock_dataGridView
            // 
            this.stock_dataGridView.AllowUserToAddRows = false;
            this.stock_dataGridView.AllowUserToDeleteRows = false;
            this.stock_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_dataGridView.Location = new System.Drawing.Point(131, 71);
            this.stock_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stock_dataGridView.MultiSelect = false;
            this.stock_dataGridView.Name = "stock_dataGridView";
            this.stock_dataGridView.ReadOnly = true;
            this.stock_dataGridView.RowHeadersVisible = false;
            this.stock_dataGridView.RowHeadersWidth = 51;
            this.stock_dataGridView.RowTemplate.Height = 24;
            this.stock_dataGridView.RowTemplate.ReadOnly = true;
            this.stock_dataGridView.Size = new System.Drawing.Size(486, 262);
            this.stock_dataGridView.TabIndex = 7;
            this.stock_dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stock_dataGridView_CellMouseClick);
            // 
            // information_label
            // 
            this.information_label.AutoSize = true;
            this.information_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_label.Location = new System.Drawing.Point(128, 379);
            this.information_label.Name = "information_label";
            this.information_label.Size = new System.Drawing.Size(57, 20);
            this.information_label.TabIndex = 8;
            this.information_label.Text = "label4";
            this.information_label.Visible = false;
            // 
            // BrokenPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 521);
            this.Controls.Add(this.information_label);
            this.Controls.Add(this.stock_dataGridView);
            this.Controls.Add(this.selectedPart_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.validation_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(789, 577);
            this.MinimumSize = new System.Drawing.Size(789, 577);
            this.Name = "BrokenPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broken Part";
            ((System.ComponentModel.ISupportInitialize)(this.stock_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validation_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label selectedPart_label;
        private System.Windows.Forms.DataGridView stock_dataGridView;
        private System.Windows.Forms.Label information_label;
    }
}