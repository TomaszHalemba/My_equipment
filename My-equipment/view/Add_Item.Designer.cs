
namespace My_equipment.view
{
    partial class Add_Item
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
            this.item_name_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.rating_textbox = new System.Windows.Forms.TextBox();
            this.company_name_textbox = new System.Windows.Forms.TextBox();
            this.add_item_button = new System.Windows.Forms.Button();
            this.dateTime_bought_picker = new System.Windows.Forms.DateTimePicker();
            this.dateTime_retired_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bought_date_checkbox = new System.Windows.Forms.CheckBox();
            this.retired_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // item_name_textbox
            // 
            this.item_name_textbox.Location = new System.Drawing.Point(114, 15);
            this.item_name_textbox.Name = "item_name_textbox";
            this.item_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.item_name_textbox.TabIndex = 0;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(114, 95);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(100, 20);
            this.price_textbox.TabIndex = 3;
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(114, 174);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(200, 96);
            this.description_textbox.TabIndex = 6;
            // 
            // rating_textbox
            // 
            this.rating_textbox.Location = new System.Drawing.Point(114, 148);
            this.rating_textbox.Name = "rating_textbox";
            this.rating_textbox.Size = new System.Drawing.Size(100, 20);
            this.rating_textbox.TabIndex = 5;
            // 
            // company_name_textbox
            // 
            this.company_name_textbox.Location = new System.Drawing.Point(114, 121);
            this.company_name_textbox.Name = "company_name_textbox";
            this.company_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.company_name_textbox.TabIndex = 4;
            // 
            // add_item_button
            // 
            this.add_item_button.Location = new System.Drawing.Point(114, 276);
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.Size = new System.Drawing.Size(100, 39);
            this.add_item_button.TabIndex = 7;
            this.add_item_button.Text = "Add item";
            this.add_item_button.UseVisualStyleBackColor = true;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // dateTime_bought_picker
            // 
            this.dateTime_bought_picker.Location = new System.Drawing.Point(114, 42);
            this.dateTime_bought_picker.Name = "dateTime_bought_picker";
            this.dateTime_bought_picker.Size = new System.Drawing.Size(200, 20);
            this.dateTime_bought_picker.TabIndex = 8;
            // 
            // dateTime_retired_picker
            // 
            this.dateTime_retired_picker.Location = new System.Drawing.Point(114, 68);
            this.dateTime_retired_picker.Name = "dateTime_retired_picker";
            this.dateTime_retired_picker.Size = new System.Drawing.Size(200, 20);
            this.dateTime_retired_picker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bought date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item retired";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rating";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Company name";
            // 
            // bought_date_checkbox
            // 
            this.bought_date_checkbox.AutoSize = true;
            this.bought_date_checkbox.Checked = true;
            this.bought_date_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bought_date_checkbox.Location = new System.Drawing.Point(320, 44);
            this.bought_date_checkbox.Name = "bought_date_checkbox";
            this.bought_date_checkbox.Size = new System.Drawing.Size(92, 19);
            this.bought_date_checkbox.TabIndex = 17;
            this.bought_date_checkbox.Text = "Dont specify";
            this.bought_date_checkbox.UseVisualStyleBackColor = true;
            // 
            // retired_checkbox
            // 
            this.retired_checkbox.AutoSize = true;
            this.retired_checkbox.Checked = true;
            this.retired_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.retired_checkbox.Location = new System.Drawing.Point(320, 69);
            this.retired_checkbox.Name = "retired_checkbox";
            this.retired_checkbox.Size = new System.Drawing.Size(92, 19);
            this.retired_checkbox.TabIndex = 18;
            this.retired_checkbox.Text = "Dont specify";
            this.retired_checkbox.UseVisualStyleBackColor = true;
            // 
            // Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retired_checkbox);
            this.Controls.Add(this.bought_date_checkbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_retired_picker);
            this.Controls.Add(this.dateTime_bought_picker);
            this.Controls.Add(this.add_item_button);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.rating_textbox);
            this.Controls.Add(this.company_name_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.item_name_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Item";
            this.Text = "Add_Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item_name_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.TextBox rating_textbox;
        private System.Windows.Forms.TextBox company_name_textbox;
        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.DateTimePicker dateTime_bought_picker;
        private System.Windows.Forms.DateTimePicker dateTime_retired_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox bought_date_checkbox;
        private System.Windows.Forms.CheckBox retired_checkbox;
    }
}