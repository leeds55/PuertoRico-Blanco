using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Summary1 : Form
	{
		[AccessedThroughProperty("cur2")]
		private Label _cur2;

		[AccessedThroughProperty("p1_name_label")]
		private Label _p1_name_label;

		[AccessedThroughProperty("cur1")]
		private Label _cur1;

		[AccessedThroughProperty("p2_name_label")]
		private Label _p2_name_label;

		[AccessedThroughProperty("current1")]
		private Label _current1;

		[AccessedThroughProperty("p3_name_label")]
		private Label _p3_name_label;

		[AccessedThroughProperty("p4_name_label")]
		private Label _p4_name_label;

		[AccessedThroughProperty("cur3")]
		private Label _cur3;

		[AccessedThroughProperty("p5_name_label")]
		private Label _p5_name_label;

		[AccessedThroughProperty("cur4")]
		private Label _cur4;

		[AccessedThroughProperty("cur5")]
		private Label _cur5;

		[AccessedThroughProperty("gov1")]
		private Label _gov1;

		[AccessedThroughProperty("role1")]
		private Label _role1;

		[AccessedThroughProperty("role2")]
		private Label _role2;

		[AccessedThroughProperty("gov5")]
		private Label _gov5;

		[AccessedThroughProperty("role3")]
		private Label _role3;

		[AccessedThroughProperty("gov4")]
		private Label _gov4;

		[AccessedThroughProperty("gov3")]
		private Label _gov3;

		[AccessedThroughProperty("gov2")]
		private Label _gov2;

		[AccessedThroughProperty("role5")]
		private Label _role5;

		[AccessedThroughProperty("role4")]
		private Label _role4;

		private IContainer components;

		internal virtual Label cur1
		{
			get
			{
				return _cur1;
			}
			set
			{
				_cur1 = value;
			}
		}

		internal virtual Label cur2
		{
			get
			{
				return _cur2;
			}
			set
			{
				_cur2 = value;
			}
		}

		internal virtual Label cur3
		{
			get
			{
				return _cur3;
			}
			set
			{
				_cur3 = value;
			}
		}

		internal virtual Label cur4
		{
			get
			{
				return _cur4;
			}
			set
			{
				_cur4 = value;
			}
		}

		internal virtual Label cur5
		{
			get
			{
				return _cur5;
			}
			set
			{
				_cur5 = value;
			}
		}

		internal virtual Label current1
		{
			get
			{
				return _current1;
			}
			set
			{
				_current1 = value;
			}
		}

		internal virtual Label gov1
		{
			get
			{
				return _gov1;
			}
			set
			{
				_gov1 = value;
			}
		}

		internal virtual Label gov2
		{
			get
			{
				return _gov2;
			}
			set
			{
				_gov2 = value;
			}
		}

		internal virtual Label gov3
		{
			get
			{
				return _gov3;
			}
			set
			{
				_gov3 = value;
			}
		}

		internal virtual Label gov4
		{
			get
			{
				return _gov4;
			}
			set
			{
				_gov4 = value;
			}
		}

		internal virtual Label gov5
		{
			get
			{
				return _gov5;
			}
			set
			{
				_gov5 = value;
			}
		}

		internal virtual Label p1_name_label
		{
			get
			{
				return _p1_name_label;
			}
			set
			{
				_p1_name_label = value;
			}
		}

		internal virtual Label p2_name_label
		{
			get
			{
				return _p2_name_label;
			}
			set
			{
				_p2_name_label = value;
			}
		}

		internal virtual Label p3_name_label
		{
			get
			{
				return _p3_name_label;
			}
			set
			{
				_p3_name_label = value;
			}
		}

		internal virtual Label p4_name_label
		{
			get
			{
				return _p4_name_label;
			}
			set
			{
				_p4_name_label = value;
			}
		}

		internal virtual Label p5_name_label
		{
			get
			{
				return _p5_name_label;
			}
			set
			{
				_p5_name_label = value;
			}
		}

		internal virtual Label role1
		{
			get
			{
				return _role1;
			}
			set
			{
				_role1 = value;
			}
		}

		internal virtual Label role2
		{
			get
			{
				return _role2;
			}
			set
			{
				_role2 = value;
			}
		}

		internal virtual Label role3
		{
			get
			{
				return _role3;
			}
			set
			{
				_role3 = value;
			}
		}

		internal virtual Label role4
		{
			get
			{
				return _role4;
			}
			set
			{
				_role4 = value;
			}
		}

		internal virtual Label role5
		{
			get
			{
				return _role5;
			}
			set
			{
				_role5 = value;
			}
		}

		public Summary1()
		{
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
			p5_name_label = new Label();
			p4_name_label = new Label();
			p3_name_label = new Label();
			p2_name_label = new Label();
			p1_name_label = new Label();
			current1 = new Label();
			cur1 = new Label();
			cur2 = new Label();
			cur3 = new Label();
			cur4 = new Label();
			cur5 = new Label();
			gov1 = new Label();
			role1 = new Label();
			role2 = new Label();
			role3 = new Label();
			role4 = new Label();
			role5 = new Label();
			gov2 = new Label();
			gov3 = new Label();
			gov4 = new Label();
			gov5 = new Label();
			SuspendLayout();
			p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			p5_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = p5_name_label;
			Point point = new Point(152, 216);
			p5NameLabel.Location = point;
			p5_name_label.Name = "p5_name_label";
			Label label = p5_name_label;
			Size size = new Size(120, 23);
			label.Size = size;
			p5_name_label.TabIndex = 13;
			p5_name_label.Text = "Player5";
			p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			p4_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = p4_name_label;
			point = new Point(152, 176);
			p4NameLabel.Location = point;
			p4_name_label.Name = "p4_name_label";
			Label p4NameLabel1 = p4_name_label;
			size = new Size(120, 23);
			p4NameLabel1.Size = size;
			p4_name_label.TabIndex = 12;
			p4_name_label.Text = "Player4";
			p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			p3_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = p3_name_label;
			point = new Point(152, 136);
			p3NameLabel.Location = point;
			p3_name_label.Name = "p3_name_label";
			Label p3NameLabel1 = p3_name_label;
			size = new Size(120, 23);
			p3NameLabel1.Size = size;
			p3_name_label.TabIndex = 11;
			p3_name_label.Text = "Player3";
			p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			p2_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = p2_name_label;
			point = new Point(152, 96);
			p2NameLabel.Location = point;
			p2_name_label.Name = "p2_name_label";
			Label p2NameLabel1 = p2_name_label;
			size = new Size(120, 23);
			p2NameLabel1.Size = size;
			p2_name_label.TabIndex = 10;
			p2_name_label.Text = "Player2";
			p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			p1_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = p1_name_label;
			point = new Point(152, 56);
			p1NameLabel.Location = point;
			p1_name_label.Name = "p1_name_label";
			Label p1NameLabel1 = p1_name_label;
			size = new Size(120, 23);
			p1NameLabel1.Size = size;
			p1_name_label.TabIndex=9;
			p1_name_label.Text = "Player1";
			p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			current1.BorderStyle = BorderStyle.Fixed3D;
			current1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = current1;
			point = new Point(72, 24);
			label1.Location = point;
			current1.Name = "current1";
			Label label2 = current1;
			size = new Size(74, 23);
			label2.Size = size;
			current1.TabIndex = 14;
			current1.Text = "Current";
			current1.TextAlign = ContentAlignment.MiddleCenter;
			cur1.BorderStyle = BorderStyle.Fixed3D;
			cur1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label3 = cur1;
			point = new Point(72, 56);
			label3.Location = point;
			cur1.Name = "cur1";
			Label label4 = cur1;
			size = new Size(74, 23);
			label4.Size = size;
			cur1.TabIndex = 16;
			cur1.Text = "-->";
			cur1.TextAlign = ContentAlignment.MiddleCenter;
			cur2.BorderStyle = BorderStyle.Fixed3D;
			cur2.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label5 = cur2;
			point = new Point(72, 96);
			label5.Location = point;
			cur2.Name = "cur2";
			Label label6 = cur2;
			size = new Size(74, 23);
			label6.Size = size;
			cur2.TabIndex = 17;
			cur2.Text = "-->";
			cur2.TextAlign = ContentAlignment.MiddleCenter;
			cur3.BorderStyle = BorderStyle.Fixed3D;
			cur3.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label7 = cur3;
			point = new Point(72, 136);
			label7.Location = point;
			cur3.Name = "cur3";
			Label label8 = cur3;
			size = new Size(74, 23);
			label8.Size = size;
			cur3.TabIndex = 18;
			cur3.Text = "-->";
			cur3.TextAlign = ContentAlignment.MiddleCenter;
			cur4.BorderStyle = BorderStyle.Fixed3D;
			cur4.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label9 = cur4;
			point = new Point(72, 176);
			label9.Location = point;
			cur4.Name = "cur4";
			Label label10 = cur4;
			size = new Size(74, 23);
			label10.Size = size;
			cur4.TabIndex = 19;
			cur4.Text = "-->";
			cur4.TextAlign = ContentAlignment.MiddleCenter;
			cur5.BorderStyle = BorderStyle.Fixed3D;
			cur5.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label11 = cur5;
			point = new Point(72, 216);
			label11.Location = point;
			cur5.Name = "cur5";
			Label label12 = cur5;
			size = new Size(74, 23);
			label12.Size = size;
			cur5.TabIndex = 20;
			cur5.Text = "-->";
			cur5.TextAlign = ContentAlignment.MiddleCenter;
			gov1.BorderStyle = BorderStyle.Fixed3D;
			gov1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label13 = gov1;
			point = new Point(8, 56);
			label13.Location = point;
			gov1.Name = "gov1";
			Label label14 = gov1;
			size = new Size(56, 23);
			label14.Size = size;
			gov1.TabIndex = 21;
			gov1.Text = "Gov";
			gov1.TextAlign = ContentAlignment.MiddleCenter;
			role1.BorderStyle = BorderStyle.Fixed3D;
			role1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label15 = role1;
			point = new Point(280, 56);
			label15.Location = point;
			role1.Name = "role1";
			Label label16 = role1;
			size = new Size(74, 23);
			label16.Size = size;
			role1.TabIndex = 22;
			role1.Text = "Role";
			role1.TextAlign = ContentAlignment.MiddleCenter;
			role2.BorderStyle = BorderStyle.Fixed3D;
			role2.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label17 = role2;
			point = new Point(280, 96);
			label17.Location = point;
			role2.Name = "role2";
			Label label18 = role2;
			size = new Size(74, 23);
			label18.Size = size;
			role2.TabIndex = 23;
			role2.Text = "Role";
			role2.TextAlign = ContentAlignment.MiddleCenter;
			role3.BorderStyle = BorderStyle.Fixed3D;
			role3.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label19 = role3;
			point = new Point(280, 136);
			label19.Location = point;
			role3.Name = "role3";
			Label label20 = role3;
			size = new Size(74, 23);
			label20.Size = size;
			role3.TabIndex = 24;
			role3.Text = "Role";
			role3.TextAlign = ContentAlignment.MiddleCenter;
			role4.BorderStyle = BorderStyle.Fixed3D;
			role4.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label21 = role4;
			point = new Point(280, 176);
			label21.Location = point;
			role4.Name = "role4";
			Label label22 = role4;
			size = new Size(74, 23);
			label22.Size = size;
			role4.TabIndex = 25;
			role4.Text = "Role";
			role4.TextAlign = ContentAlignment.MiddleCenter;
			role5.BorderStyle = BorderStyle.Fixed3D;
			role5.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label23 = role5;
			point = new Point(280, 216);
			label23.Location = point;
			role5.Name = "role5";
			Label label24 = role5;
			size = new Size(74, 23);
			label24.Size = size;
			role5.TabIndex = 26;
			role5.Text = "Role";
			role5.TextAlign = ContentAlignment.MiddleCenter;
			gov2.BorderStyle = BorderStyle.Fixed3D;
			gov2.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label25 = gov2;
			point = new Point(8, 96);
			label25.Location = point;
			gov2.Name = "gov2";
			Label label26 = gov2;
			size = new Size(56, 23);
			label26.Size = size;
			gov2.TabIndex = 27;
			gov2.Text = "Gov";
			gov2.TextAlign = ContentAlignment.MiddleCenter;
			gov3.BorderStyle = BorderStyle.Fixed3D;
			gov3.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label27 = gov3;
			point = new Point(8, 136);
			label27.Location = point;
			gov3.Name = "gov3";
			Label label28 = gov3;
			size = new Size(56, 23);
			label28.Size = size;
			gov3.TabIndex = 28;
			gov3.Text = "Gov";
			gov3.TextAlign = ContentAlignment.MiddleCenter;
			gov4.BorderStyle = BorderStyle.Fixed3D;
			gov4.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label29 = gov4;
			point = new Point(8, 176);
			label29.Location = point;
			gov4.Name = "gov4";
			Label label30 = gov4;
			size = new Size(56, 23);
			label30.Size = size;
			gov4.TabIndex = 29;
			gov4.Text = "Gov";
			gov4.TextAlign = ContentAlignment.MiddleCenter;
			gov5.BorderStyle = BorderStyle.Fixed3D;
			gov5.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label31 = gov5;
			point = new Point(8, 216);
			label31.Location = point;
			gov5.Name = "gov5";
			Label label32 = gov5;
			size = new Size(56, 23);
			label32.Size = size;
			gov5.TabIndex = 30;
			gov5.Text = "Gov";
			gov5.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(384, 266);
			ClientSize = size;
			Controls.Add(gov5);
			Controls.Add(gov4);
			Controls.Add(gov3);
			Controls.Add(gov2);
			Controls.Add(role5);
			Controls.Add(role4);
			Controls.Add(role3);
			Controls.Add(role2);
			Controls.Add(role1);
			Controls.Add(gov1);
			Controls.Add(cur5);
			Controls.Add(cur4);
			Controls.Add(cur3);
			Controls.Add(cur2);
			Controls.Add(cur1);
			Controls.Add(current1);
			Controls.Add(p5_name_label);
			Controls.Add(p4_name_label);
			Controls.Add(p3_name_label);
			Controls.Add(p2_name_label);
			Controls.Add(p1_name_label);
			Name = "Summary1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Summary";
			ResumeLayout(false);
		}
	}
}
