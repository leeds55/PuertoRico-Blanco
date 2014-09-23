using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Infopurchase1 : Form
	{
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		private IContainer components;

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
					Infopurchase1 infopurchase1 = this;
					_Button1.Click -=new EventHandler(infopurchase1.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Infopurchase1 infopurchase11 = this;
					_Button1.Click +=new EventHandler(infopurchase11.Button1_Click);
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get
			{
				return _GroupBox1;
			}
			set
			{
				_GroupBox1 = value;
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

		internal virtual Label Label10
		{
			get
			{
				return _Label10;
			}
			set
			{
				_Label10 = value;
			}
		}

		internal virtual Label Label11
		{
			get
			{
				return _Label11;
			}
			set
			{
				_Label11 = value;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return _Label2;
			}
			set
			{
				_Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return _Label3;
			}
			set
			{
				_Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return _Label4;
			}
			set
			{
				_Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return _Label5;
			}
			set
			{
				_Label5 = value;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return _Label6;
			}
			set
			{
				_Label6 = value;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return _Label7;
			}
			set
			{
				_Label7 = value;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return _Label8;
			}
			set
			{
				_Label8 = value;
			}
		}

		internal virtual Label Label9
		{
			get
			{
				return _Label9;
			}
			set
			{
				_Label9 = value;
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

		public Infopurchase1()
		{
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

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			Button1 = new Button();
			PictureBox1 = new PictureBox();
			Label1 = new Label();
			Label2 = new Label();
			Label3 = new Label();
			Label4 = new Label();
			Label5 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			Label8 = new Label();
			Label9 = new Label();
			Label10 = new Label();
			Label11 = new Label();
			GroupBox1 = new GroupBox();
			GroupBox1.SuspendLayout();
			SuspendLayout();
			Button button1 = Button1;
			Point point = new Point(40, 344);
			button1.Location = point;
			Button1.Name = "Button1";
			Button button = Button1;
			Size size = new Size(112, 32);
			button.Size = size;
			Button1.TabIndex=7;
			Button1.Text = "OK";
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(32, 101);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = PictureBox1;
			size = new Size(160, 80);
			pictureBox.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex=6;
			PictureBox1.TabStop = false;
			Label1.BorderStyle = BorderStyle.Fixed3D;
			Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(240, 48);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label = Label1;
			size = new Size(224, 32);
			label.Size = size;
			Label1.TabIndex=8;
			Label1.Text = "title";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			Label2.BorderStyle = BorderStyle.Fixed3D;
			Label2.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label2 = Label2;
			point = new Point(240, 88);
			label2.Location = point;
			Label2.Name = "Label2";
			Label label21 = Label2;
			size = new Size(224, 120);
			label21.Size = size;
			Label2.TabIndex=9;
			Label2.Text = "function";
			Label2.TextAlign = ContentAlignment.MiddleCenter;
			Label3.BorderStyle = BorderStyle.Fixed3D;
			Label3.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label3 = Label3;
			point = new Point(344, 216);
			label3.Location = point;
			Label3.Name = "Label3";
			Label label31 = Label3;
			size = new Size(120, 32);
			label31.Size = size;
			Label3.TabIndex = 10;
			Label3.Text = "Victory Points";
			Label3.TextAlign = ContentAlignment.MiddleCenter;
			Label4.BorderStyle = BorderStyle.Fixed3D;
			Label4.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label4 = Label4;
			point = new Point(344, 256);
			label4.Location = point;
			Label4.Name = "Label4";
			Label label41 = Label4;
			size = new Size(120, 32);
			label41.Size = size;
			Label4.TabIndex = 11;
			Label4.Text = "Base Cost";
			Label4.TextAlign = ContentAlignment.MiddleCenter;
			Label5.BorderStyle = BorderStyle.Fixed3D;
			Label5.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label5 = Label5;
			point = new Point(344, 296);
			label5.Location = point;
			Label5.Name = "Label5";
			Label label51 = Label5;
			size = new Size(120, 32);
			label51.Size = size;
			Label5.TabIndex = 12;
			Label5.Text = "Cost with Quarries";
			Label5.TextAlign = ContentAlignment.MiddleCenter;
			Label6.BorderStyle = BorderStyle.Fixed3D;
			Label6.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label6 = Label6;
			point = new Point(152, 16);
			label6.Location = point;
			Label6.Name = "Label6";
			Label label61 = Label6;
			size = new Size(120, 32);
			label61.Size = size;
			Label6.TabIndex = 13;
			Label6.Text = "Cost with Builder Bonus";
			Label6.TextAlign = ContentAlignment.MiddleCenter;
			Label7.BorderStyle = BorderStyle.Fixed3D;
			Label7.Font = new Font("Comic Sans MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label7 = Label7;
			point = new Point(8, 16);
			label7.Location = point;
			Label7.Name = "Label7";
			Label label71 = Label7;
			size = new Size(136, 32);
			label71.Size = size;
			Label7.TabIndex = 17;
			Label7.Text = "Cost with Builder Bonus";
			Label7.TextAlign = ContentAlignment.MiddleCenter;
			Label8.BorderStyle = BorderStyle.Fixed3D;
			Label8.Font = new Font("Comic Sans MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label8 = Label8;
			point = new Point(200, 296);
			label8.Location = point;
			Label8.Name = "Label8";
			Label label81 = Label8;
			size = new Size(136, 32);
			label81.Size = size;
			Label8.TabIndex = 16;
			Label8.Text = "Cost w/your manned Quarries";
			Label8.TextAlign = ContentAlignment.MiddleCenter;
			Label9.BorderStyle = BorderStyle.Fixed3D;
			Label9.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label9 = Label9;
			point = new Point(200, 256);
			label9.Location = point;
			Label9.Name = "Label9";
			Label label91 = Label9;
			size = new Size(136, 32);
			label91.Size = size;
			Label9.TabIndex = 15;
			Label9.Text = "Base Cost";
			Label9.TextAlign = ContentAlignment.MiddleCenter;
			Label10.BorderStyle = BorderStyle.Fixed3D;
			Label10.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label10 = Label10;
			point = new Point(200, 216);
			label10.Location = point;
			Label10.Name = "Label10";
			Label label101 = Label10;
			size = new Size(136, 32);
			label101.Size = size;
			Label10.TabIndex = 14;
			Label10.Text = "Victory Points";
			Label10.TextAlign = ContentAlignment.MiddleCenter;
			Label11.BorderStyle = BorderStyle.Fixed3D;
			Label11.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label11 = Label11;
			point = new Point(40, 208);
			label11.Location = point;
			Label11.Name = "Label11";
			Label label111 = Label11;
			size = new Size(128, 56);
			label111.Size = size;
			Label11.TabIndex = 18;
			Label11.Text = "99 Remaining";
			Label11.TextAlign = ContentAlignment.MiddleCenter;
			GroupBox1.Controls.Add(Label6);
			GroupBox1.Controls.Add(Label7);
			GroupBox groupBox1 = GroupBox1;
			point = new Point(192, 328);
			groupBox1.Location = point;
			GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = GroupBox1;
			size = new Size(280, 56);
			groupBox.Size = size;
			GroupBox1.TabIndex = 19;
			GroupBox1.TabStop = false;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(488, 402);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(GroupBox1);
			Controls.Add(Label11);
			Controls.Add(Label8);
			Controls.Add(Label9);
			Controls.Add(Label10);
			Controls.Add(Label5);
			Controls.Add(Label4);
			Controls.Add(Label3);
			Controls.Add(Label2);
			Controls.Add(Label1);
			Controls.Add(Button1);
			Controls.Add(PictureBox1);
			size = new Size(496, 440);
			MaximumSize = size;
			size = new Size(496, 440);
			MinimumSize = size;
			Name = "Infopurchase1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Building Info";
			GroupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
