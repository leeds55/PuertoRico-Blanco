using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Infoplant : Form
	{
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("infoplant_timer1")]
		private Timer _infoplant_timer1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("timer_label")]
		private Label _timer_label;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		private IContainer components;

		public bool exit_infoplant_routine;

		internal virtual Button Button1
		{
			get
			{
				return _Button1;
			}
			set
			{
				if (_Button1 != null)
				{
					Infoplant infoplant = this;
					_Button1.Click -=new EventHandler(infoplant.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Infoplant infoplant1 = this;
					_Button1.Click +=new EventHandler(infoplant1.Button1_Click);
				}
			}
		}

		internal virtual Timer infoplant_timer1
		{
			get
			{
				return _infoplant_timer1;
			}
			set
			{
				if (_infoplant_timer1 != null)
				{
					Infoplant infoplant = this;
					_infoplant_timer1.Tick -= new EventHandler(infoplant.infoplant_timer1_Tick);
				}
				_infoplant_timer1 = value;
				if (_infoplant_timer1 != null)
				{
					Infoplant infoplant1 = this;
					_infoplant_timer1.Tick +=new EventHandler(infoplant1.infoplant_timer1_Tick);
				}
			}
		}

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

		internal virtual Label timer_label
		{
			get
			{
				return _timer_label;
			}
			set
			{
				_timer_label = value;
			}
		}

		public Infoplant()
		{
			exit_infoplant_routine = false;
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void infoplant_timer1_Tick(object Sender, EventArgs e)
		{
			exit_infoplant_routine = false;
			if (StringType.StrCmp(timer_label.Text, "5", false) == 0 & !exit_infoplant_routine)
			{
				timer_label.Name = "4";
				exit_infoplant_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "4", false) == 0 & !exit_infoplant_routine)
			{
				timer_label.Name = "3";
				exit_infoplant_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "3", false) == 0 & !exit_infoplant_routine)
			{
				timer_label.Name = "2";
				exit_infoplant_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "2", false) == 0 & !exit_infoplant_routine)
			{
				timer_label.Name = "1";
				exit_infoplant_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "1", false) == 0 & !exit_infoplant_routine)
			{
				Close();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			components = new Container();
			Button1 = new Button();
			Label1 = new Label();
			PictureBox1 = new PictureBox();
			infoplant_timer1 = new Timer(components);
			timer_label = new Label();
			SuspendLayout();
			Button button1 = Button1;
			Point point = new Point(232, 256);
			button1.Location = point;
			Button1.Name = "Button1";
			Button button = Button1;
			Size size = new Size(112, 32);
			button.Size = size;
			Button1.TabIndex=4;
			Button1.Text = "OK";
			Label1.BorderStyle = BorderStyle.Fixed3D;
			Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(144, 24);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label = Label1;
			size = new Size(392, 208);
			label.Size = size;
			Label1.TabIndex=3;
			Label1.Text = "Text will go here";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(24, 80);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			size = new Size(96, 96);
			pictureBox.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex=5;
			PictureBox1.TabStop = false;
			timer_label.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label timerLabel = timer_label;
			point = new Point(360, 248);
			timerLabel.Location = point;
			timer_label.Name = "timer_label";
			Label timerLabel1 = timer_label;
			size = new Size(48, 48);
			timerLabel1.Size = size;
			timer_label.TabIndex=6;
			timer_label.Text = "99";
			timer_label.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(568, 344);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(timer_label);
			Controls.Add(PictureBox1);
			Controls.Add(Button1);
			Controls.Add(Label1);
			size = new Size(576, 352);
			MaximumSize = size;
			size = new Size(576, 352);
			MinimumSize = size;
			Name = "Infoplant";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Infoplant";
			ResumeLayout(false);
		}
	}
}
