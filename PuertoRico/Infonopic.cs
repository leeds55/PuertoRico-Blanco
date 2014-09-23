using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Infonopic : Form
	{
		[AccessedThroughProperty("infonopic_timer1")]
		private Timer _infonopic_timer1;

		[AccessedThroughProperty("timer_label")]
		private Label _timer_label;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		private IContainer components;

		private bool exit_infonopic_routine;

		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			set
			{
				if (this._Button1 != null)
				{
					Infonopic infonopic = this;
					this._Button1.Click -= new EventHandler(infonopic.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					Infonopic infonopic1 = this;
					this._Button1.Click += new EventHandler(infonopic1.Button1_Click);
				}
			}
		}

		internal virtual Timer infonopic_timer1
		{
			get
			{
				return this._infonopic_timer1;
			}
			set
			{
				if (this._infonopic_timer1 != null)
				{
					Infonopic infonopic = this;
					this._infonopic_timer1.Tick -= new EventHandler(infonopic_timer1_Tick);
				}
				this._infonopic_timer1 = value;
				if (this._infonopic_timer1 != null)
				{
					Infonopic infonopic1 = this;
					this._infonopic_timer1.Tick += new EventHandler(infonopic_timer1_Tick);
				}
			}
		}

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

		internal virtual Label timer_label
		{
			get
			{
				return this._timer_label;
			}
			set
			{
				this._timer_label = null;
				this._timer_label = value;
				this._timer_label = null;
			}
		}

		public Infonopic()
		{
			this.exit_infonopic_routine = false;
			this.InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void infonopic_timer1_Tick(object Sender, EventArgs e)
		{
			this.exit_infonopic_routine = false;
			if (StringType.StrCmp(this.timer_label.Text, "5", false) == 0 & !this.exit_infonopic_routine)
			{
				this.timer_label.Text="4";
				this.exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "4", false) == 0 & !this.exit_infonopic_routine)
			{
				this.timer_label.Text="3";
				this.exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "3", false) == 0 & !this.exit_infonopic_routine)
			{
				this.timer_label.Text="2";
				this.exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "2", false) == 0 & !this.exit_infonopic_routine)
			{
				this.timer_label.Name = "1";
				this.exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "1", false) == 0 & !this.exit_infonopic_routine)
			{
				this.Close();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.Label1 = new Label();
			this.Button1 = new Button();
			this.infonopic_timer1 = new Timer(this.components);
			this.timer_label = new Label();
			this.SuspendLayout();
			this.Label1.BorderStyle = BorderStyle.Fixed3D;
			this.Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			Point point = new Point(24, 32);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			Size size = new Size(392, 208);
			label.Size = size;
			this.Label1.TabIndex=1;
			this.Label1.Text = "Text will go here";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			Button button1 = this.Button1;
			point = new Point(160, 264);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new Size(112, 32);
			button.Size = size;
			this.Button1.TabIndex=3;
			this.Button1.Text = "OK";
			this.timer_label.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label timerLabel = this.timer_label;
			point = new Point(288, 256);
			timerLabel.Location = point;
			this.timer_label.Name = "timer_label";
			Label timerLabel1 = this.timer_label;
			size = new Size(48, 48);
			timerLabel1.Size = size;
			this.timer_label.TabIndex=4;
			this.timer_label.Text = "99";
			this.timer_label.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(6, 16);
			this.AutoScaleBaseSize = size;
			size = new Size(446, 324);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.timer_label);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Font=new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			size = new Size(448, 352);
			this.MaximumSize = size;
			size = new Size(448, 352);
			this.MinimumSize = size;
			this.Name = "Infonopic";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Information";
			this.ResumeLayout(false);
		}
	}
}
