/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 10/02/2021
 * Time: 14:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vote
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void AddButton_Click(object sender, EventArgs e)
		{
			AddForm form2 = new AddForm();
			form2.Show();	
		}
		
		void showButton_Click(object sender, EventArgs e)
		{
			tableLayoutPanel1.Show();
			labelTitle.Text = "Liste des electeurs";
		}
		
		void resultsButton_click(object sender, EventArgs e)
		{
			tableLayoutPanel1.Hide();
			labelTitle.Text = "Resultat des elections";
		}
	}
}

