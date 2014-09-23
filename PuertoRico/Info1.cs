using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Info1 : Form
	{
		[AccessedThroughProperty("info_label1")]
		private Label _info_label1;

		[AccessedThroughProperty("ok_button")]
		private Button _ok_button;

		[AccessedThroughProperty("info_label2")]
		private Label _info_label2;

		private IContainer components;

		internal virtual Label info_label1
		{
			get
			{
				return _info_label1;
			}
			set
			{
				_info_label1 = value;
			}
		}

		internal virtual Label info_label2
		{
			get
			{
				return _info_label2;
			}
			set
			{
				_info_label2 = value;
			}
		}

		internal virtual Button ok_button
		{
			get
			{
				return _ok_button;
			}
			set
			{
				if (_ok_button != null)
				{
					Info1 info1 = this;
					_ok_button.Click -=new EventHandler(info1.ok_button_Click);
				}
				_ok_button = value;
				if (_ok_button != null)
				{
					Info1 info11 = this;
					_ok_button.Click +=new EventHandler(info11.ok_button_Click);
				}
			}
		}

		public Info1()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ok_button = new Button();
			info_label1 = new Label();
			info_label2 = new Label();
			SuspendLayout();
			Button okButton = ok_button;
			Point point = new Point(160, 312);
			okButton.Location = point;
			ok_button.Name = "ok_button";
			Button button = ok_button;
			Size size = new Size(104, 40);
			button.Size = size;
			ok_button.TabIndex=0;
			ok_button.Text = "OK";
			info_label1.BorderStyle = BorderStyle.Fixed3D;
			info_label1.Font = new Font("Comic Sans MS", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label infoLabel1 = info_label1;
			point = new Point(40, 40);
			infoLabel1.Location = point;
			info_label1.Name = "info_label1";
			Label label = info_label1;
			size = new Size(368, 120);
			label.Size = size;
			info_label1.TabIndex=1;
			info_label1.Text = "Text will go here.";
			info_label2.BorderStyle = BorderStyle.Fixed3D;
			info_label2.Font = new Font("Comic Sans MS", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label infoLabel2 = info_label2;
			point = new Point(40, 168);
			infoLabel2.Location = point;
			info_label2.Name = "info_label2";
			Label infoLabel21 = info_label2;
			size = new Size(368, 120);
			infoLabel21.Size = size;
			info_label2.TabIndex=2;
			info_label2.Text = "Text will go here.";
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(440, 386);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(info_label2);
			Controls.Add(info_label1);
			Controls.Add(ok_button);
			size = new Size(448, 424);
			MaximumSize = size;
			size = new Size(448, 424);
			MinimumSize = size;
			Name = "Info1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Information";
			ResumeLayout(false);
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
