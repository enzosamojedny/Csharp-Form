
namespace C__Coderhouse_MAIN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridProducts = new DataGridView();
            btnLoadData = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtId = new TextBox();
            btnCreateUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridProducts
            // 
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Location = new Point(145, 12);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.Size = new Size(643, 426);
            dataGridProducts.TabIndex = 0;
            dataGridProducts.CellContentClick += dataGridProducts_CellContentClick;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(12, 87);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(124, 69);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Refresh products";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadProducts_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(124, 69);
            button1.TabIndex = 2;
            button1.Text = "Refresh users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLoadUsers_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 162);
            button2.Name = "button2";
            button2.Size = new Size(124, 69);
            button2.TabIndex = 3;
            button2.Text = "Refresh sales";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnLoadSales_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 237);
            button3.Name = "button3";
            button3.Size = new Size(124, 34);
            button3.TabIndex = 4;
            button3.Text = "Find user by ID";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(23, 277);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            txtId.Click += btnFindById_click;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(12, 306);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(124, 69);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Create user";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateUser);
            Controls.Add(txtId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLoadData);
            Controls.Add(dataGridProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridProducts;
        private Button btnLoadData;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtId;
        private Button btnCreateUser;
    }
}
