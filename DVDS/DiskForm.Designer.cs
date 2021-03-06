﻿namespace DVDS
{
    partial class DiskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiskForm));
            this.diskCardTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diskCardId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.diskCardAbout = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diskCardCountry1 = new System.Windows.Forms.ComboBox();
            this.diskCardCountry2 = new System.Windows.Forms.ComboBox();
            this.diskCardCountry3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.diskCardYear = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.diskCardActors = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diskCardDIrectedBy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.diskCardGenre1 = new System.Windows.Forms.ComboBox();
            this.diskCardGenre2 = new System.Windows.Forms.ComboBox();
            this.diskCardGenre3 = new System.Windows.Forms.ComboBox();
            this.diskCardGenre4 = new System.Windows.Forms.ComboBox();
            this.diskCardGenre5 = new System.Windows.Forms.ComboBox();
            this.diskCardGenre6 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.diskButtonSave = new System.Windows.Forms.Button();
            this.diskCardCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.diskCardCost = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // diskCardTitle
            // 
            this.diskCardTitle.Location = new System.Drawing.Point(11, 54);
            this.diskCardTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardTitle.Name = "diskCardTitle";
            this.diskCardTitle.Size = new System.Drawing.Size(137, 20);
            this.diskCardTitle.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Название";
            // 
            // diskCardId
            // 
            this.diskCardId.Location = new System.Drawing.Point(28, 7);
            this.diskCardId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardId.Name = "diskCardId";
            this.diskCardId.ReadOnly = true;
            this.diskCardId.Size = new System.Drawing.Size(76, 20);
            this.diskCardId.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // diskCardAbout
            // 
            this.diskCardAbout.Location = new System.Drawing.Point(160, 54);
            this.diskCardAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardAbout.Name = "diskCardAbout";
            this.diskCardAbout.Size = new System.Drawing.Size(282, 129);
            this.diskCardAbout.TabIndex = 20;
            this.diskCardAbout.Text = "";
            this.diskCardAbout.TextChanged += new System.EventHandler(this.diskCardAbout_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Страна";
            // 
            // diskCardCountry1
            // 
            this.diskCardCountry1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.diskCardCountry1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.diskCardCountry1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardCountry1.FormattingEnabled = true;
            this.diskCardCountry1.Location = new System.Drawing.Point(11, 98);
            this.diskCardCountry1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardCountry1.Name = "diskCardCountry1";
            this.diskCardCountry1.Size = new System.Drawing.Size(137, 21);
            this.diskCardCountry1.TabIndex = 24;
            // 
            // diskCardCountry2
            // 
            this.diskCardCountry2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardCountry2.FormattingEnabled = true;
            this.diskCardCountry2.Location = new System.Drawing.Point(11, 129);
            this.diskCardCountry2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardCountry2.Name = "diskCardCountry2";
            this.diskCardCountry2.Size = new System.Drawing.Size(137, 21);
            this.diskCardCountry2.TabIndex = 25;
            // 
            // diskCardCountry3
            // 
            this.diskCardCountry3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardCountry3.FormattingEnabled = true;
            this.diskCardCountry3.Location = new System.Drawing.Point(11, 162);
            this.diskCardCountry3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardCountry3.Name = "diskCardCountry3";
            this.diskCardCountry3.Size = new System.Drawing.Size(137, 21);
            this.diskCardCountry3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Год выпуска";
            // 
            // diskCardYear
            // 
            this.diskCardYear.Location = new System.Drawing.Point(11, 212);
            this.diskCardYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardYear.Name = "diskCardYear";
            this.diskCardYear.Size = new System.Drawing.Size(137, 20);
            this.diskCardYear.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Актеры";
            // 
            // diskCardActors
            // 
            this.diskCardActors.Location = new System.Drawing.Point(160, 212);
            this.diskCardActors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardActors.Name = "diskCardActors";
            this.diskCardActors.Size = new System.Drawing.Size(282, 65);
            this.diskCardActors.TabIndex = 30;
            this.diskCardActors.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Режиссер";
            // 
            // diskCardDIrectedBy
            // 
            this.diskCardDIrectedBy.Location = new System.Drawing.Point(11, 258);
            this.diskCardDIrectedBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardDIrectedBy.Name = "diskCardDIrectedBy";
            this.diskCardDIrectedBy.Size = new System.Drawing.Size(137, 20);
            this.diskCardDIrectedBy.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Жанры";
            // 
            // diskCardGenre1
            // 
            this.diskCardGenre1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardGenre1.FormattingEnabled = true;
            this.diskCardGenre1.Location = new System.Drawing.Point(11, 303);
            this.diskCardGenre1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardGenre1.Name = "diskCardGenre1";
            this.diskCardGenre1.Size = new System.Drawing.Size(137, 21);
            this.diskCardGenre1.TabIndex = 34;
            // 
            // diskCardGenre2
            // 
            this.diskCardGenre2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardGenre2.FormattingEnabled = true;
            this.diskCardGenre2.Location = new System.Drawing.Point(160, 303);
            this.diskCardGenre2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardGenre2.Name = "diskCardGenre2";
            this.diskCardGenre2.Size = new System.Drawing.Size(137, 21);
            this.diskCardGenre2.TabIndex = 35;
            // 
            // diskCardGenre3
            // 
            this.diskCardGenre3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardGenre3.FormattingEnabled = true;
            this.diskCardGenre3.Location = new System.Drawing.Point(305, 303);
            this.diskCardGenre3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardGenre3.Name = "diskCardGenre3";
            this.diskCardGenre3.Size = new System.Drawing.Size(137, 21);
            this.diskCardGenre3.TabIndex = 36;
            // 
            // diskCardGenre4
            // 
            this.diskCardGenre4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardGenre4.FormattingEnabled = true;
            this.diskCardGenre4.Location = new System.Drawing.Point(11, 335);
            this.diskCardGenre4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardGenre4.Name = "diskCardGenre4";
            this.diskCardGenre4.Size = new System.Drawing.Size(137, 21);
            this.diskCardGenre4.TabIndex = 37;
            // 
            // diskCardGenre5
            // 
            this.diskCardGenre5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardGenre5.FormattingEnabled = true;
            this.diskCardGenre5.Location = new System.Drawing.Point(160, 335);
            this.diskCardGenre5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardGenre5.Name = "diskCardGenre5";
            this.diskCardGenre5.Size = new System.Drawing.Size(137, 21);
            this.diskCardGenre5.TabIndex = 38;
            // 
            // diskCardGenre6
            // 
            this.diskCardGenre6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskCardGenre6.FormattingEnabled = true;
            this.diskCardGenre6.Location = new System.Drawing.Point(305, 335);
            this.diskCardGenre6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardGenre6.Name = "diskCardGenre6";
            this.diskCardGenre6.Size = new System.Drawing.Size(137, 21);
            this.diskCardGenre6.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Стоимость";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "₽";
            // 
            // diskButtonSave
            // 
            this.diskButtonSave.Location = new System.Drawing.Point(356, 364);
            this.diskButtonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskButtonSave.Name = "diskButtonSave";
            this.diskButtonSave.Size = new System.Drawing.Size(85, 24);
            this.diskButtonSave.TabIndex = 43;
            this.diskButtonSave.Text = "Сохранить";
            this.diskButtonSave.UseVisualStyleBackColor = true;
            this.diskButtonSave.Click += new System.EventHandler(this.SaveDisk);
            // 
            // diskCardCount
            // 
            this.diskCardCount.Location = new System.Drawing.Point(332, 7);
            this.diskCardCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardCount.Name = "diskCardCount";
            this.diskCardCount.Size = new System.Drawing.Size(110, 20);
            this.diskCardCount.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Количество";
            // 
            // diskCardCost
            // 
            this.diskCardCost.Location = new System.Drawing.Point(181, 7);
            this.diskCardCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diskCardCost.Name = "diskCardCost";
            this.diskCardCost.Size = new System.Drawing.Size(66, 20);
            this.diskCardCost.TabIndex = 46;
            // 
            // DiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 399);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.diskCardCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.diskCardCount);
            this.Controls.Add(this.diskButtonSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.diskCardGenre6);
            this.Controls.Add(this.diskCardGenre5);
            this.Controls.Add(this.diskCardGenre4);
            this.Controls.Add(this.diskCardGenre3);
            this.Controls.Add(this.diskCardGenre2);
            this.Controls.Add(this.diskCardGenre1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.diskCardDIrectedBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.diskCardActors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diskCardYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diskCardCountry3);
            this.Controls.Add(this.diskCardCountry2);
            this.Controls.Add(this.diskCardCountry1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diskCardAbout);
            this.Controls.Add(this.diskCardTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.diskCardId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(468, 438);
            this.MinimumSize = new System.Drawing.Size(468, 438);
            this.Name = "DiskForm";
            this.Text = "DiskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diskCardTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox diskCardId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox diskCardAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox diskCardCountry1;
        private System.Windows.Forms.ComboBox diskCardCountry2;
        private System.Windows.Forms.ComboBox diskCardCountry3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker diskCardYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox diskCardActors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diskCardDIrectedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox diskCardGenre1;
        private System.Windows.Forms.ComboBox diskCardGenre2;
        private System.Windows.Forms.ComboBox diskCardGenre3;
        private System.Windows.Forms.ComboBox diskCardGenre4;
        private System.Windows.Forms.ComboBox diskCardGenre5;
        private System.Windows.Forms.ComboBox diskCardGenre6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button diskButtonSave;
        private System.Windows.Forms.TextBox diskCardCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox diskCardCost;
    }
}