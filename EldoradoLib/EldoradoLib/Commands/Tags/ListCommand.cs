﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EldoradoLib.Commands.Tags
{
	class ListCommand : Command
	{
		private readonly TagCache _cache;

		public ListCommand(TagCache cache) : base(
			CommandFlags.Inherit,

			"list",
			"List tags",
			
			"list [class...]",
			
			"class is a 4-character string identifying the tag class, e.g. \"proj\".\n" +
			"Multiple classes to list tags from can be specified.\n" +
			"Tags which inherit from the given classes will also be printed.\n" +
			"If no class is specified, all tags in the file will be listed.")
		{
			_cache = cache;
		}

		public override bool Execute(List<string> args)
		{
			var searchClasses = ArgumentParser.ParseTagClasses(_cache, args);
			if (searchClasses == null)
				return false;

			HaloTag[] tags;
			if (args.Count > 0)
				tags = _cache.Tags.FindAllByClasses(searchClasses).ToArray();
			else
				tags = _cache.Tags.Where(t => t != null).ToArray();

			if (tags.Length == 0)
			{
				Console.Error.WriteLine("No tags found.");
				return true;
			}
			TagPrinter.PrintTagsShort(tags);
			return true;
		}
	}
}
