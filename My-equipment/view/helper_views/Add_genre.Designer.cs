
namespace My_equipment.view
{
    partial class Add_genre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_genre));
            this.genre_textbox = new System.Windows.Forms.TextBox();
            this.add_item_button = new System.Windows.Forms.Button();
            this.genre_label = new System.Windows.Forms.Label();
            this.modify_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genre_textbox
            // 
            resources.ApplyResources(this.genre_textbox, "genre_textbox");
            this.genre_textbox.Name = "genre_textbox";
            // 
            // add_item_button
            // 
            resources.ApplyResources(this.add_item_button, "add_item_button");
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.UseVisualStyleBackColor = true;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // genre_label
            // 
            resources.ApplyResources(this.genre_label, "genre_label");
            this.genre_label.Name = "genre_label";
            // 
            // modify_button
            // 
            resources.ApplyResources(this.modify_button, "modify_button");
            this.modify_button.Name = "modify_button";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // Add_genre
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.genre_textbox);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.add_item_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_genre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox genre_textbox;
        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Button modify_button;
    }
}