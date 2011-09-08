﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FindAndReplace.App
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}


		private void btnFindOnly_Click(object sender, EventArgs e)
		{
			var  finder = new Finder();
			finder.Dir = txtDir.Text;
			finder.FileMask = txtFileMask.Text;
			finder.FindText = txtFind.Text;
			finder.IsCaseSensitive = chkBoxCaseSense.Checked;

			List<Finder.FindResultItem> resultItems = finder.Find();
			gvResults.DataSource = resultItems;
		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			var replacer = new Replacer();

			replacer.Dir = txtDir.Text;
			replacer.FileMask = txtFileMask.Text;
			replacer.FindText = txtFind.Text;
			replacer.ReplaceText = txtReplace.Text;
			replacer.IsCaseSensitive = chkBoxCaseSense.Checked;

			var results= replacer.Replace();
			gvResults.DataSource = results;
		}
	}
}
