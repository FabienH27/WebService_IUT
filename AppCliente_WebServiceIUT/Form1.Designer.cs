
namespace AppCliente_WebServiceIUT
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.deptInput = new System.Windows.Forms.TextBox();
            this.addDeptButton = new System.Windows.Forms.Button();
            this.deptGroupBox = new System.Windows.Forms.GroupBox();
            this.deptExistLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.promoGroupBox = new System.Windows.Forms.GroupBox();
            this.promoDeptSelector = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addPromoButton = new System.Windows.Forms.Button();
            this.promoInput = new System.Windows.Forms.TextBox();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentPromoList = new System.Windows.Forms.ListBox();
            this.SaveStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.studentBirthInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.studentLastNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentFirstNameInput = new System.Windows.Forms.TextBox();
            this.searchStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.editStudent = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListBox();
            this.resultText = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.deptGroupBox.SuspendLayout();
            this.promoGroupBox.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            this.searchStudentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "WebService - IUT";
            // 
            // deptInput
            // 
            this.deptInput.Location = new System.Drawing.Point(20, 30);
            this.deptInput.Name = "deptInput";
            this.deptInput.Size = new System.Drawing.Size(285, 20);
            this.deptInput.TabIndex = 1;
            // 
            // addDeptButton
            // 
            this.addDeptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeptButton.Location = new System.Drawing.Point(20, 56);
            this.addDeptButton.Name = "addDeptButton";
            this.addDeptButton.Size = new System.Drawing.Size(285, 52);
            this.addDeptButton.TabIndex = 3;
            this.addDeptButton.Text = "Ajouter un département";
            this.addDeptButton.UseVisualStyleBackColor = true;
            this.addDeptButton.Click += new System.EventHandler(this.AddDeptButton_Click);
            // 
            // deptGroupBox
            // 
            this.deptGroupBox.Controls.Add(this.deptExistLabel);
            this.deptGroupBox.Controls.Add(this.label6);
            this.deptGroupBox.Controls.Add(this.addDeptButton);
            this.deptGroupBox.Controls.Add(this.deptInput);
            this.deptGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptGroupBox.Location = new System.Drawing.Point(23, 55);
            this.deptGroupBox.Name = "deptGroupBox";
            this.deptGroupBox.Size = new System.Drawing.Size(328, 148);
            this.deptGroupBox.TabIndex = 4;
            this.deptGroupBox.TabStop = false;
            this.deptGroupBox.Text = "Ajouter département";
            // 
            // deptExistLabel
            // 
            this.deptExistLabel.AutoSize = true;
            this.deptExistLabel.Location = new System.Drawing.Point(139, 120);
            this.deptExistLabel.Name = "deptExistLabel";
            this.deptExistLabel.Size = new System.Drawing.Size(0, 13);
            this.deptExistLabel.TabIndex = 5;
            this.deptExistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 4;
            // 
            // promoGroupBox
            // 
            this.promoGroupBox.Controls.Add(this.promoDeptSelector);
            this.promoGroupBox.Controls.Add(this.label7);
            this.promoGroupBox.Controls.Add(this.addPromoButton);
            this.promoGroupBox.Controls.Add(this.promoInput);
            this.promoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promoGroupBox.Location = new System.Drawing.Point(23, 209);
            this.promoGroupBox.Name = "promoGroupBox";
            this.promoGroupBox.Size = new System.Drawing.Size(328, 354);
            this.promoGroupBox.TabIndex = 5;
            this.promoGroupBox.TabStop = false;
            this.promoGroupBox.Text = "Ajouter promotion";
            // 
            // promoDeptSelector
            // 
            this.promoDeptSelector.FormattingEnabled = true;
            this.promoDeptSelector.Location = new System.Drawing.Point(20, 97);
            this.promoDeptSelector.Name = "promoDeptSelector";
            this.promoDeptSelector.Size = new System.Drawing.Size(285, 173);
            this.promoDeptSelector.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Département associé";
            // 
            // addPromoButton
            // 
            this.addPromoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPromoButton.Location = new System.Drawing.Point(20, 288);
            this.addPromoButton.Name = "addPromoButton";
            this.addPromoButton.Size = new System.Drawing.Size(285, 52);
            this.addPromoButton.TabIndex = 3;
            this.addPromoButton.Text = "Ajouter une promotion";
            this.addPromoButton.UseVisualStyleBackColor = true;
            this.addPromoButton.Click += new System.EventHandler(this.AddPromoButton_Click);
            // 
            // promoInput
            // 
            this.promoInput.Location = new System.Drawing.Point(20, 38);
            this.promoInput.Name = "promoInput";
            this.promoInput.Size = new System.Drawing.Size(285, 20);
            this.promoInput.TabIndex = 1;
            this.promoInput.TextChanged += new System.EventHandler(this.PromoInput_TextChanged);
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.label5);
            this.studentGroupBox.Controls.Add(this.studentPromoList);
            this.studentGroupBox.Controls.Add(this.SaveStudent);
            this.studentGroupBox.Controls.Add(this.label4);
            this.studentGroupBox.Controls.Add(this.studentBirthInput);
            this.studentGroupBox.Controls.Add(this.label3);
            this.studentGroupBox.Controls.Add(this.studentLastNameInput);
            this.studentGroupBox.Controls.Add(this.label2);
            this.studentGroupBox.Controls.Add(this.studentFirstNameInput);
            this.studentGroupBox.Location = new System.Drawing.Point(428, 55);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(474, 212);
            this.studentGroupBox.TabIndex = 6;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Ajouter étudiant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sélectionner une promotion :";
            // 
            // studentPromoList
            // 
            this.studentPromoList.FormattingEnabled = true;
            this.studentPromoList.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC"});
            this.studentPromoList.Location = new System.Drawing.Point(225, 90);
            this.studentPromoList.Name = "studentPromoList";
            this.studentPromoList.Size = new System.Drawing.Size(199, 69);
            this.studentPromoList.TabIndex = 7;
            // 
            // SaveStudent
            // 
            this.SaveStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveStudent.Location = new System.Drawing.Point(135, 165);
            this.SaveStudent.Name = "SaveStudent";
            this.SaveStudent.Size = new System.Drawing.Size(206, 23);
            this.SaveStudent.TabIndex = 6;
            this.SaveStudent.Text = "Enregistrer";
            this.SaveStudent.UseVisualStyleBackColor = true;
            this.SaveStudent.Click += new System.EventHandler(this.SaveStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date de naissance :";
            // 
            // studentBirthInput
            // 
            this.studentBirthInput.Location = new System.Drawing.Point(225, 56);
            this.studentBirthInput.MaxDate = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            this.studentBirthInput.Name = "studentBirthInput";
            this.studentBirthInput.Size = new System.Drawing.Size(192, 20);
            this.studentBirthInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom de l\'étudiant";
            // 
            // studentLastNameInput
            // 
            this.studentLastNameInput.Location = new System.Drawing.Point(368, 24);
            this.studentLastNameInput.Name = "studentLastNameInput";
            this.studentLastNameInput.Size = new System.Drawing.Size(100, 20);
            this.studentLastNameInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom de l\'étudiant";
            // 
            // studentFirstNameInput
            // 
            this.studentFirstNameInput.Location = new System.Drawing.Point(135, 24);
            this.studentFirstNameInput.Name = "studentFirstNameInput";
            this.studentFirstNameInput.Size = new System.Drawing.Size(100, 20);
            this.studentFirstNameInput.TabIndex = 0;
            // 
            // searchStudentGroupBox
            // 
            this.searchStudentGroupBox.Controls.Add(this.editStudent);
            this.searchStudentGroupBox.Controls.Add(this.listResults);
            this.searchStudentGroupBox.Controls.Add(this.resultText);
            this.searchStudentGroupBox.Controls.Add(this.searchButton);
            this.searchStudentGroupBox.Controls.Add(this.searchInput);
            this.searchStudentGroupBox.Location = new System.Drawing.Point(428, 273);
            this.searchStudentGroupBox.Name = "searchStudentGroupBox";
            this.searchStudentGroupBox.Size = new System.Drawing.Size(489, 290);
            this.searchStudentGroupBox.TabIndex = 7;
            this.searchStudentGroupBox.TabStop = false;
            this.searchStudentGroupBox.Text = "Recherche";
            // 
            // editStudent
            // 
            this.editStudent.Location = new System.Drawing.Point(262, 57);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(205, 23);
            this.editStudent.TabIndex = 5;
            this.editStudent.Text = "Editer";
            this.editStudent.UseVisualStyleBackColor = true;
            this.editStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.Location = new System.Drawing.Point(34, 116);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(434, 160);
            this.listResults.TabIndex = 4;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(34, 94);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(51, 13);
            this.resultText.TabIndex = 3;
            this.resultText.Text = "Résultats";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(34, 57);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(201, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Chercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(34, 31);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(434, 20);
            this.searchInput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 575);
            this.Controls.Add(this.searchStudentGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.Controls.Add(this.promoGroupBox);
            this.Controls.Add(this.deptGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Web Service IUT";
            this.deptGroupBox.ResumeLayout(false);
            this.deptGroupBox.PerformLayout();
            this.promoGroupBox.ResumeLayout(false);
            this.promoGroupBox.PerformLayout();
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.searchStudentGroupBox.ResumeLayout(false);
            this.searchStudentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptInput;
        private System.Windows.Forms.Button addDeptButton;
        private System.Windows.Forms.GroupBox deptGroupBox;
        private System.Windows.Forms.GroupBox promoGroupBox;
        private System.Windows.Forms.Button addPromoButton;
        private System.Windows.Forms.TextBox promoInput;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentLastNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentFirstNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker studentBirthInput;
        private System.Windows.Forms.Button SaveStudent;
        private System.Windows.Forms.GroupBox searchStudentGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox studentPromoList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox promoDeptSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Button editStudent;
        private System.Windows.Forms.Label deptExistLabel;
    }
}

