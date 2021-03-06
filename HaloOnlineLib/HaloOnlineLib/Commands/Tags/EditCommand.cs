﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Commands.Bitm;
using HaloOnlineLib.Commands.Hlmt;
using HaloOnlineLib.Commands.Unic;
using HaloOnlineLib.Commands.Vfsl;
using HaloOnlineLib.Serialization;
using HaloOnlineLib.TagStructures;

namespace HaloOnlineLib.Commands.Tags
{
	class EditCommand : Command
	{
		private readonly CommandContextStack _stack;
		private readonly TagCache _cache;
		private readonly FileInfo _fileInfo;
		private readonly StringIdCache _stringIds;

		public EditCommand(CommandContextStack stack, TagCache cache, FileInfo fileInfo, StringIdCache stringIds) : base(
			CommandFlags.None,

			"edit",
			"Edit tag-specific data",

			"edit <tag index>",

			"If the tag contains data which is supported by this program,\n" +
			"this command will make special tag-specific commands available\n" +
			"which can be used to edit or view the data in the tag.\n" +
			"\n" +
			"Currently-supported tag types: bitm, hlmt, unic, vfsl")
		{
			_stack = stack;
			_cache = cache;
			_fileInfo = fileInfo;
			_stringIds = stringIds;
		}

		public override bool Execute(List<string> args)
		{
			if (args.Count != 1)
				return false;
			var tag = ArgumentParser.ParseTagIndex(_cache, args[0]);
			if (tag == null)
				return false;
			var oldContext = _stack.Context;
			switch (tag.Class.ToString())
			{
				case "vfsl":
					EditVfslTag(tag);
					break;
				case "unic":
					EditUnicTag(tag);
					break;
				case "bitm":
					EditBitmTag(tag);
					break;
				case "hlmt":
					EditHlmtTag(tag);
					break;
				default:
					Console.Error.WriteLine("Tag type \"" + tag.Class + "\" is not supported.");
					return true;
			}
			Console.WriteLine("Tag {0:X8}.{1} has been opened for editing.", tag.Index, tag.Class);
			Console.WriteLine("New commands are now available. Enter \"help\" to view them.");
			Console.WriteLine("Use \"exit\" to return to {0}.", oldContext.Name);
			return true;
		}

		private void EditVfslTag(HaloTag tag)
		{
			VFilesList vfsl;
			using (var stream = _fileInfo.OpenRead())
				vfsl = TagDeserializer.Deserialize<VFilesList>(new TagSerializationContext(stream, _cache, tag));
			var context = VfslContextFactory.Create(_stack.Context, _fileInfo, _cache, tag, vfsl);
			_stack.Push(context);
		}

		private void EditUnicTag(HaloTag tag)
		{
			MultilingualUnicodeStringList unic;
			using (var stream = _fileInfo.OpenRead())
				unic = TagDeserializer.Deserialize<MultilingualUnicodeStringList>(new TagSerializationContext(stream, _cache, tag));
			var context = UnicContextFactory.Create(_stack.Context, _fileInfo, _cache, tag, unic, _stringIds);
			_stack.Push(context);
		}

		private void EditBitmTag(HaloTag tag)
		{
			Bitmap bitmap;
			using (var stream = _fileInfo.OpenRead())
				bitmap = TagDeserializer.Deserialize<Bitmap>(new TagSerializationContext(stream, _cache, tag));
			var context = BitmContextFactory.Create(_stack.Context, _fileInfo, _cache, tag, bitmap);
			_stack.Push(context);
		}

		private void EditHlmtTag(HaloTag tag)
		{
			Model model;
			using (var stream = _fileInfo.OpenRead())
				model = TagDeserializer.Deserialize<Model>(new TagSerializationContext(stream, _cache, tag));
			var context = HlmtContextFactory.Create(_stack.Context, _fileInfo, _cache, _stringIds, tag, model);
			_stack.Push(context);
		}
	}
}
