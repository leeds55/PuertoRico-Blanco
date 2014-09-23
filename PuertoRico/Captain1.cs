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
				return _PictureBox1;
			}
			set
			{
				_PictureBox1 = value;
			}
		}

		internal virtual PictureBox PictureBox2
		{
			get
			{
				return _PictureBox2;
			}
			set
			{
				_PictureBox2 = value;
			}
		}

		internal virtual PictureBox PictureBox3
		{
			get
			{
				return _PictureBox3;
			}
			set
			{
				_PictureBox3 = value;
			}
		}

		internal virtual PictureBox shipa_slot1
		{
			get
			{
				return _shipa_slot1;
			}
			set
			{
				_shipa_slot1 = value;
			}
		}

		internal virtual PictureBox shipa_slot2
		{
			get
			{
				return _shipa_slot2;
			}
			set
			{
				_shipa_slot2 = value;
			}
		}

		internal virtual PictureBox shipa_slot3
		{
			get
			{
				return _shipa_slot3;
			}
			set
			{
				_shipa_slot3 = value;
			}
		}

		internal virtual PictureBox shipa_slot4
		{
			get
			{
				return _shipa_slot4;
			}
			set
			{
				_shipa_slot4 = value;
			}
		}

		internal virtual PictureBox shipa_slot5
		{
			get
			{
				return _shipa_slot5;
			}
			set
			{
				_shipa_slot5 = value;
			}
		}

		internal virtual PictureBox shipa_slot6
		{
			get
			{
				return _shipa_slot6;
			}
			set
			{
				_shipa_slot6 = value;
			}
		}

		internal virtual PictureBox shipb_slot1
		{
			get
			{
				return _shipb_slot1;
			}
			set
			{
				_shipb_slot1 = value;
			}
		}

		internal virtual PictureBox shipb_slot2
		{
			get
			{
				return _shipb_slot2;
			}
			set
			{
				_shipb_slot2 = value;
			}
		}

		internal virtual PictureBox shipb_slot3
		{
			get
			{
				return _shipb_slot3;
			}
			set
			{
				_shipb_slot3 = value;
			}
		}

		internal virtual PictureBox shipb_slot4
		{
			get
			{
				return _shipb_slot4;
			}
			set
			{
				_shipb_slot4 = value;
			}
		}

		internal virtual PictureBox shipb_slot5
		{
			get
			{
				return _shipb_slot5;
			}
			set
			{
				_shipb_slot5 = value;
			}
		}

		internal virtual PictureBox shipb_slot6
		{
			get
			{
				return _shipb_slot6;
			}
			set
			{
				_shipb_slot6 = value;
			}
		}

		internal virtual PictureBox shipb_slot7
		{
			get
			{
				return _shipb_slot7;
			}
			set
			{
				_shipb_slot7 = value;
			}
		}

		internal virtual PictureBox shipc_slot1
		{
			get
			{
				return _shipc_slot1;
			}
			set
			{
				_shipc_slot1 = value;
			}
		}

		internal virtual PictureBox shipc_slot2
		{
			get
			{
				return _shipc_slot2;
			}
			set
			{
				_shipc_slot2 = value;
			}
		}

		internal virtual PictureBox shipc_slot3
		{
			get
			{
				return _shipc_slot3;
			}
			set
			{
				_shipc_slot3 = value;
			}
		}

		internal virtual PictureBox shipc_slot4
		{
			get
			{
				return _shipc_slot4;
			}
			set
			{
				_shipc_slot4 = value;
			}
		}

		internal virtual PictureBox shipc_slot5
		{
			get
			{
				return _shipc_slot5;
			}
			set
			{
				_shipc_slot5 = value;
			}
		}

		internal virtual PictureBox shipc_slot6
		{
			get
			{
				return _shipc_slot6;
			}
			set
			{
				_shipc_slot6 = value;
			}
		}

		internal virtual PictureBox shipc_slot7
		{
			get
			{
				return _shipc_slot7;
			}
			set
			{
				_shipc_slot7 = value;
			}
		}

		internal virtual PictureBox shipc_slot8
		{
			get
			{
				return _shipc_slot8;
			}
			set
			{
				_shipc_slot8 = value;
			}
		}

		public Captain1()
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
			ResourceManager resourceManager = new ResourceManager(typeof(Captain1));
			PictureBox3 = new PictureBox();
			PictureBox2 = new PictureBox();
			PictureBox1 = new PictureBox();
			shipa_slot6 = new PictureBox();
			shipa_slot5 = new PictureBox();
			shipa_slot4 = new PictureBox();
			shipa_slot3 = new PictureBox();
			shipa_slot2 = new PictureBox();
			shipa_slot1 = new PictureBox();
			shipb_slot7 = new PictureBox();
			shipb_slot6 = new PictureBox();
			shipb_slot5 = new PictureBox();
			shipb_slot4 = new PictureBox();
			shipb_slot3 = new PictureBox();
			shipb_slot2 = new PictureBox();
			shipb_slot1 = new PictureBox();
			shipc_slot8 = new PictureBox();
			shipc_slot7 = new PictureBox();
			shipc_slot6 = new PictureBox();
			shipc_slot5 = new PictureBox();
			shipc_slot4 = new PictureBox();
			shipc_slot3 = new PictureBox();
			shipc_slot2 = new PictureBox();
			shipc_slot1 = new PictureBox();
			SuspendLayout();
			PictureBox3.BackColor=SystemColors.ActiveCaption;
			PictureBox3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox3.Image=(Image)resourceManager.GetObject("PictureBox3.Image");
			PictureBox pictureBox3 = PictureBox3;
			Point point = new Point(360, 96);
			pictureBox3.Location = point;
			PictureBox3.Name="PictureBox3";
			PictureBox pictureBox = PictureBox3;
			Size size = new Size(76, 134);
			pictureBox.Size = size;
			PictureBox3.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox3.TabIndex=156;
			PictureBox3.TabStop = false;
			PictureBox3.Visible = false;
			PictureBox2.BackColor=SystemColors.ActiveCaption;
			PictureBox2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox2.Image = (Image)resourceManager.GetObject("PictureBox2.Image");
			PictureBox pictureBox2 = PictureBox2;
			point = new Point(280, 96);
			pictureBox2.Location = point;
			PictureBox2.Name = "PictureBox2";
			PictureBox pictureBox21 = PictureBox2;
			size = new Size(76, 134);
			pictureBox21.Size = size;
			PictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox2.TabIndex = 155;
			PictureBox2.TabStop = false;
			PictureBox2.Visible = false;
			PictureBox1.BackColor=SystemColors.ActiveCaption;
			PictureBox1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox1.Image = (Image)resourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = PictureBox1;
			point = new Point(192, 96);
			pictureBox1.Location = point;
			PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox11 = PictureBox1;
			size = new Size(76, 134);
			pictureBox11.Size = size;
			PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			PictureBox1.TabIndex = 154;
			PictureBox1.TabStop = false;
			PictureBox1.Visible = false;
			shipa_slot6.BackColor=SystemColors.ActiveCaption;
			shipa_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot6 = shipa_slot6;
			point = new Point(232, 206);
			shipaSlot6.Location = point;
			shipa_slot6.Name = "shipa_slot6";
			PictureBox shipaSlot61 = shipa_slot6;
			size = new Size(32, 32);
			shipaSlot61.Size = size;
			shipa_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			shipa_slot6.TabIndex = 162;
			shipa_slot6.TabStop = false;
			shipa_slot5.BackColor=SystemColors.ActiveCaption;
			shipa_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot5 = shipa_slot5;
			point = new Point(198, 206);
			shipaSlot5.Location = point;
			shipa_slot5.Name = "shipa_slot5";
			PictureBox shipaSlot51 = shipa_slot5;
			size = new Size(32, 32);
			shipaSlot51.Size = size;
			shipa_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			shipa_slot5.TabIndex = 161;
			shipa_slot5.TabStop = false;
			shipa_slot4.BackColor=SystemColors.ActiveCaption;
			shipa_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot4 = shipa_slot4;
			point = new Point(230, 158);
			shipaSlot4.Location = point;
			shipa_slot4.Name = "shipa_slot4";
			PictureBox shipaSlot41 = shipa_slot4;
			size = new Size(32, 32);
			shipaSlot41.Size = size;
			shipa_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			shipa_slot4.TabIndex = 160;
			shipa_slot4.TabStop = false;
			shipa_slot3.BackColor=SystemColors.ActiveCaption;
			shipa_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot3 = shipa_slot3;
			point = new Point(198, 158);
			shipaSlot3.Location = point;
			shipa_slot3.Name = "shipa_slot3";
			PictureBox shipaSlot31 = shipa_slot3;
			size = new Size(32, 32);
			shipaSlot31.Size = size;
			shipa_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			shipa_slot3.TabIndex = 159;
			shipa_slot3.TabStop = false;
			shipa_slot2.BackColor=SystemColors.ActiveCaption;
			shipa_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot2 = shipa_slot2;
			point = new Point(230, 124);
			shipaSlot2.Location = point;
			shipa_slot2.Name = "shipa_slot2";
			PictureBox shipaSlot21 = shipa_slot2;
			size = new Size(32, 32);
			shipaSlot21.Size = size;
			shipa_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			shipa_slot2.TabIndex = 158;
			shipa_slot2.TabStop = false;
			shipa_slot1.BackColor=SystemColors.ActiveCaption;
			shipa_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipaSlot1 = shipa_slot1;
			point = new Point(198, 124);
			shipaSlot1.Location = point;
			shipa_slot1.Name = "shipa_slot1";
			PictureBox shipaSlot11 = shipa_slot1;
			size = new Size(32, 32);
			shipaSlot11.Size = size;
			shipa_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			shipa_slot1.TabIndex = 157;
			shipa_slot1.TabStop = false;
			shipb_slot7.BackColor=SystemColors.ActiveCaption;
			shipb_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot7 = shipb_slot7;
			point = new Point(320, 212);
			shipbSlot7.Location = point;
			shipb_slot7.Name = "shipb_slot7";
			PictureBox shipbSlot71 = shipb_slot7;
			size = new Size(32, 32);
			shipbSlot71.Size = size;
			shipb_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			shipb_slot7.TabIndex = 169;
			shipb_slot7.TabStop = false;
			shipb_slot6.BackColor=SystemColors.ActiveCaption;
			shipb_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot6 = shipb_slot6;
			point = new Point(286, 212);
			shipbSlot6.Location = point;
			shipb_slot6.Name = "shipb_slot6";
			PictureBox shipbSlot61 = shipb_slot6;
			size = new Size(32, 32);
			shipbSlot61.Size = size;
			shipb_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			shipb_slot6.TabIndex = 168;
			shipb_slot6.TabStop = false;
			shipb_slot5.BackColor=SystemColors.ActiveCaption;
			shipb_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot5 = shipb_slot5;
			point = new Point(300, 174);
			shipbSlot5.Location = point;
			shipb_slot5.Name = "shipb_slot5";
			PictureBox shipbSlot51 = shipb_slot5;
			size = new Size(32, 32);
			shipbSlot51.Size = size;
			shipb_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			shipb_slot5.TabIndex = 167;
			shipb_slot5.TabStop = false;
			shipb_slot4.BackColor=SystemColors.ActiveCaption;
			shipb_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot4 = shipb_slot4;
			point = new Point(316, 142);
			shipbSlot4.Location = point;
			shipb_slot4.Name = "shipb_slot4";
			PictureBox shipbSlot41 = shipb_slot4;
			size = new Size(32, 32);
			shipbSlot41.Size = size;
			shipb_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			shipb_slot4.TabIndex = 166;
			shipb_slot4.TabStop = false;
			shipb_slot3.BackColor=SystemColors.ActiveCaption;
			shipb_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot3 = shipb_slot3;
			point = new Point(286, 142);
			shipbSlot3.Location = point;
			shipb_slot3.Name = "shipb_slot3";
			PictureBox shipbSlot31 = shipb_slot3;
			size = new Size(32, 32);
			shipbSlot31.Size = size;
			shipb_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			shipb_slot3.TabIndex = 165;
			shipb_slot3.TabStop = false;
			shipb_slot2.BackColor=SystemColors.ActiveCaption;
			shipb_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot2 = shipb_slot2;
			point = new Point(316, 112);
			shipbSlot2.Location = point;
			shipb_slot2.Name = "shipb_slot2";
			PictureBox shipbSlot21 = shipb_slot2;
			size = new Size(32, 32);
			shipbSlot21.Size = size;
			shipb_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			shipb_slot2.TabIndex = 164;
			shipb_slot2.TabStop = false;
			shipb_slot1.BackColor=SystemColors.ActiveCaption;
			shipb_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipbSlot1 = shipb_slot1;
			point = new Point(286, 112);
			shipbSlot1.Location = point;
			shipb_slot1.Name = "shipb_slot1";
			PictureBox shipbSlot11 = shipb_slot1;
			size = new Size(32, 32);
			shipbSlot11.Size = size;
			shipb_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			shipb_slot1.TabIndex = 163;
			shipb_slot1.TabStop = false;
			shipc_slot8.BackColor=SystemColors.ActiveCaption;
			shipc_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot8 = shipc_slot8;
			point = new Point(398, 212);
			shipcSlot8.Location = point;
			shipc_slot8.Name = "shipc_slot8";
			PictureBox shipcSlot81 = shipc_slot8;
			size = new Size(32, 32);
			shipcSlot81.Size = size;
			shipc_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot8.TabIndex = 177;
			shipc_slot8.TabStop = false;
			shipc_slot7.BackColor=SystemColors.ActiveCaption;
			shipc_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot7 = shipc_slot7;
			point = new Point(362, 212);
			shipcSlot7.Location = point;
			shipc_slot7.Name = "shipc_slot7";
			PictureBox shipcSlot71 = shipc_slot7;
			size = new Size(32, 32);
			shipcSlot71.Size = size;
			shipc_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot7.TabIndex = 176;
			shipc_slot7.TabStop = false;
			shipc_slot6.BackColor=SystemColors.ActiveCaption;
			shipc_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot6 = shipc_slot6;
			point = new Point(398, 176);
			shipcSlot6.Location = point;
			shipc_slot6.Name = "shipc_slot6";
			PictureBox shipcSlot61 = shipc_slot6;
			size = new Size(32, 32);
			shipcSlot61.Size = size;
			shipc_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot6.TabIndex = 175;
			shipc_slot6.TabStop = false;
			shipc_slot5.BackColor=SystemColors.ActiveCaption;
			shipc_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot5 = shipc_slot5;
			point = new Point(366, 176);
			shipcSlot5.Location = point;
			shipc_slot5.Name = "shipc_slot5";
			PictureBox shipcSlot51 = shipc_slot5;
			size = new Size(32, 32);
			shipcSlot51.Size = size;
			shipc_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot5.TabIndex = 174;
			shipc_slot5.TabStop = false;
			shipc_slot4.BackColor=SystemColors.ActiveCaption;
			shipc_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot4 = shipc_slot4;
			point = new Point(398, 146);
			shipcSlot4.Location = point;
			shipc_slot4.Name = "shipc_slot4";
			PictureBox shipcSlot41 = shipc_slot4;
			size = new Size(32, 32);
			shipcSlot41.Size = size;
			shipc_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot4.TabIndex = 173;
			shipc_slot4.TabStop = false;
			shipc_slot3.BackColor=SystemColors.ActiveCaption;
			shipc_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot3 = shipc_slot3;
			point = new Point(366, 146);
			shipcSlot3.Location = point;
			shipc_slot3.Name = "shipc_slot3";
			PictureBox shipcSlot31 = shipc_slot3;
			size = new Size(32, 32);
			shipcSlot31.Size = size;
			shipc_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot3.TabIndex = 172;
			shipc_slot3.TabStop = false;
			shipc_slot2.BackColor=SystemColors.ActiveCaption;
			shipc_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot2 = shipc_slot2;
			point = new Point(398, 114);
			shipcSlot2.Location = point;
			shipc_slot2.Name = "shipc_slot2";
			PictureBox shipcSlot21 = shipc_slot2;
			size = new Size(32, 32);
			shipcSlot21.Size = size;
			shipc_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot2.TabIndex = 171;
			shipc_slot2.TabStop = false;
			shipc_slot1.BackColor=SystemColors.ActiveCaption;
			shipc_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox shipcSlot1 = shipc_slot1;
			point = new Point(366, 114);
			shipcSlot1.Location = point;
			shipc_slot1.Name = "shipc_slot1";
			PictureBox shipcSlot11 = shipc_slot1;
			size = new Size(32, 32);
			shipcSlot11.Size = size;
			shipc_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			shipc_slot1.TabIndex = 170;
			shipc_slot1.TabStop = false;
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(576, 402);
			ClientSize = size;
			Controls.Add(shipc_slot8);
			Controls.Add(shipc_slot7);
			Controls.Add(shipc_slot6);
			Controls.Add(shipc_slot5);
			Controls.Add(shipc_slot4);
			Controls.Add(shipc_slot3);
			Controls.Add(shipc_slot2);
			Controls.Add(shipc_slot1);
			Controls.Add(shipb_slot7);
			Controls.Add(shipb_slot6);
			Controls.Add(shipb_slot5);
			Controls.Add(shipb_slot4);
			Controls.Add(shipb_slot3);
			Controls.Add(shipb_slot2);
			Controls.Add(shipb_slot1);
			Controls.Add(shipa_slot6);
			Controls.Add(shipa_slot5);
			Controls.Add(shipa_slot4);
			Controls.Add(shipa_slot3);
			Controls.Add(shipa_slot2);
			Controls.Add(shipa_slot1);
			Controls.Add(PictureBox3);
			Controls.Add(PictureBox2);
			Controls.Add(PictureBox1);
			Name = "Captain1";
			Text = "Captain1";
			ResumeLayout(false);
		}
	}
}
