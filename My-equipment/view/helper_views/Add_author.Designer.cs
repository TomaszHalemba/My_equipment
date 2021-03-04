
namespace My_equipment.view
{
    partial class Add_author
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_author));
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.add_item_button = new System.Windows.Forms.Button();
            this.dateTime_birth_picker = new System.Windows.Forms.DateTimePicker();
            this.first_name_label = new System.Windows.Forms.Label();
            this.birth_date_label = new System.Windows.Forms.Label();
            this.birth_date_checkbox = new System.Windows.Forms.CheckBox();
            this.modify_button = new System.Windows.Forms.Button();
            this.last_name_label = new System.Windows.Forms.Label();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // first_name_textbox
            // 
            resources.ApplyResources(this.first_name_textbox, "first_name_textbox");
            this.first_name_textbox.Name = "first_name_textbox";
            // 
            // add_item_button
            // 
            resources.ApplyResources(this.add_item_button, "add_item_button");
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.UseVisualStyleBackColor = true;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // dateTime_birth_picker
            // 
            resources.ApplyResources(this.dateTime_birth_picker, "dateTime_birth_picker");
            this.dateTime_birth_picker.Name = "dateTime_birth_picker";
            // 
            // first_name_label
            // 
            resources.ApplyResources(this.first_name_label, "first_name_label");
            this.first_name_label.Name = "first_name_label";
            // 
            // birth_date_label
            // 
            resources.ApplyResources(this.birth_date_label, "birth_date_label");
            this.birth_date_label.Name = "birth_date_label";
            // 
            // birth_date_checkbox
            // 
            resources.ApplyResources(this.birth_date_checkbox, "birth_date_checkbox");
            this.birth_date_checkbox.Checked = true;
            this.birth_date_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.birth_date_checkbox.Name = "birth_date_checkbox";
            this.birth_date_checkbox.UseVisualStyleBackColor = true;
            // 
            // modify_button
            // 
            resources.ApplyResources(this.modify_button, "modify_button");
            this.modify_button.Name = "modify_button";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // last_name_label
            // 
            resources.ApplyResources(this.last_name_label, "last_name_label");
            this.last_name_label.Name = "last_name_label";
            // 
            // last_name_textbox
            // 
            resources.ApplyResources(this.last_name_textbox, "last_name_textbox");
            this.last_name_textbox.Name = "last_name_textbox";
            // 
            // Add_author
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.last_name_textbox);
            this.Controls.Add(this.birth_date_checkbox);
            this.Controls.Add(this.birth_date_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.dateTime_birth_picker);
            this.Controls.Add(this.first_name_textbox);
            this.Controls.Add(this.add_item_button);
            this.Controls.Add(this.modify_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.DateTimePicker dateTime_birth_picker;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label birth_date_label;
        private System.Windows.Forms.CheckBox birth_date_checkbox;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox last_name_textbox;
    }
}