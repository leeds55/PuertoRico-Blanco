using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Inforole : Form
	{
		[AccessedThroughProperty("timer_label")]
		private Label _timer_label;

		[AccessedThroughProperty("inforole_timer1")]
		private Timer _inforole_timer1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		private IContainer components;

		private bool exit_inforole_routine;

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
					Inforole inforole = this;
					this._Button1.Click -=new EventHandler(inforole.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					Inforole inforole1 = this;
					this._Button1.Click +=new EventHandler(inforole1.Button1_Click);
				}
			}
		}

		internal virtual Timer inforole_timer1
		{
			get
			{
				return this._inforole_timer1;
			}
			set
			{
				if (this._inforole_timer1 != null)
				{
					Inforole inforole = this;
					this._inforole_timer1.Tick -=new EventHandler(inforole.inforole_timer1_Tick);
				}
				this._inforole_timer1 = value;
				if (this._inforole_timer1 != null)
				{
					Inforole inforole1 = this;
					this._inforole_timer1.Tick +=new EventHandler(inforole1.inforole_timer1_Tick);
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

		public Inforole()
		{
			this.exit_inforole_routine = false;
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

		private void inforole_timer1_Tick(object Sender, EventArgs e)
		{
			this.exit_inforole_routine = false;
			if (StringType.StrCmp(this.timer_label.Text, "5", false) == 0 & !this.exit_inforole_routine)
			{
				this.timer_label.Name = "4";
				this.exit_inforole_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "4", false) == 0 & !this.exit_inforole_routine)
			{
				this.timer_label.Name = "3";
				this.exit_inforole_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "3", false) == 0 & !this.exit_inforole_routine)
			{
				this.timer_label.Name = "2";
				this.exit_inforole_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "2", false) == 0 & !this.exit_inforole_routine)
			{
				this.timer_label.Name = "1";
				this.exit_inforole_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "1", false) == 0 & !this.exit_inforole_routine)
			{
				this.Close();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.Label1 = new Label();
			this.PictureBox1 = new PictureBox();
			this.Button1 = new Button();
			this.inforole_timer1 = new Timer(this.components);
			this.timer_label = new Label();
			this.SuspendLayout();
			this.Label1.BorderStyle = BorderStyle.Fixed3D;
			this.Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			Point point = new Point(144, 32);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			Size size = new Size(392, 208);
			label.Size = size;
			this.Label1.TabIndex=0;
			this.Label1.Text = "Text will go here";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(24, 56);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new Size(104, 160);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex=1;
			this.PictureBox1.TabStop = false;
			Button button1 = this.Button1;
			point = new Point(232, 264);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new Size(112, 32);
			button.Size = size;
			this.Button1.TabIndex=2;
			this.Button1.Text = "OK";
			this.timer_label.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label timerLabel = this.timer_label;
			point = new Point(368, 256);
			timerLabel.Location = point;
			this.timer_label.Name = "timer_label";
			Label timerLabel1 = this.timer_label;
			size = new Size(48, 48);
			timerLabel1.Size = size;
			this.timer_label.TabIndex=3;
			this.timer_label.Text = "99";
			this.timer_label.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(576, 344);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.timer_label);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label1);
			size = new Size(584, 352);
			this.MaximumSize = size;
			size = new Size(584, 352);
			this.MinimumSize = size;
			this.Name = "Inforole";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Information";
			this.ResumeLayout(false);
		}

		private void InitializeTimer()
		{
			this.inforole_timer1.Interval = 1000;
			this.inforole_timer1.Enabled = true;
		}
	}
}
