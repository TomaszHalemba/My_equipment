
namespace My_equipment.view
{
    partial class Add_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_book));
            this.book_name_textbox = new System.Windows.Forms.TextBox();
            this.genre_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.publisher_textbox = new System.Windows.Forms.TextBox();
            this.add_item_button = new System.Windows.Forms.Button();
            this.borrow_date_picker = new System.Windows.Forms.DateTimePicker();
            this.returned_date_picker = new System.Windows.Forms.DateTimePicker();
            this.book_name_label = new System.Windows.Forms.Label();
            this.borrow_label = new System.Windows.Forms.Label();
            this.genre_label = new System.Windows.Forms.Label();
            this.return_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.publisher_name_label = new System.Windows.Forms.Label();
            this.borrow_date_checkbox = new System.Windows.Forms.CheckBox();
            this.return_date_checkbox = new System.Windows.Forms.CheckBox();
            this.modify_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rating_textbox = new System.Windows.Forms.TextBox();
            this.Authors_label = new System.Windows.Forms.Label();
            this.is_readed_checkbox = new System.Windows.Forms.CheckBox();
            this.current_author_list = new System.Windows.Forms.ListBox();
            this.add_author_button = new System.Windows.Forms.Button();
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.first_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.birth_date_picker = new System.Windows.Forms.DateTimePicker();
            this.birth_date_label = new System.Windows.Forms.Label();
            this.remove_author_button = new System.Windows.Forms.Button();
            this.author_combobox = new System.Windows.Forms.ComboBox();
            this.add_author_from_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // book_name_textbox
            // 
            resources.ApplyResources(this.book_name_textbox, "book_name_textbox");
            this.book_name_textbox.Name = "book_name_textbox";
            // 
            // genre_textbox
            // 
            resources.ApplyResources(this.genre_textbox, "genre_textbox");
            this.genre_textbox.Name = "genre_textbox";
            // 
            // description_textbox
            // 
            resources.ApplyResources(this.description_textbox, "description_textbox");
            this.description_textbox.Name = "description_textbox";
            // 
            // publisher_textbox
            // 
            resources.ApplyResources(this.publisher_textbox, "publisher_textbox");
            this.publisher_textbox.Name = "publisher_textbox";
            // 
            // add_item_button
            // 
            resources.ApplyResources(this.add_item_button, "add_item_button");
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.UseVisualStyleBackColor = true;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // borrow_date_picker
            // 
            resources.ApplyResources(this.borrow_date_picker, "borrow_date_picker");
            this.borrow_date_picker.Name = "borrow_date_picker";
            // 
            // returned_date_picker
            // 
            resources.ApplyResources(this.returned_date_picker, "returned_date_picker");
            this.returned_date_picker.Name = "returned_date_picker";
            // 
            // book_name_label
            // 
            resources.ApplyResources(this.book_name_label, "book_name_label");
            this.book_name_label.Name = "book_name_label";
            // 
            // borrow_label
            // 
            resources.ApplyResources(this.borrow_label, "borrow_label");
            this.borrow_label.Name = "borrow_label";
            // 
            // genre_label
            // 
            resources.ApplyResources(this.genre_label, "genre_label");
            this.genre_label.Name = "genre_label";
            this.genre_label.Tag = "genre_label";
            // 
            // return_label
            // 
            resources.ApplyResources(this.return_label, "return_label");
            this.return_label.Name = "return_label";
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
            // publisher_name_label
            // 
            resources.ApplyResources(this.publisher_name_label, "publisher_name_label");
            this.publisher_name_label.Name = "publisher_name_label";
            // 
            // borrow_date_checkbox
            // 
            resources.ApplyResources(this.borrow_date_checkbox, "borrow_date_checkbox");
            this.borrow_date_checkbox.Checked = true;
            this.borrow_date_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.borrow_date_checkbox.Name = "borrow_date_checkbox";
            this.borrow_date_checkbox.UseVisualStyleBackColor = true;
            // 
            // return_date_checkbox
            // 
            resources.ApplyResources(this.return_date_checkbox, "return_date_checkbox");
            this.return_date_checkbox.Checked = true;
            this.return_date_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.return_date_checkbox.Name = "return_date_checkbox";
            this.return_date_checkbox.UseVisualStyleBackColor = true;
            // 
            // modify_button
            // 
            resources.ApplyResources(this.modify_button, "modify_button");
            this.modify_button.Name = "modify_button";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // rating_textbox
            // 
            resources.ApplyResources(this.rating_textbox, "rating_textbox");
            this.rating_textbox.Name = "rating_textbox";
            // 
            // Authors_label
            // 
            resources.ApplyResources(this.Authors_label, "Authors_label");
            this.Authors_label.Name = "Authors_label";
            // 
            // is_readed_checkbox
            // 
            resources.ApplyResources(this.is_readed_checkbox, "is_readed_checkbox");
            this.is_readed_checkbox.Name = "is_readed_checkbox";
            this.is_readed_checkbox.UseVisualStyleBackColor = true;
            // 
            // current_author_list
            // 
            this.current_author_list.FormattingEnabled = true;
            resources.ApplyResources(this.current_author_list, "current_author_list");
            this.current_author_list.Name = "current_author_list";
            // 
            // add_author_button
            // 
            resources.ApplyResources(this.add_author_button, "add_author_button");
            this.add_author_button.Name = "add_author_button";
            this.add_author_button.UseVisualStyleBackColor = true;
            this.add_author_button.Click += new System.EventHandler(this.add_author_button_Click);
            // 
            // first_name_textbox
            // 
            resources.ApplyResources(this.first_name_textbox, "first_name_textbox");
            this.first_name_textbox.Name = "first_name_textbox";
            // 
            // first_name_label
            // 
            resources.ApplyResources(this.first_name_label, "first_name_label");
            this.first_name_label.Name = "first_name_label";
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
            // birth_date_picker
            // 
            resources.ApplyResources(this.birth_date_picker, "birth_date_picker");
            this.birth_date_picker.Name = "birth_date_picker";
            // 
            // birth_date_label
            // 
            resources.ApplyResources(this.birth_date_label, "birth_date_label");
            this.birth_date_label.Name = "birth_date_label";
            // 
            // remove_author_button
            // 
            resources.ApplyResources(this.remove_author_button, "remove_author_button");
            this.remove_author_button.Name = "remove_author_button";
            this.remove_author_button.UseVisualStyleBackColor = true;
            this.remove_author_button.Click += new System.EventHandler(this.remove_author_button_Click);
            // 
            // author_combobox
            // 
            this.author_combobox.FormattingEnabled = true;
            resources.ApplyResources(this.author_combobox, "author_combobox");
            this.author_combobox.Name = "author_combobox";
            // 
            // add_author_from_list
            // 
            resources.ApplyResources(this.add_author_from_list, "add_author_from_list");
            this.add_author_from_list.Name = "add_author_from_list";
            this.add_author_from_list.UseVisualStyleBackColor = true;
            this.add_author_from_list.Click += new System.EventHandler(this.add_author_from_list_Click);
            // 
            // Add_book
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add_author_from_list);
            this.Controls.Add(this.author_combobox);
            this.Controls.Add(this.remove_author_button);
            this.Controls.Add(this.birth_date_label);
            this.Controls.Add(this.birth_date_picker);
            this.Controls.Add(this.last_name_textbox);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.first_name_textbox);
            this.Controls.Add(this.add_author_button);
            this.Controls.Add(this.current_author_list);
            this.Controls.Add(this.is_readed_checkbox);
            this.Controls.Add(this.Authors_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rating_textbox);
            this.Controls.Add(this.return_date_checkbox);
            this.Controls.Add(this.borrow_date_checkbox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.publisher_name_label);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.return_label);
            this.Controls.Add(this.borrow_label);
            this.Controls.Add(this.book_name_label);
            this.Controls.Add(this.returned_date_picker);
            this.Controls.Add(this.borrow_date_picker);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.publisher_textbox);
            this.Controls.Add(this.genre_textbox);
            this.Controls.Add(this.book_name_textbox);
            this.Controls.Add(this.add_item_button);
            this.Controls.Add(this.modify_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox book_name_textbox;
        private System.Windows.Forms.TextBox genre_textbox;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.TextBox publisher_textbox;
        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.DateTimePicker returned_date_picker;
        private System.Windows.Forms.Label book_name_label;
        private System.Windows.Forms.Label borrow_label;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label return_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label publisher_name_label;
        private System.Windows.Forms.CheckBox borrow_date_checkbox;
        private System.Windows.Forms.CheckBox return_date_checkbox;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rating_textbox;
        private System.Windows.Forms.Label Authors_label;
        private System.Windows.Forms.DateTimePicker borrow_date_picker;
        private System.Windows.Forms.CheckBox is_readed_checkbox;
        private System.Windows.Forms.ListBox current_author_list;
        private System.Windows.Forms.Button add_author_button;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.DateTimePicker birth_date_picker;
        private System.Windows.Forms.Label birth_date_label;
        private System.Windows.Forms.Button remove_author_button;
        private System.Windows.Forms.ComboBox author_combobox;
        private System.Windows.Forms.Button add_author_from_list;
    }
}