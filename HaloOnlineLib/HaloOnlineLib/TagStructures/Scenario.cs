using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "scnr", Size = 0x834)]
	public class Scenario
	{
		[TagElement]
		public int Unknown0 { get; set; }
		[TagElement]
		public int Unknown4 { get; set; }
		[TagElement]
		public int Unknown8 { get; set; }
		[TagElement]
		public int UnknownC { get; set; }
		[TagElement]
		public float Budget { get; set; }
		[TagElement]
		public List<TagBlock0> Unknown14 { get; set; }
		[TagElement]
		public int Unknown20 { get; set; }
		[TagElement]
		public int Unknown24 { get; set; }
		[TagElement]
		public int Unknown28 { get; set; }
		[TagElement]
		public int Unknown2C { get; set; }
		[TagElement]
		public List<TagBlock1> Unknown30 { get; set; }
		[TagElement]
		public List<TagBlock2> Unknown3C { get; set; }
		[TagElement]
		public List<TagBlock19> Unknown48 { get; set; }
		[TagElement]
		public List<TagBlock27> Unknown54 { get; set; }
		[TagElement]
		public int Unknown60 { get; set; }
		[TagElement]
		public int Unknown64 { get; set; }
		[TagElement]
		public int Unknown68 { get; set; }
		[TagElement]
		public int Unknown6C { get; set; }
		[TagElement]
		public int Unknown70 { get; set; }
		[TagElement]
		public int Unknown74 { get; set; }
		[TagElement]
		public int Unknown78 { get; set; }
		[TagElement]
		public int Unknown7C { get; set; }
		[TagElement]
		public int Unknown80 { get; set; }
		[TagElement]
		public int Unknown84 { get; set; }
		[TagElement]
		public int Unknown88 { get; set; }
		[TagElement]
		public int Unknown8C { get; set; }
		[TagElement]
		public int Unknown90 { get; set; }
		[TagElement]
		public int Unknown94 { get; set; }
		[TagElement]
		public int Unknown98 { get; set; }
		[TagElement]
		public int Unknown9C { get; set; }
		[TagElement]
		public int UnknownA0 { get; set; }
		[TagElement]
		public int UnknownA4 { get; set; }
		[TagElement]
		public int UnknownA8 { get; set; }
		[TagElement]
		public int UnknownAC { get; set; }
		[TagElement]
		public int UnknownB0 { get; set; }
		[TagElement]
		public int UnknownB4 { get; set; }
		[TagElement]
		public int UnknownB8 { get; set; }
		[TagElement]
		public List<TagBlock28> UnknownBC { get; set; }
		[TagElement]
		public List<TagBlock29> UnknownC8 { get; set; }
		[TagElement]
		public List<TagBlock30> UnknownD4 { get; set; }
		[TagElement]
		public List<TagBlock31> UnknownE0 { get; set; }
		[TagElement]
		public List<TagBlock32> UnknownEC { get; set; }
		[TagElement]
		public List<TagBlock33> UnknownF8 { get; set; }
		[TagElement]
		public List<TagBlock34> Unknown104 { get; set; }
		[TagElement]
		public List<TagBlock35> Unknown110 { get; set; }
		[TagElement]
		public List<TagBlock36> Unknown11C { get; set; }
		[TagElement]
		public List<TagBlock37> Unknown128 { get; set; }
		[TagElement]
		public List<TagBlock38> Unknown134 { get; set; }
		[TagElement]
		public List<TagBlock39> Unknown140 { get; set; }
		[TagElement]
		public List<TagBlock40> Unknown14C { get; set; }
		[TagElement]
		public List<TagBlock41> Unknown158 { get; set; }
		[TagElement]
		public int Unknown164 { get; set; }
		[TagElement]
		public int Unknown168 { get; set; }
		[TagElement]
		public int Unknown16C { get; set; }
		[TagElement]
		public int Unknown170 { get; set; }
		[TagElement]
		public int Unknown174 { get; set; }
		[TagElement]
		public int Unknown178 { get; set; }
		[TagElement]
		public int Unknown17C { get; set; }
		[TagElement]
		public int Unknown180 { get; set; }
		[TagElement]
		public int Unknown184 { get; set; }
		[TagElement]
		public int Unknown188 { get; set; }
		[TagElement]
		public int Unknown18C { get; set; }
		[TagElement]
		public int Unknown190 { get; set; }
		[TagElement]
		public List<TagBlock42> Unknown194 { get; set; }
		[TagElement]
		public List<TagBlock43> Unknown1A0 { get; set; }
		[TagElement]
		public List<TagBlock44> Unknown1AC { get; set; }
		[TagElement]
		public List<TagBlock45> Unknown1B8 { get; set; }
		[TagElement]
		public int Unknown1C4 { get; set; }
		[TagElement]
		public int Unknown1C8 { get; set; }
		[TagElement]
		public int Unknown1CC { get; set; }
		[TagElement]
		public int Unknown1D0 { get; set; }
		[TagElement]
		public int Unknown1D4 { get; set; }
		[TagElement]
		public int Unknown1D8 { get; set; }
		[TagElement]
		public List<TagBlock46> Unknown1DC { get; set; }
		[TagElement]
		public List<TagBlock47> Unknown1E8 { get; set; }
		[TagElement]
		public List<TagBlock48> Unknown1F4 { get; set; }
		[TagElement]
		public List<TagBlock49> Unknown200 { get; set; }
		[TagElement]
		public List<TagBlock50> Unknown20C { get; set; }
		[TagElement]
		public List<TagBlock51> Unknown218 { get; set; }
		[TagElement]
		public List<TagBlock52> Unknown224 { get; set; }
		[TagElement]
		public List<TagBlock53> Unknown230 { get; set; }
		[TagElement]
		public List<TagBlock54> Unknown23C { get; set; }
		[TagElement]
		public List<TagBlock55> Unknown248 { get; set; }
		[TagElement]
		public List<TagBlock56> Unknown254 { get; set; }
		[TagElement]
		public List<TagBlock57> Unknown260 { get; set; }
		[TagElement]
		public List<TagBlock58> Unknown26C { get; set; }
		[TagElement]
		public List<TagBlock59> Unknown278 { get; set; }
		[TagElement]
		public List<TagBlock60> Unknown284 { get; set; }
		[TagElement]
		public int Unknown290 { get; set; }
		[TagElement]
		public int Unknown294 { get; set; }
		[TagElement]
		public int Unknown298 { get; set; }
		[TagElement]
		public int Unknown29C { get; set; }
		[TagElement]
		public int Unknown2A0 { get; set; }
		[TagElement]
		public int Unknown2A4 { get; set; }
		[TagElement]
		public List<TagBlock62> Unknown2A8 { get; set; }
		[TagElement]
		public int Unknown2B4 { get; set; }
		[TagElement]
		public int Unknown2B8 { get; set; }
		[TagElement]
		public int Unknown2BC { get; set; }
		[TagElement]
		public int Unknown2C0 { get; set; }
		[TagElement]
		public int Unknown2C4 { get; set; }
		[TagElement]
		public int Unknown2C8 { get; set; }
		[TagElement]
		public int Unknown2CC { get; set; }
		[TagElement]
		public int Unknown2D0 { get; set; }
		[TagElement]
		public int Unknown2D4 { get; set; }
		[TagElement]
		public List<TagBlock63> Unknown2D8 { get; set; }
		[TagElement]
		public int Unknown2E4 { get; set; }
		[TagElement]
		public int Unknown2E8 { get; set; }
		[TagElement]
		public int Unknown2EC { get; set; }
		[TagElement]
		public int Unknown2F0 { get; set; }
		[TagElement]
		public int Unknown2F4 { get; set; }
		[TagElement]
		public int Unknown2F8 { get; set; }
		[TagElement]
		public int Unknown2FC { get; set; }
		[TagElement]
		public int Unknown300 { get; set; }
		[TagElement]
		public int Unknown304 { get; set; }
		[TagElement]
		public int Unknown308 { get; set; }
		[TagElement]
		public int Unknown30C { get; set; }
		[TagElement]
		public int Unknown310 { get; set; }
		[TagElement]
		public int Unknown314 { get; set; }
		[TagElement]
		public int Unknown318 { get; set; }
		[TagElement]
		public int Unknown31C { get; set; }
		[TagElement]
		public int Unknown320 { get; set; }
		[TagElement]
		public int Unknown324 { get; set; }
		[TagElement]
		public int Unknown328 { get; set; }
		[TagElement]
		public int Unknown32C { get; set; }
		[TagElement]
		public int Unknown330 { get; set; }
		[TagElement]
		public int Unknown334 { get; set; }
		[TagElement]
		public int Unknown338 { get; set; }
		[TagElement]
		public int Unknown33C { get; set; }
		[TagElement]
		public int Unknown340 { get; set; }
		[TagElement]
		public int Unknown344 { get; set; }
		[TagElement]
		public int Unknown348 { get; set; }
		[TagElement]
		public int Unknown34C { get; set; }
		[TagElement]
		public int Unknown350 { get; set; }
		[TagElement]
		public int Unknown354 { get; set; }
		[TagElement]
		public int Unknown358 { get; set; }
		[TagElement]
		public int Unknown35C { get; set; }
		[TagElement]
		public int Unknown360 { get; set; }
		[TagElement]
		public int Unknown364 { get; set; }
		[TagElement]
		public int Unknown368 { get; set; }
		[TagElement]
		public int Unknown36C { get; set; }
		[TagElement]
		public int Unknown370 { get; set; }
		[TagElement]
		public List<TagBlock64> Unknown374 { get; set; }
		[TagElement]
		public List<TagBlock65> Unknown380 { get; set; }
		[TagElement]
		public int Unknown38C { get; set; }
		[TagElement]
		public int Unknown390 { get; set; }
		[TagElement]
		public int Unknown394 { get; set; }
		[TagElement]
		public int Unknown398 { get; set; }
		[TagElement]
		public int Unknown39C { get; set; }
		[TagElement]
		public int Unknown3A0 { get; set; }
		[TagElement]
		public int Unknown3A4 { get; set; }
		[TagElement]
		public int Unknown3A8 { get; set; }
		[TagElement]
		public int Unknown3AC { get; set; }
		[TagElement]
		public int Unknown3B0 { get; set; }
		[TagElement]
		public int Unknown3B4 { get; set; }
		[TagElement]
		public int Unknown3B8 { get; set; }
		[TagElement]
		public int Unknown3BC { get; set; }
		[TagElement]
		public int Unknown3C0 { get; set; }
		[TagElement]
		public int Unknown3C4 { get; set; }
		[TagElement]
		public int Unknown3C8 { get; set; }
		[TagElement]
		public int Unknown3CC { get; set; }
		[TagElement]
		public int Unknown3D0 { get; set; }
		[TagElement]
		public int Unknown3D4 { get; set; }
		[TagElement]
		public int Unknown3D8 { get; set; }
		[TagElement]
		public int Unknown3DC { get; set; }
		[TagElement]
		public int Unknown3E0 { get; set; }
		[TagElement]
		public int Unknown3E4 { get; set; }
		[TagElement]
		public int Unknown3E8 { get; set; }
		[TagElement]
		public int Unknown3EC { get; set; }
		[TagElement]
		public int Unknown3F0 { get; set; }
		[TagElement]
		public int Unknown3F4 { get; set; }
		[TagElement]
		public List<TagBlock66> Unknown3F8 { get; set; }
		[TagElement]
		public int Unknown404 { get; set; }
		[TagElement]
		public int Unknown408 { get; set; }
		[TagElement]
		public int Unknown40C { get; set; }
		[TagElement]
		public byte[] Unknown410 { get; set; }
		[TagElement]
		public List<TagBlock69> Unknown424 { get; set; }
		[TagElement]
		public List<TagBlock71> Unknown430 { get; set; }
		[TagElement]
		public List<TagBlock72> Unknown43C { get; set; }
		[TagElement]
		public int Unknown448 { get; set; }
		[TagElement]
		public int Unknown44C { get; set; }
		[TagElement]
		public int Unknown450 { get; set; }
		[TagElement]
		public List<TagBlock73> Unknown454 { get; set; }
		[TagElement]
		public List<TagBlock74> Unknown460 { get; set; }
		[TagElement]
		public List<TagBlock75> Unknown46C { get; set; }
		[TagElement]
		public int Unknown478 { get; set; }
		[TagElement]
		public int Unknown47C { get; set; }
		[TagElement]
		public int Unknown480 { get; set; }
		[TagElement]
		public int Unknown484 { get; set; }
		[TagElement]
		public int Unknown488 { get; set; }
		[TagElement]
		public int Unknown48C { get; set; }
		[TagElement]
		public int Unknown490 { get; set; }
		[TagElement]
		public int Unknown494 { get; set; }
		[TagElement]
		public int Unknown498 { get; set; }
		[TagElement]
		public int Unknown49C { get; set; }
		[TagElement]
		public int Unknown4A0 { get; set; }
		[TagElement]
		public int Unknown4A4 { get; set; }
		[TagElement]
		public int Unknown4A8 { get; set; }
		[TagElement]
		public int Unknown4AC { get; set; }
		[TagElement]
		public int Unknown4B0 { get; set; }
		[TagElement]
		public List<TagBlock76> Unknown4B4 { get; set; }
		[TagElement]
		public int Unknown4C0 { get; set; }
		[TagElement]
		public int Unknown4C4 { get; set; }
		[TagElement]
		public int Unknown4C8 { get; set; }
		[TagElement]
		public List<TagBlock79> Unknown4CC { get; set; }
		[TagElement]
		public List<TagBlock80> Unknown4D8 { get; set; }
		[TagElement]
		public List<TagBlock81> Unknown4E4 { get; set; }
		[TagElement]
		public int Unknown4F0 { get; set; }
		[TagElement]
		public int Unknown4F4 { get; set; }
		[TagElement]
		public int Unknown4F8 { get; set; }
		[TagElement]
		public int Unknown4FC { get; set; }
		[TagElement]
		public int Unknown500 { get; set; }
		[TagElement]
		public int Unknown504 { get; set; }
		[TagElement]
		public List<TagBlock82> Unknown508 { get; set; }
		[TagElement]
		public int Unknown514 { get; set; }
		[TagElement]
		public int Unknown518 { get; set; }
		[TagElement]
		public int Unknown51C { get; set; }
		[TagElement]
		public int Unknown520 { get; set; }
		[TagElement]
		public int Unknown524 { get; set; }
		[TagElement]
		public int Unknown528 { get; set; }
		[TagElement]
		public List<TagBlock83> Unknown52C { get; set; }
		[TagElement]
		public List<TagBlock84> Unknown538 { get; set; }
		[TagElement]
		public List<TagBlock85> Unknown544 { get; set; }
		[TagElement]
		public int Unknown550 { get; set; }
		[TagElement]
		public int Unknown554 { get; set; }
		[TagElement]
		public int Unknown558 { get; set; }
		[TagElement]
		public int Unknown55C { get; set; }
		[TagElement]
		public int Unknown560 { get; set; }
		[TagElement]
		public int Unknown564 { get; set; }
		[TagElement]
		public int Unknown568 { get; set; }
		[TagElement]
		public int Unknown56C { get; set; }
		[TagElement]
		public int Unknown570 { get; set; }
		[TagElement]
		public List<TagBlock86> Unknown574 { get; set; }
		[TagElement]
		public int Unknown580 { get; set; }
		[TagElement]
		public int Unknown584 { get; set; }
		[TagElement]
		public int Unknown588 { get; set; }
		[TagElement]
		public int Unknown58C { get; set; }
		[TagElement]
		public int Unknown590 { get; set; }
		[TagElement]
		public int Unknown594 { get; set; }
		[TagElement]
		public int Unknown598 { get; set; }
		[TagElement]
		public int Unknown59C { get; set; }
		[TagElement]
		public int Unknown5A0 { get; set; }
		[TagElement]
		public int Unknown5A4 { get; set; }
		[TagElement]
		public int Unknown5A8 { get; set; }
		[TagElement]
		public int Unknown5AC { get; set; }
		[TagElement]
		public int Unknown5B0 { get; set; }
		[TagElement]
		public int Unknown5B4 { get; set; }
		[TagElement]
		public int Unknown5B8 { get; set; }
		[TagElement]
		public int Unknown5BC { get; set; }
		[TagElement]
		public int Unknown5C0 { get; set; }
		[TagElement]
		public int Unknown5C4 { get; set; }
		[TagElement]
		public int Unknown5C8 { get; set; }
		[TagElement]
		public int Unknown5CC { get; set; }
		[TagElement]
		public int Unknown5D0 { get; set; }
		[TagElement]
		public int Unknown5D4 { get; set; }
		[TagElement]
		public int Unknown5D8 { get; set; }
		[TagElement]
		public int Unknown5DC { get; set; }
		[TagElement]
		public int Unknown5E0 { get; set; }
		[TagElement]
		public int Unknown5E4 { get; set; }
		[TagElement]
		public int Unknown5E8 { get; set; }
		[TagElement]
		public int Unknown5EC { get; set; }
		[TagElement]
		public int Unknown5F0 { get; set; }
		[TagElement]
		public int Unknown5F4 { get; set; }
		[TagElement]
		public int Unknown5F8 { get; set; }
		[TagElement]
		public int Unknown5FC { get; set; }
		[TagElement]
		public int Unknown600 { get; set; }
		[TagElement]
		public int Unknown604 { get; set; }
		[TagElement]
		public int Unknown608 { get; set; }
		[TagElement]
		public List<TagBlock95> Unknown60C { get; set; }
		[TagElement]
		public int Unknown618 { get; set; }
		[TagElement]
		public int Unknown61C { get; set; }
		[TagElement]
		public int Unknown620 { get; set; }
		[TagElement]
		public int Unknown624 { get; set; }
		[TagElement]
		public List<TagBlock98> Unknown628 { get; set; }
		[TagElement]
		public List<TagBlock102> Unknown634 { get; set; }
		[TagElement]
		public List<TagBlock103> Unknown640 { get; set; }
		[TagElement]
		public List<TagBlock104> Unknown64C { get; set; }
		[TagElement]
		public int Unknown658 { get; set; }
		[TagElement]
		public int Unknown65C { get; set; }
		[TagElement]
		public int Unknown660 { get; set; }
		[TagElement]
		public int Unknown664 { get; set; }
		[TagElement]
		public int Unknown668 { get; set; }
		[TagElement]
		public int Unknown66C { get; set; }
		[TagElement]
		public int Unknown670 { get; set; }
		[TagElement]
		public List<TagBlock107> Unknown674 { get; set; }
		[TagElement]
		public List<TagBlock108> Unknown680 { get; set; }
		[TagElement]
		public HaloTag Unknown68C { get; set; }
		[TagElement]
		public int Unknown69C { get; set; }
		[TagElement]
		public int Unknown6A0 { get; set; }
		[TagElement]
		public int Unknown6A4 { get; set; }
		[TagElement]
		public int Unknown6A8 { get; set; }
		[TagElement]
		public int Unknown6AC { get; set; }
		[TagElement]
		public int Unknown6B0 { get; set; }
		[TagElement]
		public int Unknown6B4 { get; set; }
		[TagElement]
		public int Unknown6B8 { get; set; }
		[TagElement]
		public int Unknown6BC { get; set; }
		[TagElement]
		public int Unknown6C0 { get; set; }
		[TagElement]
		public int Unknown6C4 { get; set; }
		[TagElement]
		public int Unknown6C8 { get; set; }
		[TagElement]
		public int Unknown6CC { get; set; }
		[TagElement]
		public int Unknown6D0 { get; set; }
		[TagElement]
		public int Unknown6D4 { get; set; }
		[TagElement]
		public int Unknown6D8 { get; set; }
		[TagElement]
		public int Unknown6DC { get; set; }
		[TagElement]
		public int Unknown6E0 { get; set; }
		[TagElement]
		public int Unknown6E4 { get; set; }
		[TagElement]
		public int Unknown6E8 { get; set; }
		[TagElement]
		public int Unknown6EC { get; set; }
		[TagElement]
		public HaloTag Unknown6F0 { get; set; }
		[TagElement]
		public int Unknown700 { get; set; }
		[TagElement]
		public int Unknown704 { get; set; }
		[TagElement]
		public int Unknown708 { get; set; }
		[TagElement]
		public int Unknown70C { get; set; }
		[TagElement]
		public int Unknown710 { get; set; }
		[TagElement]
		public int Unknown714 { get; set; }
		[TagElement]
		public int Unknown718 { get; set; }
		[TagElement]
		public int Unknown71C { get; set; }
		[TagElement]
		public HaloTag Unknown720 { get; set; }
		[TagElement]
		public HaloTag Unknown730 { get; set; }
		[TagElement]
		public HaloTag Unknown740 { get; set; }
		[TagElement]
		public HaloTag Unknown750 { get; set; }
		[TagElement]
		public int Unknown760 { get; set; }
		[TagElement]
		public int Unknown764 { get; set; }
		[TagElement]
		public int Unknown768 { get; set; }
		[TagElement]
		public int Unknown76C { get; set; }
		[TagElement]
		public int Unknown770 { get; set; }
		[TagElement]
		public int Unknown774 { get; set; }
		[TagElement]
		public int Unknown778 { get; set; }
		[TagElement]
		public int Unknown77C { get; set; }
		[TagElement]
		public int Unknown780 { get; set; }
		[TagElement]
		public List<TagBlock109> Unknown784 { get; set; }
		[TagElement]
		public int Unknown790 { get; set; }
		[TagElement]
		public int Unknown794 { get; set; }
		[TagElement]
		public int Unknown798 { get; set; }
		[TagElement]
		public int Unknown79C { get; set; }
		[TagElement]
		public int Unknown7A0 { get; set; }
		[TagElement]
		public int Unknown7A4 { get; set; }
		[TagElement]
		public int Unknown7A8 { get; set; }
		[TagElement]
		public int Unknown7AC { get; set; }
		[TagElement]
		public int Unknown7B0 { get; set; }
		[TagElement]
		public int Unknown7B4 { get; set; }
		[TagElement]
		public int Unknown7B8 { get; set; }
		[TagElement]
		public int Unknown7BC { get; set; }
		[TagElement]
		public int Unknown7C0 { get; set; }
		[TagElement]
		public int Unknown7C4 { get; set; }
		[TagElement]
		public int Unknown7C8 { get; set; }
		[TagElement]
		public List<TagBlock110> Unknown7CC { get; set; }
		[TagElement]
		public List<TagBlock111> Unknown7D8 { get; set; }
		[TagElement]
		public int Unknown7E4 { get; set; }
		[TagElement]
		public int Unknown7E8 { get; set; }
		[TagElement]
		public int Unknown7EC { get; set; }
		[TagElement]
		public List<TagBlock112> Unknown7F0 { get; set; }
		[TagElement]
		public int Unknown7FC { get; set; }
		[TagElement]
		public int Unknown800 { get; set; }
		[TagElement]
		public int Unknown804 { get; set; }
		[TagElement]
		public int Unknown808 { get; set; }
		[TagElement]
		public int Unknown80C { get; set; }
		[TagElement]
		public int Unknown810 { get; set; }
		[TagElement]
		public int Unknown814 { get; set; }
		[TagElement]
		public int Unknown818 { get; set; }
		[TagElement]
		public int Unknown81C { get; set; }
		[TagElement]
		public int Unknown820 { get; set; }
		[TagElement]
		public int Unknown824 { get; set; }
		[TagElement]
		public List<TagBlock113> Unknown828 { get; set; }

		[TagStructure(Size = 0x6C)]
		public class TagBlock0
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown10 { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public HaloTag Unknown48 { get; set; }
			[TagElement]
			public HaloTag Unknown58 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
		}

		[TagStructure(Size = 0x14)]
		public class TagBlock1
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
		}

		[TagStructure(Size = 0x2C)]
		public class TagBlock2
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public List<TagBlock3> Unknown8 { get; set; }
			[TagElement]
			public List<TagBlock4> Unknown14 { get; set; }
			[TagElement]
			public List<TagBlock16> Unknown20 { get; set; }

			[TagStructure(Size = 0x4)]
			public class TagBlock3
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x54)]
			public class TagBlock4
			{
				[TagElement]
				public List<TagBlock5> Unknown0 { get; set; }
				[TagElement]
				public List<TagBlock8> UnknownC { get; set; }
				[TagElement]
				public List<TagBlock11> Unknown18 { get; set; }
				[TagElement]
				public List<TagBlock12> Unknown24 { get; set; }
				[TagElement]
				public List<TagBlock13> Unknown30 { get; set; }
				[TagElement]
				public List<TagBlock14> Unknown3C { get; set; }
				[TagElement]
				public List<TagBlock15> Unknown48 { get; set; }

				[TagStructure(Size = 0xC)]
				public class TagBlock5
				{
					[TagElement]
					public List<TagBlock6> Unknown0 { get; set; }

					[TagStructure(Size = 0xC)]
					public class TagBlock6
					{
						[TagElement]
						public List<TagBlock7> Unknown0 { get; set; }

						[TagStructure(Size = 0x4)]
						public class TagBlock7
						{
							[TagElement]
							public int Unknown0 { get; set; }
						}
					}
				}

				[TagStructure(Size = 0xC)]
				public class TagBlock8
				{
					[TagElement]
					public List<TagBlock9> Unknown0 { get; set; }

					[TagStructure(Size = 0xC)]
					public class TagBlock9
					{
						[TagElement]
						public List<TagBlock10> Unknown0 { get; set; }

						[TagStructure(Size = 0x4)]
						public class TagBlock10
						{
							[TagElement]
							public int Unknown0 { get; set; }
						}
					}
				}

				[TagStructure(Size = 0x1)]
				public class TagBlock11
				{
					[TagElement]
					public byte Unknown0 { get; set; }
				}

				[TagStructure(Size = 0x1)]
				public class TagBlock12
				{
					[TagElement]
					public byte Unknown0 { get; set; }
				}

				[TagStructure(Size = 0x4)]
				public class TagBlock13
				{
					[TagElement]
					public int Unknown0 { get; set; }
				}

				[TagStructure(Size = 0x4)]
				public class TagBlock14
				{
					[TagElement]
					public int Unknown0 { get; set; }
				}

				[TagStructure(Size = 0xC)]
				public class TagBlock15
				{
					[TagElement]
					public int Unknown0 { get; set; }
					[TagElement]
					public int Unknown4 { get; set; }
					[TagElement]
					public int Unknown8 { get; set; }
				}
			}

			[TagStructure(Size = 0x18)]
			public class TagBlock16
			{
				[TagElement]
				public List<TagBlock17> Unknown0 { get; set; }
				[TagElement]
				public List<TagBlock18> UnknownC { get; set; }

				[TagStructure(Size = 0xC)]
				public class TagBlock17
				{
					[TagElement]
					public int Unknown0 { get; set; }
					[TagElement]
					public int Unknown4 { get; set; }
					[TagElement]
					public int Unknown8 { get; set; }
				}

				[TagStructure(Size = 0x4)]
				public class TagBlock18
				{
					[TagElement]
					public int Unknown0 { get; set; }
				}
			}
		}

		[TagStructure(Size = 0x64)]
		public class TagBlock19
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public List<TagBlock20> Unknown10 { get; set; }
			[TagElement]
			public List<TagBlock21> Unknown1C { get; set; }
			[TagElement]
			public List<TagBlock22> Unknown28 { get; set; }
			[TagElement]
			public List<TagBlock23> Unknown34 { get; set; }
			[TagElement]
			public List<TagBlock24> Unknown40 { get; set; }
			[TagElement]
			public List<TagBlock25> Unknown4C { get; set; }
			[TagElement]
			public List<TagBlock26> Unknown58 { get; set; }

			[TagStructure(Size = 0x4)]
			public class TagBlock20
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock21
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock22
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x1)]
			public class TagBlock23
			{
				[TagElement]
				public byte Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x8)]
			public class TagBlock24
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
			}

			[TagStructure(Size = 0x8)]
			public class TagBlock25
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
			}

			[TagStructure(Size = 0x2)]
			public class TagBlock26
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}
		}

		[TagStructure(Size = 0x24)]
		public class TagBlock27
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
		}

		[TagStructure(Size = 0x24)]
		public class TagBlock28
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
		}

		[TagStructure(Size = 0xB8)]
		public class TagBlock29
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
			[TagElement]
			public int Unknown8C { get; set; }
			[TagElement]
			public int Unknown90 { get; set; }
			[TagElement]
			public int Unknown94 { get; set; }
			[TagElement]
			public int Unknown98 { get; set; }
			[TagElement]
			public int Unknown9C { get; set; }
			[TagElement]
			public int UnknownA0 { get; set; }
			[TagElement]
			public int UnknownA4 { get; set; }
			[TagElement]
			public int UnknownA8 { get; set; }
			[TagElement]
			public int UnknownAC { get; set; }
			[TagElement]
			public int UnknownB0 { get; set; }
			[TagElement]
			public int UnknownB4 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock30
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x78)]
		public class TagBlock31
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock32
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0xAC)]
		public class TagBlock33
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
			[TagElement]
			public int Unknown8C { get; set; }
			[TagElement]
			public int Unknown90 { get; set; }
			[TagElement]
			public int Unknown94 { get; set; }
			[TagElement]
			public int Unknown98 { get; set; }
			[TagElement]
			public int Unknown9C { get; set; }
			[TagElement]
			public int UnknownA0 { get; set; }
			[TagElement]
			public int UnknownA4 { get; set; }
			[TagElement]
			public int UnknownA8 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock34
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x8C)]
		public class TagBlock35
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock36
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0xAC)]
		public class TagBlock37
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
			[TagElement]
			public int Unknown8C { get; set; }
			[TagElement]
			public int Unknown90 { get; set; }
			[TagElement]
			public int Unknown94 { get; set; }
			[TagElement]
			public int Unknown98 { get; set; }
			[TagElement]
			public int Unknown9C { get; set; }
			[TagElement]
			public int UnknownA0 { get; set; }
			[TagElement]
			public int UnknownA4 { get; set; }
			[TagElement]
			public int UnknownA8 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock38
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x2C)]
		public class TagBlock39
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
		}

		[TagStructure(Size = 0x8C)]
		public class TagBlock40
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock41
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x80)]
		public class TagBlock42
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock43
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x70)]
		public class TagBlock44
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock45
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x54)]
		public class TagBlock46
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock47
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x8C)]
		public class TagBlock48
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock49
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock50
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock51
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock52
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock53
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock54
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock55
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock56
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0xC)]
		public class TagBlock57
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
		}

		[TagStructure(Size = 0x60)]
		public class TagBlock58
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public HaloTag Unknown28 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
		}

		[TagStructure(Size = 0x1C)]
		public class TagBlock59
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
		}

		[TagStructure(Size = 0x7C)]
		public class TagBlock60
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public List<TagBlock61> Unknown44 { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }

			[TagStructure(Size = 0x14)]
			public class TagBlock61
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
			}
		}

		[TagStructure(Size = 0x14)]
		public class TagBlock62
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
		}

		[TagStructure(Size = 0x14)]
		public class TagBlock63
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
		}

		[TagStructure(Size = 0x24)]
		public class TagBlock64
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
		}

		[TagStructure(Size = 0x10)]
		public class TagBlock65
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x6C)]
		public class TagBlock66
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public List<TagBlock67> Unknown54 { get; set; }
			[TagElement]
			public List<TagBlock68> Unknown60 { get; set; }

			[TagStructure(Size = 0x18)]
			public class TagBlock67
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
			}

			[TagStructure(Size = 0xC)]
			public class TagBlock68
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
			}
		}

		[TagStructure(Size = 0x34)]
		public class TagBlock69
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public List<TagBlock70> Unknown28 { get; set; }

			[TagStructure(Size = 0x24)]
			public class TagBlock70
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
			}
		}

		[TagStructure(Size = 0x28)]
		public class TagBlock71
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
		}

		[TagStructure(Size = 0x10)]
		public class TagBlock72
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x84)]
		public class TagBlock73
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
		}

		[TagStructure(Size = 0x20)]
		public class TagBlock74
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
		}

		[TagStructure(Size = 0x40)]
		public class TagBlock75
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
		}

		[TagStructure(Size = 0x28)]
		public class TagBlock76
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public List<TagBlock77> Unknown4 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public List<TagBlock78> Unknown1C { get; set; }

			[TagStructure(Size = 0x10)]
			public class TagBlock77
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
			}

			[TagStructure(Size = 0x16C)]
			public class TagBlock78
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
			}
		}

		[TagStructure(Size = 0x2)]
		public class TagBlock79
		{
			[TagElement]
			public short Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x2)]
		public class TagBlock80
		{
			[TagElement]
			public short Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x18)]
		public class TagBlock81
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
		}

		[TagStructure(Size = 0x58)]
		public class TagBlock82
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown4 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public HaloTag Unknown20 { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
		}

		[TagStructure(Size = 0x78)]
		public class TagBlock83
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
		}

		[TagStructure(Size = 0x8)]
		public class TagBlock84
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock85
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown4 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x74)]
		public class TagBlock86
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public List<TagBlock87> Unknown10 { get; set; }
			[TagElement]
			public List<TagBlock88> Unknown1C { get; set; }
			[TagElement]
			public List<TagBlock89> Unknown28 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public List<TagBlock90> Unknown38 { get; set; }
			[TagElement]
			public List<TagBlock91> Unknown44 { get; set; }
			[TagElement]
			public List<TagBlock92> Unknown50 { get; set; }
			[TagElement]
			public List<TagBlock93> Unknown5C { get; set; }
			[TagElement]
			public List<TagBlock94> Unknown68 { get; set; }

			[TagStructure(Size = 0x4)]
			public class TagBlock87
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock88
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock89
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0xC)]
			public class TagBlock90
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock91
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock92
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock93
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock94
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}
		}

		[TagStructure(Size = 0x6C)]
		public class TagBlock95
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public List<TagBlock96> Unknown54 { get; set; }
			[TagElement]
			public List<TagBlock97> Unknown60 { get; set; }

			[TagStructure(Size = 0x30)]
			public class TagBlock96
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
			}

			[TagStructure(Size = 0x30)]
			public class TagBlock97
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
			}
		}

		[TagStructure(Size = 0xB4)]
		public class TagBlock98
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public List<TagBlock99> Unknown24 { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
			[TagElement]
			public int Unknown8C { get; set; }
			[TagElement]
			public int Unknown90 { get; set; }
			[TagElement]
			public int Unknown94 { get; set; }
			[TagElement]
			public int Unknown98 { get; set; }
			[TagElement]
			public int Unknown9C { get; set; }
			[TagElement]
			public int UnknownA0 { get; set; }
			[TagElement]
			public int UnknownA4 { get; set; }
			[TagElement]
			public int UnknownA8 { get; set; }
			[TagElement]
			public int UnknownAC { get; set; }
			[TagElement]
			public int UnknownB0 { get; set; }

			[TagStructure(Size = 0x1C)]
			public class TagBlock99
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public List<TagBlock100> Unknown4 { get; set; }
				[TagElement]
				public List<TagBlock101> Unknown10 { get; set; }

				[TagStructure(Size = 0x1)]
				public class TagBlock100
				{
					[TagElement]
					public byte Unknown0 { get; set; }
				}

				[TagStructure(Size = 0x2)]
				public class TagBlock101
				{
					[TagElement]
					public short Unknown0 { get; set; }
				}
			}
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock102
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x10)]
		public class TagBlock103
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x48)]
		public class TagBlock104
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public List<TagBlock105> Unknown10 { get; set; }
			[TagElement]
			public List<TagBlock106> Unknown1C { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }

			[TagStructure(Size = 0x24)]
			public class TagBlock105
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
			}

			[TagStructure(Size = 0x10)]
			public class TagBlock106
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
			}
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock107
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x104)]
		public class TagBlock108
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
			[TagElement]
			public int Unknown8C { get; set; }
			[TagElement]
			public int Unknown90 { get; set; }
			[TagElement]
			public int Unknown94 { get; set; }
			[TagElement]
			public int Unknown98 { get; set; }
			[TagElement]
			public int Unknown9C { get; set; }
			[TagElement]
			public int UnknownA0 { get; set; }
			[TagElement]
			public int UnknownA4 { get; set; }
			[TagElement]
			public int UnknownA8 { get; set; }
			[TagElement]
			public int UnknownAC { get; set; }
			[TagElement]
			public int UnknownB0 { get; set; }
			[TagElement]
			public int UnknownB4 { get; set; }
			[TagElement]
			public int UnknownB8 { get; set; }
			[TagElement]
			public int UnknownBC { get; set; }
			[TagElement]
			public int UnknownC0 { get; set; }
			[TagElement]
			public int UnknownC4 { get; set; }
			[TagElement]
			public int UnknownC8 { get; set; }
			[TagElement]
			public int UnknownCC { get; set; }
			[TagElement]
			public int UnknownD0 { get; set; }
			[TagElement]
			public int UnknownD4 { get; set; }
			[TagElement]
			public int UnknownD8 { get; set; }
			[TagElement]
			public int UnknownDC { get; set; }
			[TagElement]
			public int UnknownE0 { get; set; }
			[TagElement]
			public int UnknownE4 { get; set; }
			[TagElement]
			public int UnknownE8 { get; set; }
			[TagElement]
			public int UnknownEC { get; set; }
			[TagElement]
			public int UnknownF0 { get; set; }
			[TagElement]
			public int UnknownF4 { get; set; }
			[TagElement]
			public int UnknownF8 { get; set; }
			[TagElement]
			public int UnknownFC { get; set; }
			[TagElement]
			public int Unknown100 { get; set; }
		}

		[TagStructure(Size = 0x4)]
		public class TagBlock109
		{
			[TagElement]
			public int Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x18)]
		public class TagBlock110
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
		}

		[TagStructure(Size = 0x10)]
		public class TagBlock111
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
		}

		[TagStructure(Size = 0x14)]
		public class TagBlock112
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
		}

		[TagStructure(Size = 0x10)]
		public class TagBlock113
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
		}
	}
}
