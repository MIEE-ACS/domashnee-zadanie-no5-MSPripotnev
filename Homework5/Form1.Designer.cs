namespace Homework5
{
    partial class EmployersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployersForm));
            this.EmployersLV = new System.Windows.Forms.ListView();
            this.EmployersPG = new System.Windows.Forms.PropertyGrid();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.idNUD = new System.Windows.Forms.NumericUpDown();
            this.IDInfoLabel = new System.Windows.Forms.Label();
            this.SalaryInfoLabel = new System.Windows.Forms.Label();
            this.salaryNUD = new System.Windows.Forms.NumericUpDown();
            this.NameInfoLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.DepartmentTB = new System.Windows.Forms.TextBox();
            this.DepartmentInfoLabel = new System.Windows.Forms.Label();
            this.PostTB = new System.Windows.Forms.TextBox();
            this.PostInfoLabel = new System.Windows.Forms.Label();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.ChangeEmployeeButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.MoreInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployersLV
            // 
            this.EmployersLV.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmployersLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployersLV.HideSelection = false;
            this.EmployersLV.LargeImageList = this.imageList;
            this.EmployersLV.Location = new System.Drawing.Point(0, 0);
            this.EmployersLV.Name = "EmployersLV";
            this.EmployersLV.Size = new System.Drawing.Size(274, 641);
            this.EmployersLV.TabIndex = 0;
            this.EmployersLV.UseCompatibleStateImageBehavior = false;
            // 
            // EmployersPG
            // 
            this.EmployersPG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployersPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployersPG.Location = new System.Drawing.Point(274, 319);
            this.EmployersPG.Name = "EmployersPG";
            this.EmployersPG.Size = new System.Drawing.Size(572, 322);
            this.EmployersPG.TabIndex = 1;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployeeButton.Location = new System.Drawing.Point(697, 9);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(135, 70);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Добавить сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // idNUD
            // 
            this.idNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idNUD.Location = new System.Drawing.Point(466, 10);
            this.idNUD.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.idNUD.Name = "idNUD";
            this.idNUD.Size = new System.Drawing.Size(200, 38);
            this.idNUD.TabIndex = 3;
            this.idNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idNUD.ThousandsSeparator = true;
            this.idNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // IDInfoLabel
            // 
            this.IDInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDInfoLabel.AutoSize = true;
            this.IDInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDInfoLabel.Location = new System.Drawing.Point(280, 11);
            this.IDInfoLabel.Name = "IDInfoLabel";
            this.IDInfoLabel.Size = new System.Drawing.Size(52, 33);
            this.IDInfoLabel.TabIndex = 4;
            this.IDInfoLabel.Text = "ID:";
            // 
            // SalaryInfoLabel
            // 
            this.SalaryInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryInfoLabel.AutoSize = true;
            this.SalaryInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryInfoLabel.Location = new System.Drawing.Point(280, 55);
            this.SalaryInfoLabel.Name = "SalaryInfoLabel";
            this.SalaryInfoLabel.Size = new System.Drawing.Size(151, 33);
            this.SalaryInfoLabel.TabIndex = 6;
            this.SalaryInfoLabel.Text = "Зарплата:";
            // 
            // salaryNUD
            // 
            this.salaryNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryNUD.DecimalPlaces = 2;
            this.salaryNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salaryNUD.Location = new System.Drawing.Point(466, 54);
            this.salaryNUD.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.salaryNUD.Name = "salaryNUD";
            this.salaryNUD.Size = new System.Drawing.Size(200, 38);
            this.salaryNUD.TabIndex = 5;
            this.salaryNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salaryNUD.ThousandsSeparator = true;
            this.salaryNUD.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // NameInfoLabel
            // 
            this.NameInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameInfoLabel.AutoSize = true;
            this.NameInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInfoLabel.Location = new System.Drawing.Point(280, 101);
            this.NameInfoLabel.Name = "NameInfoLabel";
            this.NameInfoLabel.Size = new System.Drawing.Size(81, 33);
            this.NameInfoLabel.TabIndex = 7;
            this.NameInfoLabel.Text = "Имя:";
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(466, 99);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 38);
            this.NameTB.TabIndex = 8;
            this.NameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DepartmentTB
            // 
            this.DepartmentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentTB.Location = new System.Drawing.Point(466, 187);
            this.DepartmentTB.Name = "DepartmentTB";
            this.DepartmentTB.Size = new System.Drawing.Size(200, 38);
            this.DepartmentTB.TabIndex = 10;
            this.DepartmentTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DepartmentInfoLabel
            // 
            this.DepartmentInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentInfoLabel.AutoSize = true;
            this.DepartmentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentInfoLabel.Location = new System.Drawing.Point(280, 189);
            this.DepartmentInfoLabel.Name = "DepartmentInfoLabel";
            this.DepartmentInfoLabel.Size = new System.Drawing.Size(109, 33);
            this.DepartmentInfoLabel.TabIndex = 9;
            this.DepartmentInfoLabel.Text = "Отдел:";
            // 
            // PostTB
            // 
            this.PostTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostTB.Location = new System.Drawing.Point(466, 143);
            this.PostTB.Name = "PostTB";
            this.PostTB.Size = new System.Drawing.Size(200, 38);
            this.PostTB.TabIndex = 12;
            this.PostTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PostInfoLabel
            // 
            this.PostInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostInfoLabel.AutoSize = true;
            this.PostInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostInfoLabel.Location = new System.Drawing.Point(280, 145);
            this.PostInfoLabel.Name = "PostInfoLabel";
            this.PostInfoLabel.Size = new System.Drawing.Size(174, 33);
            this.PostInfoLabel.TabIndex = 11;
            this.PostInfoLabel.Text = "Должность:";
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(697, 84);
            this.DeleteEmployeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(135, 70);
            this.DeleteEmployeeButton.TabIndex = 13;
            this.DeleteEmployeeButton.Text = "Уволить сотрудника";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // ChangeEmployeeButton
            // 
            this.ChangeEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeEmployeeButton.Location = new System.Drawing.Point(697, 159);
            this.ChangeEmployeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ChangeEmployeeButton.Name = "ChangeEmployeeButton";
            this.ChangeEmployeeButton.Size = new System.Drawing.Size(135, 70);
            this.ChangeEmployeeButton.TabIndex = 14;
            this.ChangeEmployeeButton.Text = "Изменить сотрудника";
            this.ChangeEmployeeButton.UseVisualStyleBackColor = true;
            this.ChangeEmployeeButton.Click += new System.EventHandler(this.ChangeEmployeeButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "png-transparent-user-profile-computer-icons-login-user-avatars-thumbnail.png");
            // 
            // MoreInfoButton
            // 
            this.MoreInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreInfoButton.Location = new System.Drawing.Point(286, 241);
            this.MoreInfoButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.MoreInfoButton.Name = "MoreInfoButton";
            this.MoreInfoButton.Size = new System.Drawing.Size(546, 70);
            this.MoreInfoButton.TabIndex = 15;
            this.MoreInfoButton.Text = "Показать подробную информацию";
            this.MoreInfoButton.UseVisualStyleBackColor = true;
            this.MoreInfoButton.Click += new System.EventHandler(this.MoreInfoButton_Click);
            // 
            // EmployersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 641);
            this.Controls.Add(this.MoreInfoButton);
            this.Controls.Add(this.ChangeEmployeeButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.PostTB);
            this.Controls.Add(this.PostInfoLabel);
            this.Controls.Add(this.DepartmentTB);
            this.Controls.Add(this.DepartmentInfoLabel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameInfoLabel);
            this.Controls.Add(this.SalaryInfoLabel);
            this.Controls.Add(this.salaryNUD);
            this.Controls.Add(this.IDInfoLabel);
            this.Controls.Add(this.idNUD);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployersPG);
            this.Controls.Add(this.EmployersLV);
            this.Name = "EmployersForm";
            this.ShowIcon = false;
            this.Text = "1C-Предприятие";
            ((System.ComponentModel.ISupportInitialize)(this.idNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView EmployersLV;
        private System.Windows.Forms.PropertyGrid EmployersPG;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.NumericUpDown idNUD;
        private System.Windows.Forms.Label IDInfoLabel;
        private System.Windows.Forms.Label SalaryInfoLabel;
        private System.Windows.Forms.NumericUpDown salaryNUD;
        private System.Windows.Forms.Label NameInfoLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox DepartmentTB;
        private System.Windows.Forms.Label DepartmentInfoLabel;
        private System.Windows.Forms.TextBox PostTB;
        private System.Windows.Forms.Label PostInfoLabel;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button ChangeEmployeeButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button MoreInfoButton;
    }
}

