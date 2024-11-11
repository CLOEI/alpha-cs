namespace N_tier
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            welcomePanel = new Panel();
            label4 = new Label();
            label1 = new Label();
            usersPanel = new Panel();
            button5 = new Button();
            button4 = new Button();
            label2 = new Label();
            addUserPanel = new Panel();
            addUserSubmitButton = new Button();
            passwordInput = new TextBox();
            nameInput = new TextBox();
            emailInput = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            listUserPanel = new Panel();
            userList = new ListView();
            label5 = new Label();
            productsPanel = new Panel();
            addProductPanel = new Panel();
            addProductButton = new Button();
            label11 = new Label();
            productPriceInput = new TextBox();
            label14 = new Label();
            productDescriptionInput = new TextBox();
            label13 = new Label();
            productNameInput = new TextBox();
            label12 = new Label();
            productListPanel = new Panel();
            label10 = new Label();
            productList = new ListView();
            button7 = new Button();
            button6 = new Button();
            label3 = new Label();
            dbConnectionStatus = new Panel();
            welcomePanel.SuspendLayout();
            usersPanel.SuspendLayout();
            addUserPanel.SuspendLayout();
            listUserPanel.SuspendLayout();
            productsPanel.SuspendLayout();
            addProductPanel.SuspendLayout();
            productListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 70);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Users";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 99);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Products";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // welcomePanel
            // 
            welcomePanel.Controls.Add(label4);
            welcomePanel.Controls.Add(label1);
            welcomePanel.Location = new Point(93, 12);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(695, 426);
            welcomePanel.TabIndex = 3;
            welcomePanel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(234, 206);
            label4.Name = "label4";
            label4.Size = new Size(232, 15);
            label4.TabIndex = 1;
            label4.Text = "Choose one of the menu in the left sidebar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // usersPanel
            // 
            usersPanel.Controls.Add(button5);
            usersPanel.Controls.Add(button4);
            usersPanel.Controls.Add(label2);
            usersPanel.Controls.Add(addUserPanel);
            usersPanel.Controls.Add(listUserPanel);
            usersPanel.Location = new Point(90, 15);
            usersPanel.Name = "usersPanel";
            usersPanel.Size = new Size(695, 426);
            usersPanel.TabIndex = 4;
            usersPanel.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(87, 6);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 6);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.Text = "List";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "Users";
            // 
            // addUserPanel
            // 
            addUserPanel.Controls.Add(addUserSubmitButton);
            addUserPanel.Controls.Add(passwordInput);
            addUserPanel.Controls.Add(nameInput);
            addUserPanel.Controls.Add(emailInput);
            addUserPanel.Controls.Add(label9);
            addUserPanel.Controls.Add(label8);
            addUserPanel.Controls.Add(label7);
            addUserPanel.Controls.Add(label6);
            addUserPanel.Location = new Point(6, 35);
            addUserPanel.Name = "addUserPanel";
            addUserPanel.Size = new Size(683, 388);
            addUserPanel.TabIndex = 8;
            addUserPanel.Visible = false;
            // 
            // addUserSubmitButton
            // 
            addUserSubmitButton.Location = new Point(388, 237);
            addUserSubmitButton.Name = "addUserSubmitButton";
            addUserSubmitButton.Size = new Size(75, 23);
            addUserSubmitButton.TabIndex = 10;
            addUserSubmitButton.Text = "Submit";
            addUserSubmitButton.UseVisualStyleBackColor = true;
            addUserSubmitButton.Click += addUserSubmitButton_Click;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(274, 199);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(189, 23);
            passwordInput.TabIndex = 9;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(274, 170);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(189, 23);
            nameInput.TabIndex = 8;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(274, 142);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(189, 23);
            emailInput.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 173);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 3;
            label9.Text = "Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(196, 202);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 2;
            label8.Text = "Password :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 145);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 1;
            label7.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(628, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 0;
            label6.Text = "Add User";
            // 
            // listUserPanel
            // 
            listUserPanel.Controls.Add(userList);
            listUserPanel.Controls.Add(label5);
            listUserPanel.Location = new Point(6, 41);
            listUserPanel.Name = "listUserPanel";
            listUserPanel.Size = new Size(683, 388);
            listUserPanel.TabIndex = 7;
            // 
            // userList
            // 
            userList.Location = new Point(3, 18);
            userList.Name = "userList";
            userList.Size = new Size(677, 364);
            userList.TabIndex = 1;
            userList.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(632, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 0;
            label5.Text = "List User";
            // 
            // productsPanel
            // 
            productsPanel.Controls.Add(productListPanel);
            productsPanel.Controls.Add(button7);
            productsPanel.Controls.Add(button6);
            productsPanel.Controls.Add(label3);
            productsPanel.Controls.Add(addProductPanel);
            productsPanel.Location = new Point(87, 14);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(695, 426);
            productsPanel.TabIndex = 5;
            productsPanel.Visible = false;
            // 
            // addProductPanel
            // 
            addProductPanel.Controls.Add(addProductButton);
            addProductPanel.Controls.Add(label11);
            addProductPanel.Controls.Add(productPriceInput);
            addProductPanel.Controls.Add(label14);
            addProductPanel.Controls.Add(productDescriptionInput);
            addProductPanel.Controls.Add(label13);
            addProductPanel.Controls.Add(productNameInput);
            addProductPanel.Controls.Add(label12);
            addProductPanel.Location = new Point(15, 35);
            addProductPanel.Name = "addProductPanel";
            addProductPanel.Size = new Size(683, 382);
            addProductPanel.TabIndex = 4;
            addProductPanel.Visible = false;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(382, 241);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(75, 23);
            addProductButton.TabIndex = 17;
            addProductButton.Text = "Submit";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(606, 5);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 2;
            label11.Text = "Add Product";
            // 
            // productPriceInput
            // 
            productPriceInput.Location = new Point(268, 203);
            productPriceInput.Name = "productPriceInput";
            productPriceInput.Size = new Size(189, 23);
            productPriceInput.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(211, 149);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 11;
            label14.Text = "Name :";
            // 
            // productDescriptionInput
            // 
            productDescriptionInput.Location = new Point(268, 174);
            productDescriptionInput.Name = "productDescriptionInput";
            productDescriptionInput.Size = new Size(189, 23);
            productDescriptionInput.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(217, 208);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 12;
            label13.Text = "Price :";
            // 
            // productNameInput
            // 
            productNameInput.Location = new Point(268, 146);
            productNameInput.Name = "productNameInput";
            productNameInput.Size = new Size(189, 23);
            productNameInput.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(183, 177);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 13;
            label12.Text = "Description :";
            // 
            // productListPanel
            // 
            productListPanel.Controls.Add(label10);
            productListPanel.Controls.Add(productList);
            productListPanel.Location = new Point(6, 41);
            productListPanel.Name = "productListPanel";
            productListPanel.Size = new Size(683, 382);
            productListPanel.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(610, 1);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 2;
            label10.Text = "Product List";
            // 
            // productList
            // 
            productList.Location = new Point(3, 19);
            productList.Name = "productList";
            productList.Size = new Size(677, 363);
            productList.TabIndex = 1;
            productList.UseCompatibleStateImageBehavior = false;
            // 
            // button7
            // 
            button7.Location = new Point(87, 6);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 2;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(6, 6);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 1;
            button6.Text = "List";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Products";
            // 
            // dbConnectionStatus
            // 
            dbConnectionStatus.BackColor = Color.Red;
            dbConnectionStatus.Location = new Point(12, 413);
            dbConnectionStatus.Name = "dbConnectionStatus";
            dbConnectionStatus.Size = new Size(25, 25);
            dbConnectionStatus.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dbConnectionStatus);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(productsPanel);
            Controls.Add(usersPanel);
            Controls.Add(welcomePanel);
            Name = "Form1";
            ShowIcon = false;
            Text = "Alpha";
            Load += Form1_Load;
            welcomePanel.ResumeLayout(false);
            welcomePanel.PerformLayout();
            usersPanel.ResumeLayout(false);
            usersPanel.PerformLayout();
            addUserPanel.ResumeLayout(false);
            addUserPanel.PerformLayout();
            listUserPanel.ResumeLayout(false);
            listUserPanel.PerformLayout();
            productsPanel.ResumeLayout(false);
            productsPanel.PerformLayout();
            addProductPanel.ResumeLayout(false);
            addProductPanel.PerformLayout();
            productListPanel.ResumeLayout(false);
            productListPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel welcomePanel;
        private Label label1;
        private Panel usersPanel;
        private Label label2;
        private Panel productsPanel;
        private Label label3;
        private Panel dbConnectionStatus;
        private Label label4;
        private Panel listUserPanel;
        private Label label5;
        private Button button5;
        private Button button4;
        private Panel addUserPanel;
        private Label label6;
        private TextBox passwordInput;
        private TextBox nameInput;
        private TextBox emailInput;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button addUserSubmitButton;
        private ListView userList;
        private Button button6;
        private Button button7;
        private Panel productListPanel;
        private ListView productList;
        private Label label10;
        private Panel addProductPanel;
        private Label label11;
        private Button addProductButton;
        private TextBox productPriceInput;
        private Label label14;
        private TextBox productDescriptionInput;
        private Label label13;
        private TextBox productNameInput;
        private Label label12;
    }
}
