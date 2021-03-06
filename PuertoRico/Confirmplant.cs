using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Confirmplant : Form
	{
		[AccessedThroughProperty("no_button")]
		private Button _no_button;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("yes_buton")]
		private Button _yes_buton;

		private IContainer components;

		public bool yes_clicked;

		internal virtual Label Label1
		{
			get
			{
				return _Label1;
			}
			set
			{
				_Label1 = value;
			}
		}

		internal virtual Button no_button
		{
			get
			{
				return _no_button;
			}
			set
			{
				if (_no_button != null)
				{
					Confirmplant confirmplant = this;
					_no_button.Click -=new EventHandler(confirmplant.no_button_Click);
				}
				_no_button = value;
				if (_no_button != null)
				{
					Confirmplant confirmplant1 = this;
					_no_button.Click +=new EventHandler(confirmplant1.no_button_Click);
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			get
			{
				return _PictureBox1;
			}
			set
			{
				_PictureBox1 = value;
			}
		}

		internal virtual Button yes_buton
		{
			get
			{
				return _yes_buton;
			}
			set
			{
				if (_yes_buton != null)
				{
					Confirmplant confirmplant = this;
					_yes_buton.Click -=new EventHandler(confirmplant.yes_buton_Click);
				}
				_yes_buton = value;
				if (_yes_buton != null)
				{
					Confirmplant confirmplant1 = this;
					_yes_buton.Click +=new EventHandler(confirmplant1.yes_buton_Click);
				}
			}
		}

		public Confirmplant()
		{
			yes_clicked = false;
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
			no_button = new Button();
			yes_buton = new Button();
			Label1 = new Label();
			PictureBox1 = new PictureBox();
			SuspendLayout();
			Button noButton = no_button;
			Point point = new Point(304, 264);
			noButton.Location = point;
			no_button.Name = "no_button";
			no_button.TabIndex=7;
			no_button.Text = "NO";
			Button yesButon = yes_buton;
			point = new Point(200, 264);
			yesButon.Location = point;
			yes_buton.Name = "yes_buton";
			yes_buton.TabIndex=8;
			yes_buton.Text = "YES";
			Label1.BorderStyle = BorderStyle.Fixed3D;
			Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(152, 32);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label = Label1;
			Size size = new Size(392, 208);
			label.Size = size;
			Label1.TabIndex=6;
			Label1.Text = "Text will go here";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(32, 88);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			size = new Size(96, 96);
			pictureBox.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex=9;
			PictureBox1.TabStop = false;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(568, 314);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(PictureBox1);
			Controls.Add(no_button);
			Controls.Add(yes_buton);
			Controls.Add(Label1);
			size = new Size(576, 352);
			MaximumSize = size;
			size = new Size(576, 352);
			MinimumSize = size;
			Name = "Confirmplant";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Confirmation?";
			ResumeLayout(false);
		}

		private void no_button_Click(object sender, EventArgs e)
		{
			yes_clicked = false;
			Close();
		}

		private void yes_buton_Click(object sender, EventArgs e)
		{
			yes_clicked = true;
			Close();
		}
	}
}
