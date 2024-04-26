namespace PR_22
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationDeleteSymbols = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.Task = new System.Windows.Forms.GroupBox();
            this.EntryField = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Generation = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DeleteСertainElements = new System.Windows.Forms.Button();
            this.elements = new System.Windows.Forms.TextBox();
            this.errorProviderSymbol = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberCharacters = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitField = new System.Windows.Forms.GroupBox();
            this.elementsExit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.Task.SuspendLayout();
            this.EntryField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ExitField.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Reference});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(666, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.ClearMenu,
            this.ExitMenu});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "файл";
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationGeneration,
            this.ApplicationDeleteSymbols});
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(146, 22);
            this.Applications.Text = "Приложения";
            // 
            // ApplicationGeneration
            // 
            this.ApplicationGeneration.Name = "ApplicationGeneration";
            this.ApplicationGeneration.Size = new System.Drawing.Size(269, 22);
            this.ApplicationGeneration.Text = "Приложение \"Генерация\"";
            this.ApplicationGeneration.Click += new System.EventHandler(this.ApplicationGeneration_Click);
            // 
            // ApplicationDeleteSymbols
            // 
            this.ApplicationDeleteSymbols.Name = "ApplicationDeleteSymbols";
            this.ApplicationDeleteSymbols.Size = new System.Drawing.Size(269, 22);
            this.ApplicationDeleteSymbols.Text = "Приложение \"Удаление символов\"";
            this.ApplicationDeleteSymbols.Click += new System.EventHandler(this.ApplicationDeleteSymbols_Click);
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(146, 22);
            this.ClearMenu.Text = "Очистить";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(146, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(63, 20);
            this.Reference.Text = "справка";
            this.Reference.Click += new System.EventHandler(this.Reference_Click);
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(149, 22);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Task.Controls.Add(this.pictureBox1);
            this.Task.Location = new System.Drawing.Point(2, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(652, 51);
            this.Task.TabIndex = 2;
            this.Task.TabStop = false;
            this.Task.Text = "Задание:";
            // 
            // EntryField
            // 
            this.EntryField.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.EntryField.Controls.Add(this.label1);
            this.EntryField.Controls.Add(this.Generation);
            this.EntryField.Controls.Add(this.DeleteСertainElements);
            this.EntryField.Controls.Add(this.elements);
            this.EntryField.Location = new System.Drawing.Point(2, 102);
            this.EntryField.Name = "EntryField";
            this.EntryField.Size = new System.Drawing.Size(323, 150);
            this.EntryField.TabIndex = 1;
            this.EntryField.TabStop = false;
            this.EntryField.Text = "Поле ввода:";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.Location = new System.Drawing.Point(404, 196);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(138, 50);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить поля 🗑️";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Generation
            // 
            this.Generation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Generation.Location = new System.Drawing.Point(7, 48);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(137, 60);
            this.Generation.TabIndex = 4;
            this.Generation.Text = "Сгенерировать элементы (x10) ↻";
            this.Generation.UseVisualStyleBackColor = false;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(548, 196);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход ඞ";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DeleteСertainElements
            // 
            this.DeleteСertainElements.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteСertainElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteСertainElements.Location = new System.Drawing.Point(150, 48);
            this.DeleteСertainElements.Name = "DeleteСertainElements";
            this.DeleteСertainElements.Size = new System.Drawing.Size(167, 60);
            this.DeleteСertainElements.TabIndex = 2;
            this.DeleteСertainElements.Text = "Удалить все нечетные элементы списка ✎";
            this.DeleteСertainElements.UseVisualStyleBackColor = false;
            this.DeleteСertainElements.Click += new System.EventHandler(this.DeleteСertainElements_Click);
            // 
            // elements
            // 
            this.elements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.elements.Location = new System.Drawing.Point(28, 19);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(238, 23);
            this.elements.TabIndex = 0;
            this.elements.TextChanged += new System.EventHandler(this.elements_TextChanged);
            // 
            // errorProviderSymbol
            // 
            this.errorProviderSymbol.ContainerControl = this;
            // 
            // errorProviderNull
            // 
            this.errorProviderNull.ContainerControl = this;
            // 
            // errorProviderNumberCharacters
            // 
            this.errorProviderNumberCharacters.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR_22.Properties.Resources._22;
            this.pictureBox1.Location = new System.Drawing.Point(50, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 23);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ExitField
            // 
            this.ExitField.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExitField.Controls.Add(this.elementsExit);
            this.ExitField.Location = new System.Drawing.Point(331, 102);
            this.ExitField.Name = "ExitField";
            this.ExitField.Size = new System.Drawing.Size(323, 60);
            this.ExitField.TabIndex = 5;
            this.ExitField.TabStop = false;
            this.ExitField.Text = "Поле вывода:";
            // 
            // elementsExit
            // 
            this.elementsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.elementsExit.Location = new System.Drawing.Point(29, 19);
            this.elementsExit.Name = "elementsExit";
            this.elementsExit.ReadOnly = true;
            this.elementsExit.Size = new System.Drawing.Size(229, 23);
            this.elementsExit.TabIndex = 0;
            this.elementsExit.TextChanged += new System.EventHandler(this.elementsExit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Генерация 10 значений [1; 100]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 258);
            this.Controls.Add(this.ExitField);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.EntryField);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Практическая работа №2.1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Task.ResumeLayout(false);
            this.EntryField.ResumeLayout(false);
            this.EntryField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ExitField.ResumeLayout(false);
            this.ExitField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem ApplicationGeneration;
        private System.Windows.Forms.ToolStripMenuItem ApplicationDeleteSymbols;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox EntryField;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DeleteСertainElements;
        private System.Windows.Forms.TextBox elements;
        private System.Windows.Forms.ErrorProvider errorProviderSymbol;
        private System.Windows.Forms.ErrorProvider errorProviderNull;
        private System.Windows.Forms.ErrorProvider errorProviderNumberCharacters;
        private System.Windows.Forms.GroupBox ExitField;
        private System.Windows.Forms.TextBox elementsExit;
        private System.Windows.Forms.Label label1;
    }
}

