﻿using System.IO;
using HaloOnlineLib.Commands.Core;

namespace HaloOnlineLib.Commands.Tags
{
	static class TagCacheContextFactory
	{
		public static CommandContext Create(CommandContextStack stack, TagCache cache, FileInfo fileInfo, StringIdCache stringIds)
		{
			var context = new CommandContext(null, fileInfo.Name);
			context.AddCommand(new HelpCommand(stack));
			context.AddCommand(new DependencyCommand(cache, fileInfo));
			context.AddCommand(new FixupCommand(cache, fileInfo));
			context.AddCommand(new ExtractCommand(cache, fileInfo));
			context.AddCommand(new ImportCommand(cache, fileInfo));
			context.AddCommand(new InfoCommand(cache));
			context.AddCommand(new InsertCommand(cache, fileInfo));
			context.AddCommand(new ListCommand(cache));
			context.AddCommand(new MapCommand());
			context.AddCommand(new EditCommand(stack, cache, fileInfo, stringIds));
			context.AddCommand(new DuplicateTagCommand(cache, fileInfo));
			context.AddCommand(new AddressCommand());
			context.AddCommand(new ExtractBitmapsCommand(cache, fileInfo));
			context.AddCommand(new ResourceDataCommand());
			context.AddCommand(new TagBlockCommand(cache, fileInfo));
			if (stringIds != null)
			{
				context.AddCommand(new StringIdCommand(stringIds));
				context.AddCommand(new ListStringsCommand(cache, fileInfo, stringIds));
				context.AddCommand(new GenerateLayoutsCommand(cache, fileInfo, stringIds));
			}
			return context;
		}
	}
}
