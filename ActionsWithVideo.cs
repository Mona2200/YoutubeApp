// <copyright file="ActionsWithVideo.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace YoutubeApp
{
   using System;

   public class ActionsWithVideo : Command
   {

      YoutubeReceiver receiver;

      public ActionsWithVideo(YoutubeReceiver _receiver)
      {
         receiver = _receiver;
      }

      public ActionsWithVideo()
      {
         throw new Exception("Недостаточно аргументов в методе ActionsWithVideo()");
      }

      public override void Run()
      {
         var video = receiver.GetInfo();
         Console.WriteLine($"{video.Result.Title}\n\n{video.Result.Description}\n");
      }

      public override void Cancel()
      {
         receiver.Explode();
         Console.WriteLine("Скачивание видео запущено");
      }
   }
}
