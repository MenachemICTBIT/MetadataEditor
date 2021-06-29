# MetadataEditor

This solution is not working fully.

This solution uses WinForms, C#, and .Net framework.

It allows you to specify the directory of photos and the directory containing the flight data and will trigger an action when you click 'Go!', however, accessing and writing EXIF metadata is not working.

There are many C# libraries that allow reading EXIF data pretty easily, but I could not find one that allows writing EXIF data. It looks like bit operations are required, although I'm not positive.
UPDATE: I just found a library that seems to provide access to writing EXIF data too. 
The documentation is here `https://www.codeproject.com/Articles/5251929/CompactExifLib-Access-to-EXIF-Tags-in-JPEG-TIFF-an` 
The library can be downloaded via this link `https://www.codeproject.com/KB/Articles/5251929/ExifData_1.6.zip` (it's the solution named 'Test_ExifData.sln').


Here are several links that provided useful during my research.

http://www.thevalvepage.com/swmonkey/2013/12/23/exif-tags-in-c/
https://exiftool.org/TagNames/index.html
https://exiftool.org/TagNames/EXIF.html
https://exiftool.org/
https://social.msdn.microsoft.com/Forums/en-US/71d8de37-f52d-4faa-887a-793f8041110a/managing-general-exif-info-with-imagesetpropertyitem?forum=netfxbcl
https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-read-image-metadata?view=netframeworkdesktop-4.8
https://docs.microsoft.com/en-us/dotnet/api/system.drawing.imaging.propertyitem.id?view=net-5.0




