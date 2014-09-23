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
				return this._Label1;
			}
			set
			{
				this._Label1 = null;
				this._Label1 = value;
				this._Label1 = null;
			}
		}

		internal virtual Button no_button
		{
			get
			{
				return this._no_button;
			}
			set
			{
				if (this._no_button != null)
				{
					Confirmplant confirmplant = this;
					this._no_button.Click -=new EventHandler(confirmplant.no_button_Click);
				}
				this._no_button = value;
				if (this._no_button != null)
				{
					Confirmplant confirmplant1 = this;
					this._no_button.Click +=new EventHandler(confirmplant1.no_button_Click);
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			set
			{
				this._PictureBox1 = null;
				this._PictureBox1 = value;
				this._PictureBox1 = null;
			}
		}

		internal virtual Button yes_buton
		{
			get
			{
				return this._yes_buton;
			}
			set
			{
				if (this._yes_buton != null)
				{
					Confirmplant confirmplant = this;
					this._yes_buton.Click -=new EventHandler(confirmplant.yes_buton_Click);
				}
				this._yes_buton = value;
				if (this._yes_buton != null)
				{
					Confirmplant confirmplant1 = this;
					this._yes_buton.Click +=new EventHandler(confirmplant1.yes_buton_Click);
				}
			}
		}

		public Confirmplant()
		{
			this.yes_clicked = false;
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.no_button = new Button();
			this.yes_buton = new Button();
			this.Label1 = new Label();
			this.PictureBox1 = new PictureBox();
			this.SuspendLayout();
			Button noButton = this.no_button;
			Point point = new Point(304, 264);
			noButton.Location = point;
			this.no_button.Name = "no_button";
			this.no_button.TabIndex=7;
			this.no_button.Text = "NO";
			Button yesButon = this.yes_buton;
			point = new Point(200, 264);
			yesButon.Location = point;
			this.yes_buton.Name = "yes_buton";
			this.yes_buton.TabIndex=8;
			this.yes_buton.Text = "YES";
			this.Label1.BorderStyle = BorderStyle.Fixed3D;
			this.Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(152, 32);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			Size size = new Size(392, 208);
			label.Size = size;
			this.Label1.TabIndex=6;
			this.Label1.Text = "Text will go here";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(32, 88);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new Size(96, 96);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex=9;
			this.PictureBox1.TabStop = false;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(568, 314);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.no_button);
			this.Controls.Add(this.yes_buton);
			this.Controls.Add(this.Label1);
			size = new Size(576, 352);
			this.MaximumSize = size;
			size = new Size(576, 352);
			this.MinimumSize = size;
			this.Name = "Confirmplant";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Confirmation?";
			this.ResumeLayout(false);
		}

		private void no_button_Click(object sender, EventArgs e)
		{
			this.yes_clicked = false;
			this.Close();
		}

		private void yes_buton_Click(object sender, EventArgs e)
		{
			this.yes_clicked = true;
			this.Close();
		}
	}
}
