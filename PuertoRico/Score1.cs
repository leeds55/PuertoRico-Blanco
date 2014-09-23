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
				return this._GroupBox1;
			}
			set
			{
				this._GroupBox1 = null;
				this._GroupBox1 = value;
				this._GroupBox1 = null;
			}
		}

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			set
			{
				this._GroupBox2 = null;
				this._GroupBox2 = value;
				this._GroupBox2 = null;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			set
			{
				this._GroupBox3 = null;
				this._GroupBox3 = value;
				this._GroupBox3 = null;
			}
		}

		internal virtual GroupBox groupbox4
		{
			get
			{
				return this._groupbox4;
			}
			set
			{
				this._groupbox4 = null;
				this._groupbox4 = value;
				this._groupbox4 = null;
			}
		}

		internal virtual GroupBox groupbox5
		{
			get
			{
				return this._groupbox5;
			}
			set
			{
				this._groupbox5 = null;
				this._groupbox5 = value;
				this._groupbox5 = null;
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

		internal virtual Label Label10
		{
			get
			{
				return this._Label10;
			}
			set
			{
				this._Label10 = null;
				this._Label10 = value;
				this._Label10 = null;
			}
		}

		internal virtual Label Label11
		{
			get
			{
				return this._Label11;
			}
			set
			{
				this._Label11 = null;
				this._Label11 = value;
				this._Label11 = null;
			}
		}

		internal virtual Label Label12
		{
			get
			{
				return this._Label12;
			}
			set
			{
				this._Label12 = null;
				this._Label12 = value;
				this._Label12 = null;
			}
		}

		internal virtual Label Label13
		{
			get
			{
				return this._Label13;
			}
			set
			{
				this._Label13 = null;
				this._Label13 = value;
				this._Label13 = null;
			}
		}

		internal virtual Label Label14
		{
			get
			{
				return this._Label14;
			}
			set
			{
				this._Label14 = null;
				this._Label14 = value;
				this._Label14 = null;
			}
		}

		internal virtual Label Label15
		{
			get
			{
				return this._Label15;
			}
			set
			{
				this._Label15 = null;
				this._Label15 = value;
				this._Label15 = null;
			}
		}

		internal virtual Label Label16
		{
			get
			{
				return this._Label16;
			}
			set
			{
				this._Label16 = null;
				this._Label16 = value;
				this._Label16 = null;
			}
		}

		internal virtual Label Label17
		{
			get
			{
				return this._Label17;
			}
			set
			{
				this._Label17 = null;
				this._Label17 = value;
				this._Label17 = null;
			}
		}

		internal virtual Label Label18
		{
			get
			{
				return this._Label18;
			}
			set
			{
				this._Label18 = null;
				this._Label18 = value;
				this._Label18 = null;
			}
		}

		internal virtual Label Label19
		{
			get
			{
				return this._Label19;
			}
			set
			{
				this._Label19 = null;
				this._Label19 = value;
				this._Label19 = null;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			set
			{
				this._Label2 = null;
				this._Label2 = value;
				this._Label2 = null;
			}
		}

		internal virtual Label Label20
		{
			get
			{
				return this._Label20;
			}
			set
			{
				this._Label20 = null;
				this._Label20 = value;
				this._Label20 = null;
			}
		}

		internal virtual Label Label21
		{
			get
			{
				return this._Label21;
			}
			set
			{
				this._Label21 = null;
				this._Label21 = value;
				this._Label21 = null;
			}
		}

		internal virtual Label Label22
		{
			get
			{
				return this._Label22;
			}
			set
			{
				this._Label22 = null;
				this._Label22 = value;
				this._Label22 = null;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			set
			{
				this._Label3 = null;
				this._Label3 = value;
				this._Label3 = null;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			set
			{
				this._Label4 = null;
				this._Label4 = value;
				this._Label4 = null;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			set
			{
				this._Label5 = null;
				this._Label5 = value;
				this._Label5 = null;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			set
			{
				this._Label6 = null;
				this._Label6 = value;
				this._Label6 = null;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			set
			{
				this._Label7 = null;
				this._Label7 = value;
				this._Label7 = null;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			set
			{
				this._Label8 = null;
				this._Label8 = value;
				this._Label8 = null;
			}
		}

		internal virtual Label Label9
		{
			get
			{
				return this._Label9;
			}
			set
			{
				this._Label9 = null;
				this._Label9 = value;
				this._Label9 = null;
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

		internal virtual Label p1_tie_breaker_label
		{
			get
			{
				return this._p1_tie_breaker_label;
			}
			set
			{
				this._p1_tie_breaker_label = null;
				this._p1_tie_breaker_label = value;
				this._p1_tie_breaker_label = null;
			}
		}

		internal virtual Label p1_vp_buildings_label
		{
			get
			{
				return this._p1_vp_buildings_label;
			}
			set
			{
				this._p1_vp_buildings_label = null;
				this._p1_vp_buildings_label = value;
				this._p1_vp_buildings_label = null;
			}
		}

		internal virtual Label p1_vp_chips_label
		{
			get
			{
				return this._p1_vp_chips_label;
			}
			set
			{
				this._p1_vp_chips_label = null;
				this._p1_vp_chips_label = value;
				this._p1_vp_chips_label = null;
			}
		}

		internal virtual Label p1_vp_total_label
		{
			get
			{
				return this._p1_vp_total_label;
			}
			set
			{
				this._p1_vp_total_label = null;
				this._p1_vp_total_label = value;
				this._p1_vp_total_label = null;
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

		internal virtual Label p2_tie_breaker_label
		{
			get
			{
				return this._p2_tie_breaker_label;
			}
			set
			{
				this._p2_tie_breaker_label = null;
				this._p2_tie_breaker_label = value;
				this._p2_tie_breaker_label = null;
			}
		}

		internal virtual Label p2_vp_buildings_label
		{
			get
			{
				return this._p2_vp_buildings_label;
			}
			set
			{
				this._p2_vp_buildings_label = null;
				this._p2_vp_buildings_label = value;
				this._p2_vp_buildings_label = null;
			}
		}

		internal virtual Label p2_vp_chips_label
		{
			get
			{
				return this._p2_vp_chips_label;
			}
			set
			{
				this._p2_vp_chips_label = null;
				this._p2_vp_chips_label = value;
				this._p2_vp_chips_label = null;
			}
		}

		internal virtual Label p2_vp_total_label
		{
			get
			{
				return this._p2_vp_total_label;
			}
			set
			{
				this._p2_vp_total_label = null;
				this._p2_vp_total_label = value;
				this._p2_vp_total_label = null;
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

		internal virtual Label p3_tie_breaker_label
		{
			get
			{
				return this._p3_tie_breaker_label;
			}
			set
			{
				this._p3_tie_breaker_label = null;
				this._p3_tie_breaker_label = value;
				this._p3_tie_breaker_label = null;
			}
		}

		internal virtual Label p3_vp_buildings_label
		{
			get
			{
				return this._p3_vp_buildings_label;
			}
			set
			{
				this._p3_vp_buildings_label = null;
				this._p3_vp_buildings_label = value;
				this._p3_vp_buildings_label = null;
			}
		}

		internal virtual Label p3_vp_chips_label
		{
			get
			{
				return this._p3_vp_chips_label;
			}
			set
			{
				this._p3_vp_chips_label = null;
				this._p3_vp_chips_label = value;
				this._p3_vp_chips_label = null;
			}
		}

		internal virtual Label p3_vp_total_label
		{
			get
			{
				return this._p3_vp_total_label;
			}
			set
			{
				this._p3_vp_total_label = null;
				this._p3_vp_total_label = value;
				this._p3_vp_total_label = null;
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

		internal virtual Label p4_tie_breaker_label
		{
			get
			{
				return this._p4_tie_breaker_label;
			}
			set
			{
				this._p4_tie_breaker_label = null;
				this._p4_tie_breaker_label = value;
				this._p4_tie_breaker_label = null;
			}
		}

		internal virtual Label p4_vp_buildings_label
		{
			get
			{
				return this._p4_vp_buildings_label;
			}
			set
			{
				this._p4_vp_buildings_label = null;
				this._p4_vp_buildings_label = value;
				this._p4_vp_buildings_label = null;
			}
		}

		internal virtual Label p4_vp_chips_label
		{
			get
			{
				return this._p4_vp_chips_label;
			}
			set
			{
				this._p4_vp_chips_label = null;
				this._p4_vp_chips_label = value;
				this._p4_vp_chips_label = null;
			}
		}

		internal virtual Label p4_vp_total_label
		{
			get
			{
				return this._p4_vp_total_label;
			}
			set
			{
				this._p4_vp_total_label = null;
				this._p4_vp_total_label = value;
				this._p4_vp_total_label = null;
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

		internal virtual Label p5_tie_breaker_label
		{
			get
			{
				return this._p5_tie_breaker_label;
			}
			set
			{
				this._p5_tie_breaker_label = null;
				this._p5_tie_breaker_label = value;
				this._p5_tie_breaker_label = null;
			}
		}

		internal virtual Label p5_vp_buildings_label
		{
			get
			{
				return this._p5_vp_buildings_label;
			}
			set
			{
				this._p5_vp_buildings_label = null;
				this._p5_vp_buildings_label = value;
				this._p5_vp_buildings_label = null;
			}
		}

		internal virtual Label p5_vp_chips_label
		{
			get
			{
				return this._p5_vp_chips_label;
			}
			set
			{
				this._p5_vp_chips_label = null;
				this._p5_vp_chips_label = value;
				this._p5_vp_chips_label = null;
			}
		}

		internal virtual Label p5_vp_total_label
		{
			get
			{
				return this._p5_vp_total_label;
			}
			set
			{
				this._p5_vp_total_label = null;
				this._p5_vp_total_label = value;
				this._p5_vp_total_label = null;
			}
		}

		public Score1()
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
			this.Label5 = new Label();
			this.Label4 = new Label();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.groupbox4 = new GroupBox();
			this.p4_tie_breaker_label = new Label();
			this.p4_vp_buildings_label = new Label();
			this.p4_vp_chips_label = new Label();
			this.p4_vp_total_label = new Label();
			this.Label13 = new Label();
			this.Label14 = new Label();
			this.Label15 = new Label();
			this.Label16 = new Label();
			this.groupbox5 = new GroupBox();
			this.p5_vp_buildings_label = new Label();
			this.p5_tie_breaker_label = new Label();
			this.p5_vp_total_label = new Label();
			this.p5_vp_chips_label = new Label();
			this.Label20 = new Label();
			this.Label19 = new Label();
			this.Label17 = new Label();
			this.Label18 = new Label();
			this.p1_vp_total_label = new Label();
			this.p1_vp_chips_label = new Label();
			this.p1_vp_buildings_label = new Label();
			this.p1_tie_breaker_label = new Label();
			this.p2_tie_breaker_label = new Label();
			this.p2_vp_buildings_label = new Label();
			this.p2_vp_chips_label = new Label();
			this.p2_vp_total_label = new Label();
			this.p3_tie_breaker_label = new Label();
			this.p3_vp_buildings_label = new Label();
			this.p3_vp_chips_label = new Label();
			this.p3_vp_total_label = new Label();
			this.GroupBox1 = new GroupBox();
			this.GroupBox2 = new GroupBox();
			this.Label8 = new Label();
			this.Label7 = new Label();
			this.Label6 = new Label();
			this.Label3 = new Label();
			this.GroupBox3 = new GroupBox();
			this.Label10 = new Label();
			this.Label9 = new Label();
			this.Label12 = new Label();
			this.Label11 = new Label();
			this.Label21 = new Label();
			this.Label22 = new Label();
			this.groupbox4.SuspendLayout();
			this.groupbox5.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			this.p5_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p5_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p5NameLabel = this.p5_name_label;
			Point point = new Point(8, 24);
			p5NameLabel.Location = point;
			this.p5_name_label.Name="p5_name_label";
			Label label = this.p5_name_label;
			Size size = new Size(120, 23);
			label.Size = size;
			this.p5_name_label.TabIndex=18;
			this.p5_name_label.Text="Player5";
			this.p5_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p4_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p4NameLabel = this.p4_name_label;
			point = new Point(8, 24);
			p4NameLabel.Location = point;
			this.p4_name_label.Name="p4_name_label";
			Label p4NameLabel1 = this.p4_name_label;
			size = new Size(120, 23);
			p4NameLabel1.Size = size;
			this.p4_name_label.TabIndex=17;
			this.p4_name_label.Text="Player4";
			this.p4_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p3_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p3NameLabel = this.p3_name_label;
			point = new Point(8, 24);
			p3NameLabel.Location = point;
			this.p3_name_label.Name="p3_name_label";
			Label p3NameLabel1 = this.p3_name_label;
			size = new Size(120, 23);
			p3NameLabel1.Size = size;
			this.p3_name_label.TabIndex=16;
			this.p3_name_label.Text="Player3";
			this.p3_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p2_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p2NameLabel = this.p2_name_label;
			point = new Point(8, 24);
			p2NameLabel.Location = point;
			this.p2_name_label.Name="p2_name_label";
			Label p2NameLabel1 = this.p2_name_label;
			size = new Size(120, 23);
			p2NameLabel1.Size = size;
			this.p2_name_label.TabIndex=15;
			this.p2_name_label.Text="Player2";
			this.p2_name_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_name_label.BorderStyle = BorderStyle.Fixed3D;
			this.p1_name_label.Font=new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label p1NameLabel = this.p1_name_label;
			point = new Point(8, 24);
			p1NameLabel.Location = point;
			this.p1_name_label.Name="p1_name_label";
			Label p1NameLabel1 = this.p1_name_label;
			size = new Size(120, 23);
			p1NameLabel1.Size = size;
			this.p1_name_label.TabIndex=14;
			this.p1_name_label.Text="Player1";
			this.p1_name_label.TextAlign = ContentAlignment.MiddleCenter;
			Label label5 = this.Label5;
			point = new Point(16, 72);
			label5.Location = point;
			this.Label5.Name="Label5";
			Label label51 = this.Label5;
			size = new Size(72, 16);
			label51.Size = size;
			this.Label5.TabIndex=25;
			this.Label5.Text="VP Total";
			this.Label5.TextAlign = ContentAlignment.MiddleCenter;
			Label label4 = this.Label4;
			point = new Point(16, 128);
			label4.Location = point;
			this.Label4.Name="Label4";
			Label label41 = this.Label4;
			size = new Size(72, 16);
			label41.Size = size;
			this.Label4.TabIndex=24;
			this.Label4.Text="VP Chips";
			this.Label4.TextAlign = ContentAlignment.MiddleCenter;
			Label label1 = this.Label1;
			point = new Point(16, 184);
			label1.Location = point;
			this.Label1.Name="Label1";
			Label label11 = this.Label1;
			size = new Size(72, 16);
			label11.Size = size;
			this.Label1.TabIndex=26;
			this.Label1.Text="VP Buildings";
			this.Label1.TextAlign = ContentAlignment.MiddleCenter;
			Label label2 = this.Label2;
			point = new Point(16, 240);
			label2.Location = point;
			this.Label2.Name="Label2";
			Label label21 = this.Label2;
			size = new Size(72, 24);
			label21.Size = size;
			this.Label2.TabIndex=27;
			this.Label2.Text="Goods / Doubloons";
			this.Label2.TextAlign = ContentAlignment.MiddleCenter;
			this.groupbox4.Controls.Add(this.p4_name_label);
			this.groupbox4.Controls.Add(this.p4_tie_breaker_label);
			this.groupbox4.Controls.Add(this.p4_vp_buildings_label);
			this.groupbox4.Controls.Add(this.p4_vp_chips_label);
			this.groupbox4.Controls.Add(this.p4_vp_total_label);
			this.groupbox4.Controls.Add(this.Label13);
			this.groupbox4.Controls.Add(this.Label14);
			this.groupbox4.Controls.Add(this.Label15);
			this.groupbox4.Controls.Add(this.Label16);
			GroupBox groupBox = this.groupbox4;
			point = new Point(504, 104);
			groupBox.Location = point;
			this.groupbox4.Name="groupbox4";
			GroupBox groupBox1 = this.groupbox4;
			size = new Size(136, 288);
			groupBox1.Size = size;
			this.groupbox4.TabIndex=28;
			this.groupbox4.TabStop = false;
			this.p4_tie_breaker_label.BackColor=Color.White;
			this.p4_tie_breaker_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label p4TieBreakerLabel = this.p4_tie_breaker_label;
			point = new Point(88, 232);
			p4TieBreakerLabel.Location = point;
			this.p4_tie_breaker_label.Name="p4_tie_breaker_label";
			Label p4TieBreakerLabel1 = this.p4_tie_breaker_label;
			size = new Size(36, 32);
			p4TieBreakerLabel1.Size = size;
			this.p4_tie_breaker_label.TabIndex=44;
			this.p4_tie_breaker_label.Text="99";
			this.p4_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_vp_buildings_label.BackColor=Color.White;
			this.p4_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p4VpBuildingsLabel = this.p4_vp_buildings_label;
			point = new Point(88, 176);
			p4VpBuildingsLabel.Location = point;
			this.p4_vp_buildings_label.Name="p4_vp_buildings_label";
			Label p4VpBuildingsLabel1 = this.p4_vp_buildings_label;
			size = new Size(36, 32);
			p4VpBuildingsLabel1.Size = size;
			this.p4_vp_buildings_label.TabIndex=43;
			this.p4_vp_buildings_label.Text="99";
			this.p4_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_vp_chips_label.BackColor=Color.White;
			this.p4_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p4VpChipsLabel = this.p4_vp_chips_label;
			point = new Point(88, 120);
			p4VpChipsLabel.Location = point;
			this.p4_vp_chips_label.Name="p4_vp_chips_label";
			Label p4VpChipsLabel1 = this.p4_vp_chips_label;
			size = new Size(36, 32);
			p4VpChipsLabel1.Size = size;
			this.p4_vp_chips_label.TabIndex=42;
			this.p4_vp_chips_label.Text="99";
			this.p4_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p4_vp_total_label.BackColor=Color.White;
			this.p4_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p4VpTotalLabel = this.p4_vp_total_label;
			point = new Point(88, 64);
			p4VpTotalLabel.Location = point;
			this.p4_vp_total_label.Name="p4_vp_total_label";
			Label p4VpTotalLabel1 = this.p4_vp_total_label;
			size = new Size(36, 32);
			p4VpTotalLabel1.Size = size;
			this.p4_vp_total_label.TabIndex=41;
			this.p4_vp_total_label.Text="99";
			this.p4_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			Label label13 = this.Label13;
			point = new Point(16, 128);
			label13.Location = point;
			this.Label13.Name="Label13";
			Label label131 = this.Label13;
			size = new Size(72, 16);
			label131.Size = size;
			this.Label13.TabIndex=50;
			this.Label13.Text="VP Chips";
			this.Label13.TextAlign = ContentAlignment.MiddleCenter;
			Label label14 = this.Label14;
			point = new Point(16, 72);
			label14.Location = point;
			this.Label14.Name="Label14";
			Label label141 = this.Label14;
			size = new Size(72, 16);
			label141.Size = size;
			this.Label14.TabIndex=51;
			this.Label14.Text="VP Total";
			this.Label14.TextAlign = ContentAlignment.MiddleCenter;
			Label label15 = this.Label15;
			point = new Point(16, 240);
			label15.Location = point;
			this.Label15.Name="Label15";
			Label label151 = this.Label15;
			size = new Size(72, 24);
			label151.Size = size;
			this.Label15.TabIndex=53;
			this.Label15.Text="Goods / Doubloons";
			this.Label15.TextAlign = ContentAlignment.MiddleCenter;
			Label label16 = this.Label16;
			point = new Point(16, 184);
			label16.Location = point;
			this.Label16.Name="Label16";
			Label label161 = this.Label16;
			size = new Size(72, 16);
			label161.Size = size;
			this.Label16.TabIndex=52;
			this.Label16.Text="VP Buildings";
			this.Label16.TextAlign = ContentAlignment.MiddleCenter;
			this.groupbox5.Controls.Add(this.p5_name_label);
			this.groupbox5.Controls.Add(this.p5_vp_buildings_label);
			this.groupbox5.Controls.Add(this.p5_tie_breaker_label);
			this.groupbox5.Controls.Add(this.p5_vp_total_label);
			this.groupbox5.Controls.Add(this.p5_vp_chips_label);
			this.groupbox5.Controls.Add(this.Label20);
			this.groupbox5.Controls.Add(this.Label19);
			this.groupbox5.Controls.Add(this.Label17);
			this.groupbox5.Controls.Add(this.Label18);
			GroupBox groupBox2 = this.groupbox5;
			point = new Point(648, 104);
			groupBox2.Location = point;
			this.groupbox5.Name="groupbox5";
			GroupBox groupBox3 = this.groupbox5;
			size = new Size(136, 288);
			groupBox3.Size = size;
			this.groupbox5.TabIndex=29;
			this.groupbox5.TabStop = false;
			this.p5_vp_buildings_label.BackColor=Color.White;
			this.p5_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5VpBuildingsLabel = this.p5_vp_buildings_label;
			point = new Point(88, 176);
			p5VpBuildingsLabel.Location = point;
			this.p5_vp_buildings_label.Name="p5_vp_buildings_label";
			Label p5VpBuildingsLabel1 = this.p5_vp_buildings_label;
			size = new Size(36, 32);
			p5VpBuildingsLabel1.Size = size;
			this.p5_vp_buildings_label.TabIndex=47;
			this.p5_vp_buildings_label.Text="99";
			this.p5_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_tie_breaker_label.BackColor=Color.White;
			this.p5_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5TieBreakerLabel = this.p5_tie_breaker_label;
			point = new Point(88, 232);
			p5TieBreakerLabel.Location = point;
			this.p5_tie_breaker_label.Name="p5_tie_breaker_label";
			Label p5TieBreakerLabel1 = this.p5_tie_breaker_label;
			size = new Size(36, 32);
			p5TieBreakerLabel1.Size = size;
			this.p5_tie_breaker_label.TabIndex=48;
			this.p5_tie_breaker_label.Text="99";
			this.p5_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_vp_total_label.BackColor=Color.White;
			this.p5_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5VpTotalLabel = this.p5_vp_total_label;
			point = new Point(88, 64);
			p5VpTotalLabel.Location = point;
			this.p5_vp_total_label.Name="p5_vp_total_label";
			Label p5VpTotalLabel1 = this.p5_vp_total_label;
			size = new Size(36, 32);
			p5VpTotalLabel1.Size = size;
			this.p5_vp_total_label.TabIndex=45;
			this.p5_vp_total_label.Text="99";
			this.p5_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p5_vp_chips_label.BackColor=Color.White;
			this.p5_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p5VpChipsLabel = this.p5_vp_chips_label;
			point = new Point(88, 120);
			p5VpChipsLabel.Location = point;
			this.p5_vp_chips_label.Name="p5_vp_chips_label";
			Label p5VpChipsLabel1 = this.p5_vp_chips_label;
			size = new Size(36, 32);
			p5VpChipsLabel1.Size = size;
			this.p5_vp_chips_label.TabIndex=46;
			this.p5_vp_chips_label.Text="99";
			this.p5_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			Label label20 = this.Label20;
			point = new Point(16, 184);
			label20.Location = point;
			this.Label20.Name="Label20";
			Label label201 = this.Label20;
			size = new Size(72, 16);
			label201.Size = size;
			this.Label20.TabIndex=52;
			this.Label20.Text="VP Buildings";
			this.Label20.TextAlign = ContentAlignment.MiddleCenter;
			Label label19 = this.Label19;
			point = new Point(16, 240);
			label19.Location = point;
			this.Label19.Name="Label19";
			Label label191 = this.Label19;
			size = new Size(72, 24);
			label191.Size = size;
			this.Label19.TabIndex=53;
			this.Label19.Text="Goods / Doubloons";
			this.Label19.TextAlign = ContentAlignment.MiddleCenter;
			Label label17 = this.Label17;
			point = new Point(16, 128);
			label17.Location = point;
			this.Label17.Name="Label17";
			Label label171 = this.Label17;
			size = new Size(72, 16);
			label171.Size = size;
			this.Label17.TabIndex=50;
			this.Label17.Text="VP Chips";
			this.Label17.TextAlign = ContentAlignment.MiddleCenter;
			Label label18 = this.Label18;
			point = new Point(16, 72);
			label18.Location = point;
			this.Label18.Name="Label18";
			Label label181 = this.Label18;
			size = new Size(72, 16);
			label181.Size = size;
			this.Label18.TabIndex=51;
			this.Label18.Text="VP Total";
			this.Label18.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_vp_total_label.BackColor=Color.White;
			this.p1_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1VpTotalLabel = this.p1_vp_total_label;
			point = new Point(88, 64);
			p1VpTotalLabel.Location = point;
			this.p1_vp_total_label.Name="p1_vp_total_label";
			Label p1VpTotalLabel1 = this.p1_vp_total_label;
			size = new Size(36, 32);
			p1VpTotalLabel1.Size = size;
			this.p1_vp_total_label.TabIndex=26;
			this.p1_vp_total_label.Text="99";
			this.p1_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_vp_chips_label.BackColor=Color.White;
			this.p1_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1VpChipsLabel = this.p1_vp_chips_label;
			point = new Point(88, 120);
			p1VpChipsLabel.Location = point;
			this.p1_vp_chips_label.Name="p1_vp_chips_label";
			Label p1VpChipsLabel1 = this.p1_vp_chips_label;
			size = new Size(36, 32);
			p1VpChipsLabel1.Size = size;
			this.p1_vp_chips_label.TabIndex=30;
			this.p1_vp_chips_label.Text="99";
			this.p1_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_vp_buildings_label.BackColor=Color.White;
			this.p1_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1VpBuildingsLabel = this.p1_vp_buildings_label;
			point = new Point(88, 176);
			p1VpBuildingsLabel.Location = point;
			this.p1_vp_buildings_label.Name="p1_vp_buildings_label";
			Label p1VpBuildingsLabel1 = this.p1_vp_buildings_label;
			size = new Size(36, 32);
			p1VpBuildingsLabel1.Size = size;
			this.p1_vp_buildings_label.TabIndex=31;
			this.p1_vp_buildings_label.Text="99";
			this.p1_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p1_tie_breaker_label.BackColor=Color.White;
			this.p1_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p1TieBreakerLabel = this.p1_tie_breaker_label;
			point = new Point(88, 232);
			p1TieBreakerLabel.Location = point;
			this.p1_tie_breaker_label.Name="p1_tie_breaker_label";
			Label p1TieBreakerLabel1 = this.p1_tie_breaker_label;
			size = new Size(36, 32);
			p1TieBreakerLabel1.Size = size;
			this.p1_tie_breaker_label.TabIndex=32;
			this.p1_tie_breaker_label.Text="99";
			this.p1_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_tie_breaker_label.BackColor=Color.White;
			this.p2_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2TieBreakerLabel = this.p2_tie_breaker_label;
			point = new Point(88, 232);
			p2TieBreakerLabel.Location = point;
			this.p2_tie_breaker_label.Name="p2_tie_breaker_label";
			Label p2TieBreakerLabel1 = this.p2_tie_breaker_label;
			size = new Size(36, 32);
			p2TieBreakerLabel1.Size = size;
			this.p2_tie_breaker_label.TabIndex=36;
			this.p2_tie_breaker_label.Text="99";
			this.p2_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_vp_buildings_label.BackColor=Color.White;
			this.p2_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2VpBuildingsLabel = this.p2_vp_buildings_label;
			point = new Point(88, 176);
			p2VpBuildingsLabel.Location = point;
			this.p2_vp_buildings_label.Name="p2_vp_buildings_label";
			Label p2VpBuildingsLabel1 = this.p2_vp_buildings_label;
			size = new Size(36, 32);
			p2VpBuildingsLabel1.Size = size;
			this.p2_vp_buildings_label.TabIndex=35;
			this.p2_vp_buildings_label.Text="99";
			this.p2_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_vp_chips_label.BackColor=Color.White;
			this.p2_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2VpChipsLabel = this.p2_vp_chips_label;
			point = new Point(88, 120);
			p2VpChipsLabel.Location = point;
			this.p2_vp_chips_label.Name="p2_vp_chips_label";
			Label p2VpChipsLabel1 = this.p2_vp_chips_label;
			size = new Size(36, 32);
			p2VpChipsLabel1.Size = size;
			this.p2_vp_chips_label.TabIndex=34;
			this.p2_vp_chips_label.Text="99";
			this.p2_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p2_vp_total_label.BackColor=Color.White;
			this.p2_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p2VpTotalLabel = this.p2_vp_total_label;
			point = new Point(88, 64);
			p2VpTotalLabel.Location = point;
			this.p2_vp_total_label.Name="p2_vp_total_label";
			Label p2VpTotalLabel1 = this.p2_vp_total_label;
			size = new Size(36, 32);
			p2VpTotalLabel1.Size = size;
			this.p2_vp_total_label.TabIndex=33;
			this.p2_vp_total_label.Text="99";
			this.p2_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_tie_breaker_label.BackColor=Color.White;
			this.p3_tie_breaker_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3TieBreakerLabel = this.p3_tie_breaker_label;
			point = new Point(88, 232);
			p3TieBreakerLabel.Location = point;
			this.p3_tie_breaker_label.Name="p3_tie_breaker_label";
			Label p3TieBreakerLabel1 = this.p3_tie_breaker_label;
			size = new Size(36, 32);
			p3TieBreakerLabel1.Size = size;
			this.p3_tie_breaker_label.TabIndex=40;
			this.p3_tie_breaker_label.Text="99";
			this.p3_tie_breaker_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_vp_buildings_label.BackColor=Color.White;
			this.p3_vp_buildings_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3VpBuildingsLabel = this.p3_vp_buildings_label;
			point = new Point(88, 176);
			p3VpBuildingsLabel.Location = point;
			this.p3_vp_buildings_label.Name="p3_vp_buildings_label";
			Label p3VpBuildingsLabel1 = this.p3_vp_buildings_label;
			size = new Size(36, 32);
			p3VpBuildingsLabel1.Size = size;
			this.p3_vp_buildings_label.TabIndex=39;
			this.p3_vp_buildings_label.Text="99";
			this.p3_vp_buildings_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_vp_chips_label.BackColor=Color.White;
			this.p3_vp_chips_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3VpChipsLabel = this.p3_vp_chips_label;
			point = new Point(88, 120);
			p3VpChipsLabel.Location = point;
			this.p3_vp_chips_label.Name="p3_vp_chips_label";
			Label p3VpChipsLabel1 = this.p3_vp_chips_label;
			size = new Size(36, 32);
			p3VpChipsLabel1.Size = size;
			this.p3_vp_chips_label.TabIndex=38;
			this.p3_vp_chips_label.Text="99";
			this.p3_vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			this.p3_vp_total_label.BackColor=Color.White;
			this.p3_vp_total_label.Font=new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);;
			Label p3VpTotalLabel = this.p3_vp_total_label;
			point = new Point(88, 64);
			p3VpTotalLabel.Location = point;
			this.p3_vp_total_label.Name="p3_vp_total_label";
			Label p3VpTotalLabel1 = this.p3_vp_total_label;
			size = new Size(36, 32);
			p3VpTotalLabel1.Size = size;
			this.p3_vp_total_label.TabIndex=37;
			this.p3_vp_total_label.Text="99";
			this.p3_vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			this.GroupBox1.Controls.Add(this.p1_tie_breaker_label);
			this.GroupBox1.Controls.Add(this.p1_name_label);
			this.GroupBox1.Controls.Add(this.p1_vp_total_label);
			this.GroupBox1.Controls.Add(this.p1_vp_chips_label);
			this.GroupBox1.Controls.Add(this.p1_vp_buildings_label);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label2);
			GroupBox groupBox11 = this.GroupBox1;
			point = new Point(72, 104);
			groupBox11.Location = point;
			this.GroupBox1.Name="GroupBox1";
			GroupBox groupBox12 = this.GroupBox1;
			size = new Size(136, 288);
			groupBox12.Size = size;
			this.GroupBox1.TabIndex=42;
			this.GroupBox1.TabStop = false;
			this.GroupBox2.Controls.Add(this.p2_tie_breaker_label);
			this.GroupBox2.Controls.Add(this.p2_vp_buildings_label);
			this.GroupBox2.Controls.Add(this.p2_vp_chips_label);
			this.GroupBox2.Controls.Add(this.p2_vp_total_label);
			this.GroupBox2.Controls.Add(this.p2_name_label);
			this.GroupBox2.Controls.Add(this.Label8);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.Label3);
			GroupBox groupBox21 = this.GroupBox2;
			point = new Point(216, 104);
			groupBox21.Location = point;
			this.GroupBox2.Name="GroupBox2";
			GroupBox groupBox22 = this.GroupBox2;
			size = new Size(136, 288);
			groupBox22.Size = size;
			this.GroupBox2.TabIndex=43;
			this.GroupBox2.TabStop = false;
			Label label8 = this.Label8;
			point = new Point(16, 240);
			label8.Location = point;
			this.Label8.Name="Label8";
			Label label81 = this.Label8;
			size = new Size(72, 24);
			label81.Size = size;
			this.Label8.TabIndex=36;
			this.Label8.Text="Goods / Doubloons";
			this.Label8.TextAlign = ContentAlignment.MiddleCenter;
			Label label7 = this.Label7;
			point = new Point(16, 184);
			label7.Location = point;
			this.Label7.Name="Label7";
			Label label71 = this.Label7;
			size = new Size(72, 16);
			label71.Size = size;
			this.Label7.TabIndex=35;
			this.Label7.Text="VP Buildings";
			this.Label7.TextAlign = ContentAlignment.MiddleCenter;
			Label label6 = this.Label6;
			point = new Point(16, 128);
			label6.Location = point;
			this.Label6.Name="Label6";
			Label label61 = this.Label6;
			size = new Size(72, 16);
			label61.Size = size;
			this.Label6.TabIndex=33;
			this.Label6.Text="VP Chips";
			this.Label6.TextAlign = ContentAlignment.MiddleCenter;
			Label label3 = this.Label3;
			point = new Point(16, 72);
			label3.Location = point;
			this.Label3.Name="Label3";
			Label label31 = this.Label3;
			size = new Size(72, 16);
			label31.Size = size;
			this.Label3.TabIndex=34;
			this.Label3.Text="VP Total";
			this.Label3.TextAlign = ContentAlignment.MiddleCenter;
			this.GroupBox3.Controls.Add(this.p3_name_label);
			this.GroupBox3.Controls.Add(this.p3_tie_breaker_label);
			this.GroupBox3.Controls.Add(this.p3_vp_buildings_label);
			this.GroupBox3.Controls.Add(this.p3_vp_chips_label);
			this.GroupBox3.Controls.Add(this.p3_vp_total_label);
			this.GroupBox3.Controls.Add(this.Label10);
			this.GroupBox3.Controls.Add(this.Label9);
			this.GroupBox3.Controls.Add(this.Label12);
			this.GroupBox3.Controls.Add(this.Label11);
			GroupBox groupBox31 = this.GroupBox3;
			point = new Point(360, 104);
			groupBox31.Location = point;
			this.GroupBox3.Name="GroupBox3";
			GroupBox groupBox32 = this.GroupBox3;
			size = new Size(136, 288);
			groupBox32.Size = size;
			this.GroupBox3.TabIndex=44;
			this.GroupBox3.TabStop = false;
			Label label10 = this.Label10;
			point = new Point(16, 128);
			label10.Location = point;
			this.Label10.Name="Label10";
			Label label101 = this.Label10;
			size = new Size(72, 16);
			label101.Size = size;
			this.Label10.TabIndex=46;
			this.Label10.Text="VP Chips";
			this.Label10.TextAlign = ContentAlignment.MiddleCenter;
			Label label9 = this.Label9;
			point = new Point(16, 72);
			label9.Location = point;
			this.Label9.Name="Label9";
			Label label91 = this.Label9;
			size = new Size(72, 16);
			label91.Size = size;
			this.Label9.TabIndex=47;
			this.Label9.Text="VP Total";
			this.Label9.TextAlign = ContentAlignment.MiddleCenter;
			Label label12 = this.Label12;
			point = new Point(16, 240);
			label12.Location = point;
			this.Label12.Name="Label12";
			Label label121 = this.Label12;
			size = new Size(72, 24);
			label121.Size = size;
			this.Label12.TabIndex=49;
			this.Label12.Text="Goods / Doubloons";
			this.Label12.TextAlign = ContentAlignment.MiddleCenter;
			Label label111 = this.Label11;
			point = new Point(16, 184);
			label111.Location = point;
			this.Label11.Name="Label11";
			Label label112 = this.Label11;
			size = new Size(72, 16);
			label112.Size = size;
			this.Label11.TabIndex=48;
			this.Label11.Text="VP Buildings";
			this.Label11.TextAlign = ContentAlignment.MiddleCenter;
			Label label211 = this.Label21;
			point = new Point(8, 80);
			label211.Location = point;
			this.Label21.Name="Label21";
			Label label212 = this.Label21;
			size = new Size(56, 16);
			label212.Size = size;
			this.Label21.TabIndex=33;
			this.Label21.Text="WINNER";
			this.Label21.TextAlign = ContentAlignment.MiddleCenter;
			Label label22 = this.Label22;
			point = new Point(0, 240);
			label22.Location = point;
			this.Label22.Name="Label22";
			Label label221 = this.Label22;
			size = new Size(64, 32);
			label221.Size = size;
			this.Label22.TabIndex=45;
			this.Label22.Text="TIE BREAKER";
			this.Label22.TextAlign = ContentAlignment.MiddleCenter;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(792, 410);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Label22);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.groupbox5);
			this.Controls.Add(this.groupbox4);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.Label21);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			size = new Size(800, 448);
			this.MaximumSize = size;
			size = new Size(800, 448);
			this.MinimumSize = size;
			this.Name="Score1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text="Puerto Rico Score";
			this.groupbox4.ResumeLayout(false);
			this.groupbox5.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
