using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Confirmrole : Form
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
					Confirmrole confirmrole = this;
					_no_button.Click -=new EventHandler(confirmrole.no_button_Click);
				}
				_no_button = value;
				if (_no_button != null)
				{
					Confirmrole confirmrole1 = this;
					_no_button.Click +=new EventHandler(confirmrole1.no_button_Click);
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
					Confirmrole confirmrole = this;
					_yes_buton.Click -=new EventHandler(confirmrole.yes_buton_Click);
				}
				_yes_buton = value;
				if (_yes_buton != null)
				{
					Confirmrole confirmrole1 = this;
					_yes_buton.Click +=new EventHandler(confirmrole1.yes_buton_Click);
				}
			}
		}

		public Confirmrole()
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
			PictureBox1 = new PictureBox();
			Label1 = new Label();
			no_button = new Button();
			yes_buton = new Button();
			SuspendLayout();
			PictureBox pictureBox1 = PictureBox1;
			Point point = new Point(16, 48);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			Size size = new Size(104, 160);
			pictureBox.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex=3;
			PictureBox1.TabStop = false;
			Label1.BorderStyle = BorderStyle.Fixed3D;
			Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(136, 24);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label = Label1;
			size = new Size(392, 208);
			label.Size = size;
			Label1.TabIndex=2;
			Label1.Text = "Text will go here";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			Button noButton = no_button;
			point = new Point(288, 256);
			noButton.Location = point;
			no_button.Name = "no_button";
			no_button.TabIndex=4;
			no_button.Text = "NO";
			Button yesButon = yes_buton;
			point = new Point(184, 256);
			yesButon.Location = point;
			yes_buton.Name = "yes_buton";
			yes_buton.TabIndex=5;
			yes_buton.Text = "YES";
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(544, 306);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(no_button);
			Controls.Add(yes_buton);
			Controls.Add(PictureBox1);
			Controls.Add(Label1);
			size = new Size(552, 344);
			MaximumSize = size;
			size = new Size(552, 344);
			MinimumSize = size;
			Name = "Confirmrole";
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
