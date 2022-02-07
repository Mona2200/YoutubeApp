// <copyright file="YoutubeSender.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace YoutubeApp
{
   class YoutubeSender
   {
      Command command;

      public void SetCommand(Command _command)
      {
         command = _command;
      }

      public void GetInfo()
      {
         command.Run();
      }

      public void Explode()
      {
         command.Cancel();
      }
   }
}
