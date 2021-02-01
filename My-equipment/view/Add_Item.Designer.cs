
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Item));
            this.item_name_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.rating_textbox = new System.Windows.Forms.TextBox();
            this.company_name_textbox = new System.Windows.Forms.TextBox();
            this.add_item_button = new System.Windows.Forms.Button();
            this.dateTime_bought_picker = new System.Windows.Forms.DateTimePicker();
            this.dateTime_retired_picker = new System.Windows.Forms.DateTimePicker();
            this.item_name_label = new System.Windows.Forms.Label();
            this.bought_date_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.item_retired_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.company_name_label = new System.Windows.Forms.Label();
            this.bought_date_checkbox = new System.Windows.Forms.CheckBox();
            this.retired_checkbox = new System.Windows.Forms.CheckBox();
            this.modify_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item_name_textbox
            // 
            resources.ApplyResources(this.item_name_textbox, "item_name_textbox");
            this.item_name_textbox.Name = "item_name_textbox";
            // 
            // price_textbox
            // 
            resources.ApplyResources(this.price_textbox, "price_textbox");
            this.price_textbox.Name = "price_textbox";
            // 
            // description_textbox
            // 
            resources.ApplyResources(this.description_textbox, "description_textbox");
            this.description_textbox.Name = "description_textbox";
            // 
            // rating_textbox
            // 
            resources.ApplyResources(this.rating_textbox, "rating_textbox");
            this.rating_textbox.Name = "rating_textbox";
            // 
            // company_name_textbox
            // 
            resources.ApplyResources(this.company_name_textbox, "company_name_textbox");
            this.company_name_textbox.Name = "company_name_textbox";
            // 
            // add_item_button
            // 
            resources.ApplyResources(this.add_item_button, "add_item_button");
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.UseVisualStyleBackColor = true;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // dateTime_bought_picker
            // 
            resources.ApplyResources(this.dateTime_bought_picker, "dateTime_bought_picker");
            this.dateTime_bought_picker.Name = "dateTime_bought_picker";
            // 
            // dateTime_retired_picker
            // 
            resources.ApplyResources(this.dateTime_retired_picker, "dateTime_retired_picker");
            this.dateTime_retired_picker.Name = "dateTime_retired_picker";
            // 
            // item_name_label
            // 
            resources.ApplyResources(this.item_name_label, "item_name_label");
            this.item_name_label.Name = "item_name_label";
            // 
            // bought_date_label
            // 
            resources.ApplyResources(this.bought_date_label, "bought_date_label");
            this.bought_date_label.Name = "bought_date_label";
            // 
            // price_label
            // 
            resources.ApplyResources(this.price_label, "price_label");
            this.price_label.Name = "price_label";
            // 
            // item_retired_label
            // 
            resources.ApplyResources(this.item_retired_label, "item_retired_label");
            this.item_retired_label.Name = "item_retired_label";
            // 
            // description_label
            // 
            resources.ApplyResources(this.description_label, "description_label");
            this.description_label.Name = "description_label";
            // 
            // rating_label
            // 
            resources.ApplyResources(this.rating_label, "rating_label");
            this.rating_label.Name = "rating_label";
            // 
            // company_name_label
            // 
            resources.ApplyResources(this.company_name_label, "company_name_label");
            this.company_name_label.Name = "company_name_label";
            // 
            // bought_date_checkbox
            // 
            resources.ApplyResources(this.bought_date_checkbox, "bought_date_checkbox");
            this.bought_date_checkbox.Checked = true;
            this.bought_date_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bought_date_checkbox.Name = "bought_date_checkbox";
            this.bought_date_checkbox.UseVisualStyleBackColor = true;
            // 
            // retired_checkbox
            // 
            resources.ApplyResources(this.retired_checkbox, "retired_checkbox");
            this.retired_checkbox.Checked = true;
            this.retired_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.retired_checkbox.Name = "retired_checkbox";
            this.retired_checkbox.UseVisualStyleBackColor = true;
            // 
            // modify_button
            // 
            resources.ApplyResources(this.modify_button, "modify_button");
            this.modify_button.Name = "modify_button";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // Add_Item
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.retired_checkbox);
            this.Controls.Add(this.bought_date_checkbox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.company_name_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.item_retired_label);
            this.Controls.Add(this.bought_date_label);
            this.Controls.Add(this.item_name_label);
            this.Controls.Add(this.dateTime_retired_picker);
            this.Controls.Add(this.dateTime_bought_picker);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.rating_textbox);
            this.Controls.Add(this.company_name_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.item_name_textbox);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.add_item_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Item";
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
        private System.Windows.Forms.Label item_name_label;
        private System.Windows.Forms.Label bought_date_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label item_retired_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label company_name_label;
        private System.Windows.Forms.CheckBox bought_date_checkbox;
        private System.Windows.Forms.CheckBox retired_checkbox;
        private System.Windows.Forms.Button modify_button;
    }
}