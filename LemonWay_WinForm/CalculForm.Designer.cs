namespace Lemonay_WinForm
{
    partial class CalculForm
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
            this.Calcul = new System.Windows.Forms.Button();
            this.FiboNumber = new System.Windows.Forms.TextBox();
            this.Iteration_Label = new System.Windows.Forms.Label();
            this.Calcul_Label = new System.Windows.Forms.Label();
            this.Resultat_Label = new System.Windows.Forms.Label();
            this.Resultat_TextBox = new System.Windows.Forms.TextBox();
            this.XmlJson_Label = new System.Windows.Forms.Label();
            this.Xml_TextBox = new System.Windows.Forms.TextBox();
            this.Convert_Button = new System.Windows.Forms.Button();
            this.Json_TextBox = new System.Windows.Forms.TextBox();
            this.TextXml_Label = new System.Windows.Forms.Label();
            this.ResultJson_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcul
            // 
            this.Calcul.Location = new System.Drawing.Point(65, 121);
            this.Calcul.Name = "Calcul";
            this.Calcul.Size = new System.Drawing.Size(75, 23);
            this.Calcul.TabIndex = 0;
            this.Calcul.Text = "Calcul";
            this.Calcul.UseVisualStyleBackColor = true;
            this.Calcul.Click += new System.EventHandler(this.Calcul_Click);
            // 
            // FiboNumber
            // 
            this.FiboNumber.Location = new System.Drawing.Point(115, 40);
            this.FiboNumber.Name = "FiboNumber";
            this.FiboNumber.Size = new System.Drawing.Size(100, 20);
            this.FiboNumber.TabIndex = 1;
            // 
            // Iteration_Label
            // 
            this.Iteration_Label.AutoSize = true;
            this.Iteration_Label.Location = new System.Drawing.Point(12, 43);
            this.Iteration_Label.Name = "Iteration_Label";
            this.Iteration_Label.Size = new System.Drawing.Size(103, 13);
            this.Iteration_Label.TabIndex = 2;
            this.Iteration_Label.Text = "Nombre d\'itérations :";
            // 
            // Calcul_Label
            // 
            this.Calcul_Label.AutoSize = true;
            this.Calcul_Label.Location = new System.Drawing.Point(62, 9);
            this.Calcul_Label.Name = "Calcul_Label";
            this.Calcul_Label.Size = new System.Drawing.Size(100, 13);
            this.Calcul_Label.TabIndex = 3;
            this.Calcul_Label.Text = "Calcul de Fibonacci";
            // 
            // Resultat_Label
            // 
            this.Resultat_Label.AutoSize = true;
            this.Resultat_Label.Location = new System.Drawing.Point(12, 80);
            this.Resultat_Label.Name = "Resultat_Label";
            this.Resultat_Label.Size = new System.Drawing.Size(52, 13);
            this.Resultat_Label.TabIndex = 5;
            this.Resultat_Label.Text = "Résultat :";
            // 
            // Resultat_TextBox
            // 
            this.Resultat_TextBox.Location = new System.Drawing.Point(115, 77);
            this.Resultat_TextBox.Name = "Resultat_TextBox";
            this.Resultat_TextBox.ReadOnly = true;
            this.Resultat_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Resultat_TextBox.TabIndex = 4;
            // 
            // XmlJson_Label
            // 
            this.XmlJson_Label.AutoSize = true;
            this.XmlJson_Label.Location = new System.Drawing.Point(562, 9);
            this.XmlJson_Label.Name = "XmlJson_Label";
            this.XmlJson_Label.Size = new System.Drawing.Size(128, 13);
            this.XmlJson_Label.TabIndex = 7;
            this.XmlJson_Label.Text = "Conversion XML -> JSON";
            // 
            // Xml_TextBox
            // 
            this.Xml_TextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Xml_TextBox.Location = new System.Drawing.Point(548, 35);
            this.Xml_TextBox.Multiline = true;
            this.Xml_TextBox.Name = "Xml_TextBox";
            this.Xml_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Xml_TextBox.Size = new System.Drawing.Size(159, 128);
            this.Xml_TextBox.TabIndex = 8;
            // 
            // Convert_Button
            // 
            this.Convert_Button.Location = new System.Drawing.Point(584, 193);
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(75, 23);
            this.Convert_Button.TabIndex = 9;
            this.Convert_Button.Text = "Convertir";
            this.Convert_Button.UseVisualStyleBackColor = true;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // Json_TextBox
            // 
            this.Json_TextBox.Location = new System.Drawing.Point(548, 247);
            this.Json_TextBox.Multiline = true;
            this.Json_TextBox.Name = "Json_TextBox";
            this.Json_TextBox.ReadOnly = true;
            this.Json_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Json_TextBox.Size = new System.Drawing.Size(159, 131);
            this.Json_TextBox.TabIndex = 10;
            // 
            // TextXml_Label
            // 
            this.TextXml_Label.AutoSize = true;
            this.TextXml_Label.Location = new System.Drawing.Point(477, 80);
            this.TextXml_Label.Name = "TextXml_Label";
            this.TextXml_Label.Size = new System.Drawing.Size(65, 13);
            this.TextXml_Label.TabIndex = 11;
            this.TextXml_Label.Text = "Texte XML :";
            // 
            // ResultJson_Label
            // 
            this.ResultJson_Label.AutoSize = true;
            this.ResultJson_Label.Location = new System.Drawing.Point(477, 293);
            this.ResultJson_Label.Name = "ResultJson_Label";
            this.ResultJson_Label.Size = new System.Drawing.Size(52, 13);
            this.ResultJson_Label.TabIndex = 12;
            this.ResultJson_Label.Text = "Résultat :";
            // 
            // CalculForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultJson_Label);
            this.Controls.Add(this.TextXml_Label);
            this.Controls.Add(this.Json_TextBox);
            this.Controls.Add(this.Convert_Button);
            this.Controls.Add(this.Xml_TextBox);
            this.Controls.Add(this.XmlJson_Label);
            this.Controls.Add(this.Resultat_Label);
            this.Controls.Add(this.Resultat_TextBox);
            this.Controls.Add(this.Calcul_Label);
            this.Controls.Add(this.Iteration_Label);
            this.Controls.Add(this.FiboNumber);
            this.Controls.Add(this.Calcul);
            this.Name = "CalculForm";
            this.Text = "Lemonway WebService Challenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcul;
        private System.Windows.Forms.TextBox FiboNumber;
        private System.Windows.Forms.Label Iteration_Label;
        private System.Windows.Forms.Label Calcul_Label;
        private System.Windows.Forms.TextBox Resultat_TextBox;
        private System.Windows.Forms.Label Resultat_Label;
        private System.Windows.Forms.Label XmlJson_Label;
        private System.Windows.Forms.TextBox Xml_TextBox;
        private System.Windows.Forms.Button Convert_Button;
        private System.Windows.Forms.TextBox Json_TextBox;
        private System.Windows.Forms.Label TextXml_Label;
        private System.Windows.Forms.Label ResultJson_Label;
    }
}

