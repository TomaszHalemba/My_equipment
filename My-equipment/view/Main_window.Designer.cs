
namespace My_equipment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.show_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.Category_combobox = new System.Windows.Forms.ComboBox();
            this.Create_database_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_button
            // 
            resources.ApplyResources(this.show_button, "show_button");
            this.show_button.Name = "show_button";
            this.show_button.Tag = "show_button";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // add_button
            // 
            resources.ApplyResources(this.add_button, "add_button");
            this.add_button.Name = "add_button";
            this.add_button.Tag = "add_button";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // modify_button
            // 
            resources.ApplyResources(this.modify_button, "modify_button");
            this.modify_button.Name = "modify_button";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modiffy_button_Click);
            // 
            // delete_button
            // 
            resources.ApplyResources(this.delete_button, "delete_button");
            this.delete_button.Name = "delete_button";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Category_combobox
            // 
            this.Category_combobox.FormattingEnabled = true;
            this.Category_combobox.Items.AddRange(new object[] {
            resources.GetString("Category_combobox.Items"),
            resources.GetString("Category_combobox.Items1")});
            resources.ApplyResources(this.Category_combobox, "Category_combobox");
            this.Category_combobox.Name = "Category_combobox";
            // 
            // Create_database_button
            // 
            resources.ApplyResources(this.Create_database_button, "Create_database_button");
            this.Create_database_button.Name = "Create_database_button";
            this.Create_database_button.UseVisualStyleBackColor = true;
            this.Create_database_button.Click += new System.EventHandler(this.Create_database_button_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Create_database_button);
            this.Controls.Add(this.Category_combobox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_button);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ComboBox Category_combobox;
        private System.Windows.Forms.Button Create_database_button;
    }
}

