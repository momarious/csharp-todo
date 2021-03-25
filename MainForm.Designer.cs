/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 10/02/2021
 * Time: 14:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Vote
{
	partial class MainForm
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
			this.buttonShow = new System.Windows.Forms.Button();
			this.buttonResults = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2Numero = new System.Windows.Forms.Label();
			this.label2Nom = new System.Windows.Forms.Label();
			this.label2Pool = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelMain.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Location = new System.Drawing.Point(12, 144);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(197, 74);
			this.buttonShow.TabIndex = 0;
			this.buttonShow.Text = "Liste des electeurs";
			this.buttonShow.UseVisualStyleBackColor = true;
			this.buttonShow.Click += new System.EventHandler(this.showButton_Click);
			// 
			// buttonResults
			// 
			this.buttonResults.Location = new System.Drawing.Point(12, 224);
			this.buttonResults.Name = "buttonResults";
			this.buttonResults.Size = new System.Drawing.Size(197, 74);
			this.buttonResults.TabIndex = 1;
			this.buttonResults.Text = "Résultats";
			this.buttonResults.UseVisualStyleBackColor = true;
			this.buttonResults.Click += new System.EventHandler(this.resultsButton_click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 304);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(197, 74);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Ajouter un electeur";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.tableLayoutPanel1);
			this.panelMain.Controls.Add(this.labelTitle);
			this.panelMain.Location = new System.Drawing.Point(215, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(708, 551);
			this.panelMain.TabIndex = 3;
			this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMainPaint);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
			this.tableLayoutPanel1.Controls.Add(this.label2Numero, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2Nom, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2Pool, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(88, 144);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 343);
			this.tableLayoutPanel1.TabIndex = 1;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1Paint);
			// 
			// label2Numero
			// 
			this.label2Numero.Location = new System.Drawing.Point(4, 1);
			this.label2Numero.Name = "label2Numero";
			this.label2Numero.Size = new System.Drawing.Size(100, 23);
			this.label2Numero.TabIndex = 0;
			this.label2Numero.Text = "Numéro";
			this.label2Numero.Click += new System.EventHandler(this.Label2Click);
			// 
			// label2Nom
			// 
			this.label2Nom.Location = new System.Drawing.Point(178, 1);
			this.label2Nom.Name = "label2Nom";
			this.label2Nom.Size = new System.Drawing.Size(100, 23);
			this.label2Nom.TabIndex = 1;
			this.label2Nom.Text = "Nom";
			// 
			// label2Pool
			// 
			this.label2Pool.Location = new System.Drawing.Point(352, 1);
			this.label2Pool.Name = "label2Pool";
			this.label2Pool.Size = new System.Drawing.Size(150, 23);
			this.label2Pool.TabIndex = 2;
			this.label2Pool.Text = "Bureau de vote";
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(210, 36);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(264, 45);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Liste des electeurs";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelTitle.Click += new System.EventHandler(this.Label1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 549);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonResults);
			this.Controls.Add(this.buttonShow);
			this.Name = "MainForm";
			this.Text = "Vote";
			this.panelMain.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2Pool;
		private System.Windows.Forms.Label label2Nom;
		private System.Windows.Forms.Label label2Numero;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonResults;
		private System.Windows.Forms.Button buttonShow;
		
		void PanelMainPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
		
		void Label1Click(object sender, System.EventArgs e)
		{
			
		}
		
		void TableLayoutPanel1Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
		
		void Label2Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
