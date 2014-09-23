using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Infobuilding1 : Form
	{
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("infobuilding1_timer1")]
		private Timer _infobuilding1_timer1;

		[AccessedThroughProperty("timer_label")]
		private Label _timer_label;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		private IContainer components;

		public bool exit_infobuilding1_routine;

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
					Infobuilding1 infobuilding1 = this;
					this._Button1.Click -=new EventHandler(infobuilding1.Button1_Click);
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					Infobuilding1 infobuilding11 = this;
					this._Button1.Click +=new EventHandler(infobuilding11.Button1_Click);
				}
			}
		}

		internal virtual Timer infobuilding1_timer1
		{
			get
			{
				return this._infobuilding1_timer1;
			}
			set
			{
				if (this._infobuilding1_timer1 != null)
				{
					Infobuilding1 infobuilding1 = this;
					this._infobuilding1_timer1.Tick -=new EventHandler(infobuilding1.infobuilding1_timer1_Tick);
				}
				this._infobuilding1_timer1 = value;
				if (this._infobuilding1_timer1 != null)
				{
					Infobuilding1 infobuilding11 = this;
					this._infobuilding1_timer1.Tick +=new EventHandler(infobuilding11.infobuilding1_timer1_Tick);
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

		public Infobuilding1()
		{
			this.exit_infobuilding1_routine = false;
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

		private void infobuilding1_timer1_Tick(object Sender, EventArgs e)
		{
			this.exit_infobuilding1_routine = false;
			if (StringType.StrCmp(this.timer_label.Text, "5", false) == 0 & !this.exit_infobuilding1_routine)
			{
				this.timer_label.Name = "4";
				this.exit_infobuilding1_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "4", false) == 0 & !this.exit_infobuilding1_routine)
			{
				this.timer_label.Name = "3";
				this.exit_infobuilding1_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "3", false) == 0 & !this.exit_infobuilding1_routine)
			{
				this.timer_label.Name = "2";
				this.exit_infobuilding1_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "2", false) == 0 & !this.exit_infobuilding1_routine)
			{
				this.timer_label.Name = "1";
				this.exit_infobuilding1_routine = true;
			}
			if (StringType.StrCmp(this.timer_label.Text, "1", false) == 0 & !this.exit_infobuilding1_routine)
			{
				this.Close();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.Button1 = new Button();
			this.PictureBox1 = new PictureBox();
			this.Label1 = new Label();
			this.infobuilding1_timer1 = new Timer(this.components);
			this.timer_label = new Label();
			this.SuspendLayout();
			Button button1 = this.Button1;
			Point point = new Point(256, 280);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			Size size = new Size(112, 32);
			button.Size = size;
			this.Button1.TabIndex=5;
			this.Button1.Text = "OK";
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(24, 104);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			size = new Size(160, 80);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex=4;
			this.PictureBox1.TabStop = false;
			this.Label1.BorderStyle = BorderStyle.Fixed3D;
			this.Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(200, 48);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			size = new Size(392, 208);
			label.Size = size;
			this.Label1.TabIndex=3;
			this.Label1.Text = "Text will go here";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			this.timer_label.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label timerLabel = this.timer_label;
			point = new Point(376, 272);
			timerLabel.Location = point;
			this.timer_label.Name = "timer_label";
			Label timerLabel1 = this.timer_label;
			size = new Size(48, 48);
			timerLabel1.Size = size;
			this.timer_label.TabIndex=6;
			this.timer_label.Text = "99";
			this.timer_label.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(608, 360);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.timer_label);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label1);
			size = new Size(616, 368);
			this.MaximumSize = size;
			size = new Size(616, 368);
			this.MinimumSize = size;
			this.Name = "Infobuilding1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Information";
			this.ResumeLayout(false);
		}
	}
}
