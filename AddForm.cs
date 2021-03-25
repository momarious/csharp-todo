/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 10/02/2021
 * Time: 14:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vote
{
	/// <summary>
	/// Description of AddForm.
	/// </summary>
	public partial class AddForm : Form
	{
		public AddForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
				
		void buttonSave_Click(object sender, EventArgs e)
		{
			string name = Convert.ToString(textBoxName.Text);			
			string number = Convert.ToString(textBoxNumber.Text);
			

				
		}
	}
}
