using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PuertoRico
{
	public class Buildings : Form
	{
		[AccessedThroughProperty("avail_buildings_slot1")]
		private PictureBox _avail_buildings_slot1;

		[AccessedThroughProperty("avail_buildings_slot2")]
		private PictureBox _avail_buildings_slot2;

		[AccessedThroughProperty("avail_buildings_slot3")]
		private PictureBox _avail_buildings_slot3;

		[AccessedThroughProperty("avail_buildings_slot0")]
		private PictureBox _avail_buildings_slot0;

		[AccessedThroughProperty("close_buildings_button")]
		private Button _close_buildings_button;

		[AccessedThroughProperty("avail_buildings_slot5")]
		private PictureBox _avail_buildings_slot5;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("avail_buildings_slot4")]
		private PictureBox _avail_buildings_slot4;

		[AccessedThroughProperty("avail_buildings_slot11")]
		private PictureBox _avail_buildings_slot11;

		[AccessedThroughProperty("avail_buildings_slot10")]
		private PictureBox _avail_buildings_slot10;

		[AccessedThroughProperty("avail_buildings_slot9")]
		private PictureBox _avail_buildings_slot9;

		[AccessedThroughProperty("do_not_build_button")]
		private Button _do_not_build_button;

		[AccessedThroughProperty("avail_buildings_slot8")]
		private PictureBox _avail_buildings_slot8;

		[AccessedThroughProperty("avail_buildings_slot7")]
		private PictureBox _avail_buildings_slot7;

		[AccessedThroughProperty("avail_buildings_slot6")]
		private PictureBox _avail_buildings_slot6;

		[AccessedThroughProperty("avail_buildings_slot17")]
		private PictureBox _avail_buildings_slot17;

		[AccessedThroughProperty("avail_buildings_slot16")]
		private PictureBox _avail_buildings_slot16;

		[AccessedThroughProperty("avail_buildings_slot15")]
		private PictureBox _avail_buildings_slot15;

		[AccessedThroughProperty("avail_buildings_slot14")]
		private PictureBox _avail_buildings_slot14;

		[AccessedThroughProperty("avail_buildings_slot13")]
		private PictureBox _avail_buildings_slot13;

		[AccessedThroughProperty("avail_buildings_slot12")]
		private PictureBox _avail_buildings_slot12;

		[AccessedThroughProperty("avail_buildings_slot18")]
		private PictureBox _avail_buildings_slot18;

		[AccessedThroughProperty("avail_buildings_slot19")]
		private PictureBox _avail_buildings_slot19;

		[AccessedThroughProperty("avail_buildings_slot20")]
		private PictureBox _avail_buildings_slot20;

		[AccessedThroughProperty("avail_buildings_slot21")]
		private PictureBox _avail_buildings_slot21;

		[AccessedThroughProperty("avail_buildings_slot22")]
		private PictureBox _avail_buildings_slot22;

		private IContainer components;

		public int[] buildings_available_array2;

		public int[] buildings_p1_arrayb;

		public int counter1b;

		public bool builder_roundb;

		public int current_playerb;

		public int current_role_chooserb;

		public bool p1_builtb;

		public bool found_buildingb;

		public int gold_p1b;

		public int num_manned_quarries_p1b;

		public bool builder_bonusb;

		public bool university_bonusb;

		public int discount1;

		public int discount2;

		public int cost;

		public int quarrycost;

		public int buildercost;

		public int basecost;

		public bool afford;

		public bool finishedb;

		public int build_spot;

		public bool confirmedb;

		public bool p1_built_nothingb;

		public string tempstringb;

		public int dialog_box_OK_timerb;

		public Confirmbuilding1 confirmbuilding1_formb;

		public Confirmbuilding2 confirmbuilding2_formb;

		public Confirmnopic confirmnopic_formb;

		public Infobuilding1 infobuilding1_formb;

		public Infobuilding2 infobuilding2_formb;

		public Infopurchase1 infopurchase1_form;

		public Infopurchase2 infopurchase2_form;

		internal virtual PictureBox avail_buildings_slot0
		{
			get
			{
				return _avail_buildings_slot0;
			}
			set
			{
				if (_avail_buildings_slot0 != null)
				{
					Buildings building = this;
					_avail_buildings_slot0.Click -=new EventHandler(building.avail_buildings_slot0_Click);
				}
				_avail_buildings_slot0 = value;
				if (_avail_buildings_slot0 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot0.Click +=new EventHandler(building1.avail_buildings_slot0_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot1
		{
			get
			{
				return _avail_buildings_slot1;
			}
			set
			{
				if (_avail_buildings_slot1 != null)
				{
					Buildings building = this;
					_avail_buildings_slot1.Click -=new EventHandler(building.avail_buildings_slot1_Click);
				}
				_avail_buildings_slot1 = value;
				if (_avail_buildings_slot1 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot1.Click +=new EventHandler(building1.avail_buildings_slot1_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot10
		{
			get
			{
				return _avail_buildings_slot10;
			}
			set
			{
				if (_avail_buildings_slot10 != null)
				{
					Buildings building = this;
					_avail_buildings_slot10.Click -=new EventHandler(building.avail_buildings_slot10_Click);
				}
				_avail_buildings_slot10 = value;
				if (_avail_buildings_slot10 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot10.Click +=new EventHandler(building1.avail_buildings_slot10_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot11
		{
			get
			{
				return _avail_buildings_slot11;
			}
			set
			{
				if (_avail_buildings_slot11 != null)
				{
					Buildings building = this;
					_avail_buildings_slot11.Click -=new EventHandler(building.avail_buildings_slot11_Click);
				}
				_avail_buildings_slot11 = value;
				if (_avail_buildings_slot11 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot11.Click +=new EventHandler(building1.avail_buildings_slot11_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot12
		{
			get
			{
				return _avail_buildings_slot12;
			}
			set
			{
				if (_avail_buildings_slot12 != null)
				{
					Buildings building = this;
					_avail_buildings_slot12.Click -=new EventHandler(building.avail_buildings_slot12_Click);
				}
				_avail_buildings_slot12 = value;
				if (_avail_buildings_slot12 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot12.Click +=new EventHandler(building1.avail_buildings_slot12_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot13
		{
			get
			{
				return _avail_buildings_slot13;
			}
			set
			{
				if (_avail_buildings_slot13 != null)
				{
					Buildings building = this;
					_avail_buildings_slot13.Click -=new EventHandler(building.avail_buildings_slot13_Click);
				}
				_avail_buildings_slot13 = value;
				if (_avail_buildings_slot13 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot13.Click +=new EventHandler(building1.avail_buildings_slot13_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot14
		{
			get
			{
				return _avail_buildings_slot14;
			}
			set
			{
				if (_avail_buildings_slot14 != null)
				{
					Buildings building = this;
					_avail_buildings_slot14.Click -=new EventHandler(building.avail_buildings_slot14_Click);
				}
				_avail_buildings_slot14 = value;
				if (_avail_buildings_slot14 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot14.Click +=new EventHandler(building1.avail_buildings_slot14_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot15
		{
			get
			{
				return _avail_buildings_slot15;
			}
			set
			{
				if (_avail_buildings_slot15 != null)
				{
					Buildings building = this;
					_avail_buildings_slot15.Click -=new EventHandler(building.avail_buildings_slot15_Click);
				}
				_avail_buildings_slot15 = value;
				if (_avail_buildings_slot15 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot15.Click +=new EventHandler(building1.avail_buildings_slot15_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot16
		{
			get
			{
				return _avail_buildings_slot16;
			}
			set
			{
				if (_avail_buildings_slot16 != null)
				{
					Buildings building = this;
					_avail_buildings_slot16.Click -=new EventHandler(building.avail_buildings_slot16_Click);
				}
				_avail_buildings_slot16 = value;
				if (_avail_buildings_slot16 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot16.Click +=new EventHandler(building1.avail_buildings_slot16_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot17
		{
			get
			{
				return _avail_buildings_slot17;
			}
			set
			{
				if (_avail_buildings_slot17 != null)
				{
					Buildings building = this;
					_avail_buildings_slot17.Click -=new EventHandler(building.avail_buildings_slot17_Click);
				}
				_avail_buildings_slot17 = value;
				if (_avail_buildings_slot17 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot17.Click +=new EventHandler(building1.avail_buildings_slot17_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot18
		{
			get
			{
				return _avail_buildings_slot18;
			}
			set
			{
				if (_avail_buildings_slot18 != null)
				{
					Buildings building = this;
					_avail_buildings_slot18.Click -=new EventHandler(building.avail_buildings_slot18_Click);
				}
				_avail_buildings_slot18 = value;
				if (_avail_buildings_slot18 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot18.Click +=new EventHandler(building1.avail_buildings_slot18_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot19
		{
			get
			{
				return _avail_buildings_slot19;
			}
			set
			{
				if (_avail_buildings_slot19 != null)
				{
					Buildings building = this;
					_avail_buildings_slot19.Click -=new EventHandler(building.avail_buildings_slot19_Click);
				}
				_avail_buildings_slot19 = value;
				if (_avail_buildings_slot19 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot19.Click +=new EventHandler(building1.avail_buildings_slot19_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot2
		{
			get
			{
				return _avail_buildings_slot2;
			}
			set
			{
				if (_avail_buildings_slot2 != null)
				{
					Buildings building = this;
					_avail_buildings_slot2.Click -=new EventHandler(building.avail_buildings_slot2_Click);
				}
				_avail_buildings_slot2 = value;
				if (_avail_buildings_slot2 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot2.Click +=new EventHandler(building1.avail_buildings_slot2_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot20
		{
			get
			{
				return _avail_buildings_slot20;
			}
			set
			{
				if (_avail_buildings_slot20 != null)
				{
					Buildings building = this;
					_avail_buildings_slot20.Click -=new EventHandler(building.avail_buildings_slot20_Click);
				}
				_avail_buildings_slot20 = value;
				if (_avail_buildings_slot20 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot20.Click +=new EventHandler(building1.avail_buildings_slot20_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot21
		{
			get
			{
				return _avail_buildings_slot21;
			}
			set
			{
				if (_avail_buildings_slot21 != null)
				{
					Buildings building = this;
					_avail_buildings_slot21.Click -=new EventHandler(building.avail_buildings_slot21_Click);
				}
				_avail_buildings_slot21 = value;
				if (_avail_buildings_slot21 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot21.Click +=new EventHandler(building1.avail_buildings_slot21_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot22
		{
			get
			{
				return _avail_buildings_slot22;
			}
			set
			{
				if (_avail_buildings_slot22 != null)
				{
					Buildings building = this;
					_avail_buildings_slot22.Click -=new EventHandler(building.avail_buildings_slot22_Click);
				}
				_avail_buildings_slot22 = value;
				if (_avail_buildings_slot22 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot22.Click +=new EventHandler(building1.avail_buildings_slot22_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot3
		{
			get
			{
				return _avail_buildings_slot3;
			}
			set
			{
				if (_avail_buildings_slot3 != null)
				{
					Buildings building = this;
					_avail_buildings_slot3.Click -=new EventHandler(building.avail_buildings_slot3_Click);
				}
				_avail_buildings_slot3 = value;
				if (_avail_buildings_slot3 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot3.Click +=new EventHandler(building1.avail_buildings_slot3_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot4
		{
			get
			{
				return _avail_buildings_slot4;
			}
			set
			{
				if (_avail_buildings_slot4 != null)
				{
					Buildings building = this;
					_avail_buildings_slot4.Click -=new EventHandler(building.avail_buildings_slot4_Click);
				}
				_avail_buildings_slot4 = value;
				if (_avail_buildings_slot4 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot4.Click +=new EventHandler(building1.avail_buildings_slot4_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot5
		{
			get
			{
				return _avail_buildings_slot5;
			}
			set
			{
				if (_avail_buildings_slot5 != null)
				{
					Buildings building = this;
					_avail_buildings_slot5.Click -=new EventHandler(building.avail_buildings_slot5_Click);
				}
				_avail_buildings_slot5 = value;
				if (_avail_buildings_slot5 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot5.Click +=new EventHandler(building1.avail_buildings_slot5_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot6
		{
			get
			{
				return _avail_buildings_slot6;
			}
			set
			{
				if (_avail_buildings_slot6 != null)
				{
					Buildings building = this;
					_avail_buildings_slot6.Click -=new EventHandler(building.avail_buildings_slot6_Click);
				}
				_avail_buildings_slot6 = value;
				if (_avail_buildings_slot6 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot6.Click +=new EventHandler(building1.avail_buildings_slot6_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot7
		{
			get
			{
				return _avail_buildings_slot7;
			}
			set
			{
				if (_avail_buildings_slot7 != null)
				{
					Buildings building = this;
					_avail_buildings_slot7.Click -=new EventHandler(building.avail_buildings_slot7_Click);
				}
				_avail_buildings_slot7 = value;
				if (_avail_buildings_slot7 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot7.Click +=new EventHandler(building1.avail_buildings_slot7_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot8
		{
			get
			{
				return _avail_buildings_slot8;
			}
			set
			{
				if (_avail_buildings_slot8 != null)
				{
					Buildings building = this;
					_avail_buildings_slot8.Click -=new EventHandler(building.avail_buildings_slot8_Click);
				}
				_avail_buildings_slot8 = value;
				if (_avail_buildings_slot8 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot8.Click +=new EventHandler(building1.avail_buildings_slot8_Click);
				}
			}
		}

		internal virtual PictureBox avail_buildings_slot9
		{
			get
			{
				return _avail_buildings_slot9;
			}
			set
			{
				if (_avail_buildings_slot9 != null)
				{
					Buildings building = this;
					_avail_buildings_slot9.Click -=new EventHandler(building.avail_buildings_slot9_Click);
				}
				_avail_buildings_slot9 = value;
				if (_avail_buildings_slot9 != null)
				{
					Buildings building1 = this;
					_avail_buildings_slot9.Click +=new EventHandler(building1.avail_buildings_slot9_Click);
				}
			}
		}

		internal virtual Button close_buildings_button
		{
			get
			{
				return _close_buildings_button;
			}
			set
			{
				if (_close_buildings_button != null)
				{
					Buildings building = this;
					_close_buildings_button.Click -=new EventHandler(building.close_buildings_button_Click);
				}
				_close_buildings_button = value;
				if (_close_buildings_button != null)
				{
					Buildings building1 = this;
					_close_buildings_button.Click +=new EventHandler(building1.close_buildings_button_Click);
				}
			}
		}

		internal virtual Button do_not_build_button
		{
			get
			{
				return _do_not_build_button;
			}
			set
			{
				if (_do_not_build_button != null)
				{
					Buildings building = this;
					_do_not_build_button.Click -=new EventHandler(building.do_not_build_button_Click);
				}
				_do_not_build_button = value;
				if (_do_not_build_button != null)
				{
					Buildings building1 = this;
					_do_not_build_button.Click +=new EventHandler(building1.do_not_build_button_Click);
				}
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

		public Buildings()
		{
			int[] numArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			buildings_available_array2 = numArray;
			int[] numArray1 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			buildings_p1_arrayb = numArray1;
			counter1b = 0;
			builder_roundb = false;
			current_playerb = 0;
			current_role_chooserb = 0;
			p1_builtb = false;
			found_buildingb = false;
			gold_p1b = 0;
			num_manned_quarries_p1b = 0;
			builder_bonusb = false;
			university_bonusb = false;
			discount1 = 0;
			discount2 = 0;
			cost = 0;
			quarrycost = 0;
			buildercost = 0;
			basecost = 0;
			afford = false;
			finishedb = true;
			build_spot = 0;
			confirmedb = false;
			p1_built_nothingb = false;
			confirmbuilding1_formb = new Confirmbuilding1();
			confirmbuilding2_formb = new Confirmbuilding2();
			confirmnopic_formb = new Confirmnopic();
			infobuilding1_formb = new Infobuilding1();
			infobuilding2_formb = new Infobuilding2();
			infopurchase1_form = new Infopurchase1();
			infopurchase2_form = new Infopurchase2();
			InitializeComponent();
		}

		private void avail_buildings_slot0_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[0]);
			basecost = 1;
			if (num_manned_quarries_p1b < 1)
			{
				discount1 = 0;
			}
			else
			{
				discount1 = 1;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Small Indigo Plant", "1 Colonist Capacity to Produce Indigo", "1 VP", 110);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(110);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Small Indigo Plant - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Small Indigo Plant", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Small Indigo Plant for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 110);
					if (confirmedb)
					{
						buildings_available_array2[0] = checked(buildings_available_array2[0] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 110;
							infobox_building1("You built the Small Indigo Plant", 110);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 111;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot1_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[1]);
			basecost = 2;
			if (num_manned_quarries_p1b < 1)
			{
				discount1 = 0;
			}
			else
			{
				discount1 = 1;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Small Sugar Mill", "1 colonist capacity to produce Sugar", "1 VP", 120);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(120);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Small Sugar Mill - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Small Sugar Mill", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Small Sugar Mill for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 120);
					if (confirmedb)
					{
						buildings_available_array2[1] = checked(buildings_available_array2[1] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 120;
							infobox_building1("You built the Small Sugar Mill", 120);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 121;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot10_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[10]);
			basecost = 5;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b >= 2)
			{
				discount1 = 2;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Large Market", "+2 doubloons with sale to Trading House during Trader Phase", "2 VP", 250);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(250);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Large Market - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Large Market", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Large Market for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 250);
					if (confirmedb)
					{
						buildings_available_array2[10] = checked(buildings_available_array2[10] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 250;
							infobox_building1("You built the Large Market", 250);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 251;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot11_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[11]);
			basecost = 6;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b >= 2)
			{
				discount1 = 2;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Large Warehouse", "Store all of 2 types of goods at end of Captain Phase", "2 VP", 260);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(260);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Large Warehouse - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Large Warehouse", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Large Warehouse for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 260);
					if (confirmedb)
					{
						buildings_available_array2[11] = checked(buildings_available_array2[11] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 260;
							infobox_building1("You built the Large Warehouse", 260);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 261;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot12_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[12]);
			basecost = 5;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b >= 3)
			{
				discount1 = 3;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Tobacco Storage", "3 colonist capacity to produce Tobacco", "3 VP", 310);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(310);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Tobacco Storage - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Tobacco Storage", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Tobacco Storage for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 310);
					if (confirmedb)
					{
						buildings_available_array2[12] = checked(buildings_available_array2[12] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 310;
							infobox_building1("You built the Tobacco Storage", 310);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 311;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot13_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[13]);
			basecost = 6;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b >= 3)
			{
				discount1 = 3;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Coffee Roaster", "2 colonist capacity to produce Tobacco", "3 VP", 320);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(320);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Coffee Roaster - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Coffee Roaster", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Coffee Roaster for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 320);
					if (confirmedb)
					{
						buildings_available_array2[13] = checked(buildings_available_array2[13] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 320;
							infobox_building1("You built the Coffee Roaster", 320);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 321;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot14_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[14]);
			basecost = 7;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b >= 3)
			{
				discount1 = 3;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Factory", "+0 / +1 / +2 / +3 / +5 doubloons for production of different types of goods during Craftsman Phase", "3 VP", 330);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(330);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Factory - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Factory", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Factory for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 330);
					if (confirmedb)
					{
						buildings_available_array2[14] = checked(buildings_available_array2[14] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 330;
							infobox_building1("You built the Factory", 330);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 331;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot15_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[15]);
			basecost = 8;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b >= 3)
			{
				discount1 = 3;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("University", "Free colonist for the newly built structure during Builder Phase", "3 VP", 340);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(340);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the University - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the University", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the University for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 340);
					if (confirmedb)
					{
						buildings_available_array2[15] = checked(buildings_available_array2[15] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 340;
							infobox_building1("You built the University", 340);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 341;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot16_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[16]);
			basecost = 8;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b >= 3)
			{
				discount1 = 3;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Harbor", "+1 Victory Point per delivery", "3 VP", 350);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(350);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Harbor - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Harbor", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Harbor for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 350);
					if (confirmedb)
					{
						buildings_available_array2[16] = checked(buildings_available_array2[16] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 350;
							infobox_building1("You built the Harbor", 350);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 351;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot17_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[17]);
			basecost = 9;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b >= 3)
			{
				discount1 = 3;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Wharf", "Your own ship for use once per Captain Phase", "3 VP", 360);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(360);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Wharf - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Wharf", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Wharf for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 360);
					if (confirmedb)
					{
						buildings_available_array2[17] = checked(buildings_available_array2[17] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 360;
							infobox_building1("You built the Wharf", 360);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 361;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot18_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[18]);
			basecost = 10;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b == 3)
			{
				discount1 = 3;
			}
			if (num_manned_quarries_p1b == 4)
			{
				discount1 = 4;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase2("Guild Hall", "At game end: 2VP per large prod plant / 1VP per small prod plant ", "4+X VP", 410);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(410);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Guild Hall - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Guild Hall", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Guild Hall for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building2(string.Concat(strArray), 410);
					if (confirmedb)
					{
						determine_where_to_build_large();
						if (build_spot != 99)
						{
							buildings_available_array2[18] = checked(buildings_available_array2[18] - 1);
							gold_p1b = checked(gold_p1b - cost);
							if (!university_bonusb)
							{
								buildings_p1_arrayb[build_spot] = 410;
								infobox_building2("You built the Guild Hall", 410);
							}
							else
							{
								buildings_p1_arrayb[build_spot] = 411;
							}
							p1_builtb = true;
							Close();
						}
						else
						{
							infobox_building2("You don't have enough room to build the Guild Hall", 410);
						}
					}
				}
			}
		}

		private void avail_buildings_slot19_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[19]);
			basecost = 10;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b == 3)
			{
				discount1 = 3;
			}
			if (num_manned_quarries_p1b == 4)
			{
				discount1 = 4;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase2("Residence", "At game end: VP per #of plantations: <=9/4VP 10/5vp 11/6VP 12/7VP  ", "4+X VP", 420);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(420);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Residence - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Residence", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Residence for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building2(string.Concat(strArray), 420);
					if (confirmedb)
					{
						determine_where_to_build_large();
						if (build_spot != 99)
						{
							buildings_available_array2[19] = checked(buildings_available_array2[19] - 1);
							gold_p1b = checked(gold_p1b - cost);
							if (!university_bonusb)
							{
								buildings_p1_arrayb[build_spot] = 420;
								infobox_building2("You built the Residence", 420);
							}
							else
							{
								buildings_p1_arrayb[build_spot] = 421;
							}
							p1_builtb = true;
							Close();
						}
						else
						{
							infobox_building2("You don't have enough room to build the Residence", 420);
						}
					}
				}
			}
		}

		private void avail_buildings_slot2_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[2]);
			basecost = 1;
			if (num_manned_quarries_p1b < 1)
			{
				discount1 = 0;
			}
			else
			{
				discount1 = 1;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Small Market", "+1 doubloon with sale to Trading House during Trader Phase", "1 VP", 130);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(130);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Small Market - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Small Market", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Small Market for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 130);
					if (confirmedb)
					{
						buildings_available_array2[2] = checked(buildings_available_array2[2] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 130;
							infobox_building1("You built the Small Market", 130);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 131;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot20_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[20]);
			basecost = 10;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b == 3)
			{
				discount1 = 3;
			}
			if (num_manned_quarries_p1b == 4)
			{
				discount1 = 4;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase2("Fortress", "At game end: 1 VP per 3 colonists", "4+X VP", 430);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(430);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Fortress - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Fortress", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Fortress for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building2(string.Concat(strArray), 430);
					if (confirmedb)
					{
						determine_where_to_build_large();
						if (build_spot != 99)
						{
							buildings_available_array2[20] = checked(buildings_available_array2[20] - 1);
							gold_p1b = checked(gold_p1b - cost);
							if (!university_bonusb)
							{
								buildings_p1_arrayb[build_spot] = 430;
								infobox_building2("You built the Fortress", 430);
							}
							else
							{
								buildings_p1_arrayb[build_spot] = 431;
							}
							p1_builtb = true;
							Close();
						}
						else
						{
							infobox_building2("You don't have enough room to build the Fortress", 430);
						}
					}
				}
			}
		}

		private void avail_buildings_slot21_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[21]);
			basecost = 10;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b == 3)
			{
				discount1 = 3;
			}
			if (num_manned_quarries_p1b == 4)
			{
				discount1 = 4;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase2("Customs House", "At game end: 1VP per 4VP Chips", "4+X VP", 440);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(440);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Customs House - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Customs House", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Customs House for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building2(string.Concat(strArray), 440);
					if (confirmedb)
					{
						determine_where_to_build_large();
						if (build_spot != 99)
						{
							buildings_available_array2[21] = checked(buildings_available_array2[21] - 1);
							gold_p1b = checked(gold_p1b - cost);
							if (!university_bonusb)
							{
								buildings_p1_arrayb[build_spot] = 440;
								infobox_building2("You built the Customs House", 440);
							}
							else
							{
								buildings_p1_arrayb[build_spot] = 441;
							}
							p1_builtb = true;
							Close();
						}
						else
						{
							infobox_building2("You don't have enough room to build the Customs House", 440);
						}
					}
				}
			}
		}

		private void avail_buildings_slot22_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[22]);
			basecost = 10;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b == 2)
			{
				discount1 = 2;
			}
			if (num_manned_quarries_p1b == 3)
			{
				discount1 = 3;
			}
			if (num_manned_quarries_p1b == 4)
			{
				discount1 = 4;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase2("City Hall", "At game end: 1VP per violet building", "4+X VP", 450);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(450);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the City Hall - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the City Hall", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the City Hall for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building2(string.Concat(strArray), 450);
					if (confirmedb)
					{
						determine_where_to_build_large();
						if (build_spot != 99)
						{
							buildings_available_array2[22] = checked(buildings_available_array2[22] - 1);
							gold_p1b = checked(gold_p1b - cost);
							if (!university_bonusb)
							{
								buildings_p1_arrayb[build_spot] = 450;
								infobox_building2("You built the City Hall", 450);
							}
							else
							{
								buildings_p1_arrayb[build_spot] = 451;
							}
							p1_builtb = true;
							Close();
						}
						else
						{
							infobox_building2("You don't have enough room to build the City Hall", 450);
						}
					}
				}
			}
		}

		private void avail_buildings_slot3_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[3]);
			basecost = 2;
			if (num_manned_quarries_p1b < 1)
			{
				discount1 = 0;
			}
			else
			{
				discount1 = 1;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Hacienda", "Optional 1 Random Plantation at start of Settler Phase", "1 VP", 140);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(140);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Hacienda - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Hacienda", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Hacienda for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 140);
					if (confirmedb)
					{
						buildings_available_array2[3] = checked(buildings_available_array2[3] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 140;
							infobox_building1("You built the Hacienda", 140);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 141;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot4_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[4]);
			basecost = 2;
			if (num_manned_quarries_p1b < 1)
			{
				discount1 = 0;
			}
			else
			{
				discount1 = 1;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Construction Hut", "Choose Quarry instead of Plantation during Settler Phase", "1 VP", 150);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(150);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Construction Hut - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Construction Hut", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Construction Hut for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 150);
					if (confirmedb)
					{
						buildings_available_array2[4] = checked(buildings_available_array2[4] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 150;
							infobox_building1("You built the Construction Hut", 150);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 151;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot5_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[5]);
			basecost = 3;
			if (num_manned_quarries_p1b < 1)
			{
				discount1 = 0;
			}
			else
			{
				discount1 = 1;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Small Warehouse", "Store all of one type of goods at end of Captain Phase", "1 VP", 160);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(160);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Small Warehouse - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Small Warehouse", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Small Warehouse for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 160);
					if (confirmedb)
					{
						buildings_available_array2[5] = checked(buildings_available_array2[5] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 160;
							infobox_building1("You built the Small Warehouse", 160);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 161;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot6_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[6]);
			basecost = 3;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b >= 2)
			{
				discount1 = 2;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Indigo Plant", "3 colonist capacity to produce Indigo", "2 VP", 210);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(210);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Indigo Plant - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Indigo Plant", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Indigo Plant for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 210);
					if (confirmedb)
					{
						buildings_available_array2[6] = checked(buildings_available_array2[6] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 210;
							infobox_building1("You built the Indigo Plant", 210);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 211;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot7_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[7]);
			basecost = 4;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b >= 2)
			{
				discount1 = 2;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Sugar Mill", "3 colonist capacity to produce Sugar", "2 VP", 220);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(220);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Sugar Mill - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Sugar Mill", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Sugar Mill for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 220);
					if (confirmedb)
					{
						buildings_available_array2[7] = checked(buildings_available_array2[7] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 220;
							infobox_building1("You built the Sugar Mill", 220);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 221;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot8_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[8]);
			basecost = 4;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b >= 2)
			{
				discount1 = 2;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Hospice", "Free colonist on chosen Plantation during Settler Phase", "2 VP", 230);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(230);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Hospice - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Hospice", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Hospice for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 230);
					if (confirmedb)
					{
						buildings_available_array2[8] = checked(buildings_available_array2[8] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 230;
							infobox_building1("You built the Hospice", 230);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 231;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		private void avail_buildings_slot9_Click(object sender, EventArgs e)
		{
			tempstringb = Conversion.Str(buildings_available_array2[9]);
			basecost = 5;
			discount1 = 0;
			discount2 = 0;
			if (num_manned_quarries_p1b == 1)
			{
				discount1 = 1;
			}
			if (num_manned_quarries_p1b >= 2)
			{
				discount1 = 2;
			}
			if (!builder_bonusb)
			{
				discount2 = 0;
			}
			else
			{
				discount2 = 1;
			}
			cost = checked(checked(basecost - discount1) - discount2);
			quarrycost = checked(basecost - discount1);
			if (cost < 0)
			{
				cost = 0;
			}
			if (quarrycost < 0)
			{
				quarrycost = 0;
			}
			if (checked(quarrycost - 1) >= 0)
			{
				buildercost = checked(quarrycost - 1);
			}
			else
			{
				buildercost = 0;
			}
			if (cost <= gold_p1b)
			{
				afford = true;
			}
			else
			{
				afford = false;
			}
			infobox_purchase1("Office", "Sell goods to trader already in Trading House during Trader Phase", "2 VP", 240);
			if (current_playerb != 1)
			{
				Interaction.MsgBox("It's not your turn", 0, null);
			}
			else if (!builder_roundb)
			{
				Interaction.MsgBox("It's not the Builder Phase. You can't purchase buildings now.", 0, null);
			}
			else if (p1_builtb)
			{
				Interaction.MsgBox("You've already built (or chosen not to build) this turn. Your turn is over.", 0, null);
			}
			else
			{
				check_for_building1(240);
				if (found_buildingb)
				{
					Interaction.MsgBox("You already own the Office - choose another building", 0, null);
				}
				else if (!afford)
				{
					Interaction.MsgBox("You can't afford the Office", 0, null);
				}
				else
				{
					string[] strArray = new string[] { "Do you want to build the Office for final cost of", Conversion.Str(cost), " ? - There are currently", tempstringb, " left." };
					confirmbox_building1(string.Concat(strArray), 240);
					if (confirmedb)
					{
						buildings_available_array2[9] = checked(buildings_available_array2[9] - 1);
						gold_p1b = checked(gold_p1b - cost);
						determine_where_to_build_small();
						if (!university_bonusb)
						{
							buildings_p1_arrayb[build_spot] = 240;
							infobox_building1("You built the Office", 240);
						}
						else
						{
							buildings_p1_arrayb[build_spot] = 241;
						}
						p1_builtb = true;
						Close();
					}
				}
			}
		}

		public void check_for_building1(object buildingqueryb)
		{
			found_buildingb = false;
			counter1b = 0;
			do
			{
				if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(buildings_p1_arrayb[counter1b], buildingqueryb, false) == 0, ObjectType.ObjTst(buildings_p1_arrayb[counter1b], ObjectType.AddObj(buildingqueryb, 1), false) == 0)))
				{
					found_buildingb = true;
				}
				Buildings building = this;
				building.counter1b = checked(building.counter1b + 1);
			}
			while (counter1b <= 15);
		}

		public void check_for_building2(object buildingqueryb)
		{
			found_buildingb = false;
			counter1b = 0;
			do
			{
				if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(buildings_p1_arrayb[counter1b], buildingqueryb, false) == 0, ObjectType.ObjTst(buildings_p1_arrayb[counter1b], ObjectType.AddObj(buildingqueryb, 1), false) == 0), ObjectType.ObjTst(buildings_p1_arrayb[counter1b], ObjectType.AddObj(buildingqueryb, 2), false) == 0)))
				{
					found_buildingb = true;
				}
				Buildings building = this;
				building.counter1b = checked(building.counter1b + 1);
			}
			while (counter1b <= 15);
		}

		public void check_for_building3(object buildingqueryb)
		{
			found_buildingb = false;
			counter1b = 0;
			do
			{
				if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(buildings_p1_arrayb[counter1b], buildingqueryb, false) == 0, ObjectType.ObjTst(buildings_p1_arrayb[counter1b], ObjectType.AddObj(buildingqueryb, 1), false) == 0), ObjectType.ObjTst(buildings_p1_arrayb[counter1b], ObjectType.AddObj(buildingqueryb, 2), false) == 0), ObjectType.ObjTst(buildings_p1_arrayb[counter1b], ObjectType.AddObj(buildingqueryb, 3), false) == 0)))
				{
					found_buildingb = true;
				}
				Buildings building = this;
				building.counter1b = checked(building.counter1b + 1);
			}
			while (counter1b <= 15);
		}

		private void close_buildings_button_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void confirmbox_building1(object confirmtext1, object confirmpic1)
		{
			confirmbuilding1_formb.Label1.Text = StringType.FromObject(confirmtext1);
			PictureBox pictureBox1 = confirmbuilding1_formb.PictureBox1;
			string[] strArray = new string[] { "pic\\", StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(confirmpic1))[1]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(confirmpic1))[2]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(confirmpic1))[3]), ".bmp" };
			pictureBox1.Image=Image.FromFile(string.Concat(strArray));
			confirmbuilding1_formb.PictureBox1.Visible = true;
			confirmbuilding1_formb.ShowDialog();
			if (!confirmbuilding1_formb.yes_clicked)
			{
				confirmedb = false;
			}
			else
			{
				confirmedb = true;
			}
		}

		public void confirmbox_building2(object confirmtext1, object confirmpic1)
		{
			confirmbuilding2_formb.Label1.Text =StringType.FromObject(confirmtext1);
			PictureBox pictureBox1 = confirmbuilding2_formb.PictureBox1;
			string[] strArray = new string[] { "pic\\", StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(confirmpic1))[1]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(confirmpic1))[2]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(confirmpic1))[3]), ".bmp" };
			pictureBox1.Image=Image.FromFile(string.Concat(strArray));
			confirmbuilding2_formb.PictureBox1.Visible = true;
			confirmbuilding2_formb.ShowDialog();
			if (!confirmbuilding2_formb.yes_clicked)
			{
				confirmedb = false;
			}
			else
			{
				confirmedb = true;
			}
		}

		public void confirmbox_nopic(object confirmtext1)
		{
			confirmnopic_formb.Label1.Text =StringType.FromObject(confirmtext1);
			confirmnopic_formb.ShowDialog();
			if (!confirmnopic_formb.yes_clicked)
			{
				confirmedb = false;
			}
			else
			{
				confirmedb = true;
			}
		}

		public void determine_if_build_space()
		{
		}

		public void determine_where_to_build_large()
		{
			build_spot = 99;
			counter1b = 0;
			finishedb = false;
			while (!(finishedb | counter1b == 12))
			{
				if (buildings_p1_arrayb[counter1b] != 0)
				{
					counter1b = checked(counter1b + 1);
				}
				else
				{
					if (counter1b == 0)
					{
						build_spot = 12;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[13] = 999;
						finishedb = true;
					}
					if (counter1b == 1)
					{
						build_spot = 13;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[12] = 999;
						finishedb = true;
					}
					if (counter1b == 3)
					{
						build_spot = 14;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[15] = 999;
						finishedb = true;
					}
					if (counter1b == 4)
					{
						build_spot = 15;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[14] = 999;
						finishedb = true;
					}
					if (counter1b == 6)
					{
						build_spot = 16;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[17] = 999;
						finishedb = true;
					}
					if (counter1b == 7)
					{
						build_spot = 17;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[16] = 999;
						finishedb = true;
					}
					if (counter1b == 9)
					{
						build_spot = 18;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[19] = 999;
						finishedb = true;
					}
					if (counter1b == 10)
					{
						build_spot = 19;
						buildings_p1_arrayb[counter1b] = 999;
						buildings_p1_arrayb[checked(counter1b + 1)] = 999;
						buildings_p1_arrayb[18] = 999;
						finishedb = true;
					}
					counter1b = checked(counter1b + 1);
				}
			}
		}

		public void determine_where_to_build_small()
		{
			counter1b = 0;
			finishedb = false;
			while (!(finishedb | counter1b == 12))
			{
				if (buildings_p1_arrayb[counter1b] != 0)
				{
					counter1b = checked(counter1b + 1);
				}
				else
				{
					build_spot = counter1b;
					finishedb = true;
				}
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

		private void do_not_build_button_Click(object sender, EventArgs e)
		{
			confirmbox_nopic("Are you sure you don't want to build anything?");
			if (!confirmedb)
			{
				p1_builtb = false;
				p1_built_nothingb = false;
			}
			else
			{
				p1_builtb = true;
				p1_built_nothingb = true;
				Close();
			}
		}

		public void infobox_building1(object infotext1, object infopic1)
		{
			infobuilding1_formb.infobuilding1_timer1.Interval = 1000;
			infobuilding1_formb.infobuilding1_timer1.Enabled = true;
			infobuilding1_formb.timer_label.Text =StringType.FromInteger(dialog_box_OK_timerb);
			infobuilding1_formb.Label1.Text =StringType.FromObject(infotext1);
			PictureBox pictureBox1 = infobuilding1_formb.PictureBox1;
			string[] strArray = new string[] { "pic\\", StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[1]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[2]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[3]), ".bmp" };
			pictureBox1.Image=Image.FromFile(string.Concat(strArray));
			infobuilding1_formb.PictureBox1.Visible = true;
			infobuilding1_formb.ShowDialog();
		}

		public void infobox_building2(object infotext1, object infopic1)
		{
			infobuilding2_formb.infobuilding2_timer1.Interval = 1000;
			infobuilding2_formb.infobuilding2_timer1.Enabled = true;
			infobuilding2_formb.timer_label.Text =StringType.FromInteger(dialog_box_OK_timerb);
			infobuilding2_formb.Label1.Text =StringType.FromObject(infotext1);
			PictureBox pictureBox1 = infobuilding2_formb.PictureBox1;
			string[] strArray = new string[] { "pic\\", StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[1]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[2]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[3]), ".bmp" };
			pictureBox1.Image=Image.FromFile(string.Concat(strArray));
			infobuilding2_formb.PictureBox1.Visible = true;
			infobuilding2_formb.ShowDialog();
		}

		public void infobox_purchase1(object infotext1, object infotext2, object infotext3, object infopic1)
		{
			infopurchase1_form.GroupBox1.Visible = true;
			infopurchase1_form.Label1.Text =StringType.FromObject(infotext1);
			infopurchase1_form.Label2.Text =StringType.FromObject(infotext2);
			infopurchase1_form.Label3.Text =StringType.FromObject(infotext3);
			infopurchase1_form.Label4.Text =StringType.FromInteger(basecost);
			infopurchase1_form.Label5.Text =StringType.FromInteger(quarrycost);
			infopurchase1_form.Label6.Text =StringType.FromInteger(buildercost);
			infopurchase1_form.Label11.Text =string.Concat(tempstringb, " remaining");
			PictureBox pictureBox1 = infopurchase1_form.PictureBox1;
			string[] strArray = new string[] { "pic\\", StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[1]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[2]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[3]), ".bmp" };
			pictureBox1.Image=Image.FromFile(string.Concat(strArray));
			infopurchase1_form.PictureBox1.Visible = true;
			if (!builder_roundb)
			{
				infopurchase1_form.GroupBox1.Visible = false;
			}
			else if (current_role_chooserb != 1)
			{
				infopurchase1_form.GroupBox1.Visible = false;
			}
			else
			{
				infopurchase1_form.GroupBox1.Visible = true;
			}
			infopurchase1_form.ShowDialog();
		}

		public void infobox_purchase2(object infotext1, object infotext2, object infotext3, object infopic1)
		{
			infopurchase2_form.GroupBox1.Visible = false;
			infopurchase2_form.Label1.Text =StringType.FromObject(infotext1);
			infopurchase2_form.Label2.Text =StringType.FromObject(infotext2);
			infopurchase2_form.Label3.Text =StringType.FromObject(infotext3);
			infopurchase2_form.Label4.Text =StringType.FromInteger(basecost);
			infopurchase2_form.Label5.Text =StringType.FromInteger(quarrycost);
			infopurchase2_form.Label6.Text =StringType.FromInteger(buildercost);
			infopurchase2_form.Label11.Text =string.Concat(tempstringb, " remaining");
			PictureBox pictureBox1 = infopurchase2_form.PictureBox1;
			string[] strArray = new string[] { "pic\\", StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[1]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[2]), StringType.FromChar(Conversion.Str(RuntimeHelpers.GetObjectValue(infopic1))[3]), ".bmp" };
			pictureBox1.Image=Image.FromFile(string.Concat(strArray));
			infopurchase2_form.PictureBox1.Visible = true;
			if (!builder_roundb)
			{
				infopurchase2_form.GroupBox1.Visible = false;
			}
			else if (current_role_chooserb != 1)
			{
				infopurchase2_form.GroupBox1.Visible = false;
			}
			else
			{
				infopurchase2_form.GroupBox1.Visible = true;
			}
			infopurchase2_form.ShowDialog();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ResourceManager resourceManager = new ResourceManager(typeof(Buildings));
			PictureBox1 = new PictureBox();
			close_buildings_button = new Button();
			avail_buildings_slot0 = new PictureBox();
			avail_buildings_slot1 = new PictureBox();
			avail_buildings_slot3 = new PictureBox();
			avail_buildings_slot2 = new PictureBox();
			avail_buildings_slot5 = new PictureBox();
			avail_buildings_slot4 = new PictureBox();
			avail_buildings_slot11 = new PictureBox();
			avail_buildings_slot10 = new PictureBox();
			avail_buildings_slot9 = new PictureBox();
			avail_buildings_slot8 = new PictureBox();
			avail_buildings_slot7 = new PictureBox();
			avail_buildings_slot6 = new PictureBox();
			avail_buildings_slot17 = new PictureBox();
			avail_buildings_slot16 = new PictureBox();
			avail_buildings_slot15 = new PictureBox();
			avail_buildings_slot14 = new PictureBox();
			avail_buildings_slot13 = new PictureBox();
			avail_buildings_slot12 = new PictureBox();
			avail_buildings_slot18 = new PictureBox();
			avail_buildings_slot19 = new PictureBox();
			avail_buildings_slot20 = new PictureBox();
			avail_buildings_slot21 = new PictureBox();
			avail_buildings_slot22 = new PictureBox();
			do_not_build_button = new Button();
			SuspendLayout();
			PictureBox1.Image=(Image)resourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = PictureBox1;
			Point point = new Point(16, 16);
			pictureBox1.Location = point;
			PictureBox1.Name="PictureBox1";
			PictureBox pictureBox = PictureBox1;
			Size size = new Size(664, 496);
			pictureBox.Size = size;
			PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			PictureBox1.TabIndex=1;
			PictureBox1.TabStop = false;
			Button closeBuildingsButton = close_buildings_button;
			point = new Point(576, 520);
			closeBuildingsButton.Location = point;
			close_buildings_button.Name="close_buildings_button";
			close_buildings_button.TabIndex=2;
			close_buildings_button.Text = "Close";
			avail_buildings_slot0.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot0.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot0.Image=(Image)resourceManager.GetObject("avail_buildings_slot0.Image");
			PictureBox availBuildingsSlot0 = avail_buildings_slot0;
			point = new Point(18, 76);
			availBuildingsSlot0.Location = point;
			avail_buildings_slot0.Name="avail_buildings_slot0";
			PictureBox availBuildingsSlot01 = avail_buildings_slot0;
			size = new Size(114, 64);
			availBuildingsSlot01.Size = size;
			avail_buildings_slot0.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot0.TabIndex=129;
			avail_buildings_slot0.TabStop = false;
			avail_buildings_slot0.Visible = false;
			avail_buildings_slot1.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot1.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot1.Image=(Image)resourceManager.GetObject("avail_buildings_slot1.Image");
			PictureBox availBuildingsSlot1 = avail_buildings_slot1;
			point = new Point(18, 146);
			availBuildingsSlot1.Location = point;
			avail_buildings_slot1.Name="avail_buildings_slot1";
			PictureBox availBuildingsSlot11 = avail_buildings_slot1;
			size = new Size(114, 64);
			availBuildingsSlot11.Size = size;
			avail_buildings_slot1.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot1.TabIndex=130;
			avail_buildings_slot1.TabStop = false;
			avail_buildings_slot1.Visible = false;
			avail_buildings_slot3.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot3.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot3.Image=(Image)resourceManager.GetObject("avail_buildings_slot3.Image");
			PictureBox availBuildingsSlot3 = avail_buildings_slot3;
			point = new Point(18, 288);
			availBuildingsSlot3.Location = point;
			avail_buildings_slot3.Name="avail_buildings_slot3";
			PictureBox availBuildingsSlot31 = avail_buildings_slot3;
			size = new Size(114, 64);
			availBuildingsSlot31.Size = size;
			avail_buildings_slot3.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot3.TabIndex=132;
			avail_buildings_slot3.TabStop = false;
			avail_buildings_slot3.Visible = false;
			avail_buildings_slot2.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot2.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot2.Image=(Image)resourceManager.GetObject("avail_buildings_slot2.Image");
			PictureBox availBuildingsSlot2 = avail_buildings_slot2;
			point = new Point(18, 218);
			availBuildingsSlot2.Location = point;
			avail_buildings_slot2.Name="avail_buildings_slot2";
			PictureBox availBuildingsSlot21 = avail_buildings_slot2;
			size = new Size(114, 64);
			availBuildingsSlot21.Size = size;
			avail_buildings_slot2.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot2.TabIndex=131;
			avail_buildings_slot2.TabStop = false;
			avail_buildings_slot2.Visible = false;
			avail_buildings_slot5.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot5.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot5.Image=(Image)resourceManager.GetObject("avail_buildings_slot5.Image");
			PictureBox availBuildingsSlot5 = avail_buildings_slot5;
			point = new Point(18, 432);
			availBuildingsSlot5.Location = point;
			avail_buildings_slot5.Name="avail_buildings_slot5";
			PictureBox availBuildingsSlot51 = avail_buildings_slot5;
			size = new Size(114, 64);
			availBuildingsSlot51.Size = size;
			avail_buildings_slot5.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot5.TabIndex=134;
			avail_buildings_slot5.TabStop = false;
			avail_buildings_slot5.Visible = false;
			avail_buildings_slot4.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot4.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot4.Image=(Image)resourceManager.GetObject("avail_buildings_slot4.Image");
			PictureBox availBuildingsSlot4 = avail_buildings_slot4;
			point = new Point(18, 362);
			availBuildingsSlot4.Location = point;
			avail_buildings_slot4.Name="avail_buildings_slot4";
			PictureBox availBuildingsSlot41 = avail_buildings_slot4;
			size = new Size(114, 64);
			availBuildingsSlot41.Size = size;
			avail_buildings_slot4.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot4.TabIndex=133;
			avail_buildings_slot4.TabStop = false;
			avail_buildings_slot4.Visible = false;
			avail_buildings_slot11.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot11.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot11.Image=(Image)resourceManager.GetObject("avail_buildings_slot11.Image");
			PictureBox availBuildingsSlot111 = avail_buildings_slot11;
			point = new Point(152, 432);
			availBuildingsSlot111.Location = point;
			avail_buildings_slot11.Name="avail_buildings_slot11";
			PictureBox availBuildingsSlot112 = avail_buildings_slot11;
			size = new Size(114, 64);
			availBuildingsSlot112.Size = size;
			avail_buildings_slot11.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot11.TabIndex=140;
			avail_buildings_slot11.TabStop = false;
			avail_buildings_slot11.Visible = false;
			avail_buildings_slot10.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot10.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot10.Image=(Image)resourceManager.GetObject("avail_buildings_slot10.Image");
			PictureBox availBuildingsSlot10 = avail_buildings_slot10;
			point = new Point(152, 362);
			availBuildingsSlot10.Location = point;
			avail_buildings_slot10.Name="avail_buildings_slot10";
			PictureBox availBuildingsSlot101 = avail_buildings_slot10;
			size = new Size(114, 64);
			availBuildingsSlot101.Size = size;
			avail_buildings_slot10.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot10.TabIndex=139;
			avail_buildings_slot10.TabStop = false;
			avail_buildings_slot10.Visible = false;
			avail_buildings_slot9.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot9.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot9.Image=(Image)resourceManager.GetObject("avail_buildings_slot9.Image");
			PictureBox availBuildingsSlot9 = avail_buildings_slot9;
			point = new Point(152, 288);
			availBuildingsSlot9.Location = point;
			avail_buildings_slot9.Name="avail_buildings_slot9";
			PictureBox availBuildingsSlot91 = avail_buildings_slot9;
			size = new Size(114, 64);
			availBuildingsSlot91.Size = size;
			avail_buildings_slot9.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot9.TabIndex=138;
			avail_buildings_slot9.TabStop = false;
			avail_buildings_slot9.Visible = false;
			avail_buildings_slot8.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot8.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot8.Image=(Image)resourceManager.GetObject("avail_buildings_slot8.Image");
			PictureBox availBuildingsSlot8 = avail_buildings_slot8;
			point = new Point(152, 218);
			availBuildingsSlot8.Location = point;
			avail_buildings_slot8.Name="avail_buildings_slot8";
			PictureBox availBuildingsSlot81 = avail_buildings_slot8;
			size = new Size(114, 64);
			availBuildingsSlot81.Size = size;
			avail_buildings_slot8.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot8.TabIndex=137;
			avail_buildings_slot8.TabStop = false;
			avail_buildings_slot8.Visible = false;
			avail_buildings_slot7.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot7.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot7.Image=(Image)resourceManager.GetObject("avail_buildings_slot7.Image");
			PictureBox availBuildingsSlot7 = avail_buildings_slot7;
			point = new Point(152, 146);
			availBuildingsSlot7.Location = point;
			avail_buildings_slot7.Name="avail_buildings_slot7";
			PictureBox availBuildingsSlot71 = avail_buildings_slot7;
			size = new Size(114, 64);
			availBuildingsSlot71.Size = size;
			avail_buildings_slot7.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot7.TabIndex=136;
			avail_buildings_slot7.TabStop = false;
			avail_buildings_slot7.Visible = false;
			avail_buildings_slot6.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot6.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot6.Image=(Image)resourceManager.GetObject("avail_buildings_slot6.Image");
			PictureBox availBuildingsSlot6 = avail_buildings_slot6;
			point = new Point(152, 76);
			availBuildingsSlot6.Location = point;
			avail_buildings_slot6.Name="avail_buildings_slot6";
			PictureBox availBuildingsSlot61 = avail_buildings_slot6;
			size = new Size(114, 64);
			availBuildingsSlot61.Size = size;
			avail_buildings_slot6.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot6.TabIndex=135;
			avail_buildings_slot6.TabStop = false;
			avail_buildings_slot6.Visible = false;
			avail_buildings_slot17.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot17.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot17.Image=(Image)resourceManager.GetObject("avail_buildings_slot17.Image");
			PictureBox availBuildingsSlot17 = avail_buildings_slot17;
			point = new Point(290, 432);
			availBuildingsSlot17.Location = point;
			avail_buildings_slot17.Name="avail_buildings_slot17";
			PictureBox availBuildingsSlot171 = avail_buildings_slot17;
			size = new Size(114, 64);
			availBuildingsSlot171.Size = size;
			avail_buildings_slot17.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot17.TabIndex=146;
			avail_buildings_slot17.TabStop = false;
			avail_buildings_slot17.Visible = false;
			avail_buildings_slot16.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot16.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot16.Image=(Image)resourceManager.GetObject("avail_buildings_slot16.Image");
			PictureBox availBuildingsSlot16 = avail_buildings_slot16;
			point = new Point(290, 362);
			availBuildingsSlot16.Location = point;
			avail_buildings_slot16.Name="avail_buildings_slot16";
			PictureBox availBuildingsSlot161 = avail_buildings_slot16;
			size = new Size(114, 64);
			availBuildingsSlot161.Size = size;
			avail_buildings_slot16.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot16.TabIndex=145;
			avail_buildings_slot16.TabStop = false;
			avail_buildings_slot16.Visible = false;
			avail_buildings_slot15.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot15.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot15.Image=(Image)resourceManager.GetObject("avail_buildings_slot15.Image");
			PictureBox availBuildingsSlot15 = avail_buildings_slot15;
			point = new Point(290, 288);
			availBuildingsSlot15.Location = point;
			avail_buildings_slot15.Name="avail_buildings_slot15";
			PictureBox availBuildingsSlot151 = avail_buildings_slot15;
			size = new Size(114, 64);
			availBuildingsSlot151.Size = size;
			avail_buildings_slot15.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot15.TabIndex=144;
			avail_buildings_slot15.TabStop = false;
			avail_buildings_slot15.Visible = false;
			avail_buildings_slot14.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot14.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot14.Image=(Image)resourceManager.GetObject("avail_buildings_slot14.Image");
			PictureBox availBuildingsSlot14 = avail_buildings_slot14;
			point = new Point(290, 218);
			availBuildingsSlot14.Location = point;
			avail_buildings_slot14.Name="avail_buildings_slot14";
			PictureBox availBuildingsSlot141 = avail_buildings_slot14;
			size = new Size(114, 64);
			availBuildingsSlot141.Size = size;
			avail_buildings_slot14.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot14.TabIndex=143;
			avail_buildings_slot14.TabStop = false;
			avail_buildings_slot14.Visible = false;
			avail_buildings_slot13.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot13.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot13.Image=(Image)resourceManager.GetObject("avail_buildings_slot13.Image");
			PictureBox availBuildingsSlot13 = avail_buildings_slot13;
			point = new Point(290, 146);
			availBuildingsSlot13.Location = point;
			avail_buildings_slot13.Name="avail_buildings_slot13";
			PictureBox availBuildingsSlot131 = avail_buildings_slot13;
			size = new Size(114, 64);
			availBuildingsSlot131.Size = size;
			avail_buildings_slot13.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot13.TabIndex=142;
			avail_buildings_slot13.TabStop = false;
			avail_buildings_slot13.Visible = false;
			avail_buildings_slot12.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot12.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot12.Image=(Image)resourceManager.GetObject("avail_buildings_slot12.Image");
			PictureBox availBuildingsSlot12 = avail_buildings_slot12;
			point = new Point(290, 76);
			availBuildingsSlot12.Location = point;
			avail_buildings_slot12.Name="avail_buildings_slot12";
			PictureBox availBuildingsSlot121 = avail_buildings_slot12;
			size = new Size(114, 64);
			availBuildingsSlot121.Size = size;
			avail_buildings_slot12.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot12.TabIndex=141;
			avail_buildings_slot12.TabStop = false;
			avail_buildings_slot12.Visible = false;
			avail_buildings_slot18.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot18.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot18.Image=(Image)resourceManager.GetObject("avail_buildings_slot18.Image");
			PictureBox availBuildingsSlot18 = avail_buildings_slot18;
			point = new Point(426, 80);
			availBuildingsSlot18.Location = point;
			avail_buildings_slot18.Name="avail_buildings_slot18";
			PictureBox availBuildingsSlot181 = avail_buildings_slot18;
			size = new Size(114, 132);
			availBuildingsSlot181.Size = size;
			avail_buildings_slot18.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot18.TabIndex=147;
			avail_buildings_slot18.TabStop = false;
			avail_buildings_slot18.Visible = false;
			avail_buildings_slot19.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot19.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot19.Image=(Image)resourceManager.GetObject("avail_buildings_slot19.Image");
			PictureBox availBuildingsSlot19 = avail_buildings_slot19;
			point = new Point(424, 220);
			availBuildingsSlot19.Location = point;
			avail_buildings_slot19.Name="avail_buildings_slot19";
			PictureBox availBuildingsSlot191 = avail_buildings_slot19;
			size = new Size(114, 132);
			availBuildingsSlot191.Size = size;
			avail_buildings_slot19.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot19.TabIndex=148;
			avail_buildings_slot19.TabStop = false;
			avail_buildings_slot19.Visible = false;
			avail_buildings_slot20.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot20.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot20.Image=(Image)resourceManager.GetObject("avail_buildings_slot20.Image");
			PictureBox availBuildingsSlot20 = avail_buildings_slot20;
			point = new Point(426, 364);
			availBuildingsSlot20.Location = point;
			avail_buildings_slot20.Name="avail_buildings_slot20";
			PictureBox availBuildingsSlot201 = avail_buildings_slot20;
			size = new Size(114, 132);
			availBuildingsSlot201.Size = size;
			avail_buildings_slot20.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot20.TabIndex=149;
			avail_buildings_slot20.TabStop = false;
			avail_buildings_slot20.Visible = false;
			avail_buildings_slot21.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot21.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot21.Image=(Image)resourceManager.GetObject("avail_buildings_slot21.Image");
			PictureBox availBuildingsSlot211 = avail_buildings_slot21;
			point = new Point(554, 148);
			availBuildingsSlot211.Location = point;
			avail_buildings_slot21.Name="avail_buildings_slot21";
			PictureBox availBuildingsSlot212 = avail_buildings_slot21;
			size = new Size(114, 132);
			availBuildingsSlot212.Size = size;
			avail_buildings_slot21.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot21.TabIndex=150;
			avail_buildings_slot21.TabStop = false;
			avail_buildings_slot21.Visible = false;
			avail_buildings_slot22.BackColor=SystemColors.ActiveCaption;
			avail_buildings_slot22.BorderStyle=BorderStyle.FixedSingle;
			avail_buildings_slot22.Image=(Image)resourceManager.GetObject("avail_buildings_slot22.Image");
			PictureBox availBuildingsSlot22 = avail_buildings_slot22;
			point = new Point(554, 292);
			availBuildingsSlot22.Location = point;
			avail_buildings_slot22.Name="avail_buildings_slot22";
			PictureBox availBuildingsSlot221 = avail_buildings_slot22;
			size = new Size(114, 132);
			availBuildingsSlot221.Size = size;
			avail_buildings_slot22.SizeMode=PictureBoxSizeMode.AutoSize;
			avail_buildings_slot22.TabIndex=151;
			avail_buildings_slot22.TabStop = false;
			avail_buildings_slot22.Visible = false;
			Button doNotBuildButton = do_not_build_button;
			point = new Point(474, 520);
			doNotBuildButton.Location = point;
			do_not_build_button.Name="do_not_build_button";
			Button button = do_not_build_button;
			size = new Size(86, 23);
			button.Size = size;
			do_not_build_button.TabIndex=152;
			do_not_build_button.Text = "Do Not Build";
			size = new Size(5, 13);
			AutoScaleBaseSize = size;
			size = new Size(696, 554);
			ClientSize = size;
			ControlBox = false;
			Controls.Add(do_not_build_button);
			Controls.Add(avail_buildings_slot22);
			Controls.Add(avail_buildings_slot21);
			Controls.Add(avail_buildings_slot20);
			Controls.Add(avail_buildings_slot19);
			Controls.Add(avail_buildings_slot18);
			Controls.Add(avail_buildings_slot17);
			Controls.Add(avail_buildings_slot16);
			Controls.Add(avail_buildings_slot15);
			Controls.Add(avail_buildings_slot14);
			Controls.Add(avail_buildings_slot13);
			Controls.Add(avail_buildings_slot12);
			Controls.Add(avail_buildings_slot11);
			Controls.Add(avail_buildings_slot10);
			Controls.Add(avail_buildings_slot9);
			Controls.Add(avail_buildings_slot8);
			Controls.Add(avail_buildings_slot7);
			Controls.Add(avail_buildings_slot6);
			Controls.Add(avail_buildings_slot5);
			Controls.Add(avail_buildings_slot4);
			Controls.Add(avail_buildings_slot3);
			Controls.Add(avail_buildings_slot2);
			Controls.Add(avail_buildings_slot1);
			Controls.Add(avail_buildings_slot0);
			Controls.Add(close_buildings_button);
			Controls.Add(PictureBox1);
			size = new Size(704, 592);
			MaximumSize = size;
			size = new Size(704, 592);
			MinimumSize = size;
			Name="Buildings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Buildings";
			ResumeLayout(false);
		}
	}
}
