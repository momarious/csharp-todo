/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 10/02/2021
 * Time: 14:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Vote
{
	partial class AddForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.labelNumber = new System.Windows.Forms.Label();
			this.labelTitleAdd = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(148, 176);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(284, 26);
			this.textBoxName.TabIndex = 0;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(147, 254);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(284, 26);
			this.textBoxNumber.TabIndex = 1;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(147, 332);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(284, 60);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Enregistrer";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(148, 148);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(231, 25);
			this.labelName.TabIndex = 3;
			this.labelName.Text = "Nom";
			// 
			// labelNumber
			// 
			this.labelNumber.Location = new System.Drawing.Point(148, 226);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(231, 25);
			this.labelNumber.TabIndex = 4;
			this.labelNumber.Text = "Numero";
			// 
			// labelTitleAdd
			// 
			this.labelTitleAdd.Location = new System.Drawing.Point(24, 33);
			this.labelTitleAdd.Name = "labelTitleAdd";
			this.labelTitleAdd.Size = new System.Drawing.Size(523, 61);
			this.labelTitleAdd.TabIndex = 5;
			this.labelTitleAdd.Text = "Ajouter un electeur";
			// 
			// AddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 541);
			this.Controls.Add(this.labelTitleAdd);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.textBoxName);
			this.Name = "AddForm";
			this.Text = "AddForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelTitleAdd;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.TextBox textBoxName;
	}
}
