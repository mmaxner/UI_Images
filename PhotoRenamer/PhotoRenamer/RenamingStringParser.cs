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
			string extension = original.Substring(original.LastIndexOf('.'), original.Length - original.LastIndexOf('.'));
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

			while (text.IndexOf('<') >= 0)
			{
				string propertizzle = text.Substring(text.IndexOf('<'), text.IndexOf('>') - text.IndexOf('<') + 1);
				string propertizzleName = propertizzle.Substring(1, propertizzle.Length - 2);
				try
				{
					string propertizzleValue = Exif.ParseProperty(image.GetPropertyItem(Exif.ExifPropertyIdsByName[propertizzleName]));
					text = text.Replace(propertizzle, propertizzleValue);
				}
				catch (Exception NotFoundEx)
				{
					text =  text.Replace(propertizzle, "Value Not Found");
				}
				
			}
			return (text + extension).Replace("\0", "" ) + '\0';
		}
	}
}
