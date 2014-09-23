using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Captain1 : Form
	{
		[AccessedThroughProperty("shipb_slot6")]
		private PictureBox _shipb_slot6;

		[AccessedThroughProperty("shipb_slot7")]
		private PictureBox _shipb_slot7;

		[AccessedThroughProperty("shipa_slot1")]
		private PictureBox _shipa_slot1;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("shipb_slot4")]
		private PictureBox _shipb_slot4;

		[AccessedThroughProperty("shipa_slot2")]
		private PictureBox _shipa_slot2;

		[AccessedThroughProperty("shipa_slot3")]
		private PictureBox _shipa_slot3;

		[AccessedThroughProperty("shipb_slot3")]
		private PictureBox _shipb_slot3;

		[AccessedThroughProperty("shipb_slot2")]
		private PictureBox _shipb_slot2;

		[AccessedThroughProperty("shipb_slot1")]
		private PictureBox _shipb_slot1;

		[AccessedThroughProperty("shipc_slot8")]
		private PictureBox _shipc_slot8;

		[AccessedThroughProperty("shipc_slot7")]
		private PictureBox _shipc_slot7;

		[AccessedThroughProperty("shipc_slot6")]
		private PictureBox _shipc_slot6;

		[AccessedThroughProperty("shipc_slot5")]
		private PictureBox _shipc_slot5;

		[AccessedThroughProperty("shipc_slot4")]
		private PictureBox _shipc_slot4;

		[AccessedThroughProperty("shipc_slot3")]
		private PictureBox _shipc_slot3;

		[AccessedThroughProperty("shipa_slot4")]
		private PictureBox _shipa_slot4;

		[AccessedThroughProperty("shipc_slot2")]
		private PictureBox _shipc_slot2;

		[AccessedThroughProperty("shipc_slot1")]
		private PictureBox _shipc_slot1;

		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		[AccessedThroughProperty("shipb_slot5")]
		private PictureBox _shipb_slot5;

		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		[AccessedThroughProperty("shipa_slot6")]
		private PictureBox _shipa_slot6;

		[AccessedThroughProperty("shipa_slot5")]
		private PictureBox _shipa_slot5;

		private IContainer components;

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

		internal virtual PictureBox PictureBox2
		{
			get
			{
				return this._PictureBox2;
			}
			set
			{
				this._PictureBox2 = null;
				this._PictureBox2 = value;
				this._PictureBox2 = null;
			}
		}

		internal virtual PictureBox PictureBox3
		{
			get
			{
				return this._PictureBox3;
			}
			set
			{
				this._PictureBox3 = null;
				this._PictureBox3 = value;
				this._PictureBox3 = null;
			}
		}

		internal virtual PictureBox shipa_slot1
		{
			get
			{
				return this._shipa_slot1;
			}
			set
			{
				this._shipa_slot1 = null;
				this._shipa_slot1 = value;
				this._shipa_slot1 = null;
			}
		}

		internal virtual PictureBox shipa_slot2
		{
			get
			{
				return this._shipa_slot2;
			}
			set
			{
				this._shipa_slot2 = null;
				this._shipa_slot2 = value;
				this._shipa_slot2 = null;
			}
		}

		internal virtual PictureBox shipa_slot3
		{
			get
			{
				return this._shipa_slot3;
			}
			set
			{
				this._shipa_slot3 = null;
				this._shipa_slot3 = value;
				this._shipa_slot3 = null;
			}
		}

		internal virtual PictureBox shipa_slot4
		{
			get
			{
				return this._shipa_slot4;
			}
			set
			{
				this._shipa_slot4 = null;
				this._shipa_slot4 = value;
				this._shipa_slot4 = null;
			}
		}

		internal virtual PictureBox shipa_slot5
		{
			get
			{
				return this._shipa_slot5;
			}
			set
			{
				this._shipa_slot5 = null;
				this._shipa_slot5 = value;
				this._shipa_slot5 = null;
			}
		}

		internal virtual PictureBox shipa_slot6
		{
			get
			{
				return this._shipa_slot6;
			}
			set
			{
				this._shipa_slot6 = null;
				this._shipa_slot6 = value;
				this._shipa_slot6 = null;
			}
		}

		internal virtual PictureBox shipb_slot1
		{
			get
			{
				return this._shipb_slot1;
			}
			set
			{
				this._shipb_slot1 = null;
				this._shipb_slot1 = value;
				this._shipb_slot1 = null;
			}
		}

		internal virtual PictureBox shipb_slot2
		{
			get
			{
				return this._shipb_slot2;
			}
			set
			{
				this._shipb_slot2 = null;
				this._shipb_slot2 = value;
				this._shipb_slot2 = null;
			}
		}

		internal virtual PictureBox shipb_slot3
		{
			get
			{
				return this._shipb_slot3;
			}
			set
			{
				this._shipb_slot3 = null;
				this._shipb_slot3 = value;
				this._shipb_slot3 = null;
			}
		}

		internal virtual PictureBox shipb_slot4
		{
			get
			{
				return this._shipb_slot4;
			}
			set
			{
				this._shipb_slot4 = null;
				this._shipb_slot4 = value;
				this._shipb_slot4 = null;
			}
		}

		internal virtual PictureBox shipb_slot5
		{
			get
			{
				return this._shipb_slot5;
			}
			set
			{
				this._shipb_slot5 = null;
				this._shipb_slot5 = value;
				this._shipb_slot5 = null;
			}
		}

		internal virtual PictureBox shipb_slot6
		{
			get
			{
				return this._shipb_slot6;
			}
			set
			{
				this._shipb_slot6 = null;
				this._shipb_slot6 = value;
				this._shipb_slot6 = null;
			}
		}

		internal virtual PictureBox shipb_slot7
		{
			get
			{
				return this._shipb_slot7;
			}
			set
			{
				this._shipb_slot7 = null;
				this._shipb_slot7 = value;
				this._shipb_slot7 = null;
			}
		}

		internal virtual PictureBox shipc_slot1
		{
			get
			{
				return this._shipc_slot1;
			}
			set
			{
				this._shipc_slot1 = null;
				this._shipc_slot1 = value;
				this._shipc_slot1 = null;
			}
		}

		internal virtual PictureBox shipc_slot2
		{
			get
			{
				return this._shipc_slot2;
			}
			set
			{
				this._shipc_slot2 = null;
				this._shipc_slot2 = value;
				this._shipc_slot2 = null;
			}
		}

		internal virtual PictureBox shipc_slot3
		{
			get
			{
				return this._shipc_slot3;
			}
			set
			{
				this._shipc_slot3 = null;
				this._shipc_slot3 = value;
				this._shipc_slot3 = null;
			}
		}

		internal virtual PictureBox shipc_slot4
		{
			get
			{
				return this._shipc_slot4;
			}
			set
			{
				this._shipc_slot4 = null;
				this._shipc_slot4 = value;
				this._shipc_slot4 = null;
			}
		}

		internal virtual PictureBox shipc_slot5
		{
			get
			{
				return this._shipc_slot5;
			}
			set
			{
				this._shipc_slot5 = null;
				this._shipc_slot5 = value;
				this._shipc_slot5 = null;
			}
		}

		internal virtual PictureBox shipc_slot6
		{
			get
			{
				return this._shipc_slot6;
			}
			set
			{
				this._shipc_slot6 = null;
				this._shipc_slot6 = value;
				this._shipc_slot6 = null;
			}
		}

		internal virtual PictureBox shipc_slot7
		{
			get
			{
				return this._shipc_slot7;
			}
			set
			{
				this._shipc_slot7 = null;
				this._shipc_slot7 = value;
				this._shipc_slot7 = null;
			}
		}

		internal virtual PictureBox shipc_slot8
		{
			get
			{
				return this._shipc_slot8;
			}
			set
			{
				this._shipc_slot8 = null;
				this._shipc_slot8 = value;
				this._shipc_slot8 = null;
			}
		}

		public Captain1()
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
			ResourceManager resourceManager = new ResourceManager(typeof(Captain1));
			this.PictureBox3 = new PictureBox();
			this.PictureBox2 = new PictureBox();
			this.PictureBox1 = new PictureBox();
			this.shipa_slot6 = new PictureBox();
			this.shipa_slot5 = new PictureBox();
			this.shipa_slot4 = new PictureBox();
			this.shipa_slot3 = new PictureBox();
			this.shipa_slot2 = new PictureBox();
			this.shipa_slot1 = new PictureBox();
			this.shipb_slot7 = new PictureBox();
			this.shipb_slot6 = new PictureBox();
			this.shipb_slot5 = new PictureBox();
			this.shipb_slot4 = new PictureBox();
			this.shipb_slot3 = new PictureBox();
			this.shipb_slot2 = new PictureBox();
			this.shipb_slot1 = new PictureBox();
			this.shipc_slot8 = new PictureBox();
			this.shipc_slot7 = new PictureBox();
			this.shipc_slot6 = new PictureBox();
			this.shipc_slot5 = new PictureBox();
			this.shipc_slot4 = new PictureBox();
			this.shipc_slot3 = new PictureBox();
			this.shipc_slot2 = new PictureBox();
			this.shipc_slot1 = new PictureBox();
			this.SuspendLayout();
			this.PictureBox3.BackColor=SystemColors.ActiveCaption;
			this.PictureBox3.BorderStyle=BorderStyle.FixedSingle;
			this.PictureBox3.Image=(Image)resourceManager.GetObject("PictureBox3.Image");
			PictureBox pictureBox3 = this.PictureBox3;
			Point point = new Point(360, 96);
			pictureBox3.Location = point;
			this.PictureBox3.Name="PictureBox3";
			PictureBox pictureBox = this.PictureBox3;
			Size size = new Size(76, 134);
			pictureBox.Size = size;
			this.PictureBox3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox3.TabIndex=156;
			this.PictureBox3.TabStop = false;
			this.PictureBox3.Visible = false;
			this.PictureBox2.BackColor=SystemColors.ActiveCaption;
			this.PictureBox2.BorderStyle=BorderStyle.FixedSingle;
			this.PictureBox2.Image = (Image)resourceManager.GetObject("PictureBox2.Image");
			PictureBox pictureBox2 = this.PictureBox2;
			point = new Point(280, 96);
			pictureBox2.Location = point;
			this.PictureBox2.Name = "PictureBox2";
			PictureBox pictureBox21 = this.PictureBox2;
			size = new Size(76, 134);
			pictureBox21.Size = size;
			this.PictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox2.TabIndex = 155;
			this.PictureBox2.TabStop = false;
			this.PictureBox2.Visible = false;
			this.PictureBox1.BackColor=SystemColors.ActiveCaption;
			this.PictureBox1.BorderStyle=BorderStyle.FixedSingle;
			this.PictureBox1.Image = (Image)resourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = this.PictureBox1;
			point = new Point(192, 96);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox11 = this.PictureBox1;
			size = new Size(76, 134);
			pictureBox11.Size = size;
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 154;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Visible = false;
			this.shipa_slot6.BackColor=SystemColors.ActiveCaption;
			this.shipa_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot6 = this.shipa_slot6;
			point = new Point(232, 206);
			shipaSlot6.Location = point;
			this.shipa_slot6.Name = "shipa_slot6";
			PictureBox shipaSlot61 = this.shipa_slot6;
			size = new Size(32, 32);
			shipaSlot61.Size = size;
			this.shipa_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipa_slot6.TabIndex = 162;
			this.shipa_slot6.TabStop = false;
			this.shipa_slot5.BackColor=SystemColors.ActiveCaption;
			this.shipa_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot5 = this.shipa_slot5;
			point = new Point(198, 206);
			shipaSlot5.Location = point;
			this.shipa_slot5.Name = "shipa_slot5";
			PictureBox shipaSlot51 = this.shipa_slot5;
			size = new Size(32, 32);
			shipaSlot51.Size = size;
			this.shipa_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipa_slot5.TabIndex = 161;
			this.shipa_slot5.TabStop = false;
			this.shipa_slot4.BackColor=SystemColors.ActiveCaption;
			this.shipa_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot4 = this.shipa_slot4;
			point = new Point(230, 158);
			shipaSlot4.Location = point;
			this.shipa_slot4.Name = "shipa_slot4";
			PictureBox shipaSlot41 = this.shipa_slot4;
			size = new Size(32, 32);
			shipaSlot41.Size = size;
			this.shipa_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipa_slot4.TabIndex = 160;
			this.shipa_slot4.TabStop = false;
			this.shipa_slot3.BackColor=SystemColors.ActiveCaption;
			this.shipa_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot3 = this.shipa_slot3;
			point = new Point(198, 158);
			shipaSlot3.Location = point;
			this.shipa_slot3.Name = "shipa_slot3";
			PictureBox shipaSlot31 = this.shipa_slot3;
			size = new Size(32, 32);
			shipaSlot31.Size = size;
			this.shipa_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipa_slot3.TabIndex = 159;
			this.shipa_slot3.TabStop = false;
			this.shipa_slot2.BackColor=SystemColors.ActiveCaption;
			this.shipa_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot2 = this.shipa_slot2;
			point = new Point(230, 124);
			shipaSlot2.Location = point;
			this.shipa_slot2.Name = "shipa_slot2";
			PictureBox shipaSlot21 = this.shipa_slot2;
			size = new Size(32, 32);
			shipaSlot21.Size = size;
			this.shipa_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipa_slot2.TabIndex = 158;
			this.shipa_slot2.TabStop = false;
			this.shipa_slot1.BackColor=SystemColors.ActiveCaption;
			this.shipa_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot1 = this.shipa_slot1;
			point = new Point(198, 124);
			shipaSlot1.Location = point;
			this.shipa_slot1.Name = "shipa_slot1";
			PictureBox shipaSlot11 = this.shipa_slot1;
			size = new Size(32, 32);
			shipaSlot11.Size = size;
			this.shipa_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipa_slot1.TabIndex = 157;
			this.shipa_slot1.TabStop = false;
			this.shipb_slot7.BackColor=SystemColors.ActiveCaption;
			this.shipb_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot7 = this.shipb_slot7;
			point = new Point(320, 212);
			shipbSlot7.Location = point;
			this.shipb_slot7.Name = "shipb_slot7";
			PictureBox shipbSlot71 = this.shipb_slot7;
			size = new Size(32, 32);
			shipbSlot71.Size = size;
			this.shipb_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipb_slot7.TabIndex = 169;
			this.shipb_slot7.TabStop = false;
			this.shipb_slot6.BackColor=SystemColors.ActiveCaption;
			this.shipb_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot6 = this.shipb_slot6;
			point = new Point(286, 212);
			shipbSlot6.Location = point;
			this.shipb_slot6.Name = "shipb_slot6";
			PictureBox shipbSlot61 = this.shipb_slot6;
			size = new Size(32, 32);
			shipbSlot61.Size = size;
			this.shipb_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipb_slot6.TabIndex = 168;
			this.shipb_slot6.TabStop = false;
			this.shipb_slot5.BackColor=SystemColors.ActiveCaption;
			this.shipb_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot5 = this.shipb_slot5;
			point = new Point(300, 174);
			shipbSlot5.Location = point;
			this.shipb_slot5.Name = "shipb_slot5";
			PictureBox shipbSlot51 = this.shipb_slot5;
			size = new Size(32, 32);
			shipbSlot51.Size = size;
			this.shipb_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipb_slot5.TabIndex = 167;
			this.shipb_slot5.TabStop = false;
			this.shipb_slot4.BackColor=SystemColors.ActiveCaption;
			this.shipb_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot4 = this.shipb_slot4;
			point = new Point(316, 142);
			shipbSlot4.Location = point;
			this.shipb_slot4.Name = "shipb_slot4";
			PictureBox shipbSlot41 = this.shipb_slot4;
			size = new Size(32, 32);
			shipbSlot41.Size = size;
			this.shipb_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipb_slot4.TabIndex = 166;
			this.shipb_slot4.TabStop = false;
			this.shipb_slot3.BackColor=SystemColors.ActiveCaption;
			this.shipb_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot3 = this.shipb_slot3;
			point = new Point(286, 142);
			shipbSlot3.Location = point;
			this.shipb_slot3.Name = "shipb_slot3";
			PictureBox shipbSlot31 = this.shipb_slot3;
			size = new Size(32, 32);
			shipbSlot31.Size = size;
			this.shipb_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipb_slot3.TabIndex = 165;
			this.shipb_slot3.TabStop = false;
			this.shipb_slot2.BackColor=SystemColors.ActiveCaption;
			this.shipb_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot2 = this.shipb_slot2;
			point = new Point(316, 112);
			shipbSlot2.Location = point;
			this.shipb_slot2.Name = "shipb_slot2";
			PictureBox shipbSlot21 = this.shipb_slot2;
			size = new Size(32, 32);
			shipbSlot21.Size = size;
			this.shipb_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipb_slot2.TabIndex = 164;
			this.shipb_slot2.TabStop = false;
			this.shipb_slot1.BackColor=SystemColors.ActiveCaption;
			this.shipb_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot1 = this.shipb_slot1;
			point = new Point(286, 112);
			shipbSlot1.Location = point;
			this.shipb_slot1.Name = "shipb_slot1";
			PictureBox shipbSlot11 = this.shipb_slot1;
			size = new Size(32, 32);
			shipbSlot11.Size = size;
			this.shipb_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipb_slot1.TabIndex = 163;
			this.shipb_slot1.TabStop = false;
			this.shipc_slot8.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot8 = this.shipc_slot8;
			point = new Point(398, 212);
			shipcSlot8.Location = point;
			this.shipc_slot8.Name = "shipc_slot8";
			PictureBox shipcSlot81 = this.shipc_slot8;
			size = new Size(32, 32);
			shipcSlot81.Size = size;
			this.shipc_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot8.TabIndex = 177;
			this.shipc_slot8.TabStop = false;
			this.shipc_slot7.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot7 = this.shipc_slot7;
			point = new Point(362, 212);
			shipcSlot7.Location = point;
			this.shipc_slot7.Name = "shipc_slot7";
			PictureBox shipcSlot71 = this.shipc_slot7;
			size = new Size(32, 32);
			shipcSlot71.Size = size;
			this.shipc_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot7.TabIndex = 176;
			this.shipc_slot7.TabStop = false;
			this.shipc_slot6.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot6 = this.shipc_slot6;
			point = new Point(398, 176);
			shipcSlot6.Location = point;
			this.shipc_slot6.Name = "shipc_slot6";
			PictureBox shipcSlot61 = this.shipc_slot6;
			size = new Size(32, 32);
			shipcSlot61.Size = size;
			this.shipc_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot6.TabIndex = 175;
			this.shipc_slot6.TabStop = false;
			this.shipc_slot5.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot5 = this.shipc_slot5;
			point = new Point(366, 176);
			shipcSlot5.Location = point;
			this.shipc_slot5.Name = "shipc_slot5";
			PictureBox shipcSlot51 = this.shipc_slot5;
			size = new Size(32, 32);
			shipcSlot51.Size = size;
			this.shipc_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot5.TabIndex = 174;
			this.shipc_slot5.TabStop = false;
			this.shipc_slot4.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot4 = this.shipc_slot4;
			point = new Point(398, 146);
			shipcSlot4.Location = point;
			this.shipc_slot4.Name = "shipc_slot4";
			PictureBox shipcSlot41 = this.shipc_slot4;
			size = new Size(32, 32);
			shipcSlot41.Size = size;
			this.shipc_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot4.TabIndex = 173;
			this.shipc_slot4.TabStop = false;
			this.shipc_slot3.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot3 = this.shipc_slot3;
			point = new Point(366, 146);
			shipcSlot3.Location = point;
			this.shipc_slot3.Name = "shipc_slot3";
			PictureBox shipcSlot31 = this.shipc_slot3;
			size = new Size(32, 32);
			shipcSlot31.Size = size;
			this.shipc_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot3.TabIndex = 172;
			this.shipc_slot3.TabStop = false;
			this.shipc_slot2.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot2 = this.shipc_slot2;
			point = new Point(398, 114);
			shipcSlot2.Location = point;
			this.shipc_slot2.Name = "shipc_slot2";
			PictureBox shipcSlot21 = this.shipc_slot2;
			size = new Size(32, 32);
			shipcSlot21.Size = size;
			this.shipc_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot2.TabIndex = 171;
			this.shipc_slot2.TabStop = false;
			this.shipc_slot1.BackColor=SystemColors.ActiveCaption;
			this.shipc_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot1 = this.shipc_slot1;
			point = new Point(366, 114);
			shipcSlot1.Location = point;
			this.shipc_slot1.Name = "shipc_slot1";
			PictureBox shipcSlot11 = this.shipc_slot1;
			size = new Size(32, 32);
			shipcSlot11.Size = size;
			this.shipc_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.shipc_slot1.TabIndex = 170;
			this.shipc_slot1.TabStop = false;
			size = new Size(5, 13);
			this.AutoScaleBaseSize = size;
			size = new Size(576, 402);
			this.ClientSize = size;
			this.Controls.Add(this.shipc_slot8);
			this.Controls.Add(this.shipc_slot7);
			this.Controls.Add(this.shipc_slot6);
			this.Controls.Add(this.shipc_slot5);
			this.Controls.Add(this.shipc_slot4);
			this.Controls.Add(this.shipc_slot3);
			this.Controls.Add(this.shipc_slot2);
			this.Controls.Add(this.shipc_slot1);
			this.Controls.Add(this.shipb_slot7);
			this.Controls.Add(this.shipb_slot6);
			this.Controls.Add(this.shipb_slot5);
			this.Controls.Add(this.shipb_slot4);
			this.Controls.Add(this.shipb_slot3);
			this.Controls.Add(this.shipb_slot2);
			this.Controls.Add(this.shipb_slot1);
			this.Controls.Add(this.shipa_slot6);
			this.Controls.Add(this.shipa_slot5);
			this.Controls.Add(this.shipa_slot4);
			this.Controls.Add(this.shipa_slot3);
			this.Controls.Add(this.shipa_slot2);
			this.Controls.Add(this.shipa_slot1);
			this.Controls.Add(this.PictureBox3);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox1);
			this.Name = "Captain1";
			this.Text = "Captain1";
			this.ResumeLayout(false);
		}
	}
}
