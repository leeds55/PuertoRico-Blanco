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
				return this._cur1;
			}
			set
			{
				this._cur1 = null;
				this._cur1 = value;
				this._cur1 = null;
			}
		}

		internal virtual Label cur2
		{
			get
			{
				return this._cur2;
			}
			set
			{
				this._cur2 = null;
				this._cur2 = value;
				this._cur2 = null;
			}
		}

		internal virtual Label cur3
		{
			get
			{
				return this._cur3;
			}
			set
			{
				this._cur3 = null;
				this._cur3 = value;
				this._cur3 = null;
			}
		}

		internal virtual Label cur4
		{
			get
			{
				return this._cur4;
			}
			set
			{
				this._cur4 = null;
				this._cur4 = value;
				this._cur4 = null;
			}
		}

		internal virtual Label cur5
		{
			get
			{
				return this._cur5;
			}
			set
			{
				this._cur5 = null;
				this._cur5 = value;
				this._cur5 = null;
			}
		}

		internal virtual Label current1
		{
			get
			{
				return this._current1;
			}
			set
			{
				this._current1 = null;
				this._current1 = value;
				this._current1 = null;
			}
		}

		internal virtual Label gov1
		{
			get
			{
				return this._gov1;
			}
			set
			{
				this._gov1 = null;
				this._gov1 = value;
				this._gov1 = null;
			}
		}

		internal virtual Label gov2
		{
			get
			{
				return this._gov2;
			}
			set
			{
				this._gov2 = null;
				this._gov2 = value;
				this._gov2 = null;
			}
		}

		internal virtual Label gov3
		{
			get
			{
				return this._gov3;
			}
			set
			{
				this._gov3 = null;
				this._gov3 = value;
				this._gov3 = null;
			}
		}

		internal virtual Label gov4
		{
			get
			{
				return this._gov4;
			}
			set
			{
				this._gov4 = null;
				this._gov4 = value;
				this._gov4 = null;
			}
		}

		internal virtual Label gov5
		{
			get
			{
				return this._gov5;
			}
			set
			{
				this._gov5 = null;
				this._gov5 = value;
				this._gov5 = null;
			}
		}

		internal virtual Label p1_name_label
		{
			get
			{
				return this._p1_name_label;
			}
			set
			{
				this._p1_name_label = null;
				this._p1_name_label = value;
				this._p1_name_label = null;
			}
		}

		internal virtual Label p2_name_label
		{
			get
			{
				return this._p2_name_label;
			}
			set
			{
				this._p2_name_label = null;
				this._p2_name_label = value;
				this._p2_name_label = null;
			}
		}

		internal virtual Label p3_name_label
		{
			get
			{
				return this._p3_name_label;
			}
			set
			{
				this._p3_name_label = null;
				this._p3_name_label = value;
				this._p3_name_label = null;
			}
		}

		internal virtual Label p4_name_label
		{
			get
			{
				return this._p4_name_label;
			}
			set
			{
				this._p4_name_label = null;
				this._p4_name_label = value;
				this._p4_name_label = null;
			}
		}

		internal virtual Label p5_name_label
		{
			get
			{
				return this._p5_name_label;
			}
			set
			{
				this._p5_name_label = null;
				this._p5_name_label = value;
				this._p5_name_label = null;
			}
		}

		internal virtual Label role1
		{
			get
			{
				return this._role1;
			}
			set
			{
				this._role1 = null;
				this._role1 = value;
				this._role1 = null;
			}
		}

		internal virtual Label role2
		{
			get
			{
				return this._role2;
			}
			set
			{
				this._role2 = null;
				this._role2 = value;
				this._role2 = null;
			}
		}

		internal virtual Label role3
		{
			get
			{
				return this._role3;
			}
			set
			{
				this._role3 = null;
				this._role3 = value;
				this._role3 = null;
			}
		}

		internal virtual Label role4
		{
			get
			{
				return this._role4;
			}
			set
			{
				this._role4 = null;
				this._role4 = value;
				this._role4 = null;
			}
		}

		internal virtual Label role5
		{
			get
			{
				return this._role5;
			}
			set
			{
				this._role5 = null;
				this._role5 = value;
				this._role5 = null;
			}
		}

		public Summary1()
		{
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
			this.p5_name_label = new Label();
			this.p4_name_label = new Label();
			this.p3_name_label = new Label();
			this.p2_name_label = new Label();
			this.p1_name_label = new Label();
			this.current1 = new Label();
			this.cur1 = new Label();
			this.cur2 = new Label();
			this.cur3 = new Label();
			this.cur4 = new Label();
			this.cur5 = new Label();
			this.gov1 = new Label();
			this.role1 = new Label();
			this.role2 = new Label();
			this.role3 = new Label();
			this.role4 = new Label();
			this.role5 = new Label();
			this.gov2 = new Label();
			this.gov3 = new Label();
			this.gov4 = new Label();
			this.gov5 = new Label();
			this.SuspendLayout();
			this.p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p5_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = this.p5_name_label;
			Point point = new Point(152, 216);
			p5NameLabel.Location = point;
			this.p5_name_label.Name = "p5_name_label";
			Label label = this.p5_name_label;
			Size size = new Size(120, 23);
			label.Size = size;
			this.p5_name_label.TabIndex = 13;
			this.p5_name_label.Text = "Player5";
			this.p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p4_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = this.p4_name_label;
			point = new Point(152, 176);
			p4NameLabel.Location = point;
			this.p4_name_label.Name = "p4_name_label";
			Label p4NameLabel1 = this.p4_name_label;
			size = new Size(120, 23);
			p4NameLabel1.Size = size;
			this.p4_name_label.TabIndex = 12;
			this.p4_name_label.Text = "Player4";
			this.p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p3_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = this.p3_name_label;
			point = new Point(152, 136);
			p3NameLabel.Location = point;
			this.p3_name_label.Name = "p3_name_label";
			Label p3NameLabel1 = this.p3_name_label;
			size = new Size(120, 23);
			p3NameLabel1.Size = size;
			this.p3_name_label.TabIndex = 11;
			this.p3_name_label.Text = "Player3";
			this.p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p2_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = this.p2_name_label;
			point = new Point(152, 96);
			p2NameLabel.Location = point;
			this.p2_name_label.Name = "p2_name_label";
			Label p2NameLabel1 = this.p2_name_label;
			size = new Size(120, 23);
			p2NameLabel1.Size = size;
			this.p2_name_label.TabIndex = 10;
			this.p2_name_label.Text = "Player2";
			this.p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p1_name_label.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = this.p1_name_label;
			point = new Point(152, 56);
			p1NameLabel.Location = point;
			this.p1_name_label.Name = "p1_name_label";
			Label p1NameLabel1 = this.p1_name_label;
			size = new Size(120, 23);
			p1NameLabel1.Size = size;
			this.p1_name_label.TabIndex=9;
			this.p1_name_label.Text = "Player1";
			this.p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.current1.BorderStyle = BorderStyle.Fixed3D;
			this.current1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.current1;
			point = new Point(72, 24);
			label1.Location = point;
			this.current1.Name = "current1";
			Label label2 = this.current1;
			size = new Size(74, 23);
			label2.Size = size;
			this.current1.TabIndex = 14;
			this.current1.Text = "Current";
			this.current1.TextAlign = ContentAlignment.MiddleCenter;
			this.cur1.BorderStyle = BorderStyle.Fixed3D;
			this.cur1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label3 = this.cur1;
			point = new Point(72, 56);
			label3.Location = point;
			this.cur1.Name = "cur1";
			Label label4 = this.cur1;
			size = new Size(74, 23);
			label4.Size = size;
			this.cur1.TabIndex = 16;
			this.cur1.Text = "-->";
			this.cur1.TextAlign = ContentAlignment.MiddleCenter;
			this.cur2.BorderStyle = BorderStyle.Fixed3D;
			this.cur2.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label5 = this.cur2;
			point = new Point(72, 96);
			label5.Location = point;
			this.cur2.Name = "cur2";
			Label label6 = this.cur2;
			size = new Size(74, 23);
			label6.Size = size;
			this.cur2.TabIndex = 17;
			this.cur2.Text = "-->";
			this.cur2.TextAlign = ContentAlignment.MiddleCenter;
			this.cur3.BorderStyle = BorderStyle.Fixed3D;
			this.cur3.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label7 = this.cur3;
			point = new Point(72, 136);
			label7.Location = point;
			this.cur3.Name = "cur3";
			Label label8 = this.cur3;
			size = new Size(74, 23);
			label8.Size = size;
			this.cur3.TabIndex = 18;
			this.cur3.Text = "-->";
			this.cur3.TextAlign = ContentAlignment.MiddleCenter;
			this.cur4.BorderStyle = BorderStyle.Fixed3D;
			this.cur4.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label9 = this.cur4;
			point = new Point(72, 176);
			label9.Location = point;
			this.cur4.Name = "cur4";
			Label label10 = this.cur4;
			size = new Size(74, 23);
			label10.Size = size;
			this.cur4.TabIndex = 19;
			this.cur4.Text = "-->";
			this.cur4.TextAlign = ContentAlignment.MiddleCenter;
			this.cur5.BorderStyle = BorderStyle.Fixed3D;
			this.cur5.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label11 = this.cur5;
			point = new Point(72, 216);
			label11.Location = point;
			this.cur5.Name = "cur5";
			Label label12 = this.cur5;
			size = new Size(74, 23);
			label12.Size = size;
			this.cur5.TabIndex = 20;
			this.cur5.Text = "-->";
			this.cur5.TextAlign = ContentAlignment.MiddleCenter;
			this.gov1.BorderStyle = BorderStyle.Fixed3D;
			this.gov1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label13 = this.gov1;
			point = new Point(8, 56);
			label13.Location = point;
			this.gov1.Name = "gov1";
			Label label14 = this.gov1;
			size = new Size(56, 23);
			label14.Size = size;
			this.gov1.TabIndex = 21;
			this.gov1.Text = "Gov";
			this.gov1.TextAlign = ContentAlignment.MiddleCenter;
			this.role1.BorderStyle = BorderStyle.Fixed3D;
			this.role1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label15 = this.role1;
			point = new Point(280, 56);
			label15.Location = point;
			this.role1.Name = "role1";
			Label label16 = this.role1;
			size = new Size(74, 23);
			label16.Size = size;
			this.role1.TabIndex = 22;
			this.role1.Text = "Role";
			this.role1.TextAlign = ContentAlignment.MiddleCenter;
			this.role2.BorderStyle = BorderStyle.Fixed3D;
			this.role2.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label17 = this.role2;
			point = new Point(280, 96);
			label17.Location = point;
			this.role2.Name = "role2";
			Label label18 = this.role2;
			size = new Size(74, 23);
			label18.Size = size;
			this.role2.TabIndex = 23;
			this.role2.Text = "Role";
			this.role2.TextAlign = ContentAlignment.MiddleCenter;
			this.role3.BorderStyle = BorderStyle.Fixed3D;
			this.role3.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label19 = this.role3;
			point = new Point(280, 136);
			label19.Location = point;
			this.role3.Name = "role3";
			Label label20 = this.role3;
			size = new Size(74, 23);
			label20.Size = size;
			this.role3.TabIndex = 24;
			this.role3.Text = "Role";
			this.role3.TextAlign = ContentAlignment.MiddleCenter;
			this.role4.BorderStyle = BorderStyle.Fixed3D;
			this.role4.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label21 = this.role4;
			point = new Point(280, 176);
			label21.Location = point;
			this.role4.Name = "role4";
			Label label22 = this.role4;
			size = new Size(74, 23);
			label22.Size = size;
			this.role4.TabIndex = 25;
			this.role4.Text = "Role";
			this.role4.TextAlign = ContentAlignment.MiddleCenter;
			this.role5.BorderStyle = BorderStyle.Fixed3D;
			this.role5.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label23 = this.role5;
			point = new Point(280, 216);
			label23.Location = point;
			this.role5.Name = "role5";
			Label label24 = this.role5;
			size = new Size(74, 23);
			label24.Size = size;
			this.role5.TabIndex = 26;
			this.role5.Text = "Role";
			this.role5.TextAlign = ContentAlignment.MiddleCenter;
			this.gov2.BorderStyle = BorderStyle.Fixed3D;
			this.gov2.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label25 = this.gov2;
			point = new Point(8, 96);
			label25.Location = point;
			this.gov2.Name = "gov2";
			Label label26 = this.gov2;
			size = new Size(56, 23);
			label26.Size = size;
			this.gov2.TabIndex = 27;
			this.gov2.Text = "Gov";
			this.gov2.TextAlign = ContentAlignment.MiddleCenter;
			this.gov3.BorderStyle = BorderStyle.Fixed3D;
			this.gov3.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label27 = this.gov3;
			point = new Point(8, 136);
			label27.Location = point;
			this.gov3.Name = "gov3";
			Label label28 = this.gov3;
			size = new Size(56, 23);
			label28.Size = size;
			this.gov3.TabIndex = 28;
			this.gov3.Text = "Gov";
			this.gov3.TextAlign = ContentAlignment.MiddleCenter;
			this.gov4.BorderStyle = BorderStyle.Fixed3D;
			this.gov4.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label29 = this.gov4;
			point = new Point(8, 176);
			label29.Location = point;
			this.gov4.Name = "gov4";
			Label label30 = this.gov4;
			size = new Size(56, 23);
			label30.Size = size;
			this.gov4.TabIndex = 29;
			this.gov4.Text = "Gov";
			this.gov4.TextAlign = ContentAlignment.MiddleCenter;
			this.gov5.BorderStyle = BorderStyle.Fixed3D;
			this.gov5.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label31 = this.gov5;
			point = new Point(8, 216);
			label31.Location = point;
			this.gov5.Name = "gov5";
			Label label32 = this.gov5;
			size = new Size(56, 23);
			label32.Size = size;
			this.gov5.TabIndex = 30;
			this.gov5.Text = "Gov";
			this.gov5.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(384, 266);
			this.ClientSize = size;
			this.Controls.Add(this.gov5);
			this.Controls.Add(this.gov4);
			this.Controls.Add(this.gov3);
			this.Controls.Add(this.gov2);
			this.Controls.Add(this.role5);
			this.Controls.Add(this.role4);
			this.Controls.Add(this.role3);
			this.Controls.Add(this.role2);
			this.Controls.Add(this.role1);
			this.Controls.Add(this.gov1);
			this.Controls.Add(this.cur5);
			this.Controls.Add(this.cur4);
			this.Controls.Add(this.cur3);
			this.Controls.Add(this.cur2);
			this.Controls.Add(this.cur1);
			this.Controls.Add(this.current1);
			this.Controls.Add(this.p5_name_label);
			this.Controls.Add(this.p4_name_label);
			this.Controls.Add(this.p3_name_label);
			this.Controls.Add(this.p2_name_label);
			this.Controls.Add(this.p1_name_label);
			this.Name = "Summary1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Summary";
			this.ResumeLayout(false);
		}
	}
}
