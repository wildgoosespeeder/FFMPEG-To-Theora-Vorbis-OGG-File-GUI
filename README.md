# FFMPEG-To-Theora-Vorbis-OGG-File-GUI
Create OGG Video Container Files From Non-OGG Sources

This app is designed to be portable. I won't subject users to use installer programs. I rather start off as trustworthy. Just excract the exe wherever you desire, preferably on your desktop.

It's very easy to use. Complexity will change later but I will try to keep it easy.

You can change quality settings, but these are the recommended values:
Theora quality: 7
Vorbis quality: 5
These values can be changed from 0-10, 0 meaning high lossy compression and 10 meaning minimal lossy compression. Use these settings to tweak your desired file size.

Requires FFMPEG exe from this website, preferrably a nightly build:
* http://ffmpeg.zeranoe.com/builds

Planned features, from highest priority to lowest priority:
* Resizing dimensions for each file.
* Change frame rate for each file.
* Trim times for each file.
* Volume change for each file.
* Customize file names for each file.
* Save settings the user changed from default.
* Keep it only running one instance.
* Integrate CMD information into the GUI, such as how much of the conversion is complete, errors ffmpeg returns, etc.
* Create OGA (Vorbis) only files.
* WebM output; VP8+Vorbis and VP9+Opus
* Incorperate other HTML5 proposed formats for \<audio\> and \<video\> tags.
* Incorperate all of Xiph.Org's codecs.

Features not a priority:
* Multithreaded conversion (converting more than one file at a time).

FFmpeg
* By Fabrice Bellard, FFmpeg Team
* https://www.ffmpeg.org

OGG, Vorbis, Opus, and Theora
* By Xiph.Org Foundation
* https://www.xiph.org

Icon:
I'm not creative when it comes to icons, so I mashed-up the following:
* https://commons.wikimedia.org/wiki/File:FFmpeg_Logo_new.svg
* https://commons.wikimedia.org/wiki/File:Xiph.Org_logo_square.svg
