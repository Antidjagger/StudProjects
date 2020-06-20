namespace AISFonotekaFrameWork
{
    partial class AuthForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bsLogin = new System.Windows.Forms.BindingSource(this.components);
            this.UsersDataSet = new AISFonotekaFrameWork.AISFonotekaDataSet();
            this.usersTableAdapter = new AISFonotekaFrameWork.AISFonotekaDataSetTableAdapters.UsersTableAdapter();
            this.logJournalTableAdapter = new AISFonotekaFrameWork.AISFonotekaTablesDataSetTableAdapters.LogJournalTableAdapter();
            this.aisFonotekaTablesDataSetlog = new AISFonotekaFrameWork.AISFonotekaTablesDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aisFonotekaTablesDataSetlog)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(16, 53);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(184, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(16, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(184, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(4, 9);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(229, 20);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "Неверный логин или пароль!";
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAuth.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.backMenu2;
            this.btnAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAuth.Location = new System.Drawing.Point(16, 124);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(89, 32);
            this.btnAuth.TabIndex = 5;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.backMenu2;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(111, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bsLogin
            // 
            this.bsLogin.DataSource = this.UsersDataSet;
            this.bsLogin.Position = 0;
            // 
            // UsersDataSet
            // 
            this.UsersDataSet.DataSetName = "AISFonotekaDataSet";
            this.UsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // logJournalTableAdapter
            // 
            this.logJournalTableAdapter.ClearBeforeFill = true;
            // 
            // aisFonotekaTablesDataSetlog
            // 
            this.aisFonotekaTablesDataSetlog.DataSetName = "AISFonotekaTablesDataSet";
            this.aisFonotekaTablesDataSetlog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AuthForm
            // 
            this.AcceptButton = this.btnAuth;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AISFonotekaFrameWork.Properties.Resources.back3_1;
            this.ClientSize = new System.Drawing.Size(243, 159);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация в каталоге";
            ((System.ComponentModel.ISupportInitialize)(this.bsLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aisFonotekaTablesDataSetlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.BindingSource bsLogin;
        private AISFonotekaDataSet UsersDataSet;
        private AISFonotekaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private AISFonotekaTablesDataSetTableAdapters.LogJournalTableAdapter logJournalTableAdapter;
        private AISFonotekaTablesDataSet aisFonotekaTablesDataSetlog;
    }
}