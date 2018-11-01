using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoRenamer
{
	class RenamingStringParser
	{
		public ExifManager Exif;
		public string ParseString(string text, string original)
		{
			Image image = Exif.images[original];
			int start_count = text.Split('<').Length;
			int end_count = text.Split('>').Length;
			if (start_count < end_count)
			{
				return "Invalid Name: " + (end_count - start_count).ToString() + " End Tag(s) (>) without start tag (<)";
			}
			else if (start_count > end_count)
			{
				return "Invalid Name: " + (start_count - end_count).ToString() + " Start Tag(s) (<) without End Tag (>)";
			}
			string Name = "";
			string[] tokens = text.Split(new char[]{ '<', '>'});
			for (int i = 0; i < tokens.Length; i++)
			{
				if (tokens[i] == "<")
				{
					i++;    // go past the open tag to the propertizzle name
					Name += Exif.ParseProperty(image.GetPropertyItem(Exif.ExifPropertyIdsByName[tokens[i]]));
					// find the propertizzle

					i++;	// skip past the end tag
				}
				else
				{
					Name += tokens[i];
				}
			}

			return Name;
		}
	}
}
