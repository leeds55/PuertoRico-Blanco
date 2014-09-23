using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Player3 : Form
	{
		[AccessedThroughProperty("gold_label")]
		private Label _gold_label;

		[AccessedThroughProperty("plant_p3_slot2")]
		private PictureBox _plant_p3_slot2;

		[AccessedThroughProperty("p3_close_button")]
		private Button _p3_close_button;

		[AccessedThroughProperty("plant_p3_slot12")]
		private PictureBox _plant_p3_slot12;

		[AccessedThroughProperty("governor_pic")]
		private PictureBox _governor_pic;

		[AccessedThroughProperty("build_p3_slot19")]
		private PictureBox _build_p3_slot19;

		[AccessedThroughProperty("build_p3_slot17")]
		private PictureBox _build_p3_slot17;

		[AccessedThroughProperty("player_board_pic")]
		private PictureBox _player_board_pic;

		[AccessedThroughProperty("build_p3_slot15")]
		private PictureBox _build_p3_slot15;

		[AccessedThroughProperty("build_p3_slot13")]
		private PictureBox _build_p3_slot13;

		[AccessedThroughProperty("plant_p3_slot3")]
		private PictureBox _plant_p3_slot3;

		[AccessedThroughProperty("plant_p3_slot4")]
		private PictureBox _plant_p3_slot4;

		[AccessedThroughProperty("plant_p3_slot5")]
		private PictureBox _plant_p3_slot5;

		[AccessedThroughProperty("plant_p3_slot6")]
		private PictureBox _plant_p3_slot6;

		[AccessedThroughProperty("plant_p3_slot7")]
		private PictureBox _plant_p3_slot7;

		[AccessedThroughProperty("build_p3_slot20")]
		private PictureBox _build_p3_slot20;

		[AccessedThroughProperty("build_p3_slot11")]
		private PictureBox _build_p3_slot11;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("plant_p3_slot8")]
		private PictureBox _plant_p3_slot8;

		[AccessedThroughProperty("plant_p3_slot9")]
		private PictureBox _plant_p3_slot9;

		[AccessedThroughProperty("build_p3_slot10")]
		private PictureBox _build_p3_slot10;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("build_p3_slot8")]
		private PictureBox _build_p3_slot8;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("build_p3_slot7")]
		private PictureBox _build_p3_slot7;

		[AccessedThroughProperty("vp_chips_label")]
		private Label _vp_chips_label;

		[AccessedThroughProperty("build_p3_slot5")]
		private PictureBox _build_p3_slot5;

		[AccessedThroughProperty("plant_p3_slot10")]
		private PictureBox _plant_p3_slot10;

		[AccessedThroughProperty("build_p3_slot18")]
		private PictureBox _build_p3_slot18;

		[AccessedThroughProperty("plant_p3_slot11")]
		private PictureBox _plant_p3_slot11;

		[AccessedThroughProperty("vp_total_label")]
		private Label _vp_total_label;

		[AccessedThroughProperty("build_p3_slot4")]
		private PictureBox _build_p3_slot4;

		[AccessedThroughProperty("idle_colonists_label")]
		private Label _idle_colonists_label;

		[AccessedThroughProperty("build_p3_slot2")]
		private PictureBox _build_p3_slot2;

		[AccessedThroughProperty("num_coffee_label")]
		private Label _num_coffee_label;

		[AccessedThroughProperty("build_p3_slot1")]
		private PictureBox _build_p3_slot1;

		[AccessedThroughProperty("num_tobacco_label")]
		private Label _num_tobacco_label;

		[AccessedThroughProperty("build_p3_slot12")]
		private PictureBox _build_p3_slot12;

		[AccessedThroughProperty("num_corn_label")]
		private Label _num_corn_label;

		[AccessedThroughProperty("build_p3_slot9")]
		private PictureBox _build_p3_slot9;

		[AccessedThroughProperty("num_sugar_label")]
		private Label _num_sugar_label;

		[AccessedThroughProperty("build_p3_slot16")]
		private PictureBox _build_p3_slot16;

		[AccessedThroughProperty("build_p3_slot6")]
		private PictureBox _build_p3_slot6;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("num_indigo_label")]
		private Label _num_indigo_label;

		[AccessedThroughProperty("build_p3_slot3")]
		private PictureBox _build_p3_slot3;

		[AccessedThroughProperty("plant_p3_slot1")]
		private PictureBox _plant_p3_slot1;

		[AccessedThroughProperty("build_p3_slot14")]
		private PictureBox _build_p3_slot14;

		private IContainer components;

		internal virtual PictureBox build_p3_slot1
		{
			get
			{
				return _build_p3_slot1;
			}
			set
			{
				_build_p3_slot1 = value;
			}
		}

		internal virtual PictureBox build_p3_slot10
		{
			get
			{
				return _build_p3_slot10;
			}
			set
			{
				_build_p3_slot10 = value;
			}
		}

		internal virtual PictureBox build_p3_slot11
		{
			get
			{
				return _build_p3_slot11;
			}
			set
			{
				_build_p3_slot11 = value;
			}
		}

		internal virtual PictureBox build_p3_slot12
		{
			get
			{
				return _build_p3_slot12;
			}
			set
			{
				_build_p3_slot12 = value;
			}
		}

		internal virtual PictureBox build_p3_slot13
		{
			get
			{
				return _build_p3_slot13;
			}
			set
			{
				_build_p3_slot13 = value;
			}
		}

		internal virtual PictureBox build_p3_slot14
		{
			get
			{
				return _build_p3_slot14;
			}
			set
			{
				_build_p3_slot14 = value;
			}
		}

		internal virtual PictureBox build_p3_slot15
		{
			get
			{
				return _build_p3_slot15;
			}
			set
			{
				_build_p3_slot15 = value;
			}
		}

		internal virtual PictureBox build_p3_slot16
		{
			get
			{
				return _build_p3_slot16;
			}
			set
			{
				_build_p3_slot16 = value;
			}
		}

		internal virtual PictureBox build_p3_slot17
		{
			get
			{
				return _build_p3_slot17;
			}
			set
			{
				_build_p3_slot17 = value;
			}
		}

		internal virtual PictureBox build_p3_slot18
		{
			get
			{
				return _build_p3_slot18;
			}
			set
			{
				_build_p3_slot18 = value;
			}
		}

		internal virtual PictureBox build_p3_slot19
		{
			get
			{
				return _build_p3_slot19;
			}
			set
			{
				_build_p3_slot19 = value;
			}
		}

		internal virtual PictureBox build_p3_slot2
		{
			get
			{
				return _build_p3_slot2;
			}
			set
			{
				_build_p3_slot2 = value;
			}
		}

		internal virtual PictureBox build_p3_slot20
		{
			get
			{
				return _build_p3_slot20;
			}
			set
			{
				_build_p3_slot20 = value;
			}
		}

		internal virtual PictureBox build_p3_slot3
		{
			get
			{
				return _build_p3_slot3;
			}
			set
			{
				_build_p3_slot3 = value;
			}
		}

		internal virtual PictureBox build_p3_slot4
		{
			get
			{
				return _build_p3_slot4;
			}
			set
			{
				_build_p3_slot4 = value;
			}
		}

		internal virtual PictureBox build_p3_slot5
		{
			get
			{
				return _build_p3_slot5;
			}
			set
			{
				_build_p3_slot5 = value;
			}
		}

		internal virtual PictureBox build_p3_slot6
		{
			get
			{
				return _build_p3_slot6;
			}
			set
			{
				_build_p3_slot6 = value;
			}
		}

		internal virtual PictureBox build_p3_slot7
		{
			get
			{
				return _build_p3_slot7;
			}
			set
			{
				_build_p3_slot7 = value;
			}
		}

		internal virtual PictureBox build_p3_slot8
		{
			get
			{
				return _build_p3_slot8;
			}
			set
			{
				_build_p3_slot8 = value;
			}
		}

		internal virtual PictureBox build_p3_slot9
		{
			get
			{
				return _build_p3_slot9;
			}
			set
			{
				_build_p3_slot9 = value;
			}
		}

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
					Player3 player3 = this;
					_Button1.Click -=new EventHandler(player3.Button1_Click);
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					Player3 player31 = this;
					_Button1.Click +=new EventHandler(player31.Button1_Click);
				}
			}
		}

		internal virtual Label gold_label
		{
			get
			{
				return _gold_label;
			}
			set
			{
				_gold_label = value;
			}
		}

		internal virtual PictureBox governor_pic
		{
			get
			{
				return _governor_pic;
			}
			set
			{
				_governor_pic = value;
			}
		}

		internal virtual Label idle_colonists_label
		{
			get
			{
				return _idle_colonists_label;
			}
			set
			{
				_idle_colonists_label = value;
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

		internal virtual Label num_coffee_label
		{
			get
			{
				return _num_coffee_label;
			}
			set
			{
				_num_coffee_label = value;
			}
		}

		internal virtual Label num_corn_label
		{
			get
			{
				return _num_corn_label;
			}
			set
			{
				_num_corn_label = value;
			}
		}

		internal virtual Label num_indigo_label
		{
			get
			{
				return _num_indigo_label;
			}
			set
			{
				_num_indigo_label = value;
			}
		}

		internal virtual Label num_sugar_label
		{
			get
			{
				return _num_sugar_label;
			}
			set
			{
				_num_sugar_label = value;
			}
		}

		internal virtual Label num_tobacco_label
		{
			get
			{
				return _num_tobacco_label;
			}
			set
			{
				_num_tobacco_label = value;
			}
		}

		internal virtual Button p3_close_button
		{
			get
			{
				return _p3_close_button;
			}
			set
			{
				if (_p3_close_button != null)
				{
					Player3 player3 = this;
					_p3_close_button.Click -=new EventHandler(player3.p3_close_button_Click);
				}
				_p3_close_button = value;
				if (_p3_close_button != null)
				{
					Player3 player31 = this;
					_p3_close_button.Click +=new EventHandler(player31.p3_close_button_Click);
				}
			}
		}

		internal virtual PictureBox plant_p3_slot1
		{
			get
			{
				return _plant_p3_slot1;
			}
			set
			{
				_plant_p3_slot1 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot10
		{
			get
			{
				return _plant_p3_slot10;
			}
			set
			{
				_plant_p3_slot10 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot11
		{
			get
			{
				return _plant_p3_slot11;
			}
			set
			{
				_plant_p3_slot11 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot12
		{
			get
			{
				return _plant_p3_slot12;
			}
			set
			{
				_plant_p3_slot12 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot2
		{
			get
			{
				return _plant_p3_slot2;
			}
			set
			{
				_plant_p3_slot2 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot3
		{
			get
			{
				return _plant_p3_slot3;
			}
			set
			{
				_plant_p3_slot3 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot4
		{
			get
			{
				return _plant_p3_slot4;
			}
			set
			{
				_plant_p3_slot4 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot5
		{
			get
			{
				return _plant_p3_slot5;
			}
			set
			{
				_plant_p3_slot5 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot6
		{
			get
			{
				return _plant_p3_slot6;
			}
			set
			{
				_plant_p3_slot6 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot7
		{
			get
			{
				return _plant_p3_slot7;
			}
			set
			{
				_plant_p3_slot7 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot8
		{
			get
			{
				return _plant_p3_slot8;
			}
			set
			{
				_plant_p3_slot8 = value;
			}
		}

		internal virtual PictureBox plant_p3_slot9
		{
			get
			{
				return _plant_p3_slot9;
			}
			set
			{
				_plant_p3_slot9 = value;
			}
		}

		internal virtual PictureBox player_board_pic
		{
			get
			{
				return _player_board_pic;
			}
			set
			{
				_player_board_pic = value;
			}
		}

		internal virtual Label vp_chips_label
		{
			get
			{
				return _vp_chips_label;
			}
			set
			{
				_vp_chips_label = value;
			}
		}

		internal virtual Label vp_total_label
		{
			get
			{
				return _vp_total_label;
			}
			set
			{
				_vp_total_label = value;
			}
		}

		public Player3()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (!vp_chips_label.Visible)
			{
				vp_chips_label.Visible = true;
				vp_total_label.Visible = true;
				Label4.Visible = true;
				Label5.Visible = true;
			}
			else
			{
				vp_chips_label.Visible = false;
				vp_total_label.Visible = false;
				Label4.Visible = false;
				Label5.Visible = false;
			}
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
			ResourceManager resourceManager = new ResourceManager(typeof(Player3));
			player_board_pic = new PictureBox();
			plant_p3_slot12 = new PictureBox();
			plant_p3_slot11 = new PictureBox();
			plant_p3_slot10 = new PictureBox();
			plant_p3_slot9 = new PictureBox();
			plant_p3_slot8 = new PictureBox();
			plant_p3_slot7 = new PictureBox();
			plant_p3_slot6 = new PictureBox();
			plant_p3_slot5 = new PictureBox();
			plant_p3_slot4 = new PictureBox();
			plant_p3_slot3 = new PictureBox();
			plant_p3_slot2 = new PictureBox();
			plant_p3_slot1 = new PictureBox();
			governor_pic = new PictureBox();
			Label5 = new Label();
			Label4 = new Label();
			vp_chips_label = new Label();
			vp_total_label = new Label();
			Label1 = new Label();
			gold_label = new Label();
			idle_colonists_label = new Label();
			num_coffee_label = new Label();
			num_tobacco_label = new Label();
			num_corn_label = new Label();
			num_sugar_label = new Label();
			num_indigo_label = new Label();
			p3_close_button = new Button();
			build_p3_slot11 = new PictureBox();
			build_p3_slot10 = new PictureBox();
			build_p3_slot8 = new PictureBox();
			build_p3_slot7 = new PictureBox();
			build_p3_slot5 = new PictureBox();
			build_p3_slot4 = new PictureBox();
			build_p3_slot2 = new PictureBox();
			build_p3_slot1 = new PictureBox();
			build_p3_slot12 = new PictureBox();
			build_p3_slot9 = new PictureBox();
			build_p3_slot6 = new PictureBox();
			build_p3_slot3 = new PictureBox();
			build_p3_slot14 = new PictureBox();
			build_p3_slot16 = new PictureBox();
			build_p3_slot18 = new PictureBox();
			build_p3_slot20 = new PictureBox();
			build_p3_slot13 = new PictureBox();
			build_p3_slot15 = new PictureBox();
			build_p3_slot17 = new PictureBox();
			build_p3_slot19 = new PictureBox();
			Button1 = new Button();
			SuspendLayout();
			player_board_pic.Image = (Image)resourceManager.GetObject("player_board_pic.Image");
			PictureBox playerBoardPic = player_board_pic;
			Point point = new Point(0, 0);
			playerBoardPic.Location = point;
			player_board_pic.Name = "player_board_pic";
			PictureBox pictureBox = player_board_pic;
			Size size = new Size(824, 624);
			pictureBox.Size = size;
			player_board_pic.SizeMode = PictureBoxSizeMode.CenterImage;
			player_board_pic.TabIndex=3;
			player_board_pic.TabStop = false;
			plant_p3_slot12.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot12.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot12 = plant_p3_slot12;
			point = new Point(410, 404);
			plantP3Slot12.Location = point;
			plant_p3_slot12.Name = "plant_p3_slot12";
			PictureBox plantP3Slot121 = plant_p3_slot12;
			size = new Size(72, 74);
			plantP3Slot121.Size = size;
			plant_p3_slot12.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot12.TabIndex = 148;
			plant_p3_slot12.TabStop = false;
			plant_p3_slot12.Visible = false;
			plant_p3_slot11.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot11.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot11 = plant_p3_slot11;
			point = new Point(334, 446);
			plantP3Slot11.Location = point;
			plant_p3_slot11.Name = "plant_p3_slot11";
			PictureBox plantP3Slot111 = plant_p3_slot11;
			size = new Size(72, 74);
			plantP3Slot111.Size = size;
			plant_p3_slot11.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot11.TabIndex = 147;
			plant_p3_slot11.TabStop = false;
			plant_p3_slot11.Visible = false;
			plant_p3_slot10.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot10.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot10 = plant_p3_slot10;
			point = new Point(334, 370);
			plantP3Slot10.Location = point;
			plant_p3_slot10.Name = "plant_p3_slot10";
			PictureBox plantP3Slot101 = plant_p3_slot10;
			size = new Size(72, 74);
			plantP3Slot101.Size = size;
			plant_p3_slot10.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot10.TabIndex = 146;
			plant_p3_slot10.TabStop = false;
			plant_p3_slot10.Visible = false;
			plant_p3_slot9.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot9.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot9 = plant_p3_slot9;
			point = new Point(258, 486);
			plantP3Slot9.Location = point;
			plant_p3_slot9.Name = "plant_p3_slot9";
			PictureBox plantP3Slot91 = plant_p3_slot9;
			size = new Size(72, 74);
			plantP3Slot91.Size = size;
			plant_p3_slot9.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot9.TabIndex = 145;
			plant_p3_slot9.TabStop = false;
			plant_p3_slot9.Visible = false;
			plant_p3_slot8.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot8 = plant_p3_slot8;
			point = new Point(258, 410);
			plantP3Slot8.Location = point;
			plant_p3_slot8.Name = "plant_p3_slot8";
			PictureBox plantP3Slot81 = plant_p3_slot8;
			size = new Size(72, 74);
			plantP3Slot81.Size = size;
			plant_p3_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot8.TabIndex = 144;
			plant_p3_slot8.TabStop = false;
			plant_p3_slot8.Visible = false;
			plant_p3_slot7.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot7 = plant_p3_slot7;
			point = new Point(258, 332);
			plantP3Slot7.Location = point;
			plant_p3_slot7.Name = "plant_p3_slot7";
			PictureBox plantP3Slot71 = plant_p3_slot7;
			size = new Size(72, 74);
			plantP3Slot71.Size = size;
			plant_p3_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot7.TabIndex = 143;
			plant_p3_slot7.TabStop = false;
			plant_p3_slot7.Visible = false;
			plant_p3_slot6.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot6 = plant_p3_slot6;
			point = new Point(182, 462);
			plantP3Slot6.Location = point;
			plant_p3_slot6.Name = "plant_p3_slot6";
			PictureBox plantP3Slot61 = plant_p3_slot6;
			size = new Size(72, 74);
			plantP3Slot61.Size = size;
			plant_p3_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot6.TabIndex = 142;
			plant_p3_slot6.TabStop = false;
			plant_p3_slot6.Visible = false;
			plant_p3_slot5.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot5 = plant_p3_slot5;
			point = new Point(182, 386);
			plantP3Slot5.Location = point;
			plant_p3_slot5.Name = "plant_p3_slot5";
			PictureBox plantP3Slot51 = plant_p3_slot5;
			size = new Size(72, 74);
			plantP3Slot51.Size = size;
			plant_p3_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot5.TabIndex = 141;
			plant_p3_slot5.TabStop = false;
			plant_p3_slot5.Visible = false;
			plant_p3_slot4.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot4 = plant_p3_slot4;
			point = new Point(182, 308);
			plantP3Slot4.Location = point;
			plant_p3_slot4.Name = "plant_p3_slot4";
			PictureBox plantP3Slot41 = plant_p3_slot4;
			size = new Size(72, 74);
			plantP3Slot41.Size = size;
			plant_p3_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot4.TabIndex = 140;
			plant_p3_slot4.TabStop = false;
			plant_p3_slot4.Visible = false;
			plant_p3_slot3.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot3 = plant_p3_slot3;
			point = new Point(106, 496);
			plantP3Slot3.Location = point;
			plant_p3_slot3.Name = "plant_p3_slot3";
			PictureBox plantP3Slot31 = plant_p3_slot3;
			size = new Size(72, 74);
			plantP3Slot31.Size = size;
			plant_p3_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot3.TabIndex = 139;
			plant_p3_slot3.TabStop = false;
			plant_p3_slot3.Visible = false;
			plant_p3_slot2.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot2 = plant_p3_slot2;
			point = new Point(106, 420);
			plantP3Slot2.Location = point;
			plant_p3_slot2.Name = "plant_p3_slot2";
			PictureBox plantP3Slot21 = plant_p3_slot2;
			size = new Size(72, 74);
			plantP3Slot21.Size = size;
			plant_p3_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot2.TabIndex = 138;
			plant_p3_slot2.TabStop = false;
			plant_p3_slot2.Visible = false;
			plant_p3_slot1.BackColor=SystemColors.ActiveCaption;
			plant_p3_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox plantP3Slot1 = plant_p3_slot1;
			point = new Point(106, 342);
			plantP3Slot1.Location = point;
			plant_p3_slot1.Name = "plant_p3_slot1";
			PictureBox pictureBox1 = plant_p3_slot1;
			size = new Size(72, 74);
			pictureBox1.Size = size;
			plant_p3_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			plant_p3_slot1.TabIndex = 137;
			plant_p3_slot1.TabStop = false;
			plant_p3_slot1.Visible = false;
			governor_pic.Image = (Image)resourceManager.GetObject("governor_pic.Image");
			PictureBox governorPic = governor_pic;
			point = new Point(424, 512);
			governorPic.Location = point;
			governor_pic.Name = "governor_pic";
			PictureBox governorPic1 = governor_pic;
			size = new Size(52, 72);
			governorPic1.Size = size;
			governor_pic.SizeMode=PictureBoxSizeMode.AutoSize;
			governor_pic.TabIndex = 180;
			governor_pic.TabStop = false;
			Label5.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label5 = Label5;
			point = new Point(20, 564);
			label5.Location = point;
			Label5.Name = "Label5";
			Label label = Label5;
			size = new Size(72, 16);
			label.Size = size;
			Label5.TabIndex = 179;
			Label5.Text = "VP Total";
			Label5.TextAlign = ContentAlignment.MiddleCenter;
			Label5.Visible = false;
			Label4.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label4 = Label4;
			point = new Point(20, 492);
			label4.Location = point;
			Label4.Name = "Label4";
			Label label41 = Label4;
			size = new Size(72, 16);
			label41.Size = size;
			Label4.TabIndex = 178;
			Label4.Text = "VP Chips";
			Label4.TextAlign = ContentAlignment.MiddleCenter;
			Label4.Visible = false;
			vp_chips_label.BackColor = SystemColors.ActiveBorder;
			vp_chips_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label vpChipsLabel = vp_chips_label;
			point = new Point(36, 460);
			vpChipsLabel.Location = point;
			vp_chips_label.Name = "vp_chips_label";
			Label vpChipsLabel1 = vp_chips_label;
			size = new Size(36, 32);
			vpChipsLabel1.Size = size;
			vp_chips_label.TabIndex = 177;
			vp_chips_label.Text = "99";
			vp_chips_label.TextAlign = ContentAlignment.MiddleCenter;
			vp_chips_label.Visible = false;
			vp_total_label.BackColor = SystemColors.ActiveBorder;
			vp_total_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label vpTotalLabel = vp_total_label;
			point = new Point(36, 532);
			vpTotalLabel.Location = point;
			vp_total_label.Name = "vp_total_label";
			Label vpTotalLabel1 = vp_total_label;
			size = new Size(36, 32);
			vpTotalLabel1.Size = size;
			vp_total_label.TabIndex = 176;
			vp_total_label.Text = "99";
			vp_total_label.TextAlign = ContentAlignment.MiddleCenter;
			vp_total_label.Visible = false;
			Label1.Font = new Font("Comic Sans MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = Label1;
			point = new Point(20, 428);
			label1.Location = point;
			Label1.Name = "Label1";
			Label label11 = Label1;
			size = new Size(72, 16);
			label11.Size = size;
			Label1.TabIndex = 175;
			Label1.Text = "Doubloons";
			Label1.TextAlign = ContentAlignment.MiddleCenter;
			gold_label.BackColor = SystemColors.ActiveBorder;
			gold_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label goldLabel = gold_label;
			point = new Point(36, 396);
			goldLabel.Location = point;
			gold_label.Name = "gold_label";
			Label goldLabel1 = gold_label;
			size = new Size(36, 32);
			goldLabel1.Size = size;
			gold_label.TabIndex = 174;
			gold_label.Text = "99";
			gold_label.TextAlign = ContentAlignment.MiddleCenter;
			idle_colonists_label.BackColor = SystemColors.ActiveBorder;
			idle_colonists_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label idleColonistsLabel = idle_colonists_label;
			point = new Point(52, 284);
			idleColonistsLabel.Location = point;
			idle_colonists_label.Name = "idle_colonists_label";
			Label idleColonistsLabel1 = idle_colonists_label;
			size = new Size(36, 32);
			idleColonistsLabel1.Size = size;
			idle_colonists_label.TabIndex = 173;
			idle_colonists_label.Text = "99";
			idle_colonists_label.TextAlign = ContentAlignment.MiddleCenter;
			num_coffee_label.BackColor = Color.SaddleBrown;
			num_coffee_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			num_coffee_label.ForeColor=SystemColors.ActiveCaptionText;
			Label numCoffeeLabel = num_coffee_label;
			point = new Point(406, 264);
			numCoffeeLabel.Location = point;
			num_coffee_label.Name = "num_coffee_label";
			Label numCoffeeLabel1 = num_coffee_label;
			size = new Size(36, 32);
			numCoffeeLabel1.Size = size;
			num_coffee_label.TabIndex = 172;
			num_coffee_label.Text = "99";
			num_coffee_label.TextAlign = ContentAlignment.MiddleCenter;
			num_tobacco_label.BackColor=Color.Goldenrod;
			num_tobacco_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numTobaccoLabel = num_tobacco_label;
			point = new Point(350, 264);
			numTobaccoLabel.Location = point;
			num_tobacco_label.Name = "num_tobacco_label";
			Label numTobaccoLabel1 = num_tobacco_label;
			size = new Size(36, 32);
			numTobaccoLabel1.Size = size;
			num_tobacco_label.TabIndex = 171;
			num_tobacco_label.Text = "99";
			num_tobacco_label.TextAlign = ContentAlignment.MiddleCenter;
			num_corn_label.BackColor = Color.Yellow;
			num_corn_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numCornLabel = num_corn_label;
			point = new Point(294, 264);
			numCornLabel.Location = point;
			num_corn_label.Name = "num_corn_label";
			Label numCornLabel1 = num_corn_label;
			size = new Size(36, 32);
			numCornLabel1.Size = size;
			num_corn_label.TabIndex = 170;
			num_corn_label.Text = "99";
			num_corn_label.TextAlign = ContentAlignment.MiddleCenter;
			num_sugar_label.BackColor = Color.White;
			num_sugar_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label numSugarLabel = num_sugar_label;
			point = new Point(238, 264);
			numSugarLabel.Location = point;
			num_sugar_label.Name = "num_sugar_label";
			Label numSugarLabel1 = num_sugar_label;
			size = new Size(36, 32);
			numSugarLabel1.Size = size;
			num_sugar_label.TabIndex = 169;
			num_sugar_label.Text = "99";
			num_sugar_label.TextAlign = ContentAlignment.MiddleCenter;
			num_indigo_label.BackColor = Color.Blue;
			num_indigo_label.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			num_indigo_label.ForeColor=SystemColors.ActiveCaptionText;
			Label numIndigoLabel = num_indigo_label;
			point = new Point(182, 264);
			numIndigoLabel.Location = point;
			num_indigo_label.Name = "num_indigo_label";
			Label numIndigoLabel1 = num_indigo_label;
			size = new Size(36, 32);
			numIndigoLabel1.Size = size;
			num_indigo_label.TabIndex = 168;
			num_indigo_label.Text = "99";
			num_indigo_label.TextAlign = ContentAlignment.MiddleCenter;
			Button p3CloseButton = p3_close_button;
			point = new Point(210, 570);
			p3CloseButton.Location = point;
			p3_close_button.Name = "p3_close_button";
			p3_close_button.TabIndex = 167;
			p3_close_button.Text = "Close";
			build_p3_slot11.BackColor=SystemColors.ActiveCaption;
			build_p3_slot11.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot11 = build_p3_slot11;
			point = new Point(376, 118);
			buildP3Slot11.Location = point;
			build_p3_slot11.Name = "build_p3_slot11";
			PictureBox buildP3Slot111 = build_p3_slot11;
			size = new Size(114, 64);
			buildP3Slot111.Size = size;
			build_p3_slot11.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot11.TabIndex = 192;
			build_p3_slot11.TabStop = false;
			build_p3_slot11.Visible = false;
			build_p3_slot10.BackColor=SystemColors.ActiveCaption;
			build_p3_slot10.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot10 = build_p3_slot10;
			point = new Point(376, 50);
			buildP3Slot10.Location = point;
			build_p3_slot10.Name = "build_p3_slot10";
			PictureBox buildP3Slot101 = build_p3_slot10;
			size = new Size(114, 64);
			buildP3Slot101.Size = size;
			build_p3_slot10.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot10.TabIndex = 191;
			build_p3_slot10.TabStop = false;
			build_p3_slot10.Visible = false;
			build_p3_slot8.BackColor=SystemColors.ActiveCaption;
			build_p3_slot8.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot8 = build_p3_slot8;
			point = new Point(260, 118);
			buildP3Slot8.Location = point;
			build_p3_slot8.Name = "build_p3_slot8";
			PictureBox buildP3Slot81 = build_p3_slot8;
			size = new Size(114, 64);
			buildP3Slot81.Size = size;
			build_p3_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot8.TabIndex = 190;
			build_p3_slot8.TabStop = false;
			build_p3_slot8.Visible = false;
			build_p3_slot7.BackColor=SystemColors.ActiveCaption;
			build_p3_slot7.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot7 = build_p3_slot7;
			point = new Point(260, 50);
			buildP3Slot7.Location = point;
			build_p3_slot7.Name = "build_p3_slot7";
			PictureBox buildP3Slot71 = build_p3_slot7;
			size = new Size(114, 64);
			buildP3Slot71.Size = size;
			build_p3_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot7.TabIndex = 189;
			build_p3_slot7.TabStop = false;
			build_p3_slot7.Visible = false;
			build_p3_slot5.BackColor=SystemColors.ActiveCaption;
			build_p3_slot5.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot5 = build_p3_slot5;
			point = new Point(144, 118);
			buildP3Slot5.Location = point;
			build_p3_slot5.Name = "build_p3_slot5";
			PictureBox buildP3Slot51 = build_p3_slot5;
			size = new Size(114, 64);
			buildP3Slot51.Size = size;
			build_p3_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot5.TabIndex = 188;
			build_p3_slot5.TabStop = false;
			build_p3_slot5.Visible = false;
			build_p3_slot4.BackColor=SystemColors.ActiveCaption;
			build_p3_slot4.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot4 = build_p3_slot4;
			point = new Point(144, 50);
			buildP3Slot4.Location = point;
			build_p3_slot4.Name = "build_p3_slot4";
			PictureBox buildP3Slot41 = build_p3_slot4;
			size = new Size(114, 64);
			buildP3Slot41.Size = size;
			build_p3_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot4.TabIndex = 187;
			build_p3_slot4.TabStop = false;
			build_p3_slot4.Visible = false;
			build_p3_slot2.BackColor=SystemColors.ActiveCaption;
			build_p3_slot2.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot2 = build_p3_slot2;
			point = new Point(28, 118);
			buildP3Slot2.Location = point;
			build_p3_slot2.Name = "build_p3_slot2";
			PictureBox buildP3Slot21 = build_p3_slot2;
			size = new Size(114, 64);
			buildP3Slot21.Size = size;
			build_p3_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot2.TabIndex = 186;
			build_p3_slot2.TabStop = false;
			build_p3_slot2.Visible = false;
			build_p3_slot1.BackColor=SystemColors.ActiveCaption;
			build_p3_slot1.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot1 = build_p3_slot1;
			point = new Point(28, 50);
			buildP3Slot1.Location = point;
			build_p3_slot1.Name = "build_p3_slot1";
			PictureBox buildP3Slot12 = build_p3_slot1;
			size = new Size(114, 64);
			buildP3Slot12.Size = size;
			build_p3_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot1.TabIndex = 185;
			build_p3_slot1.TabStop = false;
			build_p3_slot1.Visible = false;
			build_p3_slot12.BackColor=SystemColors.ActiveCaption;
			build_p3_slot12.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot121 = build_p3_slot12;
			point = new Point(376, 186);
			buildP3Slot121.Location = point;
			build_p3_slot12.Name = "build_p3_slot12";
			PictureBox buildP3Slot122 = build_p3_slot12;
			size = new Size(114, 64);
			buildP3Slot122.Size = size;
			build_p3_slot12.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot12.TabIndex = 184;
			build_p3_slot12.TabStop = false;
			build_p3_slot12.Visible = false;
			build_p3_slot9.BackColor=SystemColors.ActiveCaption;
			build_p3_slot9.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot9 = build_p3_slot9;
			point = new Point(260, 186);
			buildP3Slot9.Location = point;
			build_p3_slot9.Name = "build_p3_slot9";
			PictureBox buildP3Slot91 = build_p3_slot9;
			size = new Size(114, 64);
			buildP3Slot91.Size = size;
			build_p3_slot9.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot9.TabIndex = 183;
			build_p3_slot9.TabStop = false;
			build_p3_slot9.Visible = false;
			build_p3_slot6.BackColor=SystemColors.ActiveCaption;
			build_p3_slot6.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot6 = build_p3_slot6;
			point = new Point(144, 186);
			buildP3Slot6.Location = point;
			build_p3_slot6.Name = "build_p3_slot6";
			PictureBox buildP3Slot61 = build_p3_slot6;
			size = new Size(114, 64);
			buildP3Slot61.Size = size;
			build_p3_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot6.TabIndex = 182;
			build_p3_slot6.TabStop = false;
			build_p3_slot6.Visible = false;
			build_p3_slot3.BackColor=SystemColors.ActiveCaption;
			build_p3_slot3.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot3 = build_p3_slot3;
			point = new Point(28, 186);
			buildP3Slot3.Location = point;
			build_p3_slot3.Name = "build_p3_slot3";
			PictureBox buildP3Slot31 = build_p3_slot3;
			size = new Size(114, 64);
			buildP3Slot31.Size = size;
			build_p3_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot3.TabIndex = 181;
			build_p3_slot3.TabStop = false;
			build_p3_slot3.Visible = false;
			build_p3_slot14.BackColor=SystemColors.ActiveCaption;
			build_p3_slot14.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot14 = build_p3_slot14;
			point = new Point(28, 118);
			buildP3Slot14.Location = point;
			build_p3_slot14.Name = "build_p3_slot14";
			PictureBox buildP3Slot141 = build_p3_slot14;
			size = new Size(114, 132);
			buildP3Slot141.Size = size;
			build_p3_slot14.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot14.TabIndex = 200;
			build_p3_slot14.TabStop = false;
			build_p3_slot14.Visible = false;
			build_p3_slot16.BackColor=SystemColors.ActiveCaption;
			build_p3_slot16.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot16 = build_p3_slot16;
			point = new Point(144, 118);
			buildP3Slot16.Location = point;
			build_p3_slot16.Name = "build_p3_slot16";
			PictureBox buildP3Slot161 = build_p3_slot16;
			size = new Size(114, 132);
			buildP3Slot161.Size = size;
			build_p3_slot16.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot16.TabIndex = 199;
			build_p3_slot16.TabStop = false;
			build_p3_slot16.Visible = false;
			build_p3_slot18.BackColor=SystemColors.ActiveCaption;
			build_p3_slot18.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot18 = build_p3_slot18;
			point = new Point(260, 118);
			buildP3Slot18.Location = point;
			build_p3_slot18.Name = "build_p3_slot18";
			PictureBox buildP3Slot181 = build_p3_slot18;
			size = new Size(114, 132);
			buildP3Slot181.Size = size;
			build_p3_slot18.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot18.TabIndex = 198;
			build_p3_slot18.TabStop = false;
			build_p3_slot18.Visible = false;
			build_p3_slot20.BackColor=SystemColors.ActiveCaption;
			build_p3_slot20.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot20 = build_p3_slot20;
			point = new Point(376, 118);
			buildP3Slot20.Location = point;
			build_p3_slot20.Name = "build_p3_slot20";
			PictureBox buildP3Slot201 = build_p3_slot20;
			size = new Size(114, 132);
			buildP3Slot201.Size = size;
			build_p3_slot20.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot20.TabIndex = 197;
			build_p3_slot20.TabStop = false;
			build_p3_slot20.Visible = false;
			build_p3_slot13.BackColor=SystemColors.ActiveCaption;
			build_p3_slot13.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot13 = build_p3_slot13;
			point = new Point(28, 50);
			buildP3Slot13.Location = point;
			build_p3_slot13.Name = "build_p3_slot13";
			PictureBox buildP3Slot131 = build_p3_slot13;
			size = new Size(114, 132);
			buildP3Slot131.Size = size;
			build_p3_slot13.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot13.TabIndex = 196;
			build_p3_slot13.TabStop = false;
			build_p3_slot13.Visible = false;
			build_p3_slot15.BackColor=SystemColors.ActiveCaption;
			build_p3_slot15.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot15 = build_p3_slot15;
			point = new Point(144, 50);
			buildP3Slot15.Location = point;
			build_p3_slot15.Name = "build_p3_slot15";
			PictureBox buildP3Slot151 = build_p3_slot15;
			size = new Size(114, 132);
			buildP3Slot151.Size = size;
			build_p3_slot15.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot15.TabIndex = 195;
			build_p3_slot15.TabStop = false;
			build_p3_slot15.Visible = false;
			build_p3_slot17.BackColor=SystemColors.ActiveCaption;
			build_p3_slot17.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot17 = build_p3_slot17;
			point = new Point(260, 50);
			buildP3Slot17.Location = point;
			build_p3_slot17.Name = "build_p3_slot17";
			PictureBox buildP3Slot171 = build_p3_slot17;
			size = new Size(114, 132);
			buildP3Slot171.Size = size;
			build_p3_slot17.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot17.TabIndex = 194;
			build_p3_slot17.TabStop = false;
			build_p3_slot17.Visible = false;
			build_p3_slot19.BackColor=SystemColors.ActiveCaption;
			build_p3_slot19.BorderStyle=BorderStyle.FixedSingle;
			PictureBox buildP3Slot19 = build_p3_slot19;
			point = new Point(376, 50);
			buildP3Slot19.Location = point;
			build_p3_slot19.Name = "build_p3_slot19";
			PictureBox buildP3Slot191 = build_p3_slot19;
			size = new Size(114, 132);
			buildP3Slot191.Size = size;
			build_p3_slot19.SizeMode=PictureBoxSizeMode.AutoSize;
			build_p3_slot19.TabIndex = 193;
			build_p3_slot19.TabStop = false;
			build_p3_slot19.Visible = false;
			Button button1 = Button1;
			point = new Point(20, 586);
			button1.Location = point;
			Button1.Name = "Button1";
			Button1.TabIndex = 201;
			Button1.Text = "Points";
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(512, 610);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(Button1);
			Controls.Add(build_p3_slot14);
			Controls.Add(build_p3_slot16);
			Controls.Add(build_p3_slot18);
			Controls.Add(build_p3_slot20);
			Controls.Add(build_p3_slot13);
			Controls.Add(build_p3_slot15);
			Controls.Add(build_p3_slot17);
			Controls.Add(build_p3_slot19);
			Controls.Add(build_p3_slot11);
			Controls.Add(build_p3_slot10);
			Controls.Add(build_p3_slot8);
			Controls.Add(build_p3_slot7);
			Controls.Add(build_p3_slot5);
			Controls.Add(build_p3_slot4);
			Controls.Add(build_p3_slot2);
			Controls.Add(build_p3_slot1);
			Controls.Add(build_p3_slot12);
			Controls.Add(build_p3_slot9);
			Controls.Add(build_p3_slot6);
			Controls.Add(build_p3_slot3);
			Controls.Add(governor_pic);
			Controls.Add(Label5);
			Controls.Add(Label4);
			Controls.Add(vp_chips_label);
			Controls.Add(vp_total_label);
			Controls.Add(Label1);
			Controls.Add(gold_label);
			Controls.Add(idle_colonists_label);
			Controls.Add(num_coffee_label);
			Controls.Add(num_tobacco_label);
			Controls.Add(num_corn_label);
			Controls.Add(num_sugar_label);
			Controls.Add(num_indigo_label);
			Controls.Add(p3_close_button);
			Controls.Add(plant_p3_slot12);
			Controls.Add(plant_p3_slot11);
			Controls.Add(plant_p3_slot10);
			Controls.Add(plant_p3_slot9);
			Controls.Add(plant_p3_slot8);
			Controls.Add(plant_p3_slot7);
			Controls.Add(plant_p3_slot6);
			Controls.Add(plant_p3_slot5);
			Controls.Add(plant_p3_slot4);
			Controls.Add(plant_p3_slot3);
			Controls.Add(plant_p3_slot2);
			Controls.Add(plant_p3_slot1);
			Controls.Add(player_board_pic);
			size = new Size(520, 648);
			MaximumSize = size;
			size = new Size(520, 648);
			MinimumSize = size;
			Name = "Player3";
			Text = "Player3";
			ResumeLayout(false);
		}

		private void p3_close_button_Click(object sender, EventArgs e)
		{
			Visible = false;
		}
	}
}
