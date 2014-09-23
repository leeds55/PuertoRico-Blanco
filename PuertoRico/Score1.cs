using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Score1 : Form
	{
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("p5_vp_total_label")]
		private Label _p5_vp_total_label;

		[AccessedThroughProperty("p5_vp_chips_label")]
		private Label _p5_vp_chips_label;

		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[AccessedThroughProperty("p5_vp_buildings_label")]
		private Label _p5_vp_buildings_label;

		[AccessedThroughProperty("p5_tie_breaker_label")]
		private Label _p5_tie_breaker_label;

		[AccessedThroughProperty("p4_vp_total_label")]
		private Label _p4_vp_total_label;

		[AccessedThroughProperty("p4_vp_chips_label")]
		private Label _p4_vp_chips_label;

		[AccessedThroughProperty("p4_vp_buildings_label")]
		private Label _p4_vp_buildings_label;

		[AccessedThroughProperty("p4_tie_breaker_label")]
		private Label _p4_tie_breaker_label;

		[AccessedThroughProperty("groupbox5")]
		private GroupBox _groupbox5;

		[AccessedThroughProperty("p3_vp_total_label")]
		private Label _p3_vp_total_label;

		[AccessedThroughProperty("p3_vp_chips_label")]
		private Label _p3_vp_chips_label;

		[AccessedThroughProperty("p3_vp_buildings_label")]
		private Label _p3_vp_buildings_label;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[AccessedThroughProperty("p5_name_label")]
		private Label _p5_name_label;

		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[AccessedThroughProperty("p4_name_label")]
		private Label _p4_name_label;

		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[AccessedThroughProperty("p3_name_label")]
		private Label _p3_name_label;

		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[AccessedThroughProperty("p2_name_label")]
		private Label _p2_name_label;

		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[AccessedThroughProperty("p1_name_label")]
		private Label _p1_name_label;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("groupbox4")]
		private GroupBox _groupbox4;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("p3_tie_breaker_label")]
		private Label _p3_tie_breaker_label;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("p1_vp_total_label")]
		private Label _p1_vp_total_label;

		[AccessedThroughProperty("p1_vp_chips_label")]
		private Label _p1_vp_chips_label;

		[AccessedThroughProperty("p1_vp_buildings_label")]
		private Label _p1_vp_buildings_label;

		[AccessedThroughProperty("p2_vp_total_label")]
		private Label _p2_vp_total_label;

		[AccessedThroughProperty("p1_tie_breaker_label")]
		private Label _p1_tie_breaker_label;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("p2_tie_breaker_label")]
		private Label _p2_tie_breaker_label;

		[AccessedThroughProperty("p2_vp_buildings_label")]
		private Label _p2_vp_buildings_label;

		[AccessedThroughProperty("p2_vp_chips_label")]
		private Label _p2_vp_chips_label;

		private IContainer components;

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

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return _GroupBox2;
			}
			set
			{
				_GroupBox2 = value;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			get
			{
				return _GroupBox3;
			}
			set
			{
				_GroupBox3 = value;
			}
		}

		internal virtual GroupBox groupbox4
		{
			get
			{
				return _groupbox4;
			}
			set
			{
				_groupbox4 = value;
			}
		}

		internal virtual GroupBox groupbox5
		{
			get
			{
				return _groupbox5;
			}
			set
			{
				_groupbox5 = value;
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

		internal virtual Label Label12
		{
			get
			{
				return _Label12;
			}
			set
			{
				_Label12 = value;
			}
		}

		internal virtual Label Label13
		{
			get
			{
				return _Label13;
			}
			set
			{
				_Label13 = value;
			}
		}

		internal virtual Label Label14
		{
			get
			{
				return _Label14;
			}
			set
			{
				_Label14 = value;
			}
		}

		internal virtual Label Label15
		{
			get
			{
				return _Label15;
			}
			set
			{
				_Label15 = value;
			}
		}

		internal virtual Label Label16
		{
			get
			{
				return _Label16;
			}
			set
			{
				_Label16 = value;
			}
		}

		internal virtual Label Label17
		{
			get
			{
				return _Label17;
			}
			set
			{
				_Label17 = value;
			}
		}

		internal virtual Label Label18
		{
			get
			{
				return _Label18;
			}
			set
			{
				_Label18 = value;
			}
		}

		internal virtual Label Label19
		{
			get
			{
				return _Label19;
			}
			set
			{
				_Label19 = value;
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

		internal virtual Label Label20
		{
			get
			{
				return _Label20;
			}
			set
			{
				_Label20 = value;
			}
		}

		internal virtual Label Label21
		{
			get
			{
				return _Label21;
			}
			set
			{
				_Label21 = value;
			}
		}

		internal virtual Label Label22
		{
			get
			{
				return _Label22;
			}
			set
			{
				_Label22 = value;
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

		internal virtual Label p1_tie_breaker_label
		{
			get
			{
				return _p1_tie_breaker_label;
			}
			set
			{
				_p1_tie_breaker_label = value;
			}
		}

		internal virtual Label p1_vp_buildings_label
		{
			get
			{
				return _p1_vp_buildings_label;
			}
			set
			{
				_p1_vp_buildings_label = value;
			}
		}

		internal virtual Label p1_vp_chips_label
		{
			get
			{
				return _p1_vp_chips_label;
			}
			set
			{
				_p1_vp_chips_label = value;
			}
		}

		internal virtual Label p1_vp_total_label
		{
			get
			{
				return _p1_vp_total_label;
			}
			set
			{
				_p1_vp_total_label = value;
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

		internal virtual Label p2_tie_breaker_label
		{
			get
			{
				return _p2_tie_breaker_label;
			}
			set
			{
				_p2_tie_breaker_label = value;
			}
		}

		internal virtual Label p2_vp_buildings_label
		{
			get
			{
				return _p2_vp_buildings_label;
			}
			set
			{
				_p2_vp_buildings_label = value;
			}
		}

		internal virtual Label p2_vp_chips_label
		{
			get
			{
				return _p2_vp_chips_label;
			}
			set
			{
				_p2_vp_chips_label = value;
			}
		}

		internal virtual Label p2_vp_total_label
		{
			get
			{
				return _p2_vp_total_label;
			}
			set
			{
				_p2_vp_total_label = value;
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

		internal virtual Label p3_tie_breaker_label
		{
			get
			{
				return _p3_tie_breaker_label;
			}
			set
			{
				_p3_tie_breaker_label = value;
			}
		}

		internal virtual Label p3_vp_buildings_label
		{
			get
			{
				return _p3_vp_buildings_label;
			}
			set
			{
				_p3_vp_buildings_label = value;
			}
		}

		internal virtual Label p3_vp_chips_label
		{
			get
			{
				return _p3_vp_chips_label;
			}
			set
			{
				_p3_vp_chips_label = value;
			}
		}

		internal virtual Label p3_vp_total_label
		{
			get
			{
				return _p3_vp_total_label;
			}
			set
			{
				_p3_vp_total_label = value;
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

		internal virtual Label p4_tie_breaker_label
		{
			get
			{
				return _p4_tie_breaker_label;
			}
			set
			{
				_p4_tie_breaker_label = value;
			}
		}

		internal virtual Label p4_vp_buildings_label
		{
			get
			{
				return _p4_vp_buildings_label;
			}
			set
			{
				_p4_vp_buildings_label = value;
			}
		}

		internal virtual Label p4_vp_chips_label
		{
			get
			{
				return _p4_vp_chips_label;
			}
			set
			{
				_p4_vp_chips_label = value;
			}
		}

		internal virtual Label p4_vp_total_label
		{
			get
			{
				return _p4_vp_total_label;
			}
			set
			{
				_p4_vp_total_label = value;
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

		internal virtual Label p5_tie_breaker_label
		{
			get
			{
				return _p5_tie_breaker_label;
			}
			set
			{
				_p5_tie_breaker_label = value;
			}
		}

		internal virtual Label p5_vp_buildings_label
		{
			get
			{
				return _p5_vp_buildings_label;
			}
			set
			{
				_p5_vp_buildings_label = value;
			}
		}

		internal virtual Label p5_vp_chips_label
		{
			get
			{
				return _p5_vp_chips_label;
			}
			set
			{
				_p5_vp_chips_label = value;
			}
		}

		internal virtual Label p5_vp_total_label
		{
			get
			{
				return _p5_vp_total_label;
			}
			set
			{
				_p5_vp_total_label = value;
			}
		}

		public Score1()
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
			Label5 = new Label();
			Label4 = new Label();
			Label1 = new Label();
			Label2 = new Label();
			groupbox4 = new GroupBox();
			p4_tie_breaker_label = new Label();
			p4_vp_buildings_label = new Label();
			p4_vp_chips_label = new Label();
			p4_vp_total_label = new Label();
			Label13 = new Label();
			Label14 = new Label();
			Label15 = new Label();
			Label16 = new Label();
			groupbox5 = new GroupBox();
			p5_vp_buildings_label = new Label();
			p5_tie_breaker_label = new Label();
			p5_vp_total_label = new Label();
			p5_vp_chips_label = new Label();
			Label20 = new Label();
			Label19 = new Label();
			Label17 = new Label();
			Label18 = new Label();
			p1_vp_total_label = new Label();
			p1_vp_chips_label = new Label();
			p1_vp_buildings_label = new Label();
			p1_tie_breaker_label = new Label();
			p2_tie_breaker_label = new Label();
			p2_vp_buildings_label = new Label();
			p2_vp_chips_label = new Label();
			p2_vp_total_label = new Label();
			p3_tie_breaker_label = new Label();
			p3_vp_buildings_label = new Label();
			p3_vp_chips_label = new Label();
			p3_vp_total_label = new Label();
			GroupBox1 = new GroupBox();
			GroupBox2 = new GroupBox();
			Label8 = new Label();
			Label7 = new Label();
			Label6 = new Label();
			Label3 = new Label();
			GroupBox3 = new GroupBox();
			Label10 = new Label();
			Label9 = new Label();
			Label12 = new Label();
			Label11 = new Label();
			Label21 = new Label();
			Label22 = new Label();
			groupbox4.SuspendLayout();
			groupbox5.SuspendLayout();
			GroupBox1.SuspendLayout();
			GroupBox2.SuspendLayout();
			GroupBox3.SuspendLayout();
			SuspendLayout();
			p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			p5_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = p5_name_label;
			Point point = new Point(8, 24);
			p5NameLabel.Location = point;
			p5_name_label.Name="p5_name_label";
			Label label = p5_name_label;
			Size size = new Size(120, 23);
			label.Size = size;
			p5_name_label.TabIndex=18;
			p5_name_label.Text="Player5";
			p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			p4_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = p4_name_label;
			point = new Point(8, 24);
			p4NameLabel.Location = point;
			p4_name_label.Name="p4_name_label";
			Label p4NameLabel1 = p4_name_label;
			size = new Size(120, 23);
			p4NameLabel1.Size = size;
			p4_name_label.TabIndex=17;
			p4_name_label.Text="Player4";
			p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			p3_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = p3_name_label;
			point = new Point(8, 24);
			p3NameLabel.Location = point;
			p3_name_label.Name="p3_name_label";
			Label p3NameLabel1 = p3_name_label;
			size = new Size(120, 23);
			p3NameLabel1.Size = size;
			p3_name_label.TabIndex=16;
			p3_name_label.Text="Player3";
			p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			p2_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = p2_name_label;
			point = new Point(8, 24);
			p2NameLabel.Location = point;
			p2_name_label.Name="p2_name_label";
			Label p2NameLabel1 = p2_name_label;
			size = new Size(120, 23);
			p2NameLabel1.Size = size;
			p2_name_label.TabIndex=15;
			p2_name_label.Text="Player2";
			p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			p1_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = p1_name_label;
			point = new Point(8, 24);
			p1NameLabel.Location = point;
			p1_name_label.Name="p1_name_label";
			Label p1NameLabel1 = p1_name_label;
			size = new Size(120, 23);
			p1NameLabel1.Size = size;
			p1_name_label.TabIndex=14;
			p1_name_label.Text="Player1";
			p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			Label label5 = Label5;
			point = new Point(16, 72);
			label5.Location = point;
			Label5.Name="Label5";
			Label label51 = Label5;
			size = new Size(72, 16);
			label51.Size = size;
			Label5.TabIndex=25;
			Label5.Text="VP Total";
			Label5.TextAlign = ContentAlignment.MiddleCenter;
			Label label4 = Label4;
			point = new Point(16, 128);
			label4.Location = point;
			Label4.Name="Label4";
			Label label41 = Label4;
			size = new Size(72, 16);
			label41.Size = size;
			Label4.TabIndex=24;
			Label4.Text="VP Chips";
			Label4.TextAlign = ContentAlignment.MiddleCenter;
			Label label1 = Label1;
			point = new Point(16, 184);
			label1.Location = point;
			Label1.Name="Label1";
			Label label11 = Label1;
			size = new Size(72, 16);
			label11.Size = size;
			Label1.TabIndex=26;
			Label1.Text="VP Buildings";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			Label label2 = Label2;
			point = new Point(16, 240);
			label2.Location = point;
			Label2.Name="Label2";
			Label label21 = Label2;
			size = new Size(72, 24);
			label21.Size = size;
			Label2.TabIndex=27;
			Label2.Text="Goods / Doubloons";
			Label2.TextAlign = ContentAlignment.MiddleCenter;
			groupbox4.Controls.Add(p4_name_label);
			groupbox4.Controls.Add(p4_tie_breaker_label);
			groupbox4.Controls.Add(p4_vp_buildings_label);
			groupbox4.Controls.Add(p4_vp_chips_label);
			groupbox4.Controls.Add(p4_vp_total_label);
			groupbox4.Controls.Add(Label13);
			groupbox4.Controls.Add(Label14);
			groupbox4.Controls.Add(Label15);
			groupbox4.Controls.Add(Label16);
			GroupBox groupBox = groupbox4;
			point = new Point(504, 104);
			groupBox.Location = point;
			groupbox4.Name="groupbox4";
			GroupBox groupBox1 = groupbox4;
			size = new Size(136, 288);
			groupBox1.Size = size;
			groupbox4.TabIndex=28;
			groupbox4.TabStop = false;
			p4_tie_breaker_label.BackColor=Color.White;
			p4_tie_breaker_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4TieBreakerLabel = p4_tie_breaker_label;
			point = new Point(88, 232);
			p4TieBreakerLabel.Location = point;
			p4_tie_breaker_label.Name="p4_tie_breaker_label";
			Label p4TieBreakerLabel1 = p4_tie_breaker_label;
			size = new Size(36, 32);
			p4TieBreakerLabel1.Size = size;
			p4_tie_breaker_label.TabIndex=44;
			p4_tie_breaker_label.Text="99";
			p4_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_vp_buildings_label.BackColor=Color.White;
			p4_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p4VpBuildingsLabel = p4_vp_buildings_label;
			point = new Point(88, 176);
			p4VpBuildingsLabel.Location = point;
			p4_vp_buildings_label.Name="p4_vp_buildings_label";
			Label p4VpBuildingsLabel1 = p4_vp_buildings_label;
			size = new Size(36, 32);
			p4VpBuildingsLabel1.Size = size;
			p4_vp_buildings_label.TabIndex=43;
			p4_vp_buildings_label.Text="99";
			p4_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_vp_chips_label.BackColor=Color.White;
			p4_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p4VpChipsLabel = p4_vp_chips_label;
			point = new Point(88, 120);
			p4VpChipsLabel.Location = point;
			p4_vp_chips_label.Name="p4_vp_chips_label";
			Label p4VpChipsLabel1 = p4_vp_chips_label;
			size = new Size(36, 32);
			p4VpChipsLabel1.Size = size;
			p4_vp_chips_label.TabIndex=42;
			p4_vp_chips_label.Text="99";
			p4_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			p4_vp_total_label.BackColor=Color.White;
			p4_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p4VpTotalLabel = p4_vp_total_label;
			point = new Point(88, 64);
			p4VpTotalLabel.Location = point;
			p4_vp_total_label.Name="p4_vp_total_label";
			Label p4VpTotalLabel1 = p4_vp_total_label;
			size = new Size(36, 32);
			p4VpTotalLabel1.Size = size;
			p4_vp_total_label.TabIndex=41;
			p4_vp_total_label.Text="99";
			p4_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			Label label13 = Label13;
			point = new Point(16, 128);
			label13.Location = point;
			Label13.Name="Label13";
			Label label131 = Label13;
			size = new Size(72, 16);
			label131.Size = size;
			Label13.TabIndex=50;
			Label13.Text="VP Chips";
			Label13.TextAlign = ContentAlignment.MiddleCenter;
			Label label14 = Label14;
			point = new Point(16, 72);
			label14.Location = point;
			Label14.Name="Label14";
			Label label141 = Label14;
			size = new Size(72, 16);
			label141.Size = size;
			Label14.TabIndex=51;
			Label14.Text="VP Total";
			Label14.TextAlign = ContentAlignment.MiddleCenter;
			Label label15 = Label15;
			point = new Point(16, 240);
			label15.Location = point;
			Label15.Name="Label15";
			Label label151 = Label15;
			size = new Size(72, 24);
			label151.Size = size;
			Label15.TabIndex=53;
			Label15.Text="Goods / Doubloons";
			Label15.TextAlign = ContentAlignment.MiddleCenter;
			Label label16 = Label16;
			point = new Point(16, 184);
			label16.Location = point;
			Label16.Name="Label16";
			Label label161 = Label16;
			size = new Size(72, 16);
			label161.Size = size;
			Label16.TabIndex=52;
			Label16.Text="VP Buildings";
			Label16.TextAlign = ContentAlignment.MiddleCenter;
			groupbox5.Controls.Add(p5_name_label);
			groupbox5.Controls.Add(p5_vp_buildings_label);
			groupbox5.Controls.Add(p5_tie_breaker_label);
			groupbox5.Controls.Add(p5_vp_total_label);
			groupbox5.Controls.Add(p5_vp_chips_label);
			groupbox5.Controls.Add(Label20);
			groupbox5.Controls.Add(Label19);
			groupbox5.Controls.Add(Label17);
			groupbox5.Controls.Add(Label18);
			GroupBox groupBox2 = groupbox5;
			point = new Point(648, 104);
			groupBox2.Location = point;
			groupbox5.Name="groupbox5";
			GroupBox groupBox3 = groupbox5;
			size = new Size(136, 288);
			groupBox3.Size = size;
			groupbox5.TabIndex=29;
			groupbox5.TabStop = false;
			p5_vp_buildings_label.BackColor=Color.White;
			p5_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5VpBuildingsLabel = p5_vp_buildings_label;
			point = new Point(88, 176);
			p5VpBuildingsLabel.Location = point;
			p5_vp_buildings_label.Name="p5_vp_buildings_label";
			Label p5VpBuildingsLabel1 = p5_vp_buildings_label;
			size = new Size(36, 32);
			p5VpBuildingsLabel1.Size = size;
			p5_vp_buildings_label.TabIndex=47;
			p5_vp_buildings_label.Text="99";
			p5_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_tie_breaker_label.BackColor=Color.White;
			p5_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5TieBreakerLabel = p5_tie_breaker_label;
			point = new Point(88, 232);
			p5TieBreakerLabel.Location = point;
			p5_tie_breaker_label.Name="p5_tie_breaker_label";
			Label p5TieBreakerLabel1 = p5_tie_breaker_label;
			size = new Size(36, 32);
			p5TieBreakerLabel1.Size = size;
			p5_tie_breaker_label.TabIndex=48;
			p5_tie_breaker_label.Text="99";
			p5_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_vp_total_label.BackColor=Color.White;
			p5_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5VpTotalLabel = p5_vp_total_label;
			point = new Point(88, 64);
			p5VpTotalLabel.Location = point;
			p5_vp_total_label.Name="p5_vp_total_label";
			Label p5VpTotalLabel1 = p5_vp_total_label;
			size = new Size(36, 32);
			p5VpTotalLabel1.Size = size;
			p5_vp_total_label.TabIndex=45;
			p5_vp_total_label.Text="99";
			p5_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p5_vp_chips_label.BackColor=Color.White;
			p5_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5VpChipsLabel = p5_vp_chips_label;
			point = new Point(88, 120);
			p5VpChipsLabel.Location = point;
			p5_vp_chips_label.Name="p5_vp_chips_label";
			Label p5VpChipsLabel1 = p5_vp_chips_label;
			size = new Size(36, 32);
			p5VpChipsLabel1.Size = size;
			p5_vp_chips_label.TabIndex=46;
			p5_vp_chips_label.Text="99";
			p5_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			Label label20 = Label20;
			point = new Point(16, 184);
			label20.Location = point;
			Label20.Name="Label20";
			Label label201 = Label20;
			size = new Size(72, 16);
			label201.Size = size;
			Label20.TabIndex=52;
			Label20.Text="VP Buildings";
			Label20.TextAlign = ContentAlignment.MiddleCenter;
			Label label19 = Label19;
			point = new Point(16, 240);
			label19.Location = point;
			Label19.Name="Label19";
			Label label191 = Label19;
			size = new Size(72, 24);
			label191.Size = size;
			Label19.TabIndex=53;
			Label19.Text="Goods / Doubloons";
			Label19.TextAlign = ContentAlignment.MiddleCenter;
			Label label17 = Label17;
			point = new Point(16, 128);
			label17.Location = point;
			Label17.Name="Label17";
			Label label171 = Label17;
			size = new Size(72, 16);
			label171.Size = size;
			Label17.TabIndex=50;
			Label17.Text="VP Chips";
			Label17.TextAlign = ContentAlignment.MiddleCenter;
			Label label18 = Label18;
			point = new Point(16, 72);
			label18.Location = point;
			Label18.Name="Label18";
			Label label181 = Label18;
			size = new Size(72, 16);
			label181.Size = size;
			Label18.TabIndex=51;
			Label18.Text="VP Total";
			Label18.TextAlign = ContentAlignment.MiddleCenter;
			p1_vp_total_label.BackColor=Color.White;
			p1_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1VpTotalLabel = p1_vp_total_label;
			point = new Point(88, 64);
			p1VpTotalLabel.Location = point;
			p1_vp_total_label.Name="p1_vp_total_label";
			Label p1VpTotalLabel1 = p1_vp_total_label;
			size = new Size(36, 32);
			p1VpTotalLabel1.Size = size;
			p1_vp_total_label.TabIndex=26;
			p1_vp_total_label.Text="99";
			p1_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_vp_chips_label.BackColor=Color.White;
			p1_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1VpChipsLabel = p1_vp_chips_label;
			point = new Point(88, 120);
			p1VpChipsLabel.Location = point;
			p1_vp_chips_label.Name="p1_vp_chips_label";
			Label p1VpChipsLabel1 = p1_vp_chips_label;
			size = new Size(36, 32);
			p1VpChipsLabel1.Size = size;
			p1_vp_chips_label.TabIndex=30;
			p1_vp_chips_label.Text="99";
			p1_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_vp_buildings_label.BackColor=Color.White;
			p1_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1VpBuildingsLabel = p1_vp_buildings_label;
			point = new Point(88, 176);
			p1VpBuildingsLabel.Location = point;
			p1_vp_buildings_label.Name="p1_vp_buildings_label";
			Label p1VpBuildingsLabel1 = p1_vp_buildings_label;
			size = new Size(36, 32);
			p1VpBuildingsLabel1.Size = size;
			p1_vp_buildings_label.TabIndex=31;
			p1_vp_buildings_label.Text="99";
			p1_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			p1_tie_breaker_label.BackColor=Color.White;
			p1_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1TieBreakerLabel = p1_tie_breaker_label;
			point = new Point(88, 232);
			p1TieBreakerLabel.Location = point;
			p1_tie_breaker_label.Name="p1_tie_breaker_label";
			Label p1TieBreakerLabel1 = p1_tie_breaker_label;
			size = new Size(36, 32);
			p1TieBreakerLabel1.Size = size;
			p1_tie_breaker_label.TabIndex=32;
			p1_tie_breaker_label.Text="99";
			p1_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_tie_breaker_label.BackColor=Color.White;
			p2_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2TieBreakerLabel = p2_tie_breaker_label;
			point = new Point(88, 232);
			p2TieBreakerLabel.Location = point;
			p2_tie_breaker_label.Name="p2_tie_breaker_label";
			Label p2TieBreakerLabel1 = p2_tie_breaker_label;
			size = new Size(36, 32);
			p2TieBreakerLabel1.Size = size;
			p2_tie_breaker_label.TabIndex=36;
			p2_tie_breaker_label.Text="99";
			p2_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_vp_buildings_label.BackColor=Color.White;
			p2_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2VpBuildingsLabel = p2_vp_buildings_label;
			point = new Point(88, 176);
			p2VpBuildingsLabel.Location = point;
			p2_vp_buildings_label.Name="p2_vp_buildings_label";
			Label p2VpBuildingsLabel1 = p2_vp_buildings_label;
			size = new Size(36, 32);
			p2VpBuildingsLabel1.Size = size;
			p2_vp_buildings_label.TabIndex=35;
			p2_vp_buildings_label.Text="99";
			p2_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_vp_chips_label.BackColor=Color.White;
			p2_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2VpChipsLabel = p2_vp_chips_label;
			point = new Point(88, 120);
			p2VpChipsLabel.Location = point;
			p2_vp_chips_label.Name="p2_vp_chips_label";
			Label p2VpChipsLabel1 = p2_vp_chips_label;
			size = new Size(36, 32);
			p2VpChipsLabel1.Size = size;
			p2_vp_chips_label.TabIndex=34;
			p2_vp_chips_label.Text="99";
			p2_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			p2_vp_total_label.BackColor=Color.White;
			p2_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2VpTotalLabel = p2_vp_total_label;
			point = new Point(88, 64);
			p2VpTotalLabel.Location = point;
			p2_vp_total_label.Name="p2_vp_total_label";
			Label p2VpTotalLabel1 = p2_vp_total_label;
			size = new Size(36, 32);
			p2VpTotalLabel1.Size = size;
			p2_vp_total_label.TabIndex=33;
			p2_vp_total_label.Text="99";
			p2_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_tie_breaker_label.BackColor=Color.White;
			p3_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3TieBreakerLabel = p3_tie_breaker_label;
			point = new Point(88, 232);
			p3TieBreakerLabel.Location = point;
			p3_tie_breaker_label.Name="p3_tie_breaker_label";
			Label p3TieBreakerLabel1 = p3_tie_breaker_label;
			size = new Size(36, 32);
			p3TieBreakerLabel1.Size = size;
			p3_tie_breaker_label.TabIndex=40;
			p3_tie_breaker_label.Text="99";
			p3_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_vp_buildings_label.BackColor=Color.White;
			p3_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3VpBuildingsLabel = p3_vp_buildings_label;
			point = new Point(88, 176);
			p3VpBuildingsLabel.Location = point;
			p3_vp_buildings_label.Name="p3_vp_buildings_label";
			Label p3VpBuildingsLabel1 = p3_vp_buildings_label;
			size = new Size(36, 32);
			p3VpBuildingsLabel1.Size = size;
			p3_vp_buildings_label.TabIndex=39;
			p3_vp_buildings_label.Text="99";
			p3_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_vp_chips_label.BackColor=Color.White;
			p3_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3VpChipsLabel = p3_vp_chips_label;
			point = new Point(88, 120);
			p3VpChipsLabel.Location = point;
			p3_vp_chips_label.Name="p3_vp_chips_label";
			Label p3VpChipsLabel1 = p3_vp_chips_label;
			size = new Size(36, 32);
			p3VpChipsLabel1.Size = size;
			p3_vp_chips_label.TabIndex=38;
			p3_vp_chips_label.Text="99";
			p3_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			p3_vp_total_label.BackColor=Color.White;
			p3_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3VpTotalLabel = p3_vp_total_label;
			point = new Point(88, 64);
			p3VpTotalLabel.Location = point;
			p3_vp_total_label.Name="p3_vp_total_label";
			Label p3VpTotalLabel1 = p3_vp_total_label;
			size = new Size(36, 32);
			p3VpTotalLabel1.Size = size;
			p3_vp_total_label.TabIndex=37;
			p3_vp_total_label.Text="99";
			p3_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			GroupBox1.Controls.Add(p1_tie_breaker_label);
			GroupBox1.Controls.Add(p1_name_label);
			GroupBox1.Controls.Add(p1_vp_total_label);
			GroupBox1.Controls.Add(p1_vp_chips_label);
			GroupBox1.Controls.Add(p1_vp_buildings_label);
			GroupBox1.Controls.Add(Label5);
			GroupBox1.Controls.Add(Label4);
			GroupBox1.Controls.Add(Label1);
			GroupBox1.Controls.Add(Label2);
			GroupBox groupBox11 = GroupBox1;
			point = new Point(72, 104);
			groupBox11.Location = point;
			GroupBox1.Name="GroupBox1";
			GroupBox groupBox12 = GroupBox1;
			size = new Size(136, 288);
			groupBox12.Size = size;
			GroupBox1.TabIndex=42;
			GroupBox1.TabStop = false;
			GroupBox2.Controls.Add(p2_tie_breaker_label);
			GroupBox2.Controls.Add(p2_vp_buildings_label);
			GroupBox2.Controls.Add(p2_vp_chips_label);
			GroupBox2.Controls.Add(p2_vp_total_label);
			GroupBox2.Controls.Add(p2_name_label);
			GroupBox2.Controls.Add(Label8);
			GroupBox2.Controls.Add(Label7);
			GroupBox2.Controls.Add(Label6);
			GroupBox2.Controls.Add(Label3);
			GroupBox groupBox21 = GroupBox2;
			point = new Point(216, 104);
			groupBox21.Location = point;
			GroupBox2.Name="GroupBox2";
			GroupBox groupBox22 = GroupBox2;
			size = new Size(136, 288);
			groupBox22.Size = size;
			GroupBox2.TabIndex=43;
			GroupBox2.TabStop = false;
			Label label8 = Label8;
			point = new Point(16, 240);
			label8.Location = point;
			Label8.Name="Label8";
			Label label81 = Label8;
			size = new Size(72, 24);
			label81.Size = size;
			Label8.TabIndex=36;
			Label8.Text="Goods / Doubloons";
			Label8.TextAlign = ContentAlignment.MiddleCenter;
			Label label7 = Label7;
			point = new Point(16, 184);
			label7.Location = point;
			Label7.Name="Label7";
			Label label71 = Label7;
			size = new Size(72, 16);
			label71.Size = size;
			Label7.TabIndex=35;
			Label7.Text="VP Buildings";
			Label7.TextAlign = ContentAlignment.MiddleCenter;
			Label label6 = Label6;
			point = new Point(16, 128);
			label6.Location = point;
			Label6.Name="Label6";
			Label label61 = Label6;
			size = new Size(72, 16);
			label61.Size = size;
			Label6.TabIndex=33;
			Label6.Text="VP Chips";
			Label6.TextAlign = ContentAlignment.MiddleCenter;
			Label label3 = Label3;
			point = new Point(16, 72);
			label3.Location = point;
			Label3.Name="Label3";
			Label label31 = Label3;
			size = new Size(72, 16);
			label31.Size = size;
			Label3.TabIndex=34;
			Label3.Text="VP Total";
			Label3.TextAlign = ContentAlignment.MiddleCenter;
			GroupBox3.Controls.Add(p3_name_label);
			GroupBox3.Controls.Add(p3_tie_breaker_label);
			GroupBox3.Controls.Add(p3_vp_buildings_label);
			GroupBox3.Controls.Add(p3_vp_chips_label);
			GroupBox3.Controls.Add(p3_vp_total_label);
			GroupBox3.Controls.Add(Label10);
			GroupBox3.Controls.Add(Label9);
			GroupBox3.Controls.Add(Label12);
			GroupBox3.Controls.Add(Label11);
			GroupBox groupBox31 = GroupBox3;
			point = new Point(360, 104);
			groupBox31.Location = point;
			GroupBox3.Name="GroupBox3";
			GroupBox groupBox32 = GroupBox3;
			size = new Size(136, 288);
			groupBox32.Size = size;
			GroupBox3.TabIndex=44;
			GroupBox3.TabStop = false;
			Label label10 = Label10;
			point = new Point(16, 128);
			label10.Location = point;
			Label10.Name="Label10";
			Label label101 = Label10;
			size = new Size(72, 16);
			label101.Size = size;
			Label10.TabIndex=46;
			Label10.Text="VP Chips";
			Label10.TextAlign = ContentAlignment.MiddleCenter;
			Label label9 = Label9;
			point = new Point(16, 72);
			label9.Location = point;
			Label9.Name="Label9";
			Label label91 = Label9;
			size = new Size(72, 16);
			label91.Size = size;
			Label9.TabIndex=47;
			Label9.Text="VP Total";
			Label9.TextAlign = ContentAlignment.MiddleCenter;
			Label label12 = Label12;
			point = new Point(16, 240);
			label12.Location = point;
			Label12.Name="Label12";
			Label label121 = Label12;
			size = new Size(72, 24);
			label121.Size = size;
			Label12.TabIndex=49;
			Label12.Text="Goods / Doubloons";
			Label12.TextAlign = ContentAlignment.MiddleCenter;
			Label label111 = Label11;
			point = new Point(16, 184);
			label111.Location = point;
			Label11.Name="Label11";
			Label label112 = Label11;
			size = new Size(72, 16);
			label112.Size = size;
			Label11.TabIndex=48;
			Label11.Text="VP Buildings";
			Label11.TextAlign = ContentAlignment.MiddleCenter;
			Label label211 = Label21;
			point = new Point(8, 80);
			label211.Location = point;
			Label21.Name="Label21";
			Label label212 = Label21;
			size = new Size(56, 16);
			label212.Size = size;
			Label21.TabIndex=33;
			Label21.Text="WINNER";
			Label21.TextAlign = ContentAlignment.MiddleCenter;
			Label label22 = Label22;
			point = new Point(0, 240);
			label22.Location = point;
			Label22.Name="Label22";
			Label label221 = Label22;
			size = new Size(64, 32);
			label221.Size = size;
			Label22.TabIndex=45;
			Label22.Text="TIE BREAKER";
			Label22.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(792, 410);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(Label22);
			Controls.Add(GroupBox1);
			Controls.Add(groupbox5);
			Controls.Add(groupbox4);
			Controls.Add(GroupBox2);
			Controls.Add(GroupBox3);
			Controls.Add(Label21);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			size = new Size(800, 448);
			MaximumSize = size;
			size = new Size(800, 448);
			MinimumSize = size;
			Name="Score1";
			StartPosition = FormStartPosition.CenterScreen;
			Text="Puerto Rico Score";
			groupbox4.ResumeLayout(false);
			groupbox5.ResumeLayout(false);
			GroupBox1.ResumeLayout(false);
			GroupBox2.ResumeLayout(false);
			GroupBox3.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
