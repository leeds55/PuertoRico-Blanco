using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Confirmnopic : Form
	{
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("yes_buton")]
		private Button _yes_buton;

		[AccessedThroughProperty("no_button")]
		private Button _no_button;

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
					Confirmnopic confirmnopic = this;
					this._no_button.Click -=new EventHandler(confirmnopic.no_button_Click);
				}
				this._no_button = value;
				if (this._no_button != null)
				{
					Confirmnopic confirmnopic1 = this;
					this._no_button.Click +=new EventHandler(confirmnopic1.no_button_Click);
				}
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
					Confirmnopic confirmnopic = this;
					this._yes_buton.Click -=new EventHandler(confirmnopic.yes_buton_Click);
				}
				this._yes_buton = value;
				if (this._yes_buton != null)
				{
					Confirmnopic confirmnopic1 = this;
					this._yes_buton.Click +=new EventHandler(confirmnopic1.yes_buton_Click);
				}
			}
		}

		public Confirmnopic()
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
			this.SuspendLayout();
			Button noButton = this.no_button;
			Point point = new Point(232, 248);
			noButton.Location = point;
			this.no_button.Name = "no_button";
			this.no_button.TabIndex=7;
			this.no_button.Text = "NO";
			Button yesButon = this.yes_buton;
			point = new Point(128, 248);
			yesButon.Location = point;
			this.yes_buton.Name = "yes_buton";
			this.yes_buton.TabIndex=8;
			this.yes_buton.Text = "YES";
			this.Label1.BorderStyle = BorderStyle.Fixed3D;
			this.Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(24, 16);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			Size size = new Size(392, 208);
			label.Size = size;
			this.Label1.TabIndex=6;
			this.Label1.Text = "Text will go here";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(440, 298);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.no_button);
			this.Controls.Add(this.yes_buton);
			this.Controls.Add(this.Label1);
			size = new Size(448, 336);
			this.MaximumSize = size;
			size = new Size(448, 336);
			this.MinimumSize = size;
			this.Name = "Confirmnopic";
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