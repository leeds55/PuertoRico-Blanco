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
				return _Button1;
			}
			set
			{
				if (_Button1 != null)
				{
					Infonopic infonopic = this;
					_Button1.Click -= new EventHandler(infonopic.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Infonopic infonopic1 = this;
					_Button1.Click += new EventHandler(infonopic1.Button1_Click);
				}
			}
		}

		internal virtual Timer infonopic_timer1
		{
			get
			{
				return _infonopic_timer1;
			}
			set
			{
				if (_infonopic_timer1 != null)
				{
					Infonopic infonopic = this;
					_infonopic_timer1.Tick -= new EventHandler(infonopic_timer1_Tick);
				}
				_infonopic_timer1 = value;
				if (_infonopic_timer1 != null)
				{
					Infonopic infonopic1 = this;
					_infonopic_timer1.Tick += new EventHandler(infonopic_timer1_Tick);
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

		public Infonopic()
		{
			exit_infonopic_routine = false;
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

		private void infonopic_timer1_Tick(object Sender, EventArgs e)
		{
			exit_infonopic_routine = false;
			if (StringType.StrCmp(timer_label.Text, "5", false) == 0 & !exit_infonopic_routine)
			{
				timer_label.Text="4";
				exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "4", false) == 0 & !exit_infonopic_routine)
			{
				timer_label.Text="3";
				exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "3", false) == 0 & !exit_infonopic_routine)
			{
				timer_label.Text="2";
				exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "2", false) == 0 & !exit_infonopic_routine)
			{
				timer_label.Name = "1";
				exit_infonopic_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "1", false) == 0 & !exit_infonopic_routine)
			{
				Close();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			components = new Container();
			Label1 = new Label();
			Button1 = new Button();
			infonopic_timer1 = new Timer(components);
			timer_label = new Label();
			SuspendLayout();
			Label1.BorderStyle = BorderStyle.Fixed3D;
			Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			Point point = new Point(24, 32);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label = Label1;
			Size size = new Size(392, 208);
			label.Size = size;
			Label1.TabIndex=1;
			Label1.Text = "Text will go here";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			Button button1 = Button1;
			point = new Point(160, 264);
			button1.Location = point;
			Button1.Name = "Button1";
			Button button = Button1;
			size = new Size(112, 32);
			button.Size = size;
			Button1.TabIndex=3;
			Button1.Text = "OK";
			timer_label.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label timerLabel = timer_label;
			point = new Point(288, 256);
			timerLabel.Location = point;
			timer_label.Name = "timer_label";
			Label timerLabel1 = timer_label;
			size = new Size(48, 48);
			timerLabel1.Size = size;
			timer_label.TabIndex=4;
			timer_label.Text = "99";
			timer_label.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(6, 16);
			AutoScaleBaseSize = size;
			size = new Size(446, 324);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(timer_label);
			Controls.Add(Button1);
			Controls.Add(Label1);
			Font=new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			size = new Size(448, 352);
			MaximumSize = size;
			size = new Size(448, 352);
			MinimumSize = size;
			Name = "Infonopic";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Information";
			ResumeLayout(false);
		}
	}
}
