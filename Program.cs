// <copyright file="Program.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace YoutubeApp
{
   class Program
   {
      static void Main()
      {
         var sender = new YoutubeSender();
         var receiver = new YoutubeReceiver("https://www.youtube.com/watch?v=CvBfHwUxHIk");
         sender.SetCommand(new ActionsWithVideo(receiver));
         sender.GetInfo();
         sender.Explode();
      }
   }
}
