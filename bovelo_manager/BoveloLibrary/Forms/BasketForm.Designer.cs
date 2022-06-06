﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bovelo
{
    partial class BasketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketForm));
            this.validate_btn = new System.Windows.Forms.Button();
            this.bike_list_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.empty_cart_btn = new System.Windows.Forms.Button();
            this.delivery_name = new System.Windows.Forms.Label();
            this.delivery_time_label = new System.Windows.Forms.Label();
            this.new_Client = new System.Windows.Forms.Button();
            this.select_Client = new System.Windows.Forms.Button();
            this.label_selectedClient = new System.Windows.Forms.Label();
            this.label_clientName = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deliveryTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // validate_btn
            // 
            this.validate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validate_btn.Location = new System.Drawing.Point(920, 538);
            this.validate_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.validate_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.validate_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(158, 35);
            this.validate_btn.TabIndex = 14;
            this.validate_btn.Text = "Confirm";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // bike_list_label
            // 
            this.bike_list_label.AutoSize = true;
            this.bike_list_label.Location = new System.Drawing.Point(20, 20);
            this.bike_list_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bike_list_label.Name = "bike_list_label";
            this.bike_list_label.Size = new System.Drawing.Size(0, 20);
            this.bike_list_label.TabIndex = 15;
            // 
            // back_btn
            // 
            this.back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_btn.Location = new System.Drawing.Point(752, 538);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.back_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(158, 35);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // empty_cart_btn
            // 
            this.empty_cart_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empty_cart_btn.Location = new System.Drawing.Point(24, 538);
            this.empty_cart_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.empty_cart_btn.MaximumSize = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.MinimumSize = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.Name = "empty_cart_btn";
            this.empty_cart_btn.Size = new System.Drawing.Size(158, 35);
            this.empty_cart_btn.TabIndex = 17;
            this.empty_cart_btn.Text = "Empty Cart";
            this.empty_cart_btn.UseVisualStyleBackColor = true;
            this.empty_cart_btn.Click += new System.EventHandler(this.empty_cart_btn_Click);
            // 
            // delivery_name
            // 
            this.delivery_name.AutoSize = true;
            this.delivery_name.Location = new System.Drawing.Point(24, 480);
            this.delivery_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delivery_name.Name = "delivery_name";
            this.delivery_name.Size = new System.Drawing.Size(144, 20);
            this.delivery_name.TabIndex = 18;
            this.delivery_name.Text = "Estimated Delivery:";
            // 
            // delivery_time_label
            // 
            this.delivery_time_label.AutoSize = true;
            this.delivery_time_label.Location = new System.Drawing.Point(214, 480);
            this.delivery_time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delivery_time_label.Name = "delivery_time_label";
            this.delivery_time_label.Size = new System.Drawing.Size(0, 20);
            this.delivery_time_label.TabIndex = 19;
            // 
            // new_Client
            // 
            this.new_Client.Location = new System.Drawing.Point(752, 440);
            this.new_Client.Name = "new_Client";
            this.new_Client.Size = new System.Drawing.Size(158, 38);
            this.new_Client.TabIndex = 20;
            this.new_Client.Text = "New Client";
            this.new_Client.UseVisualStyleBackColor = true;
            this.new_Client.Click += new System.EventHandler(this.new_Client_Click);
            // 
            // select_Client
            // 
            this.select_Client.Location = new System.Drawing.Point(920, 440);
            this.select_Client.Name = "select_Client";
            this.select_Client.Size = new System.Drawing.Size(158, 38);
            this.select_Client.TabIndex = 21;
            this.select_Client.Text = "Select Client";
            this.select_Client.UseVisualStyleBackColor = true;
            this.select_Client.Click += new System.EventHandler(this.select_Client_Click);
            // 
            // label_selectedClient
            // 
            this.label_selectedClient.AutoSize = true;
            this.label_selectedClient.Location = new System.Drawing.Point(24, 440);
            this.label_selectedClient.Name = "label_selectedClient";
            this.label_selectedClient.Size = new System.Drawing.Size(53, 20);
            this.label_selectedClient.TabIndex = 22;
            this.label_selectedClient.Text = "Client:";
            // 
            // label_clientName
            // 
            this.label_clientName.AutoSize = true;
            this.label_clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clientName.Location = new System.Drawing.Point(182, 440);
            this.label_clientName.Name = "label_clientName";
            this.label_clientName.Size = new System.Drawing.Size(0, 20);
            this.label_clientName.TabIndex = 23;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(16, 400);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(175, 20);
            this.label_price.TabIndex = 24;
            this.label_price.Text = " TT (excluding VAT): ";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(197, 400);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(57, 20);
            this.price.TabIndex = 25;
            this.price.Text = "label1";
            // 
            // Statuslabel
            // 
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(0, 25);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(112, 25);
            this.StatusLabel1.Text = "Basket ready";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Statuslabel,
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1108, 32);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(28, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 295);
            this.panel1.TabIndex = 27;
            // 
            // deliveryTime
            // 
            this.deliveryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTime.Location = new System.Drawing.Point(176, 480);
            this.deliveryTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deliveryTime.Name = "deliveryTime";
            this.deliveryTime.Size = new System.Drawing.Size(288, 20);
            this.deliveryTime.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "   Product:     Color:        Size:       Quantity:                              " +
    "   PPU:";
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_clientName);
            this.Controls.Add(this.label_selectedClient);
            this.Controls.Add(this.select_Client);
            this.Controls.Add(this.new_Client);
            this.Controls.Add(this.delivery_time_label);
            this.Controls.Add(this.delivery_name);
            this.Controls.Add(this.empty_cart_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.bike_list_label);
            this.Controls.Add(this.validate_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1130, 681);
            this.MinimumSize = new System.Drawing.Size(1130, 681);
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button validate_btn;
        private System.Windows.Forms.Label bike_list_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button empty_cart_btn;
        private System.Windows.Forms.Label delivery_name;
        private System.Windows.Forms.Label delivery_time_label;
        private System.Windows.Forms.Button new_Client;
        private System.Windows.Forms.Button select_Client;
        private System.Windows.Forms.Label label_selectedClient;
        private System.Windows.Forms.Label label_clientName;
        private Label label_price;
        private Label price;
        private ToolStripStatusLabel Statuslabel;
        private ToolStripStatusLabel StatusLabel1;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private Label deliveryTime;
        private Label label1;
    }
}