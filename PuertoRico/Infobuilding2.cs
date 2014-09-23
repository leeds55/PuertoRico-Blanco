using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Infobuilding2 : Form
	{
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("infobuilding2_timer1")]
		private Timer _infobuilding2_timer1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("timer_label")]
		private Label _timer_label;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		private IContainer components;

		public bool exit_infobuilding2_routine;

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
					Infobuilding2 infobuilding2 = this;
					_Button1.Click -=new EventHandler(infobuilding2.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Infobuilding2 infobuilding21 = this;
					_Button1.Click +=new EventHandler(infobuilding21.Button1_Click);
				}
			}
		}

		internal virtual Timer infobuilding2_timer1
		{
			get
			{
				return _infobuilding2_timer1;
			}
			set
			{
				if (_infobuilding2_timer1 != null)
				{
					Infobuilding2 infobuilding2 = this;
					_infobuilding2_timer1.Tick -=new EventHandler(infobuilding2.infobuilding2_timer1_Tick);
				}
				_infobuilding2_timer1 = value;
				if (_infobuilding2_timer1 != null)
				{
					Infobuilding2 infobuilding21 = this;
					_infobuilding2_timer1.Tick +=new EventHandler(infobuilding21.infobuilding2_timer1_Tick);
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

		public Infobuilding2()
		{
			exit_infobuilding2_routine = false;
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

		private void infobuilding2_timer1_Tick(object Sender, EventArgs e)
		{
			exit_infobuilding2_routine = false;
			if (StringType.StrCmp(timer_label.Text, "5", false) == 0 & !exit_infobuilding2_routine)
			{
				timer_label.Name = "4";
				exit_infobuilding2_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "4", false) == 0 & !exit_infobuilding2_routine)
			{
				timer_label.Name = "3";
				exit_infobuilding2_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "3", false) == 0 & !exit_infobuilding2_routine)
			{
				timer_label.Name = "2";
				exit_infobuilding2_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "2", false) == 0 & !exit_infobuilding2_routine)
			{
				timer_label.Name = "1";
				exit_infobuilding2_routine = true;
			}
			if (StringType.StrCmp(timer_label.Text, "1", false) == 0 & !exit_infobuilding2_routine)
			{
				Close();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			components = new Container();
			Button1 = new Button();
			PictureBox1 = new PictureBox();
			Label1 = new Label();
			timer_label = new Label();
			infobuilding2_timer1 = new Timer(components);
			SuspendLayout();
			Button button1 = Button1;
			Point point = new Point(256, 264);
			button1.Location = point;
			Button1.Name = "Button1";
			Button button = Button1;
			Size size = new Size(112, 32);
			button.Size = size;
			Button1.TabIndex=8;
			Button1.Text = "OK";
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(24, 48);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			size = new Size(160, 184);
			pictureBox.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex=7;
			PictureBox1.TabStop = false;
			Label1.BorderStyle = BorderStyle.Fixed3D;
			Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(200, 32);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label = Label1;
			size = new Size(392, 208);
			label.Size = size;
			Label1.TabIndex=6;
			Label1.Text = "Text will go here";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			timer_label.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label timerLabel = timer_label;
			point = new Point(376, 256);
			timerLabel.Location = point;
			timer_label.Name = "timer_label";
			Label timerLabel1 = timer_label;
			size = new Size(48, 48);
			timerLabel1.Size = size;
			timer_label.TabIndex=9;
			timer_label.Text = "99";
			timer_label.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(616, 314);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(timer_label);
			Controls.Add(Button1);
			Controls.Add(PictureBox1);
			Controls.Add(Label1);
			size = new Size(624, 352);
			MaximumSize = size;
			size = new Size(624, 352);
			MinimumSize = size;
			Name = "Infobuilding2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Infobuilding2";
			ResumeLayout(false);
		}
	}
}
